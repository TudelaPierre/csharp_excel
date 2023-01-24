using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Excel = Microsoft.Office.Interop.Excel;

namespace Excel
{
    public partial class Form1 : Form
    {
        Microsoft.Office.Interop.Excel.Application app;
        Microsoft.Office.Interop.Excel.Workbooks wbooks;
        Microsoft.Office.Interop.Excel.Workbook wbook;

        public Form1()
        {
            InitializeComponent();
        }

        private void BTN_Browse_Clickk(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Fichier Excel (*.xls;*.xlsx)|*.xls;*.xlsx";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                TB_Path.Text = ofd.FileName;
            }

        }

        private void TB_Path_TextChanged(object sender, EventArgs e) 
        {
            BTN_Open.Enabled = TB_Path.Text != "";
        }

        private void BTN_Open_Click(object sender, EventArgs e)
        {
            app = new Microsoft.Office.Interop.Excel.Application();
            wbooks = app.Workbooks;
            wbook = wbooks.Open(TB_Path.Text);
            app.Visible = true;

        }

        private void BTN_Fill_Click(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel._Worksheet wsheet = wbook.ActiveSheet;
            string from = TB_FillFrom.Text;
            string to = TB_FillTo.Text;

            int fromX = int.Parse(from.Split(',')[0]);
            int fromY = int.Parse(from.Split(',')[1]);

            int toX = int.Parse(to.Split(',')[0]);
            int toY = int.Parse(to.Split(',')[1]);

            for (int x = fromX; x < toX; x++)
            {
                for (int y = fromY; y < toY; y++)
                {
                    wsheet.Cells[x, y].Value = $"{x}+{y}={x/y}";
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
