using System;
using AltBeaconOrg.BoundBeacon;
using AltBeaconOrg.BoundBeacon.Logging;
using Xunit;

namespace AndroidAltBeaconLibrary.UnitTests
{
    public class AltBeaconParserTest : TestBase
    {
        [Fact]
        public void TestRecognizeBeacon()
        {
            var beaconManager = BeaconManager.GetInstanceForApplication(Android.App.Application.Context);
            var bytes = HexStringToByteArray("02011a1bff1801beac2f234454cf6d4a0fadf2f4911ba9ffa600010002c50900");
            AltBeaconParser parser = new AltBeaconParser();
            Beacon beacon = parser.FromScanData(bytes, -55, null, 0);
            AssertEx.AreEqual("Beacon should have one data field", 1, beacon.DataFields.Count);
            AssertEx.AreEqual("manData should be parsed", 9, ((AltBeacon)beacon).MfgReserved);
        }

        [Fact]
        public void TestDetectsDaveMHardwareBeacon()
        {
            var bytes = HexStringToByteArray("02011a1bff1801beac2f234454cf6d4a0fadf2f4911ba9ffa600050003be020e09526164426561636f6e20555342020a0300000000000000000000000000");
            var parser = new AltBeaconParser();
            var beacon = parser.FromScanData(bytes, -55, null, 0);
            AssertEx.NotNull("Beacon should be not null if parsed successfully", beacon);
        }

        [Fact]
        public void TestDetectsAlternateBeconType()
        {
            var bytes = HexStringToByteArray("02011a1bff1801aabb2f234454cf6d4a0fadf2f4911ba9ffa600010002c50900");
            var parser = new AltBeaconParser();
            parser.SetMatchingBeaconTypeCode(new Java.Lang.Long(0xaabbL));
            var beacon = parser.FromScanData(bytes, -55, null, 0);
            AssertEx.NotNull("Beacon should be not null if parsed successfully", beacon);
        }

        [Fact]
        public void TestParseWrongFormatReturnsNothing()
        {
            LogManager.D("XXX", "testParseWrongFormatReturnsNothing start");
            var bytes = HexStringToByteArray("02011a1aff1801ffff2f234454cf6d4a0fadf2f4911ba9ffa600010002c509");
            var parser = new AltBeaconParser();
            var beacon = parser.FromScanData(bytes, -55, null, 0);
            LogManager.D("XXX", "testParseWrongFormatReturnsNothing end");
            Assert.Null(beacon);
        }

        [Fact]
        public void TestParsesBeaconMissingDataField()
        {
            var bytes = HexStringToByteArray("02011a1aff1801beac2f234454cf6d4a0fadf2f4911ba9ffa600010002c5000000");
            var parser = new AltBeaconParser();
            var beacon = parser.FromScanData(bytes, -55, null, 0);
            var identifier = beacon.GetIdentifier(0).ToString();
            var identifier1 = beacon.GetIdentifier(1).ToString();
            var identifier2 = beacon.GetIdentifier(2).ToString();
            AssertEx.AreEqual(-55, beacon.Rssi, "mRssi should be as passed in");
            AssertEx.AreEqual("uuid should be parsed", identifier, "2f234454-cf6d-4a0f-adf2-f4911ba9ffa6");
            AssertEx.AreEqual("id2 should be parsed", identifier1, "1");
            AssertEx.AreEqual("id3 should be parsed", identifier2, "2");
            AssertEx.AreEqual(-59, beacon.TxPower, "txPower should be parsed");
            AssertEx.AreEqual(0x118, beacon.Manufacturer, "manufacturer should be parsed");
            AssertEx.AreEqual(Convert.ToInt64(new Java.Lang.Long(0)), Convert.ToInt64(beacon.DataFields[0]), "missing data field zero should be zero");
        }
    }
}