
using Android.Runtime;
using Java.Lang;

namespace AltBeaconOrg.BoundBeacon
{
    public partial class Settings
    {

        public partial class BackgroundServiceScanStrategy
        {
            public int CompareTo(Object o)
            {
                return CompareTo((IScanStrategy)o);
            }


            [Register("clone", "()Lorg/altbeacon/beacon/Settings$BackgroundServiceScanStrategy;", "")]
            public unsafe global::AltBeaconOrg.BoundBeacon.Settings.IScanStrategy Clone()
            {
                const string __id = "clone.()Lorg/altbeacon/beacon/Settings$BackgroundServiceScanStrategy;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::AltBeaconOrg.BoundBeacon.Settings.BackgroundServiceScanStrategy>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        public partial class ForegroundServiceScanStrategy
        {
            public int CompareTo(Object o)
            {
                return CompareTo((IScanStrategy)o);
            }

            public unsafe global::AltBeaconOrg.BoundBeacon.Settings.IScanStrategy Clone()
            {
                const string __id = "clone.()Lorg/altbeacon/beacon/Settings$ForegroundServiceScanStrategy;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::AltBeaconOrg.BoundBeacon.Settings.ForegroundServiceScanStrategy>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        public partial class IntentScanStrategy
        {
            public int CompareTo(Object o)
            {
                return CompareTo((IScanStrategy)o);
            }
            public unsafe global::AltBeaconOrg.BoundBeacon.Settings.IScanStrategy Clone()
            {
                const string __id = "clone.()Lorg/altbeacon/beacon/Settings$IntentScanStrategy;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::AltBeaconOrg.BoundBeacon.Settings.IntentScanStrategy>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }

        public partial class JobServiceScanStrategy
        {
            public int CompareTo(Object o)
            {
                return CompareTo((IScanStrategy)o);
            }

            public unsafe global::AltBeaconOrg.BoundBeacon.Settings.IScanStrategy Clone()
            {
                const string __id = "clone.()Lorg/altbeacon/beacon/Settings$JobServiceScanStrategy;";
                try
                {
                    var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod(__id, this, null);
                    return global::Java.Lang.Object.GetObject<global::AltBeaconOrg.BoundBeacon.Settings.JobServiceScanStrategy>(__rm.Handle, JniHandleOwnership.TransferLocalRef);
                }
                finally
                {
                }
            }
        }
    }
}
