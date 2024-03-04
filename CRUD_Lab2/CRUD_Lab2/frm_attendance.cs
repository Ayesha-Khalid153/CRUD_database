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
    public partial class frm_attendance : Form
    {
        public frm_attendance()
        {
            InitializeComponent();
        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Attendance values (@ID, @CourseName, @Time, @Status)", con);
            cmd.Parameters.AddWithValue("@ID", txt_AttendanceID.Text);
            cmd.Parameters.AddWithValue("@CourseName", txt_AttendanceCourse.Text);
            cmd.Parameters.AddWithValue("@Time", txt_Attendancetime.Text);
            bool t = false;
            if (txt_AttendanceStatus.Text != "0")
                t = true;
            cmd.Parameters.AddWithValue("@Status", t);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");

        }

        private void btn_Retrieve_Click(object sender, EventArgs e)
        {

            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Select * from Attendance", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Update Attendance SET ID = @ID, CourseName = @CourseName, Time  = @Time, Status = @Status Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_AttendanceID.Text);
            cmd.Parameters.AddWithValue("@CourseName", txt_AttendanceCourse.Text);
            cmd.Parameters.AddWithValue("@Time", txt_Attendancetime.Text);
            bool t = false;
            if (txt_AttendanceStatus.Text != "0")
                t = true;
            cmd.Parameters.AddWithValue("@Status", t);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Updated");

        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("DELETE FROM Attendance Where ID = @ID", con);
            cmd.Parameters.AddWithValue("@ID", txt_AttendanceID.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully Delete");
        }

        private void txt_Attendancetime_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
