﻿using System;

using Xamarin.Forms;

namespace TripLog
{
	public class MainPage : ContentPage
	{
		public MainPage()
		{
			Content = new StackLayout
			{
				Children = {
					new Label { Text = "Hello ContentPage" }
				}
			};
		}
	}
}


