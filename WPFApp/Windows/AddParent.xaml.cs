using System.Windows;
using EFLib.Services;

namespace WPFApp.Windows;

public partial class AddParent : Window
{
    private readonly IParentService _service;
    public AddParent()
    {
        InitializeComponent();
        _service = new ParentService();
    }

    private void AddParent_Button(object sender, RoutedEventArgs e)
    {
        if (FirstName != null && LastName != null )
        {
            _service.Create(FirstName.Text, LastName.Text);
            MessageBox.Show("Added successfully!");
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid input!");
        }
    }
}