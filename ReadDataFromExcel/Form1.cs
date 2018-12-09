using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.Data.Filtering.Helpers;
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

        //List<ExcelStudent> excelStudentList;
        private List<BankStatement> excelBankList;
        public ReadFromExcelWF()
        {
            InitializeComponent();
            // excelFile = new FileInfo(excelFilePath);
            excelPackage = new ExcelPackage(excelFile);
            sheetList = new List<string>();
            //excelStudentList = new List<ExcelStudent>();
            excelBankList = new List<BankStatement>();
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
            lueDate.Properties.DataSource = columnList;
            lueDate.EditValue = (string)columnList[0];lueMark.Properties.DataSource = columnList;
            lueMark.EditValue = (string)columnList[1];

        }

        private void btnGenerateView_Click(object sender, EventArgs e)
        {
            excelBankList=new List<BankStatement>();
            string selectedSheetName = lueSheetName.EditValue.ToString();
            var excelSheet = excelPackage.Workbook.Worksheets[selectedSheetName];
            //var rollColumn = lueIdentification.EditValue;
            //var markColumn = lueMark.EditValue;

            //var rollColumn = "A";
            //var markColumn = "B";
            //List<ExcelStudent> excelStudentList = new List<ExcelStudent>();


            var dateColumn = "A";
            var transactionType = "B";
            var theirType = "C";
            var narrative = "D";
            var ourRef = "E";
            var transRef = "F";
            var debit = "G";
            var credit = "H";
            var balance = "I";

            string cellIndex = "";



            for (int i = 2; i <= rowNo; i++)
            {
                //ExcelStudent excelStudentObj = new ExcelStudent();
                BankStatement bankSaStatement = new BankStatement();

                for (int j = 1; j <= columnNo; j++)
                {
                    cellIndex = dateColumn + i.ToString();
                    bankSaStatement.Date = excelSheet.Cells[cellIndex].Value.ToString();
                    cellIndex = transactionType + i.ToString();

                    if (excelSheet.Cells[cellIndex].Value.ToString() == null)
                    {
                        bankSaStatement.TransactionType = "--";
                    }
                    else
                    {
                        bankSaStatement.TransactionType = excelSheet.Cells[cellIndex].Value.ToString();
                    }

                    cellIndex = theirType + i.ToString();

                    if (excelSheet.Cells[cellIndex].Text.ToString() == "")
                    {
                        bankSaStatement.TheirType = "-";
                    }
                    else
                    {
                        bankSaStatement.TheirType = excelSheet.Cells[cellIndex].Value.ToString();
                    }

                    cellIndex = narrative + i.ToString();
                    bankSaStatement.Narrative = excelSheet.Cells[cellIndex].Value.ToString();
                    cellIndex = ourRef + i.ToString();
                    bankSaStatement.OurRef = excelSheet.Cells[cellIndex].Value.ToString();
                    cellIndex = transRef + i.ToString();
                    bankSaStatement.TransRef = excelSheet.Cells[cellIndex].Value.ToString();
                    cellIndex = debit + i.ToString();
                    bankSaStatement.Debit = excelSheet.Cells[cellIndex].Value.ToString();
                    cellIndex = credit + i.ToString();
                    bankSaStatement.Credit = excelSheet.Cells[cellIndex].Value.ToString();
                    cellIndex = balance + i.ToString();
                    bankSaStatement.Balance = excelSheet.Cells[cellIndex].Value.ToString();

                    //string cellVal = excelSheet.Cells[i, j].Value.ToString();
                    //excelStudentObj.Roll = cellVal;
                    //excelStudentObj.Mark = cellVal;
                }


                excelBankList.Add(bankSaStatement);
            }

            excelStudentBindingSource.DataSource = excelBankList;
            gridControl1.RefreshDataSource();
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            StatementReportForm dlg = new StatementReportForm(excelBankList);

            dlg.ShowDialog();
        }

        private void ReadFromExcelWF_Load(object sender, EventArgs e)
        {

        }


    }
}
