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
            SuspendLayout();
            // 
            // ProcessNameLabel
            // 
            ProcessNameLabel.AutoSize = true;
            ProcessNameLabel.Location = new Point(205, 63);
            ProcessNameLabel.Name = "ProcessNameLabel";
            ProcessNameLabel.Size = new Size(124, 25);
            ProcessNameLabel.TabIndex = 0;
            ProcessNameLabel.Text = "Process Name";
            // 
            // OkButton
            // 
            OkButton.Location = new Point(389, 173);
            OkButton.Name = "OkButton";
            OkButton.Size = new Size(112, 34);
            OkButton.TabIndex = 1;
            OkButton.Text = "Ok";
            OkButton.UseVisualStyleBackColor = true;
            OkButton.Visible = false;
            OkButton.Click += button1_Click;
            // 
            // InProcessForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(531, 219);
            ControlBox = false;
            Controls.Add(OkButton);
            Controls.Add(ProcessNameLabel);
            Name = "InProcessForm";
            Text = "In Process";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label ProcessNameLabel;
        private Button OkButton;
    }
}