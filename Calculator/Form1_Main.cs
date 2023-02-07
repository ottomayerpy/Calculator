using System;
using System.Drawing;
using System.Windows.Forms;
using Calculator.Properties;
using Calculator.Additional_Code;

namespace Calculator
{
    public partial class Form1_Main : Form
    {
        public Form1_Main()
        {
            InitializeComponent();
            Width = 275;
            Height = 279;
            PanelCalc.Location = new Point(2, 16);
            LabelNumber.Text = null;
            LabelDecision.Text = null;
            richTextBox.Text = Settings.Default.History;
            ComboBox1.SelectedItem = "Информация";
            AddHandlersToControls();
        }

        private void NumberFont()
        {
            ButtonUnFocus.Focus();

            LabelNumber.Font = LabelNumber.Text.Length >= 15
             ? new Font("Segoe UI", 10, FontStyle.Regular)
             : new Font("Segoe UI", 14, FontStyle.Regular);

            if (LabelNumber.Text.Length >= 25)
                LabelNumber.Font = new Font("Segoe UI", 8, FontStyle.Regular);

            if (LabelNumber.Text == "")
                LabelNumber.Text = null;
        }

        private void ButtonsNumber_Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag.ToString()) // При нажатии перечисленных кейсов, ноль не стирается
            {
                case "<<<":
                    LabelNumber.Text = ClearOne(LabelNumber.Text);
                    break;
                case "+":
                case "-":
                case "*":
                case "/":
                case "^":
                case ".":
                    break;
                default:
                    if (LabelNumber.Text == "0" || LabelNumber.Text == "-0")
                        LabelNumber.Text = null;
                    break;
            }

            if (((Button)sender).Tag.ToString() != "<<<")
            {
                if (LabelNumber.Text.Contains("|"))
                    LabelNumber.Text = LabelNumber.Text.Insert(LabelNumber.Text.IndexOf("|"), ((Button)sender).Tag.ToString());
                else
                    LabelNumber.Text += ((Button)sender).Tag.ToString();
            }

            if (Settings.Default.CB3F2 == true)
            {
                try // Удаление повторяющихся знаков
                {
                    string[] chars = {
                        "++",  "-+",  "*+",  "/+",  "^+",  ".+",  "%+", "√+",  "(+",        "+)",
                        "+--", "---", "*--", "/--", "^--", ".-",  "%-", "√--", "(--",       "--)",
                        "+*",  "-*",  "**",  "/*",  "^*",  ".*",  "%*", "√*",  "(*",        "*)",
                        "+/",  "-/",  "*/",  "//",  "^/",  "./",  "%/", "√/",  "(/",        "/)",
                        "+^",  "-^",  "*^",  "/^",  "^^",  ".^",  "%^", "√^",  "(^",        "^)",
                        "+.",  "-.",  "*.",  "/.",  "^.",  "..",  "%.", "√.",  "(.",  ").", ".)",
                        "+%",  "-%",  "*%",  "/%",  "^%",  ".%",  "%%", "√%",  "(%",  ")%", "%)",
                                                                  ".√",  "%√", "√√",  "((",  ")√", ":)",
                        ")0",  ")1", ")2", ")3", ")4", ")5", ")6", ")7", ")8", ")9",  "()",  "))",
                        "0(",  "1(", "2(", "3(", "4(", "5(", "6(", "7(", "8(", "9(",         ")(",
                    };

                    foreach (string q in chars)
                    {
                        if (LabelNumber.Text.Contains(q))
                        {
                            LabelNumber.Text = LabelNumber.Text.Remove(LabelNumber.Text.IndexOf(q), q.Length);
                            LabelNumber.Text += ((Button)sender).Tag.ToString();
                        }
                    }
                }
                catch { }

                string[] math = { "+", "-", "*", "/", "^", "√", "%", "(", ")", "." };
                foreach (string w in math)
                {
                    if ((LabelNumber.Text.Contains("!") && LabelNumber.Text.Contains(w)) || LabelNumber.Text == "!")
                        ButtonClearOne.PerformClick();
                }

                if ((LabelNumber.Text.Contains(")") && !LabelNumber.Text.Contains("(")) || (LabelNumber.Text.Contains("%") && LabelNumber.Text.Contains("√")))
                    ButtonClearOne.PerformClick();
            }
            NumberFont();
        }

        private void ButtonEq_Click(object sender, EventArgs e)
        {
            string Eq = LabelNumber.Text.Replace("|", null);
            Eq = Eq.Replace(",", ".");
            string EqAJ = null;

            if (Eq.Contains("^") || Eq.Contains("√") || Eq.Contains(":")) // Анализ и сортировка математических выражений
            {
                EqAJ = Eq;
                SortMathExp a = new SortMathExp();

                while (Eq.Contains("^"))
                    Eq = a.Sort(Eq);
                while (Eq.Contains("√"))
                    Eq = a.Sort2(Eq);
            }

            if (Eq.Contains("%")) // Вычисление процентов
            {
                EqAJ = Eq;
                PercentCalculate a = new PercentCalculate();
                Eq = a.Percent(Eq);
            }

            if (Eq.Contains("!")) // Вычисление факториала
            {
                try
                {
                    EqAJ = Eq;
                    FactorialCalculate a = new FactorialCalculate();
                    Eq = a.Factorial(Convert.ToInt64(Eq.Replace("!", null))).ToString();
                }
                catch
                {
                    LabelDecision.Text = "Ошибка!";
                }
            }
            else // Вычисление всего остального
            {
                try
                {
                    EqAJ = Eq;
                    NCalc.Expression exp = new NCalc.Expression(Eq);
                    Eq = exp.Evaluate().ToString();
                }
                catch
                {
                    LabelDecision.Text = "Ошибка!";
                }
            }
            
            try
            {
                if (Settings.Default.CB1F2 == true && Eq != "Ошибка!") // Сортировка чисел по разрядам (решения)
                {
                    bool bDrobSort = false;
                    string sDrobSort = null;

                    if (Eq.Contains("."))
                    {
                        sDrobSort = Eq.Substring(Eq.IndexOf("."));
                        Eq = Eq.Remove(Eq.IndexOf("."));
                        bDrobSort = true;
                    }

                    switch (Eq.Length)
                    {
                        case 4:
                            SortNumber(1, true);
                            break;
                        case 5:
                            SortNumber(2, true);
                            break;
                        case 6:
                            SortNumber(3, true);
                            break;
                        case 7:
                            SortNumber(1, true);
                            SortNumber(5, false);
                            break;
                        case 8:
                            SortNumber(2, true);
                            SortNumber(6, false);
                            break;
                        case 9:
                            SortNumber(3, true);
                            SortNumber(7, false);
                            break;
                        case 10:
                            SortNumber(1, true);
                            SortNumber(5, false);
                            SortNumber(9, false);
                            break;
                        default:
                            if (!Eq.Contains("Неверное"))
                                Eq = Eq.Replace(" ", null);
                            break;
                    }
                    if (bDrobSort == true)
                        Eq += sDrobSort;
                }

                if (Settings.Default.CB4F2 == true && Eq != "Ошибка!" && Eq.Contains("."))
                {
                    Eq = Eq.Remove(Eq.IndexOf(".") + 3);
                }
            }
            catch { }

            if (LabelDecision.Text != "Ошибка!")
                LabelDecision.Text = Eq;
            Settings.Default.History = richTextBox.Text;

            if (Settings.Default.CB5F2 == true)
                richTextBox.Text = Settings.Default.History += EqAJ + " = " + LabelDecision.Text + "\n--------------------------------------------------------------\n";
            else
                richTextBox.Text = Settings.Default.History += LabelNumber.Text.Replace("|", null) + " = " + LabelDecision.Text + "\n--------------------------------------------------------------\n";

            NumberFont();
        }

        private void ButtonEqCopyInNumber_Click(object sender, EventArgs e)
        {
            if (LabelNumber.Text == "0" || LabelNumber.Text == "-0")
                LabelNumber.Text = null;

            LabelNumber.Text += LabelDecision.Text.Replace(" ", null);
            NumberFont();
        }

        private void SortNumber(byte a, bool b)
        {
            try
            {
                if (b == true)
                    LabelDecision.Text = LabelDecision.Text.Replace(" ", null);

                LabelDecision.Text = LabelDecision.Text.Insert(a, " ");
            }
            catch { }
        }

        private string ClearOne(string input)
        {
            int lenght = input.Length - 1;
            string text = input;
            input = null;

            for (int i = 0; i < lenght; i++)
                input = input + text[i];

            NumberFont();

            return input;
        }

        private void ButtonClearNumber_Click(object sender, EventArgs e)
        {
            LabelNumber.Text = null;
            NumberFont();
        }

        private void ButtonClearFull_Click(object sender, EventArgs e)
        {
            LabelDecision.Text = null;
            LabelNumber.Text = null;
            NumberFont();
        }

        private void ToolHelpHotKey_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
" Backspace - Чистит один символ \n Insert - Чистит основное поле \n Delete - Чистит все поля",
"Горячие клавиши",
MessageBoxButtons.OK,
MessageBoxIcon.Information);
        }

        private void ToolHelpPercent_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
"Примеры вычисления процентов: \n\n" +
"Прибавить 35% к числу 487 ?\n Как вычислять: 487 + 35% \n\n" +
"Вычесть 17% из числа 229 ?\n Как вычислять: 229 - 17% \n\n" +
"Какое число соответствует 23% от числа 857 ?\n Как вычислять: 857 * 23% \n\n" +
"Сколько составляет 24% от числа 248 ?\n Как вычислять: 248 / 24% \n\n" +
"Сколько процентов составляет число 7 от числа 30 ?\n Как вычислять: 7%30 \n\n",
"Вычесление процентов",
MessageBoxButtons.OK,
MessageBoxIcon.Information);
        }

        private void ToolMenuSettings_Click(object sender, EventArgs e)
        {
            new Form2_Settings().ShowDialog();
        }

        private void ToolViewOpenItem_Click(object sender, EventArgs e)
        {
            if (ToolViewConverter.Checked == true && ToolViewHistory.Checked == false)
            {
                for (; Width < 628; Width += 4) { }
                if (Width != 628)
                {
                    for (; Width > 628; Width -= 4) { }
                    PanelCalc.Location = new Point(2, 16);
                }
                BoxConverter.Location = new Point(259, 18);
            }
            else if (ToolViewHistory.Checked == true && ToolViewConverter.Checked == false)
            {
                for (; Width < 540; Width += 4) { }
                if (Width != 540)
                {
                    for (; Width > 540; Width -= 4) { }
                }
                PanelHistory.Location = new Point(0, 25);
                PanelCalc.Location = new Point(267, 16);
            }
            else if (ToolViewHistory.Checked == true && ToolViewConverter.Checked == true)
            {
                for (; Width < 891; Width += 4) { }
                PanelHistory.Location = new Point(0, 25);
                PanelCalc.Location = new Point(267, 16);
                BoxConverter.Location = new Point(524, 18);
            }
            else if (ToolViewConverter.Checked == false && ToolViewHistory.Checked == false)
            {
                for (; Width > 275; Width -= 4) { }
                PanelCalc.Location = new Point(2, 16);
                
            }

            if (ToolViewConverter.Checked == true)
                BoxConverter.Visible = true;
            else
                BoxConverter.Visible = false;

            if (ToolViewHistory.Checked == true)
                PanelHistory.Visible = true;
            else
                PanelHistory.Visible = false;
        }

        private void Main_KeyDown(object sender, KeyEventArgs e)
        {
            if (!TextBoxInput.Focused && !richTextBox.Focused)
            {
                if (e.KeyCode == Keys.D1 | e.KeyCode == Keys.NumPad1)   Button1.PerformClick();
                if (e.KeyCode == Keys.D2 | e.KeyCode == Keys.NumPad2)   Button2.PerformClick();
                if (e.KeyCode == Keys.D3 | e.KeyCode == Keys.NumPad3)   Button3.PerformClick();
                if (e.KeyCode == Keys.D4 | e.KeyCode == Keys.NumPad4)   Button4.PerformClick();
                if (e.KeyCode == Keys.D5 | e.KeyCode == Keys.NumPad5)   Button5.PerformClick();
                if (e.KeyCode == Keys.D6 | e.KeyCode == Keys.NumPad6)   Button6.PerformClick();
                if (e.KeyCode == Keys.D7 | e.KeyCode == Keys.NumPad7)   Button7.PerformClick();
                if (e.KeyCode == Keys.D8 | e.KeyCode == Keys.NumPad8)   Button8.PerformClick();
                if (e.KeyCode == Keys.D9 | e.KeyCode == Keys.NumPad9)   Button9.PerformClick();
                if (e.KeyCode == Keys.D0 | e.KeyCode == Keys.NumPad0)   Button0.PerformClick();
                if (e.KeyCode == Keys.Add)                              ButtonPlus.PerformClick();
                if (e.KeyCode == Keys.Subtract)                         ButtonMinus.PerformClick();
                if (e.KeyCode == Keys.Multiply)                         ButtonMult.PerformClick();
                if (e.KeyCode == Keys.Divide)                           ButtonDiv.PerformClick();
                if (e.KeyCode == Keys.Decimal)                          ButtonPoint.PerformClick();
                if (e.KeyCode == Keys.Insert)                           ButtonClearNumber.PerformClick();
                if (e.KeyCode == Keys.Delete)                           ButtonClearFull.PerformClick();
                if (e.KeyCode == Keys.C && e.Modifiers == Keys.Control) ToolEditCopy.PerformClick();
                if (e.KeyCode == Keys.V && e.Modifiers == Keys.Control) ToolEditPaste.PerformClick();
                if (e.KeyCode == Keys.Left)                             DividingStripL();
                if (e.KeyCode == Keys.Right)                            DividingStripR();
                if (e.KeyCode == Keys.Enter) ButtonEq.PerformClick();

                if (e.KeyCode == Keys.Back && LabelNumber.Text.Contains("|"))
                {
                    try
                    {
                        LabelNumber.Text = LabelNumber.Text.Remove(LabelNumber.Text.IndexOf("|") - 1, 1);
                    }
                    catch { }

                    if (LabelNumber.Text == "|")
                        LabelNumber.Text = null;
                }
                else if (e.KeyCode == Keys.Back)
                    ButtonClearOne.PerformClick();
            }
        }

        private void AddHandlersToControls()
        {
            foreach (Control control in Controls)
                control.PreviewKeyDown += new PreviewKeyDownEventHandler(Form1_Main_PreviewKeyDown);
        }

        private void DividingStripL()
        {
            try
            {
                if (LabelNumber.Text.Contains("|"))
                {
                    int a = LabelNumber.Text.IndexOf("|");
                    LabelNumber.Text = LabelNumber.Text.Replace("|", "");
                    LabelNumber.Text = LabelNumber.Text.Insert(a - 1, "|");
                }
            }
            catch { }
        }

        private void DividingStripR()
        {
            try
            {
                if (LabelNumber.Text.Contains("|"))
                {
                    int a = LabelNumber.Text.IndexOf("|");
                    LabelNumber.Text = LabelNumber.Text.Replace("|", "");
                    LabelNumber.Text = LabelNumber.Text.Insert(a + 1, "|");
                }
            }
            catch { }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox2.Enabled = true;
            ComboBox2.Items.Clear();
            ComboBox3.Items.Clear();
            TextBoxInput.Text = TextBoxOutput.Text = null;

            if (ComboBox1.Text == "Информация")
            {
                object[] items = { "Терабайт", "Гигабайт", "Мегабайт", "Килобайт", "Байт", "Бит",
                "Килобит", "Мегабит", "Гигабит", "Терабит"};
                ComboBox2.Items.AddRange(items);
                ComboBox3.Items.AddRange(items);
                ComboBox2.Text = "Гигабайт";
                ComboBox3.Text = "Мегабайт";
            }

            if (ComboBox1.Text == "Время")
            {
                object[] items = { "Век", "Год", "Месяц", "Декада", "Неделя", "Сутки", "Час", "Минута", "Секунда", "Миллисекунда", "Микросекунда", "Наносекунда" };
                ComboBox2.Items.AddRange(items);
                ComboBox3.Items.AddRange(items);
                ComboBox2.Text = "Час";
                ComboBox3.Text = "Минута";
            }

            if (ComboBox1.Text == "Системы счисления")
            {
                object[] items = { "Двоичная система счисления", "Восьмеричная система счисления", "Шестнадцатеричная система счисления"};
                object[] item = { "Десятичная система счисления" };
                ComboBox2.Enabled = false;
                ComboBox2.Items.AddRange(item);
                ComboBox3.Items.AddRange(items);
                ComboBox2.Text = "Десятичная система счисления";
                ComboBox3.Text = "Двоичная система счисления";
            }
        }

        private void ToolEditPaste_Click(object sender, EventArgs e)
        {
            if (!TextBoxInput.Focused && !TextBoxOutput.Focused && !richTextBox.Focused)
            {
                if (LabelNumber.Text == "0")
                    LabelNumber.Text = null;

                LabelNumber.Text += Clipboard.GetText();
            }
        }

        private void ToolEditCopy_Click(object sender, EventArgs e)
        {
            if (!TextBoxInput.Focused && !TextBoxOutput.Focused && !richTextBox.Focused)
            {
                try
                {
                    if (Settings.Default.RB2F2 == true)
                        Clipboard.SetText(LabelNumber.Text);
                    else if (Settings.Default.RB3F2 == true)
                        Clipboard.SetText(LabelNumber.Text + " = " + LabelDecision.Text.Replace(" ", null));
                    else
                        Clipboard.SetText(LabelDecision.Text.Replace(" ", null));
                }
                catch { }
            }
        }

        private void SelectConvert(object sender, EventArgs e)
        {
            if (ComboBox1.Text == "Информация")
                ConvertInformation();

            if (ComboBox1.Text == "Время")
                ConvertTime();

            if (ComboBox1.Text == "Системы счисления")
                ConvertNumberSystem();

            if ((TextBoxOutput.Text == "бесконечность") || (TextBoxOutput.Text == "∞"))
                TextBoxInput.Text = null;
        }

        private void ConvertNumberSystem()
        {
            try
            {
                if (TextBoxInput.Text != "")
                {
                    switch (ComboBox3.Text)
                    {
                        case "Двоичная система счисления":
                            TextBoxOutput.Text = Convert.ToString(Convert.ToInt32(TextBoxInput.Text), 2);
                            break;
                        case "Восьмеричная система счисления":
                            TextBoxOutput.Text = Convert.ToString(Convert.ToInt32(TextBoxInput.Text), 8);
                            break;
                        case "Шестнадцатеричная система счисления":
                            TextBoxOutput.Text = Convert.ToString(Convert.ToInt32(TextBoxInput.Text), 16);
                            break;
                    }
                }
                else
                    TextBoxOutput.Text = null;
            }
            catch
            {
                TextBoxInput.Text = ClearOne(TextBoxInput.Text);
                TextBoxInput.Focus();
            }
        }

        private void ConvertTime()
        {
            try
            {
                if (TextBoxInput.Text != "") // Чтобы не вылезла ошибка, когда textBoxInput пуст
                {
                    ConvertTime z = new ConvertTime();
                    TextBoxOutput.Text = z.Convert(Convert.ToDouble(TextBoxInput.Text), ComboBox2.Text, ComboBox3.Text).ToString();
                }
                else
                    TextBoxOutput.Text = null;
            }
            catch
            {
                TextBoxInput.Text = ClearOne(TextBoxInput.Text);
                TextBoxInput.Focus();
            }
        }

        private void ConvertInformation()
        {
            try
            {
                if (TextBoxInput.Text != "") // Чтобы не вылезла ошибка, когда textBoxInput пуст
                {
                    ConvertInformation a = new ConvertInformation();
                    TextBoxOutput.Text = a.Convert(TextBoxInput.Text, ComboBox2.Text, ComboBox3.Text);
                }
                else
                    TextBoxOutput.Text = null;
            }
            catch
            {
                TextBoxInput.Text = ClearOne(TextBoxInput.Text);
                TextBoxInput.Focus();
            }
        }

        private void Form1_Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Settings.Default.CB2F2 == true)
                Settings.Default.History = null;

            if (Settings.Default.CB2F2 == false)
                Settings.Default.History = richTextBox.Text;

            Settings.Default.Save();
        }

        private void LabelNumber_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(LabelNumber, LabelNumber.Text);
        }

        private void LabelDecision_MouseHover(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(LabelDecision, LabelDecision.Text);
        }

        private void LabelNumber_Click(object sender, EventArgs e)
        {
            if (!LabelNumber.Text.Contains("|"))
                LabelNumber.Text += "|";
            else
                LabelNumber.Text = LabelNumber.Text.Replace("|", "");
        }

        private void Form1_Main_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;
        }
    }
}