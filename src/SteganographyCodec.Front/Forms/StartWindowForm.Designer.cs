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
            this.ChooseActingLabel = new System.Windows.Forms.Label();
            this.DecodeFileButton = new System.Windows.Forms.Button();
            this.IncodeFileButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ChooseActingLabel
            // 
            this.ChooseActingLabel.AutoSize = true;
            this.ChooseActingLabel.Location = new System.Drawing.Point(321, 88);
            this.ChooseActingLabel.Name = "ChooseActingLabel";
            this.ChooseActingLabel.Size = new System.Drawing.Size(128, 25);
            this.ChooseActingLabel.TabIndex = 0;
            this.ChooseActingLabel.Text = "Choose Acting";
            // 
            // DecodeFileButton
            // 
            this.DecodeFileButton.Location = new System.Drawing.Point(86, 226);
            this.DecodeFileButton.Name = "DecodeFileButton";
            this.DecodeFileButton.Size = new System.Drawing.Size(179, 82);
            this.DecodeFileButton.TabIndex = 1;
            this.DecodeFileButton.Text = "Decode File";
            this.DecodeFileButton.UseVisualStyleBackColor = true;
            // 
            // IncodeFileButton
            // 
            this.IncodeFileButton.Location = new System.Drawing.Point(499, 229);
            this.IncodeFileButton.Name = "IncodeFileButton";
            this.IncodeFileButton.Size = new System.Drawing.Size(174, 77);
            this.IncodeFileButton.TabIndex = 2;
            this.IncodeFileButton.Text = "Incode File";
            this.IncodeFileButton.UseVisualStyleBackColor = true;
            this.IncodeFileButton.Click += new System.EventHandler(this.IncodeFileButton_Click);
            // 
            // StartWindowForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IncodeFileButton);
            this.Controls.Add(this.DecodeFileButton);
            this.Controls.Add(this.ChooseActingLabel);
            this.Name = "StartWindowForm";
            this.Text = "Start Window";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label ChooseActingLabel;
        private Button DecodeFileButton;
        private Button IncodeFileButton;
    }
}