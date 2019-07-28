namespace UserInterface
{
    partial class PharmacistSystemScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PharmacistSystemScreen));
            this.pnlInspectionScreen = new System.Windows.Forms.Panel();
            this.dtGridViewRecipeList = new System.Windows.Forms.DataGridView();
            this.pictureBoxHospitalAppointment = new System.Windows.Forms.PictureBox();
            this.lblInspectionScreen = new System.Windows.Forms.Label();
            this.btnOldRecipes = new System.Windows.Forms.Button();
            this.grpboxRecipeQuery = new System.Windows.Forms.GroupBox();
            this.DtGridViewListPrescription = new System.Windows.Forms.DataGridView();
            this.btnSearchRecipe = new System.Windows.Forms.Button();
            this.txtRecipeSearch = new System.Windows.Forms.TextBox();
            this.btnRecipeDelete = new System.Windows.Forms.Button();
            this.pnlInspectionScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewRecipeList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalAppointment)).BeginInit();
            this.grpboxRecipeQuery.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridViewListPrescription)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlInspectionScreen
            // 
            this.pnlInspectionScreen.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlInspectionScreen.Controls.Add(this.dtGridViewRecipeList);
            this.pnlInspectionScreen.Controls.Add(this.pictureBoxHospitalAppointment);
            this.pnlInspectionScreen.Controls.Add(this.lblInspectionScreen);
            this.pnlInspectionScreen.Controls.Add(this.btnOldRecipes);
            this.pnlInspectionScreen.Controls.Add(this.grpboxRecipeQuery);
            this.pnlInspectionScreen.Location = new System.Drawing.Point(12, 12);
            this.pnlInspectionScreen.Name = "pnlInspectionScreen";
            this.pnlInspectionScreen.Size = new System.Drawing.Size(760, 473);
            this.pnlInspectionScreen.TabIndex = 12;
            // 
            // dtGridViewRecipeList
            // 
            this.dtGridViewRecipeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewRecipeList.Location = new System.Drawing.Point(373, 164);
            this.dtGridViewRecipeList.Name = "dtGridViewRecipeList";
            this.dtGridViewRecipeList.Size = new System.Drawing.Size(370, 275);
            this.dtGridViewRecipeList.TabIndex = 27;
            // 
            // pictureBoxHospitalAppointment
            // 
            this.pictureBoxHospitalAppointment.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHospitalAppointment.Image")));
            this.pictureBoxHospitalAppointment.Location = new System.Drawing.Point(646, 12);
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
            this.lblInspectionScreen.Location = new System.Drawing.Point(39, 35);
            this.lblInspectionScreen.Name = "lblInspectionScreen";
            this.lblInspectionScreen.Size = new System.Drawing.Size(118, 20);
            this.lblInspectionScreen.TabIndex = 1;
            this.lblInspectionScreen.Text = "Eczacı Ekranı";
            // 
            // btnOldRecipes
            // 
            this.btnOldRecipes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOldRecipes.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.btnOldRecipes.Location = new System.Drawing.Point(373, 117);
            this.btnOldRecipes.Name = "btnOldRecipes";
            this.btnOldRecipes.Size = new System.Drawing.Size(370, 32);
            this.btnOldRecipes.TabIndex = 3;
            this.btnOldRecipes.Text = "Hastaya Ait Reçeteleri Görüntüle";
            this.btnOldRecipes.UseVisualStyleBackColor = true;
            this.btnOldRecipes.Click += new System.EventHandler(this.btnOldRecipes_Click);
            // 
            // grpboxRecipeQuery
            // 
            this.grpboxRecipeQuery.Controls.Add(this.DtGridViewListPrescription);
            this.grpboxRecipeQuery.Controls.Add(this.btnSearchRecipe);
            this.grpboxRecipeQuery.Controls.Add(this.txtRecipeSearch);
            this.grpboxRecipeQuery.Controls.Add(this.btnRecipeDelete);
            this.grpboxRecipeQuery.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpboxRecipeQuery.Location = new System.Drawing.Point(37, 80);
            this.grpboxRecipeQuery.Name = "grpboxRecipeQuery";
            this.grpboxRecipeQuery.Size = new System.Drawing.Size(317, 359);
            this.grpboxRecipeQuery.TabIndex = 23;
            this.grpboxRecipeQuery.TabStop = false;
            this.grpboxRecipeQuery.Text = "Reçete Sorgula";
            // 
            // DtGridViewListPrescription
            // 
            this.DtGridViewListPrescription.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtGridViewListPrescription.Location = new System.Drawing.Point(6, 105);
            this.DtGridViewListPrescription.Name = "DtGridViewListPrescription";
            this.DtGridViewListPrescription.Size = new System.Drawing.Size(305, 254);
            this.DtGridViewListPrescription.TabIndex = 7;
            // 
            // btnSearchRecipe
            // 
            this.btnSearchRecipe.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSearchRecipe.Location = new System.Drawing.Point(6, 63);
            this.btnSearchRecipe.Name = "btnSearchRecipe";
            this.btnSearchRecipe.Size = new System.Drawing.Size(216, 36);
            this.btnSearchRecipe.TabIndex = 6;
            this.btnSearchRecipe.Text = "Reçete Numarası Sorgula";
            this.btnSearchRecipe.UseVisualStyleBackColor = true;
            this.btnSearchRecipe.Click += new System.EventHandler(this.btnSearchRecipe_Click);
            // 
            // txtRecipeSearch
            // 
            this.txtRecipeSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtRecipeSearch.Location = new System.Drawing.Point(6, 37);
            this.txtRecipeSearch.Multiline = true;
            this.txtRecipeSearch.Name = "txtRecipeSearch";
            this.txtRecipeSearch.Size = new System.Drawing.Size(305, 20);
            this.txtRecipeSearch.TabIndex = 1;
            // 
            // btnRecipeDelete
            // 
            this.btnRecipeDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRecipeDelete.Location = new System.Drawing.Point(228, 63);
            this.btnRecipeDelete.Name = "btnRecipeDelete";
            this.btnRecipeDelete.Size = new System.Drawing.Size(83, 36);
            this.btnRecipeDelete.TabIndex = 5;
            this.btnRecipeDelete.Text = "Temizle";
            this.btnRecipeDelete.UseVisualStyleBackColor = true;
            this.btnRecipeDelete.Click += new System.EventHandler(this.btnRecipeDelete_Click);
            // 
            // PharmacistSystemScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 496);
            this.Controls.Add(this.pnlInspectionScreen);
            this.Name = "PharmacistSystemScreen";
            this.Text = "PharmacistSystemScreen";
            this.pnlInspectionScreen.ResumeLayout(false);
            this.pnlInspectionScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewRecipeList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHospitalAppointment)).EndInit();
            this.grpboxRecipeQuery.ResumeLayout(false);
            this.grpboxRecipeQuery.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtGridViewListPrescription)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInspectionScreen;
        private System.Windows.Forms.DataGridView dtGridViewRecipeList;
        private System.Windows.Forms.PictureBox pictureBoxHospitalAppointment;
        private System.Windows.Forms.Label lblInspectionScreen;
        private System.Windows.Forms.Button btnOldRecipes;
        private System.Windows.Forms.GroupBox grpboxRecipeQuery;
        private System.Windows.Forms.Button btnSearchRecipe;
        private System.Windows.Forms.TextBox txtRecipeSearch;
        private System.Windows.Forms.Button btnRecipeDelete;
        private System.Windows.Forms.DataGridView DtGridViewListPrescription;
    }
}