using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace XamlApp
{
	/// <summary>
	/// Логика взаимодействия для TeamsMain.xaml
	/// </summary>
	public partial class TeamsMain : Window
	{
		public TeamsMain()
		{
			InitializeComponent();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			VisitorMenu visitorMenu = new VisitorMenu();
			visitorMenu.Show();
			this.Close();
		}
	}
}
