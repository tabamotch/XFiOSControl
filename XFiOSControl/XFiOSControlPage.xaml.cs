using Xamarin.Forms;

namespace XFiOSControl
{
    public partial class XFiOSControlPage : ContentPage
    {
        public XFiOSControlPage()
        {
            InitializeComponent();

            hoge.InsertSegment("test1", 0, false);
            hoge.InsertSegment("test2", 1, false);

            hoge.SelectedSegment = 0;
        }
    }
}
