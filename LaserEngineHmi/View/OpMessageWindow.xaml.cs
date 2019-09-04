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
using System.Windows.Shapes;
using GalaSoft.MvvmLight.Messaging;
using GalaSoft.MvvmLight.Ioc;
using DataCenter.Model;
using LaserEngineHmi.ViewModel;

namespace LaserEngineHmi.View
{
    /// <summary>
    /// OpMessageWindow.xaml 的交互逻辑
    /// </summary>
    public partial class OpMessageWindow : Window
    {
        public OpMessageWindow()
        {
            InitializeComponent();
            this.DataContext = SimpleIoc.Default.GetInstance<OpMessageViewModel>();
        }
    }
}
