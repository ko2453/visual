using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using ComboBoxDataBinding.Models;
using System.Windows.Controls;
using ComboBoxDataBinding.Data;

namespace ComboBoxDataBinding.ViewModels
{
    public class MainWindowViewModel : ViewModel
    {

        readonly FontRepository _fontRepository;
        public ObservableCollection<FontSize> FontSizes { get;  set; }

        public ObservableCollection<FontFamily> FontFamilies { get; set; }


        public MainWindowViewModel()
        {
            _fontRepository = new FontRepository();
           this.FontSizes = new ObservableCollection<FontSize>(_fontRepository.getsize());
            this.FontFamilies = new ObservableCollection<FontFamily>(_fontRepository.getfamily()); 
        }

        protected override void OnDispose()
        {
            this.FontSizes.Clear();
        }
        

        
    }
}
