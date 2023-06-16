using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCoPiPe
{
    public partial class InitializeSettingForm : Form
    {

        public AppSettings settings;

        public InitializeSettingForm(AppSettings settings)
        {
            InitializeComponent();

            this.settings = settings;
        }


        private void InitializeSettingForm_Load(object sender, EventArgs e)
        {
            checkBoxKeepRunning.Checked = settings.KeepRunning;
        }

        private void checkBoxKeepRunning_CheckedChanged(object sender, EventArgs e)
        {
            updateSettings();
        }

        private void updateSettings()
        {
            settings.KeepRunning = checkBoxKeepRunning.Checked;
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
