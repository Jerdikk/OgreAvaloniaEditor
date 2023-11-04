using Avalonia.Controls;
using Avalonia.Threading;
using Avalonia.VisualTree;
using Avalonia.Win32;
using OgreAvaloniaEditor.ViewModels;
using System;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;

namespace OgreAvaloniaEditor.Views
{
    public partial class MainWindow : Window
    {
        public OgreControl ogreControl;
        public MainWindow()
        {
            InitializeComponent();
            ogreControl = new OgreControl();    
            OgreHost.Children.Clear();
            OgreHost.Children.Add(ogreControl);
            
        }

        protected override void OnDataContextChanged(EventArgs e)
        {
            base.OnDataContextChanged(e);
            MainWindowViewModel? viewModel = (MainWindowViewModel?)this.DataContext;
            if (viewModel != null)
            {
                viewModel.mainWindow = this;
            }
            
        }

    }
}