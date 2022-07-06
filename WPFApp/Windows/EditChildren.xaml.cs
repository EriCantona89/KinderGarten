using System;
using System.Windows;
using EFLib.Services;

namespace WPFApp.Windows;

public partial class EditChildren : Window
{
    private readonly IChildrenService _service;
    private int id;
    public EditChildren(int id )
    {
        this.id = id;
        InitializeComponent();
        _service = new ChildrenService();
        GetInfo(id);
    }

    private void GetInfo(int id)
    {
        var entity =  _service.GetById(id);
        FirstName.Text = entity.FirstName;
        LastName.Text = entity.LastName;
        ParentId.Text = entity.ParentId.ToString();
        TeacherId.Text = entity.TeacherId.ToString();


    }
    private void EditChildren_Button(object sender, RoutedEventArgs e)
    {
        if (FirstName != null && LastName != null && ParentId != null && TeacherId != null  )
        {
            _service.Update(id, FirstName.Text, LastName.Text, Int32.Parse(ParentId.Text),Int32.Parse(TeacherId.Text));

            MessageBox.Show("Edit successfully!");
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid input!");
        }
        
    }
}