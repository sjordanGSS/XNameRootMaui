using System;
using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Maui.Controls;


namespace MauiTest4
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
			collection.ItemsSource = new List<string>
			{
				string.Empty
			};			
		}

		private void Button_Clicked(object sender, EventArgs e)
        {
			Debug.WriteLine($"Clicked called from {this.GetType()}");
        }
	}
}
