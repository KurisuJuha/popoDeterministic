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

        public static Fix64 Ln(this Fix64 value)
            => Fix64.Ln(value);

        public static Fix64 Pow(this Fix64 value, Fix64 exp)
            => Fix64.Pow(value, exp);

        public static Fix64 Sqrt(this Fix64 value)
            => Fix64.Sqrt(value);

        public static Fix64 Sin(this Fix64 value)
            => Fix64.Sin(value);

        public static Fix64 FastSin(this Fix64 value)
            => Fix64.FastSin(value);

        public static Fix64 Cos(this Fix64 value)
            => Fix64.Cos(value);

        public static Fix64 FastCos(this Fix64 value)
            => Fix64.FastCos(value);

        public static Fix64 Tan(this Fix64 value)
            => Fix64.Tan(value);

    }
}