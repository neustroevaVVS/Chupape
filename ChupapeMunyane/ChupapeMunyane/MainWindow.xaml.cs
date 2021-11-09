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

namespace ChupapeMunyane
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /// <summary> Проверка Паспорта </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            /// 
            string str1 = textBox1.Text;

            if (str1.Length != 11)
            {
                MessageBox.Show("Не корректно указаны паспортные данные");
            }
            else
            {
                //MessageBox.Show("Всё ок");

                string strTemp = str1.Replace(" ", "");
                bool success = long.TryParse(strTemp, out long tel);

                if (success && str1.Length == 11)
                {
                    //MessageBox.Show("Верно указаны паспортные данные");
                }
                else MessageBox.Show("Не корректно указаны паспортные данные");

            }




            /// <summary> Проверка Телефона </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string str3 = textBox3.Text;

            if (str3.Length != 0)
            {
                if (Convert.ToString(str3[0]) != "+")
                {
                    bool success = long.TryParse(str3, out long tel);

                    if (success && str3.Length == 11)
                    {
                        //MessageBox.Show("Верно введён номер телефона");
                    }
                    else MessageBox.Show("Не верно введён номер телефона");
                }

                if (Convert.ToString(str3[0]) == "+")
                {
                    str3 = str3.Replace(Convert.ToString(str3[0]), "0");
                    //MessageBox.Show("asd " + str3);

                    bool success = long.TryParse(str3, out long tel);

                    if (success && str3.Length == 12)
                    {
                        //MessageBox.Show("Верно введён номер телефона");
                    }
                    else MessageBox.Show("Не верно введён номер телефона");
                }
            }
            else MessageBox.Show("Не верно введён номер телефона");




            /// <summary> Проверка e-mail </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            string strMail = textBox4.Text;
            string mailWord = "mail.ru";
            int countDog = 0;

            while (true)
            {
                foreach (var ch in strMail) if (ch == '@' && strMail[0] != '@' &&
                        strMail[strMail.Length - 1] != '@') countDog++;
                if (countDog != 1)
                {
                    MessageBox.Show("E-mail введён не корректно");
                    break;
                }
                //else MessageBox.Show("E-mail введён корректно");

                int a = strMail.IndexOf(mailWord);

                if (a < 0) MessageBox.Show("E-mail введён не корректно");
                //else MessageBox.Show("E-mail введён корректно");



                break;
            }
        }
    }
}
