using System.Windows;
using EFLib.Services;

namespace WPFApp.Windows;

public partial class AddTeacher : Window
{
    private readonly ITeacherService _service;
    public AddTeacher()
    {
        InitializeComponent();
        _service = new TeacherService();
    }

    private void AddTeacher_Button(object sender, RoutedEventArgs e)
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