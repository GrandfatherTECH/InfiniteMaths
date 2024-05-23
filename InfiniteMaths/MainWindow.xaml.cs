using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;
using IsAllLettersOrDigitsLib;
using System.Net.Security;
using System.Windows.Xps.Serialization;
using System.Runtime;
using System.Globalization;
using System.DirectoryServices;
using System.Numerics;
using System.CodeDom;
using System.Windows.Media.Animation;
using System.DirectoryServices.ActiveDirectory;

namespace InfiniteMaths
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
           
        public string[] modes { set; get; } 
        public MainWindow()
        {
            InitializeComponent();

            modes = new string[] { "Перевод в десятичную СС", "Перевод из десятичной СС" };
            DataContext = this;
        }
        

        private double[] letter_case
        (
            char letter,
            double power,
            double sys
        )
        {
            double[] res = { 0, 0 };
            int check;
            switch (letter)
            {
                case 'A':
                case 'a':
                    res[0] = 10 * Math.Pow(sys, power);
                    check = 10;
                    break;
                case 'B':
                case 'b':
                    res[0] = 11 * Math.Pow(sys, power);
                    check = 11;
                    break;
                case 'C':
                case 'c':
                    res[0] = 12 * Math.Pow(sys, power);
                    check = 12;
                    break;
                case 'D':
                case 'd':
                    res[0] = 13 * Math.Pow(sys, power);
                    check = 13;
                    break;
                case 'E':
                case 'e':
                    res[0] = 14 * Math.Pow(sys, power);
                    check = 14;
                    break;
                case 'F':
                case 'f':
                    res[0] = 15 * Math.Pow(sys, power);
                    check = 15;
                    break;
                case 'G':
                case 'g':
                    res[0] = 16 * Math.Pow(sys, power);
                    check = 16;
                    break;
                case 'H':
                case 'h':
                    res[0] = 17 * Math.Pow(sys, power);
                    check = 17;
                    break;
                case 'I':
                case 'i':
                    res[0] = 18 * Math.Pow(sys, power);
                    check = 18;
                    break;
                case 'J':
                case 'j':
                    res[0] = 19 * Math.Pow(sys, power);
                    check = 19;
                    break;
                case 'K':
                case 'k':
                    res[0] = 20 * Math.Pow(sys, power);
                    check = 20;
                    break;
                case 'L':
                case 'l':
                    res[0] = 21 * Math.Pow(sys, power);
                    check = 21;
                    break;
                case 'M':
                case 'm':
                    res[0] = 22 * Math.Pow(sys, power);
                    check = 22;
                    break;
                case 'N':
                case 'n':
                    res[0] = 23 * Math.Pow(sys, power);
                    check = 23;
                    break;
                case 'O':
                case 'o':
                    res[0] = 24 * Math.Pow(sys, power);
                    check = 24;
                    break;
                case 'P':
                case 'p':
                    res[0] = 25 * Math.Pow(sys, power);
                    check = 25;
                    break;
                case 'Q':
                case 'q':
                    res[0] = 26 * Math.Pow(sys, power);
                    check = 26;
                    break;
                case 'R':
                case 'r':
                    res[0] = 27 * Math.Pow(sys, power);
                    check = 27;
                    break;
                case 'S':
                case 's':
                    res[0] = 28 * Math.Pow(sys, power);
                    check = 28;
                    break;
                case 'T':
                case 't':
                    res[0] = 29 * Math.Pow(sys, power);
                    check = 29;
                    break;
                case 'U':
                case 'u':
                    res[0] = 30 * Math.Pow(sys, power);
                    check = 30;
                    break;
                case 'V':
                case 'v':
                    res[0] = 31 * Math.Pow(sys, power);
                    check = 31;
                    break;
                case 'W':
                case 'w':
                    res[0] = 32 * Math.Pow(sys, power);
                    check = 32;
                    break;
                case 'X':
                case 'x':
                    res[0] = 33 * Math.Pow(sys, power);
                    check = 33;
                    break;
                case 'Y':
                case 'y':
                    res[0] = 34 * Math.Pow(sys, power);
                    check = 34;
                    break;
                case 'Z':
                case 'z':
                    res[0] = 35 * Math.Pow(sys, power);
                    check = 35;
                    break;
                default:
                    Result.Text = $"Не латинская буква {letter}";
                    res[1] = 100;
                    return res;
            }
            if (check < sys)
            {
                return res;
            }
            else
            {
                Result.Text = $"Число {letter} больше (или равно) основания системы";
                Result.Text += " n:" + res[0].ToString();
                res[1] = 101;
                return res;
            }
        }
        

        private int complexnum_to_int(char num)
        {
            switch (num)
            {
                case 'A':
                case 'a':
                    return 10;
                case 'B':
                case 'b':
                    return 11;
                case 'C':
                case 'c':
                    return 12;
                case 'D':
                case 'd':
                    return 13;
                case 'E':
                case 'e':
                    return 14;
                case 'F':
                case 'f':
                    return 15;
                case 'G':
                case 'g':
                    return 16;
                case 'H':
                case 'h':
                    return 17;
                case 'I':
                case 'i':
                    return 18;
                case 'J':
                case 'j':
                    return 19;
                case 'K':
                case 'k':
                    return 20;
                case 'L':
                case 'l':
                    return 21;
                case 'M':
                case 'm':
                    return 22;
                case 'N':
                case 'n':
                    return 23;
                case 'O':
                case 'o':
                    return 24;
                case 'P':
                case 'p':
                    return 25;
                case 'Q':
                case 'q':
                    return 26;
                case 'R':
                case 'r':
                    return 27;
                case 'S':
                case 's':
                    return 28;
                case 'T':
                case 't':
                    return 29;
                case 'U':
                case 'u':
                    return 30;
                case 'V':
                case 'v':
                    return 31;
              case 'W':
                case 'w':
                    return 32;
                case 'X':
                case 'x':
                    return 33;
                case 'Y':
                case 'y':
                    return 34;
                case 'Z':
                case 'z':
                    return 35;
                default:
                    Result.Text = $"Не латинская буква: {num}";
                    return 0;
            }
        }


        private char add_letter(decimal num)
        {
            switch (num)
            {
                case 10:
                    return 'A';
                case 11:
                    return 'B';
                case 12:
                    return 'C';
                case 13:
                    return 'D';
                case 14:
                    return 'E';
                case 15:
                    return 'F';
                case 16:
                    return 'G';
                case 17:
                    return 'H';
                case 18:
                    return 'I';
                case 19:
                    return 'J';
                case 20:
                    return 'K';
                case 21:
                    return 'L';
                case 22:
                    return 'M';
                case 23:
                    return 'N';
                case 24:
                    return 'O';
                case 25:
                    return 'P';
                case 26:
                    return 'Q';
                case 27:
                    return 'R';
                case 28:
                    return 'S';
                case 29:
                    return 'T';
                case 30:
                    return 'U';
                case 31:
                    return 'V';
                case 32:
                    return 'W';
                case 33:
                    return 'X';
                case 34:
                    return 'Y';
                case 35:
                    return 'Z';
                default:
                    return '_';
            }
        }


        private object[] add_letter_substract(decimal num)
        {
            object[] res = new object[2];
            switch (num)
            {
                case 10:
                    res[0] = 'A';
                    res[1] = num - 10;
                    return res;
                case 11:
                    res[0] = 'B';
                    res[1] = num - 11;
                    return res;
                case 12:
                    res[0] = 'C';
                    res[1] = num - 12;
                    return res;
                case 13:
                    res[0] = 'D';
                    res[1] = num - 13;
                    return res;
                case 14:
                    res[0] = 'E';
                    res[1] = num - 14;
                    return res;
                case 15:
                    res[0] = 'F';
                    res[1] = num - 15;
                    return res;
                case 16:
                    res[0] = 'G';
                    res[1] = num - 16;
                    return res;
                case 17:
                    res[0] = 'H';
                    res[1] = num - 17;
                    return res;
                case 18:
                    res[0] = 'I';
                    res[1] = num - 18;
                    return res;
                case 19:
                    res[0] = 'J';
                    res[1] = num - 19;
                    return res;
                case 20:
                    res[0] = 'K';
                    res[1] = num - 20;
                    return res;
                case 21:
                    res[0] = 'L';
                    res[1] = num - 21;
                    return res;
                case 22:
                    res[0] = 'M';
                    res[1] = num - 22;
                    return res;
                case 23:
                    res[0] = 'N';
                    res[1] = num - 23;
                    return res;
                case 24:
                    res[0] = 'O';
                    res[1] = num - 24;
                    return res;
                case 25:
                    res[0] = 'P';
                    res[1] = num - 25;
                    return res;
                case 26:
                    res[0] = 'Q';
                    res[1] = num - 26;
                    return res;
                case 27:
                    res[0] = 'R';
                    res[1] = num - 27;
                    return res;
                case 28:
                    res[0] = 'S';
                    res[1] = num - 28;
                    return res;
                case 29:
                    res[0] = 'T';
                    res[1] = num - 29;
                    return res;
                case 30:
                    res[0] = 'U';
                    res[1] = num - 30;
                    return res;
                case 31:
                    res[0] = 'V';
                    res[1] = num - 31;
                    return res;
                case 32:
                    res[0] = 'W';
                    res[1] = num - 32;
                    return res;
                case 33:
                    res[0] = 'X';
                    res[1] = num - 33;
                    return res;
                case 34:
                    res[0] = 'Y';
                    res[1] = num - 34;
                    return res;
                case 35:
                    res[0] = 'Z';
                    res[1] = num - 35;
                    return res;
                default:
                    res[0] = '_';
                    res[1] = 0;
                    return res;
            }
        }


        private int coordinates = -1; // used in Number_TextChanged() to keep the track of the dot in a num in Numebr.Text
        /// <summary>
        /// 
        /// not allowing to use '.' twice
        /// not allowing anythig exept '.', '[A-Za-z]', '0-9' 
        /// 
        /// </summary>
        /// <param name="sender">
        /// 
        /// </param>
        /// 
        /// <param name="e">
        /// 
        /// </param>
        private void Number_TextChanged(object sender, TextChangedEventArgs e)
        {
            bool twice_meet = false;
            int times_meet = 0;
            string txt = Number.Text, res = "";
            if (coordinates != -1 && coordinates + 1 < txt.Length && txt[coordinates] != '.' && txt[coordinates + 1] == '.')
            {
                coordinates++;
            }
            if (coordinates + 1 < txt.Length && coordinates != -1 && coordinates - 1 >= 0 && txt[coordinates] != '.' && txt[coordinates - 1] == '.')
            {
                coordinates--;
            }
            for (int i = 0; i < txt.Length; i++)
            {
                if (txt[i] == '.')
                {
                    times_meet++;
                    if (times_meet == 1 && coordinates == -1)
                    {
                        coordinates = i;
                    }
                }
            }
            if (times_meet == 2)
            {
                twice_meet = true;
            }
            if (times_meet == 0)
            {
                coordinates = -1;
            }
            for (int i = 0; i < txt.Length; i++)
            {
                if (char.IsLetterOrDigit(txt[i]) || txt[i] == '|' || txt[i] == '.')
                {
                    if (coordinates >= 0)
                    {
                        if (txt[i] == '.' && i == coordinates)
                        {
                            res += txt[i];
                            continue;
                        }

                        if (txt[i] == '.' && twice_meet && i != coordinates)
                        {
                            continue;
                        }
                    }
                    if(Choose.SelectedIndex == 1 && (txt[i] == '|' || char.IsLetter(txt[i])))
                    {
                        continue;
                    }
                    res += txt[i];
                }
            }
            Number.Text = res;
        }


        /// <summary>
        /// 
        /// getting the number value in the decimal numerous system
        /// 
        /// </summary>
        /// <param name="sender">
        /// 
        /// </param>
        /// 
        /// <param name="e">
        /// 
        /// </param>
        private void Sys_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!IsAllLettersOrDigitsClass.IsAllDigit(Sys.Text))
            {
                string txt = Sys.Text, res = "";
                for (int i = 0; i < txt.Length; i++)
                {
                    if (char.IsDigit(txt[i]))
                    {
                        res += txt[i];
                    }
                }
                Sys.Text = res;
            }
        }


        /// <summary>
        /// 
        /// converting a number
        ///
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Convert_Click(object sender, RoutedEventArgs e)
        {
            double num = 0;                         // the variable that stores the final number
            if (Choose.SelectedIndex == 0)
            {
                if (Sys.Text == string.Empty || Number.Text == string.Empty)
                {
                    Result.Text = "Пустые строки";
                    return;
                }


                string double_part_num_str = "";                // the double <string> part of a num
                string complexnum = "";                         // the <string> complex num that will be converted to <double>
                string num_str = Number.Text;                   // the <string> num of an entered num
                double complexnum_to_num = 0;                   // the <string> complex num converted to <double> (ready to be added to the num variable)
                double sys = int.Parse(Sys.Text);               // the base of a num
                double power = -1;                              // the power of the integer part of a num
                double double_power = 0;                        // the power for the double part of a num
                double get_num = 0;                             // get a numeric value from a char value
                bool meet = false;                              // the '|' is met
                bool double_meet = false;                       // the '.' is met
                int complexnum_to_int_check = 0;                // checks if complexnum_to_int() does not return 0
                double[] letter_case_check = new double[2];     /* checks letter_case_check[0]: num += letter_case_check[0]
                                                                letter_case_check[1]: if 0 then ok; if 100, then error non-latin letter; if 101, then num_str[i] > sys */


                //estimating power

                for (int i = 0; i < num_str.Length; i++)
                {
                    if (!meet && !double_meet && char.IsLetterOrDigit(num_str[i]))
                    {
                        power++;
                    }
                    if (!meet && double_meet && char.IsLetterOrDigit(num_str[i]))
                    {
                        double_part_num_str += num_str[i];
                        double_power--;
                    }
                    if (!meet && !double_meet && num_str[i] == '.')
                    {
                        double_meet = true;
                        continue;
                    }
                    if (!meet && num_str[i] == '|')
                    {
                        meet = true;
                        continue;
                    }
                    if (meet && num_str[i] != '|')
                    {
                        continue;
                    }
                    if (meet && num_str[i] == '|')
                    {
                        meet = false;
                        if (!double_meet)
                        {
                            power++;
                        }
                        else
                        {
                            double_power--;
                        }
                    }
                }

                double_meet = false;
                meet = false;

                //converting integer part

                for (int i = 0; i < num_str.Length; i++)
                {

                    //converting complex numbers

                    if (num_str[i] == '|')
                    {
                        if (!meet)
                        {
                            meet = true;
                            continue;
                        }
                        else
                        {
                            meet = false;
                            for (int ii = 0; ii < complexnum.Length; ii++)
                            {
                                complexnum_to_int_check = complexnum_to_int(complexnum[ii]);
                                if(complexnum_to_int_check != 0)
                                {
                                    complexnum_to_num += complexnum_to_int_check;
                                }
                                else
                                {
                                    return;
                                }
                            }
                            if (complexnum_to_num < sys)
                            {
                                num += complexnum_to_num * Math.Pow(sys, power);
                                power--;
                                complexnum = "";
                                complexnum_to_num = 0;
                                continue;
                            }
                            else
                            {
                                Result.Text = $"Ошибка: число {complexnum} больше (или равно) системе счисления";
                                return;
                            }
                        }
                    }
                    if (char.IsDigit(num_str[i]))
                    {
                        get_num = (double)char.GetNumericValue(num_str[i]);
                        if (meet)
                        {
                            Result.Text = "Ошибка: нельзя вставлять цифры десятичной системы счисения в комплексные числа";
                            //Error: cannot put decimal digits and dots in complex numbers
                            return;
                        }
                        if (get_num < sys)
                        {
                            num += get_num * Math.Pow(sys, power);
                            power--;
                            continue;
                        }
                        else
                        {
                            Result.Text = $"Число {get_num} больше (или равно) основания системы";
                            return;
                        }
                    }
                    else if (char.IsLetter(num_str[i]) && !meet)
                    {
                        letter_case_check = letter_case(num_str[i], power, sys);
                        if (letter_case_check[1] == 0)
                        {
                            num += letter_case_check[0];
                            power--;
                        }
                        else if (letter_case_check[1] == 100 || letter_case_check[1] == 101)
                        {
                            return;
                        }
                    }
                    else if (char.IsLetter(num_str[i]) && meet)
                    {
                        complexnum += num_str[i];
                        continue;
                    }
                    if (num_str[i] == '.')
                    {
                        if (meet)
                        {
                            Result.Text = "Ошибка: нельзя вставлять точки в комплексные числа";
                            return;
                        }
                        double_meet = true;
                        break;
                    }
                }

                //converting the double part
                if (double_meet)
                {
                    for (int i = num_str.Length - 1; i >= 0; i--)
                    {
                        // converting comple numbers
                        if (num_str[i] == '|')
                        {
                            if (!meet)
                            {
                                meet = true;
                                continue;
                            }
                            else
                            {
                                meet = false;
                                for (int ii = 0; ii < complexnum.Length; ii++)
                                {
                                    complexnum_to_int_check = complexnum_to_int(complexnum[ii]);
                                    if (complexnum_to_int_check != 0)
                                    {
                                        complexnum_to_num += complexnum_to_int_check;
                                    }
                                    else
                                    {
                                        return;
                                    }
                                }
                                if (complexnum_to_num < sys)
                                {
                                    num += complexnum_to_num * Math.Pow(sys, double_power);
                                    double_power++;
                                    complexnum = "";
                                    complexnum_to_num = 0;
                                    continue;
                                }
                                else
                                {
                                    Result.Text = $"Ошибка: число {complexnum} больше (или равно) системы счисления";
                                    return;
                                }
                            }
                        }

                        if (char.IsDigit(num_str[i]))
                        {
                            get_num = (double)char.GetNumericValue(num_str[i]);
                            if (meet)
                            {
                                Result.Text = "Ошибка: нельзя вставлять цифры десятичной системы счисения в комплексные числа";
                                return;
                            }
                            if (get_num < sys)
                            {
                                num += get_num * Math.Pow(sys, double_power);
                                double_power++;
                                continue;
                            }
                            else
                            {
                                Result.Text = $"Число {get_num} больше (или равно) основания системы";
                                return;
                            }
                        }
                        else if (char.IsLetter(num_str[i]) && !meet)
                        {
                            letter_case_check = letter_case(num_str[i], double_power, sys);
                            if (letter_case_check[1] == 0)
                            {
                                num += letter_case_check[0];
                                double_power++;
                            }
                            else if (letter_case_check[1] == 100 || letter_case_check[1] == 101)
                            {
                                return;
                            }
                        }
                        else if (char.IsLetter(num_str[i]) && meet)
                        {
                            complexnum += num_str[i];
                            continue;
                        }
                        if (num_str[i] == '.')
                        {
                            if(meet)
                            {
                                Result.Text = "Нельзя вставлять точки в комплексные числа";
                                return;
                            }
                            break;
                        }
                    }
                }
                Result.Text = " Результат: " + num.ToString();
                return;
            }
            if (Choose.SelectedIndex == 1)
            {
                if (Number.Text == string.Empty || Sys.Text == string.Empty)
                {
                    Result.Text = string.Empty;
                    Result.Text += "Пустые строки";
                    return;
                }
                decimal nearest;
                bool defnearest = true;
                if (Nearest.Text != string.Empty)
                {
                    nearest = int.Parse(Nearest.Text);
                    defnearest = false;
                }
                else
                {
                    nearest = 0;
                }
                if (nearest < 1 && Nearest.Text != string.Empty)
                {
                    Result.Text = string.Empty;
                    Result.Text = "Ошибка: точность не быть меньше 1";
                    return;
                }
                object[] sub_letter_check = new object[2];
                string result = "";
                char[] cresult = new char[] { };
                decimal complex_remainder;
                decimal number = decimal.Parse(Number.Text);
                decimal sys = int.Parse(Sys.Text);
                decimal truncate = 0;
                decimal ftruncate = 0;
                decimal remainder = 0;
                bool bdouble = false;
                if(number % 1 != 0)
                {
                    bdouble = true;
                    truncate = number - Math.Truncate(number);
                    number = Math.Truncate(number);

                }
                while (number != 0)
                {
                    if (number >= sys)
                    {
                        remainder = number % sys;
                        number = Math.Truncate(number / sys);
                        // Result.Text += "Condition met! ";
                    }
                    else
                    {
                        remainder = number;
                        number = 0;
                    }
                    if (remainder > 9)
                    {
                        if (remainder < 36)
                        {
                            result += add_letter(remainder);
                            /* if (number < sys)
                            {
                                Result.Text += " s:" + result;
                            }
                            */
                            continue;
                        }
                        else if (remainder > 35 && remainder < 46)
                        {
                            result += '|';
                            complex_remainder = remainder - 10;
                            result += add_letter(complex_remainder);
                            result += "A|";
                            /* if (number < sys)
                            {
                                Result.Text += " s:" + result;
                            }
                            */
                            continue;
                        }
                        else if (remainder >= 46)
                        {
                            result += '|';
                            complex_remainder = remainder;
                            complex_remainder -= 35;
                            result += 'Z';
                            while (complex_remainder != 0)
                            {
                                if (complex_remainder >= 35)
                                {
                                    result += 'Z';
                                    complex_remainder -= 35;
                                    continue;
                                }
                                sub_letter_check = add_letter_substract(complex_remainder);
                                result += sub_letter_check[0];
                                complex_remainder = (decimal)sub_letter_check[1];
                            }
                            result += '|';
                            /* if (number < sys)
                            {
                                Result.Text += " s:" + result;
                            }
                            */
                        }
                    }
                    else
                    {
                        result += remainder.ToString();
                    }
                }

                cresult = result.ToCharArray();
                // Result.Text += " s:" + result;                            // > used for debugging
                // Result.Text += " arr:" + new string(cresult);             // > used for debugging
                Array.Reverse(cresult);
                result = new string(cresult);

                if (bdouble)
                {
                    // Result.Text += " bd:" + result + " ";                 // > used for debugging
                    result += '.';
                    // Result.Text += " ad:" + result + " ";                 // > used for debugging
                    bool first = false;
                    int i = 0;
                    while ((truncate > 0 && defnearest && i <= 99) || (truncate > 0 && !defnearest && nearest != 0))
                    {
                       // Result.Text += " w:" + result + " ";               // > used for debugging
                        if (defnearest)
                        {
                            i++;
                        }
                        if(i == 100)
                        {
                            break;
                        }
                        if (nearest > 0)
                        {
                            nearest--;
                        }

                        truncate *= sys;

                        if (first && truncate == ftruncate)
                        {
                            result += 'p';
                            break;
                        }
                        if (!first)
                        {
                            first = true;
                            ftruncate = truncate;
                        }
                        if (Math.Truncate(truncate) > 9)
                        {
                            if (Math.Truncate(truncate) < 36)
                            {
                                result += add_letter(Math.Truncate(truncate));
                                truncate -= Math.Truncate(truncate);
                                continue;
                            }
                            else if (Math.Truncate(truncate) > 35 && Math.Truncate(truncate) < 46)
                            {
                                result += '|';
                                complex_remainder = Math.Truncate(truncate) - 10;
                                result += add_letter(Math.Truncate(complex_remainder));
                                result += "A|";
                                truncate -= Math.Truncate(truncate);
                                continue;
                            }
                            else if (Math.Truncate(truncate) >= 46)
                            {
                                result += '|';
                                complex_remainder = Math.Truncate(truncate);
                                complex_remainder -= 35;
                                result += 'Z';
                                while (complex_remainder != 0)
                                {
                                    if (complex_remainder >= 35)
                                    {
                                        result += 'Z';
                                        complex_remainder -= 35;
                                        continue;
                                    }
                                    sub_letter_check = add_letter_substract(complex_remainder);
                                    result += sub_letter_check[0];
                                    complex_remainder = (decimal)sub_letter_check[1];
                                }
                                truncate -= Math.Truncate(truncate);
                                result += '|';
                            }
                        }
                        else
                        {
                            result += (Math.Truncate(truncate)).ToString();
                            truncate -= Math.Truncate(truncate);
                        }
                    }
                }
                Result.Text = "Результат:  " + result;
            }
        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(Choose.SelectedIndex == 0)
            {
                Thickness margin;

                margin = Result.Margin;
                margin.Top = 98;
                Result.Margin = margin;

                margin = Choose.Margin;
                margin.Top = 151;
                Choose.Margin = margin;

                margin = Nearest.Margin;
                margin.Top = 181;
                Nearest.Margin = margin;

                Nearest.IsEnabled = false;
                Nearest.Visibility= Visibility.Collapsed;

            }
            else if(Choose.SelectedIndex == 1)
            {
                Thickness margin;

                margin = Result.Margin;
                margin.Top = 141;
                Result.Margin = margin;

                margin = Choose.Margin;
                margin.Top = 194;
                Choose.Margin = margin;

                margin = Nearest.Margin;
                margin.Top = 98;
                Nearest.Margin = margin;

                Nearest.IsEnabled = true;
                Nearest.Visibility = Visibility.Visible;
            }
        }

        private void Nearest_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!IsAllLettersOrDigitsClass.IsAllDigit(Sys.Text))
            {
                string txt = Nearest.Text, res = "";
                for (int i = 0; i < txt.Length; i++)
                {
                    if (char.IsDigit(txt[i]))
                    {
                        res += txt[i];
                    }
                }
                Nearest.Text = res;
            }
        }

        private void Clear_Click(object sender, RoutedEventArgs e)
        {
            Result.Text = string.Empty;
        }

        private void Copy_Click(object sender, RoutedEventArgs e)
        {
            string clipboard = "";
            for(int i = 11; i < Result.Text.Length; i++)
            {
                clipboard += Result.Text[i];
            }
            Clipboard.SetText(clipboard);
        }
    }
}
