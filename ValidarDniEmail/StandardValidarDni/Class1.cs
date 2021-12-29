using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Linq;

namespace Validar
{
    public class Class1
    {

        public Boolean validarEmail(String email) // Método para validar el Email ingresado
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            try
            {
                // Normalize the domain
                email = Regex.Replace(email, @"(@)(.+)$", DomainMapper,
                                      RegexOptions.None, TimeSpan.FromMilliseconds(200));

                // Examines the domain part of the email and normalizes it.
                string DomainMapper(Match match)
                {
                    // Use IdnMapping class to convert Unicode domain names.
                    var idn = new IdnMapping();

                    // Pull out and process domain name (throws ArgumentException on invalid)
                    string domainName = idn.GetAscii(match.Groups[2].Value);

                    return match.Groups[1].Value + domainName;
                }
            }
            catch (RegexMatchTimeoutException e)
            {
                return false;
            }
            catch (ArgumentException e)
            {
                return false;
            }

            try
            {
                return Regex.IsMatch(email,
                    @"^[^@\s]+@[^@\s]+\.[^@\s]+$",
                    RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }


        public Boolean ValidarDNI(String DNI)
        {
            if ((DNI.Count(char.IsDigit) == 8) && // only 9 digits
    (DNI.EndsWith("A", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("B", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("C", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("D", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("E", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("F", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("G", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("H", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("I", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("J", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("K", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("L", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("M", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("N", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("Ñ", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("O", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("P", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("Q", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("R", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("S", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("T", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("U", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("V", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("W", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("X", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("Y", StringComparison.OrdinalIgnoreCase)
     || DNI.EndsWith("Z", StringComparison.OrdinalIgnoreCase)))//3rd digit can not be equal to 4 or 9
            {
                //Valid
                return true;
            }
            else
            {
                //invalid
                return false;
            }
            
        }
    }
}