
namespace CRUD_Lab2
{
    partial class frm_Crud
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
            this.SuspendLayout();
            // 
            // frm_Crud
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "frm_Crud";
            this.Load += new System.EventHandler(this.frm_Crud_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tbl_grd;
        private System.Windows.Forms.TableLayoutPanel tbl_frm1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lbl_ViewStudentRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_Crudd;
        private System.Windows.Forms.Button btn_Retrieve;
        private System.Windows.Forms.Button btn_Create;
        private System.Windows.Forms.TableLayoutPanel tbl_CRUD;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.TableLayoutPanel tbl_studentRecord;
        private System.Windows.Forms.Label lbl_StudentRecord;
        private System.Windows.Forms.TableLayoutPanel tbl_record;
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
    }
}