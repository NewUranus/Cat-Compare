using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
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

            Windows.ApplicationModel.Core.CoreApplication.GetCurrentView().TitleBar.ExtendViewIntoTitleBar = true;

            //
            RichEditBox1.Visibility = Visibility.Collapsed;
            RichEditBox2.Visibility = Visibility.Collapsed;
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            Windows.Storage.StorageFolder picturesFolder = Windows.Storage.KnownFolders.PicturesLibrary;
            System.Text.StringBuilder outputText = new StringBuilder();

            IReadOnlyList<Windows.Storage.IStorageItem> itemsList = await picturesFolder.GetItemsAsync();

            foreach (var item in itemsList)
            {
                if (item is Windows.Storage.StorageFolder)
                {
                    outputText.Append(item.Name + " folder\n");

                }
                else
                {
                    outputText.Append(item.Name + "\n");

                }
            }
            TextBlock1.Text = outputText.ToString() + "\nPath:==" + picturesFolder.Path;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
