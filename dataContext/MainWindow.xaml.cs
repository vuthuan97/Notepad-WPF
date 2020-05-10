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

namespace dataContext
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<User> dsuser;
        public MainWindow()
        {
            InitializeComponent();
            DataContext = this;
            dsuser = new List<User>();
            Binding binding = new Binding("Text");
            binding.Source = txt_str;
            txt_value.SetBinding(TextBox.TextProperty, binding);
            dsuser.Add(new User() { Name="Vũ Thuận"});
            dsuser.Add(new User() { Name = "Hoàng Qúy" });
            lb_display.ItemsSource = dsuser;
            CollectionView view = (CollectionView)CollectionViewSource.GetDefaultView(lb_display.ItemsSource);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            BindingExpression binding = txtTitle.GetBindingExpression(TextBox.TextProperty);
            binding.UpdateSource();

        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            dsuser.Add(new User() {Name = txt_UserName.Text });
            CollectionViewSource.GetDefaultView(lb_display.ItemsSource).Refresh();
        }

        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            if(lb_display.SelectedIndex >=0)
            {
                dsuser.RemoveAt(lb_display.SelectedIndex);
            }
            CollectionViewSource.GetDefaultView(lb_display.ItemsSource).Refresh();
        }

        private void Btn_change_Click(object sender, RoutedEventArgs e)
        {

        }
    }
    public class User
    {
        public string Name { get; set; }
    }
}
