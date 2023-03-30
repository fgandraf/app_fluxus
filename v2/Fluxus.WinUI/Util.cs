using System.Text.RegularExpressions;

namespace Fluxus.WinUI
{
    public class Util
    {

        public static DateTime ValidateDate(string dateString)
        {
            if (dateString != "__/__/____" || !string.IsNullOrEmpty(dateString))
                return Convert.ToDateTime(dateString);
            else
            {
                return new DateTime();
            }
        }

        public static string MaskValidated(object maskedTextBox)
        {
            var regex = new Regex(@"[^\d]");
            MaskedTextBox mtxtBox = (MaskedTextBox)maskedTextBox;
            string text = regex.Replace(mtxtBox.Text, "");
            string tag = mtxtBox.Tag.ToString();
            string returnMask = string.Empty;

            if (text == "")
                return string.Empty;
            else
            {


                if (tag == "telefone")
                {
                    if (text.Length == 10)
                        returnMask = "(99) #########";
                    else
                        returnMask = "(99) ##########";
                }
                else if (tag == "cep")
                {
                    returnMask = "99999-999";
                }
                else if (tag == "data")
                {
                    returnMask = "00/00/0000";
                }
                else if (tag == "cnpj")
                {
                    returnMask = "00,000,000/0000-00";
                }
                else if (tag == "cpf")
                {
                    returnMask = "000,000,000-00";
                }

                return returnMask;
            }
        }


        public static string MaskEnter(object maskedTextBox)
        {
            MaskedTextBox mtxtBox = (MaskedTextBox)maskedTextBox;
            string tag = mtxtBox.Tag.ToString();
            string returnMask = string.Empty;



            if (tag == "telefone")
            {
                returnMask = "(99) ##########";
            }
            else if (tag == "cep")
            {
                returnMask = "99999-999";
            }
            else if (tag == "data")
            {
                returnMask = "00/00/0000";
            }
            else if (tag == "cnpj")
            {
                returnMask = "00,000,000/0000-00";
            }
            else if (tag == "referencia")
            {
                returnMask = "0000,0000,000000000/0000,00,00,00";
            }
            else if (tag == "cpf")
            {
                returnMask = "000,000,000-00";
            }


            return returnMask;
        }
    }
}
