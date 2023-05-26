namespace SteganographyCodec.Front.Forms
{
    partial class ExceptionForm
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
            Exceptionlabel = new Label();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // Exceptionlabel
            // 
            Exceptionlabel.Dock = DockStyle.Fill;
            Exceptionlabel.Location = new Point(0, 0);
            Exceptionlabel.Name = "Exceptionlabel";
            Exceptionlabel.Size = new Size(436, 157);
            Exceptionlabel.TabIndex = 0;
            Exceptionlabel.Text = "label1";
            Exceptionlabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // CloseButton
            // 
            CloseButton.Location = new Point(312, 111);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(112, 34);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "Close";
            CloseButton.UseVisualStyleBackColor = true;
            CloseButton.Click += CloseButton_Click;
            // 
            // ExceptionForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(436, 157);
            Controls.Add(CloseButton);
            Controls.Add(Exceptionlabel);
            Name = "ExceptionForm";
            Text = "ExceptionForm";
            ResumeLayout(false);
        }

        #endregion

        private Label Exceptionlabel;
        private Button CloseButton;
    }
}