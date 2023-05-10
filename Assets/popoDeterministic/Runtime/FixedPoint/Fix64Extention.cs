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

        public static Fix64 Floor(this Fix64 value)
            => Fix64.Floor(value);

        public static long FloorToLong(this Fix64 value)
            => Fix64.FloorToLong(value);

        public static Fix64 Ceiling(this Fix64 value)
            => Fix64.Ceiling(value);

        public static Fix64 Round(this Fix64 value)
            => Fix64.Round(value);

    }
}