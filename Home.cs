using System;
using System.Windows.Forms;
using System.IO;
using OfficeOpenXml;

namespace ExcelDataMerger
{
    public partial class Home : Form
    {
        private string sourceFilePath, targetFilePath;
        public string sourceColumnMatch, sourceColumnTake, targetColumnMatch, targetColumnUpdate;
        public int sCM, sCT, tCM, tCU;

        public Home()
        {
            InitializeComponent();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                sourceFilePath = openFileDialog1.FileName;
                file1_name.Text = Path.GetFileName(sourceFilePath);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (openFileDialog2.ShowDialog() == DialogResult.OK)
            {
                targetFilePath = openFileDialog2.FileName;
                file2_name.Text = Path.GetFileName(targetFilePath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(sourceFilePath) || string.IsNullOrEmpty(targetFilePath))
            {
                MessageBox.Show("Please select both source and target files.");
                return;
            }

            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;

                using (var package1 = new ExcelPackage(new FileInfo(sourceFilePath)))
                {
                    if (package1.Workbook == null)
                    {
                        MessageBox.Show("Workbook could not be loaded.");
                        return;
                    }

                    if (package1.Workbook.Worksheets.Count == 0)
                    {
                        MessageBox.Show("Workbook does not contain any worksheets.");
                        return;
                    }

                    ExcelWorksheet worksheet1 = package1.Workbook.Worksheets[0];

                    using (var package2 = new ExcelPackage(new FileInfo(targetFilePath)))
                    {
                        if (package2.Workbook == null)
                        {
                            MessageBox.Show("Target workbook could not be loaded.");
                            return;
                        }

                        if (package2.Workbook.Worksheets.Count == 0)
                        {
                            MessageBox.Show("Target workbook does not contain any worksheets.");
                            return;
                        }

                        sourceColumnMatch = sColumnMatch.Text;
                        sourceColumnTake = sColumnTake.Text;
                        targetColumnMatch = tColumnMatch.Text;
                        targetColumnUpdate = tColumnUpdate.Text;

                        if (string.IsNullOrEmpty(sourceColumnMatch) || string.IsNullOrEmpty(sourceColumnTake) || string.IsNullOrEmpty(targetColumnMatch) || string.IsNullOrEmpty(targetColumnUpdate))
                        {
                            MessageBox.Show("Please enter XLS sheet column indices.");
                            return;
                        }

                        sCM = Convert.ToInt32(sourceColumnMatch);
                        sCT = Convert.ToInt32(sourceColumnTake);
                        tCM = Convert.ToInt32(targetColumnMatch);
                        tCU = Convert.ToInt32(targetColumnUpdate);

                        ExcelWorksheet worksheet2 = package2.Workbook.Worksheets[0];

                        int maxColumns1 = worksheet1.Dimension.Columns;
                        int maxColumns2 = worksheet2.Dimension.Columns;

                        if (sCM > maxColumns1 || sCT > maxColumns1 || tCM > maxColumns2 || tCU > maxColumns2)
                        {
                            MessageBox.Show("Column index out of range.");
                            return;
                        }

                        int rows1 = worksheet1.Dimension.Rows;
                        int rows2 = worksheet2.Dimension.Rows;

                        for (int row1 = 2; row1 <= rows1; row1++)
                        {
                            string productCode1 = worksheet1.Cells[row1, sCM].GetValue<string>();
                            double price1 = worksheet1.Cells[row1, sCT].GetValue<double>();

                            for (int row2 = 2; row2 <= rows2; row2++)
                            {
                                string productCode2 = worksheet2.Cells[row2, tCM].GetValue<string>();

                                if (productCode1 == productCode2)
                                {
                                    worksheet2.Cells[row2, tCU].Value = price1;
                                    break;
                                }
                            }
                        }

                        package2.Save();
                    }
                }

                MessageBox.Show("Price values updated successfully.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private TextBox GetSColumnMatch()
        {
            return sColumnMatch;
        }

       
    }
}
