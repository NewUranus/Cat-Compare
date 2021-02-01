using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x804 上介绍了“空白页”项模板

namespace Cat_Compare
{
    /// <summary>
    /// 可用于自身或导航至 Frame 内部的空白页。
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            //Windows.UI.Composition.Visual hostVisual = Windows.UI.Xaml.Hosting.ElementCompositionPreview.GetElementVisual(GlassHost);
            //Windows.UI.Composition.Compositor compositor = hostVisual.Compositor;
            //var backdropBrush = compositor.CreateHostBackdropBrush();
            //var glassVisual = compositor.CreateSpriteVisual();
            //glassVisual.Brush = backdropBrush;
            //Windows.UI.Xaml.Hosting.ElementCompositionPreview.SetElementChildVisual(GlassHost, glassVisual);
            //var bindSizeAnimation = compositor.CreateExpressionAnimation("hostVisual.Size");
            //bindSizeAnimation.SetReferenceParameter("hostVisual", hostVisual);
            //glassVisual.StartAnimation("Size", bindSizeAnimation);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
