﻿using System;
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

namespace SpeckleNavisworks.Views
{
    /// <summary>
    /// Interaktionslogik für CreateNewStream.xaml
    /// </summary>
    public partial class CreateNewStream : Window
    {
        public CreateNewStream(ViewModels.Base viewModel)
        {
            InitializeComponent();

            DataContext = viewModel;
        }
    }
}