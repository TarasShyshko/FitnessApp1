using FitnessApp1.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace FitnessApp1
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(CollectionDetailPage), typeof(CollectionDetailPage));
        }

    }
}
