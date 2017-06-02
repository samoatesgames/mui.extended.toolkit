
using System;
using Xceed.Wpf.AvalonDock.Themes;

namespace ModernUI.Xceed.AvalonDock
{
    public class ModernUiTheme : Theme
    {
        public override Uri GetResourceUri()
        {
            return new Uri("/ModernUI.Xceed.AvalonDock;component/Assets/Theme.xaml", UriKind.Relative);  
        }
    }
}
