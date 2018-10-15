using System;

namespace vector.lib
{
    public class CylCoordsSystem
    {
        public double r, f, z;

        public CylCoordsSystem(double p, double f, double z)
        {
            this.r = p;
            this.f = f;
            this.z = z;
        }

        // Проекция вектора в цилиндрической системе координат
        public CylCoordsSystem(Vector vector)
        {
            this.r = Math.Sqrt((vector.x * vector.x) + (vector.y * vector.y));
            this.f = Math.Atan(vector.y / vector.x);
            this.z = vector.z;
        }
    }
}
