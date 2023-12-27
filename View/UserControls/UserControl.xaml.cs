using System.Windows;
namespace Wpf_24.View.UserControls
{
    public partial class UserControl : UserControl
    {
        public static readonly DependencyProperty InputTextProperty =
            DependencyProperty.Register("InputText", typeof(string), typeof(UserControl), new PropertyMetadata(""));

        public string InputText
        {
            get { return (string)GetValue(InputTextProperty); }
            set { SetValue(InputTextProperty, value); }
        }


        public event EventHandler EditButtonClicked;

        public UserControl()
        {
            InitializeComponent();
        }

        private void EditButtonClick(object sender, RoutedEventArgs e)
        {
            EditButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}