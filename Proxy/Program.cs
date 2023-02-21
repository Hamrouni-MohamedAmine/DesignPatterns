using Proxy;

Console.Title = "Proxy";

//without proxy
Console.WriteLine("Constructing document");
var document = new Document("Document");
Console.WriteLine("Document constructed");
document.displayDocument();

Console.WriteLine();

//wit proxy
Console.WriteLine("Constructing document proxy");
var documentProxy = new DocumentProxy("DocumentProxy");
Console.WriteLine("Document proxy constructed");
documentProxy.DisplayDocument();

Console.WriteLine();

/// with chained proxy
Console.WriteLine("Constructing protected document proxy");
var protectedDocumentProxy = new ProtectedDocumentProxy("DocumentProxy", "Viewer");
Console.WriteLine("Document proxy constructed");
protectedDocumentProxy.DisplayDocument();

Console.WriteLine();

/// with chained proxy no acess
Console.WriteLine("Constructing protected document proxy");
protectedDocumentProxy = new ProtectedDocumentProxy("DocumentProxy", "AnotherRole");
Console.WriteLine("Document proxy constructed");
protectedDocumentProxy.DisplayDocument();

Console.ReadKey();