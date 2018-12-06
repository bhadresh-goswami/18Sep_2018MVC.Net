using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ViwBagViewDataTempData.Models
{
    public class InfoModel
    {
        [Key]
        public int UserId { get; set; }

        //private string _UserName;

        //public string UserName
        //{
        //    get { return _UserName; }
        //    set { _UserName = value; }
        //}
        [DataType(DataType.Text)]
        public string UserName { get; set; }


        private string _Password;
        [DataType(DataType.Password)]
        public string Password
        {
            get
            {
                //System.Text.UTF8Encoding encoder = new System.Text.UTF8Encoding();
                //System.Text.Decoder utf8Decode = encoder.GetDecoder();
                //byte[] todecode_byte = Convert.FromBase64String(_Password);
                //int charCount = utf8Decode.GetCharCount(todecode_byte, 0, todecode_byte.Length);
                //char[] decoded_char = new char[charCount];
                //utf8Decode.GetChars(todecode_byte, 0, todecode_byte.Length, decoded_char, 0);
                //string result = new String(decoded_char);


                //return result;
                return _Password;
            }
            set
            {

                byte[] encData_byte = new byte[value.Length];
                encData_byte = System.Text.Encoding.UTF8.GetBytes(value);
                string encodedData = Convert.ToBase64String(encData_byte);
                _Password = encodedData;

            }
        }



    }
}