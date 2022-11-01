using System;

namespace ClientData
{
    public class ClientData
    {
        public int Id { get; }
        public ClientName Name { get; }
        public PassportData PassportData { get; }
        public Car Car { get; }

        public ClientData(int id, ClientName name, PassportData passport, Car car)
        {
            Id = id;
            Name = name;
            PassportData = passport;
            Car = car;
        }
    }

    public class ClientName
    {
        public string Name { get; }
        public string Surname { get; }
    }

    public class PassportData
    {
        public string Id { get; }
        public DateTime BirthDate { get; }
        public string Registration { get; }
    }

    public class Car
    {
        public int Id { get; }
        public string Model { get; }
        public string Color { get; }
    }
}    