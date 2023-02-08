using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup.Localizer;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace pr1._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int player;
        private int a;
        public MainWindow()
        {
            InitializeComponent();
            this.Width = 900;
            this.Height= 700;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            switch (player)
            {
                case 1:
                    label1.Content = "Играют нолики";
                    sender.GetType().GetProperty("Content").SetValue(sender, "X");
                    player = 0;
                    break;
                case 0:
                    label1.Content = "Играют крестики";
                    sender.GetType().GetProperty("Content").SetValue(sender, "O");
                    player = 1;
                    break;
            }
            sender.GetType().GetProperty("IsEnabled").SetValue(sender, false);
            Botinok();
            proverka();
        }
        private void proverka()
        {
            if (button1.Content == button2.Content && button2.Content == button3.Content)
            {
                if (button1.Content == "X" || button1.Content == "O")
                {
                    if (button1.Content == "X")
                    {
                        MessageBox.Show("Победили крестики!");
                        vigral();
                    }
                    else
                    {
                        MessageBox.Show("Победили нолики!");
                        vigral();
                    }
                }
            }
            if (button4.Content == button5.Content && button5.Content == button6.Content)
            {
                if (button4.Content == "X" || button4.Content == "O")
                {
                    if (button4.Content == "X")
                    {
                        MessageBox.Show("Победили крестики!");
                        vigral();
                    }
                    else
                    {
                        MessageBox.Show("Победили нолики!");
                        vigral();
                    }
                }
            }
            if (button7.Content == button8.Content && button8.Content == button9.Content)
            {
                if (button7.Content == "X" || button7.Content == "O")
                {
                    if (button7.Content == "X")
                    {
                        MessageBox.Show("Победили крестики!");
                        vigral();
                    }
                    else
                    {
                        MessageBox.Show("Победили нолики!");
                        vigral();
                    }
                }
            }
            if (button1.Content == button5.Content && button5.Content == button9.Content)
            {
                if (button1.Content == "X" || button1.Content == "O")
                {
                    if (button1.Content == "X")
                    {
                        MessageBox.Show("Победили крестики!");
                        vigral();
                    }
                    else
                    {
                        MessageBox.Show("Победили нолики!");
                        vigral();
                    }
                }
            }
            if (button3.Content == button5.Content && button5.Content == button7.Content)
            {
                if (button3.Content == "X" || button3.Content == "O")
                {
                    if (button3.Content == "X")
                    {
                        MessageBox.Show("Победили крестики!");
                        vigral();
                    }
                    else
                    {
                        MessageBox.Show("Победили нолики!");
                        vigral();
                    }
                }
            }
            if (button3.Content == button6.Content && button6.Content == button9.Content)
            {
                if (button3.Content == "X" || button3.Content == "O")
                {
                    if (button2.Content == "X")
                    {
                        MessageBox.Show("Победили крестики!");
                        vigral();
                    }
                    else
                    {
                        MessageBox.Show("Победили нолики!");
                        vigral();
                    }
                }
            }
            if (button2.Content == button5.Content && button5.Content == button8.Content)
            {
                if (button2.Content == "X" || button2.Content == "O")
                {
                    if (button2.Content == "X")
                    { 
                        MessageBox.Show("Победили крестики!");
                        vigral();
                    }
                    else
                    {
                        MessageBox.Show("Победили нолики!");
                        vigral();
                    }
                }
            }
            if (button1.Content == button4.Content && button4.Content == button7.Content)
            {
                if (button1.Content == "X" || button1.Content == "O")
                {
                    if (button1.Content == "X")
                    {
                        MessageBox.Show("Победили крестики!");
                        vigral();
                    }
                    else
                    {
                        MessageBox.Show("Победили нолики!");
                        vigral();
                    }
                }
            }
        }

        private void Nachalo_Click(object sender, RoutedEventArgs e)
        {
            button1.Content = "";
            button1.IsEnabled= true;
            button2.Content = "";
            button2.IsEnabled = true;
            button3.Content = "";
            button3.IsEnabled = true;
            button4.Content = "";
            button4.IsEnabled = true;
            button5.Content = "";
            button5.IsEnabled = true;
            button6.Content = "";
            button6.IsEnabled = true;
            button7.Content = "";
            button7.IsEnabled = true;
            button8.Content = "";
            button8.IsEnabled = true;
            button9.Content = "";
            button9.IsEnabled = true;
            Nachalo.IsEnabled= false;
        }
        private void Vihod_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void Krestiki_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Играют крестики";
            player = 1;
            Nachalo.IsEnabled = true;
        }

        private void Noliki_Click(object sender, RoutedEventArgs e)
        {
            label1.Content = "Играют нолики";
            player = 0;
            Nachalo.IsEnabled = true;
        }
        private void vigral()
        {
            button1.Content = "";
            button1.IsEnabled = false;
            button2.Content = "";
            button2.IsEnabled = false;
            button3.Content = "";
            button3.IsEnabled = false;
            button4.Content = "";
            button4.IsEnabled = false;
            button5.Content = "";
            button5.IsEnabled = false;
            button6.Content = "";
            button6.IsEnabled = false;
            button7.Content = "";
            button7.IsEnabled = false;
            button8.Content = "";
            button8.IsEnabled = false;
            button9.Content = "";
            button9.IsEnabled = false;
        }
        private void Botinok()
        {
            Random random = new Random();
            a = random.Next(1,9);
            switch (player)
            {
                case 1:
                    if (a == 1)
                    {
                        if (button1.Content == "X" || button1.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button1.Content = "X";
                            button1.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    if (a == 2)
                    {
                        if (button2.Content == "X" || button2.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button2.Content = "X";
                            button2.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    if (a == 3)
                    {
                        if (button3.Content == "X" || button3.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button3.Content = "X";
                            button3.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    if (a == 4)
                    {
                        if (button4.Content == "X" || button4.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button4.Content = "X";
                            button4.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    if (a == 5)
                    {
                        if (button5.Content == "X" || button5.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button5.Content = "X";
                            button5.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    if (a == 6)
                    {
                        if (button6.Content == "X" || button6.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button6.Content = "X";
                            button6.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    if (a == 7)
                    {
                        if (button7.Content == "X" || button6.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button7.Content = "X";
                            button7.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    if (a == 8)
                    {
                        if (button8.Content == "X" || button8.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button8.Content = "X";
                            button8.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    if (a == 9)
                    {
                        if (button9.Content == "X" || button9.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button9.Content = "X";
                            button9.IsEnabled = false;
                            player = 0;
                            label1.Content = "Играют нолики";
                        }
                    }
                    break;
                case 0:
                    if (a == 1)
                    {
                        if (button1.Content == "X" || button1.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button1.Content = "O";
                            button1.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    if (a == 2)
                    {
                        if (button2.Content == "X" || button2.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button2.Content = "O";
                            button2.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    if (a == 3)
                    {
                        if (button3.Content == "X" || button3.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button3.Content = "O";
                            button3.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    if (a == 4)
                    {
                        if (button4.Content == "X" || button4.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button4.Content = "O";
                            button4.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    if (a == 5)
                    {
                        if (button5.Content == "X" || button5.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button5.Content = "O";
                            button5.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    if (a == 6)
                    {
                        if (button6.Content == "X" || button6.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button6.Content = "O";
                            button6.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    if (a == 7)
                    {
                        if (button7.Content == "X" || button7.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button7.Content = "O";
                            button7.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    if (a == 8)
                    {
                        if (button8.Content == "X" || button8.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button8.Content = "O";
                            button8.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    if (a == 9)
                    {
                        if(button9.Content == "X" || button9.Content == "O")
                        {
                            Botinok();
                        }
                        else
                        {
                            button9.Content = "O";
                            button9.IsEnabled = false;
                            player = 1;
                            label1.Content = "Играют крестики";
                        }
                    }
                    break;
            }
        }
    }
}
