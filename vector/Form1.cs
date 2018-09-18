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
    }
}
