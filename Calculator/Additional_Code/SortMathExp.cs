namespace Calculator.Additional_Code
{
    public class SortMathExp
    {
        public string Sort(string input)
        {
            int found = input.LastIndexOf("^");

            string txt1 = input.Substring(found);
            txt1 = txt1.Replace("^", ",");
            string txt2 = input.Remove(found);
            input = txt2 + txt1;
            input = input.Replace(",-", ",_");

            int index1 = 0, index2 = 0;

            for (int i = 0; i < found; i++)
            {
                switch (input[i])
                {
                    case '(':
                    case ':':
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        index1 = i + 1;
                        break;
                    case 'S':
                        index1 = i + 5;
                        break;
                }
            }

            for (int i = found; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case ':':
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                        index2 = i + 4;
                        break;
                }
                if (index2 != 0)
                    break;
            }
            input = input.Insert(index1, "Pow(");
            if (index2 != 0)
                input = input.Insert(index2, ")");
            else
                input = input.Insert(input.Length, ")");
            input = input.Replace(",_", ",-");
            return input;
        }

        public string Sort2(string input)
        {
            int found = input.LastIndexOf("√");

            string txt1 = input.Substring(found);
            txt1 = txt1.Replace("√", null);
            string txt2 = input.Remove(found);
            input = txt2 + txt1;

            int index1 = 0, index2 = 0;

            for (int i = 0; i < found; i++)
            {
                switch (input[i])
                {
                    case '(':
                    case ':':
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case ',':
                    case '^':
                        index1 = i + 1;
                        break;
                }
            }

            for (int i = found; i < input.Length; i++)
            {
                switch (input[i])
                {
                    case ':':
                    case '^':
                    case '+':
                    case '-':
                    case '*':
                    case '/':
                    case ',':
                        index2 = i + 5;
                        break;
                }
                if (index2 != 0)
                    break;
            }
            input = input.Insert(index1, "Sqrt(");
            if (index2 != 0)
                input = input.Insert(index2, ")");
            else
                input = input.Insert(input.Length, ")");
            return input;
        }

        public string Sort3(string input, string id)
        {
            if (id == "Max")
                input = "Max(" + input + ")";
            if (id == "Min")
                input = "Min(" + input + ")";

            return input.Replace(":", ",");
        }
    }
}