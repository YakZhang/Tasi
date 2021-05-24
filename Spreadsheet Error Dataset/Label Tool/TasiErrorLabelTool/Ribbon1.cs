using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Office.Tools.Ribbon;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;

namespace TasiErrorLabelTool
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }
        //Error group
        string errorGroup = "";
        //Error group number
        int errorNumber = 0;
        //row number
        int row = 2;

        //column index number transfer to index letter
        public string GetColumnNameByNum(int ColumnNum, string col = "")
        {
            if (ColumnNum > 26)
            {
                int mod = ColumnNum % 26;
                int rel = ColumnNum / 26;

                if (mod == 0)
                {
                    mod = 26;
                    rel = rel - 1;
                }

                int chz = mod + 64;
                char ch = (char)chz;
                return GetColumnNameByNum(rel, (ch.ToString() + col));


            }
            else
            {
                int chz = ColumnNum + 64;
                char ch = (char)chz;
                return ch.ToString() + col;
            }
        }

        private void AddErrorCell_Clink(object sender, RibbonControlEventArgs e)
        {
            //document error cells and insert comments
            Excel.Application app = Globals.ThisAddIn.Application;
            Excel.Range cell = app.ActiveCell;
            int rowIndex = cell.Row;
            int columnIndex = cell.Column;
            String columnLetter = "";
            //get cell location
            columnLetter = GetColumnNameByNum(columnIndex);

            String cellLocation = "";
            cellLocation = columnLetter + rowIndex.ToString();

            // this.errorbox.Text = cellLocation + "," +" "+ errorGroup;
            if (errorGroup == "")
            {
                this.errorbox.Text = cellLocation + "," + " ";
            }
            else
            {
                this.errorbox.Text = errorGroup + cellLocation + "," + " ";
            }
            errorGroup = this.errorbox.Text;

            //add comments for this error cell
            if (cell.Comment == null)
            {
                cell.AddComment("Error");
            }


            //error number add
            errorNumber = errorNumber + 1;

        }
        private void AddGroup_Click(object sender, RibbonControlEventArgs e)
        {
            //get Error group news
            string spreadsheetName = Globals.ThisAddIn.Application.ActiveWorkbook.Name;
            spreadsheetName = spreadsheetName.Replace(".xlsx", "");
            spreadsheetName = spreadsheetName.Replace(".xls", "");
            string worksheetName = Globals.ThisAddIn.Application.ActiveSheet.Name;
            string ErrorCell = this.errorbox.Text;
            string addType = this.addType.Text; // The reasons for the cell is an error cell.

            // Input
            Excel.Workbook GroundTruth;
            try
            {

                GroundTruth = Globals.ThisAddIn.Application.Workbooks["GroundtruthStatistics.xlsx"];

            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Open GroundtruthStatistics.xlsx first.");
                return;
            }
            Excel.Worksheet sheet = GroundTruth.Sheets["Sheet1"];

            //String currentSheet = spreadsheetName.Replace(".xls", "") + "_" + worksheetName;
            row++;


            //Input

            sheet.Cells[row, 1].Value = spreadsheetName;
            sheet.Cells[row, 2].Value = worksheetName;
            sheet.Cells[row, 3].Value = ErrorCell;
            sheet.Cells[row, 4].value = errorNumber.ToString();
            sheet.Cells[row, 5].value = addType;




            //Error group  zero
            errorGroup = "";
            //Error group number zero
            errorNumber = 0;
            //Others zero
            this.errorbox.Text = "";
            this.addType.Text = "";






        }

        private void editBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {

        }

        private void comboBox1_TextChanged(object sender, RibbonControlEventArgs e)
        {

        }
    }
}
