using MahApps.Metro.Controls;
using WPFSimplePlayground.Models;
using WPFSimplePlayground.ViewModels;

namespace WPFSimplePlayground
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void DataGrid_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {
            var result = ((Employee)((System.Windows.Controls.DataGrid)sender)?.SelectedItem)?.Name;
        }
    }
}
