using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ReadDataFromExcel
{
    public partial class StatementReportForm : DevExpress.XtraEditors.XtraForm
    {
        private StatementReport _reportDesign;
        public List<BankStatement> _excelBank; 
        public StatementReportForm(List<BankStatement> excelStd)
        {
            _excelBank = new List<BankStatement>();
            _excelBank = excelStd;
            _reportDesign=new StatementReport();
            InitializeComponent();
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            _reportDesign.DataSource = _excelBank;
           // _reportDesign.serial = 0;
            documentViewer1.DocumentSource = _reportDesign;
            _reportDesign.CreateDocument();
        }}
}