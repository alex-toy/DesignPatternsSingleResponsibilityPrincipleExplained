namespace ConsoleUI
{
    public class PersonValidator
    {

        public static bool Validate(Person person)
        {
            // Checks to be sure the first and last names are valid
            bool firstNameWrong = string.IsNullOrWhiteSpace(person.FirstName);
            if (firstNameWrong)
            {
                StandardMessages.DisplayValidationError("first name");
                return false;
            }

            bool lastNameWrong = string.IsNullOrWhiteSpace(person.LastName);
            if (lastNameWrong)
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
}
