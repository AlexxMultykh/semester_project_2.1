using Antlr4.Runtime;
using semesterProject2;
using semesterProject2.Content;

var fileName = "Content/test.ls"; // args[0];
var fileContent = File.ReadAllText(fileName);

var inputStream = new AntlrInputStream(fileContent);
var languageLexer = new languageLexer(inputStream);
var commonTokenStream = new CommonTokenStream(languageLexer);
var languageParser = new languageParser(commonTokenStream);


var languageContext = languageParser.program();
var visitor = new LanguageVisitor();
visitor.Visit(languageContext);