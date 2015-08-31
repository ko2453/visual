using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ComboBoxDataBinding.Models;

namespace ComboBoxDataBinding.Data
{
    public class FontRepository
    {
        readonly List<FontFamily> _fontfamily = new List<FontFamily>();
        readonly List<FontSize> _fontsize = new List<FontSize>();

        public FontRepository()
        {            
        }

        public List<FontFamily> getfamily()
        { 
            for (int i = 0; i < 5; i++)
            {
                _fontfamily.Add(FontFamily.CreateFontFamily("czionkakroj" + i));
            }
            return new List<FontFamily>(_fontfamily);
        }

        public List<FontSize> getsize()
        {
            for (int i = 4; i < 80; i++)
            {
                _fontsize.Add(FontSize.CreateFontSize(i));
            }
            return new List<FontSize>(_fontsize);
        }
    }
}
