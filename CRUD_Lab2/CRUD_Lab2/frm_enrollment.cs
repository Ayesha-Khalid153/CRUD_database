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
    public partial class frm_enrollment : Form
    {
        public frm_enrollment()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Enrolment values (@studentID, @coureseID)", con);
            cmd.Parameters.AddWithValue("@studentID", txt_EnrolmentID.Text);
            cmd.Parameters.AddWithValue("@coureseID", txt_EnrolmentCourseID.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void btn_Retrieve_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Enrolment", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            grd_Enrollment.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Enrolment SET coureseID = @coureseID Where studentID = @studentID", con);
            cmd.Parameters.AddWithValue("@studentID", txt_EnrolmentID.Text);
            cmd.Parameters.AddWithValue("@coureseID", txt_EnrolmentCourseID.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE From Enrolment Where studentID = @studentID", con);
            cmd.Parameters.AddWithValue("@studentID", txt_EnrolmentID.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Delete");
        }

        private void txt_EnrolmentID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
