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
    public partial class frm_Crud : Form
    {
        public frm_Crud()
        {
            InitializeComponent();
        }

        private void lbl_StudentsRecord_Click(object sender, EventArgs e)
        {

        }

        private void btn_Create_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("Insert into Students values (@ID, @Name, @Department, @Session, @CGPA, @Adress", con);
            cmd.Parameters.AddWithValue("@ID", txt_ID.Text);
            cmd.Parameters.AddWithValue("@Name", txt_Name.Text);
            cmd.Parameters.AddWithValue("@Department",txt_Department.Text);
            cmd.Parameters.AddWithValue("@Session", txt_Session.Text);
            cmd.Parameters.AddWithValue("@CGPA", float.Parse(txt_CGPA.Text));
            cmd.Parameters.AddWithValue("@Adress", txt_Adress.Text);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        private void frm_Crud_Load(object sender, EventArgs e)
        {

        }
    }
}
