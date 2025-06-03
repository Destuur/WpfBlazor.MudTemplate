using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using System.Windows;

namespace WpfBlazor.MudTemplate
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			var serviceCollection = new ServiceCollection();
			serviceCollection.AddWpfBlazorWebView();
			serviceCollection.AddMudServices();
#if DEBUG
			serviceCollection.AddBlazorWebViewDeveloperTools();
#endif

			var serviceProvider = serviceCollection.BuildServiceProvider();
			Resources.Add("services", serviceProvider);

			InitializeComponent();
		}
	}
}