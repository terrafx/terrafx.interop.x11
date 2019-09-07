// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xlib.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct XConfigureRequestEvent
    {
        public int type;

        [NativeTypeName("unsigned long")]
        public UIntPtr serial;

        public int send_event;

        [NativeTypeName("Display *")]
        public XDisplay* display;

        [NativeTypeName("Window")]
        public UIntPtr parent;

        [NativeTypeName("Window")]
        public UIntPtr window;

        public int x;

        public int y;

        public int width;

        public int height;

        public int border_width;

        [NativeTypeName("Window")]
        public UIntPtr above;

        public int detail;

        [NativeTypeName("unsigned long")]
        public UIntPtr value_mask;
    }
}