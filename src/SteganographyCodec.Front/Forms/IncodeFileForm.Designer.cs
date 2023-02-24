namespace SteganographyCodec.Front
{
    public partial class IncodeFileForm
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
            this.BrowseFileButton = new System.Windows.Forms.Button();
            this.IncodeFileButton = new System.Windows.Forms.Button();
            this.PathToFileTextbox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BrowseFileButton
            // 
            this.BrowseFileButton.Location = new System.Drawing.Point(435, 60);
            this.BrowseFileButton.Name = "BrowseFileButton";
            this.BrowseFileButton.Size = new System.Drawing.Size(112, 34);
            this.BrowseFileButton.TabIndex = 0;
            this.BrowseFileButton.Text = "Browse File";
            this.BrowseFileButton.UseVisualStyleBackColor = true;
            this.BrowseFileButton.Click += new System.EventHandler(this.BrowseFileButton_Click);
            // 
            // IncodeFileButton
            // 
            this.IncodeFileButton.Location = new System.Drawing.Point(563, 59);
            this.IncodeFileButton.Name = "IncodeFileButton";
            this.IncodeFileButton.Size = new System.Drawing.Size(181, 35);
            this.IncodeFileButton.TabIndex = 1;
            this.IncodeFileButton.Text = "Incode File";
            this.IncodeFileButton.UseVisualStyleBackColor = true;
            this.IncodeFileButton.Click += new System.EventHandler(this.ShowDataInFileButton_Click);
            // 
            // PathToFileTextbox
            // 
            this.PathToFileTextbox.Location = new System.Drawing.Point(48, 63);
            this.PathToFileTextbox.Name = "PathToFileTextbox";
            this.PathToFileTextbox.Size = new System.Drawing.Size(351, 31);
            this.PathToFileTextbox.TabIndex = 2;
            // 
            // IncodeFileForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PathToFileTextbox);
            this.Controls.Add(this.IncodeFileButton);
            this.Controls.Add(this.BrowseFileButton);
            this.Name = "IncodeFileForm";
            this.Text = "Incode File";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BrowseFileButton;
        private Button IncodeFileButton;
        public TextBox PathToFileTextbox;
    }
}