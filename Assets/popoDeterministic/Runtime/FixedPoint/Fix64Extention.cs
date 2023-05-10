namespace JuhaKurisu.PopoTools.Deterministics.Extentions
{
    public static class Fix64Extention
    {
        public static int Sign(this Fix64 value)
            => Fix64.Sign(value);

        public static Fix64 Abs(this Fix64 value)
            => Fix64.Abs(value);

        public static Fix64 FastAbs(this Fix64 value)
            => Fix64.FastAbs(value);

    }
}