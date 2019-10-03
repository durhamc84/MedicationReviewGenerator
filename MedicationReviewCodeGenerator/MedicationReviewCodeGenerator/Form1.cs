using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data.Sql;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;



namespace MedicationReviewCodeGenerator
{
    public partial class MedReview : Form
    {
        public MedReview()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void ActivworkBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }


        private void Button6_Click(object sender, EventArgs e)
        {
            string doctor = null;

            switch (txtPrescriber.Text)
            {
                case "Patil":
                    doctor = "RP01";
                    break;
                case "Scribner":
                    doctor = "KWS1";
                    break;
                case "Brandt":
                    doctor = "CEB3";
                    break;
                case "Rade":
                    doctor = "NKR1";
                    break;
                case "All":
                    doctor = "RP01, KWS1, CEB3, NKR1";
                    break;
                default:
                    MessageBox.Show("Please Select a Prescriber");
                    break;
            }


            DataTable table = new DataTable();
            DataTable printTable = new DataTable();
            printTable.Columns.AddRange(new DataColumn[4] { new DataColumn("clientcode_c"), new DataColumn("staffcode_c"), new DataColumn("program_c"), new DataColumn("activitydate_d") });

            if (txtPrescriber.Text == "All")
            {
                using (SqlConnection con = new SqlConnection("Data Source = ECHOSQL\\ECHOSQL; Initial Catalog = heritage; User ID = sa; Password = "))
                {

                    using (SqlCommand cmd = new SqlCommand("select * from ar.activwork where activitydate_d between(CURRENT_TIMESTAMP - 90) and CURRENT_TIMESTAMP and staffcode_c IN('rp01','kws1','CEB3','NKR1') and program_c = @program", con))
                    {

                        cmd.Parameters.AddWithValue("@program", txtProgram.Text);
                        SqlDataAdapter ds = new SqlDataAdapter(cmd);
                        ds.Fill(table);

                    }

                }

            }
            else
            {
                using (SqlConnection con = new SqlConnection("Data Source = ECHOSQL\\ECHOSQL; Initial Catalog = heritage; User ID = sa; Password = "))
                {
                    string sqlQuery = @"select * from ar.activwork where activitydate_d between(CURRENT_TIMESTAMP - 90) and CURRENT_TIMESTAMP and staffcode_c IN(@doctor) and program_c = @program";
                    using (SqlCommand cmd = new SqlCommand(sqlQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@doctor", doctor);
                        cmd.Parameters.AddWithValue("@program", txtProgram.Text);

                        SqlDataAdapter ds = new SqlDataAdapter(cmd);
                        ds.Fill(table);

                    }
                }
            }




            int totalRows = table.Rows.Count;
            double count;
            Random pull = new Random();
            int start = 0;
            int dtIndex = pull.Next(0, table.Rows.Count);



            count = Math.Round(Convert.ToDouble(totalRows) * 0.10, MidpointRounding.AwayFromZero);

            while (start < count)
            {
                var result = table.AsEnumerable().OrderBy(r => pull.Next());
                DataRow newRow = result.First();
                string clientCode = newRow["clientcode_c"].ToString();
                string staffCode = newRow["staffcode_c"].ToString();
                string program = newRow["program_c"].ToString();
                string activityDate = newRow["activitydate_d"].ToString();
                printTable.Rows.Add(clientCode, staffCode, program, activityDate);



                start++;

            }


            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = printTable;

        }


        private void copyAlltoClipboard()
        {
            dataGridView1.SelectAll();
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            copyAlltoClipboard();
            Microsoft.Office.Interop.Excel.Application xlexcel;
            Microsoft.Office.Interop.Excel.Workbook xlWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet xlWorkSheet;
            object misValue = System.Reflection.Missing.Value;
            xlexcel = new Excel.Application();
            xlexcel.Visible = true;
            xlWorkBook = xlexcel.Workbooks.Add(misValue);
            xlWorkSheet = (Excel.Worksheet)xlWorkBook.Worksheets.get_Item(1);
            Excel.Range CR = (Excel.Range)xlWorkSheet.Cells[1, 1];
            CR.Select();
            xlWorkSheet.PasteSpecial(CR, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, true);
        }

        private void TxtProgram_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }



}

