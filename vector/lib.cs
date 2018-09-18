using System;


namespace lib
{
    // Вектор в 3-х мерном пространстве
    public class Vector
    {
        // Пространственные координаты вектора
        public double x, y, z;

        // Получение модуля вектора
        public double module {
            get {
                return Math.Sqrt((x * x) + (y * y) + (z * z));
            }
        }

        // Инициализация вектора при отсутствующих входных данных
        public Vector()
        {
            this.x = 0f;
            this.y = 0f;
            this.z = 0f;
        }

        // Инициализация вектора 
        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        // Перегрузка оператора сложения векторов
        public static Vector operator +(Vector a, Vector b)
        {
            return new Vector(a.x + b.x, a.y + b.y, a.z + b.z);
        }

        // Перегрузка оператора разности векторов
        public static Vector operator -(Vector a, Vector b)
        {
            return new Vector(a.x - b.x, a.y - b.y, a.z - b.z);
        }

        // Перегрузка оператора умножения вектора на скаляр(величину)
        public static Vector operator *(Vector vector, double number)
        {
            return new Vector(vector.x * number, vector.y * number, vector.z * number);
        }

        // Проекция вектора в декартовой системе координат
        public static implicit operator DecartCoordsSystem(Vector vector)
        {
            return new DecartCoordsSystem(vector);
        }

        // Проекция вектора в цилиндрической системе координат
        public static implicit operator CyrCoordsSystem(Vector vector)
        {
            return new CyrCoordsSystem(vector);
        }

    }

    // Декартовое представление вектора
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

    // Цилиндрическая система координат
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
            this.z = vector.x;
        }
    }

}
