﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;
using System.Windows.Media.Imaging;


namespace DraggableApp.Converters
{
    [ValueConversion(typeof(IList<Point>), typeof(PathSegmentCollection))]
    public class ConnectionPathConverter : IValueConverter
    {
        static ConnectionPathConverter()
        {
            Instance = new ConnectionPathConverter();
        }

        public static ConnectionPathConverter Instance
        {
            get;
            private set;
        }

        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            IList<Point> points = (IList<Point>)value;
            PointCollection pointCollection = new PointCollection();
            foreach (Point point in points)
            {
                pointCollection.Add(point);
            }
            return pointCollection;
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
