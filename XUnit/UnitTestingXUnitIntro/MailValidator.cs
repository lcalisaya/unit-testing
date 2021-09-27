using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace UnitTestingXUnitIntro
{
    public class MailValidator
    {
        public bool IsValidEmail(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
                throw new EmailNotProvidedException();

            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            return regex.IsMatch(emailAddress);
        }
        public string IsSpam(string emailAddress)
        {
            if (string.IsNullOrEmpty(emailAddress))
                throw new EmailNotProvidedException();

            List<string> spammyDomains = new List<string>() { "spam.com", "dodgy.com", "donttrust.com", "sample.com", "anothersample.com" };
            return spammyDomains.Any(d => emailAddress.Contains(d)) ? "SPAM" : "INBOX";
        }
    }
}
