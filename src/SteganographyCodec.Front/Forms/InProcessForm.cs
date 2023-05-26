using SteganographyCodec.Domain.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                    ProcessNameLabel.Text = "Incoding";
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
