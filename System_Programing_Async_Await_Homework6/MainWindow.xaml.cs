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

namespace System_Programing_Async_Await_Homework6
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string Text {  get; set; }
        public int Counter0 { get; set; } = 1;
        public int Counter1 { get; set; } = 1;
        public int Counter2 { get; set; } = 1;
        public int Counter3 { get; set; } = 1;
        public int Counter4 { get; set; } = 1;
        public int Counter5 { get; set; } = 1;
        public int Counter6 { get; set; } = 1;
        public int Counter7 { get; set; } = 1;
        public int Counter8 { get; set; } = 1;
        public MainWindow()
        {
            InitializeComponent();
        }

        private async void AddSymbol(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);

            screen.AppendText(Text);
            Counter0 = 1; 
            Counter1 = 1;
            Counter2 = 1;
            Counter3 = 1;
            Counter4 = 1;
            Counter5 = 1;
            Counter6 = 1;
            Counter7 = 1;
            Counter8 = 1;
        }

        private async void WriteSymbol(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);

            Text = "#";
        }

        private async void WriteSymbol2(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);

            if (Counter0 == 1) 
            {
                Text = "0";
                Counter0++;
            }
            else if (Counter0 == 2) 
            {
                Text = "+";
                Counter0 = 1;
            }
        }

        private async void WriteSymbol3(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            Text = "*";
        }

        private async void WriteSymbol4(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            Text = "1";
        }

        private async void ClearScreen(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            screen.Document.Blocks.Clear();
        }

        private async void WriteSymbol5(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            if(Counter1 == 1) 
            {
                Text = "2";
                Counter1++;
            }
            else if(Counter1 == 2) 
            {
                Text = "A";
                Counter1++;
            }
            else if(Counter1 == 3) 
            {
                Text = "B";
                Counter1++;
            }
            else if(Counter1 == 4) 
            {
                Text = "C";
                Counter1 = 1;
            }

        }

        private async void WriteSymbol6(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            if (Counter2 == 1)
            {
                Text = "3";
                Counter2++;
            }
            else if (Counter2 == 2)
            {
                Text = "D";
                Counter2++;
            }
            else if (Counter2 == 3)
            {
                Text = "E";
                Counter2++;
            }
            else if (Counter2 == 4)
            {
                Text = "F";
                Counter2 = 1;
            }
        }

        private async void WriteSymbol7(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            if (Counter3 == 1)
            {
                Text = "4";
                Counter3++;
            }
            else if (Counter3 == 2)
            {
                Text = "G";
                Counter3++;
            }
            else if (Counter3 == 3)
            {
                Text = "H";
                Counter3++;
            }
            else if (Counter3 == 4)
            {
                Text = "I";
                Counter3 = 1;
            }
        }

        private async void WriteSymbol8(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            if (Counter4 == 1)
            {
                Text = "5";
                Counter4++;
            }
            else if (Counter4 == 2)
            {
                Text = "J";
                Counter4++;
            }
            else if (Counter4 == 3)
            {
                Text = "K";
                Counter4++;
            }
            else if (Counter4 == 4)
            {
                Text = "L";
                Counter4 = 1;
            }
        }

        private async void WriteSymbol9(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            if (Counter5 == 1)
            {
                Text = "6";
                Counter5++;
            }
            else if (Counter5 == 2)
            {
                Text = "M";
                Counter5++;
            }
            else if (Counter5 == 3)
            {
                Text = "N";
                Counter5++;
            }
            else if (Counter5 == 4)
            {
                Text = "O";
                Counter5 = 1;
            }
        }

        private async void WriteSymbol10(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            if (Counter6 == 1)
            {
                Text = "7";
                Counter6++;
            }
            else if (Counter6 == 2)
            {
                Text = "P";
                Counter6++;
            }
            else if (Counter6 == 3)
            {
                Text = "Q";
                Counter6++;
            }
            else if (Counter6 == 4)
            {
                Text = "R";
                Counter6++;
            }
            else if (Counter6 == 5)
            {
                Text = "S";
                Counter6 = 1;
            }
        }

        private async void WriteSymbol11(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            if (Counter7 == 1)
            {
                Text = "8";
                Counter7++;
            }
            else if (Counter7 == 2)
            {
                Text = "T";
                Counter7++;
            }
            else if (Counter7 == 3)
            {
                Text = "U";
                Counter7++;
            }
            else if (Counter7 == 4)
            {
                Text = "V";
                Counter7 = 1;
            }
        }

        private async void WriteSymbol12(object sender, RoutedEventArgs e)
        {
            await Task.Delay(1000);
            if (Counter8 == 1)
            {
                Text = "9";
                Counter8++;
            }
            else if (Counter8 == 2)
            {
                Text = "W";
                Counter8++;
            }
            else if (Counter8 == 3)
            {
                Text = "X";
                Counter8++;
            }
            else if (Counter8 == 4)
            {
                Text = "Y";
                Counter8++;
            }
            else if (Counter8 == 5)
            {
                Text = "Z";
                Counter8 = 1;
            }
        }
    }
}