namespace vector.lib
{
    public class DecartCoordsSystem
    {
        public double i, j, k;

        public DecartCoordsSystem(double i, double j, double k)
        {
            this.i = i;
            this.j = j;
            this.k = k;
        }

        // Проекция вектора в декартовой системе координат
        public DecartCoordsSystem(Vector vector)
        {
            this.i = vector.x;
            this.j = vector.y;
            this.k = vector.z;
        }
    }
}
