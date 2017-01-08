using Xamarin.Forms;

namespace MyFirstFormsApp
{
	public partial class MyFirstFormsAppPage : ContentPage
	{
		#region Private properties 

		int tapCount;

		#endregion

		#region Init

		public MyFirstFormsAppPage()
		{
			InitializeComponent();
			UpdateControls();
		}

		#endregion

		#region Event handler

		void IncrementButton_Clicked(object sender, System.EventArgs e)
		{
			tapCount++;
			UpdateControls();
		}

		void DecrementButton_Clicked(object sender, System.EventArgs e)
		{
			tapCount--;
			UpdateControls();
		}

		#endregion

		#region Private helper 

		private void UpdateControls()
		{
			if (tapCount == 1)
			{
				tapLabel.Text = $"You tapped {tapCount} time.";
			}
			else
			{
				tapLabel.Text = $"You tapped {tapCount} times.";
			}

			decrementButton.IsEnabled = tapCount > 0;
		}
			
		#endregion
	}
}
