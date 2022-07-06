using System.Windows;
using System.Windows.Controls;
using EFLib.Services;

namespace WPFApp.Views;

public partial class ChildrenView : UserControl
{
    private readonly IChildrenService _service;
    public ChildrenView()
    {
        InitializeComponent();
        _service = new ChildrenService();
        GetAll();
    }

    private void DeleteButton_Click(object sender, RoutedEventArgs e)
    {
        dynamic entity = ((Button) sender).DataContext;
        _service.Delete(entity.Id);
        GetAll();
    }

    private void Update_Click(object sender, RoutedEventArgs e)
    {
        // TO DO Window
        throw new System.NotImplementedException();
    }

    private void AddChildren_Click(object sender, RoutedEventArgs e)
    {
        // TO DO Window
        throw new System.NotImplementedException();
    }

    private void Refresh_Click(object sender, RoutedEventArgs e)
    {
        GetAll();
    }

    public  void GetAll()
    {
        var list =  _service.GetAll();
        View.ItemsSource = list;

    }
}