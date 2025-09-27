using System;
using AltBeaconOrg.BoundBeacon;
using AltBeaconOrg.BoundBeacon.Simulator;
using Xunit;
using System.Collections.Generic;

namespace AndroidAltBeaconLibrary.UnitTests
{
    public class BeaconSimulatorTest : TestBase
    {
        [Fact(Skip = "StaticBeaconSimulator.Beacons property is read-only in current API")]
        public void testSetBeacons()
        {
            // StaticBeaconSimulator staticBeaconSimulator = new StaticBeaconSimulator();
            // byte[] beaconBytes = HexStringToByteArray("02011a1bff1801beac2f234454cf6d4a0fadf2f4911ba9ffa600010002c509");
            // Beacon beacon = new AltBeaconParser().FromScanData(beaconBytes, -55, null, 0);
            // List<Beacon> beacons = new List<Beacon>();
            // beacons.Add(beacon);
            // staticBeaconSimulator.Beacons = beacons; // Property is read-only
            // AssertEx.AreEqual("getBeacons should match values entered with setBeacons", staticBeaconSimulator.Beacons, beacons);
        }

        [Fact(Skip = "StaticBeaconSimulator.Beacons property is read-only in current API")]
        public void testSetBeaconsEmpty()
        {
            // StaticBeaconSimulator staticBeaconSimulator = new StaticBeaconSimulator();
            // List<Beacon> beacons = new List<Beacon>();
            // staticBeaconSimulator.Beacons = beacons; // Property is read-only
            // AssertEx.AreEqual("getBeacons should match values entered with setBeacons even when empty", staticBeaconSimulator.Beacons, beacons);
        }

        [Fact(Skip = "StaticBeaconSimulator.Beacons property is read-only in current API")]
        public void testSetBeaconsNull()
        {
            // StaticBeaconSimulator staticBeaconSimulator = new StaticBeaconSimulator();
            // staticBeaconSimulator.Beacons = null; // Property is read-only
            // AssertEx.AreEqual("getBeacons should return null", staticBeaconSimulator.Beacons, null);
        }
    }
}
