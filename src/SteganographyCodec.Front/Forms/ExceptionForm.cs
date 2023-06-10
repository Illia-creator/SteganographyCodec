using SteganographyCodec.Domain.Entities.Exceptions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
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
            pictureBox.Image = Image.FromFile(
                    Path.Combine(
                    Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                     @"C:\Users\sie29\source\repos\SteganographyCodec\src\Images\Oxygen-Icons.org-Oxygen-Actions-dialog-close.256.png"));
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
