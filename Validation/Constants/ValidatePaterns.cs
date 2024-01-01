namespace Validation.Constants
{
    public class ValidatePaterns
    {
        public const string Rnokpp = @"^[0-9]{10}$";

        public const string Passport = @"^[u0400-\u04FF]{2}[0-9]{6}$";

        public const string Guid = @"(?im)^[{(]?[0-9A-F]{8}[-]?(?:[0-9A-F]{4}[-]?){3}[0-9A-F]{12}[)}]?$";

    }
}
