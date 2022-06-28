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

namespace BasicTrader.WPF.Controls
{
    /// <summary>
    /// Interaction logic for IndexCard.xaml
    /// </summary>
    public partial class IndexCard : UserControl
    {
       // public Brush SetChangeTextForegroundColor { get; set; }
        public IndexCard()
        {
            InitializeComponent();
            //DataContext = this;

            //SetChangeTextForegroundColor = SetChangeTextColor();
        }

        public Brush SetChangeTextColor()
        {
            if (!string.IsNullOrEmpty(Change.Text) && decimal.Parse(Change.Text) < 0)
            {
                return new SolidColorBrush(Colors.Red);
            }
            else
            {
                return new SolidColorBrush((Color)ColorConverter.ConvertFromString("#296d52"));
            }
        }
    }
}
