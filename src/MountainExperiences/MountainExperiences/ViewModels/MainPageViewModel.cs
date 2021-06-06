using Prism.Navigation;
using System.Threading.Tasks;
using Xamarin.CommunityToolkit.ObjectModel;

namespace MountainExperiences.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        private string searchText;

        public string SearchText 
        {
            get => searchText; 
            set
            {
                if (searchText != value)
                {
                    SetProperty(ref searchText, value);
                }
            }
        }

        private IAsyncCommand<string> goToSearchPageCommand;

        public IAsyncCommand<string> GoToSearchPageCommand
        {
            get
            {
                if (goToSearchPageCommand == null)
                {
                    goToSearchPageCommand = new AsyncCommand<string>(GoToSearchPageAsync);
                }

                return goToSearchPageCommand;
            }
        }

        private async Task GoToSearchPageAsync(string keyword)
        {
            var navigationParams = new NavigationParameters
            {
                { "keyword", keyword }
            };

            INavigationResult navigationResult = await NavigationService.NavigateAsync("SearchPage", navigationParams, useModalNavigation: false, false);

            if (!navigationResult.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
