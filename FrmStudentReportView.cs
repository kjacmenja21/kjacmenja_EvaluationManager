using Evaluation_Manager.Models;
using Evaluation_Manager.Repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmStudentReportView : Form
    {
        public FrmStudentReportView()
        {
            InitializeComponent();
        }

        private void FrmStudentReportView_Load(object sender, EventArgs e)
        {
            var students = StudentRepository.GetStudents();
            var reportViewList = new List<StudentReportView>();

            foreach(var student in students)
            {
                reportViewList.Add(new StudentReportView(student));
            }
            dgvReport.DataSource = reportViewList;
        }
    }
}
