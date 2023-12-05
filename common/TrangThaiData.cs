using PJ_For_Wang_Test.PopsUp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PJ_For_Wang_Test.common
{
    class TrangThaiData
    {
        public static string tatca = "Tất cả";
        public static string nghiViec = "Đã nghỉ việc";
        public static string lamViec = "Đang làm việc";

        public static ComboboxItem comboboxItem2 = new ComboboxItem(tatca, 2);
        public static ComboboxItem comboboxItem0 = new ComboboxItem(nghiViec, 0);
        public static ComboboxItem comboboxItem1 = new ComboboxItem(lamViec, 1);
        //public static Dictionary<int, ComboboxItem> items = new Dictionary<int, ComboboxItem>() { 
        //  { 2, comboboxItem2 }, { 1, comboboxItem1 }, { 0, comboboxItem0 } 
        //};
        public static ComboboxItem[] items = new ComboboxItem[] { comboboxItem2, comboboxItem1, comboboxItem0 };
        public static ComboboxItem[] itemsUpdate = new ComboboxItem[] { comboboxItem1, comboboxItem0 };
        // new[] { comboboxItem0, comboboxItem1, comboboxItem };
    }
}
