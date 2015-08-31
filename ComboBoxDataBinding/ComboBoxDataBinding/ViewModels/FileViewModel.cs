using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComboBoxDataBinding.Models;
using System.IO;
using Microsoft.Win32;
using System.Collections.ObjectModel;


namespace ComboBoxDataBinding.ViewModels
{
    class FileViewModel : ViewModel
    {
         public static RelayCommand OpenCommand { get; set; }
         private string _selectedPath;
         public string SelectedPath{
             get { return _selectedPath; }
             set {
                _selectedPath = value;
                NotifyPropertyChanged("SelectedPath");
            }
        }

        private string _defaultPath;

        public FileViewModel() {        
            OpenCommand = new RelayCommand(ExecuteOpenFileDialog);
        }

        public FileViewModel(string defaultPath) {
            _defaultPath = defaultPath;
            OpenCommand = new RelayCommand(ExecuteOpenFileDialog);       
        } 
         private void ExecuteOpenFileDialog(){
            var dialog = new OpenFileDialog { InitialDirectory = _defaultPath };
            dialog.ShowDialog();
            SelectedPath = dialog.FileName;    
        
        }
    }
}
