namespace SteganographyCodec.Front
{
    public partial class StartWindowForm
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
            ChooseActingLabel = new Label();
            DecodeFileButton = new Button();
            IncodeFileButton = new Button();
            SuspendLayout();
            // 
            // ChooseActingLabel
            // 
            ChooseActingLabel.AutoSize = true;
            ChooseActingLabel.Location = new Point(321, 88);
            ChooseActingLabel.Name = "ChooseActingLabel";
            ChooseActingLabel.Size = new Size(128, 25);
            ChooseActingLabel.TabIndex = 0;
            ChooseActingLabel.Text = "Choose Acting";
            // 
            // DecodeFileButton
            // 
            DecodeFileButton.Location = new Point(86, 226);
            DecodeFileButton.Name = "DecodeFileButton";
            DecodeFileButton.Size = new Size(179, 82);
            DecodeFileButton.TabIndex = 1;
            DecodeFileButton.Text = "Decode File";
            DecodeFileButton.UseVisualStyleBackColor = true;
            DecodeFileButton.Click += DecodeFileButton_Click;
            // 
            // IncodeFileButton
            // 
            IncodeFileButton.Location = new Point(499, 229);
            IncodeFileButton.Name = "IncodeFileButton";
            IncodeFileButton.Size = new Size(174, 77);
            IncodeFileButton.TabIndex = 2;
            IncodeFileButton.Text = "Incode File";
            IncodeFileButton.UseVisualStyleBackColor = true;
            IncodeFileButton.Click += IncodeFileButton_Click;
            // 
            // StartWindowForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(IncodeFileButton);
            Controls.Add(DecodeFileButton);
            Controls.Add(ChooseActingLabel);
            Name = "StartWindowForm";
            Text = "Start Window";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ChooseActingLabel;
        private Button DecodeFileButton;
        private Button IncodeFileButton;
    }
}