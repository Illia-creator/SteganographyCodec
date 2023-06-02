
using SteganographyCodec.Codec.Files;
using SteganographyCodec.Domain;
using SteganographyCodec.Domain.Enteties.Files;
using SteganographyCodec.Domain.Enteties.Files.Const;
using SteganographyCodec.Domain.Entities.Exceptions;
using SteganographyCodec.Front.Forms;
using System.Windows.Forms;

namespace SteganographyCodec.Front
{
    public partial class EncodeFileForm : Form
    {
        public EncodeFileForm()
        {
            InitializeComponent();
        }


        public void BrowseFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Title = FileDialogConst.NameSelectFile;
                fileDialog.InitialDirectory = FileConst.InitialDirectory;
                fileDialog.Filter = FileDialogConst.FilterDocx;
                fileDialog.FilterIndex = FileDialogConst.FilterIndex;
                fileDialog.ShowDialog();
                PathToFileTextbox.Text = fileDialog.FileName;
                BusClass.value = fileDialog.FileName;
            }
            catch (Exception ex)
            {
                ExceptionForm exceptionForm = new ExceptionForm(ex);
                exceptionForm.Show();
            }
        }

        private void ShowDataInFileButton_Click(object sender, EventArgs e)
        {
            InProcessForm inProcessForm = new InProcessForm(1);
            try
            {
                if (BusClass.value == string.Empty)
                    throw new Exception("Select File Firstly!");

                inProcessForm.Show();

                EncodeFileProcess.Encoding();

                inProcessForm.CloseForm();
            }
            catch (InvalidSymbolException ex)
            {
                ExceptionForm exceptionForm = new ExceptionForm(ex);
                exceptionForm.Show();
                inProcessForm.ExtremeClose();
            }
            catch (Exception ex)
            {
                ExceptionForm exceptionForm = new ExceptionForm(ex);
                exceptionForm.Show();
                inProcessForm.ExtremeClose();
            }
        }
    }
}
