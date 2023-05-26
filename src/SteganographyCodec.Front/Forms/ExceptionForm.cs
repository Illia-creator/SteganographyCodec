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
    public partial class ExceptionForm : Form
    {
        public ExceptionForm(Exception ex)
        {
            InitializeComponent();
            Exceptionlabel.Text = ex.Message;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
