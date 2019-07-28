namespace UserInterface
{
    partial class PrescriptionSystem
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
            this.pnlPrescription = new System.Windows.Forms.Panel();
            this.gbPrescription = new System.Windows.Forms.GroupBox();
            this.btnPrescriptonAdd = new System.Windows.Forms.Button();
            this.lstDrugs = new System.Windows.Forms.ListBox();
            this.btnAddDrug = new System.Windows.Forms.Button();
            this.txtDrug = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlPrescription.SuspendLayout();
            this.gbPrescription.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlPrescription
            // 
            this.pnlPrescription.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.pnlPrescription.Controls.Add(this.gbPrescription);
            this.pnlPrescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlPrescription.Location = new System.Drawing.Point(0, 0);
            this.pnlPrescription.Name = "pnlPrescription";
            this.pnlPrescription.Size = new System.Drawing.Size(393, 367);
            this.pnlPrescription.TabIndex = 13;
            // 
            // gbPrescription
            // 
            this.gbPrescription.Controls.Add(this.btnPrescriptonAdd);
            this.gbPrescription.Controls.Add(this.lstDrugs);
            this.gbPrescription.Controls.Add(this.btnAddDrug);
            this.gbPrescription.Controls.Add(this.txtDrug);
            this.gbPrescription.Controls.Add(this.label2);
            this.gbPrescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbPrescription.Location = new System.Drawing.Point(12, 12);
            this.gbPrescription.Name = "gbPrescription";
            this.gbPrescription.Size = new System.Drawing.Size(369, 343);
            this.gbPrescription.TabIndex = 23;
            this.gbPrescription.TabStop = false;
            this.gbPrescription.Text = "Reçete Sistemi";
            // 
            // btnPrescriptonAdd
            // 
            this.btnPrescriptonAdd.Location = new System.Drawing.Point(199, 308);
            this.btnPrescriptonAdd.Name = "btnPrescriptonAdd";
            this.btnPrescriptonAdd.Size = new System.Drawing.Size(164, 32);
            this.btnPrescriptonAdd.TabIndex = 6;
            this.btnPrescriptonAdd.Text = "Reçete Onayla";
            this.btnPrescriptonAdd.UseVisualStyleBackColor = true;
            this.btnPrescriptonAdd.Click += new System.EventHandler(this.btnPrescriptonAdd_Click);
            // 
            // lstDrugs
            // 
            this.lstDrugs.FormattingEnabled = true;
            this.lstDrugs.ItemHeight = 16;
            this.lstDrugs.Location = new System.Drawing.Point(9, 90);
            this.lstDrugs.Name = "lstDrugs";
            this.lstDrugs.Size = new System.Drawing.Size(354, 212);
            this.lstDrugs.TabIndex = 5;
            // 
            // btnAddDrug
            // 
            this.btnAddDrug.Location = new System.Drawing.Point(308, 35);
            this.btnAddDrug.Name = "btnAddDrug";
            this.btnAddDrug.Size = new System.Drawing.Size(55, 23);
            this.btnAddDrug.TabIndex = 4;
            this.btnAddDrug.Text = "Ekle";
            this.btnAddDrug.UseVisualStyleBackColor = true;
            this.btnAddDrug.Click += new System.EventHandler(this.btnAddDrug_Click);
            // 
            // txtDrug
            // 
            this.txtDrug.Location = new System.Drawing.Point(96, 35);
            this.txtDrug.Name = "txtDrug";
            this.txtDrug.Size = new System.Drawing.Size(205, 22);
            this.txtDrug.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "İlaç Bilgisi:";
            // 
            // PrescriptionSystem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 367);
            this.Controls.Add(this.pnlPrescription);
            this.Name = "PrescriptionSystem";
            this.Text = "Reçete";
            this.pnlPrescription.ResumeLayout(false);
            this.gbPrescription.ResumeLayout(false);
            this.gbPrescription.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlPrescription;
        private System.Windows.Forms.GroupBox gbPrescription;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDrug;
        private System.Windows.Forms.Button btnAddDrug;
        private System.Windows.Forms.ListBox lstDrugs;
        private System.Windows.Forms.Button btnPrescriptonAdd;
    }
}