using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComboBoxDataBinding.Models
{
    public class FontFamily
    {
        public string Font { get; set; }        

        public static FontFamily CreateFontFamily(string font)
        {
            return new FontFamily { Font = font };      
        }
    }
}