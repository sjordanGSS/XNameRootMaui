using System;
using Android.App;
using Android.Runtime;
using Microsoft.Maui;

namespace MauiTest4
{
	[Application]
	public class MainApplication : MauiApplication<Startup>
	{
		public MainApplication(IntPtr handle, JniHandleOwnership ownership)
			: base(handle, ownership)
		{
		}
	}
}