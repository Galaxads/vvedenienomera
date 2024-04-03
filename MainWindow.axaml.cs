using Avalonia.Controls;
using Avalonia.Interactivity;
using System;
using Avalonia.Interactivity;
using System.Diagnostics;
using HarfBuzzSharp;
using Microsoft.CodeAnalysis.CSharp;

namespace vvedenienomera
{
    public partial class MainWindow : Window
    {
        int znachtel;
        string nowchislo = "";
        

        public MainWindow()
        {
            InitializeComponent();
        }

       

        public void NumberPlus(object source, RoutedEventArgs args)
        {
            if (0<=znachtel)
            {
                znachtel += 1;

                nomertel.Text = $"{znachtel}";

            }

        }
        public void NumberMinus(object source, RoutedEventArgs args)
        {
            if (0 < znachtel)
            {
                znachtel -= 1;
                nomertel.Text = $"{znachtel}";

            }
           
        }
        public void Sbros(object source, RoutedEventArgs args)
        {
            if (0 < znachtel)
            {
                znachtel = 0;
                nomertel.Text = $"{znachtel}";

            }

        }
        public void podtverjd(object source, RoutedEventArgs args)
        {
            nomers.Text=$"Ваш номер телефона:{nomertel.Text}";

        }
        public void Numberrandom(object source, RoutedEventArgs args)
        {
            int chislo;
            
            nowchislo="";
            Random rnd = new Random();
                for (int i = 0; i < 11; i++)
                {
                    chislo = rnd.Next(1, 10);
                    nowchislo += chislo;
                }
            
           
            nomers1.Text = $"Ваш номер телефона?: {nowchislo}";
        }
        public void podtverjd2(object source, RoutedEventArgs args)
        {
            nomers1.Text = $"Номер:{nowchislo}";

        }
        public void podtverjd3(object source, RoutedEventArgs args)
        {
            xname.Text = $"Номер телефона:{x1}+{x2}+{x3}+{x4}+{x5}+{x6}+{x7}+{x8}+{x9}+{x10}+{x11}";

        }
    }
}