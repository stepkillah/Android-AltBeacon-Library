using System;
using AltBeaconOrg.BoundBeacon.Service.Scanner;
using Xunit;

namespace AndroidAltBeaconLibrary.UnitTests
{
	public class DistinctPacketDetectorTest
	{
		[Fact(Skip = "DistinctPacketDetector class no longer available in library")]
	    public void testSecondDuplicatePacketIsNotDistinct() {
	        // DistinctPacketDetector dpd = new DistinctPacketDetector();
	        // dpd.IsPacketDistinct("01:02:03:04:05:06", new byte[] {0x01, 0x02});
	        // bool secondResult = dpd.IsPacketDistinct("01:02:03:04:05:06", new byte[] {0x01, 0x02});
	        // AssertEx.False("second call with same packet should not be distinct", secondResult);
	    }
	
	    [Fact(Skip = "DistinctPacketDetector class no longer available in library")]
	    public void testSecondNonDuplicatePacketIsDistinct() {
	        // DistinctPacketDetector dpd = new DistinctPacketDetector();
	        // dpd.IsPacketDistinct("01:02:03:04:05:06", new byte[] {0x01, 0x02});
	        // bool secondResult = dpd.IsPacketDistinct("01:02:03:04:05:06", new byte[] {0x03, 0x04});
	        // AssertEx.True("second call with different packet should be distinct", secondResult);
	    }
	
	    [Fact(Skip = "DistinctPacketDetector class no longer available in library")]
	    public void testSamePacketForDifferentMacIsDistinct() {
	        // DistinctPacketDetector dpd = new DistinctPacketDetector();
	        // dpd.IsPacketDistinct("01:02:03:04:05:06", new byte[] {0x01, 0x02});
	        // bool secondResult = dpd.IsPacketDistinct("01:01:01:01:01:01", new byte[] {0x01, 0x02});
	        // AssertEx.True("second packet with different mac should be distinct", secondResult);
	    }
	
	    [Fact(Skip = "DistinctPacketDetector class no longer available in library")]
	    public void clearingDetectionsPreventsDistinctDetection() {
	        // DistinctPacketDetector dpd = new DistinctPacketDetector();
	        // dpd.IsPacketDistinct("01:02:03:04:05:06", new byte[] {0x01, 0x02});
	        // dpd.ClearDetections();
	        // bool secondResult = dpd.IsPacketDistinct("01:02:03:04:05:06", new byte[] {0x01, 0x02});
	        // AssertEx.True("second call with same packet after clear should be distinct", secondResult);
	    }
	}
}
