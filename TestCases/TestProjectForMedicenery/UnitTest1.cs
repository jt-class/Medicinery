namespace TestProjectForMedicenery
{
    public class UnitTest1
    {


        [Fact]
        public void AddedItemInTheCart(){
            int NumberOfItems[] = { 1, 2, 3 };
            int[] Items = NumberOfItems;
            AssertTrue(Items);
        }
        public void NotifyUsers() {
        
        }
        public void SearchItem() {
            string SearchedItem = "MedecineNumber1";
            string CurrentItemAvailable[] = { "Medecine1", "Medecine2", "Medecine3" };
            foreach (string i in CurrentItemAvailable) {
                Assert.AreEqual(i , SearchedItem);
            }

        
        }
        public void Login() {
            string UserName = "test@gmail.com";
            string PassWord = "test_passWOrd";
            string UserNameDB[] = { "test23@gmail.com", "test@gmail.com", "test2@gmail.co" }
            string PassWordDB[] = { "Test_passWORD", "test_passWOrd", "TEST_passWOrd" }
            foreach (string x in UserNameDB) {
                Assert.AreEqual(x , UserName);
            }
            foreach (string x in PassWordDB)
            {
                Assert.AreEqual(x, PassWord);
            }
        }

    }
}