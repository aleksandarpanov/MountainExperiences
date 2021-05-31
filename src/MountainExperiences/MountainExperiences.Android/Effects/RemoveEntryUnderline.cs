using Android.Graphics;
using Android.Widget;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;

[assembly: ResolutionGroupName("XFBaseEntry.RemoveEntryUnderline")]
[assembly: ExportEffect(typeof(MountainExperiences.Droid.Effects.RemoveEntryUnderline), nameof(MountainExperiences.Droid.Effects.RemoveEntryUnderline))]

namespace MountainExperiences.Droid.Effects
{
    public class RemoveEntryUnderline : PlatformEffect
    {
        protected override void OnAttached()
        {
            var editText = this.Control as EditText;

            if (editText is null)
            {
                throw new NotImplementedException();
            }

            editText.SetBackgroundColor(Android.Graphics.Color.Transparent);
        }

        protected override void OnDetached()
        {
            throw new NotImplementedException();
        }
    }
}