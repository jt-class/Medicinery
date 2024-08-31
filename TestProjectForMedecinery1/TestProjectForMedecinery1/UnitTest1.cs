using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;
using TestProjectForMedecinery1;
namespace TestProjectForMedecinery1
{
    public class TestFunction
    {
        public string? ItemSearch(string ItemName)
        {
            string[] MedecineDB = { "Medecine1", "Medecine2", "Medecine3" };

            for (int i = 0; i < MedecineDB.Length; i++) {
                if (ItemName.Equals(MedecineDB[i]))
                {
                    return MedecineDB[i];
                }
                else
                {
                    continue;
                }
            }
            return null;

        }

        public string? EmailVeriication(string Email) {

            string[] EmailDB = { "UserExample@test.com","UserExample231@test.com","testingEmail@test.com" };

            for (int x = 0; x < EmailDB.Length; x++)*
            {
                if (Email.Equals(EmailDB[x]))
                {
                    return Email;

                }
            }
            return null;
        
        }
        public string? PasswordVerification(string Password)
        {

            string[] PassDB = { "Password231", "passwOrd2", "paswrd21" };
            for (int x = 0; x < PassDB.Length; x++)
            {
                if (Password.Equals(PassDB[x]))
                {
                    return Password;

                }
            }
            return null;

        }

    }
    

}

public class UnitTest1
    {
        private bool matchFound;

        [Fact]
       /* public void AddedItemInTheCart()
        {
            int [] NumberOfItems = { 1, 2, 3 };
            int[] Items = NumberOfItems;
            Debug.Assert(Items.Length > NumberOfItems.Length);

        }*/
       /* public void NotifyUsers()
        {
            var message = "Test message";

            var notification = new Notification(message);
                var result = notification.Message;

            Assert.Equal(message, result);
        }*/
        public void SearchItem()
        {
            TestFunction searchItem = new TestFunction();
            string UserInput = "Medecine2";
            string [] CurrentItemAvailable = { "Medecine1", "Medecine2", "Medecine3" };

            string Input = searchItem.ItemSearch(UserInput);



            for (int i = 0; i < CurrentItemAvailable.Length; i++) {
                if (CurrentItemAvailable[i] == Input)
                {
                    Assert.Equal(CurrentItemAvailable[i], Input);
                    matchFound = true;
                    break;
                }

            }
            Assert.True(matchFound, $"The input {Input} was not found in the array.");



        }
        
    [Fact]
    public void LoginTest()
    {
        TestFunction Login = new TestFunction();
        string EmailInput = "test23@gmail.com";
        string PasssInput = "Test_passWORD";
        bool email = false;
        bool pass = false;

        string[] TargetEmail = { "test23@gmail.com", "test@gmail.com", "test2@gmail.co" };
        string[] TargetPass = { "Test_passWORD", "test_passWOrd", "TEST_passWOrd" };

        foreach (string x in TargetEmail)
        {
            if (x == EmailInput)
            {
                email = true;
                break;
            }
        }

        foreach (string x in TargetPass)
        {
            if (x == PasssInput)
            {
                pass = true;
                break;
            }
        }
        
            Assert.True(email && pass ,$"Both email and password pass");
    }

}