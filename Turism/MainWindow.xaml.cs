using System;
using System.IO;
using System.Windows;
using EO.WebBrowser;

namespace Turism
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string htmlFilePath = @"C:/Users/nikit/source/repos/Turism/Turism/Map3.html";

            // Проверьте, существует ли файл
            if (File.Exists(htmlFilePath))
            {
                webView.Source = new Uri(htmlFilePath);
            }
            else
            {
                MessageBox.Show("HTML файл не найден: " + htmlFilePath);
            }
        }
    }
}
