using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Lab2
{
    public partial class frm_desktop : Form
    {
        public frm_desktop()
        {
            InitializeComponent();
        }

        private void tbl_ViewPannel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lbl_CRUD_Click(object sender, EventArgs e)
        {
            frmCrud frmcrud = new frmCrud();
            frmcrud.ShowDialog();
        }

        private void lbl_Course_Click(object sender, EventArgs e)
        {
            frm_Course frmcourse = new frm_Course();
            frmcourse.ShowDialog();
        }

        private void lbl_Enrollment_Click(object sender, EventArgs e)
        {
            frm_enrollment enrollment = new frm_enrollment();
            enrollment.ShowDialog();
        }

        private void lbl_Attendance_Click(object sender, EventArgs e)
        {
            frm_attendance attendance = new frm_attendance();
            attendance.ShowDialog();
        }
    }
}
