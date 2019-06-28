using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gardiennage
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

    }

    public static class MFiltrage
    {
        static GardiennageContainer MyDb = new GardiennageContainer();
        public static IQueryable<Gardien> Fnom(string text)
        {
            return MyDb.GardienSet.Where(p => p.Nom == text);
        }
    }
}
