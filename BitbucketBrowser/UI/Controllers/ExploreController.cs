using System;
using MonoTouch.Dialog;
using MonoTouch.UIKit;
using MonoTouch.Foundation;
using System.Threading;
using System.Linq;
using System.Collections.Generic;
using RedPlum;
using System.Drawing;

namespace BitbucketBrowser.UI
{
    public class ExploreController : DialogViewController
    {

        public ExploreController()
            : base(UITableViewStyle.Plain, new RootElement("Explore"), false)
        {
            EnableSearch = true;
            AutoHideSearch = false;
            NavigationItem.BackBarButtonItem = new UIBarButtonItem("Back", UIBarButtonItemStyle.Plain, null);
            this.SearchPlaceholder = "Search Repositories";
        }

        void ShowSearch(bool value)
        {
            if (!value)
            {
                if (TableView.ContentOffset.Y < 44)
                    TableView.ContentOffset = new PointF (0, 44);
            }
            else
            {
                TableView.ContentOffset = new PointF (0, 0);
            }
        }

        class ExploreSearchDelegate : UISearchBarDelegate 
        {
            ExploreController container;

            public ExploreSearchDelegate (ExploreController container)
            {
                this.container = container;
            }

            public override void OnEditingStarted (UISearchBar searchBar)
            {
                searchBar.ShowsCancelButton = true;
                container.StartSearch ();
                container.ShowSearch(true);
                container.NavigationController.SetNavigationBarHidden(true, true);
            }

            public override void OnEditingStopped (UISearchBar searchBar)
            {
                searchBar.ShowsCancelButton = false;
                container.FinishSearch ();
                container.NavigationController.SetNavigationBarHidden(false, true);
            }

            public override void TextChanged (UISearchBar searchBar, string searchText)
            {
            }

            public override void CancelButtonClicked (UISearchBar searchBar)
            {
                searchBar.ShowsCancelButton = false;
                container.FinishSearch ();
                searchBar.ResignFirstResponder ();
                container.NavigationController.SetNavigationBarHidden(false, true);
            }

            public override void SearchButtonClicked (UISearchBar searchBar)
            {
                container.SearchButtonClicked (searchBar.Text);
                container.NavigationController.SetNavigationBarHidden(false, true);
            }
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            var search = (UISearchBar)this.TableView.TableHeaderView;

            search.Delegate = new ExploreSearchDelegate(this);
        }

        public override void SearchButtonClicked(string text)
        {
            this.View.EndEditing(true);


            MBProgressHUD hud = null;
            hud = new MBProgressHUD(this.View.Superview); 
            hud.Mode = MBProgressHUDMode.Indeterminate;
            hud.TitleText = "Searching...";

            InvokeOnMainThread(delegate {
                Root.Clear();
                this.View.Superview.AddSubview(hud);
                hud.Show(true);
            });

            ThreadPool.QueueUserWorkItem(delegate {
                var l = Application.Client.Repositories.Search(text);
                var elements = new List<Element>(l.Repositories.Count);
                l.Repositories.ForEach(r => 
                {
                    var el = new StyledStringElement(r.Name, r.Description, UITableViewCellStyle.Subtitle)
                    { Accessory = UITableViewCellAccessory.DisclosureIndicator, Lines = 1, LineBreakMode = UILineBreakMode.TailTruncation };
                    el.Tapped += () => NavigationController.PushViewController(new RepositoryInfoController(r), true);
                    elements.Add(el);
                });


                InvokeOnMainThread(delegate {
                    Root.Clear();
                    Root.Add(new Section() { Elements = elements });
                    if (hud != null)
                    {
                        hud.Hide(true);
                        hud.RemoveFromSuperview();
                    }

                    ShowSearch(elements.Count == 0);
                });

               
            });
        }
    }
}
