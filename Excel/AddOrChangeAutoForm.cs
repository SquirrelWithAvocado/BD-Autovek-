using System;
using System.Windows.Forms;
using System.Drawing;
using System.Text.Json;

namespace Excel.App
{
    public partial class AddOrChangeAutoForm : Form
    {
        private CarsInformationForm _pastApp;
        private Client _curClient;
        private int _carId;

        public AddOrChangeAutoForm(Client curClient, CarsInformationForm pastApp, int carId)
        {
            _curClient = curClient;
            _carId = carId;
            _pastApp = pastApp;
            ClientSize = new Size(810, 470);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            InitializeComponent();
            if (carId < _curClient.Cars.Count)
                DrawTextBoxes();
        }

        private void DrawTextBoxes()
        {
            textBox1.Text = _curClient.Cars[_carId].Id;
            textBox2.Text = _curClient.Cars[_carId].Model;
            textBox3.Text = _curClient.Cars[_carId].TypeCar;
            textBox4.Text = _curClient.Cars[_carId].CategoryCar;
            textBox5.Text = _curClient.Cars[_carId].YearManufacture; 
            textBox6.Text = _curClient.Cars[_carId].Chassis;
            textBox7.Text = _curClient.Cars[_carId].Cabin;
            textBox8.Text = _curClient.Cars[_carId].ColorCabin;
            textBox9.Text = _curClient.Cars[_carId].PassportCar;
        }

        private void AddCar(
            string vin, 
            string model, 
            string name, 
            string category,
            string date,
            string gears,
            string surface,
            string color,
            string passport
        )
        {
            if (_carId < _curClient.Cars.Count)
                _curClient.Cars[_carId] = new Car
                {
                    VIN = vin,
                    Cabin = surface,
                    CategoryCar = category,
                    Chassis = gears,
                    ColorCabin = color,
                    ClientId = _curClient.Id,
                    PassportCar = passport,
                    Id = _carId.ToString(),
                    Mileage = "",
                    Model = model,
                    TypeCar = name,
                    YearManufacture = date
                };
            else
                _curClient.Cars.Add(new Car
                {
                    VIN = vin,
                    Cabin = surface,
                    CategoryCar = category,
                    Chassis = gears,
                    ColorCabin = color,
                    ClientId = _curClient.Id,
                    PassportCar = passport,
                    Id = vin,
                    Mileage = "",
                    Model = model,
                    TypeCar = name,
                    YearManufacture = date
                });

            PutDataCar(JsonSerializer.Serialize(_curClient), "clients");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var vin = textBox1.Text;
            var model = textBox2.Text;
            var name = textBox3.Text;
            var category = textBox4.Text;
            var date = textBox5.Text;
            var gears = textBox6.Text;
            var surface = textBox7.Text;
            var color = textBox8.Text;
            var passport = textBox9.Text;

            AddCar(vin, model, name, category, date, gears, surface, color, passport);
            
            Hide();
            _pastApp.UpdateAll();
            _pastApp.Show();
        }

        private void PutDataCar(string content, string prefix)
        {
            var response = HttpRequester.SendPost(content, prefix);

            if (response.IsSuccessStatusCode)
                MessageBox.Show("Информация об авто обновлена");
            else
                MessageBox.Show("Обновление не удалось, попробуйте ещё раз");
        }
    }
}