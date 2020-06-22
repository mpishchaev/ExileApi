using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ActorComponentOffsets
    {
        [FieldOffset(0x1a8)] public long ActionPtr;
        [FieldOffset(0x208)] public short ActionId;

        // [FieldOffset(0xFA)] public short TotalActionCounterA;
        // [FieldOffset(0xFC)] public int TotalActionCounterB;
        // only works for channeling skills
        // [FieldOffset(0x100)] public float TotalTimeInAction;
        // some unknown timer whos value keep resetting to zero.
        // [FieldOffset(0x104)] public float UnknownTimer;
        [FieldOffset(0x230)] public int AnimationId;

        // Use the one inside the ActionPtr struct (i.e. ActionWrapperOffsets).
        // That one works for all kind of skills.
        // [FieldOffset(0x128)] public Vector2 SkillDestination;
        [FieldOffset(0x650)] public NativePtrArray ActorSkillsArray;
        [FieldOffset(0x670)] public NativePtrArray ActorVaalSkills; // probably wrong
        [FieldOffset(0x698)] public NativePtrArray DeployedObjectArray; // probably wrong
    }
}
