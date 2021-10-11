using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace AppWeb_Regex.Models
{
    public class ExpresionRegular
    {
        public ExpresionRegular(){}

        public bool ValidarExpresionRegular(string valor)
        {
            Regex reT = new Regex(@"[A-Z]*[:]*[\s]*[0-9]*[-]*[0-9]*[;]\s*([A-Z]{0,}[a-z]{0,}[0-9]{0,}[\s]*[.]*[-]*)*");
            MatchCollection mat = reT.Matches(valor);
            foreach (Match match in mat)
                return true;                
            return false;
        }

    }
}
