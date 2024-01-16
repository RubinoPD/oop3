using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsApp1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            string connstring = @"server=localhost;userid=root;password=;database=oop";

            MySqlConnection conn = null;

            try
            {
                conn = new MySqlConnection(connstring);
                conn.Open();
                MessageBox.Show("db connected successfully!");
            } catch (Exception ex)
            {
                MessageBox.Show($"Error: {0}", ex.ToString());
            } finally
            {
                if (conn != null)
                {
                    conn.Close();
                }
            }

            
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainLoginPage());
        }
    }
}
