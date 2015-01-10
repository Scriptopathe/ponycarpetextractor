using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace InteractiveInterpreter
{
    static class Program
    {
        static void Write(bool[,] sqr)
        {
            System.IO.FileStream f = System.IO.File.Open("test4.txt", System.IO.FileMode.Create);
            System.IO.StreamWriter w = new System.IO.StreamWriter(f);
            w.Write(sqr.GetLength(1).ToString() + " " + sqr.GetLength(0).ToString() + "\n");
            w.WriteLine();
            for (int y = 0; y < sqr.GetLength(1); y++)
            {
                for (int x = 0; x < sqr.GetLength(0); x++)
                {
                    if(x == sqr.GetLength(0) - 1)
                        w.Write(sqr[x, y] ? "1" : "0");
                    else
                        w.Write(sqr[x, y] ? "1 " : "0 ");
                }
                if (y != sqr.GetLength(1) - 1)
                    w.WriteLine();
            }
            w.Close();
            f.Close();
        }
        static void DrawSquare(bool[,] sqr, int x, int y, int w, int h)
        {
            for (int sx = x; sx < x + w; sx++)
            {
                for (int sy = y; sy < y + h; sy++)
                {
                    sqr[sx, sy] = true;
                }
            }
        }
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool[,] sqr = new bool[10,10];
            DrawSquare(sqr, 5, 5, 1, 1);
            Write(sqr);

            ForceDot();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
        static void ForceDot()
        {
            string oldDecimalSeparator = Application.CurrentCulture.NumberFormat.NumberDecimalSeparator;
            System.Globalization.CultureInfo forceDotCulture;
            forceDotCulture = (System.Globalization.CultureInfo)Application.CurrentCulture.Clone();
            forceDotCulture.NumberFormat.NumberDecimalSeparator = ".";
            Application.CurrentCulture = forceDotCulture;
    } 
    }
}
