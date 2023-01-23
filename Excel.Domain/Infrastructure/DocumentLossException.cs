using System;

namespace Excel.Infrastructure
{
    public class DocumentLossException : Exception
    {
        public DocumentLossException(Exception documentLossException) :
            base("Нарушена целостность HashSet<Document> _documents",
                documentLossException) { }
    }
}