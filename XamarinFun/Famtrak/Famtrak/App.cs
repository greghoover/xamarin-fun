using Xamarin.Forms;
using Xamarin.Forms.Maps;

namespace Famtrak
{
	public class App : Application
	{
		public App()
		{
			//The root page of your application
			//MainPage = new ContentPage
			//{
			//	Content = new StackLayout
			//	{
			//		VerticalOptions = LayoutOptions.Center,
			//		Children = {
			//			//new Map(new MapSpan(new Position(0, 0), 28.533,81.3792)), // new MapSpan(new Position(10, 10), 28.533,81.3792)
			//			 new Label {
			//				 HorizontalTextAlignment = TextAlignment.Center,
			//				 Text = "Welcome to Xamarin Forms!"
			//			 }
			//		 }
			//	}
			//};
			MainPage = new MapPage();
		}

		protected override void OnStart()
		{
			// Handle when your app starts
		}

		protected override void OnSleep()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume()
		{
			// Handle when your app resumes
		}
	}
}
