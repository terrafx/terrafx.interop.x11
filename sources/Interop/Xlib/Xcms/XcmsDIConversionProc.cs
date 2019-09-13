// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from X11\Xcms.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © Tektronix, Inc.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [UnmanagedFunctionPointer(CallingConvention.Cdecl)]
    public unsafe delegate int XcmsDIConversionProc([NativeTypeName("XcmsCCC")] XcmsCCC* ccc, [NativeTypeName("XcmsColor *")] XcmsColor* white_point, [NativeTypeName("XcmsColor *")] XcmsColor* pcolors_in_out, [NativeTypeName("unsigned int")] uint ncolors);
}