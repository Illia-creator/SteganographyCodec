namespace SteganographyCodec.Front.Forms
{
    partial class DecodeFileForm
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
            PathToFileTextbox = new TextBox();
            DecodeFileButton = new Button();
            BrowseFileButton = new Button();
            SuspendLayout();
            // 
            // PathToFileTextbox
            // 
            PathToFileTextbox.Location = new Point(43, 102);
            PathToFileTextbox.Name = "PathToFileTextbox";
            PathToFileTextbox.Size = new Size(351, 31);
            PathToFileTextbox.TabIndex = 5;
            // 
            // DecodeFileButton
            // 
            DecodeFileButton.Location = new Point(558, 98);
            DecodeFileButton.Name = "DecodeFileButton";
            DecodeFileButton.Size = new Size(181, 35);
            DecodeFileButton.TabIndex = 4;
            DecodeFileButton.Text = "Decode File";
            DecodeFileButton.UseVisualStyleBackColor = true;
            DecodeFileButton.Click += DecodeFileButton_Click;
            // 
            // BrowseFileButton
            // 
            BrowseFileButton.Location = new Point(430, 99);
            BrowseFileButton.Name = "BrowseFileButton";
            BrowseFileButton.Size = new Size(112, 34);
            BrowseFileButton.TabIndex = 3;
            BrowseFileButton.Text = "Browse File";
            BrowseFileButton.UseVisualStyleBackColor = true;
            BrowseFileButton.Click += BrowseFileButton_Click;
            // 
            // DecodeFileForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(PathToFileTextbox);
            Controls.Add(DecodeFileButton);
            Controls.Add(BrowseFileButton);
            Name = "DecodeFileForm";
            Text = "DecodeFileForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public TextBox PathToFileTextbox;
        private Button DecodeFileButton;
        private Button BrowseFileButton;
    }
}