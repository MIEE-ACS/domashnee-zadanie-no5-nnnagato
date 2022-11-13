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
    /// Логика взаимодействия для addingwindow.xaml
    /// </summary>
    public partial class addingwindow : Window
    {
        public addingwindow()
        {
            InitializeComponent();
        }
        public int article;
        public int size;
        public int price;

        int get_value(int index)
        {
            int buf;
            int result;
            TextBox txt = sizeBox;
            switch(index)
            {
                case 1:
                    txt = articulBox;
                    break;
                case 2:
                    txt = sizeBox;
                    break;
                case 3:
                    txt = priceBox;
                    break;
            }
            if(int.TryParse(txt.Text, out buf))
            {
                if(buf>0)
                {
                    result = buf;
                }
                else
                {
                    MessageBox.Show("Введите положительные значения");
                    throw new Exception("Ошибка ввода");
                }    
            }
            else
            {
                MessageBox.Show("Введите во все поля целые числа");
                throw new Exception("Ошибка ввода");
            }
            return result;
        }
        private void acceptButton_Click(object sender, RoutedEventArgs e)
        {
            article = get_value(1);
            size = get_value(2);
            price = get_value(3);
            this.DialogResult = true;
        }

        private void denyButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
