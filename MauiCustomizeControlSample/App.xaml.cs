#if __ANDROID__
using Android.Content.Res;
using Microsoft.Maui.Controls.Compatibility.Platform.Android;
#endif
using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.PlatformConfiguration.WindowsSpecific;
using Microsoft.Maui.Graphics;
using Application = Microsoft.Maui.Controls.Application;

namespace MauiCustomizeControlSample
{
	public partial class App : Application
	{
		public App()
		{
			InitializeComponent();
            // EntryMapper hase been update to Mapper
            Microsoft.Maui.Handlers.EntryHandler.Mapper.AppendToMapping("NoUnderline", (handler, view) =>
            {
#if __ANDROID__
                //I am not able to find a perfect replacement for NativeView
                handler.PlatformView.BackgroundTintList = ColorStateList.ValueOf(Colors.Transparent.ToAndroid());
#endif
			});

            MainPage = new MainPage();
		}
	}
}
