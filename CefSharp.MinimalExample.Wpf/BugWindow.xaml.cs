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
using System.Windows.Shapes;

namespace CefSharp.MinimalExample.Wpf
{
    /// <summary>
    /// Interaction logic for BugWindow.xaml
    /// </summary>
    public partial class BugWindow : Window
    {
        private CefSharp.Wpf.ChromiumWebBrowser browser;

        public BugWindow()
        {
            InitializeComponent();

            this.StaticBrowser.Child = new CefSharp.Wpf.ChromiumWebBrowser("http://www.msn.net");
        }

        private void OnAddBrowser(object sender, RoutedEventArgs e)
        {
            if (browser == null)
            {
                browser = new CefSharp.Wpf.ChromiumWebBrowser("http://www.msn.net");
            }

            this.BrowserSite.Child = browser;
        }

        private void OnRemoveBrowser(object sender, RoutedEventArgs e)
        {
            if (browser != null)
            {
                this.BrowserSite.Child = null;
            }
        }
    }
}
