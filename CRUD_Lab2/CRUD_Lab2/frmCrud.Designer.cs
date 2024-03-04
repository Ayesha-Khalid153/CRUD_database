
namespace CRUD_Lab2
{
    partial class frmCrud
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_grd = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_frm1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lbl_ViewStudentRecord = new System.Windows.Forms.Label();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Retrieve = new System.Windows.Forms.Button();
            this.btn_Create = new System.Windows.Forms.Button();
            this.tbl_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.tbl_studentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_StudentRecord = new System.Windows.Forms.Label();
            this.tbl_record = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_Adress = new System.Windows.Forms.Label();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Department = new System.Windows.Forms.TextBox();
            this.txt_CGPA = new System.Windows.Forms.TextBox();
            this.txt_Session = new System.Windows.Forms.TextBox();
            this.txt_Adress = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Department = new System.Windows.Forms.Label();
            this.lbl_CGPA = new System.Windows.Forms.Label();
            this.lbl_Session = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbl_grd.SuspendLayout();
            this.tbl_frm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbl_Crudd.SuspendLayout();
            this.tbl_CRUD.SuspendLayout();
            this.tbl_studentRecord.SuspendLayout();
            this.tbl_record.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 54.4542F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 45.5458F));
            this.tableLayoutPanel1.Controls.Add(this.tbl_grd, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbl_Crudd, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbl_CRUD, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbl_studentRecord, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(797, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tbl_grd
            // 
            this.tbl_grd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_grd.ColumnCount = 1;
            this.tbl_grd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_grd.Controls.Add(this.tbl_frm1, 0, 1);
            this.tbl_grd.Controls.Add(this.lbl_ViewStudentRecord, 0, 0);
            this.tbl_grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_grd.Location = new System.Drawing.Point(436, 3);
            this.tbl_grd.Name = "tbl_grd";
            this.tbl_grd.RowCount = 2;
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.Size = new System.Drawing.Size(358, 378);
            this.tbl_grd.TabIndex = 3;
            this.tbl_grd.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_grd_Paint);
            // 
            // tbl_frm1
            // 
            this.tbl_frm1.ColumnCount = 1;
            this.tbl_frm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_frm1.Controls.Add(this.dataGridView1, 0, 0);
            this.tbl_frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_frm1.Location = new System.Drawing.Point(3, 67);
            this.tbl_frm1.Name = "tbl_frm1";
            this.tbl_frm1.RowCount = 1;
            this.tbl_frm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_frm1.Size = new System.Drawing.Size(352, 308);
            this.tbl_frm1.TabIndex = 0;
            this.tbl_frm1.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_frm1_Paint);
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(344, 297);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // lbl_ViewStudentRecord
            // 
            this.lbl_ViewStudentRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ViewStudentRecord.AutoSize = true;
            this.lbl_ViewStudentRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ViewStudentRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewStudentRecord.Location = new System.Drawing.Point(79, 19);
            this.lbl_ViewStudentRecord.Name = "lbl_ViewStudentRecord";
            this.lbl_ViewStudentRecord.Size = new System.Drawing.Size(200, 26);
            this.lbl_ViewStudentRecord.TabIndex = 15;
            this.lbl_ViewStudentRecord.Text = "View Student Record";
            this.lbl_ViewStudentRecord.Click += new System.EventHandler(this.lbl_ViewStudentRecord_Click);
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_Retrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_Create, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(20, 388);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(392, 58);
            this.tbl_Crudd.TabIndex = 0;
            this.tbl_Crudd.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_Crudd_Paint);
            // 
            // btn_Retrieve
            // 
            this.btn_Retrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Retrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Retrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Retrieve.Location = new System.Drawing.Point(256, 17);
            this.btn_Retrieve.Name = "btn_Retrieve";
            this.btn_Retrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_Retrieve.TabIndex = 1;
            this.btn_Retrieve.Text = "Retrieve";
            this.btn_Retrieve.UseVisualStyleBackColor = false;
            this.btn_Retrieve.Click += new System.EventHandler(this.btn_Retrieve_Click);
            // 
            // btn_Create
            // 
            this.btn_Create.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Create.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Create.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Create.Location = new System.Drawing.Point(60, 17);
            this.btn_Create.Name = "btn_Create";
            this.btn_Create.Size = new System.Drawing.Size(75, 23);
            this.btn_Create.TabIndex = 0;
            this.btn_Create.Text = "Create";
            this.btn_Create.UseVisualStyleBackColor = false;
            this.btn_Create.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // tbl_CRUD
            // 
            this.tbl_CRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_CRUD.ColumnCount = 2;
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Controls.Add(this.btn_Delete, 0, 0);
            this.tbl_CRUD.Controls.Add(this.btn_Update, 0, 0);
            this.tbl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_CRUD.Location = new System.Drawing.Point(436, 387);
            this.tbl_CRUD.Name = "tbl_CRUD";
            this.tbl_CRUD.RowCount = 1;
            this.tbl_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Size = new System.Drawing.Size(358, 60);
            this.tbl_CRUD.TabIndex = 1;
            this.tbl_CRUD.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_CRUD_Paint);
            // 
            // btn_Delete
            // 
            this.btn_Delete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Delete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Delete.Location = new System.Drawing.Point(231, 18);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(75, 23);
            this.btn_Delete.TabIndex = 2;
            this.btn_Delete.Text = "Delete";
            this.btn_Delete.UseVisualStyleBackColor = false;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Update.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_Update.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_Update.Location = new System.Drawing.Point(52, 18);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(75, 23);
            this.btn_Update.TabIndex = 1;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tbl_studentRecord
            // 
            this.tbl_studentRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_studentRecord.ColumnCount = 1;
            this.tbl_studentRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_studentRecord.Controls.Add(this.lbl_StudentRecord, 0, 0);
            this.tbl_studentRecord.Controls.Add(this.tbl_record, 0, 1);
            this.tbl_studentRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_studentRecord.Location = new System.Drawing.Point(3, 3);
            this.tbl_studentRecord.Name = "tbl_studentRecord";
            this.tbl_studentRecord.RowCount = 2;
            this.tbl_studentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_studentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_studentRecord.Size = new System.Drawing.Size(427, 378);
            this.tbl_studentRecord.TabIndex = 2;
            this.tbl_studentRecord.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel4_Paint);
            // 
            // lbl_StudentRecord
            // 
            this.lbl_StudentRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_StudentRecord.AutoSize = true;
            this.lbl_StudentRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_StudentRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentRecord.Location = new System.Drawing.Point(138, 19);
            this.lbl_StudentRecord.Name = "lbl_StudentRecord";
            this.lbl_StudentRecord.Size = new System.Drawing.Size(151, 26);
            this.lbl_StudentRecord.TabIndex = 16;
            this.lbl_StudentRecord.Text = "Student Record";
            this.lbl_StudentRecord.Click += new System.EventHandler(this.lbl_StudentRecord_Click);
            // 
            // tbl_record
            // 
            this.tbl_record.ColumnCount = 2;
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 213F));
            this.tbl_record.Controls.Add(this.lbl_Adress, 0, 5);
            this.tbl_record.Controls.Add(this.lbl_ID, 0, 0);
            this.tbl_record.Controls.Add(this.txt_ID, 1, 0);
            this.tbl_record.Controls.Add(this.txt_Name, 1, 1);
            this.tbl_record.Controls.Add(this.txt_Department, 1, 2);
            this.tbl_record.Controls.Add(this.txt_CGPA, 1, 3);
            this.tbl_record.Controls.Add(this.txt_Session, 1, 4);
            this.tbl_record.Controls.Add(this.txt_Adress, 1, 5);
            this.tbl_record.Controls.Add(this.lbl_Name, 0, 1);
            this.tbl_record.Controls.Add(this.lbl_Department, 0, 2);
            this.tbl_record.Controls.Add(this.lbl_CGPA, 0, 3);
            this.tbl_record.Controls.Add(this.lbl_Session, 0, 4);
            this.tbl_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_record.Location = new System.Drawing.Point(3, 67);
            this.tbl_record.Name = "tbl_record";
            this.tbl_record.RowCount = 6;
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 55F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.Size = new System.Drawing.Size(421, 308);
            this.tbl_record.TabIndex = 0;
            this.tbl_record.Paint += new System.Windows.Forms.PaintEventHandler(this.tbl_record_Paint);
            // 
            // lbl_Adress
            // 
            this.lbl_Adress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Adress.AutoSize = true;
            this.lbl_Adress.Location = new System.Drawing.Point(85, 277);
            this.lbl_Adress.Name = "lbl_Adress";
            this.lbl_Adress.Size = new System.Drawing.Size(39, 13);
            this.lbl_Adress.TabIndex = 25;
            this.lbl_Adress.Text = "Adress";
            this.lbl_Adress.Click += new System.EventHandler(this.lbl_Adress_Click);
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Location = new System.Drawing.Point(95, 19);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(18, 13);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "ID";
            this.lbl_ID.Click += new System.EventHandler(this.lbl_ID_Click);
            // 
            // txt_ID
            // 
            this.txt_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_ID.Location = new System.Drawing.Point(265, 16);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(100, 20);
            this.txt_ID.TabIndex = 15;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // txt_Name
            // 
            this.txt_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Name.Location = new System.Drawing.Point(265, 69);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(100, 20);
            this.txt_Name.TabIndex = 16;
            this.txt_Name.TextChanged += new System.EventHandler(this.txt_Name_TextChanged);
            // 
            // txt_Department
            // 
            this.txt_Department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Department.Location = new System.Drawing.Point(265, 123);
            this.txt_Department.Name = "txt_Department";
            this.txt_Department.Size = new System.Drawing.Size(100, 20);
            this.txt_Department.TabIndex = 17;
            this.txt_Department.TextChanged += new System.EventHandler(this.txt_Department_TextChanged);
            // 
            // txt_CGPA
            // 
            this.txt_CGPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CGPA.Location = new System.Drawing.Point(265, 175);
            this.txt_CGPA.Name = "txt_CGPA";
            this.txt_CGPA.Size = new System.Drawing.Size(100, 20);
            this.txt_CGPA.TabIndex = 18;
            this.txt_CGPA.TextChanged += new System.EventHandler(this.txt_CGPA_TextChanged);
            // 
            // txt_Session
            // 
            this.txt_Session.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Session.Location = new System.Drawing.Point(265, 224);
            this.txt_Session.Name = "txt_Session";
            this.txt_Session.Size = new System.Drawing.Size(100, 20);
            this.txt_Session.TabIndex = 19;
            this.txt_Session.TextChanged += new System.EventHandler(this.txt_Session_TextChanged);
            // 
            // txt_Adress
            // 
            this.txt_Adress.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_Adress.Location = new System.Drawing.Point(265, 273);
            this.txt_Adress.Name = "txt_Adress";
            this.txt_Adress.Size = new System.Drawing.Size(100, 20);
            this.txt_Adress.TabIndex = 20;
            this.txt_Adress.TextChanged += new System.EventHandler(this.txt_Adress_TextChanged);
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(87, 73);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(35, 13);
            this.lbl_Name.TabIndex = 21;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.Click += new System.EventHandler(this.lbl_Name_Click);
            // 
            // lbl_Department
            // 
            this.lbl_Department.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Department.AutoSize = true;
            this.lbl_Department.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl_Department.Location = new System.Drawing.Point(73, 127);
            this.lbl_Department.Name = "lbl_Department";
            this.lbl_Department.Size = new System.Drawing.Size(62, 13);
            this.lbl_Department.TabIndex = 22;
            this.lbl_Department.Text = "Department";
            this.lbl_Department.UseMnemonic = false;
            this.lbl_Department.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbl_CGPA
            // 
            this.lbl_CGPA.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CGPA.AutoSize = true;
            this.lbl_CGPA.Location = new System.Drawing.Point(86, 178);
            this.lbl_CGPA.Name = "lbl_CGPA";
            this.lbl_CGPA.Size = new System.Drawing.Size(36, 13);
            this.lbl_CGPA.TabIndex = 23;
            this.lbl_CGPA.Text = "CGPA";
            this.lbl_CGPA.Click += new System.EventHandler(this.lbl_CGPA_Click);
            // 
            // lbl_Session
            // 
            this.lbl_Session.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Session.AutoSize = true;
            this.lbl_Session.Location = new System.Drawing.Point(82, 228);
            this.lbl_Session.Name = "lbl_Session";
            this.lbl_Session.Size = new System.Drawing.Size(44, 13);
            this.lbl_Session.TabIndex = 24;
            this.lbl_Session.Text = "Session";
            this.lbl_Session.Click += new System.EventHandler(this.lbl_Session_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "frm_CRUD";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbl_grd.ResumeLayout(false);
            this.tbl_grd.PerformLayout();
            this.tbl_frm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbl_Crudd.ResumeLayout(false);
            this.tbl_CRUD.ResumeLayout(false);
            this.tbl_studentRecord.ResumeLayout(false);
            this.tbl_studentRecord.PerformLayout();
            this.tbl_record.ResumeLayout(false);
            this.tbl_record.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.TableLayoutPanel tbl_studentRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_record;
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tbl_frm1;
        private System.Windows.Forms.Label lbl_ViewStudentRecord;
        private System.Windows.Forms.Label lbl_StudentRecord;
        private System.Windows.Forms.Label lbl_Adress;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Department;
        private System.Windows.Forms.TextBox txt_CGPA;
        private System.Windows.Forms.TextBox txt_Session;
        private System.Windows.Forms.TextBox txt_Adress;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Department;
        private System.Windows.Forms.Label lbl_CGPA;
        private System.Windows.Forms.Label lbl_Session;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_Retrieve;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
    }
}

