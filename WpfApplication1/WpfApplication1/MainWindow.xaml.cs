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

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Random rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                lbrastgelesayılar.Items.Add(rnd.Next(0, 100));
            }
            
        }
        string xx; 
        
        private void btnbaşlat_Click(object sender, RoutedEventArgs e)
        {
            hak = 5;
            tbhak.Text = hak.ToString();
            Random rnd = new Random();
            xx = lbrastgelesayılar.Items[rnd.Next(0, lbrastgelesayılar.Items.Count)].ToString();
            btntahminet.IsEnabled = true;
            
        }
        int hak=5;
        private void btntahminet_Click(object sender, RoutedEventArgs e)
        {
            int tsayı;
            if (int.TryParse(tbtahmin.Text,out tsayı))
            {
                if (hak != 0)
                {
                    hak--;
                }

                tbhak.Text = hak.ToString();
                if (hak == 0)
                {
                    MessageBox.Show("hakkınız bitti");

                }

                if (int.TryParse(tbtahmin.Text,out tsayı))
                {
                    if (tbtahmin.Text == xx)
                    {
                        MessageBox.Show("doğru bildiniz");
                        tbkrastgelesayı.Text = xx.ToString();
                        btntahminet.IsEnabled = false;
                        lbrastgelesayılar.Items.Remove(int.Parse(xx));
                    }
                    else
                    {
                        if ((int.Parse(tbtahmin.Text) < int.Parse(xx)))
                        {
                            MessageBox.Show("daha büyük bir sayı giriniz");


                        }
                        else if (int.Parse(tbtahmin.Text) > int.Parse(xx))
                        {
                            MessageBox.Show("daha küçük bir sayı giriniz");


                        }

                    }
                }
                
                
            }
            else
            {

                MessageBox.Show("girdiğin sayıyı kontrol et");
                tbhak.Text = hak.ToString();
                tbtahmin.Clear();
                tbtahmin.Focus();
            }

            tbtahmin.Clear();
            tbtahmin.Focus();


        }
    }
}
