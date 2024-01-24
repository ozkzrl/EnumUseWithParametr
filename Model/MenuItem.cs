using EnumUseWithParametr.Enums;
using System.ComponentModel.DataAnnotations;

namespace EnumUseWithParametr.Model
{
    public class MenuItem
    {
        
        public int Id { get; set; }
        public MenuType MenuType { get; set; }
        public string DisplayName { get; set; }
        public string Url { get; set; }

    }
}
