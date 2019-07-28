using System;
using System.Windows.Forms;
using DataAccess;
using Entities;

namespace UserInterface
{
    public partial class LoginSystem : Form
    {
        public LoginSystem()
        {
            InitializeComponent();
        }
        int rol = 0;
        private void btnPatient_Click(object sender, EventArgs e)
        {
            rol = 1;
            pnlLogin.Enabled = true;
        }

        private void btnDoctor_Click(object sender, EventArgs e)
        {
            rol = 2;
            pnlLogin.Enabled = true;

        }

        private void btnPharmacist_Click(object sender, EventArgs e)
        {
            rol = 3;
            pnlLogin.Enabled = true;

        }

        private void LoginSystem_Load(object sender, EventArgs e)
        {
            pnlLogin.Enabled = false;
            
        }        

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var passwordResult = Validator.isPasswordValid(txtPassword.Text);
            
            switch (rol)
            {
                case 1:
                    
                    var mailResult = Validator.isEmailValid(txtEmail.Text);

                    if (mailResult == false && passwordResult == false)
                    {
                        lblWarning.Text = "Lütfen Kullanıcı Bilgilerinizi Doğru Formatta Giriniz!";
                    }//Kullanıcı Adı ve Şifre Yanlışsa
                    else
                    {
                        PatientLoginDetailManagement patientLogin = new PatientLoginDetailManagement();
                        PatientLoginDetail patient = new PatientLoginDetail
                        
                        {
                            UserName = txtEmail.Text.Trim(),
                            Password = txtPassword.Text.Trim()
                        };

                        var patientResult = patientLogin.FindPatient(patient);
                        if (patientResult== null)
                        {
                            lblWarning.Text = "Lütfen Kullanıcı Bilgilerini Kontrol Ediniz!";
                        }
                        else
                        {
                            AppointmentSystem appointmentSystem = new AppointmentSystem();
                            appointmentSystem.UserID = patientResult.PatientId;
                            appointmentSystem.Show();

                        }
                       

                    }//Kullanıcı Adı ve Şifre Doğruysa
                    break;


                case 2:
                    var drusernameResult = Validator.isDoctorUserNameValid(txtEmail.Text);

                    if (drusernameResult == false && passwordResult == false)
                    {
                        lblWarning.Text = "Lütfen Kullanıcı Bilgilerinizi Doğru Formatta Giriniz!";
                    }
                    else
                    {
                        DoctorLoginDetailManagement doctorLogin = new DoctorLoginDetailManagement();
                        DoctorLoginDetail doctor = new DoctorLoginDetail
                        {
                            UserName = txtEmail.Text.Trim(),
                            Password = txtPassword.Text.Trim()

                        };
                        if (doctorLogin.FindDoctor(doctor) == null)
                        {
                            lblWarning.Text = "Lütfen Kullanıcı Bilgilerini Kontrol Ediniz!";

                        }
                        else
                        {
                            DoctorSystemScreen doctorSystemScreen = new DoctorSystemScreen();
                            doctorSystemScreen.doctorId = doctorLogin.FindDoctor(doctor).DoctorId;
                            doctorSystemScreen.Show();

                        }
                    }
                    break;


                case 3:
                    var phusernameResult = Validator.isPharmacistUserNameValid(txtEmail.Text);

                    PharmacistLoginDetailManagement pharmacistLogin = new PharmacistLoginDetailManagement();
                    PharmacistLoginDetail pharmacist = new PharmacistLoginDetail
                    {
                        UserName = txtEmail.Text.Trim(),
                        Password = txtPassword.Text.Trim()

                    };

                    if (phusernameResult == false && passwordResult == false)
                    {
                        lblWarning.Text = "Lütfen Kullanıcı Bilgilerinizi Doğru Formatta Giriniz!";

                    }
                    else
                    {

                        var pharmacistResult = pharmacistLogin.FindPharmacist(pharmacist);
                        if(pharmacist==null)
                            
                        {
                            lblWarning.Text = "Lütfen Kullanıcı Bilgilerini Kontrol Ediniz!";

                        }
                        else
                        {
                            PharmacistSystemScreen pharmacistSystemScreen = new PharmacistSystemScreen();
                            pharmacistSystemScreen.getPharmacistId = pharmacistResult.PharmacistId;
                            pharmacistSystemScreen.Show();
                        }

                    }

                    break;
                                                         
            }



        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            NewPatientMember newPatientMember = new NewPatientMember();
            newPatientMember.Show();
        }
        public string result;

          }
}

