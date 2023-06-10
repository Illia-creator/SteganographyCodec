namespace SteganographyCodec.Front.Forms
{
    partial class InProcessForm
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
            ProcessNameLabel = new Label();
            OkButton = new Button();
            pictureBox = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // ProcessNameLabel
            // 
            ProcessNameLabel.AutoSize = true;
            ProcessNameLabel.Location = new Point(156, 52);
            ProcessNameLabel.Margin = new Padding(2, 0, 2, 0);
            ProcessNameLabel.Name = "ProcessNameLabel";
            ProcessNameLabel.Size = new Size(82, 15);
            ProcessNameLabel.TabIndex = 0;
            ProcessNameLabel.Text = "Process Name";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(272, 104);
            OkButton.Margin = new Padding(2);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(78, 20);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Visible = false;
            OkButton.Click += button1_Click;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(64, 18);
            pictureBox.Margin = new Padding(2);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(88, 84);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 2;
            pictureBox.TabStop = false;
            // 
            // InProcessForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(372, 131);
            ControlBox = false;
            Controls.Add(pictureBox);
            Controls.Add(OkButton);
            Controls.Add(ProcessNameLabel);
            Margin = new Padding(2);
            Name = "InProcessForm";
            Text = "In Process";
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProcessNameLabel;
        private Button OkButton;
        private PictureBox pictureBox;
    }
}