using System;

namespace JuhaKurisu.PopoTools.Deterministics
{
    public struct FixVector2
    {
        public Fix64 x { get; private set; }
        public Fix64 y { get; private set; }

        public Fix64 this[int index]
        {
            get
            {
                switch (index)
                {
                    case 0: return x;
                    case 1: return y;
                    default:
                        throw new IndexOutOfRangeException("Invalid Vector2 index!");
                }
            }
        }

        public FixVector2(Fix64 x, Fix64 y) { this.x = x; this.y = y; }

        public FixVector2(Fix64 x) { this.x = x; this.y = Fix64.Zero; }

        private static readonly FixVector2 zeroVector = new(new(0), new(0));
        private static readonly FixVector2 oneVector = new(new(1), new(1));
        private static readonly FixVector2 upVector = new(new(0), new(1));
        public static FixVector2 zero => zeroVector;
        public static FixVector2 one => oneVector;
        public static FixVector2 up => upVector;
    }
}