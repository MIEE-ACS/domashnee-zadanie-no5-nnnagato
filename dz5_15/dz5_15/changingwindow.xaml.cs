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
using System.Windows.Shapes;

namespace dz5_15
{
    /// <summary>
    /// Логика взаимодействия для extrawindow.xaml
    /// </summary>
    public partial class extrawindow : Window
    {
        public extrawindow()
        {
            InitializeComponent();
        }

        public int get_value(int box)
        {
            int buf;
            int rezult;
            TextBox txt = numBox;
            switch(box)
            {
                case 1:
                    txt = numBox;
                    break;
                case 2:
                    txt = articulBox;
                    break;
                case 3:
                    txt = sizeBox;
                    break;
                case 4:
                    txt = priceBox;
                    break;
            }
            
            if(int.TryParse(txt.Text, out buf))
            {
                if(buf > 0)
                {
                    rezult = buf;                        
                }
                else
                {
                    MessageBox.Show("Укажите во всех строка положительные целочисленные значения.");
                    throw new Exception("ошибка ввода");
                }
            }
            else
            {
                 MessageBox.Show("Укажите во всех строка положительные целочисленные значения.");
                 throw new Exception("ошибка ввода");
            }
            
            return rezult;
        }
        public int number;
        public int article;
        public int size;
        public int price;
        
        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            number = get_value(1);
            article = get_value(2);
            size = get_value(3);
            price = get_value(4);
            this.DialogResult = true;
        }
        private void denyButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
