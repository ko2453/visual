using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Drawing.Text;
using System.IO;
using System.Windows;
using Microsoft.Win32;




namespace projekt
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

        private void wklej_Click(object sender, RoutedEventArgs e)
        {
            
        }

       

        private void nowy_dok_Click(object sender, RoutedEventArgs e)
        {

        }

        private void open_dok_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog();
            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            openFileDialog1.Filter = "RTF|*.rtf|Text Files|*.txt|VB Files|*.vb|C# Files|*.cs|All Files|*.*";
            openFileDialog1.ShowDialog();
            
        }

        private void richTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

  

        private void fontcombo_Initialized(object sender, EventArgs e)
        {
            
        }

        private void sizecombo_Initialized_1(object sender, EventArgs e)
        {
            int size = 5;
            while (size < 42)
            {
                sizecombo.Items.Add(size);
                size = size + 2;
            }
        }

        private void upbutton_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void sizecombo_IsEnabledChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            MessageBox.Show("SASA");
        }

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void RibbonGallery_SelectionChanged(object sender, System.Windows.RoutedPropertyChangedEventArgs<object> e)
        {
            if (this.richTextBox.Selection.IsEmpty)
                this.richTextBox.FontSize = 30.0;
            else
                this.richTextBox.Selection.ApplyPropertyValue(TextElement.FontSizeProperty, sizecombo.Text);
        }

       

       
    }
}
