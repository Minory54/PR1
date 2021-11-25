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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
{
	/// <summary>
	/// Логика взаимодействия для MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{

		SolidColorBrush blueColor = new SolidColorBrush(Color.FromRgb(105, 149, 194));
		SolidColorBrush whiteColor = new SolidColorBrush(Color.FromRgb(255, 255, 255));
		SolidColorBrush greyColor = new SolidColorBrush(Color.FromRgb(126, 126, 126));

		FontFamily MicrosoftSansSerif = new FontFamily("Microsoft Sans Serif");

        public MainWindow()
		{
			InitializeComponent();
		}

		private void Main_Loaded(object sender, RoutedEventArgs e)
		{
			RowDefinition row1 = new RowDefinition { Height = GridLength.Auto};
			RowDefinition row2 = new RowDefinition();
			RowDefinition row3 = new RowDefinition { Height = GridLength.Auto };
			Main.RowDefinitions.Add(row1);
			Main.RowDefinitions.Add(row2);
			Main.RowDefinitions.Add(row3);

			ColumnDefinition col1 = new ColumnDefinition();
			ColumnDefinition col2 = new ColumnDefinition { Width = GridLength.Auto };
			ColumnDefinition col3 = new ColumnDefinition();
			Main.ColumnDefinitions.Add(col1);
			Main.ColumnDefinitions.Add(col2);
			Main.ColumnDefinitions.Add(col3);

			//Main.ShowGridLines = true;

			// HEADER
			// Блок для логотипа
			StackPanel logoPanel = new StackPanel
			{
				Orientation = Orientation.Horizontal,
				Margin = new Thickness(0, 5, 0, 3),
			};
			Grid.SetRow(logoPanel, 0);
			Grid.SetColumn(logoPanel, 0);
			Main.Children.Add(logoPanel);

			// Логотип в шапке
			Image logo = new Image
			{
				Source = new BitmapImage(new Uri("Res/logo.jpg", UriKind.Relative)),
				Height = 40,
			};
			logoPanel.Children.Add(logo);

			// Текст рядом с логотипом
			TextBlock textLogo = new TextBlock 
			{ 
				Text = "NBA Management System",
				FontFamily = MicrosoftSansSerif,
				VerticalAlignment = VerticalAlignment.Center,
				Margin = new Thickness(10, 0, 0, 0),
				Foreground = greyColor
			};
			logoPanel.Children.Add(textLogo);


			// Центральный блок
			StackPanel adminPanel = new StackPanel
			{
				Orientation = Orientation.Horizontal,
				VerticalAlignment = VerticalAlignment.Center,
				HorizontalAlignment = HorizontalAlignment.Center,
			};
			Grid.SetRow(adminPanel, 0);
			Grid.SetColumn(adminPanel, 1);
			Main.Children.Add(adminPanel);

			// Текст центрального блока
			TextBlock textAdmin = new TextBlock
			{
				Text = "Admin Panel",
				FontFamily = MicrosoftSansSerif,
				VerticalAlignment = VerticalAlignment.Center,
				FontSize = 16,
				
			};
			adminPanel.Children.Add(textAdmin);


			// Блок для кнопки
			StackPanel btnPanel = new StackPanel
			{
				Orientation = Orientation.Horizontal,
				VerticalAlignment = VerticalAlignment.Center,
				HorizontalAlignment = HorizontalAlignment.Right,
			};
			Grid.SetRow(btnPanel, 0);
			Grid.SetColumn(btnPanel, 2);
			Main.Children.Add(btnPanel);

			// Кнопка "Back"
			Button headerBtn = new Button
			{
				Content = "Back",
				Margin = new Thickness(0, 0, 20, 0),
				MinWidth = 50
			};
			btnPanel.Children.Add(headerBtn);

			// Линия
			Rectangle line = new Rectangle 
			{ 
				Fill = blueColor,
				Height = 1,
				VerticalAlignment = VerticalAlignment.Bottom
			};
			Grid.SetRow(line, 0);
			Grid.SetColumnSpan(line, 3);
			Main.Children.Add(line);
			// HEADER END


			// MAIN
			// Основной блок
			StackPanel mainPanel = new StackPanel
			{
				VerticalAlignment = VerticalAlignment.Center,
				HorizontalAlignment = HorizontalAlignment.Center,
			};
			Grid.SetRow(mainPanel, 1);
			Grid.SetColumn(mainPanel, 1);
			Main.Children.Add(mainPanel);

			// Текст центрального блока
			TextBlock textMain = new TextBlock
			{
				Text = "Users can login the system using their jobnumber and password",
				FontFamily = MicrosoftSansSerif,
				Margin = new Thickness(0, 0, 0, 40),
				FontSize = 14,
				Foreground = greyColor
			};
			mainPanel.Children.Add(textMain);


			// Блок для формы заполения
			StackPanel formPanel = new StackPanel
			{
				Margin = new Thickness(30, 0, 30, 0),
			};
			mainPanel.Children.Add(formPanel);


			// Блок для поля "Jobnumber"
			StackPanel loginPanel = new StackPanel
			{
				Orientation = Orientation.Horizontal,
				HorizontalAlignment = HorizontalAlignment.Left,
				Margin = new Thickness(0, 0, 0, 15),
			};
			formPanel.Children.Add(loginPanel);

			// Текст для поля "Jobnumber"
			TextBlock textLogin = new TextBlock
			{
				Text = "Jobnumber:",
				FontFamily = MicrosoftSansSerif,
				Margin = new Thickness(0, 0, 20, 0),
				Height = 15
			};
			loginPanel.Children.Add(textLogin);

			// Поле ввода "Jobnumber"
			TextBox loginBox = new TextBox 
			{ 
				Width = 200,
				Height = 25
			};
			loginPanel.Children.Add(loginBox);


			// Блок для поля "Password"
			StackPanel passPanel = new StackPanel
			{
				Orientation = Orientation.Horizontal,
				HorizontalAlignment = HorizontalAlignment.Left,
			};
			formPanel.Children.Add(passPanel);

			// Текст для поля "Password"
			TextBlock textPass = new TextBlock
			{
				Text = "Password:",
				FontFamily = MicrosoftSansSerif,
				Margin = new Thickness(0, 0, 27, 0),
				Height = 15
			};
			passPanel.Children.Add(textPass);

			// Поле ввода "Password"
			TextBox passBox = new TextBox
			{
				Width = 200,
				Height = 25
			};
			passPanel.Children.Add(passBox);


			// Блок для чек-бокса и кнопок
			StackPanel formBottomPanel = new StackPanel
			{
				Margin = new Thickness(83, 25, 0, 0),
			};
			formPanel.Children.Add(formBottomPanel);

			// Чек-бокс "Remember Me"
			CheckBox remBox = new CheckBox { Content = "Remember Me" };
			formBottomPanel.Children.Add(remBox);


			// Блок для кнопок
			StackPanel formBtnPanel = new StackPanel
			{
				Orientation = Orientation.Horizontal,
				HorizontalAlignment = HorizontalAlignment.Left,
				Margin = new Thickness(0, 15, 0, 0),
			};
			formBottomPanel.Children.Add(formBtnPanel);

			// Кнопка "Login"
			Button loginBtn = new Button
			{
				Content = "Login",
				Height = 25,
				Width = 50,
				Margin = new Thickness(0, 0, 40, 0),
			};
			formBtnPanel.Children.Add(loginBtn);

			// Кнопка "Cancel"
			Button cancelBtn = new Button
			{
				Content = "Cancel",
				Height = 25,
				Width = 50,
			};
			formBtnPanel.Children.Add(cancelBtn);
			// MAIN END


			// FOOTER 

			Border border = new Border { Background = blueColor };
			Grid.SetRow(border, 2);
			Grid.SetColumnSpan(border, 3);
			Main.Children.Add(border);

			StackPanel footerPanel = new StackPanel
			{
				HorizontalAlignment = HorizontalAlignment.Center,
			};
			Grid.SetRow(footerPanel, 2);
			Grid.SetColumn(footerPanel, 1);
			Main.Children.Add(footerPanel);

			// Текст в подвале
			TextBlock textFooter = new TextBlock
			{
				FontSize = 11,
				FontFamily = MicrosoftSansSerif,
				Text = "The current season is 2016-2017 and the NBA already has a history of 21 years",
				Foreground = whiteColor,
			};
			footerPanel.Children.Add(textFooter);

			// FOOTER END

		}
	}
}
