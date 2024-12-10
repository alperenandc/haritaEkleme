using haritaEkleme;
using System;
using System.Windows.Forms;

namespace haritaEkleme
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1()); // Form1, ana form
        }
    }
}
