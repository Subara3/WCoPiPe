using GlobalHotKey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.Windows.Input;
using WCoPiPe.utility;
using static WCoPiPe.utility.ValiableEntityUtility;

namespace WCoPiPe


{

    public partial class MainForm : Form
    {
        public static string GetDescription(Enum value)
        {
            FieldInfo fieldInfo = value.GetType().GetField(value.ToString());

            DescriptionAttribute[] attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

            if (attributes != null && attributes.Length > 0)
            {
                return attributes[0].Description;
            }
            else
            {
                return value.ToString();
            }
        }

        public class TabPageControls
        {
            public Label LabelY { get; set; }
            public NumericUpDown NumericUpDownY { get; set; }
            public Label LabelX { get; set; }
            public NumericUpDown NumericUpDownX { get; set; }
            public Button CalculateButton { get; set; }
        }

        HotKeyManager hotKeyManager = new HotKeyManager();

        HotKey hotKey;

        Dictionary<TabPage, TabPageControls> tabPageControls = new Dictionary<TabPage, TabPageControls>();

        public MainForm()
        {
            InitializeComponent();
            hotKey = hotKeyManager.Register(Key.Q,System.Windows.Input.ModifierKeys.Control);
            hotKeyManager.KeyPressed += (sender, args) =>
            {
                this.Invoke(new MethodInvoker(delegate
                {
                    this.Show();
                    this.WindowState = FormWindowState.Normal;
                    this.Activate();
                }));
            };
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            string extraLabelContent = @"(X = 0:マップX座標（通常[1マスを1と換算]）
1:マップY座標（通常）
2:マップX座標(精密[0.5マスを1換算]）
3:マップY座標（精密）
4:イベントの高さ（ピクセル数）
5:イベントの影番号
6:イベントの方向（1-9）
7:ピクセル補正値X
8:ピクセル補正値Y
9:イベントのキャラチップ画像[文字列] )";

            int labelXOffset = 20;
            int labelYOffset = 20;
            int numericUpDownXOffset = 130;
            int numericUpDownWidth = 70;

            foreach (var item in ValiableEntityUtility.EntityTypeLabels)
            {
                var entityType = item.Key;
                var (label1, label2) = item.Value;

                var entityTypeDescription = GetDescription(entityType);

                var tabPage = new TabPage(entityTypeDescription)
                {
                    Text = entityTypeDescription,
                    Tag = entityType,
                };
                var controls = new TabPageControls();

                var label = new Label
                {
                    Text = ValiableEntityUtility.EntityTypeDescriptions[entityType],
                    Location = new Point(labelXOffset, labelYOffset),
                    AutoSize = true
                };
                tabPage.Controls.Add(label);

                labelYOffset += 60;

                if (!string.IsNullOrEmpty(label1))
                {
                    var labelY = new Label
                    {
                        Text = label1,
                        Location = new Point(labelXOffset, labelYOffset),
                        AutoSize = true
                    };
                    var numericUpDownY = new NumericUpDown
                    {
                        Location = new Point(numericUpDownXOffset, labelYOffset),
                        Maximum = 9999,
                        Width = numericUpDownWidth,
                        TextAlign = HorizontalAlignment.Right
                    };
                    tabPage.Controls.Add(labelY);
                    tabPage.Controls.Add(numericUpDownY);
                    controls.NumericUpDownY = numericUpDownY;

                    labelYOffset += 30;
                }
                if (!string.IsNullOrEmpty(label2))
                {
                    var labelX = new Label
                    {
                        Text = label2,
                        Location = new Point(labelXOffset, labelYOffset),
                        AutoSize = true
                    };
                    var numericUpDownX = new NumericUpDown
                    {
                        Location = new Point(numericUpDownXOffset, labelYOffset),
                        Maximum = 9999,
                        Width = numericUpDownWidth,
                        TextAlign = HorizontalAlignment.Right
                    };
                    tabPage.Controls.Add(labelX);
                    tabPage.Controls.Add(numericUpDownX);
                    controls.NumericUpDownX = numericUpDownX;

                    labelYOffset += 30;
                }

                labelYOffset = 150;

                var calculateButton = new Button
                {
                    Text = "コピペ",
                    Location = new Point(labelXOffset, labelYOffset),
                    Height = 50,
                };
                tabPage.Controls.Add(calculateButton);
                calculateButton.Click += CalculateButton_Click;

                controls.CalculateButton = calculateButton;

                if (entityType == EntityType.EventCoordinate ||
    entityType == EntityType.MainCharacterCoordinate ||
    entityType == EntityType.ThisEventCoordinate)
                {
                    var extraLabel = new Label
                    {
                        Text = extraLabelContent,
                        Location = new Point(220, 50),                        
                        AutoSize = true,
                        Font = new Font("Microsoft Sans Serif", 8) 
                };
                    tabPage.Controls.Add(extraLabel);

                }


                tabPageControls.Add(tabPage, controls);

                tabControlValiable.TabPages.Add(tabPage);

                labelYOffset = 20;
            }
        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            // 選択されているTabPageを取得します
            var selectedTabPage = tabControlValiable.SelectedTab;

            // それに対応するcontrolsを取得します
            var controls = tabPageControls[selectedTabPage];

            // エンティティタイプを取得します
            var entityType = (ValiableEntityUtility.EntityType)selectedTabPage.Tag;

            // 計算に必要なYとXを取得します
            int y = controls.NumericUpDownY != null ? (int)controls.NumericUpDownY.Value : 0;
            int x = (int)controls.NumericUpDownX.Value;

            // エンティティを作成して計算を行います
            var entity = ValiableEntityUtility.CreateEntity(entityType, y, x);
            var position = entity.CalculateValue();

            // 計算結果を表示します
            Clipboard.SetText(position.ToString());
            textBoxOutputPreview.Text = position.ToString();

        }

        private void buttonUDBOutput_Click(object sender, EventArgs e)
        {
            try
            {
                GenericDatabaseCalculateButton_Click(DatabaseEntityUtility.Database.DatabaseType.UserDatabase);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCDBOutput_Click(object sender, EventArgs e)
        {
            try
            {
                GenericDatabaseCalculateButton_Click(DatabaseEntityUtility.Database.DatabaseType.VariableDatabase);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonOutputSys_Click(object sender, EventArgs e)
        {
            try
            {
                GenericDatabaseCalculateButton_Click(DatabaseEntityUtility.Database.DatabaseType.SystemDatabase);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show(ex.Message, "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GenericDatabaseCalculateButton_Click(DatabaseEntityUtility.Database.DatabaseType type)
        {
            DatabaseEntityUtility.Database database;

            switch (type)
            {
                case DatabaseEntityUtility.Database.DatabaseType.UserDatabase:
                    database = new DatabaseEntityUtility.UserDatabase();
                    break;

                case DatabaseEntityUtility.Database.DatabaseType.VariableDatabase:
                    database = new DatabaseEntityUtility.VariableDatabase();
                    break;

                case DatabaseEntityUtility.Database.DatabaseType.SystemDatabase:
                    database = new DatabaseEntityUtility.SystemDatabase();
                    break;

                default:
                    throw new ArgumentOutOfRangeException();
            }

            // ここでnumericUpDownコントロールから値を取得します。
            database.A = (int)numericUpDownA.Value;
            database.B = (int)numericUpDownB.Value;
            database.C = (int)numericUpDownC.Value;

            int result = database.CalculateValue();

            Clipboard.SetText(result.ToString());
            textBoxOutputPreview.Text = result.ToString();
        }


        private void CloseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.notifyIcon.Dispose();
            hotKeyManager.Unregister(hotKey);
            hotKeyManager.Dispose();
            System.Windows.Forms.Application.Exit();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Program.settings.KeepRunning) // 常駐の時だけ
            {
                if (e.CloseReason == CloseReason.ApplicationExitCall)
                {
                    e.Cancel = false; // Application.Exit()が呼び出されたときはキャンセルしない
                }
                else
                {
                    e.Cancel = true; // それ以外の理由でウィンドウが閉じようとしたときはキャンセルする
                    this.WindowState = FormWindowState.Minimized;
                    this.Hide();
                    this.notifyIcon.Visible = true;
                }
            }

        }

        private void notifyIcon_MouseClick(object sender, MouseEventArgs e)
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            numericUpDownA.Value = 0;
            numericUpDownB.Value = 0;   
            numericUpDownC.Value = 0;
        }

        private void buttonGetUDB_Click(object sender, EventArgs e)
        {
            var text = $"\\udb[{numericUpDownA.Value}:{numericUpDownB.Value}:{numericUpDownC.Value}]";
            Clipboard.SetText(text);
            textBoxOutputPreview.Text= text;
        }

        private void buttonGetCDB_Click(object sender, EventArgs e) {
            var text = $"\\cdb[{numericUpDownA.Value}:{numericUpDownB.Value}:{numericUpDownC.Value}]";
            Clipboard.SetText(text);
            textBoxOutputPreview.Text = text;
        }


        private void ToolStripMenuItemSettings_Click_1(object sender, EventArgs e)
        {
            InitializeSettingForm settingForm = new InitializeSettingForm(Program.settings);
            if (settingForm.ShowDialog() == DialogResult.OK)
            {
                // OKがクリックされた場合、変更された設定を保存します。
                Program.settings = settingForm.settings;
                Program.settings.Save();
            }
        }

    }

}
