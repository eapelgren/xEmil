﻿using Xamarin.Forms;
using xEmilForms.Pages;
using XLabs.Forms.Mvvm;


namespace xEmilForms.ViewModel
{
    /// <summary>
	/// The MVVM sample view model.
	/// </summary>
	[ViewType(typeof(MvvmSamplePage))]
	public class MvvmSampleViewModel : XLabs.Forms.Mvvm.ViewModel
	{
		private Command _navigateToViewModel;
		private string _navigateToViewModelButtonText = "Navigate to another view model";

		/// <summary>
		/// Gets the navigate to view model.
		/// </summary>
		/// <value>
		/// The navigate to view model.
		/// </value>
		public Command NavigateToViewModel 
		{
			get
			{
				return _navigateToViewModel ?? (_navigateToViewModel = new Command(
					async () => NavigationService.NavigateTo<FacebookViewModel>(),
																		   () => true));
			}
		}

		/// <summary>
		/// Gets or sets the navigate to view model button text.
		/// </summary>
		/// <value>
		/// The navigate to view model button text.
		/// </value>
		public string NavigateToViewModelButtonText
		{
			get
			{
				return _navigateToViewModelButtonText;
			}
			set
			{ 
				this.SetProperty(ref _navigateToViewModelButtonText, value);
			}
		}
	}
}

