﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
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
using System.Windows.Threading;

namespace joytobutton
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>  

    public partial class MainWindow : Window
    {

        private Timer _timer;
        private const int RefreshRate = 60;
        public MainWindow()
        {
            InitializeComponent();
            var inputMonitor = new ControllerIn();
            inputMonitor.Start();
            Dots();
  

        }


        //Toggles visibility of boxes and allows repositioning with mouse clicks
        #region Gear Button Clicks
        private void ButtonGear1_Click(object sender, RoutedEventArgs e)
        {
            RectGear1.Visibility = Visibility.Hidden;
        }

        private void ButtonGear2_Click(object sender, RoutedEventArgs e)
        {
            RectGear2.Visibility = Visibility.Hidden;
        }

        private void ButtonGear3_Click(object sender, RoutedEventArgs e)
        {
            RectGear3.Visibility = Visibility.Hidden;
        }

        private void ButtonGear4_Click(object sender, RoutedEventArgs e)
        {
            RectGear4.Visibility = Visibility.Hidden;
        }

        private void ButtonGear5_Click(object sender, RoutedEventArgs e)
        {
            RectGear5.Visibility = Visibility.Hidden;
        }

        private void ButtonGear6_Click(object sender, RoutedEventArgs e)
        {
            RectGear6.Visibility = Visibility.Hidden;
        }

        private void ButtonGear7_Click(object sender, RoutedEventArgs e)
        {
            RectGear7.Visibility = Visibility.Hidden;
        }

        private void ButtonGearR_Click(object sender, RoutedEventArgs e)
        {
            RectGearR.Visibility = Visibility.Hidden;
        }


        private void CanvasClick(object sender, MouseEventArgs e)
        {
            if (RectGear1.Visibility == Visibility.Hidden)
            {
                Point dropPosition = e.GetPosition(BoxWhite);
                RectGear1.Visibility = Visibility.Visible;

                Canvas.SetLeft(RectGear1, (dropPosition.X - 50));
                Canvas.SetTop(RectGear1, (dropPosition.Y - 50));
            }
            else if (RectGear2.Visibility == Visibility.Hidden)
            {
                Point dropPosition = e.GetPosition(BoxWhite);
                RectGear2.Visibility = Visibility.Visible;

                Canvas.SetLeft(RectGear2, (dropPosition.X - 50));
                Canvas.SetTop(RectGear2, (dropPosition.Y - 50));
            }
            else if (RectGear3.Visibility == Visibility.Hidden)
            {
                Point dropPosition = e.GetPosition(BoxWhite);
                RectGear3.Visibility = Visibility.Visible;

                Canvas.SetLeft(RectGear3, (dropPosition.X - 50));
                Canvas.SetTop(RectGear3, (dropPosition.Y - 50));
            }
            else if (RectGear4.Visibility == Visibility.Hidden)
            {
                Point dropPosition = e.GetPosition(BoxWhite);
                RectGear4.Visibility = Visibility.Visible;

                Canvas.SetLeft(RectGear4, (dropPosition.X - 50));
                Canvas.SetTop(RectGear4, (dropPosition.Y - 50));
            }
            else if (RectGear5.Visibility == Visibility.Hidden)
            {
                Point dropPosition = e.GetPosition(BoxWhite);
                RectGear5.Visibility = Visibility.Visible;

                Canvas.SetLeft(RectGear5, (dropPosition.X - 50));
                Canvas.SetTop(RectGear5, (dropPosition.Y - 50));
            }
            else if (RectGear6.Visibility == Visibility.Hidden)
            {
                Point dropPosition = e.GetPosition(BoxWhite);
                RectGear6.Visibility = Visibility.Visible;

                Canvas.SetLeft(RectGear6, (dropPosition.X - 50));
                Canvas.SetTop(RectGear6, (dropPosition.Y - 50));
            }
            else if (RectGear7.Visibility == Visibility.Hidden)
            {
                Point dropPosition = e.GetPosition(BoxWhite);
                RectGear7.Visibility = Visibility.Visible;

                Canvas.SetLeft(RectGear7, (dropPosition.X - 50));
                Canvas.SetTop(RectGear7, (dropPosition.Y - 50));
            }
            else if (RectGearR.Visibility == Visibility.Hidden)
            {
                Point dropPosition = e.GetPosition(BoxWhite);
                RectGearR.Visibility = Visibility.Visible;

                Canvas.SetLeft(RectGearR, (dropPosition.X - 50));
                Canvas.SetTop(RectGearR, (dropPosition.Y - 50));
            }
        }
        #endregion
        
        
        //[System.STAThread]
        private async void Dots()
        {

            Random rnd = new Random();

            for (int i = 0; i < 5; i++)
            {
                //int X = rnd.Next(100, 150);
                //int Y = rnd.Next(100, 150);

                ControllerIn ctrl = new ControllerIn();
                var x = ctrl.XInput();
                var y = ctrl.YInput();

                Draw.Circle(x, y, 10, BoxWhite);

                Thread.Sleep(1000);
            }

        }


        class Draw
        {
            public static void Circle(int x, int y, int diam, Canvas cv)
            {
                
                //Dispatcher.Invoke(() =>
                //{
                    Ellipse Circle = new Ellipse()
                    {
                        Width = diam,
                        Height = diam,
                        Stroke = Brushes.Black,
                        StrokeThickness = 10
                    };

                    cv.Children.Add(Circle);

                    Circle.SetValue(Canvas.LeftProperty, (double)x);
                    Circle.SetValue(Canvas.TopProperty, (double)y);
                //}, System.Windows.Threading.DispatcherPriority.Normal);
                
                
            }
        }


    }
}
