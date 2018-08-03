﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Kino.Toolkit.Wpf
{
    public class KinoListBox : ListBox
    {
        protected override DependencyObject GetContainerForItemOverride()
        {
            return new KinoListBoxItem();
        }
    }
}
