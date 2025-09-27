using Android.Runtime;
using System;
using System.Collections.Generic;

namespace AltBeaconOrg.BoundBeacon.Simulator
{
    public partial class StaticBeaconSimulator
    {


        public IList<Beacon> Beacons => BeaconsNet();

        [Register("getBeacons", "()Ljava/util/List;", "GetBeaconsNetHandler")]
        public virtual unsafe global::System.Collections.Generic.IList<global::AltBeaconOrg.BoundBeacon.Beacon> BeaconsNet()
        {
            const string __id = "getBeacons.()Ljava/util/List;";
            try
            {
                var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod(__id, this, null);
                return global::Android.Runtime.JavaList<global::AltBeaconOrg.BoundBeacon.Beacon>.FromJniHandle(__rm.Handle, JniHandleOwnership.TransferLocalRef);
            }
            finally
            {
            }
        }
    }
}
