using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Xaml;
using PasswordApp;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]

namespace Applied_Activity_1
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
    }
}
