namespace MorseApp
{
    public partial class Form1 : Form, IObserver
    {
        private Controller controller;
        private Model model;
        public Form1(Model model)
        {
            InitializeComponent();
            this.model = model;
            this.controller = new Controller(model, this);
            this.model.Register(this);
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void UpdateState()
        {

        }
        private void BrowseButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Wave File (*.wav)|*.wav;";
            if (openFileDialog1.ShowDialog() != DialogResult.OK)
                return;

         controller.OpenFile(openFileDialog1.FileName);
        }

        private void buttonDecode_Click(object sender, EventArgs e)
        {
            controller.Decode();
        }
    }
}