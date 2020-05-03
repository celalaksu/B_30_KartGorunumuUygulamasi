using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KartGorunumuUygulamasi.OzelKontroller
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class KartGorunumu : ContentView
    {
        public KartGorunumu()
        {
            InitializeComponent();
        }

        public static readonly BindableProperty KartBaslikOzelligi = BindableProperty.Create(
            "KartBaslik",       
            typeof(string),     
            typeof(KartGorunumu),   
            string.Empty);      

        public static readonly BindableProperty KartAciklamaOzelligi = BindableProperty.Create(
            nameof(KartAciklama), typeof(string), typeof(KartGorunumu), string.Empty);
        public static readonly BindableProperty KenarRengiOzelligi = BindableProperty.Create(
            nameof(KenarRengi), typeof(Color), typeof(KartGorunumu), Color.DarkGray);
        public static readonly BindableProperty KartRengiOzelligi = BindableProperty.Create(
            nameof(KartRengi), typeof(Color), typeof(KartGorunumu), Color.White);
        public static readonly BindableProperty IconResimKaynagiOzelligi = BindableProperty.Create(
            nameof(IconResimKaynagi), typeof(ImageSource), typeof(KartGorunumu), default(ImageSource));
        public static readonly BindableProperty IconArkaplanRengiOzellgi = BindableProperty.Create(
            nameof(IconArkaplanRengi), typeof(Color), typeof(KartGorunumu), Color.LightGray);


        public string KartBaslik
        {
            get => (string)GetValue(KartGorunumu.KartBaslikOzelligi);
            set => SetValue(KartGorunumu.KartBaslikOzelligi, value);
        }

        public string KartAciklama
        {
            get => (string)GetValue(KartGorunumu.KartAciklamaOzelligi);
            set => SetValue(KartGorunumu.KartAciklamaOzelligi, value);
        }

        public Color KenarRengi
        {
            get => (Color)GetValue(KartGorunumu.KenarRengiOzelligi);
            set => SetValue(KartGorunumu.KenarRengiOzelligi, value);
        }

        public Color KartRengi
        {
            get => (Color)GetValue(KartGorunumu.KartRengiOzelligi);
            set => SetValue(KartGorunumu.KartRengiOzelligi, value);
        }

        public ImageSource IconResimKaynagi
        {
            get => (ImageSource)GetValue(KartGorunumu.IconResimKaynagiOzelligi);
            set => SetValue(KartGorunumu.IconResimKaynagiOzelligi, value);
        }

        public Color IconArkaplanRengi
        {
            get => (Color)GetValue(KartGorunumu.IconArkaplanRengiOzellgi);
            set => SetValue(KartGorunumu.IconArkaplanRengiOzellgi, value);
        }
    }
}