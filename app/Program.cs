using System.Diagnostics;

namespace app
{
    class Program
    {
        [STAThread]
        static void Main()
        {
            Application.Run(new Form1());
            while (true)
            {
                if (Form1.ActiveForm == null)
                {
                    Application.Run(new Form1());
                }

            }
         

        }
    }
}