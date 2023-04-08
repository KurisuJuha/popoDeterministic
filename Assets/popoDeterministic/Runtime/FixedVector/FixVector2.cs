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

    }
}