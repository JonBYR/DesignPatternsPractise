// See https://aka.ms/new-console-template for more information
using DesignPatterns.Memento;

Console.WriteLine("Hello, World!");
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
