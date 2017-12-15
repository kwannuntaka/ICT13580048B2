using System;
using System.Collections.Generic;
using ICT13580048B2.Models;
using Xamarin.Forms;

namespace ICT13580048B2
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            newButton.Clicked += NewButton_Clicked;
		}

		protected override void OnAppearing()
		{
			LoadData();
		}

		void LoadData()
		{
            productListView.ItemsSource = App.Dbhelper.GetProducts();
		}

		void NewButton_Clicked(object sender, EventArgs e)
		{
			Navigation.PushModalAsync(new ProductNewPage());
		}

		void Edit_Clicked(object sender, System.EventArgs e)
		{
			var button = sender as MenuItem;
			var product = button.CommandParameter as Product;
			Navigation.PushModalAsync(new ProductNewPage(product));
		}

		async void Delete_Clicked(object sender, System.EventArgs e)
		{

			var button = sender as MenuItem;
			var product = button.CommandParameter as Product;

			var isOk = await DisplayAlert("ยืนยัน", "คุณต้องการลบใช่หรือไม่", "ใช่", "ไม่ใช่");

			if (isOk)
			{
                App.Dbhelper.DeleteProduct(product);
				LoadData();
			}
		}
	}
}


               