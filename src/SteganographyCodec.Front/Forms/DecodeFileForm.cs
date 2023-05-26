using SteganographyCodec.Codec.Files;
using SteganographyCodec.Domain;
using SteganographyCodec.Domain.Enteties.Files.Const;

namespace SteganographyCodec.Front.Forms
{
    public partial class DecodeFileForm : Form
    {
        public DecodeFileForm()
        {
            InitializeComponent();
        }


        private void BrowseFileButton_Click(object sender, EventArgs e)
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

        private void DecodeFileButton_Click(object sender, EventArgs e)
        {
            InProcessForm inProcessForm = new InProcessForm(2);

            try
            {
                if (BusClass.value == string.Empty)
                    throw new Exception("Select File Firstly!");

                inProcessForm.Show();

                DecodeFileProcess.Decoding();

                inProcessForm.CloseForm();
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
