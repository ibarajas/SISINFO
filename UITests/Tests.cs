using System;
using System.IO;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace SISINFO.UITests
{
	[TestFixture]
	public class Tests
	{
		AndroidApp app;

		[SetUp]
		public void BeforeEachTest ()
		{
			app = ConfigureApp.Android.ApkFile("../../../Droid/bin/Release/com.itc.SISINFO.apk").StartApp ();
		}

		[Test]
		public void Buscar ()
		{
			app.Tap(c=>c.Marked("NoResourceEntry-0"));
			app.EnterText (c => c.Index (12), "luis");
			app.Tap (c => c.Index (17));
		}
	}
}

