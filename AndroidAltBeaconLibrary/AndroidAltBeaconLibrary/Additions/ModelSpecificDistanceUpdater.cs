using Object = Java.Lang.Object;
using Void = Java.Lang.Void;

namespace AltBeaconOrg.BoundBeacon.Distance
{
    public partial class ModelSpecificDistanceUpdater
    {
        protected override Object DoInBackground(params Object[] @params)
        {
            // Call the renamed method with proper parameter handling
            var voidParams = new Void[@params.Length];
            for (int i = 0; i < @params.Length; i++)
            {
                voidParams[i] = (Void)@params[i];
            }
            return _DoInBackground(voidParams);
        }
    }
}