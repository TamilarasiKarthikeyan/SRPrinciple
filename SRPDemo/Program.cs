using System;


namespace SRPDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonData.GetPersonData();

            bool IsPersonValid = PersonValidator.Validate(user);

            if(IsPersonValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            GenerateUserData.SaveUserData(user);
            StandardMessages.EndApplication();

        }
    }
}
