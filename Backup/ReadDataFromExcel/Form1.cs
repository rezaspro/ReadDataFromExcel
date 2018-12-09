using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using OfficeOpenXml;

namespace ReadDataFromExcel
{
    public partial class ReadFromExcelWF : Form
    {
        private string excelFilePath = "";
        private FileInfo excelFile;
        private ExcelPackage excelPackage;
        private List<string> sheetList;

        int rowNo = 0;
        int columnNo = 0;
        public ReadFromExcelWF()
        {
            InitializeComponent();
            // excelFile = new FileInfo(excelFilePath);
            excelPackage = new ExcelPackage(excelFile);
            sheetList = new List<string>();
        }



        private void buttonEdit1_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            DialogResult dlg = openFileDialog1.ShowDialog();

            if (dlg == DialogResult.OK)
            {
                excelFilePath = openFileDialog1.FileName;
                filePath.Text = excelFilePath;
                //responsible for get excel file
                excelFile = new FileInfo(excelFilePath);

                //responsible excel file formating 
                excelPackage = new ExcelPackage(excelFile);

                //
                sheetList = new List<string>();


                foreach (ExcelWorksheet excelWorksheet in excelPackage.Workbook.Worksheets)
                {
                    sheetList.Add(excelWorksheet.Name);
                }

                lueSheetName.Properties.DataSource = sheetList;
                lueSheetName.EditValue = sheetList[0];

            }

        }

        private void lueSheetName_EditValueChanged(object sender, EventArgs e)
        {
            string selectedSheetName = lueSheetName.EditValue.ToString();
            var excelSheet = excelPackage.Workbook.Worksheets[selectedSheetName];


            rowNo = excelSheet.Dimension.End.Row;
            columnNo = excelSheet.Dimension.End.Column;

            List<string> columnList = new List<string>();

            for (int i = 1; i <= 1; i++)
            {
                for (int j = 1; j <= columnNo; j++)
                {
                    columnList.Add(excelSheet.Cells[i, j].Value.ToString());
                }
            }

            lueIdentification.Properties.DataSource = columnList;
            lueIdentification.EditValue = (string)columnList[0];
            lueMark.Properties.DataSource = columnList;
            lueMark.EditValue = (string)columnList[0];

        }

        private void btnGenerateView_Click(object sender, EventArgs e)
        {
            string selectedSheetName = lueSheetName.EditValue.ToString();
            var excelSheet = excelPackage.Workbook.Worksheets[selectedSheetName];
            //var rollColumn = lueIdentification.EditValue;
            //var markColumn = lueMark.EditValue;

            var rollColumn = "A";
            var markColumn = "B";
            List<ExcelStudent> excelStudentList = new List<ExcelStudent>();

            string cellIndex = "";

          

            for (int i = 2; i <= rowNo; i++)
            {
                ExcelStudent excelStudentObj = new ExcelStudent();
                for (int j = 1; j <= columnNo; j++)
                {
                    cellIndex = rollColumn + i.ToString();
                    excelStudentObj.Roll = excelSheet.Cells[cellIndex].Value.ToString();
                    cellIndex = markColumn + i.ToString();
                    excelStudentObj.Mark = excelSheet.Cells[cellIndex].Value.ToString();
                        //string cellVal = excelSheet.Cells[i, j].Value.ToString();
                        //excelStudentObj.Roll = cellVal;
                        //excelStudentObj.Mark = cellVal;
                }


                excelStudentList.Add(excelStudentObj);
            }

            excelStudentBindingSource.DataSource = excelStudentList;
            gridControl1.RefreshDataSource();

        }


    }
}
