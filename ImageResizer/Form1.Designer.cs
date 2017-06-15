namespace ImageResizer
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.resizeBtn = new System.Windows.Forms.Button();
            this.fileLocationTB = new System.Windows.Forms.TextBox();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.newResolutionTB = new System.Windows.Forms.TextBox();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // resizeBtn
            // 
            this.resizeBtn.Location = new System.Drawing.Point(12, 132);
            this.resizeBtn.Name = "resizeBtn";
            this.resizeBtn.Size = new System.Drawing.Size(631, 23);
            this.resizeBtn.TabIndex = 0;
            this.resizeBtn.Text = "Resize";
            this.resizeBtn.UseVisualStyleBackColor = true;
            this.resizeBtn.Click += new System.EventHandler(this.resizeBtn_Click);
            // 
            // fileLocationTB
            // 
            this.fileLocationTB.Location = new System.Drawing.Point(12, 14);
            this.fileLocationTB.Name = "fileLocationTB";
            this.fileLocationTB.ReadOnly = true;
            this.fileLocationTB.Size = new System.Drawing.Size(532, 20);
            this.fileLocationTB.TabIndex = 1;
            // 
            // openFileBtn
            // 
            this.openFileBtn.Location = new System.Drawing.Point(550, 12);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(93, 23);
            this.openFileBtn.TabIndex = 2;
            this.openFileBtn.Text = "Open File";
            this.openFileBtn.UseVisualStyleBackColor = true;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New resolution (e.g. 1280x720):";
            // 
            // newResolutionTB
            // 
            this.newResolutionTB.Location = new System.Drawing.Point(175, 40);
            this.newResolutionTB.Name = "newResolutionTB";
            this.newResolutionTB.Size = new System.Drawing.Size(126, 20);
            this.newResolutionTB.TabIndex = 4;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 103);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(631, 23);
            this.progressBar1.Step = 100;
            this.progressBar1.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 167);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.newResolutionTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFileBtn);
            this.Controls.Add(this.fileLocationTB);
            this.Controls.Add(this.resizeBtn);
            this.Name = "Form1";
            this.Text = "ImageResizer v1.0";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button resizeBtn;
        private System.Windows.Forms.TextBox fileLocationTB;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox newResolutionTB;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

