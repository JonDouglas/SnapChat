using System;
using System.Collections.ObjectModel;
using SnapChat.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SnapChat
{
	public partial class SnapChatPage : ContentPage
	{

		private ObservableCollection<Email> _emails = new ObservableCollection<Email>()
			{
				new Email(){ Icon= new Uri("https://i.annihil.us/u/prod/marvel/i/mg/3/50/537ba56d31087.jpg"), Subject = "RE: The Rolling Stones...", Name="Captain America", Body = "This Mick Jagger guy is pretty good...", Date = "1:09 PM", EmailCount = 1 },
                new Email(){ Icon= new Uri("https://i.annihil.us/u/prod/marvel/i/mg/9/c0/527bb7b37ff55.jpg"), Subject = "FW: Donation from Stark...", Name="Tony (Iron Man)", Body = "I don't need this old thing anymore...", Date = "2:13 PM", EmailCount = 5 },
                new Email(){ Icon= new Uri("https://i.annihil.us/u/prod/marvel/i/mg/5/a0/538615ca33ab0.jpg"), Subject = "Calming YouTube...", Name="Dr. Banner", Body = "Figured I'd share these calming videos...", Date = "3:33 PM", EmailCount = 2 },
                new Email(){ Icon= new Uri("https://i.annihil.us/u/prod/marvel/i/mg/d/d0/5269657a74350.jpg"), Subject = "By Odin's Beard!...", Name="Thor", Body = "I'll have another!...", Date = "3:55 PM", EmailCount = 6 },
                new Email(){ Icon= new Uri("https://i.annihil.us/u/prod/marvel/i/mg/3/10/526033c8b474a.jpg"), Subject = "I am Groot...", Name="Groot", Body = "I am Groot...Groot...", Date = "4:10 PM", EmailCount = 125 },
                new Email(){ Icon= new Uri("https://i.annihil.us/u/prod/marvel/i/mg/6/60/5261a80a67e7d.jpg"), Subject = "For the fate of Wakanda...", Name="King T'Challa", Body = "You are a good man with a good heart, and it is...", Date = "5:30 PM", EmailCount = 4 },
                new Email(){ Icon= new Uri("https://i.annihil.us/u/prod/marvel/i/mg/9/a0/537bc55e8b1f5.jpg"), Subject = "Hooked on a feeling...", Name="Star-Lord", Body = "I just updated my Zune software and...", Date = "6:20 PM", EmailCount = 7 },
                new Email(){ Icon= new Uri("https://i.annihil.us/u/prod/marvel/i/mg/3/50/526548a343e4b.jpg"), Subject = "Lost my job recently, any...", Name="Peter Parker", Body = "Do you have any leads for jobs...", Date = "1:13 AM", EmailCount = 11 },
            };

		public ObservableCollection<Email> Emails
		{
			get { return _emails; }
			set
			{
				_emails = value;
				OnPropertyChanged("Emails");
			}
		}

		public SnapChatPage()
		{
			InitializeComponent();
			BindingContext = this;
		}

		private async void Button_Clicked(object sender, EventArgs e)
		{
            await DisplayAlert("Thanos", "You should have gone for the head.", "SNAP!");
            Thanos.IsVisible = true;
            await Thanos.RotateTo(360, 1000, Easing.CubicInOut);
            for (int i = 0; i < 4; i++)
            {
                Emails.RemoveAt(Emails.Count - 1);
            }
            Thanos.IsVisible = false;
        }
    }
}
