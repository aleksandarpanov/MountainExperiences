
using Xamarin.Forms;

namespace MountainExperiences.Controls
{
    public partial class SupportControl : ContentView
    {
        Brush brush;
        public SupportControl()
        {
            InitializeComponent();
            brush = new SolidColorBrush();
        }

        #region MyProperty

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(TextProperty), typeof(string), typeof(SupportControl), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as SupportControl;
            if (newV != null && !(newV is string)) return;
            var oldTextProperty = (string)old;
            var newTextProperty = (string)newV;
            me?.MyTextPropertyChanged(oldTextProperty, newTextProperty);
        });

        private void MyTextPropertyChanged(string oldText, string newText)
        {
            SupportText.Text = newText;
        }

        /// <summary>
        /// A bindable property
        /// </summary>
        public string Text
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }

        public static readonly BindableProperty ImageSourceProperty = BindableProperty.Create(nameof(ImageSourceProperty), typeof(ImageSource), typeof(SupportControl), propertyChanged: (obj, old, newV) => {
            var me = obj as SupportControl;
            if (newV != null && !(newV is ImageSource)) return;
            var oldImageSource = (ImageSource)old;
            var newImageSource = (ImageSource)newV;

            me?.MyImagePropertyChanged(oldImageSource, newImageSource);
        });

        public ImageSource ImageSource
        {
            get => (ImageSource)GetValue(ImageSourceProperty);
            set => SetValue(ImageSourceProperty, value);
        }

        private void MyImagePropertyChanged(ImageSource oldImageSource, ImageSource newImageSource)
        {
            SupportImage.Source = newImageSource;
        }

        public static readonly BindableProperty StatusColorProperty = BindableProperty.Create(nameof(StatusColorProperty), typeof(Color), typeof(SupportControl), propertyChanged: (obj, old, newV) =>
        {
            var me = obj as SupportControl;
            if (newV != null && !(newV is Color)) return;
            var oldColor = (Color)old;
            var newColor = (Color)newV;
            me?.MyStatusColorChanged(oldColor, newColor);
        });

        private void MyStatusColorChanged(Color oldColor, Color newColor)
        {
            brush = new SolidColorBrush(newColor);
            SupportStatusColor.Fill = brush;
        }

        /// <summary>
        /// A bindable property
        /// </summary>
        public Color StatusColor
        {
            get => (Color)GetValue(StatusColorProperty);
            set => SetValue(StatusColorProperty, value);
        }

        #endregion
    }
}