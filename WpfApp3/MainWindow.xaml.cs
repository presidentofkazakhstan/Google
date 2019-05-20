using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp3
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            webBrowser.Source = new Uri("https://google.com");

        }



        private void AddNewItem(object sender, SelectionChangedEventArgs e)
        {
            if (TabControl.SelectedIndex == TabControl.Items.Count - 1)
            {
                (TabControl.Items[TabControl.Items.Count - 1] as TabItem).Header = "Google";

                (TabControl.Items[TabControl.Items.Count - 1] as TabItem).Content = new WebBrowser()
                {
                    Source = new Uri("https://google.com")
                };

                TabItem addNewItem = new TabItem()
                {
                    Header = "+"
                };
                TabControl.Items.Add(addNewItem);
            }
        }
    }
}
