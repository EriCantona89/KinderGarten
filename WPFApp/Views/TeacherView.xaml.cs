using System.Windows;
using System.Windows.Controls;
using EFLib.Services;
using WPFApp.Windows;

namespace WPFApp.Views;

public partial class TeacherView : UserControl
{
    private readonly ITeacherService _service;
    public TeacherView()
    {
        InitializeComponent();
        _service = new TeacherService();
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
        Window editTeacher = new EditTeacher(content.Id);
        editTeacher.Show();
    }

    private void AddTeacher_Click(object sender, RoutedEventArgs e)
    {
        Window addTeacher = new AddTeacher();
        addTeacher.Show();
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