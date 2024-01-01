using System.Text.RegularExpressions;
using Validation.Constants;
using Validation.Models;

namespace Validation.Services
{
    public class ValidateUserService
    {
        public bool ValidatePassport(string dataForValidate)
        {
            var regex = new Regex(ValidatePaterns.Passport);

            if (regex.IsMatch(dataForValidate))
            {
                using (var context = new DijaDbContext())
                {
                    string? passport = context.Users.Where(x => x.Passport == dataForValidate).Select(x => x.Passport).FirstOrDefault();
                    if (passport != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ValidateRnokpp(string dataForValidate)
        {
            var regex = new Regex(ValidatePaterns.Rnokpp);

            if (regex.IsMatch(dataForValidate))
            {
                using (var context = new DijaDbContext())
                {
                    string? rnokpp = context.Users.Where(x => x.Rnokpp == dataForValidate).Select(x => x.Rnokpp).FirstOrDefault();
                    if (rnokpp != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public bool ValidateBirthday(string dataForValidate)
        {
            try
            {
                DateTime enteredDate = DateTime.Parse(dataForValidate);

                using (var context = new DijaDbContext())
                {
                    DateTime? birthday = context.Users.Where(x => x.BirthDate == enteredDate).Select(x => x.BirthDate).FirstOrDefault();
                    if (birthday == enteredDate)
                    {
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                Console.WriteLine("Wrong Format Data");
            }

            return false;
        }
    }
}
