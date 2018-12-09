namespace ReadDataFromExcel
{
    partial class ReadFromExcelWF
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnGenerateView = new DevExpress.XtraEditors.SimpleButton();
            this.lueMark = new DevExpress.XtraEditors.LookUpEdit();
            this.lueDate = new DevExpress.XtraEditors.LookUpEdit();
            this.lueSheetName = new DevExpress.XtraEditors.LookUpEdit();
            this.filePath = new DevExpress.XtraEditors.ButtonEdit();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.excelStudentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransactionType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTheirType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNarrative = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOurRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTransRef = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDebit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCredit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colBalance = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueMark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSheetName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePath.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelStudentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Controls.Add(this.btnGenerateView);
            this.groupControl1.Controls.Add(this.lueMark);
            this.groupControl1.Controls.Add(this.lueDate);
            this.groupControl1.Controls.Add(this.lueSheetName);
            this.groupControl1.Controls.Add(this.filePath);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(750, 346);
            this.groupControl1.TabIndex = 2;
            this.groupControl1.Text = "groupControl1";
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(320, 311);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 30);
            this.simpleButton2.TabIndex = 6;
            this.simpleButton2.Text = "simpleButton2";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // btnGenerateView
            // 
            this.btnGenerateView.Location = new System.Drawing.Point(418, 311);
            this.btnGenerateView.Name = "btnGenerateView";
            this.btnGenerateView.Size = new System.Drawing.Size(84, 30);
            this.btnGenerateView.TabIndex = 5;
            this.btnGenerateView.Text = "Generate View";
            this.btnGenerateView.Click += new System.EventHandler(this.btnGenerateView_Click);
            // 
            // lueMark
            // 
            this.lueMark.Location = new System.Drawing.Point(213, 116);
            this.lueMark.Name = "lueMark";
            this.lueMark.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueMark.Size = new System.Drawing.Size(289, 20);
            this.lueMark.TabIndex = 4;
            // 
            // lueDate
            // 
            this.lueDate.Location = new System.Drawing.Point(213, 90);
            this.lueDate.Name = "lueDate";
            this.lueDate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDate.Size = new System.Drawing.Size(289, 20);
            this.lueDate.TabIndex = 1;
            // 
            // lueSheetName
            // 
            this.lueSheetName.Location = new System.Drawing.Point(213, 64);
            this.lueSheetName.Name = "lueSheetName";
            this.lueSheetName.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueSheetName.Size = new System.Drawing.Size(289, 20);
            this.lueSheetName.TabIndex = 3;
            this.lueSheetName.EditValueChanged += new System.EventHandler(this.lueSheetName_EditValueChanged);
            // 
            // filePath
            // 
            this.filePath.Location = new System.Drawing.Point(213, 38);
            this.filePath.Name = "filePath";
            this.filePath.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.filePath.Size = new System.Drawing.Size(289, 20);
            this.filePath.TabIndex = 2;
            this.filePath.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.buttonEdit1_ButtonClick);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Location = new System.Drawing.Point(12, 364);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(750, 346);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "groupControl2";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.excelStudentBindingSource;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 21);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(746, 323);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // excelStudentBindingSource
            // 
            this.excelStudentBindingSource.DataSource = typeof(ReadDataFromExcel.BankStatement);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colDate,
            this.colTransactionType,
            this.colTheirType,
            this.colNarrative,
            this.colOurRef,
            this.colTransRef,
            this.colDebit,
            this.colCredit,
            this.colBalance});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colDate
            // 
            this.colDate.FieldName = "Date";
            this.colDate.Name = "colDate";
            this.colDate.Visible = true;
            this.colDate.VisibleIndex = 0;
            // 
            // colTransactionType
            // 
            this.colTransactionType.FieldName = "TransactionType";
            this.colTransactionType.Name = "colTransactionType";
            this.colTransactionType.Visible = true;
            this.colTransactionType.VisibleIndex = 1;
            // 
            // colTheirType
            // 
            this.colTheirType.FieldName = "TheirType";
            this.colTheirType.Name = "colTheirType";
            this.colTheirType.Visible = true;
            this.colTheirType.VisibleIndex = 2;
            // 
            // colNarrative
            // 
            this.colNarrative.FieldName = "Narrative";
            this.colNarrative.Name = "colNarrative";
            this.colNarrative.Visible = true;
            this.colNarrative.VisibleIndex = 3;
            // 
            // colOurRef
            // 
            this.colOurRef.FieldName = "OurRef";
            this.colOurRef.Name = "colOurRef";
            this.colOurRef.Visible = true;
            this.colOurRef.VisibleIndex = 4;
            // 
            // colTransRef
            // 
            this.colTransRef.FieldName = "TransRef";
            this.colTransRef.Name = "colTransRef";
            this.colTransRef.Visible = true;
            this.colTransRef.VisibleIndex = 5;
            // 
            // colDebit
            // 
            this.colDebit.FieldName = "Debit";
            this.colDebit.Name = "colDebit";
            this.colDebit.Visible = true;
            this.colDebit.VisibleIndex = 6;
            // 
            // colCredit
            // 
            this.colCredit.FieldName = "Credit";
            this.colCredit.Name = "colCredit";
            this.colCredit.Visible = true;
            this.colCredit.VisibleIndex = 7;
            // 
            // colBalance
            // 
            this.colBalance.FieldName = "Balance";
            this.colBalance.Name = "colBalance";
            this.colBalance.Visible = true;
            this.colBalance.VisibleIndex = 8;
            // 
            // ReadFromExcelWF
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 722);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "ReadFromExcelWF";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Read From Excel File";
            this.Load += new System.EventHandler(this.ReadFromExcelWF_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lueMark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueSheetName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filePath.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.excelStudentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lueSheetName;
        private DevExpress.XtraEditors.ButtonEdit filePath;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit lueMark;
        private DevExpress.XtraEditors.LookUpEdit lueDate;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnGenerateView;
        private System.Windows.Forms.BindingSource excelStudentBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colDate;
        private DevExpress.XtraGrid.Columns.GridColumn colTransactionType;
        private DevExpress.XtraGrid.Columns.GridColumn colTheirType;
        private DevExpress.XtraGrid.Columns.GridColumn colNarrative;
        private DevExpress.XtraGrid.Columns.GridColumn colOurRef;
        private DevExpress.XtraGrid.Columns.GridColumn colTransRef;
        private DevExpress.XtraGrid.Columns.GridColumn colDebit;
        private DevExpress.XtraGrid.Columns.GridColumn colCredit;
        private DevExpress.XtraGrid.Columns.GridColumn colBalance;

    }
}

