using System;

namespace MyLeasing.Web.Data.Entities
{
    internal class MaxiLengthAttribute : Attribute
    {
        private int v;
        private string ErrorMessage;

        public MaxiLengthAttribute(int v, string ErrorMessage)
        {
            this.v = v;
            this.ErrorMessage = ErrorMessage;
        }
    }
}