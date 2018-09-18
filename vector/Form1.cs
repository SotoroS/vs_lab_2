using System;
using System.Windows.Forms;

using lib;

namespace vector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        // Проверка введенных значений в поля формы
        private void textBoxCoord_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;

            if (!Char.IsDigit(number) && number != 8 && number != 44) // цифры, клавиша BackSpace и запятая
            {
                e.Handled = true;
            }
        }

        private void radioButtonMulti_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
            {
                groupBoxVectorB.Visible = false;
                groupBoxNumber.Visible = true;
                groupBoxNumber.BringToFront();
            }
            else
            {
                groupBoxNumber.Visible = false;
                groupBoxVectorB.Visible = true;
                groupBoxVectorB.BringToFront();
            }

        }

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

                textBoxVectorResX.Text = result.x.ToString();
                textBoxVectorResY.Text = result.y.ToString();
                textBoxVectorResZ.Text = result.z.ToString();

                // Вычисление модулей
                textBoxVectorAModule.Text = a.module.ToString();
                textBoxVectorBModule.Text = b.module.ToString();
                textBoxVectorResModule.Text = result.module.ToString();

                // Проекция в декартовую систему координат
                DecartCoordsSystem decartA = new DecartCoordsSystem(a);
                DecartCoordsSystem decartB = new DecartCoordsSystem(b);
                DecartCoordsSystem decartRes = new DecartCoordsSystem(result);

                textBoxVectorAI.Text = decartA.i.ToString();
                textBoxVectorAJ.Text = decartA.j.ToString();
                textBoxVectorAK.Text = decartA.k.ToString();

                textBoxVectorBI.Text = decartB.i.ToString();
                textBoxVectorBJ.Text = decartB.j.ToString();
                textBoxVectorBK.Text = decartB.k.ToString();

                textBoxVectorResI.Text = decartRes.i.ToString();
                textBoxVectorResJ.Text = decartRes.j.ToString();
                textBoxVectorResK.Text = decartRes.k.ToString();

                // Проекция в цилиндрическую систему координат
                CyrCoordsSystem cylA = new CyrCoordsSystem(a);
                CyrCoordsSystem cylB = new CyrCoordsSystem(b);
                CyrCoordsSystem cylRes = new CyrCoordsSystem(result);

                textBoxVectorACylR.Text = cylA.r.ToString();
                textBoxVectorACylF.Text = cylA.f.ToString();
                textBoxVectorACylZ.Text = cylA.z.ToString();

                textBoxVectorBCylR.Text = cylB.r.ToString();
                textBoxVectorBCylF.Text = cylB.f.ToString();
                textBoxVectorBCylZ.Text = cylB.z.ToString();

                textBoxVectorResCylR.Text = cylRes.r.ToString();
                textBoxVectorResCylF.Text = cylRes.f.ToString();
                textBoxVectorResCylZ.Text = cylRes.z.ToString();
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

                textBoxVectorResX.Text = result.x.ToString();
                textBoxVectorResY.Text = result.y.ToString();
                textBoxVectorResZ.Text = result.z.ToString();

                // Вычисление модулей
                textBoxVectorAModule.Text = a.module.ToString();
                textBoxVectorBModule.Text = b.module.ToString();
                textBoxVectorResModule.Text = result.module.ToString();

                // Проекция в декартовую систему координат
                DecartCoordsSystem decartA = new DecartCoordsSystem(a);
                DecartCoordsSystem decartB = new DecartCoordsSystem(b);
                DecartCoordsSystem decartRes = new DecartCoordsSystem(result);

                textBoxVectorAI.Text = decartA.i.ToString();
                textBoxVectorAJ.Text = decartA.j.ToString();
                textBoxVectorAK.Text = decartA.k.ToString();

                textBoxVectorBI.Text = decartB.i.ToString();
                textBoxVectorBJ.Text = decartB.j.ToString();
                textBoxVectorBK.Text = decartB.k.ToString();

                textBoxVectorResI.Text = decartRes.i.ToString();
                textBoxVectorResJ.Text = decartRes.j.ToString();
                textBoxVectorResK.Text = decartRes.k.ToString();

                // Проекция в цилиндрическую систему координат
                CyrCoordsSystem cylA = new CyrCoordsSystem(a);
                CyrCoordsSystem cylB = new CyrCoordsSystem(b);
                CyrCoordsSystem cylRes = new CyrCoordsSystem(result);

                textBoxVectorACylR.Text = cylA.r.ToString();
                textBoxVectorACylF.Text = cylA.f.ToString();
                textBoxVectorACylZ.Text = cylA.z.ToString();

                textBoxVectorBCylR.Text = cylB.r.ToString();
                textBoxVectorBCylF.Text = cylB.f.ToString();
                textBoxVectorBCylZ.Text = cylB.z.ToString();

                textBoxVectorResCylR.Text = cylRes.r.ToString();
                textBoxVectorResCylF.Text = cylRes.f.ToString();
                textBoxVectorResCylZ.Text = cylRes.z.ToString();
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

                textBoxVectorResX.Text = result.x.ToString();
                textBoxVectorResY.Text = result.y.ToString();
                textBoxVectorResZ.Text = result.z.ToString();

                // Вычисление модулей
                textBoxVectorAModule.Text = a.module.ToString();
                textBoxVectorResModule.Text = result.module.ToString();

                // Проекция в декартовую систему координат
                DecartCoordsSystem decartA = new DecartCoordsSystem(a);
                DecartCoordsSystem decartRes = new DecartCoordsSystem(result);

                textBoxVectorAI.Text = decartA.i.ToString();
                textBoxVectorAJ.Text = decartA.j.ToString();
                textBoxVectorAK.Text = decartA.k.ToString();

                textBoxVectorResI.Text = decartRes.i.ToString();
                textBoxVectorResJ.Text = decartRes.j.ToString();
                textBoxVectorResK.Text = decartRes.k.ToString();

                // Проекция в цилиндрическую систему координат
                CyrCoordsSystem cylA = new CyrCoordsSystem(a);
                CyrCoordsSystem cylRes = new CyrCoordsSystem(result);

                textBoxVectorACylR.Text = cylA.r.ToString();
                textBoxVectorACylF.Text = cylA.f.ToString();
                textBoxVectorACylZ.Text = cylA.z.ToString();

                textBoxVectorResCylR.Text = cylRes.r.ToString();
                textBoxVectorResCylF.Text = cylRes.f.ToString();
                textBoxVectorResCylZ.Text = cylRes.z.ToString();
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
    }
}
