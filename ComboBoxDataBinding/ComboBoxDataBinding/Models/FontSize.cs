using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComboBoxDataBinding.Models
{
    public class FontSize
    {
        public int SizeFont { get; set; }

        public static FontSize CreateFontSize(int sizeFont)
        {
            return new FontSize { SizeFont = sizeFont };
            
        }
    }
}