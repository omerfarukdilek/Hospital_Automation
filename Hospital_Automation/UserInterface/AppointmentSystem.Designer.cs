namespace UserInterface
{
    partial class AppointmentSystem
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
            this.dtGridViewAvailableDoctorsandHospitals = new System.Windows.Forms.DataGridView();
            this.dtGridViewSelectedDoctorDate = new System.Windows.Forms.DataGridView();
            this.lblPatient = new System.Windows.Forms.Label();
            this.gbHospitalAppointment = new System.Windows.Forms.GroupBox();
            this.dpDate = new System.Windows.Forms.DateTimePicker();
            this.lblDate = new System.Windows.Forms.Label();
            this.cmbChooseDoctor = new System.Windows.Forms.ComboBox();
            this.lblChooseDoctor = new System.Windows.Forms.Label();
            this.cmbClinicLocation = new System.Windows.Forms.ComboBox();
            this.lblInspectionLocation = new System.Windows.Forms.Label();
            this.cmbPolyclinic = new System.Windows.Forms.ComboBox();
            this.lblClinic = new System.Windows.Forms.Label();
            this.cmbHospital = new System.Windows.Forms.ComboBox();
            this.lblHospital = new System.Windows.Forms.Label();
            this.btnDeleteAppointment = new System.Windows.Forms.Button();
            this.btnSearchHospitalAppointment = new System.Windows.Forms.Button();
            this.lblPatientName = new System.Windows.Forms.Label();
            this.btnSaveAppointment = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAvailableDoctorsandHospitals)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewSelectedDoctorDate)).BeginInit();
            this.gbHospitalAppointment.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridViewAvailableDoctorsandHospitals
            // 
            this.dtGridViewAvailableDoctorsandHospitals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewAvailableDoctorsandHospitals.Location = new System.Drawing.Point(15, 378);
            this.dtGridViewAvailableDoctorsandHospitals.Name = "dtGridViewAvailableDoctorsandHospitals";
            this.dtGridViewAvailableDoctorsandHospitals.Size = new System.Drawing.Size(754, 190);
            this.dtGridViewAvailableDoctorsandHospitals.TabIndex = 40;
            this.dtGridViewAvailableDoctorsandHospitals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewAvailableDoctorsandHospitals_CellContentClick);
            // 
            // dtGridViewSelectedDoctorDate
            // 
            this.dtGridViewSelectedDoctorDate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewSelectedDoctorDate.Location = new System.Drawing.Point(366, 50);
            this.dtGridViewSelectedDoctorDate.Name = "dtGridViewSelectedDoctorDate";
            this.dtGridViewSelectedDoctorDate.Size = new System.Drawing.Size(403, 311);
            this.dtGridViewSelectedDoctorDate.TabIndex = 35;
            this.dtGridViewSelectedDoctorDate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtGridViewSelectedDoctorDate_CellContentClick);
            // 
            // lblPatient
            // 
            this.lblPatient.AutoSize = true;
            this.lblPatient.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatient.Location = new System.Drawing.Point(12, 9);
            this.lblPatient.Name = "lblPatient";
            this.lblPatient.Size = new System.Drawing.Size(30, 17);
            this.lblPatient.TabIndex = 43;
            this.lblPatient.Text = "Sn.";
            // 
            // gbHospitalAppointment
            // 
            this.gbHospitalAppointment.Controls.Add(this.btnSaveAppointment);
            this.gbHospitalAppointment.Controls.Add(this.dpDate);
            this.gbHospitalAppointment.Controls.Add(this.lblDate);
            this.gbHospitalAppointment.Controls.Add(this.cmbChooseDoctor);
            this.gbHospitalAppointment.Controls.Add(this.lblChooseDoctor);
            this.gbHospitalAppointment.Controls.Add(this.cmbClinicLocation);
            this.gbHospitalAppointment.Controls.Add(this.lblInspectionLocation);
            this.gbHospitalAppointment.Controls.Add(this.cmbPolyclinic);
            this.gbHospitalAppointment.Controls.Add(this.lblClinic);
            this.gbHospitalAppointment.Controls.Add(this.cmbHospital);
            this.gbHospitalAppointment.Controls.Add(this.lblHospital);
            this.gbHospitalAppointment.Controls.Add(this.btnDeleteAppointment);
            this.gbHospitalAppointment.Controls.Add(this.btnSearchHospitalAppointment);
            this.gbHospitalAppointment.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbHospitalAppointment.Location = new System.Drawing.Point(12, 42);
            this.gbHospitalAppointment.Name = "gbHospitalAppointment";
            this.gbHospitalAppointment.Size = new System.Drawing.Size(337, 330);
            this.gbHospitalAppointment.TabIndex = 44;
            this.gbHospitalAppointment.TabStop = false;
            this.gbHospitalAppointment.Text = "Hastane Randevu Arama";
            // 
            // dpDate
            // 
            this.dpDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dpDate.Location = new System.Drawing.Point(127, 41);
            this.dpDate.Name = "dpDate";
            this.dpDate.Size = new System.Drawing.Size(200, 22);
            this.dpDate.TabIndex = 54;
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDate.Location = new System.Drawing.Point(9, 44);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(39, 16);
            this.lblDate.TabIndex = 53;
            this.lblDate.Text = "Tarih:";
            // 
            // cmbChooseDoctor
            // 
            this.cmbChooseDoctor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbChooseDoctor.FormattingEnabled = true;
            this.cmbChooseDoctor.Location = new System.Drawing.Point(127, 182);
            this.cmbChooseDoctor.Name = "cmbChooseDoctor";
            this.cmbChooseDoctor.Size = new System.Drawing.Size(200, 24);
            this.cmbChooseDoctor.TabIndex = 52;
            this.cmbChooseDoctor.SelectedIndexChanged += new System.EventHandler(this.cmbChooseDoctor_SelectedIndexChanged);
            // 
            // lblChooseDoctor
            // 
            this.lblChooseDoctor.AutoSize = true;
            this.lblChooseDoctor.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblChooseDoctor.Location = new System.Drawing.Point(9, 185);
            this.lblChooseDoctor.Name = "lblChooseDoctor";
            this.lblChooseDoctor.Size = new System.Drawing.Size(49, 16);
            this.lblChooseDoctor.TabIndex = 51;
            this.lblChooseDoctor.Text = "Hekim:";
            // 
            // cmbClinicLocation
            // 
            this.cmbClinicLocation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbClinicLocation.FormattingEnabled = true;
            this.cmbClinicLocation.Location = new System.Drawing.Point(127, 144);
            this.cmbClinicLocation.Name = "cmbClinicLocation";
            this.cmbClinicLocation.Size = new System.Drawing.Size(200, 24);
            this.cmbClinicLocation.TabIndex = 50;
            // 
            // lblInspectionLocation
            // 
            this.lblInspectionLocation.AutoSize = true;
            this.lblInspectionLocation.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInspectionLocation.Location = new System.Drawing.Point(9, 113);
            this.lblInspectionLocation.Name = "lblInspectionLocation";
            this.lblInspectionLocation.Size = new System.Drawing.Size(60, 16);
            this.lblInspectionLocation.TabIndex = 49;
            this.lblInspectionLocation.Text = "Poliklinik";
            // 
            // cmbPolyclinic
            // 
            this.cmbPolyclinic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbPolyclinic.FormattingEnabled = true;
            this.cmbPolyclinic.Location = new System.Drawing.Point(127, 110);
            this.cmbPolyclinic.Name = "cmbPolyclinic";
            this.cmbPolyclinic.Size = new System.Drawing.Size(200, 24);
            this.cmbPolyclinic.TabIndex = 48;
            this.cmbPolyclinic.SelectedIndexChanged += new System.EventHandler(this.cmbPolyclinic_SelectedIndexChanged);
            // 
            // lblClinic
            // 
            this.lblClinic.AutoSize = true;
            this.lblClinic.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblClinic.Location = new System.Drawing.Point(9, 147);
            this.lblClinic.Name = "lblClinic";
            this.lblClinic.Size = new System.Drawing.Size(75, 16);
            this.lblClinic.TabIndex = 47;
            this.lblClinic.Text = "Departman:";
            // 
            // cmbHospital
            // 
            this.cmbHospital.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbHospital.FormattingEnabled = true;
            this.cmbHospital.Location = new System.Drawing.Point(127, 76);
            this.cmbHospital.Name = "cmbHospital";
            this.cmbHospital.Size = new System.Drawing.Size(200, 24);
            this.cmbHospital.TabIndex = 46;
            this.cmbHospital.SelectedIndexChanged += new System.EventHandler(this.cmbHospital_SelectedIndexChanged);
            // 
            // lblHospital
            // 
            this.lblHospital.AutoSize = true;
            this.lblHospital.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHospital.Location = new System.Drawing.Point(9, 76);
            this.lblHospital.Name = "lblHospital";
            this.lblHospital.Size = new System.Drawing.Size(60, 16);
            this.lblHospital.TabIndex = 45;
            this.lblHospital.Text = "Hastane:";
            // 
            // btnDeleteAppointment
            // 
            this.btnDeleteAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeleteAppointment.Location = new System.Drawing.Point(12, 231);
            this.btnDeleteAppointment.Name = "btnDeleteAppointment";
            this.btnDeleteAppointment.Size = new System.Drawing.Size(72, 41);
            this.btnDeleteAppointment.TabIndex = 44;
            this.btnDeleteAppointment.Text = "Temizle";
            this.btnDeleteAppointment.UseVisualStyleBackColor = true;
            this.btnDeleteAppointment.Click += new System.EventHandler(this.btnDeleteAppointment_Click_1);
            // 
            // btnSearchHospitalAppointment
            // 
            this.btnSearchHospitalAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchHospitalAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSearchHospitalAppointment.Location = new System.Drawing.Point(127, 231);
            this.btnSearchHospitalAppointment.Name = "btnSearchHospitalAppointment";
            this.btnSearchHospitalAppointment.Size = new System.Drawing.Size(200, 41);
            this.btnSearchHospitalAppointment.TabIndex = 43;
            this.btnSearchHospitalAppointment.Text = "Randevu Ara";
            this.btnSearchHospitalAppointment.UseVisualStyleBackColor = true;
            this.btnSearchHospitalAppointment.Click += new System.EventHandler(this.btnSearchHospitalAppointment_Click);
            // 
            // lblPatientName
            // 
            this.lblPatientName.AutoSize = true;
            this.lblPatientName.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPatientName.Location = new System.Drawing.Point(48, 9);
            this.lblPatientName.Name = "lblPatientName";
            this.lblPatientName.Size = new System.Drawing.Size(0, 17);
            this.lblPatientName.TabIndex = 45;
            // 
            // btnSaveAppointment
            // 
            this.btnSaveAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSaveAppointment.ForeColor = System.Drawing.Color.Maroon;
            this.btnSaveAppointment.Location = new System.Drawing.Point(12, 278);
            this.btnSaveAppointment.Name = "btnSaveAppointment";
            this.btnSaveAppointment.Size = new System.Drawing.Size(315, 41);
            this.btnSaveAppointment.TabIndex = 55;
            this.btnSaveAppointment.Text = "Randevuyu Kaydet";
            this.btnSaveAppointment.UseVisualStyleBackColor = true;
            // 
            // AppointmentSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 590);
            this.Controls.Add(this.lblPatientName);
            this.Controls.Add(this.gbHospitalAppointment);
            this.Controls.Add(this.lblPatient);
            this.Controls.Add(this.dtGridViewAvailableDoctorsandHospitals);
            this.Controls.Add(this.dtGridViewSelectedDoctorDate);
            this.Name = "AppointmentSystem";
            this.Text = "Randevu Al";
            this.Load += new System.EventHandler(this.AppointmentSystem_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewAvailableDoctorsandHospitals)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewSelectedDoctorDate)).EndInit();
            this.gbHospitalAppointment.ResumeLayout(false);
            this.gbHospitalAppointment.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtGridViewAvailableDoctorsandHospitals;
        private System.Windows.Forms.DataGridView dtGridViewSelectedDoctorDate;
        private System.Windows.Forms.Label lblPatient;
        private System.Windows.Forms.GroupBox gbHospitalAppointment;
        private System.Windows.Forms.DateTimePicker dpDate;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.ComboBox cmbChooseDoctor;
        private System.Windows.Forms.Label lblChooseDoctor;
        private System.Windows.Forms.ComboBox cmbClinicLocation;
        private System.Windows.Forms.Label lblInspectionLocation;
        private System.Windows.Forms.ComboBox cmbPolyclinic;
        private System.Windows.Forms.Label lblClinic;
        private System.Windows.Forms.ComboBox cmbHospital;
        private System.Windows.Forms.Label lblHospital;
        private System.Windows.Forms.Button btnDeleteAppointment;
        private System.Windows.Forms.Button btnSearchHospitalAppointment;
        private System.Windows.Forms.Label lblPatientName;
        private System.Windows.Forms.Button btnSaveAppointment;
    }
}