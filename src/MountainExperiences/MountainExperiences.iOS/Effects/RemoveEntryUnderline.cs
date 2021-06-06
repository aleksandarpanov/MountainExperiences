using System;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ResolutionGroupName("XFBaseEntry.RemoveEntryUnderline")]
[assembly: ExportEffect(typeof(MountainExperiences.iOS.Effects.RemoveEntryUnderline), nameof(MountainExperiences.iOS.Effects.RemoveEntryUnderline))]
namespace MountainExperiences.iOS.Effects
{
    public class RemoveEntryUnderline : PlatformEffect
    {
        protected override void OnAttached()
        {
            var editText = this.Control as UITextField;

            if (editText is null)
            {
                throw new NotImplementedException();
            }

            editText.Layer.BorderColor = UIColor.Clear.CGColor;
            editText.Layer.BorderWidth = 0;
            editText.BorderStyle = UITextBorderStyle.None;
        }

        protected override void OnDetached()
        {
            throw new System.NotImplementedException();
        }
    }
}