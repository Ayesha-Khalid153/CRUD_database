using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Lab2
{
    public partial class frmCrud : Form
    {
        public frmCrud()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbl_frm1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Students values (@ID, @Name, @Department, @Session, @CGPA, @Adress)", con);
            cmd.Parameters.AddWithValue("@ID", txt_ID.Text);
            cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@Department", txt_Department.Text);
            cmd.Parameters.AddWithValue("@Session", txt_Session.Text);
            cmd.Parameters.AddWithValue("@CGPA", float.Parse(txt_CGPA.Text));
            cmd.Parameters.AddWithValue("@Adress", txt_Adress.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void btn_Retrieve_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Students", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Students SET Name = @Name, Department = @Department, Session = @Session,CGPA =  @CGPA, Adress = @Adress Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_ID.Text);
            cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@Department", txt_Department.Text);
            cmd.Parameters.AddWithValue("@Session", txt_Session.Text);
            cmd.Parameters.AddWithValue("@CGPA", float.Parse(txt_CGPA.Text));
            cmd.Parameters.AddWithValue("@Adress", txt_Adress.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Students Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_ID.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Delete");
        }

        private void tbl_grd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lbl_ViewStudentRecord_Click(object sender, EventArgs e)
        {

        }

        private void tbl_Crudd_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbl_CRUD_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_StudentRecord_Click(object sender, EventArgs e)
        {

        }

        private void tbl_record_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_Adress_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ID_Click(object sender, EventArgs e)
        {

        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Department_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_CGPA_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Session_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_Name_Click(object sender, EventArgs e)
        {

        }

        private void lbl_CGPA_Click(object sender, EventArgs e)
        {

        }

        private void lbl_Session_Click(object sender, EventArgs e)
        {

        }
    }
}
