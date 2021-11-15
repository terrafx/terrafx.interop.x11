// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from include/X11/Xproto.h in the Xlib - C Language X Interface: X Version 11, Release 7.7
// Original source is Copyright © The Open Group

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Xlib.UnitTests
{
    /// <summary>Provides validation of the <see cref="xStoreNamedColorReq" /> struct.</summary>
    public static unsafe partial class xStoreNamedColorReqTests
    {
        /// <summary>Validates that the <see cref="xStoreNamedColorReq" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<xStoreNamedColorReq>(), Is.EqualTo(sizeof(xStoreNamedColorReq)));
        }

        /// <summary>Validates that the <see cref="xStoreNamedColorReq" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(xStoreNamedColorReq).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="xStoreNamedColorReq" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(xStoreNamedColorReq), Is.EqualTo(16));
        }
    }
}