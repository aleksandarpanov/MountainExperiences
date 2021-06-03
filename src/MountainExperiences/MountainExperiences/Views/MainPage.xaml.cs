
using System;
using Xamarin.Essentials;

namespace MountainExperiences.Views
{
    public partial class MainPage
    {
        double density;
        public MainPage()
        {
            InitializeComponent();
            // Screen density
            density = DeviceDisplay.MainDisplayInfo.Density;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);
            VerticalDottedLine.Y2 = 0.65 * ParentGrid.Height;
        }
    }
}
