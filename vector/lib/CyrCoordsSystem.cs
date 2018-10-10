using System;

namespace vector.lib
{
    public class CyrCoordsSystem
    {
        public double r, f, z;

        public CyrCoordsSystem(double p, double f, double z)
        {
            this.r = p;
            this.f = f;
            this.z = z;
        }

        // Проекция вектора в цилиндрической системе координат
        public CyrCoordsSystem(Vector vector)
        {
            this.r = Math.Sqrt((vector.x * vector.x) + (vector.y * vector.y));
            this.f = Math.Atan(vector.y / vector.x);
            this.z = vector.z;
        }
    }
}
