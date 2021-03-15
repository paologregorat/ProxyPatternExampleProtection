using ProxyPatternExampleProtection.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPatternExampleProtection.Abstract
{
    public interface IDocumentOperations
    {
        public Document GetDocument(int documentID);
        public bool SaveDocument(Document document);
    }
}
