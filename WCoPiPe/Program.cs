using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WCoPiPe
{
    internal static class Program
    {
        public static AppSettings settings;

        /// <summary>
        /// アプリケーションのメイン エントリ ポイントです。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // 設定ファイルから設定を読み込みます。
            settings = AppSettings.Load();

            Application.Run(new MainForm());
        }
    }
}
