using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UserInterface
{
    public partial class Analysis : Form
    {
        public Analysis()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            string analysis = string.Empty;
            DoctorExaminationSystem   doctorExamination = new DoctorExaminationSystem();
            foreach (CheckBox item in pnlAnalysis.Controls)
            {
                if (item.Checked==true)
                {
                    analysis += item.Text + ",";
                }
            }
            doctorExamination.Analysis = analysis;
            this.Close();
        }
    }
}
