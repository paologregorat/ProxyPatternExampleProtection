using ProxyPatternExampleProtection.Abstract;
using ProxyPatternExampleProtection.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProxyPatternExampleProtection.Controllers
{
    public class ProxyDocumentOperations : IDocumentOperations
    {
        private readonly bool _isAuthenticated;
        public ProxyDocumentOperations(string username, string password)
        {
            _isAuthenticated = false;
            if (username == "test" && password == "test")
                _isAuthenticated = true;
        }
        public Document GetDocument(int documentID)
        {
            if (!_isAuthenticated)
                new Exception("Not authorized");

            var docOp = new ConcreteDocumentOperations();
            return docOp.GetDocument(documentID);
        }

        public bool SaveDocument(Document document)
        {
            if (!_isAuthenticated)
                throw new Exception("Not authorized");

            var docOp = new ConcreteDocumentOperations();
            return docOp.SaveDocument(document);
        }
    }
}
