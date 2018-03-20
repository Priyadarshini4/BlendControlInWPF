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

namespace ControlExample
{
    /// <summary>
    /// Interaction logic for ProgressCircle.xaml
    /// </summary>
    public partial class ProgressCircle : UserControl
    {
        
        public static readonly DependencyProperty IndicatorBrushProperty = DependencyProperty.Register("indicatorBrush", typeof(Brush), typeof(ProgressCircle));
        public Brush indicatorBrush
        {
            get { return (Brush)this.GetValue(IndicatorBrushProperty); }
            set { this.SetValue(IndicatorBrushProperty, value); }
        }

        public static readonly DependencyProperty BorderBrushProperty = DependencyProperty.Register("borderBrush", typeof(Brush), typeof(ProgressCircle));
        public Brush borderBrush
        {
            get { return (Brush)this.GetValue(BorderBrushProperty); }
            set { this.SetValue(IndicatorBrushProperty, value); }
        }

        public static readonly DependencyProperty ProgressBackgroundBrush = DependencyProperty.Register("progressBackgroudBrush", typeof(Brush), typeof(ProgressCircle));
        public Brush progressBackgroudBrush
        {
            get { return (Brush)this.GetValue(BorderBrushProperty); }
            set { this.SetValue(ProgressBackgroundBrush, value); }
        }

        public static readonly DependencyProperty ValueProperty = DependencyProperty.Register("value", typeof(int), typeof(ProgressCircle));
        public int value
        {
            get { return (int)this.GetValue(ValueProperty); }
            set { this.SetValue(ValueProperty, value); }
        }
        public ProgressCircle()
        {
            InitializeComponent();
        }

        [ValueConversion(typeof (int),typeof(double)) ]
        public class ValueToAngelConverter : IValueConverter
        {
            public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                return (double)((int)value * 0.01) * 360;
            }

            public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
            {
                return (int)((double)value / 360) * 100;
            }
        }


    }
}
