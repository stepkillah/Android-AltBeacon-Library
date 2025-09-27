
using Android.Runtime;
using Java.Interop;
using System;

namespace AltBeaconOrg.BoundBeacon.Utils
{
    public partial class ChangeAwareCopyOnWriteArrayList
    {
        [Register("removeIf", "(Ljava/util/function/Predicate;)Z", "")]
        public override unsafe bool RemoveIf(global::Java.Util.Functions.IPredicate filter)
        {
            const string __id = "removeIf.(Ljava/util/function/Predicate;)Z";
            try
            {
                JniArgumentValue* __args = stackalloc JniArgumentValue[1];
                __args[0] = new JniArgumentValue((filter == null) ? IntPtr.Zero : ((global::Java.Lang.Object)filter).Handle);
                var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod(__id, this, __args);
                return __rm;
            }
            finally
            {
                global::System.GC.KeepAlive(filter);
            }
        }

        [Register("size", "()I", "")]
        public unsafe int InvokeSize()
        {
            const string __id = "size.()I";
            try
            {
                var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method(__id, this, null);
                return __rm;
            }
            finally
            {
            }
        }
    }
}
