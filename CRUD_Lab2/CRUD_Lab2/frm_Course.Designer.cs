
namespace CRUD_Lab2
{
    partial class frm_Course
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
            this.lbl_CourseID = new System.Windows.Forms.Label();
            this.txt_CourseID = new System.Windows.Forms.TextBox();
            this.txt_CourseName = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_StudentRecord = new System.Windows.Forms.Label();
            this.tbl_record = new System.Windows.Forms.TableLayoutPanel();
            this.btn_CourseDelete = new System.Windows.Forms.Button();
            this.tbl_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_CourseUpdate = new System.Windows.Forms.Button();
            this.btn_CourseRetrieve = new System.Windows.Forms.Button();
            this.btn_CourseCreate = new System.Windows.Forms.Button();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ViewStudentRecord = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tbl_frm1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_grd = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_studentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.tbl_record.SuspendLayout();
            this.tbl_CRUD.SuspendLayout();
            this.tbl_Crudd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tbl_frm1.SuspendLayout();
            this.tbl_grd.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbl_studentRecord.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_CourseID
            // 
            this.lbl_CourseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_CourseID.AutoSize = true;
            this.lbl_CourseID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_CourseID.Location = new System.Drawing.Point(92, 93);
            this.lbl_CourseID.Name = "lbl_CourseID";
            this.lbl_CourseID.Size = new System.Drawing.Size(25, 17);
            this.lbl_CourseID.TabIndex = 1;
            this.lbl_CourseID.Text = "ID";
            // 
            // txt_CourseID
            // 
            this.txt_CourseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CourseID.Location = new System.Drawing.Point(375, 91);
            this.txt_CourseID.Name = "txt_CourseID";
            this.txt_CourseID.Size = new System.Drawing.Size(100, 20);
            this.txt_CourseID.TabIndex = 15;
            // 
            // txt_CourseName
            // 
            this.txt_CourseName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_CourseName.Location = new System.Drawing.Point(375, 304);
            this.txt_CourseName.Name = "txt_CourseName";
            this.txt_CourseName.Size = new System.Drawing.Size(100, 20);
            this.txt_CourseName.TabIndex = 16;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(55, 305);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(98, 17);
            this.lbl_Name.TabIndex = 21;
            this.lbl_Name.Text = "Course Name";
            // 
            // lbl_StudentRecord
            // 
            this.lbl_StudentRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_StudentRecord.AutoSize = true;
            this.lbl_StudentRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_StudentRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_StudentRecord.Location = new System.Drawing.Point(251, 30);
            this.lbl_StudentRecord.Name = "lbl_StudentRecord";
            this.lbl_StudentRecord.Size = new System.Drawing.Size(145, 26);
            this.lbl_StudentRecord.TabIndex = 16;
            this.lbl_StudentRecord.Text = "Course Record";
            // 
            // tbl_record
            // 
            this.tbl_record.ColumnCount = 2;
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 432F));
            this.tbl_record.Controls.Add(this.lbl_CourseID, 0, 0);
            this.tbl_record.Controls.Add(this.txt_CourseID, 1, 0);
            this.tbl_record.Controls.Add(this.txt_CourseName, 1, 1);
            this.tbl_record.Controls.Add(this.lbl_Name, 0, 1);
            this.tbl_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_record.Location = new System.Drawing.Point(3, 90);
            this.tbl_record.Name = "tbl_record";
            this.tbl_record.RowCount = 2;
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 203F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 10F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.Size = new System.Drawing.Size(641, 425);
            this.tbl_record.TabIndex = 0;
            // 
            // btn_CourseDelete
            // 
            this.btn_CourseDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CourseDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_CourseDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CourseDelete.Location = new System.Drawing.Point(368, 30);
            this.btn_CourseDelete.Name = "btn_CourseDelete";
            this.btn_CourseDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_CourseDelete.TabIndex = 2;
            this.btn_CourseDelete.Text = "Delete";
            this.btn_CourseDelete.UseVisualStyleBackColor = false;
            this.btn_CourseDelete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // tbl_CRUD
            // 
            this.tbl_CRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_CRUD.ColumnCount = 2;
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Controls.Add(this.btn_CourseDelete, 0, 0);
            this.tbl_CRUD.Controls.Add(this.btn_CourseUpdate, 0, 0);
            this.tbl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_CRUD.Location = new System.Drawing.Point(656, 527);
            this.tbl_CRUD.Name = "tbl_CRUD";
            this.tbl_CRUD.RowCount = 1;
            this.tbl_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Size = new System.Drawing.Size(541, 83);
            this.tbl_CRUD.TabIndex = 1;
            // 
            // btn_CourseUpdate
            // 
            this.btn_CourseUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CourseUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_CourseUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CourseUpdate.Location = new System.Drawing.Point(97, 30);
            this.btn_CourseUpdate.Name = "btn_CourseUpdate";
            this.btn_CourseUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_CourseUpdate.TabIndex = 1;
            this.btn_CourseUpdate.Text = "Update";
            this.btn_CourseUpdate.UseVisualStyleBackColor = false;
            this.btn_CourseUpdate.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_CourseRetrieve
            // 
            this.btn_CourseRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CourseRetrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_CourseRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CourseRetrieve.Location = new System.Drawing.Point(447, 29);
            this.btn_CourseRetrieve.Name = "btn_CourseRetrieve";
            this.btn_CourseRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_CourseRetrieve.TabIndex = 1;
            this.btn_CourseRetrieve.Text = "Retrieve";
            this.btn_CourseRetrieve.UseVisualStyleBackColor = false;
            this.btn_CourseRetrieve.Click += new System.EventHandler(this.btn_Retrieve_Click);
            // 
            // btn_CourseCreate
            // 
            this.btn_CourseCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_CourseCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_CourseCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_CourseCreate.Location = new System.Drawing.Point(124, 29);
            this.btn_CourseCreate.Name = "btn_CourseCreate";
            this.btn_CourseCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_CourseCreate.TabIndex = 0;
            this.btn_CourseCreate.Text = "Create";
            this.btn_CourseCreate.UseVisualStyleBackColor = false;
            this.btn_CourseCreate.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_CourseRetrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_CourseCreate, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(3, 528);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(647, 81);
            this.tbl_Crudd.TabIndex = 0;
            // 
            // lbl_ViewStudentRecord
            // 
            this.lbl_ViewStudentRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ViewStudentRecord.AutoSize = true;
            this.lbl_ViewStudentRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_ViewStudentRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ViewStudentRecord.Location = new System.Drawing.Point(173, 30);
            this.lbl_ViewStudentRecord.Name = "lbl_ViewStudentRecord";
            this.lbl_ViewStudentRecord.Size = new System.Drawing.Size(194, 26);
            this.lbl_ViewStudentRecord.TabIndex = 15;
            this.lbl_ViewStudentRecord.Text = "View Course Record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(85, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(364, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // tbl_frm1
            // 
            this.tbl_frm1.ColumnCount = 1;
            this.tbl_frm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_frm1.Controls.Add(this.dataGridView1, 0, 0);
            this.tbl_frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_frm1.Location = new System.Drawing.Point(3, 90);
            this.tbl_frm1.Name = "tbl_frm1";
            this.tbl_frm1.RowCount = 1;
            this.tbl_frm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_frm1.Size = new System.Drawing.Size(535, 425);
            this.tbl_frm1.TabIndex = 0;
            // 
            // tbl_grd
            // 
            this.tbl_grd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_grd.ColumnCount = 1;
            this.tbl_grd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_grd.Controls.Add(this.tbl_frm1, 0, 1);
            this.tbl_grd.Controls.Add(this.lbl_ViewStudentRecord, 0, 0);
            this.tbl_grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_grd.Location = new System.Drawing.Point(656, 3);
            this.tbl_grd.Name = "tbl_grd";
            this.tbl_grd.RowCount = 2;
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.Size = new System.Drawing.Size(541, 518);
            this.tbl_grd.TabIndex = 3;
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(1, -2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 613);
            this.tableLayoutPanel1.TabIndex = 1;
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
            this.tbl_studentRecord.Size = new System.Drawing.Size(647, 518);
            this.tbl_studentRecord.TabIndex = 2;
            // 
            // frm_Course
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1202, 613);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_Course";
            this.Text = "frm_Course";
            this.tbl_record.ResumeLayout(false);
            this.tbl_record.PerformLayout();
            this.tbl_CRUD.ResumeLayout(false);
            this.tbl_Crudd.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tbl_frm1.ResumeLayout(false);
            this.tbl_grd.ResumeLayout(false);
            this.tbl_grd.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbl_studentRecord.ResumeLayout(false);
            this.tbl_studentRecord.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lbl_CourseID;
        private System.Windows.Forms.TextBox txt_CourseID;
        private System.Windows.Forms.TextBox txt_CourseName;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_StudentRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_record;
        private System.Windows.Forms.Button btn_CourseDelete;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.Button btn_CourseUpdate;
        private System.Windows.Forms.Button btn_CourseRetrieve;
        private System.Windows.Forms.Button btn_CourseCreate;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Label lbl_ViewStudentRecord;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TableLayoutPanel tbl_frm1;
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tbl_studentRecord;
    }
}