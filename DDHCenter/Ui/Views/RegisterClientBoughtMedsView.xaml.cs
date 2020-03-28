﻿using DDHCenter.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DDHCenter.Ui.Views
{
    /// <summary>
    /// Lógica de interacción para RegisterClientBoughtMedsView.xaml
    /// </summary>
    public partial class RegisterClientBoughtMedsView : UserControl
    {
        public RegisterClientBoughtMedsView()
        {
            InitializeComponent();
            this.Loaded += RegisterClientBoughtMedsView_Loaded;
        }

        void RegisterClientBoughtMedsView_Loaded(object sender, RoutedEventArgs e)
        {
            ((RegisterClientBoughtMedsViewModel)this.DataContext).GetMedicines();
        }
    }
}
