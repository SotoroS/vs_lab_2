using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vector.lib
{
    public class Vector
    {
        // Пространственные координаты вектора
        public double x, y, z;

        // Получение модуля вектора
        public double module {
            get
            {
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
        public static implicit operator CylCoordsSystem(Vector vector)
        {
            return new CylCoordsSystem(vector);
        }

        /// <summary>
        /// Преобразование в строковый тип данных
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return x.ToString("F2") + "; " + y.ToString("F2") + "; " + z.ToString("F2") + "; " + module.ToString("F2") + "; " + ((CylCoordsSystem)this).f.ToString("F2"); 
        }

        /// <summary>
        /// Оператор сравнения
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            var item = obj as Vector;

            if (item == null)
                return false;

            return this.x.Equals(item.x) && this.y.Equals(item.y) && this.z.Equals(item.z);
        }

        /// <summary>
        /// Хэш-функция
        /// </summary>
        /// <returns></returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }
    }

}
