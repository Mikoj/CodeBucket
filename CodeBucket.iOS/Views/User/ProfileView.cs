using Cirrious.MvvmCross.Binding.BindingContext;
using CodeBucket.ViewControllers;
using CodeBucket.Views;
using CodeBucket.Core.ViewModels.User;
using CodeBucket.Elements;

namespace CodeBucket.Views.User
{
	public class ProfileView : ViewModelDrivenDialogViewController
    {
		public new ProfileViewModel ViewModel
		{
			get { return (ProfileViewModel)base.ViewModel; }
			set { base.ViewModel = value; }
		}

		public ProfileView()
		{
			Root.UnevenRows = true;
		}

        public override void ViewDidLoad()
        {
            Title = "Profile";

            base.ViewDidLoad();

			var header = new HeaderView();
            var set = this.CreateBindingSet<ProfileView, ProfileViewModel>();
            set.Bind(header).For(x => x.Title).To(x => x.Username).OneWay();
			set.Bind(header).For(x => x.Subtitle).To(x => x.User.Username).OneWay();
			set.Bind(header).For(x => x.ImageUri).To(x => x.User.Avatar).OneWay();
            set.Apply();

			ViewModel.Bind(x => x.User, x =>
			{
				var followers = new StyledStringElement("Followers", () => ViewModel.GoToFollowersCommand.Execute(null), Images.Heart);
				var events = new StyledStringElement("Events", () => ViewModel.GoToEventsCommand.Execute(null), Images.Event);
                var organizations = new StyledStringElement("Groups", () => ViewModel.GoToGroupsCommand.Execute(null), Images.Group);
				var repos = new StyledStringElement("Repositories", () => ViewModel.GoToRepositoriesCommand.Execute(null), Images.Repo);
                var following = new StyledStringElement("Following", () => ViewModel.GoToFollowingCommand.Execute(null), Images.Following);
                var midSec = new Section() { events, organizations, followers, following };
				Root = new RootElement(Title) { new Section(header), midSec, new Section { repos } };
			});
//			if (!ViewModel.IsLoggedInUser)
//				NavigationItem.RightBarButtonItem = new UIBarButtonItem(UIBarButtonSystemItem.Action, (s, e) => ShowExtraMenu());
        }
//
//		private void ShowExtraMenu()
//		{
//			var sheet = MonoTouch.Utilities.GetSheet(ViewModel.Username);
//			var followButton = sheet.AddButton(ViewModel.IsFollowing ? "Unfollow" : "Follow");
//			var cancelButton = sheet.AddButton("Cancel");
//			sheet.CancelButtonIndex = cancelButton;
//			sheet.DismissWithClickedButtonIndex(cancelButton, true);
//			sheet.Clicked += (s, e) => {
//				if (e.ButtonIndex == followButton)
//				{
//					ViewModel.ToggleFollowingCommand.Execute(null);
//				}
//			};
//
//			sheet.ShowInView(this.View);
//		}
    }
}

