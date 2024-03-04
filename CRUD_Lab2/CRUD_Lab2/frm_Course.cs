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
    public partial class frm_Course : Form
    {
        public frm_Course()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Course values (@ID, @CourseName)", con);
            cmd.Parameters.AddWithValue("@ID", txt_CourseID.Text);
            cmd.Parameters.AddWithValue("@CourseName", txt_CourseName.Text);
            
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void btn_Retrieve_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Course", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE From Course Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_CourseID.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Delete");
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Course SET CourseName = @CourseName Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_CourseID.Text);
            cmd.Parameters.AddWithValue("@CourseName", txt_CourseName.Text);
     
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
        }
    }
}
