using System;
using System.Windows;
using EFLib.Services;

namespace WPFApp.Windows;

public partial class AddChildren : Window
{
    private readonly IChildrenService _service;
    public AddChildren()
    {
        InitializeComponent();
        _service = new ChildrenService();
    }


    private void AddChildren_Button(object sender, RoutedEventArgs e)
    {
        if (FirstName != null && LastName != null && ParentId != null && TeacherId != null)
        {
            _service.Create(FirstName.Text, LastName.Text, Int32.Parse(ParentId.Text), Int32.Parse(TeacherId.Text));
            MessageBox.Show("Added succesfully!");
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid input!");
        }
    }
}