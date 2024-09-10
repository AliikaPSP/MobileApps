﻿#if WINDOWS
using Microsoft.UI;
using Microsoft.UI.Windowing;
using Windows.Graphics;
#endif
using MauiApp1.Views;

namespace MauiApp1
{
    public partial class App : Application
    {
        const int WindowWidth = 540;
        const int WindowHeight = 1200;
        public App()
        {
            InitializeComponent();

#if WINDOWS
                Microsoft.Maui.Handlers.WindowHandler.Mapper.AppendToMapping(nameof(IWindow), (handler, view) =>
                {
                    var mauiWindow = handler.VirtualView;
                    var nativeWindow = handler.PlatformView;
                    nativeWindow.Activate();
                    IntPtr windowHandle = WinRT.Interop.WindowNative.GetWindowHandle(nativeWindow);
                    WindowId windowId = Microsoft.UI.Win32Interop.GetWindowIdFromWindow(windowHandle);
                    AppWindow appWindow = Microsoft.UI.Windowing.AppWindow.GetFromWindowId(windowId);
                    appWindow.Resize(new SizeInt32(WindowWidth, WindowHeight));
                });
#endif
           

            MainPage = new StartPage();
        }
    }
}
