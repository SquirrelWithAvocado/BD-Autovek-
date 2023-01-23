using System;

namespace Excel.Infrastructure
{
    public class NullSheetException : Exception
    {
        public NullSheetException(Exception nullSheetException) :
            base("Документ не может быть заполнен, так как нет значения листов excel", 
                nullSheetException) { }
    }
}