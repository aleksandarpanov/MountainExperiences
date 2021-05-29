using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MountainExperiences.ViewModels
{
    public class MainPageViewModel : ViewModelBase
    {
        public MainPageViewModel(INavigationService navigationService)
            : base(navigationService)
        {
            Title = "Main Page";
        }

        private ICommand goToSearchPageCommand;

        public ICommand GoToSearchPageCommand
        {
            get
            {
                if (goToSearchPageCommand == null)
                {
                    goToSearchPageCommand = new DelegateCommand(async() => await GoToSearchPageAsync());
                }

                return goToSearchPageCommand;
            }
        }

        private async Task GoToSearchPageAsync()
        {
            INavigationResult navigationResult = await NavigationService.NavigateAsync("SearchPage", null, useModalNavigation: false, false);

            if (!navigationResult.Success)
            {
                System.Diagnostics.Debugger.Break();
            }
        }
    }
}
