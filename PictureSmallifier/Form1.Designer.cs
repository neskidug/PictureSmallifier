namespace PictureSmallifier
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        
        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnResize = new System.Windows.Forms.Button();
            this.btnSelectFromClipboard = new System.Windows.Forms.Button();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.lblChooseSizeInPercentage = new System.Windows.Forms.Label();
            this.txtSizePercentage = new System.Windows.Forms.TextBox();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnResize);
            this.panel1.Controls.Add(this.btnSelectFromClipboard);
            this.panel1.Controls.Add(this.btnSaveFile);
            this.panel1.Controls.Add(this.lblChooseSizeInPercentage);
            this.panel1.Controls.Add(this.txtSizePercentage);
            this.panel1.Controls.Add(this.btnSelectFile);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 450);
            this.panel1.TabIndex = 0;
            // 
            // btnResize
            // 
            this.btnResize.Location = new System.Drawing.Point(686, 311);
            this.btnResize.Name = "btnResize";
            this.btnResize.Size = new System.Drawing.Size(75, 23);
            this.btnResize.TabIndex = 6;
            this.btnResize.Text = "Resize";
            this.btnResize.UseVisualStyleBackColor = true;
            this.btnResize.Click += new System.EventHandler(this.btnResize_Click);
            // 
            // btnSelectFromClipboard
            // 
            this.btnSelectFromClipboard.Location = new System.Drawing.Point(540, 394);
            this.btnSelectFromClipboard.Name = "btnSelectFromClipboard";
            this.btnSelectFromClipboard.Size = new System.Drawing.Size(99, 23);
            this.btnSelectFromClipboard.TabIndex = 5;
            this.btnSelectFromClipboard.Text = "From clipboard";
            this.btnSelectFromClipboard.UseVisualStyleBackColor = true;
            this.btnSelectFromClipboard.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Location = new System.Drawing.Point(712, 394);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(75, 23);
            this.btnSaveFile.TabIndex = 4;
            this.btnSaveFile.Text = "Save file";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            this.btnSaveFile.Click += new System.EventHandler(this.btnSaveFile_Click);
            // 
            // lblChooseSizeInPercentage
            // 
            this.lblChooseSizeInPercentage.AutoSize = true;
            this.lblChooseSizeInPercentage.Location = new System.Drawing.Point(540, 285);
            this.lblChooseSizeInPercentage.Name = "lblChooseSizeInPercentage";
            this.lblChooseSizeInPercentage.Size = new System.Drawing.Size(140, 15);
            this.lblChooseSizeInPercentage.TabIndex = 3;
            this.lblChooseSizeInPercentage.Text = "Choose a size percentage";
            // 
            // txtSizePercentage
            // 
            this.txtSizePercentage.Enabled = false;
            this.txtSizePercentage.Location = new System.Drawing.Point(686, 282);
            this.txtSizePercentage.Name = "txtSizePercentage";
            this.txtSizePercentage.Size = new System.Drawing.Size(101, 23);
            this.txtSizePercentage.TabIndex = 2;
            this.txtSizePercentage.TextChanged += new System.EventHandler(this.txtSizePercentage_TextChanged);
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Location = new System.Drawing.Point(540, 365);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(99, 23);
            this.btnSelectFile.TabIndex = 1;
            this.btnSelectFile.Text = "Select File";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            this.btnSelectFile.Click += new System.EventHandler(this.btnSelectFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(534, 417);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckPathExists = false;
            this.saveFileDialog1.DefaultExt = "jpg";
            this.saveFileDialog1.InitialDirectory = "C:\\";
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog1_FileOk);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnSelectFile;
        private PictureBox pictureBox1;
        private Label lblChooseSizeInPercentage;
        private TextBox txtSizePercentage;
        private Button btnSelectFromClipboard;
        private Button btnSaveFile;
        private SaveFileDialog saveFileDialog1;
        private Button btnResize;
    }
}