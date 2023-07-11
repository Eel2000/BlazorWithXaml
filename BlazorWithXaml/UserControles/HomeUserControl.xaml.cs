using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Navigation;

namespace BlazorWithXaml.UserControles
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            this.InitializeComponent();
        }

        private void TextBlock_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var source = sender as TextBlock;
            if (source != null)
            {
                source.FontSize = 15;
            }
        }

        private void TextBlock_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            var source = sender as TextBlock;
            if (source != null)
            {
                source.FontSize = 20;
            }
        }

        private void TextBlock_MouseEnter(object sender, MouseEventArgs e)
        {
            var source = sender as TextBlock;
            if (source != null)
            {
                source.Foreground = new SolidColorBrush(Colors.Gray);
            }
        }

        private void TextBlock_MouseLeave(object sender, MouseEventArgs e)
        {
            var source = sender as TextBlock;
            if (source != null)
            {
                source.Foreground = new SolidColorBrush(Colors.White);
            }
        }
    }
}
