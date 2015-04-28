using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace ReportConnectionChanger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void button1_Click_1(object sender, EventArgs e) 
        {

            object misValue = System.Reflection.Missing.Value;

            bool checkWB = checkExcelWorkBook(folderDir.Text);
            if (checkWB)
            {
                string[] fileNames = Directory.GetFiles(folderDir.Text);
                int i = 0;
                MessageBox.Show("Repointer starting");
                do
                {
                    Excel.Application xlApp = new Excel.Application();
                    Excel.Workbook xlWorkBook = xlApp.Workbooks.Open(fileNames[i], 0, false, 5, "", "", true, Microsoft.Office.Interop.Excel.XlPlatform.xlWindows, "\t", true, false, 0, true, 1, 0);
                    
                    foreach (Excel.WorkbookConnection wc in xlWorkBook.Connections)
                    {
                        var conn = xlWorkBook.Connections.Item(1);
                        string modText = conn.OLEDBConnection.Connection;
                        string nameConnection = connName.Text; 

                        try
                        {
                            if (nameConnection == null || nameConnection.Length == 0)
                            {
                                wc.Name = wc.Name;
                            }
                            else
                            {
                                wc.Name = connName.Text;
                            }
                            modText = Regex.Replace(modText, "Data Source=" + origConn.Text, "Data Source=" + newConnString.Text);
                            conn.OLEDBConnection.Connection = modText;
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("Exception encountered" + e1.StackTrace);
                        }
                    }

                    xlWorkBook.Close(true, misValue, misValue);
                    xlApp.Quit();
                    releaseObject(xlWorkBook);
                    releaseObject(xlApp);
                    i++;
                
                } while (i < fileNames.Length);
                MessageBox.Show("All excel changes are complete!");
            }
            else
                MessageBox.Show("Please enter a valid/non empty folder directory");
        }

        private bool checkExcelWorkBook(string folderDir) 
        {
            try
            {
                if (folderDir == null || folderDir.Length == 0)
                {
                    MessageBox.Show("Please enter a value for the folder directory");
                    return false;
                }
                else
                {
                    string[] files = System.IO.Directory.GetFiles(folderDir);
                    if (files.Length == 0)
                    {
                        MessageBox.Show("Please check that this is not an empty folder");
                        return false;
                    }
                    else
                        return true; 
                }
            }
            catch (DirectoryNotFoundException e)
            {
                MessageBox.Show("Please check that this is a valid directory");
                return false;
            }

        }

        private void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Unable to release the Object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
