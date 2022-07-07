using System.Windows;
using System.Windows.Controls;
using EFLib.Services;
using WPFApp.Windows;

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
        dynamic content = ((Button) sender).DataContext;
        Window editChildren = new EditChildren(content.Id);
        editChildren.Show();
    }

    private void AddChildren_Click(object sender, RoutedEventArgs e)
    {
        Window addChildren = new AddChildren();
        addChildren.Show();
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