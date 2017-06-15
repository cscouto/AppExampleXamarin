using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace AndroidExample
{
    [Activity(Label = "AndroidExample", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            //Define o conteudo da view
            SetContentView(Resource.Layout.Main);

            // cria um botao
            Button button = FindViewById<Button>(Resource.Id.MyButton);

            //coloca um evento no click
            button.Click += delegate { button.Text = string.Format("{0} clicks!", count++); };
        }
    }
}

