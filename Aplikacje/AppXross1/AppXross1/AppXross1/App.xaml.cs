﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace AppXross1
{
	public partial class App : Application
	{
		public App ()
		{
            MainPage = new Domowa(); //Zadeklarowanie naszej strony jako domowej

			//InitializeComponent();                    pominelem

			//MainPage = new AppXross1.MainPage();      pominelem
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
