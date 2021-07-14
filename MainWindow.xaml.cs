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

namespace Custom_Cursor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //      Cursor myCursor = new Cursor(Application.GetResourceStream(new Uri("stain-of-paint-cursor.cur", UriKind.Relative)).Stream);
        //Cursor myCursor = new Cursor(@"D:\repos\Custom Cursor\cursorpaint.cur");
        Cursor myCursor = new Cursor(@"D:\repos\Custom Cursor\cursor3.cur");
        //Cursor myCursor2 = new Cursor(Application.GetResourceStream(new Uri("stain-of-paint-pointer.cur")).Stream);
        public MainWindow()
        {
            this.Cursor = myCursor;
            InitializeComponent();
        }
    }
}
