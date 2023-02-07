namespace Calculator.Additional_Code
{
    public class ConvertTime
    {
        public double Convert(double time, string CB2, string CB3)
        {
            switch (CB2) //ComboBox2
            {
                case "Век":
                    switch (CB3) //ComboBox3
                    {
                        case "Век":
                            return time; // Value
                        case "Год":
                            return time * 99.99999999999999;
                        case "Месяц":
                            return time * 1216.6666666832132;
                        case "Декада":
                            return time * 10;
                        case "Неделя":
                            return time * 5214.285714356629;
                        case "Сутки":
                            return time * 36500.000000496395;
                        case "Час":
                            return time * 876000.0000119135;
                        case "Минута":
                            return time * 52560000.00071481;
                        case "Секунда":
                            return time * 3153600000.0428886;
                        case "Миллисекунда":
                            return time * 3153600000042.8887;
                        case "Микросекунда":
                            return time * 3153600000042888.5;
                        case "Наносекунда":
                            return time * 3153600000042888700;
                    }
                    break;

                case "Год":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 0.01;
                        case "Год":
                            return time;
                        case "Месяц":
                            return time * 12.166666666832132;
                        case "Декада":
                            return time * 0.1;
                        case "Неделя":
                            return time * 52.14285714356629;
                        case "Сутки":
                            return time * 365.00000000496397;
                        case "Час":
                            return time * 8760.000000119137;
                        case "Минута":
                            return time * 525600.0000071481;
                        case "Секунда":
                            return time * 31536000.00042889;
                        case "Миллисекунда":
                            return time * 31536000000.42889;
                        case "Микросекунда":
                            return time * 31536000000428.89;
                        case "Наносекунда":
                            return time * 31536000000428892;
                    }
                    break;

                case "Месяц":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 0.0008219178082080001;
                        case "Год":
                            return time * 0.0821917808208;
                        case "Месяц":
                            return time;
                        case "Декада":
                            return time * 0.008219178082080001;
                        case "Неделя":
                            return time * 4.2857142857142865;
                        case "Сутки":
                            return time * 30.000000000000004;
                        case "Час":
                            return time * 720.0000000000001;
                        case "Минута":
                            return time * 43200.00000000001;
                        case "Секунда":
                            return time * 2592000.0000000005;
                        case "Миллисекунда":
                            return time * 2592000000.0000005;
                        case "Микросекунда":
                            return time * 2592000000000.0005;
                        case "Наносекунда":
                            return time * 2592000000000000.5;
                    }
                    break;

                case "Декада":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 0.1;
                        case "Год":
                            return time * 10;
                        case "Месяц":
                            return time * 121.66666666832131;
                        case "Декада":
                            return time;
                        case "Неделя":
                            return time * 521.4285714356629;
                        case "Сутки":
                            return time * 3650.0000000496398;
                        case "Час":
                            return time * 87600.00000119135;
                        case "Минута":
                            return time * 5256000.000071482;
                        case "Секунда":
                            return time * 315360000.0042889;
                        case "Миллисекунда":
                            return time * 315360000004.2889;
                        case "Микросекунда":
                            return time * 315360000004288.9;
                        case "Наносекунда":
                            return time * 315360000004288900;
                    }
                    break;

                case "Неделя":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 0.0001917808219152;
                        case "Год":
                            return time * 0.019178082191519997;
                        case "Месяц":
                            return time * 0.23333333333333328;
                        case "Декада":
                            return time * 0.001917808219152;
                        case "Неделя":
                            return time;
                        case "Сутки":
                            return time * 6.999999999999999;
                        case "Час":
                            return time * 167.99999999999997;
                        case "Минута":
                            return time * 10080;
                        case "Секунда":
                            return time * 604800;
                        case "Миллисекунда":
                            return time * 604800000;
                        case "Микросекунда":
                            return time * 604800000000;
                        case "Наносекунда":
                            return time * 604800000000000;
                    }
                    break;

                case "Сутки":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 0.000027397260273600004;
                        case "Год":
                            return time * 0.00273972602736;
                        case "Месяц":
                            return time * 0.03333333333333333;
                        case "Декада":
                            return time * 0.00027397260273600004;
                        case "Неделя":
                            return time * 0.14285714285714;
                        case "Сутки":
                            return time;
                        case "Час":
                            return time * 24;
                        case "Минута":
                            return time * 1440;
                        case "Секунда":
                            return time * 86400;
                        case "Миллисекунда":
                            return time * 86400000;
                        case "Микросекунда":
                            return time * 86400000000;
                        case "Наносекунда":
                            return time * 86400000000000;
                    }
                    break;

                case "Час":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 0.0000011415525114;
                        case "Год":
                            return time * 0.00011415525114;
                        case "Месяц":
                            return time * 0.0013888888888888887;
                        case "Декада":
                            return time * 0.000011415525114;
                        case "Неделя":
                            return time * 0.005952380952380953;
                        case "Сутки":
                            return time * 0.041666666666666664;
                        case "Час":
                            return time;
                        case "Минута":
                            return time * 60;
                        case "Секунда":
                            return time * 3600;
                        case "Миллисекунда":
                            return time * 3600000;
                        case "Микросекунда":
                            return time * 3600000000;
                        case "Наносекунда":
                            return time * 3600000000000;
                    }
                    break;

                case "Минута":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 1.9025875190000003e-8;
                        case "Год":
                            return time * 0.000001902587519;
                        case "Месяц":
                            return time * 0.000023148148148148147;
                        case "Декада":
                            return time * 1.9025875190000002e-7;
                        case "Неделя":
                            return time * 0.00009920634920634922;
                        case "Сутки":
                            return time * 0.0006944444444444444;
                        case "Час":
                            return time * 0.016666666666666666;
                        case "Минута":
                            return time;
                        case "Секунда":
                            return time * 60;
                        case "Миллисекунда":
                            return time * 60000;
                        case "Микросекунда":
                            return time * 60000000;
                        case "Наносекунда":
                            return time * 60000000000;
                    }
                    break;

                case "Секунда":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 3.1709791983333335e-10;
                        case "Год":
                            return time * 3.1709791983333334e-8;
                        case "Месяц":
                            return time * 3.8580246913580245e-7;
                        case "Декада":
                            return time * 3.1709791983333335e-9;
                        case "Неделя":
                            return time * 0.0000016534391534391535;
                        case "Сутки":
                            return time * 0.000011574074074074073;
                        case "Час":
                            return time * 0.0002777777777777778;
                        case "Минута":
                            return time * 0.016666666666666666;
                        case "Секунда":
                            return time;
                        case "Миллисекунда":
                            return time * 1000;
                        case "Микросекунда":
                            return time * 1000000;
                        case "Наносекунда":
                            return time * 1000000000;
                    }
                    break;

                case "Миллисекунда":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 3.1709791983333336e-13;
                        case "Год":
                            return time * 3.1709791983333334e-11;
                        case "Месяц":
                            return time * 3.8580246913580243e-10;
                        case "Декада":
                            return time * 3.1709791983333335e-12;
                        case "Неделя":
                            return time * 1.6534391534391535e-9;
                        case "Сутки":
                            return time * 1.1574074074074074e-8;
                        case "Час":
                            return time * 2.7777777777777776e-7;
                        case "Минута":
                            return time * 0.000016666666666666667;
                        case "Секунда":
                            return time * 0.001;
                        case "Миллисекунда":
                            return time;
                        case "Микросекунда":
                            return time * 1000;
                        case "Наносекунда":
                            return time * 1000000;
                    }
                    break;

                case "Микросекунда":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 3.1709791983333336e-16;
                        case "Год":
                            return time * 3.1709791983333336e-14;
                        case "Месяц":
                            return time * 3.858024691358024e-13;
                        case "Декада":
                            return time * 3.1709791983333336e-15;
                        case "Неделя":
                            return time * 1.6534391534391536e-12;
                        case "Сутки":
                            return time * 1.1574074074074074e-11;
                        case "Час":
                            return time * 2.7777777777777777e-10;
                        case "Минута":
                            return time * 1.6666666666666667e-8;
                        case "Секунда":
                            return time * 0.000001;
                        case "Миллисекунда":
                            return time * 0.001;
                        case "Микросекунда":
                            return time;
                        case "Наносекунда":
                            return time * 1000;
                    }
                    break;

                case "Наносекунда":
                    switch (CB3)
                    {
                        case "Век":
                            return time * 3.170979198333334e-19;
                        case "Год":
                            return time * 3.1709791983333333e-17;
                        case "Месяц":
                            return time * 3.858024691358024e-16;
                        case "Декада":
                            return time * 3.1709791983333336e-18;
                        case "Неделя":
                            return time * 1.6534391534391536e-15;
                        case "Сутки":
                            return time * 1.1574074074074074e-14;
                        case "Час":
                            return time * 2.777777777777778e-13;
                        case "Минута":
                            return time * 1.6666666666666667e-11;
                        case "Секунда":
                            return time * 1e-9;
                        case "Миллисекунда":
                            return time * 0.000001;
                        case "Микросекунда":
                            return time * 0.001;
                        case "Наносекунда":
                            return time;
                    }
                    break;
            }
            return -1;
        }
    }
}
