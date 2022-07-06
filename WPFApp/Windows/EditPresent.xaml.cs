using System;
using System.Windows;
using EFLib.Services;

namespace WPFApp.Windows;

public partial class EditPresent : Window
{
    private readonly IPresentService _service;
    private int id;
    public EditPresent(int id )
    {
        this.id = id;
        InitializeComponent();
        _service = new PresentService();
        GetInfo(id);
    }
    
    
    private void GetInfo(int id)
    {
        var entity = _service.GetById(id);
        Date.Text = entity.Date.ToString();
        ChildrenId.Text = entity.ChildrenId.ToString();
        if (entity.Presents == true)
        {
            Presents.IsChecked = true;
        }
        else
        {
            Presents.IsChecked = false;
        }
    }
    private void EditChildren_Button(object sender, RoutedEventArgs e)
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
            _service.Update(id,Date.SelectedDate.Value, Int32.Parse(ChildrenId.Text), present);
            MessageBox.Show("Edit successfully!");
            this.Close();
        }
        else
        {
            MessageBox.Show("Invalid input!");
        }
        
    }
}