﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace AppXross1
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Domowa : ContentPage
	{
		public Domowa ()
		{
			InitializeComponent ();
		}

        private void Button_Clicked(object sender, EventArgs e)
        {
            string text = GlownyWpis.Text;
            //odniesienie do entry x.Name 

            GlownyLabel.Text = "Witaj " + text;
            //odniesienie do Label x:Name="GlownyLabel" + powyzszy string text
        }
    }
}