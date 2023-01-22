using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace Excel.App
{
    public class Client
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Patronymic { get; set; }
        public string PlaceOfBirth { get; set; }
        public string DateOfBirth { get; set; }

        public List<Data> Passport { get; set; }
        public List<Operation> Operations { get; set; }
        public List<Car> Cars { get; set; }
    }

    [ComplexType]
    public class Data
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("client")]
        public string ClientId { get; set; }

        public string Series { get; set; }
        public string Number { get; set; }
        public string WhereIssued { get; set; }
        public string DateOfIssue { get; set; }
        public string DivisionCode { get; set; }
        public string PhoneNumber { get; set; }
        public string Registration { get; set; }
    }

    [ComplexType]
    public class Car
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("client")]
        public string ClientId { get; set; }

        public string VIN { get; set; }
        public string Model { get; set; }
        public string TypeCar { get; set; }
        public string CategoryCar { get; set; }
        public string YearManufacture { get; set; }
        public string Chassis { get; set; }
        public string Cabin { get; set; }
        public string ColorCabin { get; set; }
        public string PassportCar { get; set; }
        public string Mileage { get; set; }
    }

    [ComplexType]
    public class Operation
    {
        [Key]
        public string Id { get; set; }

        [ForeignKey("client")]
        public string ClientId { get; set; }

        public string Name { get; set; }
        public string Price { get; set; }
        public string Status { get; set; }
        public string Comment { get; set; }
    }
}