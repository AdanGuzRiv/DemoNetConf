using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace DemoNetConf.CV
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EntryView : ContentView
    {
        public EntryView()
        {
            InitializeComponent();
            entryControl.TextChanged += async (s, e) =>
            {
                if (!string.IsNullOrEmpty(entryControl.Text))
                {
                    TextEntryControl = entryControl.Text;
                    await etiquetainfo.FadeTo(1, 250, Easing.SinOut);
                    StartAnimation();
                }
                else
                    HiddenLabel();
            };
        }

        private async void HiddenLabel()
        {
            await etiquetainfo.FadeTo(0, 250, Easing.SinIn);
        }
        private async void StartAnimation()
        {
            await border.ScaleTo(1.1, 250, Easing.CubicIn);
            await border.ScaleTo(1, 250, Easing.CubicOut);
        }
        public ImageSource IconEntryControl
        {
            get => iconEntry.Source;
            set => iconEntry.Source = value;
        }
        public Color TextEntryColorControl
        {
            get => entryControl.TextColor;
            set => entryControl.TextColor = value;
        }
        public Color PlaceHolderColorControl
        {
            get => entryControl.PlaceholderColor;
            set => entryControl.PlaceholderColor = value;
        }

        public string PlaceHolderTextControl
        {
            get => entryControl.Placeholder;
            set 
            { 
                entryControl.Placeholder = value;
                etiquetainfo.Text = value;
            }
        }
        public bool IsPasswordEntry
        {
            get => entryControl.IsPassword;
            set => entryControl.IsPassword = value;
        }

        public static readonly BindableProperty TextProperty = BindableProperty.Create(nameof(TextEntryControl), typeof(string), typeof(EntryView), defaultValue: string.Empty,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var elementView = (EntryView)bindable;
                elementView.entryControl.Text = (string)newValue;
            });
        public string TextEntryControl
        {
            get => (string)GetValue(TextProperty);
            set => SetValue(TextProperty, value);
        }
        public static readonly BindableProperty TextErrorProperty = BindableProperty.Create(nameof(TextError), typeof(string), typeof(EntryView), defaultValue: string.Empty,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var elementView = (EntryView)bindable;
                elementView.etiquetaError.Text = (string)newValue;
            });
        public string TextError
        {
            get => (string)GetValue(TextErrorProperty);
            set => SetValue(TextErrorProperty, value);
        }
        public static readonly BindableProperty ShowErrorProperty = BindableProperty.Create(nameof(ShowError), typeof(bool), typeof(EntryView), defaultValue: false,
            propertyChanged: (bindable, oldValue, newValue) =>
            {
                var elementView = (EntryView)bindable;
                elementView.etiquetaError.IsVisible = (bool)newValue;
            });
        public bool ShowError
        {
            get => (bool)GetValue(ShowErrorProperty);
            set => SetValue(ShowErrorProperty, value);
        }

        public int LenghtEntry
        {
            get => entryControl.Text.Length;
        }
    }
}