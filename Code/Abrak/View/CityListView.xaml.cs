using Abrak.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Abrak.View
{
    /// <summary>
    /// Interaction logic for CityListView.xaml
    /// </summary>
    public partial class CityListView : UserControl
    {
        public CityListView()
        {
            InitializeComponent();
            CityListView_ViewModel  vm = new CityListView_ViewModel();
            DataContext = vm;
        }
    }
}
