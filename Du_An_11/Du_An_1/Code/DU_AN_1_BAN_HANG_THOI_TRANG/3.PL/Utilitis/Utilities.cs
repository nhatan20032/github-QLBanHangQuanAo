using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.PL.Utilitis
{
    public class Utilities
    {
        public static string GetMaTuSinh(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "";
            }
            if (!value.Trim().Contains(" ") || value.Trim().Contains("  ")) return "";

            string temp = value.Trim().ToLower();
            string[] arrNames = temp.Split(' ');
            string result = arrNames[arrNames.Length - 1];
            for (int i = 0; i < arrNames.Length - 1; i++)
            {
                result += arrNames[i][0];
            }
            //string final = GetVietHoaChuCaiDau(arrNames[arrNames.Length - 1]).Trim();
            //for (int i = 0; i < arrNames.Length - 1; i++)
            //{
            //    final += GetChuCaiDau(arrNames[i]);
            //}

            return ConvertToUnsign(result);
        }

        public static string VietHoaChuCaiDau(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                return "";
            }
            string temp = value.Trim().ToLower();
            string[] arrNames = temp.Split(' ');
            string final = "";
            for (int i = 0; i < arrNames.Length; i++)
            {
                final += GetVietHoaChuCaiDau(arrNames[i]);
            }

            return final;
        }
        public static string GetChuCaiDau(string value)
        {
            return value.Substring(0, 1);
        }

        public static string GetVietHoaChuCaiDau(string value)
        {
            return Convert.ToString(value[0]).ToUpper() + value.Substring(1);
        }

        public static string ConvertToUnsign(string str)
        {
            string strFormD = str.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc =
                    System.Globalization.CharUnicodeInfo.GetUnicodeCategory(strFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(strFormD[i]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD));
        }
        public static void ResetControlValues(Control Parent)
        {
            foreach (Control mycontrols in Parent.Controls)
                if (mycontrols is TextBox)
                {
                    (mycontrols as TextBox).Text = string.Empty;
                }
                else if (mycontrols is DateTimePicker)
                {
                    (mycontrols as DateTimePicker).Value = DateTime.Now;
                }
        }
        public static string CheckSDT(string y)
        {
            if (!Regex.IsMatch(y, @"(84|0[3|5|7|8|9])+([0-9]{8})\b"))
            {
                MessageBox.Show("phải đúng định dạng số điện thoại VN");
                return "";
            }
            return y;
        }
        public static string CheckSo(string y)
        {
            if (!Regex.IsMatch(y, @"[0-9]+"))
            {
                MessageBox.Show("ko chứa số");
                return "";
            }
            return y;
        }
    }
}
