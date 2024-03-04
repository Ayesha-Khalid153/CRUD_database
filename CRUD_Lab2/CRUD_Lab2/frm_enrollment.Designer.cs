
namespace CRUD_Lab2
{
    partial class frm_enrollment
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
            this.grd_Enrollment = new System.Windows.Forms.DataGridView();
            this.lbl_EnrolmentRecord = new System.Windows.Forms.Label();
            this.tbl_Crudd = new System.Windows.Forms.TableLayoutPanel();
            this.btn_EnrollmentRetrieve = new System.Windows.Forms.Button();
            this.btn_EnrollmentCreate = new System.Windows.Forms.Button();
            this.tbl_CRUD = new System.Windows.Forms.TableLayoutPanel();
            this.btn_EnrollmentDelete = new System.Windows.Forms.Button();
            this.btn_EnrollmentUpdate = new System.Windows.Forms.Button();
            this.tbl_studentRecord = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_EnrollmentRecord = new System.Windows.Forms.Label();
            this.tbl_record = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_EnrolmentID = new System.Windows.Forms.TextBox();
            this.txt_EnrolmentCourseID = new System.Windows.Forms.TextBox();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.tbl_grd.SuspendLayout();
            this.tbl_frm1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grd_Enrollment)).BeginInit();
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
            this.tableLayoutPanel1.Location = new System.Drawing.Point(-1, -1);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 85.52036F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.47964F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1236, 595);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbl_grd
            // 
            this.tbl_grd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_grd.ColumnCount = 1;
            this.tbl_grd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_grd.Controls.Add(this.tbl_frm1, 0, 1);
            this.tbl_grd.Controls.Add(this.lbl_EnrolmentRecord, 0, 0);
            this.tbl_grd.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_grd.Location = new System.Drawing.Point(676, 3);
            this.tbl_grd.Name = "tbl_grd";
            this.tbl_grd.RowCount = 2;
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_grd.Size = new System.Drawing.Size(557, 502);
            this.tbl_grd.TabIndex = 3;
            // 
            // tbl_frm1
            // 
            this.tbl_frm1.ColumnCount = 1;
            this.tbl_frm1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.11399F));
            this.tbl_frm1.Controls.Add(this.grd_Enrollment, 0, 0);
            this.tbl_frm1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_frm1.Location = new System.Drawing.Point(3, 88);
            this.tbl_frm1.Name = "tbl_frm1";
            this.tbl_frm1.RowCount = 1;
            this.tbl_frm1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.46205F));
            this.tbl_frm1.Size = new System.Drawing.Size(551, 411);
            this.tbl_frm1.TabIndex = 0;
            // 
            // grd_Enrollment
            // 
            this.grd_Enrollment.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.grd_Enrollment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grd_Enrollment.Location = new System.Drawing.Point(11, 3);
            this.grd_Enrollment.Name = "grd_Enrollment";
            this.grd_Enrollment.Size = new System.Drawing.Size(529, 405);
            this.grd_Enrollment.TabIndex = 0;
            // 
            // lbl_EnrolmentRecord
            // 
            this.lbl_EnrolmentRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_EnrolmentRecord.AutoSize = true;
            this.lbl_EnrolmentRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_EnrolmentRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnrolmentRecord.Location = new System.Drawing.Point(163, 29);
            this.lbl_EnrolmentRecord.Name = "lbl_EnrolmentRecord";
            this.lbl_EnrolmentRecord.Size = new System.Drawing.Size(230, 26);
            this.lbl_EnrolmentRecord.TabIndex = 15;
            this.lbl_EnrolmentRecord.Text = "View Enrollment Record";
            // 
            // tbl_Crudd
            // 
            this.tbl_Crudd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tbl_Crudd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_Crudd.ColumnCount = 2;
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Controls.Add(this.btn_EnrollmentRetrieve, 1, 0);
            this.tbl_Crudd.Controls.Add(this.btn_EnrollmentCreate, 0, 0);
            this.tbl_Crudd.Location = new System.Drawing.Point(3, 511);
            this.tbl_Crudd.Name = "tbl_Crudd";
            this.tbl_Crudd.RowCount = 1;
            this.tbl_Crudd.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_Crudd.Size = new System.Drawing.Size(667, 81);
            this.tbl_Crudd.TabIndex = 0;
            // 
            // btn_EnrollmentRetrieve
            // 
            this.btn_EnrollmentRetrieve.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EnrollmentRetrieve.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_EnrollmentRetrieve.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EnrollmentRetrieve.Location = new System.Drawing.Point(462, 29);
            this.btn_EnrollmentRetrieve.Name = "btn_EnrollmentRetrieve";
            this.btn_EnrollmentRetrieve.Size = new System.Drawing.Size(75, 23);
            this.btn_EnrollmentRetrieve.TabIndex = 1;
            this.btn_EnrollmentRetrieve.Text = "Retrieve";
            this.btn_EnrollmentRetrieve.UseVisualStyleBackColor = false;
            this.btn_EnrollmentRetrieve.Click += new System.EventHandler(this.btn_Retrieve_Click);
            // 
            // btn_EnrollmentCreate
            // 
            this.btn_EnrollmentCreate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EnrollmentCreate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_EnrollmentCreate.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_EnrollmentCreate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EnrollmentCreate.Location = new System.Drawing.Point(129, 29);
            this.btn_EnrollmentCreate.Name = "btn_EnrollmentCreate";
            this.btn_EnrollmentCreate.Size = new System.Drawing.Size(75, 23);
            this.btn_EnrollmentCreate.TabIndex = 0;
            this.btn_EnrollmentCreate.Text = "Create";
            this.btn_EnrollmentCreate.UseVisualStyleBackColor = false;
            this.btn_EnrollmentCreate.Click += new System.EventHandler(this.btn_Create_Click);
            // 
            // tbl_CRUD
            // 
            this.tbl_CRUD.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_CRUD.ColumnCount = 2;
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Controls.Add(this.btn_EnrollmentDelete, 0, 0);
            this.tbl_CRUD.Controls.Add(this.btn_EnrollmentUpdate, 0, 0);
            this.tbl_CRUD.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_CRUD.Location = new System.Drawing.Point(676, 511);
            this.tbl_CRUD.Name = "tbl_CRUD";
            this.tbl_CRUD.RowCount = 1;
            this.tbl_CRUD.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tbl_CRUD.Size = new System.Drawing.Size(557, 81);
            this.tbl_CRUD.TabIndex = 1;
            // 
            // btn_EnrollmentDelete
            // 
            this.btn_EnrollmentDelete.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EnrollmentDelete.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_EnrollmentDelete.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_EnrollmentDelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EnrollmentDelete.Location = new System.Drawing.Point(380, 29);
            this.btn_EnrollmentDelete.Name = "btn_EnrollmentDelete";
            this.btn_EnrollmentDelete.Size = new System.Drawing.Size(75, 23);
            this.btn_EnrollmentDelete.TabIndex = 2;
            this.btn_EnrollmentDelete.Text = "Delete";
            this.btn_EnrollmentDelete.UseVisualStyleBackColor = false;
            this.btn_EnrollmentDelete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_EnrollmentUpdate
            // 
            this.btn_EnrollmentUpdate.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_EnrollmentUpdate.BackColor = System.Drawing.SystemColors.ControlText;
            this.btn_EnrollmentUpdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_EnrollmentUpdate.Location = new System.Drawing.Point(101, 29);
            this.btn_EnrollmentUpdate.Name = "btn_EnrollmentUpdate";
            this.btn_EnrollmentUpdate.Size = new System.Drawing.Size(75, 23);
            this.btn_EnrollmentUpdate.TabIndex = 1;
            this.btn_EnrollmentUpdate.Text = "Update";
            this.btn_EnrollmentUpdate.UseVisualStyleBackColor = false;
            this.btn_EnrollmentUpdate.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // tbl_studentRecord
            // 
            this.tbl_studentRecord.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tbl_studentRecord.ColumnCount = 1;
            this.tbl_studentRecord.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.7449F));
            this.tbl_studentRecord.Controls.Add(this.lbl_EnrollmentRecord, 0, 0);
            this.tbl_studentRecord.Controls.Add(this.tbl_record, 0, 1);
            this.tbl_studentRecord.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_studentRecord.Location = new System.Drawing.Point(3, 3);
            this.tbl_studentRecord.Name = "tbl_studentRecord";
            this.tbl_studentRecord.RowCount = 2;
            this.tbl_studentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.93548F));
            this.tbl_studentRecord.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.06451F));
            this.tbl_studentRecord.Size = new System.Drawing.Size(667, 502);
            this.tbl_studentRecord.TabIndex = 2;
            // 
            // lbl_EnrollmentRecord
            // 
            this.lbl_EnrollmentRecord.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_EnrollmentRecord.AutoSize = true;
            this.lbl_EnrollmentRecord.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_EnrollmentRecord.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EnrollmentRecord.Location = new System.Drawing.Point(243, 29);
            this.lbl_EnrollmentRecord.Name = "lbl_EnrollmentRecord";
            this.lbl_EnrollmentRecord.Size = new System.Drawing.Size(181, 26);
            this.lbl_EnrollmentRecord.TabIndex = 16;
            this.lbl_EnrollmentRecord.Text = "Enrollment Record";
            // 
            // tbl_record
            // 
            this.tbl_record.ColumnCount = 2;
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 209F));
            this.tbl_record.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 452F));
            this.tbl_record.Controls.Add(this.lbl_ID, 0, 0);
            this.tbl_record.Controls.Add(this.txt_EnrolmentID, 1, 0);
            this.tbl_record.Controls.Add(this.txt_EnrolmentCourseID, 1, 1);
            this.tbl_record.Controls.Add(this.lbl_Name, 0, 1);
            this.tbl_record.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl_record.Location = new System.Drawing.Point(3, 88);
            this.tbl_record.Name = "tbl_record";
            this.tbl_record.RowCount = 2;
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 186F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 9F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl_record.Size = new System.Drawing.Size(661, 411);
            this.tbl_record.TabIndex = 0;
            // 
            // lbl_ID
            // 
            this.lbl_ID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(65, 84);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(79, 17);
            this.lbl_ID.TabIndex = 1;
            this.lbl_ID.Text = "Student ID";
            // 
            // txt_EnrolmentID
            // 
            this.txt_EnrolmentID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EnrolmentID.Location = new System.Drawing.Point(385, 83);
            this.txt_EnrolmentID.Name = "txt_EnrolmentID";
            this.txt_EnrolmentID.Size = new System.Drawing.Size(100, 20);
            this.txt_EnrolmentID.TabIndex = 15;
            this.txt_EnrolmentID.TextChanged += new System.EventHandler(this.txt_EnrolmentID_TextChanged);
            // 
            // txt_EnrolmentCourseID
            // 
            this.txt_EnrolmentCourseID.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txt_EnrolmentCourseID.Location = new System.Drawing.Point(385, 288);
            this.txt_EnrolmentCourseID.Name = "txt_EnrolmentCourseID";
            this.txt_EnrolmentCourseID.Size = new System.Drawing.Size(100, 20);
            this.txt_EnrolmentCourseID.TabIndex = 16;
            // 
            // lbl_Name
            // 
            this.lbl_Name.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.Location = new System.Drawing.Point(66, 290);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(77, 17);
            this.lbl_Name.TabIndex = 21;
            this.lbl_Name.Text = "Course ID";
            // 
            // frm_enrollment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.CancelButton = this.btn_EnrollmentDelete;
            this.ClientSize = new System.Drawing.Size(1233, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_enrollment";
            this.Text = "frm_Enrollment";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tbl_grd.ResumeLayout(false);
            this.tbl_grd.PerformLayout();
            this.tbl_frm1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grd_Enrollment)).EndInit();
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
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tbl_frm1;
        private System.Windows.Forms.DataGridView grd_Enrollment;
        private System.Windows.Forms.Label lbl_EnrolmentRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Button btn_EnrollmentRetrieve;
        private System.Windows.Forms.Button btn_EnrollmentCreate;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.Button btn_EnrollmentDelete;
        private System.Windows.Forms.Button btn_EnrollmentUpdate;
        private System.Windows.Forms.TableLayoutPanel tbl_studentRecord;
        private System.Windows.Forms.Label lbl_EnrollmentRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_record;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_EnrolmentID;
        private System.Windows.Forms.TextBox txt_EnrolmentCourseID;
        private System.Windows.Forms.Label lbl_Name;
    }
}