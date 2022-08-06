namespace Awesome.Maui.Controls;

public partial class CircularFontIcon : Grid
{
    public CircularFontIcon()
    {
        InitializeComponent();

        //Init
        Circle.Fill = new SolidColorBrush(CircleBackgroundColor);
        Circle.Stroke = new SolidColorBrush(CircleBorderColor);
        Circle.StrokeThickness = CircleBorderThickness;
        CircleGeometry.Center = new Point(CircleRadius, CircleRadius);
        CircleGeometry.RadiusX = CircleRadius;
        CircleGeometry.RadiusY = CircleRadius;
        Icon.TextColor = CircleForegroundColor;
        Icon.FontFamily = CircleFontFamily;
        Icon.FontSize = CircleFontSize;
        Icon.Text = CircleText;
    }

    public static readonly BindableProperty CircleBackgroundColorProperty = BindableProperty.Create(nameof(CircleBackgroundColor), typeof(Color), typeof(CircularFontIcon), Colors.White, BindingMode.TwoWay);
    public static readonly BindableProperty CircleForegroundColorProperty = BindableProperty.Create(nameof(CircleForegroundColor), typeof(Color), typeof(CircularFontIcon), Colors.Black, BindingMode.TwoWay);
    public static readonly BindableProperty CircleBorderColorProperty = BindableProperty.Create(nameof(CircleBorderColor), typeof(Color), typeof(CircularFontIcon), Colors.Black, BindingMode.TwoWay);
    public static readonly BindableProperty CircleBorderThicknessProperty = BindableProperty.Create(nameof(CircleBorderThickness), typeof(double), typeof(CircularFontIcon), 5.0, BindingMode.TwoWay);
    public static readonly BindableProperty CircleRadiusProperty = BindableProperty.Create(nameof(CircleRadius), typeof(double), typeof(CircularFontIcon), 12.0, BindingMode.TwoWay);
    public static readonly BindableProperty CircleFontFamilyProperty = BindableProperty.Create(nameof(CircleFontFamily), typeof(string), typeof(CircularFontIcon), default(string), BindingMode.TwoWay);
    public static readonly BindableProperty CircleFontSizeProperty = BindableProperty.Create(nameof(CircleFontSize), typeof(double), typeof(CircularFontIcon), 20.0, BindingMode.TwoWay);
    public static readonly BindableProperty CircleTextProperty = BindableProperty.Create(nameof(CircleText), typeof(string), typeof(CircularFontIcon), default(string), BindingMode.TwoWay);

    public Color CircleBackgroundColor
    {
        get
        {
            return (Color)GetValue(CircleBackgroundColorProperty);
        }

        set
        {
            SetValue(CircleBackgroundColorProperty, value);
        }
    }

    public Color CircleForegroundColor
    {
        get
        {
            return (Color)GetValue(CircleForegroundColorProperty);
        }

        set
        {
            SetValue(CircleForegroundColorProperty, value);
        }
    }

    public Color CircleBorderColor
    {
        get
        {
            return (Color)GetValue(CircleBorderColorProperty);
        }

        set
        {
            SetValue(CircleBorderColorProperty, value);
        }
    }

    public double CircleBorderThickness
    {
        get
        {
            return (double)GetValue(CircleBorderThicknessProperty);
        }

        set
        {
            SetValue(CircleBorderThicknessProperty, value);
        }
    }

    public double CircleRadius
    {
        get
        {
            return (double)GetValue(CircleRadiusProperty);
        }

        set
        {
            SetValue(CircleRadiusProperty, value);
        }
    }

    public string CircleFontFamily
    {
        get
        {
            return (string)GetValue(CircleFontFamilyProperty);
        }

        set
        {
            SetValue(CircleFontFamilyProperty, value);
        }
    }

    public double CircleFontSize
    {
        get
        {
            return (double)GetValue(CircleFontSizeProperty);
        }

        set
        {
            SetValue(CircleFontSizeProperty, value);
        }
    }

    public string CircleText
    {
        get
        {
            return (string)GetValue(CircleTextProperty);
        }

        set
        {
            SetValue(CircleTextProperty, value);
        }
    }

    protected override void OnPropertyChanged(string propertyName)
    {
        base.OnPropertyChanged(propertyName);

        if (propertyName == CircleBackgroundColorProperty.PropertyName)
        {
            Circle.Fill = new SolidColorBrush(CircleBackgroundColor);
        }
        else if (propertyName == CircleBorderColorProperty.PropertyName)
        {
            Circle.Stroke = new SolidColorBrush(CircleBorderColor);
        }
        else if (propertyName == CircleBorderThicknessProperty.PropertyName)
        {
            Circle.StrokeThickness = CircleBorderThickness;
        }
        else if (propertyName == CircleRadiusProperty.PropertyName)
        {
            CircleGeometry.Center = new Point(CircleRadius, CircleRadius);
            CircleGeometry.RadiusX = CircleRadius;
            CircleGeometry.RadiusY = CircleRadius;
        }
        else if (propertyName == CircleForegroundColorProperty.PropertyName)
        {
            Icon.TextColor = CircleForegroundColor;
        }
        else if (propertyName == CircleFontFamilyProperty.PropertyName)
        {
            Icon.FontFamily = CircleFontFamily;
        }
        else if (propertyName == CircleFontSizeProperty.PropertyName)
        {
            Icon.FontSize = CircleFontSize;
        }
        else if (propertyName == CircleTextProperty.PropertyName)
        {
            Icon.Text = CircleText;
        }
    }
}