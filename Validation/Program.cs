﻿using System.Text.RegularExpressions;

using Validation.Constants;
using Validation.Services;

class Program
{
    static async Task Main(string[] args)
    {
         new MockDataService().FillDb();

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
                    result = await validateUserService.ValidatePassport(dataForValidate[1]);
                }

                if (dataForValidate[0].ToLower().Equals(SearchCommand.Rnokpp))
                {
                    result = await validateUserService.ValidateRnokpp(dataForValidate[1]);
                }

                if (dataForValidate[0].ToLower().Equals(SearchCommand.BirthDay))
                {
                    result = await validateUserService.ValidateBirthday(dataForValidate[1]);
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