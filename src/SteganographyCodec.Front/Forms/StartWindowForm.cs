namespace SteganographyCodec.Front
{
    public partial class StartWindowForm : Form
    {
        public StartWindowForm()
        {
            InitializeComponent();
        }

        private void IncodeFileButton_Click(object sender, EventArgs e)
        {
            IncodeFileForm incodeFileForm = new IncodeFileForm();
            incodeFileForm.Show();
        }
    }
}
