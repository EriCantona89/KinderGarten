using System.Windows;
using System.Windows.Controls;
using EFLib.Services;

namespace WPFApp.Views;

public partial class ParentView : UserControl
{
    private readonly IParentService _service;
    public ParentView()
    {
        InitializeComponent();
        _service = new ParentService();
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

    private void AddParent_Click(object sender, RoutedEventArgs e)
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