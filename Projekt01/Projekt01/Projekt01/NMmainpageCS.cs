﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

using Xamarin.Forms;
/*
namespace Projekt01
{
	public class NMmainpageCS : ContentPage
	{
		public NMmainpageCS ()
		{
			Content = new StackLayout {
				Children = {
					new Label { Text = "Hello Page" }
				}
			};
		}
	}
}
*/

namespace ModalNavigation
{
    public class MainPageCS : ContentPage
    {
        ListView listView;
        List<Contact> contacts;

        public MainPageCS()
        {
            SetupData();

            listView = new ListView
            {
                ItemsSource = contacts
            };
            listView.ItemSelected += OnItemSelected;

            Padding = new Thickness(0, Device.OnPlatform(40, 0, 0), 0, 0);
            Content = new StackLayout
            {
                Children = {
                    listView
                }
            };
        }

        async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (listView.SelectedItem != null)
            {
                var detailPage = new DetailPageCS();
                detailPage.BindingContext = e.SelectedItem as Contact;
                listView.SelectedItem = null;
                await Navigation.PushModalAsync(detailPage);
            }
        }

        void SetupData()
        {
            contacts = new List<Contact>();
            contacts.Add(new Contact
            {
                Name = "Jane Doe",
                Age = 30,
                Occupation = "Developer",
                Country = "USA"
            });
            contacts.Add(new Contact
            {
                Name = "John Doe",
                Age = 34,
                Occupation = "Tester",
                Country = "USA"
            });
            contacts.Add(new Contact
            {
                Name = "John Smith",
                Age = 52,
                Occupation = "PM",
                Country = "UK"
            });
            contacts.Add(new Contact
            {
                Name = "Kath Smith",
                Age = 55,
                Occupation = "Business Analyst",
                Country = "UK"
            });
            contacts.Add(new Contact
            {
                Name = "Steve Smith",
                Age = 19,
                Occupation = "Junior Developer",
                Country = "UK"
            });
        }
    }
}
