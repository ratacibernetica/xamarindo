﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace AwesomeApp
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            MyWebView.Source = new UrlWebViewSource { Url = "https://untrusted-root.badssl.com/" };
        }
    }
}

