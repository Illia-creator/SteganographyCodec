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
            BrowseFileButton = new Button();
            IncodeFileButton = new Button();
            PathToFileTextbox = new TextBox();
            SuspendLayout();
            // 
            // BrowseFileButton
            // 
            BrowseFileButton.Location = new Point(435, 60);
            BrowseFileButton.Name = "BrowseFileButton";
            BrowseFileButton.Size = new Size(112, 34);
            BrowseFileButton.TabIndex = 0;
            BrowseFileButton.Text = "Browse File";
            BrowseFileButton.UseVisualStyleBackColor = true;
            BrowseFileButton.Click += BrowseFileButton_Click;
            // 
            // IncodeFileButton
            // 
            IncodeFileButton.Location = new Point(563, 59);
            IncodeFileButton.Name = "IncodeFileButton";
            IncodeFileButton.Size = new Size(181, 35);
            IncodeFileButton.TabIndex = 1;
            IncodeFileButton.Text = "Incode File";
            IncodeFileButton.UseVisualStyleBackColor = true;
            IncodeFileButton.Click += ShowDataInFileButton_Click;
            // 
            // PathToFileTextbox
            // 
            PathToFileTextbox.Location = new Point(48, 63);
            PathToFileTextbox.Name = "PathToFileTextbox";
            PathToFileTextbox.Size = new Size(351, 31);
            PathToFileTextbox.TabIndex = 2;
            // 
            // IncodeFileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PathToFileTextbox);
            Controls.Add(IncodeFileButton);
            Controls.Add(BrowseFileButton);
            Name = "IncodeFileForm";
            Text = "Incode File";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BrowseFileButton;
        private Button IncodeFileButton;
        public TextBox PathToFileTextbox;
    }
}