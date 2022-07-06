using System;
using System.Windows;
using EFLib.Services;

namespace WPFApp.Windows;

public partial class AddPresent : Window
{
    private readonly IPresentService _service;
    public AddPresent()
    {
        InitializeComponent();
        _service = new PresentService();
    }

    private void AddPresent_Button(object sender, RoutedEventArgs e)
    {
        if (Date != null && ChildrenId != null && Presents != null )
        {
            Boolean present;
            if ((bool) Presents.IsChecked)
            {
                present = true;
            }
            else
            {
                present = false;
            }
            
            _service.Create(Date.SelectedDate.Value, Int32.Parse(ChildrenId.Text), present);
            MessageBox.Show("Added successfully!");
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid input!");
        }
    }
}