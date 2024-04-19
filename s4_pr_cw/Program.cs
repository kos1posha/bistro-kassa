using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace s3_pr_cw
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Restaurant ThisRestaurant;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            try
            {
                using (FileStream stream = new FileStream("save.dat", FileMode.Open))
                {
                    BinaryFormatter binaryFormatter = new BinaryFormatter();
                    ThisRestaurant = (Restaurant)binaryFormatter.Deserialize(stream);
                }
                Application.Run(new BistroKassa(ThisRestaurant));
            }
            catch
            {
                Application.Run(new BistroKassa());
            }
        }
    }
}
