﻿using System.Runtime.InteropServices;
using GameOffsets.Native;

namespace GameOffsets
{
    [StructLayout(LayoutKind.Explicit, Pack = 1)]
    public struct ObjectMagicPropertiesOffsets
    {
        [FieldOffset(0x9C)] public int Rarity;
        [FieldOffset(0xC0)] public NativePtrArray Mods;
    }
}
