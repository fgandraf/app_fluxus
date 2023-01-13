using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Fluxus.WinUI
{
    public class Util
    {

        
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


        public static string ValidateDateString(string dateString)
        {
            if (dateString != "__/__/____")
                return dateString;
            else
                return null;
        }


        public static byte[] ImageToByte(Image logo)
        {
            using (var stream = new MemoryStream())
            {
                logo.Save(stream, ImageFormat.Png);
                return stream.ToArray();
            }
        }


        public static Image ByteToImage(byte[] bytes)
        {
            using (var stream = new MemoryStream(bytes))
            {
                return Image.FromStream(stream);
            }
        }


        

    }
}
