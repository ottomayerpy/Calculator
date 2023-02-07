using Calculator.Properties;

namespace Calculator.Additional_Code
{
    public class ConvertInformation
    {
        public string Convert(string input, string CB2, string CB3)
        {
            bool TB2 = CB2 == "Терабайт";
            bool TB3 = CB3 == "Терабайт";
            bool GB2 = CB2 == "Гигабайт";
            bool GB3 = CB3 == "Гигабайт";
            bool MB2 = CB2 == "Мегабайт";
            bool MB3 = CB3 == "Мегабайт";
            bool KB2 = CB2 == "Килобайт";
            bool KB3 = CB3 == "Килобайт";
            bool B2 = CB2 == "Байт";
            bool B3 = CB3 == "Байт";
            bool Bi2 = CB2 == "Бит";
            bool Bi3 = CB3 == "Бит";
            bool KBi2 = CB2 == "Килобит";
            bool KBi3 = CB3 == "Килобит";
            bool MBi2 = CB2 == "Мегабит";
            bool MBi3 = CB3 == "Мегабит";
            bool GBi2 = CB2 == "Гигабит";
            bool GBi3 = CB3 == "Гигабит";
            bool TBi2 = CB2 == "Терабит";
            bool TBi3 = CB3 == "Терабит";

            double ConvertInfoDU = double.Parse(input);
            decimal ConvertInfoDC = decimal.Parse(input);

            if ((TB2 && TB3) || (GB2 && GB3) || (MB2 && MB3) || (KB2 && KB3) || (B2 && B3) || (Bi2 && Bi3) || (TBi2 && TBi3) || (GBi2 && GBi3) || (MBi2 && MBi3) || (KBi2 && KBi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = ConvertInfoDU.ToString();
                else
                    return input = ConvertInfoDC.ToString();
            }
            else if ((TB2 && GB3) || (GB2 && MB3) || (MB2 && KB3) || (KB2 && B3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 1024).ToString();
                else
                    return input = (ConvertInfoDC * 1024).ToString();
            }
            else if ((TB2 && MB3) || (GB2 && KB3) || (MB2 && B3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC * 1024 * 1024).ToString();
            }
            else if ((TB2 && KB3) || (GB2 && B3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 1024 * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC * 1024 * 1024 * 1024).ToString();
            }
            else if (TB2 && B3)
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 1024 * 1024 * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC * 1024 * 1024 * 1024 * 1024).ToString();
            }
            else if ((GB2 && TB3) || (MB2 && GB3) || (KB2 && MB3) || (B2 && KB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 1024).ToString();
                else
                    return input = (ConvertInfoDC / 1024).ToString();
            }
            else if ((MB2 && TB3) || (KB2 && GB3) || (B2 && MB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC / 1024 / 1024).ToString();
            }
            else if ((KB2 && TB3) || (B2 && GB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 1024 / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC / 1024 / 1024 / 1024).ToString();
            }
            else if (B2 && TB3)
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 1024 / 1024 / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC / 1024 / 1024 / 1024 / 1024).ToString();
            }
            else if ((TB2 && TBi3) || (GB2 && GBi3) || (MB2 && MBi3) || (KB2 && KBi3) || (B2 && Bi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8).ToString();
                else
                    return input = (ConvertInfoDC * 8).ToString();
            }
            else if ((TB2 && GBi3) || (GB2 && MBi3) || (MB2 && KBi3) || (KB2 && Bi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8 * 1024).ToString();
                else
                    return input = (ConvertInfoDC * 8 * 1024).ToString();
            }
            else if ((GB2 && TBi3) || (MB2 && GBi3) || (KB2 && MBi3) || (B2 && KBi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8 / 1024).ToString();
                else
                    return input = (ConvertInfoDC * 8 / 1024).ToString();
            }
            else if ((MB2 && TBi3) || (KB2 && GBi3) || (B2 && MBi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8 / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC * 8 / 1024 / 1024).ToString();
            }
            else if ((KB2 && TBi3) || (B2 && GBi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8 / 1024 / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC * 8 / 1024 / 1024 / 1024).ToString();
            }
            else if (B2 && TBi3)
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8 / 1024 / 1024 / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC * 8 / 1024 / 1024 / 1024 / 1024).ToString();
            }
            else if ((KBi2 && B3) || (MBi2 && KB3) || (GBi2 && MB3) || (TBi2 && GB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8 * 1024).ToString();
                else
                    return input = (ConvertInfoDC / 8 * 1024).ToString();
            }
            else if ((MBi2 && B3) || (GBi2 && KB3) || (TBi2 && MB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8 * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC / 8 * 1024 * 1024).ToString();
            }
            else if ((GBi2 && B3) || (TBi2 && KB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8 * 1024 * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC / 8 * 1024 * 1024 * 1024).ToString();
            }
            else if (TBi2 && B3)
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8 * 1024 * 1024 * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC / 8 * 1024 * 1024 * 1024 * 1024).ToString();
            }
            else if ((TB2 && MBi3) || (GB2 && KBi3) || (MB2 && Bi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8 * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC * 8 * 1024 * 1024).ToString();
            }
            else if ((TB2 && KBi3) || (GB2 && Bi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8 * 1024 * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC * 8 * 1024 * 1024 * 1024).ToString();
            }
            else if (TB2 && Bi3)
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 8 * 1024 * 1024 * 1024 * 1024).ToString();
                else
                    return input = (ConvertInfoDC * 8 * 1024 * 1024 * 1024 * 1024).ToString();
            }
            else if ((TBi2 && TB3) || (GBi2 && GB3) || (MBi2 && MB3) || (KBi2 && KB3) || (Bi2 && B3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8).ToString();
                else
                    return input = (ConvertInfoDC / 8).ToString();
            }
            else if ((GBi2 && TB3) || (MBi2 && GB3) || (KBi2 && MB3) || (Bi2 && KB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8 / 1024).ToString();
                else
                    return input = (ConvertInfoDC / 8 / 1024).ToString();
            }
            else if ((MBi2 && TB3) || (KBi2 && GB3) || (Bi2 && MB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8 / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC / 8 / 1024 / 1024).ToString();
            }
            else if ((KBi2 && TB3) || (Bi2 && GB3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8 / 1024 / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC / 8 / 1024 / 1024 / 1024).ToString();
            }
            else if (Bi2 && TB3)
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 8 / 1024 / 1024 / 1024 / 1024).ToString();
                else
                    return input = (ConvertInfoDC / 8 / 1024 / 1024 / 1024 / 1024).ToString();
            }
            else if ((TBi2 && GBi3) || (GBi2 && MBi3) || (MBi2 && KBi3) || (KBi2 && Bi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 1000).ToString();
                else
                    return input = (ConvertInfoDC * 1000).ToString();
            }
            else if ((TBi2 && MBi3) || (GBi2 && KBi3) || (MBi2 && Bi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 1000 * 1000).ToString();
                else
                    return input = (ConvertInfoDC * 1000 * 1000).ToString();
            }
            else if ((TBi2 && KBi3) || (GBi2 && Bi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 1000 * 1000 * 1000).ToString();
                else
                    return input = (ConvertInfoDC * 1000 * 1000 * 1000).ToString();
            }
            else if (TBi2 && Bi3)
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU * 1000 * 1000 * 1000 * 1000).ToString();
                else
                    return input = (ConvertInfoDC * 1000 * 1000 * 1000 * 1000).ToString();
            }
            else if ((GBi2 && TBi3) || (MBi2 && GBi3) || (KBi2 && MBi3) || (Bi2 && KBi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 1000).ToString();
                else
                    return input = (ConvertInfoDC / 1000).ToString();
            }
            else if ((MBi2 && TBi3) || (KBi2 && GBi3) || (Bi2 && MBi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 1000 / 1000).ToString();
                else
                    return input = (ConvertInfoDC / 1000 / 1000).ToString();
            }
            else if ((KBi2 && TBi3) || (Bi2 && GBi3))
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 1000 / 1000 / 1000).ToString();
                else
                    return input = (ConvertInfoDC / 1000 / 1000 / 1000).ToString();
            }
            else if (Bi2 && TBi3)
            {
                if (Settings.Default.RB4F2 == true)
                    return input = (ConvertInfoDU / 1000 / 1000 / 1000 / 1000).ToString();
                else
                    return input = (ConvertInfoDC / 1000 / 1000 / 1000 / 1000).ToString();
            }

            return "Error";
        }
    }
}
