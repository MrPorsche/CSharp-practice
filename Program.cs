/*
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

// This is the desired output..,

/*
View English output:
        c:\\Exercise\\ACME\\data.txt

Посмотреть русский вывод:
        c:\\Exercise\\ACME\\ru-RU\\data.txt\n
*/

/*
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

// I have changed student course names to my liking

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


Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Math class methods challenge ////////////////////////////////////////////////////");

Console.WriteLine("\n////////////////////////// Implement a method of the Math class that returns the larger of two numbers //////////////////////////");

int firstValue  = 500;
int secondValue = 600;
int largeValue;

largeValue = Math.Max(firstValue, secondValue);

Console.WriteLine($"The large value is: {largeValue}");

Console.WriteLine("\n////////////////////////// Random.Next() method //////////////////////////\n");

Random dice = new Random();

int roll = dice.Next(1, 30);
int roll2 = dice.Next(1, 30);
int roll3 = dice.Next(1, 40);

int total = roll + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll} + {roll2} + {roll3} + {total}");


Console.WriteLine("\n////////////////////////// Conditions //////////////////////////");
Console.WriteLine("\n////////////////////////// if, else, and else if practice //////////////////////////");

if ((roll == roll2) || (roll2 == roll3) || (roll3 == roll)) { // "||" logical OR operator
        if ((roll == roll2) && (roll2 == roll3)) { // "&&" logical AND operator
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
                Console.WriteLine($"Your new score is: {total}");
        }
        else
        {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
                Console.WriteLine($"Your new score is: {total}");
        }
}

if (total >= 90) {
        Console.WriteLine("\nAwesome! You have won a Brand New car.");
}
else if (total >= 72) {
        Console.WriteLine("\nWonderful! You have won a New Laptop.");
}
else if (total >= 55) {
        Console.WriteLine("\nAmazing! You have won a Trip for two.");
}
else if (total >= 40) {
        Console.WriteLine("\nGreat! You have won a Pet.");
}
else if (total >= 28) {
        Console.WriteLine("\nCool! You have won another Round.");
}
else {
        Console.WriteLine("\nSorry! Better luck next time.");
}

Console.WriteLine("\n\n////////////////////////// Challenge: Improve renewal rate of subscriptions //////////////////////////");

Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage  = 0;

if (daysUntilExpiration == 0) {
        Console.WriteLine("Your subscription has expired.");
} else if (daysUntilExpiration == 1) {
        Console.WriteLine("Your subscription expires within a day!");
        discountPercentage = 20;
} else if (daysUntilExpiration <= 5) {
        Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
        discountPercentage = 10;
} else if (daysUntilExpiration <= 10) {
        Console.WriteLine("Your subscription will expire soon. Renew now!");
}

if (discountPercentage > 0) {
        Console.WriteLine($"Renew now and save upto {discountPercentage}%.");
}
Console.WriteLine("\n\n\n\n\n//////////////////////////////////////////////////// Arrays ////////////////////////////////////////////////////");

string[] fraudulentOrderIDs = new string[3];

fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";
// fraudulentOrderIDs[3] = "D000";

Console.WriteLine("\n\n////////////////////////// Another way of declaring OR initializing an Array //////////////////////////");

string[] fraudulentOrderIDs = {"A123" , "B456", "C789"};

Console.WriteLine($"First element of you array is: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second element of your array is: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third element of your array is: {fraudulentOrderIDs[2]}");

fraudulentOrderIDs[0] ="F000";
Console.WriteLine($"First element is reassign to: {fraudulentOrderIDs[0]}");

Console.WriteLine($"There are {fraudulentOrderIDs.Length} faudulent orders to process.");

Console.WriteLine("\n\n////////////////////////// foreach statement //////////////////////////");

int[] inventory = {200, 450, 700, 175, 250};
int sum = 0;
int bin = 0;
foreach (int items in inventory) {
        sum += items;
        bin++;
        Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

Console.WriteLine($"We have {sum} items in inventory.");
*/
Console.WriteLine("\n\n////////////////////////// Challenge: Report the Order IDs that need further investigation //////////////////////////");

string[] suspeciouseOrderIDs = {"B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179"};

Console.WriteLine("Below are the suspeciouse order IDs");

foreach (string orderID in suspeciouseOrderIDs) {
        if (orderID.StartsWith("B")) {
                Console.WriteLine(orderID);
        }
}