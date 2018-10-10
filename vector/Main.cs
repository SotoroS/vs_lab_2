using System;
using System.Windows.Forms;
using vector.lib;
using System.Collections.Generic;
using System.Linq;

namespace vector
{
    public partial class Main : Form
    {
        /// <summary>
        /// Список векторов
        /// </summary>
        private List<Vector> vectors = new List<Vector>();

        /// <summary>
        /// Состояние сортировки ASC || DESC
        /// </summary>
        private bool asc = true;

        public Main()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Проверка введенных значений в поля формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxCoord_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// Регулировка доступности полей в зависиомоти от выбранной операции вычисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                groupBoxVectorB.Enabled = false;
                textBoxNumber.Enabled = true;
            }
            else
            {
                groupBoxVectorB.Enabled = true;
                textBoxNumber.Enabled = false;
            }
        }

        /// <summary>
        /// Dвычисления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCalc_Click(object sender, EventArgs e)
        {

            if (radioButtonAdd.Checked) // Сложение
            {
                Vector a = new Vector(
                    Convert.ToDouble(textBoxVectorAX.Text),
                    Convert.ToDouble(textBoxVectorAY.Text),
                    Convert.ToDouble(textBoxVectorAZ.Text)
                );

                Vector b = new Vector(
                    Convert.ToDouble(textBoxVectorBX.Text),
                    Convert.ToDouble(textBoxVectorBY.Text),
                    Convert.ToDouble(textBoxVectorBZ.Text)
                );

                Vector result = a + b;

                textBoxVectorResX.Text = result.x.ToString("N2");
                textBoxVectorResY.Text = result.y.ToString("N2");
                textBoxVectorResZ.Text = result.z.ToString("N2");

                // Вычисление модулей
                textBoxVectorAModule.Text = a.module.ToString("N2");
                textBoxVectorBModule.Text = b.module.ToString("N2");
                textBoxVectorResModule.Text = result.module.ToString("N2");

                // Проекция в декартовую систему координат
                DecartCoordsSystem decartA = new DecartCoordsSystem(a);
                DecartCoordsSystem decartB = new DecartCoordsSystem(b);
                DecartCoordsSystem decartRes = new DecartCoordsSystem(result);

                textBoxVectorAI.Text = decartA.i.ToString("N2");
                textBoxVectorAJ.Text = decartA.j.ToString("N2");
                textBoxVectorAK.Text = decartA.k.ToString("N2");

                textBoxVectorBI.Text = decartB.i.ToString("N2");
                textBoxVectorBJ.Text = decartB.j.ToString("N2");
                textBoxVectorBK.Text = decartB.k.ToString("N2");

                textBoxVectorResI.Text = decartRes.i.ToString("N2");
                textBoxVectorResJ.Text = decartRes.j.ToString("N2");
                textBoxVectorResK.Text = decartRes.k.ToString("N2");

                // Проекция в цилиндрическую систему координат
                CyrCoordsSystem cylA = new CyrCoordsSystem(a);
                CyrCoordsSystem cylB = new CyrCoordsSystem(b);
                CyrCoordsSystem cylRes = new CyrCoordsSystem(result);

                textBoxVectorACylR.Text = cylA.r.ToString("N2");
                textBoxVectorACylF.Text = cylA.f.ToString("N2");
                textBoxVectorACylZ.Text = cylA.z.ToString("N2");

                textBoxVectorBCylR.Text = cylB.r.ToString("N2");
                textBoxVectorBCylF.Text = cylB.f.ToString("N2");
                textBoxVectorBCylZ.Text = cylB.z.ToString("N2");

                textBoxVectorResCylR.Text = cylRes.r.ToString("N2");
                textBoxVectorResCylF.Text = cylRes.f.ToString("N2");
                textBoxVectorResCylZ.Text = cylRes.z.ToString("N2");
            }
            else if (radioButtonDiff.Checked)   // Вычитание
            {
                Vector a = new Vector(
                    Convert.ToDouble(textBoxVectorAX.Text),
                    Convert.ToDouble(textBoxVectorAY.Text),
                    Convert.ToDouble(textBoxVectorAZ.Text)
                );

                Vector b = new Vector(
                    Convert.ToDouble(textBoxVectorBX.Text),
                    Convert.ToDouble(textBoxVectorBY.Text),
                    Convert.ToDouble(textBoxVectorBZ.Text)
                );

                Vector result = a - b;

                textBoxVectorResX.Text = result.x.ToString("N2");
                textBoxVectorResY.Text = result.y.ToString("N2");
                textBoxVectorResZ.Text = result.z.ToString("N2");

                // Вычисление модулей
                textBoxVectorAModule.Text = a.module.ToString("N2");
                textBoxVectorBModule.Text = b.module.ToString("N2");
                textBoxVectorResModule.Text = result.module.ToString("N2");

                // Проекция в декартовую систему координат
                DecartCoordsSystem decartA = new DecartCoordsSystem(a);
                DecartCoordsSystem decartB = new DecartCoordsSystem(b);
                DecartCoordsSystem decartRes = new DecartCoordsSystem(result);

                textBoxVectorAI.Text = decartA.i.ToString("N2");
                textBoxVectorAJ.Text = decartA.j.ToString("N2");
                textBoxVectorAK.Text = decartA.k.ToString("N2");

                textBoxVectorBI.Text = decartB.i.ToString("N2");
                textBoxVectorBJ.Text = decartB.j.ToString("N2");
                textBoxVectorBK.Text = decartB.k.ToString("N2");

                textBoxVectorResI.Text = decartRes.i.ToString("N2");
                textBoxVectorResJ.Text = decartRes.j.ToString("N2");
                textBoxVectorResK.Text = decartRes.k.ToString("N2");

                // Проекция в цилиндрическую систему координат
                CyrCoordsSystem cylA = new CyrCoordsSystem(a);
                CyrCoordsSystem cylB = new CyrCoordsSystem(b);
                CyrCoordsSystem cylRes = new CyrCoordsSystem(result);

                textBoxVectorACylR.Text = cylA.r.ToString("N2");
                textBoxVectorACylF.Text = cylA.f.ToString("N2");
                textBoxVectorACylZ.Text = cylA.z.ToString("N2");

                textBoxVectorBCylR.Text = cylB.r.ToString("N2");
                textBoxVectorBCylF.Text = cylB.f.ToString("N2");
                textBoxVectorBCylZ.Text = cylB.z.ToString("N2");

                textBoxVectorResCylR.Text = cylRes.r.ToString("N2");
                textBoxVectorResCylF.Text = cylRes.f.ToString("N2");
                textBoxVectorResCylZ.Text = cylRes.z.ToString("N2");
            }
            else if (radioButtonMulti.Checked)  // Умножение
            {
                Vector a = new Vector(
                    Convert.ToDouble(textBoxVectorAX.Text),
                    Convert.ToDouble(textBoxVectorAY.Text),
                    Convert.ToDouble(textBoxVectorAZ.Text)
                );

                Double b = Convert.ToDouble(textBoxNumber.Text);

                Vector result = a * b;

                textBoxVectorResX.Text = result.x.ToString("N2");
                textBoxVectorResY.Text = result.y.ToString("N2");
                textBoxVectorResZ.Text = result.z.ToString("N2");

                // Вычисление модулей
                textBoxVectorAModule.Text = a.module.ToString("N2");
                textBoxVectorResModule.Text = result.module.ToString("N2");

                // Проекция в декартовую систему координат
                DecartCoordsSystem decartA = new DecartCoordsSystem(a);
                DecartCoordsSystem decartRes = new DecartCoordsSystem(result);

                textBoxVectorAI.Text = decartA.i.ToString("N2");
                textBoxVectorAJ.Text = decartA.j.ToString("N2");
                textBoxVectorAK.Text = decartA.k.ToString("N2");

                textBoxVectorResI.Text = decartRes.i.ToString("N2");
                textBoxVectorResJ.Text = decartRes.j.ToString("N2");
                textBoxVectorResK.Text = decartRes.k.ToString("N2");

                // Проекция в цилиндрическую систему координат
                CyrCoordsSystem cylA = new CyrCoordsSystem(a);
                CyrCoordsSystem cylRes = new CyrCoordsSystem(result);

                textBoxVectorACylR.Text = cylA.r.ToString("N2");
                textBoxVectorACylF.Text = cylA.f.ToString("N2");
                textBoxVectorACylZ.Text = cylA.z.ToString("N2");

                textBoxVectorResCylR.Text = cylRes.r.ToString("N2");
                textBoxVectorResCylF.Text = cylRes.f.ToString("N2");
                textBoxVectorResCylZ.Text = cylRes.z.ToString("N2");
            }
        }

        // Проверка на пустату текстого поля
        private void textBoxVector_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = ((TextBox)sender);

            // Проверка на пустату строки
            if (textBox.Text == String.Empty)
            {
                textBox.Text = "0";
            }
        }

        /// <summary>
        /// Добавление вектора A в список векторов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVectorAAdd_Click(object sender, EventArgs e)
        {
            vectors.Add(new Vector(Convert.ToDouble(textBoxVectorAX.Text), Convert.ToDouble(textBoxVectorAY.Text), Convert.ToDouble(textBoxVectorAZ.Text)));
            UpdateListBox();
        }

        /// <summary>
        /// Добавление вектора B в список векторов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVectorBAdd_Click(object sender, EventArgs e)
        {
            vectors.Add(new Vector(Convert.ToDouble(textBoxVectorBX.Text), Convert.ToDouble(textBoxVectorBY.Text), Convert.ToDouble(textBoxVectorBZ.Text)));
            UpdateListBox();
        }

        /// <summary>
        /// Добавление вектора Res в список векторов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVectorResAdd_Click(object sender, EventArgs e)
        {
            vectors.Add(new Vector(Convert.ToDouble(textBoxVectorResX.Text), Convert.ToDouble(textBoxVectorResY.Text), Convert.ToDouble(textBoxVectorResZ.Text)));
            UpdateListBox();
        }

        /// <summary>
        /// Получение вектора A из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVectorAGet_Click(object sender, EventArgs e)
        {
            if (listBoxVectors.SelectedIndex < 0) return;

            string[] value = listBoxVectors.GetItemText(listBoxVectors.SelectedItem).Split(';');

            textBoxVectorAX.Text = value[0];
            textBoxVectorAY.Text = value[1];
            textBoxVectorAZ.Text = value[2];
        }

        /// <summary>
        /// Получение вектора B из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVectorBGet_Click(object sender, EventArgs e)
        {
            if (listBoxVectors.SelectedIndex < 0) return;

            string[] value = listBoxVectors.GetItemText(listBoxVectors.SelectedItem).Split(';');

            textBoxVectorBX.Text = value[0];
            textBoxVectorBY.Text = value[1];
            textBoxVectorBZ.Text = value[2];
        }

        /// <summary>
        /// Удаление вектора из списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            listBoxVectors.Items.Remove(listBoxVectors.SelectedItem);
        }

        private void UpdateListBox()
        {
            listBoxVectors.Items.Clear();

            foreach (Vector v in vectors)
                listBoxVectors.Items.Add(v.x + ";" + v.y + ";" + v.z);
        }

        private void UpdateListBox(List<Vector> list)
        {
            listBoxVectors.Items.Clear();

            foreach (Vector v in list)
                listBoxVectors.Items.Add(v.x + ";" + v.y + ";" + v.z);
        }

        /// <summary>
        /// Сортирвка по возрастанию 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSortAsc_Click(object sender, EventArgs e)
        {
            List<Vector> newVectors = new List<Vector>();

            if (!asc) asc = true;
            
            IEnumerable<Vector> query = from v in vectors orderby v.x + v.y + v.z ascending select v;

            foreach(Vector v in query) newVectors.Add(v);

            vectors = newVectors;

            UpdateListBox();
        }

        /// <summary>
        /// Сортировка по убыванию
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSortDesc_Click(object sender, EventArgs e)
        {
            List<Vector> newVectors = new List<Vector>();

            if (asc) asc = false;

            IEnumerable<Vector> query = from v in vectors orderby v.x + v.y + v.z descending select v;

            foreach (Vector v in query) newVectors.Add(v);

            vectors = newVectors;

            UpdateListBox();
        }

        /// <summary>
        /// Удаление выбранного элемента
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteSelected_Click(object sender, EventArgs e)
        {
            if (listBoxVectors.SelectedIndex < 0) return;

            vectors.RemoveAt(listBoxVectors.SelectedIndex);
            UpdateListBox();
        }

        /// <summary>
        /// Удаление всех элементов списка
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            vectors.Clear();
            UpdateListBox();
        }

        /// <summary>
        /// Сортировка по X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSortByX_Click(object sender, EventArgs e)
        {
            List<Vector> newVectors = new List<Vector>();

            IEnumerable<Vector> query;

            if (asc) query = from v in vectors orderby v.x ascending select v;
            else query = from v in vectors orderby v.x descending select v;

            foreach (Vector v in query) newVectors.Add(v);

            vectors = newVectors;

            UpdateListBox();
        }

        /// <summary>
        /// Сортировка по Y
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSortByY_Click(object sender, EventArgs e)
        {
            List<Vector> newVectors = new List<Vector>();

            IEnumerable<Vector> query;

            if (asc) query = from v in vectors orderby v.y ascending select v;
            else query = from v in vectors orderby v.y descending select v;

            foreach (Vector v in query) newVectors.Add(v);

            vectors = newVectors;

            UpdateListBox();
        }

        /// <summary>
        /// Сортировка по Z
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSortByZ_Click(object sender, EventArgs e)
        {
            List<Vector> newVectors = new List<Vector>();

            IEnumerable<Vector> query;

            if (asc) query = from v in vectors orderby v.z ascending select v;
            else query = from v in vectors orderby v.z descending select v;

            foreach (Vector v in query) newVectors.Add(v);

            vectors = newVectors;

            UpdateListBox();
        }

        /// <summary>
        /// Удаление дубликатов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRemoveDublicate_Click(object sender, EventArgs e)
        {
            List<Vector> newVectors = new List<Vector>();

            IEnumerable<Vector> query = vectors.Distinct<Vector>();

            foreach (Vector v in query) newVectors.Add(v);

            vectors = newVectors;

            UpdateListBox();
        }

        /// <summary>
        /// Изменение видимости поля поиска X
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSearchX_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSearchX.Enabled = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// Изменение видимости поля поиска Y
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSearchY_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSearchY.Enabled = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// Изменение видимости поля поиска Z
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxSearchZ_CheckedChanged(object sender, EventArgs e)
        {
            textBoxSearchZ.Enabled = ((CheckBox)sender).Checked;
        }

        /// <summary>
        /// Поиск
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearch_Click(object sender, EventArgs e)
        {
            if (textBoxSearchX.Enabled || textBoxSearchY.Enabled || textBoxSearchZ.Enabled)
            {
                List<Vector> result = new List<Vector>();

                IEnumerable<Vector> query = from v in vectors select v;

                if (textBoxSearchX.Enabled) query = query.Where(v => { return v.x == Convert.ToDouble(textBoxSearchX.Text); });
                if (textBoxSearchY.Enabled) query = query.Where(v => { return v.y == Convert.ToDouble(textBoxSearchY.Text); });
                if (textBoxSearchZ.Enabled) query = query.Where(v => { return v.z == Convert.ToDouble(textBoxSearchZ.Text); });

                foreach (Vector v in query) result.Add(v);

                UpdateListBox(result);
            }
            else
            {
                MessageBox.Show("Должно быть включено хотя бы одно поле.", "Ошибка");
            }
        }

        /// <summary>
        /// Очистка результатов поиска
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSearchResultClear_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }
    }
}
