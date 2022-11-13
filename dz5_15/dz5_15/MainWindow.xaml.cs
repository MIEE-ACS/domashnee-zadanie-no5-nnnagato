using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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

namespace dz5_15
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    public struct shoes
    {
        int articul;
        int size;
        int price;

        public shoes(int a, int s, int p)
        {
            articul = a;
            size = s;
            price = p;
        }

        public int Articul
        {
            set { articul = value;  }
            get { return articul; }
        }

        public int Size
        {
            set { size = value; }
            get { return size; }
        }

        public int Price
        {
            set { price = value; }
            get { return price; }
        }
        
    }
    
    public partial class MainWindow : Window
    {
        
        public void update_fields()
        {
            numerationLabel.Content = string.Format("");
            articulLabel.Content = string.Format("");
            razmerLabel.Content = string.Format("");
            priceLabel.Content = string.Format("");
            for(int i=0; i<col; i++)
            {
                numerationLabel.Content += String.Format("\n{0}.",i + 1);
                articulLabel.Content += String.Format("\n{0}", spisok[i].Articul);
                razmerLabel.Content += String.Format("\n{0}", spisok[i].Size);
                priceLabel.Content += String.Format("\n{0}", spisok[i].Price);
            }
        }
        public MainWindow()
        {
            InitializeComponent();
            spisok[0] = new shoes(1, 43, 5000);
            spisok[1] = new shoes(2, 35, 2500);
            spisok[2] = new shoes(15, 23, 1300);
            spisok[3] = new shoes(124, 12, 2700);
            spisok[4] = new shoes(3, 41, 7000);
            update_fields();
        }

         
        public static int col = 5;
        public static shoes[] spisok = new shoes[col];

        private void changeButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new extrawindow();
            window.Owner = this;
            window.ShowDialog();
            if(window.DialogResult == true)
            {
                int num = window.number - 1;
                spisok[num].Articul = window.article;
                spisok[num].Size = window.size;
                spisok[num].Price = window.price;
                update_fields();
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            var window = new addingwindow();
            window.Owner = this;
            window.ShowDialog();
            if(window.DialogResult == true)
            {
                int i = col;
                col++;
                Array.Resize(ref spisok, col);
                spisok[i].Articul = window.article;
                spisok[i].Size = window.size;
                spisok[i].Price = window.price;
                update_fields();
                
            }

        }

        private void leavebutton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
