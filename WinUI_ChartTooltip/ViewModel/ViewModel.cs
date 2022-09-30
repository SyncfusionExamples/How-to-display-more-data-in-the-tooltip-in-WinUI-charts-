using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinUI_ChartTooltip
{
    public class ViewModel
    {
        private ObservableCollection<Model> data;

        public ObservableCollection<Model> Data
        {
            get { return data; }
            set { data = value; }
        }

        public ViewModel()
        {
            Data = new ObservableCollection<Model>()
            {
                new Model() {Country ="India", Population=234},
                new Model(){Country ="United States", Population = 156},
                new Model(){Country ="China", Population = 280},
                new Model(){Country ="Australia", Population = 134},
                new Model(){Country ="Kuwait", Population = 80}
            };
        }
    }
}
