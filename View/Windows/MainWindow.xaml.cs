using System.Windows;

namespace Wpf_24
{
    public partial class MainWindow : Window
    {
        public string GraphicsData { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
        }
    }
}