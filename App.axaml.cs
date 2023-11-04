using Avalonia;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Markup.Xaml;
using OgreAvaloniaEditor.ViewModels;
using OgreAvaloniaEditor.Views;

namespace OgreAvaloniaEditor
{
    public partial class App : Application
    {
        public override void Initialize()
        {
            AvaloniaXamlLoader.Load(this);
        }

        public override void OnFrameworkInitializationCompleted()
        {
            if (ApplicationLifetime is IClassicDesktopStyleApplicationLifetime desktop)
            {
                MainWindowViewModel mainWindowViewModel = new MainWindowViewModel();

                desktop.MainWindow = new MainWindow
                {
                    DataContext = mainWindowViewModel,
                };
                                
            }



            base.OnFrameworkInitializationCompleted();
        }
    }
}