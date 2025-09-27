using System;
using Xunit;
using AltBeaconOrg.BoundBeacon.Service;

namespace AndroidAltBeaconLibrary.UnitTests
{
	public class RunningAverageRssiFilterTest
	{
		[Fact]
	    public void initTest1() {
	        RunningAverageRssiFilter filter = new RunningAverageRssiFilter();
	        filter.AddMeasurement(new Java.Lang.Integer(-50));
	        AssertEx.AreEqual("First measurement should be -50", filter.CalculateRssi().ToString("F1"), "-50.0");
	    }
	}
}
