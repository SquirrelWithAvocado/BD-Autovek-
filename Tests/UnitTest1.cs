using System.Collections.Generic;
using NUnit.Framework;
using Server;

namespace Tests
{
    [TestFixture]
    public class DatabaseTests
    {
        public MySqlContext DbContext;
        public MySqlRepository DbRepository;
        public Client DefaultClient;
        
        [SetUp]
        public void Setup()
        {
            DbContext = new MySqlContext();
            
            var clientCars = new List<Car>();
            clientCars.Add(new Car{ Id = "AA908A", ClientId = "75693475", Model = "Lada 2111", Color = "Red"});

            var clientOperations = new List<Operation>();
            clientOperations.Add(
                new Operation
                {
                    Id = "321", 
                    ClientId = "75693475",
                    Name = "Coloring", 
                    Price = "1000rub", 
                    Status = "Ready", 
                    Comment = ""
                }
            );
            
            DbRepository = new MySqlRepository();
            DefaultClient = new Client {
                Id = "75693475",
                Name = "Ivan",
                Surname = "Ivanov",
                Patronymic = "Ivanovich",
                Registration = "Ekaterinburg city",
                Cars = clientCars,
                Operations = clientOperations
            };
        }

        [Test]
        public void AddDefaultClient()
        {
            DbRepository.Add(DefaultClient);
            Assert.True(true);
        }
        
        [Test]
        public void DeleteDataBase()
        {
            DbContext.DeleteData();
            Assert.True(true);
        }
    }
}