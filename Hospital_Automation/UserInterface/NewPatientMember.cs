using System;
using System.Windows.Forms;
using BusinessLogic;
using DataAccess;
using Entities;

namespace UserInterface
{
    public partial class NewPatientMember : Form
    {
        PatientController patientController;
        PatientManagement patientManagement;
        PatientLoginDetailManagement patientLoginDetailManagement;

        public NewPatientMember()
        {
            InitializeComponent();
            patientManagement = new PatientManagement();
            patientLoginDetailManagement = new PatientLoginDetailManagement();
            patientController = new PatientController();
        }

        private void btnPatientMemberSave_Click(object sender, EventArgs e)
        {
            long tc = Convert.ToInt64(txtPatientPersonelIdentifyNumber.Text);
            string username = txtNewPatientEmail.Text.Trim();
            string password = txtNewPatientPassword.Text.Trim();

            Patient patient = new Patient
            {
                FirstName = txtPatientName.Text.Trim(),
                LastName = txtPatientSurname.Text.Trim(),
                Phone = txtPatientPhone.Text.Trim(),
                BirthDate = Convert.ToDateTime(dateTimePicker1.Value.ToShortDateString()),
                TCNumber = tc,
                Gender = Convert.ToBoolean(cmbGender.SelectedValue),

            };
            var result = patientController.AddPatient(patient);



            if (LoginDetailCheck(username, password) == false)
            {
                lblWarning.Text = "E-Mail/Şifreyi Düzgün Formatta Giriniz!";
            }
            else
            {
                var result2 = patientManagement.SearchPatient(tc);
                PatientLoginDetail patientLoginDetail = new PatientLoginDetail
                {
                    PatientId = result2,
                    UserName = username,
                    Password = password,
                    Status = true
                };

                patientLoginDetailManagement.AddPatientLoginDetail(patientLoginDetail);
            }

            //Gb_PatientDetailClear();
        }

        private bool LoginDetailCheck(string username, string password)
        {
            var user = Validator.isEmailValid(username);
            var pass = Validator.isPasswordValid(password);
            if (user == false && pass == false)
            {
                return false;
            }
            else
            {
                return true;
            }

        }
        private void Gb_PatientDetailClear()
        {
            foreach (Control item in gbPatientDetails.Controls)
            {
                if (item is TextBox)
                {
                    TextBox textBox = (TextBox)item;
                    textBox.Clear();
                }
                else
                {
                    dateTimePicker1.Value = DateTime.Now;
                    cmbGender.SelectedIndex = 0;
                }
            }
        }
    }


}
