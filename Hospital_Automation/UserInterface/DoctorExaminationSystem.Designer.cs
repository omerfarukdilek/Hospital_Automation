namespace UserInterface
{
    partial class DoctorExaminationSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorExaminationSystem));
            this.pnlInspectionScreen = new System.Windows.Forms.Panel();
            this.btnInspenctionResult = new System.Windows.Forms.Button();
            this.btnNotCreateInspection = new System.Windows.Forms.Button();
            this.dtExaminationView = new System.Windows.Forms.DataGridView();
            this.btnExaminationSearch = new System.Windows.Forms.Button();
            this.btnCreateRecipe = new System.Windows.Forms.Button();
            this.pictureBoxHospitalAppointment = new System.Windows.Forms.PictureBox();
            this.lblInspectionScreen = new System.Windows.Forms.Label();
            this.btnAnalysisRequest = new System.Windows.Forms.Button();
            this.grpboxDiagnosis = new System.Windows.Forms.GroupBox();
            this.dtDiagnosis = new System.Windows.Forms.DataGridView();
            this.btnSearchDiagnosis = new System.Windows.Forms.Button();
            this.txtDiagnosisSearch = new System.Windows.Forms.TextBox();
            this.btnDiagnosisSearchDelete = new System.Windows.Forms.Button();
            this.btnAppointment = new System.Windows.Forms.Button();
            this.pnlInspectionScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExaminationView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalAppointment)).BeginInit();
            this.grpboxDiagnosis.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDiagnosis)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInspectionScreen
            // 
            this.pnlInspectionScreen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlInspectionScreen.Controls.Add(this.btnAppointment);
            this.pnlInspectionScreen.Controls.Add(this.btnInspenctionResult);
            this.pnlInspectionScreen.Controls.Add(this.btnNotCreateInspection);
            this.pnlInspectionScreen.Controls.Add(this.dtExaminationView);
            this.pnlInspectionScreen.Controls.Add(this.btnExaminationSearch);
            this.pnlInspectionScreen.Controls.Add(this.btnCreateRecipe);
            this.pnlInspectionScreen.Controls.Add(this.pictureBoxHospitalAppointment);
            this.pnlInspectionScreen.Controls.Add(this.lblInspectionScreen);
            this.pnlInspectionScreen.Controls.Add(this.btnAnalysisRequest);
            this.pnlInspectionScreen.Controls.Add(this.grpboxDiagnosis);
            this.pnlInspectionScreen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlInspectionScreen.Location = new System.Drawing.Point(0, 0);
            this.pnlInspectionScreen.Name = "pnlInspectionScreen";
            this.pnlInspectionScreen.Size = new System.Drawing.Size(986, 594);
            this.pnlInspectionScreen.TabIndex = 11;
            // 
            // btnInspenctionResult
            // 
            this.btnInspenctionResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnInspenctionResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnInspenctionResult.Location = new System.Drawing.Point(43, 304);
            this.btnInspenctionResult.Name = "btnInspenctionResult";
            this.btnInspenctionResult.Size = new System.Drawing.Size(305, 41);
            this.btnInspenctionResult.TabIndex = 29;
            this.btnInspenctionResult.Text = "Muayene Sonucunu Kaydet";
            this.btnInspenctionResult.UseVisualStyleBackColor = true;
            this.btnInspenctionResult.Click += new System.EventHandler(this.btnInspenctionResult_Click);
            // 
            // btnNotCreateInspection
            // 
            this.btnNotCreateInspection.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNotCreateInspection.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNotCreateInspection.Location = new System.Drawing.Point(43, 492);
            this.btnNotCreateInspection.Name = "btnNotCreateInspection";
            this.btnNotCreateInspection.Size = new System.Drawing.Size(305, 41);
            this.btnNotCreateInspection.TabIndex = 28;
            this.btnNotCreateInspection.Text = "Muayene Gerçekleşmedi";
            this.btnNotCreateInspection.UseVisualStyleBackColor = true;
            this.btnNotCreateInspection.Click += new System.EventHandler(this.BtnNotCreateInspection_Click);
            // 
            // dtExaminationView
            // 
            this.dtExaminationView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtExaminationView.Location = new System.Drawing.Point(373, 117);
            this.dtExaminationView.Name = "dtExaminationView";
            this.dtExaminationView.Size = new System.Drawing.Size(602, 463);
            this.dtExaminationView.TabIndex = 27;
            // 
            // btnExaminationSearch
            // 
            this.btnExaminationSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExaminationSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnExaminationSearch.Location = new System.Drawing.Point(43, 398);
            this.btnExaminationSearch.Name = "btnExaminationSearch";
            this.btnExaminationSearch.Size = new System.Drawing.Size(305, 41);
            this.btnExaminationSearch.TabIndex = 26;
            this.btnExaminationSearch.Text = "Muayene Sorgula";
            this.btnExaminationSearch.UseVisualStyleBackColor = true;
            this.btnExaminationSearch.Click += new System.EventHandler(this.btnExaminationSearch_Click);
            // 
            // btnCreateRecipe
            // 
            this.btnCreateRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCreateRecipe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnCreateRecipe.Location = new System.Drawing.Point(43, 445);
            this.btnCreateRecipe.Name = "btnCreateRecipe";
            this.btnCreateRecipe.Size = new System.Drawing.Size(305, 41);
            this.btnCreateRecipe.TabIndex = 25;
            this.btnCreateRecipe.Text = "Reçete Oluştur";
            this.btnCreateRecipe.UseVisualStyleBackColor = true;
            this.btnCreateRecipe.Click += new System.EventHandler(this.btnCreateRecipe_Click);
            // 
            // pictureBoxHospitalAppointment
            // 
            this.pictureBoxHospitalAppointment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalAppointment.Image")));
            this.pictureBoxHospitalAppointment.Location = new System.Drawing.Point(878, 12);
            this.pictureBoxHospitalAppointment.Name = "pictureBoxHospitalAppointment";
            this.pictureBoxHospitalAppointment.Size = new System.Drawing.Size(97, 62);
            this.pictureBoxHospitalAppointment.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxHospitalAppointment.TabIndex = 7;
            this.pictureBoxHospitalAppointment.TabStop = false;
            // 
            // lblInspectionScreen
            // 
            this.lblInspectionScreen.AutoSize = true;
            this.lblInspectionScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInspectionScreen.Location = new System.Drawing.Point(33, 38);
            this.lblInspectionScreen.Name = "lblInspectionScreen";
            this.lblInspectionScreen.Size = new System.Drawing.Size(137, 20);
            this.lblInspectionScreen.TabIndex = 1;
            this.lblInspectionScreen.Text = "Muayene Ekranı";
            // 
            // btnAnalysisRequest
            // 
            this.btnAnalysisRequest.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAnalysisRequest.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAnalysisRequest.Location = new System.Drawing.Point(43, 351);
            this.btnAnalysisRequest.Name = "btnAnalysisRequest";
            this.btnAnalysisRequest.Size = new System.Drawing.Size(305, 41);
            this.btnAnalysisRequest.TabIndex = 3;
            this.btnAnalysisRequest.Text = "Tahlil Talebinde Bulun";
            this.btnAnalysisRequest.UseVisualStyleBackColor = true;
            this.btnAnalysisRequest.Click += new System.EventHandler(this.btnAnalysisRequest_Click);
            // 
            // grpboxDiagnosis
            // 
            this.grpboxDiagnosis.Controls.Add(this.dtDiagnosis);
            this.grpboxDiagnosis.Controls.Add(this.btnSearchDiagnosis);
            this.grpboxDiagnosis.Controls.Add(this.txtDiagnosisSearch);
            this.grpboxDiagnosis.Controls.Add(this.btnDiagnosisSearchDelete);
            this.grpboxDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxDiagnosis.Location = new System.Drawing.Point(37, 80);
            this.grpboxDiagnosis.Name = "grpboxDiagnosis";
            this.grpboxDiagnosis.Size = new System.Drawing.Size(317, 218);
            this.grpboxDiagnosis.TabIndex = 23;
            this.grpboxDiagnosis.TabStop = false;
            this.grpboxDiagnosis.Text = "Teşhis";
            // 
            // dtDiagnosis
            // 
            this.dtDiagnosis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtDiagnosis.Location = new System.Drawing.Point(7, 64);
            this.dtDiagnosis.Name = "dtDiagnosis";
            this.dtDiagnosis.Size = new System.Drawing.Size(304, 148);
            this.dtDiagnosis.TabIndex = 7;
            // 
            // btnSearchDiagnosis
            // 
            this.btnSearchDiagnosis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchDiagnosis.Location = new System.Drawing.Point(161, 37);
            this.btnSearchDiagnosis.Name = "btnSearchDiagnosis";
            this.btnSearchDiagnosis.Size = new System.Drawing.Size(72, 22);
            this.btnSearchDiagnosis.TabIndex = 6;
            this.btnSearchDiagnosis.Text = "Ara";
            this.btnSearchDiagnosis.UseVisualStyleBackColor = true;
            this.btnSearchDiagnosis.Click += new System.EventHandler(this.btnSearchDiagnosis_Click);
            // 
            // txtDiagnosisSearch
            // 
            this.txtDiagnosisSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtDiagnosisSearch.Location = new System.Drawing.Point(6, 37);
            this.txtDiagnosisSearch.Multiline = true;
            this.txtDiagnosisSearch.Name = "txtDiagnosisSearch";
            this.txtDiagnosisSearch.Size = new System.Drawing.Size(150, 20);
            this.txtDiagnosisSearch.TabIndex = 1;
            // 
            // btnDiagnosisSearchDelete
            // 
            this.btnDiagnosisSearchDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDiagnosisSearchDelete.Location = new System.Drawing.Point(239, 37);
            this.btnDiagnosisSearchDelete.Name = "btnDiagnosisSearchDelete";
            this.btnDiagnosisSearchDelete.Size = new System.Drawing.Size(72, 22);
            this.btnDiagnosisSearchDelete.TabIndex = 5;
            this.btnDiagnosisSearchDelete.Text = "Temizle";
            this.btnDiagnosisSearchDelete.UseVisualStyleBackColor = true;
            // 
            // btnAppointment
            // 
            this.btnAppointment.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAppointment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnAppointment.Location = new System.Drawing.Point(44, 539);
            this.btnAppointment.Name = "btnAppointment";
            this.btnAppointment.Size = new System.Drawing.Size(305, 41);
            this.btnAppointment.TabIndex = 30;
            this.btnAppointment.Text = "Randevu Oluştur";
            this.btnAppointment.UseVisualStyleBackColor = true;
            this.btnAppointment.Click += new System.EventHandler(this.btnAppointment_Click);
            // 
            // DoctorExaminationSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 594);
            this.Controls.Add(this.pnlInspectionScreen);
            this.Name = "DoctorExaminationSystem";
            this.Text = "DoctorInspectionSystem";
            this.Load += new System.EventHandler(this.DoctorExaminationSystem_Load);
            this.pnlInspectionScreen.ResumeLayout(false);
            this.pnlInspectionScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtExaminationView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalAppointment)).EndInit();
            this.grpboxDiagnosis.ResumeLayout(false);
            this.grpboxDiagnosis.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtDiagnosis)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInspectionScreen;
        private System.Windows.Forms.DataGridView dtExaminationView;
        private System.Windows.Forms.Button btnExaminationSearch;
        private System.Windows.Forms.Button btnCreateRecipe;
        private System.Windows.Forms.PictureBox pictureBoxHospitalAppointment;
        private System.Windows.Forms.Label lblInspectionScreen;
        private System.Windows.Forms.Button btnAnalysisRequest;
        private System.Windows.Forms.GroupBox grpboxDiagnosis;
        private System.Windows.Forms.Button btnSearchDiagnosis;
        private System.Windows.Forms.TextBox txtDiagnosisSearch;
        private System.Windows.Forms.Button btnDiagnosisSearchDelete;
        private System.Windows.Forms.Button btnNotCreateInspection;
        private System.Windows.Forms.Button btnInspenctionResult;
        private System.Windows.Forms.DataGridView dtDiagnosis;
        private System.Windows.Forms.Button btnAppointment;
    }
}