using System.Text.RegularExpressions;

using Validation.Constants;
using Validation.Services;

class Program
{
    static void Main(string[] args)
    {
        //use new MockDataService().FillDb(); 1 time and after comment this line because guids are hardcoded.
        //new MockDataService().FillDb();

        //put breakpoint here and check mock data in database.
        while (true)
        {
            bool result = default;

            string? input = Console.ReadLine();

            ValidateUserService validateUserService = new ValidateUserService();

            if (input != null || input != string.Empty)
            {
                string[] dataForValidate = input!.Split(' ');

                if (dataForValidate[0].ToLower().Equals(SearchCommand.Passport))
                {
                    result = validateUserService.ValidatePassport(dataForValidate[1]);
                }

                if (dataForValidate[0].ToLower().Equals(SearchCommand.Rnokpp))
                {
                    result = validateUserService.ValidateRnokpp(dataForValidate[1]);
                }

                if (dataForValidate[0].ToLower().Equals(SearchCommand.BirthDay))
                {
                    result = validateUserService.ValidateBirthday(dataForValidate[1]);
                }

                if (new Regex(ValidatePaterns.Guid).IsMatch(input))
                {
                    Console.WriteLine(SensivityCaseChecker.IsUpper(input) ? "IOS" : "Adnroid");
                    continue;
                }
            }
            Console.WriteLine(result);
        }
    }
}