namespace JuhaKurisu.PopoTools.Deterministics
{
    public static class FixVector2Extention
    {
        public static FixVector2 RotatePoint(this FixVector2 self, FixVector2 origin, Fix64 angle)
            => self.RotatePoint(self - origin, angle) + origin;

        public static FixVector2 RotatePoint(this FixVector2 self, Fix64 angle)
        {
            Fix64 radAngle = Fix64.deg2Rad * angle;
            Fix64 cos = Fix64.Cos(radAngle);
            Fix64 sin = Fix64.Sin(radAngle);

            return new FixVector2(
                self.x * cos - self.y * sin,
                self.x * sin + self.y * cos
            );
        }
    }
}