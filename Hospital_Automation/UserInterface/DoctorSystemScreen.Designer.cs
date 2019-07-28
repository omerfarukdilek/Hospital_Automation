namespace UserInterface
{
    partial class DoctorSystemScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorSystemScreen));
            this.pnlDoctorScreen = new System.Windows.Forms.Panel();
            this.pictureBoxHospitalAppointment = new System.Windows.Forms.PictureBox();
            this.dtPickerWorkingDate = new System.Windows.Forms.DateTimePicker();
            this.lblWorkingDate = new System.Windows.Forms.Label();
            this.dtGridViewDoctorAppointmentScreen = new System.Windows.Forms.DataGridView();
            this.btnCreateInspection = new System.Windows.Forms.Button();
            this.pnlDoctorScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalAppointment)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDoctorAppointmentScreen)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlDoctorScreen
            // 
            this.pnlDoctorScreen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlDoctorScreen.Controls.Add(this.pictureBoxHospitalAppointment);
            this.pnlDoctorScreen.Controls.Add(this.dtPickerWorkingDate);
            this.pnlDoctorScreen.Controls.Add(this.lblWorkingDate);
            this.pnlDoctorScreen.Controls.Add(this.dtGridViewDoctorAppointmentScreen);
            this.pnlDoctorScreen.Controls.Add(this.btnCreateInspection);
            this.pnlDoctorScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDoctorScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlDoctorScreen.Name = "pnlDoctorScreen";
            this.pnlDoctorScreen.Size = new System.Drawing.Size(796, 470);
            this.pnlDoctorScreen.TabIndex = 11;
            // 
            // pictureBoxHospitalAppointment
            // 
            this.pictureBoxHospitalAppointment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalAppointment.Image")));
            this.pictureBoxHospitalAppointment.Location = new System.Drawing.Point(707, 0);
            this.pictureBoxHospitalAppointment.Name = "pictureBoxHospitalAppointment";
            this.pictureBoxHospitalAppointment.Size = new System.Drawing.Size(81, 71);
            this.pictureBoxHospitalAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHospitalAppointment.TabIndex = 25;
            this.pictureBoxHospitalAppointment.TabStop = false;
            // 
            // dtPickerWorkingDate
            // 
            this.dtPickerWorkingDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtPickerWorkingDate.Location = new System.Drawing.Point(123, 31);
            this.dtPickerWorkingDate.Name = "dtPickerWorkingDate";
            this.dtPickerWorkingDate.Size = new System.Drawing.Size(244, 25);
            this.dtPickerWorkingDate.TabIndex = 23;
            this.dtPickerWorkingDate.ValueChanged += new System.EventHandler(this.dtPickerWorkingDate_ValueChanged);
            // 
            // lblWorkingDate
            // 
            this.lblWorkingDate.AutoSize = true;
            this.lblWorkingDate.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblWorkingDate.Location = new System.Drawing.Point(12, 37);
            this.lblWorkingDate.Name = "lblWorkingDate";
            this.lblWorkingDate.Size = new System.Drawing.Size(105, 17);
            this.lblWorkingDate.TabIndex = 22;
            this.lblWorkingDate.Text = "Çalışma Günü:";
            // 
            // dtGridViewDoctorAppointmentScreen
            // 
            this.dtGridViewDoctorAppointmentScreen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewDoctorAppointmentScreen.Location = new System.Drawing.Point(12, 89);
            this.dtGridViewDoctorAppointmentScreen.Name = "dtGridViewDoctorAppointmentScreen";
            this.dtGridViewDoctorAppointmentScreen.Size = new System.Drawing.Size(776, 283);
            this.dtGridViewDoctorAppointmentScreen.TabIndex = 16;
            // 
            // btnCreateInspection
            // 
            this.btnCreateInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateInspection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateInspection.Location = new System.Drawing.Point(543, 390);
            this.btnCreateInspection.Name = "btnCreateInspection";
            this.btnCreateInspection.Size = new System.Drawing.Size(245, 41);
            this.btnCreateInspection.TabIndex = 3;
            this.btnCreateInspection.Text = "Muayene Oluştur";
            this.btnCreateInspection.UseVisualStyleBackColor = true;
            this.btnCreateInspection.Click += new System.EventHandler(this.btnCreateInspection_Click);
            // 
            // DoctorSystemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 470);
            this.Controls.Add(this.pnlDoctorScreen);
            this.Name = "DoctorSystemScreen";
            this.Text = "Doktor Sistemi";
            this.Load += new System.EventHandler(this.DoctorSystemScreen_Load);
            this.pnlDoctorScreen.ResumeLayout(false);
            this.pnlDoctorScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalAppointment)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewDoctorAppointmentScreen)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDoctorScreen;
        private System.Windows.Forms.DateTimePicker dtPickerWorkingDate;
        private System.Windows.Forms.Label lblWorkingDate;
        private System.Windows.Forms.DataGridView dtGridViewDoctorAppointmentScreen;
        private System.Windows.Forms.Button btnCreateInspection;
        private System.Windows.Forms.PictureBox pictureBoxHospitalAppointment;
    }
}