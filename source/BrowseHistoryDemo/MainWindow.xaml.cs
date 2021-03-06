﻿namespace BrowseHistoryDemo
{
    using System.Windows;

    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var appVM = new BrowserHistoryDemoLib.ViewModels.AppViewModel();
            DataContext = appVM;

            appVM.Init();
        }
    }
}
