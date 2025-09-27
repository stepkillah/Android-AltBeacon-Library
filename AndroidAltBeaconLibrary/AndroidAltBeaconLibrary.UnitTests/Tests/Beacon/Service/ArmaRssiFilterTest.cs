using System;
using AltBeaconOrg.BoundBeacon.Service;
using Xunit;

namespace AndroidAltBeaconLibrary.UnitTests
{
	public class ArmaRssiFilterTest
	{
		[Fact]
	    public void initTest1() {
	        ArmaRssiFilter filter = new ArmaRssiFilter();
	        filter.AddMeasurement(new Java.Lang.Integer(-50));
	        AssertEx.AreEqual("First measurement should be -50", filter.CalculateRssi().ToString("F1"), "-50.0");
	    }
	}
}
