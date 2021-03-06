using MVVM.Command;
using MVVM.Models;
using MVVM.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace MVVM.ViewModels
{
    class EditViewModel
    {
        public Car Car { get; set; }
        public RelayCommand CloseCommand { get; set; }
        public EditView EditView { get; set; }

        public EditViewModel()
        {
            var editView = new EditView();
            CloseCommand = new RelayCommand(a =>
            {
                foreach (Window window in Application.Current.Windows)
                {
                    if (window.Title == "EditView") window.Close();
                }
            }, p => true);
        }
    }
}
