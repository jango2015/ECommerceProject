using System;
using System.Text.RegularExpressions;
using Ecommerce.Helpers;

namespace Ecoomerce.Domain.ValueObject
{
    public class Email
    {
        public string Address { get; private set; }
        public const int AdressMaxLength = 254;

        #region Constructors

        //construtor do Entity
        protected Email()
        {
           
        }

        public Email(string adress)
        {
            Guard.ForNullOrEmpty(adress,"E-mail");
            Guard.StringLength("E-mail",adress,AdressMaxLength);
            if(!IsValid(adress))
                throw new Exception("email inválido");
            this.Address = adress;
        }


        public static bool IsValid(string email)
        {
            var regexEmail = new Regex(@"^(?("")("".+?""@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$");
            return regexEmail.IsMatch(email);
        }
        #endregion
    }
}
