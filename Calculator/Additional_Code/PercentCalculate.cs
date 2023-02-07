namespace Calculator.Additional_Code
{
    public class PercentCalculate
    {
        public string Percent(string text)
        {
            string number = null, percent = null, math = null, result = null;
            int indexNum = 0;

            try
            {
                char[] chars = { '+', '-', '*', '/' };

                foreach (char q in chars)
                {
                    if (text.Contains(q.ToString()))
                    {
                        math = q.ToString();
                    }
                }

                if (math != null)
                {
                    text = text.Replace("%", null);
                    indexNum = text.IndexOf(math);
                    number = text.Remove(indexNum);
                    percent = text.Substring(indexNum + 1);

                    switch (math)
                    {
                        case "+":
                            result = number + "/100*" + percent + "+" + number;
                            break;
                        case "-":
                            result = number + "-" + number + "/100*" + percent;
                            break;
                        case "*":
                            result = number + "/100*" + percent;
                            break;
                        case "/":
                            result = "100/(" + number + "/" + percent + ")";
                            break;
                    }
                }
                else
                {
                    indexNum = text.IndexOf("%");
                    number = text.Remove(indexNum);
                    percent = text.Substring(indexNum + 1);
                    text = text.Replace("%", null);

                    result = "100*" + number + "/" + percent;
                }
            }
            catch { return "Ошибка!"; }

            return result;
        }
    }
}
