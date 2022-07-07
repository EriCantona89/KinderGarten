using System.Windows;
using System.Windows.Controls;
using EFLib.Services;
using WPFApp.Windows;

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
        dynamic content = ((Button) sender).DataContext;
        Window editParent = new EditParent(content.Id);
        editParent.Show();
    }

    private void AddParent_Click(object sender, RoutedEventArgs e)
    {
        Window addParent = new AddParent();
        addParent.Show();
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