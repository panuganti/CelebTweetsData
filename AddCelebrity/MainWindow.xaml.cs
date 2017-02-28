using Microsoft.Win32;
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
using FireSharp;
using CelebriTweesLibrary;

namespace AddCelebrity
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void _ctlSelectImage_Click(object sender, RoutedEventArgs e)
        {
            var dialog = new OpenFileDialog();
            var dialogSucc = dialog.ShowDialog();
            if (dialogSucc.HasValue && dialogSucc.Value)
            {
                // ... Create a new BitmapImage.
                BitmapImage b = new BitmapImage();
                b.BeginInit();
                b.UriSource = new Uri(dialog.FileName);
                b.EndInit();
                // ... Assign Source.
                _ctlImage.Source = b;
                _ctlStatus.Text = String.Format("w x h: {0} x {1}", b.Width, b.Height); 
            }
        }

        private void _ctlAddCelebrity_Click(object sender, RoutedEventArgs e)
        {
            var firebase = new Firebase();
            firebase.
        }
    }
}
