// Write Your First C# Code

Console.WriteLine("//////////////////////////////////////////////////// Write Your First C# Code ////////////////////////////////////////////////////");

Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");

// The three new lines of code you added demonstrated the difference between the
// Console.WriteLine() and Console.Write methods.

Console.WriteLine("\n\nSee https://aka.ms/new-console-template for more information");


Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Combine strings using character escape sequences ////////////////////////////////////////////////////");

Console.WriteLine("\n////////////////////////// The \"\\n\" sequence will add a new line, and a \"\\t\" sequence will add a tab //////////////////////////");


Console.WriteLine("\n1. Hello\nWorld!");
Console.WriteLine("\n2. Hello\tWorld!");

Console.WriteLine("\n////////////////////////// Use the \"\\\" escape sequence to add quotations //////////////////////////");

Console.WriteLine("\n3. Hello \"World\"!");

Console.WriteLine("\n////////////////////////// Use the \"\\\\\" escape sequence to add single backslash //////////////////////////");

Console.WriteLine("\n4. c:\\source\\repos");

Console.WriteLine("\n////////////////////////// Verbatim string literal //////////////////////////");
Console.WriteLine("\nA verbatim string literal will keep all whitespace and characters without the need to escape the backslash. To create a verbatim string, use the @ directive before the literal string.\n");

Console.WriteLine(@"5.    c:\source\repos    
        (this is where your code goes)");

Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Unicode escape characters ////////////////////////////////////////////////////");

Console.WriteLine("\nYou can also add encoded characters in literal strings using the \"\\u\" escape sequence, then a four-character code representing some character in Unicode (UTF-16).");

Console.WriteLine("\nExample: \"Kon'nichiwa World\"\nwrite like this...");

Console.WriteLine("\u3053\u3093\u306B\u3061\u306F World!");
Console.WriteLine("using \\u3053\\u3093\\u306B\\u3061\\u306F unicode.");

Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Combine strings using string concatenation ////////////////////////////////////////////////////");

Console.WriteLine("\n////////////////////////// Concatenate using + symbol //////////////////////////");

string name = "Ilyas";
string greeting = "Hello " + name;
Console.WriteLine(greeting);

Console.WriteLine("\n////////////////////////// Concatenate multiple variables and literal strings //////////////////////////");

string greeting2 = "Hello";
string message = greeting2 + " " + name + "!";
Console.WriteLine(message);

Console.WriteLine("\n////////////////////////// Avoiding intermediate variables //////////////////////////");

Console.WriteLine(greeting2 + " " + name + "!");


Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Combine strings using string interpolation ////////////////////////////////////////////////////");

Console.WriteLine("\n////////////////////////// What is string interpolation? //////////////////////////");

Console.WriteLine("\nString interpolation combines multiple values into a single literal string by using a \"template\" and one or more interpolation expressions. An interpolation expression is a variable surrounded by an opening and closing curly brace symbol { }. The literal string becomes a template when it's prefixed by the $ character.");

Console.WriteLine("\nIn other words, instead of writing the following line of code:\n\"string message = greeting + \" \" + firstName + \"!\"");

Console.WriteLine("You can write this more concise line of code instead: \nstring message = $\"{greeting} {firstName}!\"");

string newMessage = $"Welcome {name}!";
Console.WriteLine($"Output: {newMessage}");

Console.WriteLine("\nAnother example");

int version = 11;
string updateText = "Update to Win";
string alert = $"{updateText} {version}";
Console.WriteLine(alert);

Console.WriteLine("\nOR");

int newVersion = 11;
string alertText = "Update to Win";
Console.WriteLine($"{alertText} {newVersion}");

Console.WriteLine("\n////////////////////////// Combine verbatim literals and string interpolation //////////////////////////\n");

string projectName = "First-Project";
Console.WriteLine($@"C:\Output\{projectName}\Data");

Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Challange ////////////////////////////////////////////////////");

Console.WriteLine("\nThis is the desired output..,");

Console.WriteLine("\nView English output:");
Console.WriteLine("\n\tc:\\Exercise\\ACME\\data.txt");

Console.WriteLine("\nПосмотреть русский вывод:");
Console.WriteLine("\n\tc:\\Exercise\\ACME\\ru-RU\\data.txt\n");

string proName = "ACME";

string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";

// solution

string location1 = $@"c:\Exercise\{proName}\data.txt";

string location2 = $@"c:\Exercise\{proName}\ru-RU\data.txt";


Console.WriteLine($"\nView English output:\n\t\t{location1}");

Console.WriteLine($"\n{russianMessage}\n\t\t{location2}");



Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Guided projects ////////////////////////////////////////////////////");

Console.WriteLine("\n////////////////////////// Calculate and print student grade //////////////////////////\n");

int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;

int sophiaTotal = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasTotal = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahTotal = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongTotal = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

decimal sophiaGrade = (decimal) sophiaTotal / currentAssignments;
decimal nicolasGrade = (decimal) nicolasTotal / currentAssignments;
decimal zahirahGrade = (decimal) zahirahTotal / currentAssignments;
decimal jeongGrade = (decimal) jeongTotal / currentAssignments;

Console.WriteLine($"Sophia: {sophia1}, {sophia2}, {sophia3}, {sophia4}, {sophia5}");
Console.WriteLine($"\nNicolas: {nicolas1}, {nicolas2}, {nicolas3}, {nicolas4}, {nicolas5}");
Console.WriteLine($"\nZahirah: {zahirah1}, {zahirah2}, {zahirah3}, {zahirah4}, {zahirah5}");
Console.WriteLine($"\nJeong: {jeong1}, {jeong2}, {jeong3}, {jeong4}, {jeong5}");

Console.WriteLine("\n\n\nStudent\t\tGrade");
Console.WriteLine($"Sophia\t\t{sophiaGrade}\tA");
Console.WriteLine($"Nicolas\t\t{nicolasGrade}\tB");
Console.WriteLine($"Zahirah\t\t{zahirahGrade}\tB");
Console.WriteLine($"Jeong\t\t{jeongGrade}\tA");


Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Calculate Final GPA ////////////////////////////////////////////////////");

Console.WriteLine("\\\\I have changed student name and course names to my liking.");

string studentName = "Ilyas Sayyed";
string course1Name = "Java 101";
string course2Name = "Cyber Security 102";
string course3Name = "Python 103";
string course4Name = "OOSE 104";
string course5Name = "C#";

int course1Credit = 3;
int course2Credit = 3;
int course3Credit = 4;
int course4Credit = 4;
int course5Credit = 3;

int gradeA = 4;
int gradeB = 3;

int course1Grade = gradeA;
int course2Grade = gradeB;
int course3Grade = gradeB;
int course4Grade = gradeB;
int course5Grade = gradeA;

int totalCreditHours = 0;

totalCreditHours += course1Credit;
totalCreditHours += course2Credit;
totalCreditHours += course3Credit;
totalCreditHours += course4Credit;
totalCreditHours += course5Credit;

int totalGradePoints = 0;

totalGradePoints += course1Credit * course1Grade;
totalGradePoints += course2Credit * course2Grade;
totalGradePoints += course3Credit * course3Grade;
totalGradePoints += course4Credit * course4Grade;
totalGradePoints += course5Credit * course5Grade;

decimal gradePointAverage = (decimal) totalGradePoints / totalCreditHours;

int leadingDigit = (int) gradePointAverage;
int firstDigit = (int) (gradePointAverage * 10) % 10;
int secondDigit = (int) (gradePointAverage *100) % 10;

Console.WriteLine($"\n\n\nStudent: {studentName}\n");
Console.WriteLine($"Course\t\t\t\tGrade\tCredit Hours");

Console.WriteLine($"{course1Name}\t\t\t{course1Grade}\t\t{course1Credit}");
Console.WriteLine($"{course2Name}\t\t{course2Grade}\t\t{course2Credit}");
Console.WriteLine($"{course3Name}\t\t\t{course3Grade}\t\t{course3Credit}");
Console.WriteLine($"{course4Name}\t\t\t{course4Grade}\t\t{course4Credit}");
Console.WriteLine($"{course5Name}\t\t\t\t{course5Grade}\t\t{course5Credit}");

Console.WriteLine($"\nFinal GPA:\t\t\t{leadingDigit}.{firstDigit}{secondDigit}");