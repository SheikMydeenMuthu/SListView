using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SListView.CustomViews
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListTemplate : Grid
    {
        public ListTemplate()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty UserImageProperty = BindableProperty.Create(
            propertyName: nameof(UserImage),
            returnType: typeof(Image),
            declaringType: typeof(ListTemplate),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: null,
            propertyChanged: OnUserImagePropertyChanged);

        public static readonly BindableProperty TitleValueProperty = BindableProperty.Create(
            propertyName: nameof(TitleValue),
            returnType: typeof(string),
            declaringType: typeof(ListTemplate),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: string.Empty,
            propertyChanged: OnTiltePropertyChanged);

        public static readonly BindableProperty SubTitleValueProperty = BindableProperty.Create(
            propertyName: nameof(SubTitleValue),
            returnType: typeof(string),
            declaringType: typeof(ListTemplate),
            defaultBindingMode: BindingMode.TwoWay,
            defaultValue: string.Empty,
            propertyChanged: OnSubTiltePropertyChanged);

        private static void OnTiltePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var listTemplate = (bindable as ListTemplate);
            listTemplate.Title.Text = newValue.ToString();
        }

        private static void OnSubTiltePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var listTemplate = (bindable as ListTemplate);
            listTemplate.SubTitle.Text = newValue.ToString();
        }

        private static void OnUserImagePropertyChanged(BindableObject bindable, object oldValue, object newValue)
        {
            var listTemplate = (bindable as ListTemplate);
            listTemplate.ImgIcon.Source = newValue.ToString();
        }


        public Image UserImage
        {
            get { return (Image)GetValue(UserImageProperty); }
            set { SetValue(UserImageProperty, value); }
        }

        public string TitleValue
        {
            get { return (string)GetValue(TitleValueProperty); }
            set { SetValue(TitleValueProperty, value); }
        }

        public string SubTitleValue
        {
            get { return (string)GetValue(SubTitleValueProperty); }
            set { SetValue(SubTitleValueProperty, value); }
        }

    }
}