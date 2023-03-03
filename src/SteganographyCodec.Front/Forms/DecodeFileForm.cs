using SteganographyCodec.Domain.Enteties.Files.Const;
using SteganographyCodec.Domain;
using SteganographyCodec.Codec.Files;

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
            fileDialog.Filter = FileDialogConst.FilterTxt;
            fileDialog.FilterIndex = FileDialogConst.FilterIndex;
            fileDialog.ShowDialog();
            PathToFileTextbox.Text = fileDialog.FileName;
            BusClass.value = fileDialog.FileName;
        }

        private void DecodeFileButton_Click(object sender, EventArgs e)
        {
            DecodeFileProcess.Decoding();
        }
    }
}
