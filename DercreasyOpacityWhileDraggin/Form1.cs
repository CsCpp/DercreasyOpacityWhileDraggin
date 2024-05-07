namespace DercreasyOpacityWhileDraggin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_ResizeBegin(object sender, EventArgs e)
        {
            Opacity = 0.5;
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            Opacity = 1;
        }
    }
}
