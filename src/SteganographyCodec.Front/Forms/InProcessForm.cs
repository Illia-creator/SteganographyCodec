using SteganographyCodec.Domain.Entities.Exceptions;
using System.Reflection;

namespace SteganographyCodec.Front.Forms
{
    public partial class InProcessForm : Form
    {
        public int processCode;
        public InProcessForm(int processCode)
        {
            try
            {
                InitializeComponent();

                this.processCode = processCode;

                if (processCode == 1)
                {
                    ProcessNameLabel.Text = "Encoding";
                }
                else if (processCode == 2)
                {
                    ProcessNameLabel.Text = "Decoding";
                }
            }
            catch (ExtremeCloseFormException ex)
            {
                Close();
            }
        }

        public void CloseForm()
        {
            if (processCode == 1)
            {
                ProcessNameLabel.Text = "Encoding Completed";               
            }
            else if (processCode == 2)
            {
                ProcessNameLabel.Text = "Decoding Completed";
            }

            pictureBox.Image = Image.FromFile(
                    Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                     @"C:\Users\sie29\source\repos\SteganographyCodec\src\Images\Oxygen-Icons.org-Oxygen-Actions-dialog-ok.256.png"));

            OkButton.Visible = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void ExtremeClose()
        {
            Close();
        }
    }
}
