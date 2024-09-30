using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using TestProjectForMedecinery1;

namespace TestProjectForMedecinery1
{




}
public class TestFunction
{
    public string? ItemSearch(string ItemName)
    {
        string[] MedecineDB = { "Medecine1", "Medecine2", "Medecine3" };
        string ItemSearch = "";

        foreach (string x in MedecineDB)
        {
            if (ItemName.Equals(x))
            {
                ItemSearch = x;
                break;
            }
            else
            {
                continue;

            }
        }
        return ItemSearch;

    }

    public string? EmailVeriication(string Email)
    {

        string[] EmailDB = { "UserExample@test.com", "UserExample231@test.com", "testingEmail@test.com" };

        foreach (string x in EmailDB)
        {
            if (Email.Equals(x))
            {
                return x;
            }
            else
            {
                continue;
            }
        }
        return null;


    }
    public string? PasswordVerification(string Password)
    {
        string[] PassDB = { "Password231", "passwOrd2", "paswrd21" };

        foreach (string x in PassDB)
        {
            if (Password.Equals(x))
            {
                return x;

            }
            else
            {
                continue;
            }
        }
        return null;

    }

    /*The method parameter contain itemId as of now
      di ko mun nilagyan for initial test unit muna since wala pang DB
     */
    private List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public List<string> GetItems()
    {
        return items;
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
    public void SearchItem1()
    {
        TestFunction searchItem = new TestFunction();
        string UserInput = "Medecine";
        string[] CurrentItemAvailable = { "Medecine1", "Medecine2", "Medecine3" };




        foreach (string x in CurrentItemAvailable)
        {
            if (x.Equals(searchItem.ItemSearch(UserInput)))
            {
                matchFound = true;
                break;
            }

        }
        Assert.True(matchFound, $"The input {UserInput} was not found in the array.");



    }
    [Fact]
    public void SearchItem2()
    {
        TestFunction searchItem = new TestFunction();
        string UserInput = "Medecine2";
        string[] CurrentItemAvailable = { "Medecine1", "Medecine2", "Medecine3" };

        foreach (string x in CurrentItemAvailable)
        {
            if (x.Equals(searchItem.ItemSearch(UserInput)))
            {
                matchFound = true;
                break;
            }

        }
        Assert.True(matchFound, $"The input {UserInput} was not found in the array.");

    }
    //Hiniwalay ko yung Email and Pass test para makita ko kung tama yung ginawa ko HAHAHA last commit ko mali pala yung code T-T

    [Fact]
    public void EmailTest1()
    {
        TestFunction Login = new TestFunction();

        string Input1 = "UserExample@test.com";
        bool email = false;
        string[] TargetEmail = { "UserExample@test.com", "UserExample231@test.com", "testingEmail@test.com" };


        foreach (string x in TargetEmail)
        {
            if (x.Equals(Login.EmailVeriication(Input1)))
            {
                email = true;
                break;
            }
        }

        Assert.True(email, $"The Email is not in DB");
    }
    [Fact]
    public void EmailTest2()
    {
        string inpu2 = "User@gmail,com";
        TestFunction Login = new TestFunction();

        bool email = false;
        string[] TargetEmail = { "UserExample@test.com", "UserExample231@test.com", "testingEmail@test.com" };


        foreach (string x in TargetEmail)
        {
            if (x.Equals(Login.EmailVeriication(inpu2)))
            {
                email = true;
                break;
            }
        }

        Assert.True(email, $"The Email is not in DB");
    }
    [Fact]
    public void PassWordTest1()
    {
        string input1 = "Password231";
        TestFunction Login = new TestFunction();
        bool pass = false;
        string[] PassDB = { "Password231", "passwOrd2", "paswrd21" };

        foreach (string x in PassDB)
        {
            if (x.Equals(Login.PasswordVerification(input1)))
            {
                pass = true;
                break;
            }

        }
        Assert.True(pass, $"The password is not in DB");

    }

    [Fact]
    public void PassWordTest2()
    {
        string Input2 = "Passwosdas22";
        TestFunction Login = new TestFunction();
        bool pass = false;
        string[] PassDB = { "Password231", "passwOrd2", "paswrd21" };

        foreach (string x in PassDB)
        {
            if (x.Equals(Login.PasswordVerification(Input2)))
            {
                pass = true;
                break;
            }

        }
        Assert.True(pass, $"The password is not in DB");

    }
    [Fact]
    public void CartTest1()
    {
        string item1 = "Medecine1";
        string item2 = "Medecine2";
        string item3 = "Medecine3";

        var testFunction = new TestFunction();
        testFunction.AddItem(item1);
        testFunction.AddItem(item2);
        testFunction.AddItem(item3);
        var items = testFunction.GetItems();

        Assert.Collection(items,
            item => Assert.Equal("Medecine1", item),
            item => Assert.Equal("Medecine2", item),
            item => Assert.Equal("Medecine3", item)
            );
    }



}