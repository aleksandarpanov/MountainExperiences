using Prism.Commands;
using Prism.Navigation;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MountainExperiences.ViewModels
{
    public class SearchPageViewModel : ViewModelBase
    {
        public SearchPageViewModel(INavigationService navigationService)
            :base(navigationService)
        {

        }

        private ICommand goBackCommand;

        public ICommand GoBackCommand
        {
            get
            {
                if (goBackCommand == null)
                {
                    goBackCommand = new DelegateCommand(async () => await GoBackAsync());
                }

                return goBackCommand;
            }
        }

        private async Task GoBackAsync()
        {
            INavigationResult navigationResult = await NavigationService.GoBackAsync();

            if (!navigationResult.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
