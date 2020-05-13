using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Gorsel1_Emlak_Proje
{
    static class Program
    {
        public static void ButonlarEnableAyarlama(Form f, bool enabled)
        {
            foreach (Control item in f.Controls)
            {
                if (item is Button)
                {
                    Button b = item as Button;
                    b.Enabled = enabled;
                }
                if (item is TabControl)
                {
                    TabControl t = item as TabControl;
                    foreach (Control item2 in t.Controls)
                    {
                        if (item2 is TabPage)
                        {
                            TabPage tp = item2 as TabPage;
                            foreach (Control item3 in tp.Controls)
                            {
                                if (item3 is Button)
                                {
                                    Button b = item3 as Button;
                                    b.Enabled = false;
                                }
                            }
                        }
                    }

                }
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new KullaniciGirisi());
        }
    }
}
