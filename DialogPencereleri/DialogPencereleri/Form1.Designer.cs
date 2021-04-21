namespace DialogPencereleri
{
    partial class Form1
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
            this.btnFontDialog = new System.Windows.Forms.Button();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblDeneme = new System.Windows.Forms.Label();
            this.btnOpenFileDialog = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.lblDeneme2 = new System.Windows.Forms.Label();
            this.btnSaveFileDialog = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.SuspendLayout();
            // 
            // btnFontDialog
            // 
            this.btnFontDialog.Location = new System.Drawing.Point(12, 12);
            this.btnFontDialog.Name = "btnFontDialog";
            this.btnFontDialog.Size = new System.Drawing.Size(75, 23);
            this.btnFontDialog.TabIndex = 0;
            this.btnFontDialog.Text = "FontDialog";
            this.btnFontDialog.UseVisualStyleBackColor = true;
            this.btnFontDialog.Click += new System.EventHandler(this.btnFontDialog_Click);
            // 
            // lblDeneme
            // 
            this.lblDeneme.AutoSize = true;
            this.lblDeneme.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeneme.Location = new System.Drawing.Point(317, 166);
            this.lblDeneme.Name = "lblDeneme";
            this.lblDeneme.Size = new System.Drawing.Size(134, 29);
            this.lblDeneme.TabIndex = 1;
            this.lblDeneme.Text = "HelloWorld";
            // 
            // btnOpenFileDialog
            // 
            this.btnOpenFileDialog.Location = new System.Drawing.Point(113, 13);
            this.btnOpenFileDialog.Name = "btnOpenFileDialog";
            this.btnOpenFileDialog.Size = new System.Drawing.Size(139, 23);
            this.btnOpenFileDialog.TabIndex = 2;
            this.btnOpenFileDialog.Text = "OpenFileDialog";
            this.btnOpenFileDialog.UseVisualStyleBackColor = true;
            this.btnOpenFileDialog.Click += new System.EventHandler(this.btnOpenFileDialog_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // lblDeneme2
            // 
            this.lblDeneme2.AutoSize = true;
            this.lblDeneme2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeneme2.Location = new System.Drawing.Point(317, 241);
            this.lblDeneme2.Name = "lblDeneme2";
            this.lblDeneme2.Size = new System.Drawing.Size(134, 29);
            this.lblDeneme2.TabIndex = 1;
            this.lblDeneme2.Text = "HelloWorld";
            // 
            // btnSaveFileDialog
            // 
            this.btnSaveFileDialog.Location = new System.Drawing.Point(322, 13);
            this.btnSaveFileDialog.Name = "btnSaveFileDialog";
            this.btnSaveFileDialog.Size = new System.Drawing.Size(122, 24);
            this.btnSaveFileDialog.TabIndex = 3;
            this.btnSaveFileDialog.Text = "SaveFileDialog";
            this.btnSaveFileDialog.UseVisualStyleBackColor = true;
            this.btnSaveFileDialog.Click += new System.EventHandler(this.btnSaveFileDialog_Click);
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(514, 14);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(122, 23);
            this.btnBrowser.TabIndex = 4;
            this.btnBrowser.Text = "FolderBrowserDialog";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Location = new System.Drawing.Point(678, 14);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(100, 23);
            this.btnColorDialog.TabIndex = 5;
            this.btnColorDialog.Text = "ColorDialog";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.btnBrowser);
            this.Controls.Add(this.btnSaveFileDialog);
            this.Controls.Add(this.btnOpenFileDialog);
            this.Controls.Add(this.lblDeneme2);
            this.Controls.Add(this.lblDeneme);
            this.Controls.Add(this.btnFontDialog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFontDialog;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblDeneme;
        private System.Windows.Forms.Button btnOpenFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label lblDeneme2;
        private System.Windows.Forms.Button btnSaveFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}

