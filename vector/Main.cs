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
        /// Вектора
        /// </summary>
        Vector a = new Vector();
        Vector b = new Vector();
        Vector r = new Vector();

        double number;

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
        /// Проверка на пустату текстого поля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBoxVector_TextChanged(object sender, EventArgs e)
        {

            {
                // Преобразование текстовых полей в вектора
                if (!(double.TryParse(tbvax.Text, out a.x)
                    && double.TryParse(tbvay.Text, out a.y)
                    && double.TryParse(tbvaz.Text, out a.z)
                    && double.TryParse(tbvbx.Text, out b.x)
                    && double.TryParse(tbvby.Text, out b.y)
                    && double.TryParse(tbvbz.Text, out b.z)
                    && double.TryParse(tbvrx.Text, out r.x)
                    && double.TryParse(tbvrx.Text, out r.y)
                    && double.TryParse(tbvrx.Text, out r.z)
                    && double.TryParse(tbn.Text, out number)))
                {
                    return;
                }

                if (radioButtonAdd.Checked) r = a + b;
                else if (radioButtonDiff.Checked) r = a - b;
                else if (radioButtonMulti.Checked) r = a * number;

                tbvrx.Text = r.x.ToString("N2");
                tbvry.Text = r.y.ToString("N2");
                tbvrz.Text = r.z.ToString("N2");

                // Вычисление модулей
                tbvam.Text = a.module.ToString("N2");
                tbvbm.Text = b.module.ToString("N2");
                tbvrm.Text = r.module.ToString("N2");

                // Проекция в декартовую системц координат
                tbvai.Text = a.x.ToString("N2");
                tbvaj.Text = a.y.ToString("N2");
                tbvak.Text = a.z.ToString("N2");

                tbvbi.Text = b.x.ToString("N2");
                tbvbj.Text = b.y.ToString("N2");
                tbvbk.Text = b.z.ToString("N2");

                tbvri.Text = r.x.ToString("N2");
                tbvrj.Text = r.y.ToString("N2");
                tbvrk.Text = r.z.ToString("N2");

                // Проекция в цилиндрическую систему координат
                tbvacr.Text = ((CylCoordsSystem)a).r.ToString("N2");
                tbvacf.Text = ((CylCoordsSystem)a).f.ToString("N2");
                tbvacz.Text = ((CylCoordsSystem)a).z.ToString("N2");

                tbvbcr.Text = ((CylCoordsSystem)b).r.ToString("N2");
                tbvbcf.Text = ((CylCoordsSystem)b).f.ToString("N2");
                tbvbcz.Text = ((CylCoordsSystem)b).z.ToString("N2");

                tbvrcr.Text = ((CylCoordsSystem)r).r.ToString("N2");
                tbvrcf.Text = ((CylCoordsSystem)r).f.ToString("N2");
                tbvrcz.Text = ((CylCoordsSystem)r).z.ToString("N2");
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
                tbn.Enabled = true;
            }
            else
            {
                groupBoxVectorB.Enabled = true;
                tbn.Enabled = false;
            }
        }

        /// <summary>
        /// Добавление вектора A в список векторов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVectorAAdd_Click(object sender, EventArgs e)
        {
            vectors.Add(new Vector(Convert.ToDouble(tbvax.Text), Convert.ToDouble(tbvay.Text), Convert.ToDouble(tbvaz.Text)));
            UpdateListBox();
        }

        /// <summary>
        /// Добавление вектора B в список векторов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVectorBAdd_Click(object sender, EventArgs e)
        {
            vectors.Add(new Vector(Convert.ToDouble(tbvbx.Text), Convert.ToDouble(tbvby.Text), Convert.ToDouble(tbvbz.Text)));
            UpdateListBox();
        }

        /// <summary>
        /// Добавление вектора Res в список векторов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVectorResAdd_Click(object sender, EventArgs e)
        {
            vectors.Add(new Vector(Convert.ToDouble(tbvrx.Text), Convert.ToDouble(tbvry.Text), Convert.ToDouble(tbvrz.Text)));
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

            tbvax.Text = value[0].Trim();
            tbvay.Text = value[1].Trim();
            tbvaz.Text = value[2].Trim();
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

            tbvbx.Text = value[0].Trim();
            tbvby.Text = value[1].Trim();
            tbvbz.Text = value[2].Trim();
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

        /// <summary>
        /// Обновление списка векторов
        /// </summary>
        private void UpdateListBox()
        {
            listBoxVectors.Items.Clear();

            foreach (Vector v in vectors)
                listBoxVectors.Items.Add(v.ToString());
        }

        /// <summary>
        /// Обновление списка векторов
        /// </summary>
        /// <param name="list"></param>
        private void UpdateListBox(List<Vector> list)
        {
            listBoxVectors.Items.Clear();

            foreach (Vector v in list)
                listBoxVectors.Items.Add(v.ToString());
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
                List<Vector> r = new List<Vector>();

                IEnumerable<Vector> query = from v in vectors select v;

                if (textBoxSearchX.Enabled) query = query.Where(v => { return v.x == Convert.ToDouble(textBoxSearchX.Text); });
                if (textBoxSearchY.Enabled) query = query.Where(v => { return v.y == Convert.ToDouble(textBoxSearchY.Text); });
                if (textBoxSearchZ.Enabled) query = query.Where(v => { return v.z == Convert.ToDouble(textBoxSearchZ.Text); });

                foreach (Vector v in query) r.Add(v);

                UpdateListBox(r);
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
        private void buttonSearchrClear_Click(object sender, EventArgs e)
        {
            UpdateListBox();
        }

        /// <summary>
        /// Поиск спектра векторов в заданных значения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSpectorSearch_Click(object sender, EventArgs e)
        {
            List<Vector> list = new List<Vector>();

            IEnumerable<Vector> query = from v in vectors
                                        where v.module >= Convert.ToDouble(textBoxR1.Text) && v.module <= Convert.ToDouble(textBoxR2.Text)
                                            && ((CylCoordsSystem)v).f >= Convert.ToDouble(textBoxF1.Text) && ((CylCoordsSystem)v).f <= Convert.ToDouble(textBoxF2.Text)
                                        select v;

            foreach (Vector v in query) list.Add(v);

            UpdateListBox(list);
        }
    }
}
