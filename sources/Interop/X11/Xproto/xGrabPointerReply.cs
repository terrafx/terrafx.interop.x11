namespace TerraFX.Interop
{
    public partial struct xGrabPointerReply
    {
        [NativeTypeName("BYTE")]
        public byte type;

        [NativeTypeName("BYTE")]
        public byte status;

        [NativeTypeName("CARD16")]
        public ushort sequenceNumber;

        [NativeTypeName("CARD32")]
        public uint length;

        [NativeTypeName("CARD32")]
        public uint pad1;

        [NativeTypeName("CARD32")]
        public uint pad2;

        [NativeTypeName("CARD32")]
        public uint pad3;

        [NativeTypeName("CARD32")]
        public uint pad4;

        [NativeTypeName("CARD32")]
        public uint pad5;

        [NativeTypeName("CARD32")]
        public uint pad6;
    }
}
