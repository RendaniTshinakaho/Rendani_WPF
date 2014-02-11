using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace FirstWpfClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            DataContext = this;
            InitializeComponent();
        }

        ObservableCollection<int> sampleData = new ObservableCollection<int>();
        public ObservableCollection<int> SampleData { get {
            if (sampleData.Count <= 0)
            {
                sampleData.Add(1);
                sampleData.Add(2);
                sampleData.Add(3);
                sampleData.Add(4);
                sampleData.Add(5);
            }
            return sampleData;
        } }

        private void BtnDelete_OnClick(object sender, RoutedEventArgs e)
        { 
            sampleData.Remove(4);         
        }

        private void BtnAdd_OnClick(object sender, RoutedEventArgs e)
        {
            sampleData.Add(6);
            sampleData.Add(7);
        }

        private void BtnEdit_OnClick(object sender, RoutedEventArgs e)
        {
           
        }
    }
}
