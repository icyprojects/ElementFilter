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

namespace Element_Table_Creator
{
    public partial class Form1 : Form
    {
        private string tableXMLPath = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e) // Код: https://msdn.microsoft.com/ru-ru/library/system.windows.forms.openfiledialog(v=vs.110).aspx
        {
            Stream myStream = null;
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = "c:\\";
            openFileDialog1.Filter = "XML Table files (*.xml)|*.xml";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if ((myStream = openFileDialog1.OpenFile()) != null)
                    {
                        using (myStream)
                        {
                            TableLoader tbl  = new TableLoader();
                            tbl.SetXml(openFileDialog1.FileName);
                            tbl.Load(dataGridView1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not read file from disk. Original error: " + ex.Message);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "O\x2084\x2082\x2083";
        }
    }
}
