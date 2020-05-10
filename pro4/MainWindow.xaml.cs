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
using System.IO;
using Microsoft.Win32;
using System.Drawing;


namespace pro4
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

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbbfont.SelectedIndex >= 0)
            {
                txt_content.FontSize = int.Parse(((sender as ComboBox).SelectedItem as ComboBoxItem).Content as string);
               
            }
        }
        private void Btn_color_Click(object sender, RoutedEventArgs e)
        {

            System.Windows.Forms.ColorDialog cl = new System.Windows.Forms.ColorDialog();
            if (cl.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txt_content.Foreground = new SolidColorBrush(System.Windows.Media.Color.FromArgb(cl.Color.A, cl.Color.R, cl.Color.G, cl.Color.B));

            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

      

        private void Txt_content_SelectionChanged(object sender, RoutedEventArgs e)
        {
            int row = txt_content.GetLineIndexFromCharacterIndex(txt_content.CaretIndex);
            int col = txt_content.CaretIndex - txt_content.GetCharacterIndexFromLineIndex(row);
            txt_line.Text = "Line " + (row + 1) + ", Char " + (col + 1);
           
           
        }
    }
}
