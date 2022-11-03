using System.Windows;
using System.Windows.Controls;

namespace Source;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    private void TextBoxPlaceHolderUC_TextChangedUC(object sender, TextChangedEventArgs e)
    {
        var control = sender as TextBoxPlaceHolderUC;

        MessageBox.Show(control?.Text);
    }
}
