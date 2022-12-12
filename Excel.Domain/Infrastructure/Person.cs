namespace Excel.Infrastructure
{
    public class Person //to excel.datalayer
    {
        // public static void GetDatabase() Получается вспомогательный метод. Получаем данные клиента из бд.
        public int Id { get; }
        public string NumberСar { get; }
        public string Name { get; }
        public string Surname { get; }
        public string MiddleName { get; }
        public string Car { get; }
        public int ContractIndex { get; }

        public Person()
        {
            Id = 0;
            Car = "Lada";
            NumberСar = "A012BC 77";
            Name = "Олег";
            Surname = "Буба";
            MiddleName = "Олегович";
            ContractIndex = 1;
        }

        public void GetDataBase()
        {
            
        }
    }
}
