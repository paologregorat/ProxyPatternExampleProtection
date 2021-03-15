using ProxyPatternExampleProtection.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPatternExampleProtection.Concrete
{
    public class ConcreteDocumentOperations : IDocumentOperations
    {
        public Document GetDocument(int documentID)
        {
            return new Document("Doc saved","Text doc","Summary doc");
        }

        public bool SaveDocument(Document document)
        {
            return true;
        }
    }
}
