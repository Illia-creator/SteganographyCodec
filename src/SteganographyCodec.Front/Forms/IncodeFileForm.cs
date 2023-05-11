
using SteganographyCodec.Codec.Files;
using SteganographyCodec.Domain;
using SteganographyCodec.Domain.Enteties.Files;
using SteganographyCodec.Domain.Enteties.Files.Const;
using System.Windows.Forms;

namespace SteganographyCodec.Front
{
    public partial class IncodeFileForm : Form
    {

        // private readonly IGetPathFromForm getPathFromForm;
        public IncodeFileForm()
        {
            InitializeComponent();
        }
        //public IncodeFileForm(IGetPathFromForm getPathFromForm)
        //{
        //    this.getPathFromForm = getPathFromForm;
        //}


        public void BrowseFileButton_Click(object sender, EventArgs e)
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

        private void ShowDataInFileButton_Click(object sender, EventArgs e)
        {
            IncodeFileProcess.Incoding();
        }
    }
}
