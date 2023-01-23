using System;

namespace Excel.Infrastructure
{
    public class NullDataException : Exception
    {
        public NullDataException(Exception nullDataException) :
            base("Документ не может быть заполнен, так как значение данных пустое", 
                nullDataException) { }
    }
}