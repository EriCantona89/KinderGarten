using System.Windows;
using EFLib.Services;

namespace WPFApp.Windows;

public partial class EditParent : Window
{
    private readonly IParentService _service;
    private int id;
    public EditParent(int id )
    {
        this.id = id;
        InitializeComponent();
        _service = new ParentService();
        GetInfo(id);
    }

    private void GetInfo(int id)
    {
        var entity =  _service.GetById(id);
        FirstName.Text = entity.FirstName;
        LastName.Text = entity.LastName;


    }
    private void EditChildren_Button(object sender, RoutedEventArgs e)
    {
        if (FirstName != null && LastName != null  )
        {
            _service.Update(id, FirstName.Text, LastName.Text);

            MessageBox.Show("Edit successfully!");
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid input!");
        }
    }
}