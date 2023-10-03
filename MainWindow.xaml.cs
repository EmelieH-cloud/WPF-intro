using System.Windows;

namespace WPF_intro
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
            cmbPriority.Items.Add("Critical");
            cmbPriority.Items.Add("High");
            cmbPriority.Items.Add("Medium");
            cmbPriority.Items.Add("Low");
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (txtTask != null && cmbPriority.Text != null)
            {
                string task = txtTask.Text;
                string priority = cmbPriority.Text;
                Task t = new(task, priority);
                MyListView.Items.Add(t.DisplayData());
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            if (txtTask != null && cmbPriority.Text != null)
            {
                string task = txtTask.Text;
                string priority = cmbPriority.Text;
                Task t = new(task, priority);
                MyListView.Items.Remove(t.DisplayData());
            }
        }
    }
}
