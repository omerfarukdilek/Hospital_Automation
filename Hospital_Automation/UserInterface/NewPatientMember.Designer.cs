namespace UserInterface
{
    partial class NewPatientMember
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlHospitalAppointment = new System.Windows.Forms.Panel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtNewPatientEmail = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtNewPatientPassword = new System.Windows.Forms.TextBox();
            this.lblNewPatientPassword = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.txtPatientPersonelIdentifyNumber = new System.Windows.Forms.TextBox();
            this.txtPatientPhone = new System.Windows.Forms.TextBox();
            this.txtPatientSurname = new System.Windows.Forms.TextBox();
            this.txtPatientName = new System.Windows.Forms.TextBox();
            this.lblPatientPersonelIdentifyNumber = new System.Windows.Forms.Label();
            this.lblPatientPhone = new System.Windows.Forms.Label();
            this.lblPatientSurname = new System.Windows.Forms.Label();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.btnPatientMemberSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLoginDetail = new System.Windows.Forms.GroupBox();
            this.gbPatientDetails = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.pnlHospitalAppointment.SuspendLayout();
            this.gbLoginDetail.SuspendLayout();
            this.gbPatientDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHospitalAppointment
            // 
            this.pnlHospitalAppointment.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlHospitalAppointment.Controls.Add(this.lblWarning);
            this.pnlHospitalAppointment.Controls.Add(this.gbPatientDetails);
            this.pnlHospitalAppointment.Controls.Add(this.gbLoginDetail);
            this.pnlHospitalAppointment.Controls.Add(this.btnPatientMemberSave);
            this.pnlHospitalAppointment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHospitalAppointment.Location = new System.Drawing.Point(0, 0);
            this.pnlHospitalAppointment.Name = "pnlHospitalAppointment";
            this.pnlHospitalAppointment.Size = new System.Drawing.Size(416, 478);
            this.pnlHospitalAppointment.TabIndex = 9;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarFont = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(136, 180);
            this.dateTimePicker1.MinDate = new System.DateTime(1910, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(177, 25);
            this.dateTimePicker1.TabIndex = 32;
            // 
            // txtNewPatientEmail
            // 
            this.txtNewPatientEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPatientEmail.Location = new System.Drawing.Point(136, 43);
            this.txtNewPatientEmail.Name = "txtNewPatientEmail";
            this.txtNewPatientEmail.Size = new System.Drawing.Size(177, 22);
            this.txtNewPatientEmail.TabIndex = 31;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblCity.Location = new System.Drawing.Point(26, 45);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(54, 17);
            this.lblCity.TabIndex = 30;
            this.lblCity.Text = "E-mail:";
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.cmbGender.Location = new System.Drawing.Point(136, 220);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(177, 25);
            this.cmbGender.TabIndex = 29;
            // 
            // txtNewPatientPassword
            // 
            this.txtNewPatientPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtNewPatientPassword.Location = new System.Drawing.Point(136, 80);
            this.txtNewPatientPassword.Name = "txtNewPatientPassword";
            this.txtNewPatientPassword.Size = new System.Drawing.Size(177, 22);
            this.txtNewPatientPassword.TabIndex = 28;
            // 
            // lblNewPatientPassword
            // 
            this.lblNewPatientPassword.AutoSize = true;
            this.lblNewPatientPassword.BackColor = System.Drawing.Color.Transparent;
            this.lblNewPatientPassword.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblNewPatientPassword.Location = new System.Drawing.Point(26, 82);
            this.lblNewPatientPassword.Name = "lblNewPatientPassword";
            this.lblNewPatientPassword.Size = new System.Drawing.Size(54, 17);
            this.lblNewPatientPassword.TabIndex = 27;
            this.lblNewPatientPassword.Text = "Parola:";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.BackColor = System.Drawing.Color.Transparent;
            this.lblSex.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSex.Location = new System.Drawing.Point(26, 220);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(64, 17);
            this.lblSex.TabIndex = 24;
            this.lblSex.Text = "Cinsiyet:";
            // 
            // txtPatientPersonelIdentifyNumber
            // 
            this.txtPatientPersonelIdentifyNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientPersonelIdentifyNumber.Location = new System.Drawing.Point(136, 145);
            this.txtPatientPersonelIdentifyNumber.Name = "txtPatientPersonelIdentifyNumber";
            this.txtPatientPersonelIdentifyNumber.Size = new System.Drawing.Size(177, 22);
            this.txtPatientPersonelIdentifyNumber.TabIndex = 22;
            // 
            // txtPatientPhone
            // 
            this.txtPatientPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientPhone.Location = new System.Drawing.Point(136, 109);
            this.txtPatientPhone.Name = "txtPatientPhone";
            this.txtPatientPhone.Size = new System.Drawing.Size(177, 22);
            this.txtPatientPhone.TabIndex = 21;
            // 
            // txtPatientSurname
            // 
            this.txtPatientSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientSurname.Location = new System.Drawing.Point(136, 73);
            this.txtPatientSurname.Name = "txtPatientSurname";
            this.txtPatientSurname.Size = new System.Drawing.Size(177, 22);
            this.txtPatientSurname.TabIndex = 20;
            // 
            // txtPatientName
            // 
            this.txtPatientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPatientName.Location = new System.Drawing.Point(136, 37);
            this.txtPatientName.Name = "txtPatientName";
            this.txtPatientName.Size = new System.Drawing.Size(177, 22);
            this.txtPatientName.TabIndex = 19;
            // 
            // lblPatientPersonelIdentifyNumber
            // 
            this.lblPatientPersonelIdentifyNumber.AutoSize = true;
            this.lblPatientPersonelIdentifyNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientPersonelIdentifyNumber.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientPersonelIdentifyNumber.Location = new System.Drawing.Point(26, 147);
            this.lblPatientPersonelIdentifyNumber.Name = "lblPatientPersonelIdentifyNumber";
            this.lblPatientPersonelIdentifyNumber.Size = new System.Drawing.Size(60, 17);
            this.lblPatientPersonelIdentifyNumber.TabIndex = 17;
            this.lblPatientPersonelIdentifyNumber.Text = "T.C. No:";
            // 
            // lblPatientPhone
            // 
            this.lblPatientPhone.AutoSize = true;
            this.lblPatientPhone.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientPhone.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientPhone.Location = new System.Drawing.Point(26, 111);
            this.lblPatientPhone.Name = "lblPatientPhone";
            this.lblPatientPhone.Size = new System.Drawing.Size(58, 17);
            this.lblPatientPhone.TabIndex = 14;
            this.lblPatientPhone.Text = "Telefon:";
            // 
            // lblPatientSurname
            // 
            this.lblPatientSurname.AutoSize = true;
            this.lblPatientSurname.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientSurname.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientSurname.Location = new System.Drawing.Point(26, 75);
            this.lblPatientSurname.Name = "lblPatientSurname";
            this.lblPatientSurname.Size = new System.Drawing.Size(53, 17);
            this.lblPatientSurname.TabIndex = 12;
            this.lblPatientSurname.Text = "Soyad:";
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.BackColor = System.Drawing.Color.Transparent;
            this.lblPatientName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientName.Location = new System.Drawing.Point(26, 39);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(29, 17);
            this.lblPatientName.TabIndex = 9;
            this.lblPatientName.Text = "Ad:";
            // 
            // btnPatientMemberSave
            // 
            this.btnPatientMemberSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPatientMemberSave.ForeColor = System.Drawing.Color.Red;
            this.btnPatientMemberSave.Location = new System.Drawing.Point(304, 427);
            this.btnPatientMemberSave.Name = "btnPatientMemberSave";
            this.btnPatientMemberSave.Size = new System.Drawing.Size(100, 41);
            this.btnPatientMemberSave.TabIndex = 4;
            this.btnPatientMemberSave.Text = "Kaydet";
            this.btnPatientMemberSave.UseVisualStyleBackColor = true;
            this.btnPatientMemberSave.Click += new System.EventHandler(this.btnPatientMemberSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(26, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 33;
            this.label1.Text = "Doğum Tarihi:";
            // 
            // gbLoginDetail
            // 
            this.gbLoginDetail.Controls.Add(this.txtNewPatientEmail);
            this.gbLoginDetail.Controls.Add(this.lblNewPatientPassword);
            this.gbLoginDetail.Controls.Add(this.txtNewPatientPassword);
            this.gbLoginDetail.Controls.Add(this.lblCity);
            this.gbLoginDetail.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbLoginDetail.Location = new System.Drawing.Point(12, 294);
            this.gbLoginDetail.Name = "gbLoginDetail";
            this.gbLoginDetail.Size = new System.Drawing.Size(392, 127);
            this.gbLoginDetail.TabIndex = 34;
            this.gbLoginDetail.TabStop = false;
            this.gbLoginDetail.Text = "Kullanıcı Adı Ve Şifre";
            // 
            // gbPatientDetails
            // 
            this.gbPatientDetails.Controls.Add(this.txtPatientName);
            this.gbPatientDetails.Controls.Add(this.lblPatientName);
            this.gbPatientDetails.Controls.Add(this.label1);
            this.gbPatientDetails.Controls.Add(this.lblPatientSurname);
            this.gbPatientDetails.Controls.Add(this.dateTimePicker1);
            this.gbPatientDetails.Controls.Add(this.lblPatientPhone);
            this.gbPatientDetails.Controls.Add(this.cmbGender);
            this.gbPatientDetails.Controls.Add(this.lblPatientPersonelIdentifyNumber);
            this.gbPatientDetails.Controls.Add(this.lblSex);
            this.gbPatientDetails.Controls.Add(this.txtPatientSurname);
            this.gbPatientDetails.Controls.Add(this.txtPatientPersonelIdentifyNumber);
            this.gbPatientDetails.Controls.Add(this.txtPatientPhone);
            this.gbPatientDetails.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbPatientDetails.Location = new System.Drawing.Point(12, 16);
            this.gbPatientDetails.Name = "gbPatientDetails";
            this.gbPatientDetails.Size = new System.Drawing.Size(392, 261);
            this.gbPatientDetails.TabIndex = 35;
            this.gbPatientDetails.TabStop = false;
            this.gbPatientDetails.Text = "Kullanıcı Bilgileri";
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.BackColor = System.Drawing.Color.Transparent;
            this.lblWarning.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWarning.Location = new System.Drawing.Point(19, 438);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(0, 17);
            this.lblWarning.TabIndex = 36;
            // 
            // NewPatientMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 478);
            this.Controls.Add(this.pnlHospitalAppointment);
            this.Name = "NewPatientMember";
            this.Text = "Üye Ol";
            this.pnlHospitalAppointment.ResumeLayout(false);
            this.pnlHospitalAppointment.PerformLayout();
            this.gbLoginDetail.ResumeLayout(false);
            this.gbLoginDetail.PerformLayout();
            this.gbPatientDetails.ResumeLayout(false);
            this.gbPatientDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHospitalAppointment;
        private System.Windows.Forms.TextBox txtNewPatientPassword;
        private System.Windows.Forms.Label lblNewPatientPassword;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.TextBox txtPatientPersonelIdentifyNumber;
        private System.Windows.Forms.TextBox txtPatientPhone;
        private System.Windows.Forms.TextBox txtPatientSurname;
        private System.Windows.Forms.TextBox txtPatientName;
        private System.Windows.Forms.Label lblPatientPersonelIdentifyNumber;
        private System.Windows.Forms.Label lblPatientPhone;
        private System.Windows.Forms.Label lblPatientSurname;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Button btnPatientMemberSave;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtNewPatientEmail;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.GroupBox gbLoginDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbPatientDetails;
        private System.Windows.Forms.Label lblWarning;
    }
}