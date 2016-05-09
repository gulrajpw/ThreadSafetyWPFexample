using System.Windows;
using System.Windows.Controls;
using System.Threading;
using System;

namespace BackgroundThreadExample
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            

            Thread setResponse = new Thread(new ThreadStart(AppendTextbox));
            setResponse.Start();



        }


        private void button_Click(object sender, RoutedEventArgs e)
        {
            //add text to a label
            textBox.Text += "\r\n Event handler text \n";
        }


       
        private void AppendTextbox()
        {
            
            Dispatcher.Invoke((Action)delegate ()  //Invoke method for thread. Dispatcher method is for WPF only.
            {
                textBox.Text += "Invoked text \n";

            });
           
        }


    }
}
