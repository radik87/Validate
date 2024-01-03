using Microsoft.EntityFrameworkCore;

using System.Text.RegularExpressions;
using Validation.Constants;
using Validation.Models;

namespace Validation.Services
{
    public class ValidateUserService
    {
        public async Task<bool> ValidatePassport(string dataForValidate)
        {
            var regex = new Regex(ValidatePaterns.Passport);

            if (regex.IsMatch(dataForValidate))
            {
                using (var context = new DijaDbContext())
                {
                    string? passport = await context.Users.Where(x => x.Passport == dataForValidate).Select(x => x.Passport)
                        .FirstOrDefaultAsync();
                    if (passport != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public async Task<bool> ValidateRnokpp(string dataForValidate)
        {
            var regex = new Regex(ValidatePaterns.Rnokpp);

            if (regex.IsMatch(dataForValidate))
            {
                using (var context = new DijaDbContext())
                {
                    string? rnokpp = await context.Users.Where(x => x.Rnokpp == dataForValidate).Select(x => x.Rnokpp)
                        .FirstOrDefaultAsync();
                    if (rnokpp != null)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public async Task<bool> ValidateBirthday(string dataForValidate)
        {
            try
            {
                DateTime enteredDate = DateTime.Parse(dataForValidate);

                using (var context = new DijaDbContext())
                {
                    DateTime? birthday = await context.Users.Where(x => x.BirthDate == enteredDate).Select(x => x.BirthDate)
                        .FirstOrDefaultAsync();
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
