using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaLibrary
{
    public partial class MyAvaloniaControl : UserControl
    {
        public MyAvaloniaControl()
        {
            InitializeComponent();
        }

        public void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
