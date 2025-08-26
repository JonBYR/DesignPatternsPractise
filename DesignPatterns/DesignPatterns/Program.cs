// See https://aka.ms/new-console-template for more information
using DesignPatterns.Iterator;
using DesignPatterns.Memento;
using DesignPatterns.ChainOfResponsibility;
using DesignPatterns.Builder;
Console.WriteLine("Hello, World!");
/*
History history = new History();
Document document = new Document("Hello World", "Arial", 12);
history.push(new DocumentState(document.getContent(), document.getFontName(), document.getFontSize()));
document.setContent("Hello Universe");
document.setFontName("Times New Roman");
document.setFontSize(14);
history.push(new DocumentState(document.getContent(), document.getFontName(), document.getFontSize()));
document.setContent("Hello Multiverse");
document.setFontName("Courier New");
document.setFontSize(16);
document.undo(history.pop());
Console.WriteLine(document.getContent());
*/
/*
BrowseHistory history = new BrowseHistory();
history.Push("https://google.com");
history.Push("https://github.com");
history.Push("https://stackoverflow.com");
Iteartor<string> iterator = history.createIterator();
while (iterator.HasNext())
{
    Console.WriteLine(iterator.Current());
    iterator.Next();
}
*/
/*
var logger = new Logger(null); //last element of linked list in chain of command
var compressor = new Compressor(logger);
var authenticator = new Authenticator(compressor);
var server = new Server(authenticator);
var request = new HttpRequest("admin", "password");
server.handle(request);
*/
Presentation present = new Presentation();
PdfBuilder builder = new PdfBuilder();
present.export(builder);
var pdf = builder.getPdfdocument();
