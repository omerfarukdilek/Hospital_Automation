namespace UserInterface
{
    partial class Analysis
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
            this.pnlAnalysis = new System.Windows.Forms.Panel();
            this.checkBoxHepatitisB = new System.Windows.Forms.CheckBox();
            this.checkBoxHepatitisA = new System.Windows.Forms.CheckBox();
            this.checkBoxDiabetes = new System.Windows.Forms.CheckBox();
            this.checkBoxUrinalysis = new System.Windows.Forms.CheckBox();
            this.checkBoxBloodAnalysis = new System.Windows.Forms.CheckBox();
            this.lblAnalysis = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.pnlAnalysis.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlAnalysis
            // 
            this.pnlAnalysis.Controls.Add(this.checkBoxHepatitisB);
            this.pnlAnalysis.Controls.Add(this.checkBoxHepatitisA);
            this.pnlAnalysis.Controls.Add(this.checkBoxDiabetes);
            this.pnlAnalysis.Controls.Add(this.checkBoxUrinalysis);
            this.pnlAnalysis.Controls.Add(this.checkBoxBloodAnalysis);
            this.pnlAnalysis.Location = new System.Drawing.Point(12, 65);
            this.pnlAnalysis.Name = "pnlAnalysis";
            this.pnlAnalysis.Size = new System.Drawing.Size(228, 200);
            this.pnlAnalysis.TabIndex = 1;
            // 
            // checkBoxHepatitisB
            // 
            this.checkBoxHepatitisB.AutoSize = true;
            this.checkBoxHepatitisB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHepatitisB.Location = new System.Drawing.Point(27, 170);
            this.checkBoxHepatitisB.Name = "checkBoxHepatitisB";
            this.checkBoxHepatitisB.Size = new System.Drawing.Size(121, 20);
            this.checkBoxHepatitisB.TabIndex = 17;
            this.checkBoxHepatitisB.Text = "Hepatit B Tahlili";
            this.checkBoxHepatitisB.UseVisualStyleBackColor = true;
            // 
            // checkBoxHepatitisA
            // 
            this.checkBoxHepatitisA.AutoSize = true;
            this.checkBoxHepatitisA.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxHepatitisA.Location = new System.Drawing.Point(27, 130);
            this.checkBoxHepatitisA.Name = "checkBoxHepatitisA";
            this.checkBoxHepatitisA.Size = new System.Drawing.Size(121, 20);
            this.checkBoxHepatitisA.TabIndex = 16;
            this.checkBoxHepatitisA.Text = "Hepatit A Tahlili";
            this.checkBoxHepatitisA.UseVisualStyleBackColor = true;
            // 
            // checkBoxDiabetes
            // 
            this.checkBoxDiabetes.AutoSize = true;
            this.checkBoxDiabetes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxDiabetes.Location = new System.Drawing.Point(27, 90);
            this.checkBoxDiabetes.Name = "checkBoxDiabetes";
            this.checkBoxDiabetes.Size = new System.Drawing.Size(113, 20);
            this.checkBoxDiabetes.TabIndex = 15;
            this.checkBoxDiabetes.Text = "Diyabet Tahlili";
            this.checkBoxDiabetes.UseVisualStyleBackColor = true;
            // 
            // checkBoxUrinalysis
            // 
            this.checkBoxUrinalysis.AutoSize = true;
            this.checkBoxUrinalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxUrinalysis.Location = new System.Drawing.Point(27, 54);
            this.checkBoxUrinalysis.Name = "checkBoxUrinalysis";
            this.checkBoxUrinalysis.Size = new System.Drawing.Size(93, 20);
            this.checkBoxUrinalysis.TabIndex = 14;
            this.checkBoxUrinalysis.Text = "İdrar Tahlili";
            this.checkBoxUrinalysis.UseVisualStyleBackColor = true;
            // 
            // checkBoxBloodAnalysis
            // 
            this.checkBoxBloodAnalysis.AutoSize = true;
            this.checkBoxBloodAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxBloodAnalysis.Location = new System.Drawing.Point(27, 18);
            this.checkBoxBloodAnalysis.Name = "checkBoxBloodAnalysis";
            this.checkBoxBloodAnalysis.Size = new System.Drawing.Size(89, 20);
            this.checkBoxBloodAnalysis.TabIndex = 13;
            this.checkBoxBloodAnalysis.Text = "Kan Tahlili";
            this.checkBoxBloodAnalysis.UseVisualStyleBackColor = true;
            // 
            // lblAnalysis
            // 
            this.lblAnalysis.AutoSize = true;
            this.lblAnalysis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAnalysis.Location = new System.Drawing.Point(12, 25);
            this.lblAnalysis.Name = "lblAnalysis";
            this.lblAnalysis.Size = new System.Drawing.Size(154, 20);
            this.lblAnalysis.TabIndex = 12;
            this.lblAnalysis.Text = "Yapılacak Tahliller";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(165, 288);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Onayla";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // Analysis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 323);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.pnlAnalysis);
            this.Controls.Add(this.lblAnalysis);
            this.Name = "Analysis";
            this.Text = "Analysis";
            this.pnlAnalysis.ResumeLayout(false);
            this.pnlAnalysis.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlAnalysis;
        private System.Windows.Forms.CheckBox checkBoxHepatitisB;
        private System.Windows.Forms.CheckBox checkBoxHepatitisA;
        private System.Windows.Forms.CheckBox checkBoxDiabetes;
        private System.Windows.Forms.CheckBox checkBoxUrinalysis;
        private System.Windows.Forms.CheckBox checkBoxBloodAnalysis;
        private System.Windows.Forms.Label lblAnalysis;
        private System.Windows.Forms.Button btnOk;
    }
}