using System.Windows;
using System.Windows.Controls;

namespace Source;

public partial class TextBoxPlaceHolderUC : UserControl
{
    public TextBoxPlaceHolderUC()
    {
        InitializeComponent();
    }


    public string PlaceHolderText
    {
        get { return (string)GetValue(PlaceHolderTextProperty); }
        set { SetValue(PlaceHolderTextProperty, value); }
    }

    public static readonly DependencyProperty PlaceHolderTextProperty =
        DependencyProperty.Register("PlaceHolderText", typeof(string), typeof(TextBoxPlaceHolderUC));




    public string Text
    {
        get { return (string)GetValue(TextProperty); }
        set { SetValue(TextProperty, value); }
    }

    public static readonly DependencyProperty TextProperty =
        DependencyProperty.Register("Text", typeof(string), typeof(TextBoxPlaceHolderUC));





    public bool AcceptsReturn
    {
        get { return (bool)GetValue(AcceptsReturnProperty); }
        set { SetValue(AcceptsReturnProperty, value); }
    }

    public static readonly DependencyProperty AcceptsReturnProperty =
        DependencyProperty.Register("AcceptsReturn", typeof(bool), typeof(TextBoxPlaceHolderUC));



    public event TextChangedEventHandler TextChangedUC;

    private void textBox_TextChanged(object sender, TextChangedEventArgs e)
    {
        TextChangedUC?.Invoke(this, e);
    }
}