using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace BarManagerControllerExample {
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window {
        public Window1() {
            InitializeComponent();
        }

        private void btnExit_ItemClick(object sender, DevExpress.Wpf.Bars.ItemClickEventArgs e) {
            Close();
        }

        private void btnAbout_ItemClick(object sender, DevExpress.Wpf.Bars.ItemClickEventArgs e) {
            MessageBox.Show("About Window");
        }

        private void myButton_ItemClick(object sender, DevExpress.Wpf.Bars.ItemClickEventArgs e) {

        }

        private void myButton2_ItemClick(object sender, DevExpress.Wpf.Bars.ItemClickEventArgs e) {

        }
    }
}
