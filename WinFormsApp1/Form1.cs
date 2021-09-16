using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Collections.ObjectModel;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        static string FirstNamesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "FirstName.txt");
        static string LastNamesPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LastName.txt");
        static string sPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "save.txt");

        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            string[] NamesGenerated = File.ReadAllLines(sPath);
            foreach (var gen in NamesGenerated)
            {
                listOfNames.Items.Add(gen);
            }
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            listOfNames.Items.Clear();
            string[] FirstNames = File.ReadAllLines(FirstNamesPath);
            string[] LastNames = File.ReadAllLines(LastNamesPath);

            try
            {
                for (int i = 0; i < 300; i++)
                {
                    int FirstNameIndex = rand.Next(FirstNames.Length);
                    int LastNameIndex = rand.Next(LastNames.Length);
                    listOfNames.Items.Add((FirstNames[FirstNameIndex].ToString()) + " " + LastNames[LastNameIndex].ToString());
                    Logger.LogThisLine("Add name: " + FirstNames[FirstNameIndex] + " and last name: " + LastNames[LastNameIndex] + " to listOfNames");
                }
            }
            catch (Exception ex)
            {
                Logger.LogThisLine(ex.ToString());
            }
            generateButton.Enabled = false;
        }

        private void exportXLS_Click(object sender, EventArgs e)
        {
           
            StreamWriter SaveFile = new StreamWriter(sPath);

            try
            {
                foreach (var item in listOfNames.Items)
                {
                    SaveFile.WriteLine(item);
                }
            }
            catch(Exception ex)
            {
                Logger.LogThisLine(ex.ToString());
            }

            SaveFile.Close();
            Logger.LogThisLine("Create file save.txt with generate names");

            MessageBox.Show("Imiona i nazwiska zapisano do pliku 'save.txt' w katalogu WinFormsApp1\\WinFormsApp1\\bin\\Debug\\net5.0-windows");
        }

        private void closeApplication_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                Logger.LogThisLine("Application was closed");
            }
            catch (Exception ex)
            {
                Logger.LogThisLine(ex.ToString());
            }


        }
    }
}
