namespace TerraFX.Interop
{
    public partial struct xChangeActivePointerGrabReq
    {
        [NativeTypeName("CARD8")]
        public byte reqType;

        [NativeTypeName("BYTE")]
        public byte pad;

        [NativeTypeName("CARD16")]
        public ushort length;

        [NativeTypeName("CARD32")]
        public uint cursor;

        [NativeTypeName("CARD32")]
        public uint time;

        [NativeTypeName("CARD16")]
        public ushort eventMask;

        [NativeTypeName("CARD16")]
        public ushort pad2;
    }
}
