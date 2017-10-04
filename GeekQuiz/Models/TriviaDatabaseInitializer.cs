namespace GeekQuiz.Models
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Web;

    public class TriviaDatabaseInitializer : CreateDatabaseIfNotExists<TriviaContext>
    {
        protected override void Seed(TriviaContext context)
        {
            base.Seed(context);

            var questions = new List<TriviaQuestion>();

            questions.Add(new TriviaQuestion
            {
                Title = "What does the keyword virtual mean in the method definition?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "The method is public", IsCorrect = false },
                    new TriviaOption { Title = "The method can be derived", IsCorrect = false },
                    new TriviaOption { Title = "The method can be over-ridden", IsCorrect = true },
                    new TriviaOption { Title = "The method is static", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Readonly variables...",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Are allocated at compile time", IsCorrect = false },
                    new TriviaOption { Title = "Can have declaration and initialization separated", IsCorrect = false },
                    new TriviaOption { Title = "Are initialized at runtime", IsCorrect = false },
                    new TriviaOption { Title = "All of the above", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "How is a single line comment made in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "#", IsCorrect = false },
                    new TriviaOption { Title = "<!--", IsCorrect = false },
                    new TriviaOption { Title = "//", IsCorrect = true },
                    new TriviaOption { Title = "[comment]", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is a 'sealed' class in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "A class that must be inherited", IsCorrect = false },
                    new TriviaOption { Title = "An interface", IsCorrect = false },
                    new TriviaOption { Title = "A class that cannot be inherited", IsCorrect = true },
                    new TriviaOption { Title = "A class with no methods", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What are namespaces in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "containers for classes", IsCorrect = true },
                    new TriviaOption { Title = "strings", IsCorrect = false },
                    new TriviaOption { Title = "sealed classes", IsCorrect = false },
                    new TriviaOption { Title = "variables that haven't been declared", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is the keyword 'const' used for?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "To start a constructor", IsCorrect = false },
                    new TriviaOption { Title = "To define what constitutes a class", IsCorrect = false },
                    new TriviaOption { Title = "To declare a constant, unchangeable value", IsCorrect = true },
                    new TriviaOption { Title = "to reference the constitution namespace", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "How many loop constructs are there in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "2", IsCorrect = false },
                    new TriviaOption { Title = "3", IsCorrect = false },
                    new TriviaOption { Title = "4", IsCorrect = true },
                    new TriviaOption { Title = "5", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "How is exception handling done in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "An 'if...then' block'", IsCorrect = false },
                    new TriviaOption { Title = "A 'try...catch' block", IsCorrect = true },
                    new TriviaOption { Title = "Console logging", IsCorrect = false },
                    new TriviaOption { Title = "Discreet intervals", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What are the two types of errors in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Compile Time and Run Time", IsCorrect = true },
                    new TriviaOption { Title = "Run Time and Initialization", IsCorrect = false },
                    new TriviaOption { Title = "Initialization and Connection", IsCorrect = false },
                    new TriviaOption { Title = "Connection and Logic", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What kind of method does not return a value?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "void", IsCorrect = true },
                    new TriviaOption { Title = "empty", IsCorrect = false },
                    new TriviaOption { Title = "static", IsCorrect = false },
                    new TriviaOption { Title = "output", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is a jagged array?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "An array of arrays with different sizes", IsCorrect = true },
                    new TriviaOption { Title = "An array with an odd amount of members", IsCorrect = false },
                    new TriviaOption { Title = "An array of both int and string types", IsCorrect = false },
                    new TriviaOption { Title = "There is no such thing", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which of these is not a number value type?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "long", IsCorrect = false },
                    new TriviaOption { Title = "double", IsCorrect = false },
                    new TriviaOption { Title = "int", IsCorrect = false },
                    new TriviaOption { Title = "string", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Where are reference types stored?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "A floppy disk", IsCorrect = false },
                    new TriviaOption { Title = "The stack", IsCorrect = false },
                    new TriviaOption { Title = "The heap", IsCorrect = true },
                    new TriviaOption { Title = "On the cloud", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Where are value types stored?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "The heap", IsCorrect = false },
                    new TriviaOption { Title = "The cloud", IsCorrect = false },
                    new TriviaOption { Title = "The stack", IsCorrect = true },
                    new TriviaOption { Title = "A flash drive", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is the difference between String and StringBuilder?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "StringBuilder is mutable, String is not", IsCorrect = true },
                    new TriviaOption { Title = "StringBuilder is an array of Strings", IsCorrect = false },
                    new TriviaOption { Title = "String is mutable, StringBuilder is not", IsCorrect = false },
                    new TriviaOption { Title = "They are the same thing in different namespaces", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "How we can sort the array elements in descending order in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Sort() and Backward()", IsCorrect = false },
                    new TriviaOption { Title = "Reverse.Sort()", IsCorrect = false },
                    new TriviaOption { Title = "SortZ->A()", IsCorrect = false },
                    new TriviaOption { Title = "Sort() and Reverse()", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is the 'is' operator used for?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "Declare a var", IsCorrect = false },
                    new TriviaOption { Title = "Check for type", IsCorrect = true },
                    new TriviaOption { Title = "Change a value", IsCorrect = false },
                    new TriviaOption { Title = "Cast into a class", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Is C# managed or unmanaged code?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "managed", IsCorrect = true },
                    new TriviaOption { Title = "unmanaged", IsCorrect = false },
                    new TriviaOption { Title = "it can be both", IsCorrect = false },
                    new TriviaOption { Title = "neither", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is a hashtable?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "An array of numbers", IsCorrect = false },
                    new TriviaOption { Title = "A table that compiles code", IsCorrect = false },
                    new TriviaOption { Title = "A relational database connection", IsCorrect = false },
                    new TriviaOption { Title = "A way to store key/value pairs", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "How can you check whether a hash table contains specific key in C#",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "HasKey", IsCorrect = false },
                    new TriviaOption { Title = "ContainsValue", IsCorrect = false },
                    new TriviaOption { Title = "HasValue", IsCorrect = false },
                    new TriviaOption { Title = "ContainsKey", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is enum in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "a sorted array", IsCorrect = false },
                    new TriviaOption { Title = "an enumeration explaining a method", IsCorrect = false },
                    new TriviaOption { Title = "a public class", IsCorrect = false },
                    new TriviaOption { Title = "an enumeration of named constants", IsCorrect = true }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which is not a loop type in C#?",
                Options = (new TriviaOption[]
                {
                    new TriviaOption { Title = "For", IsCorrect = false },
                    new TriviaOption { Title = "During", IsCorrect = true },
                    new TriviaOption { Title = "While", IsCorrect = false },
                    new TriviaOption { Title = "Do...While", IsCorrect = false }
                }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What does the 'continue' statement do?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "breaks out of a loop", IsCorrect = false },
                        new TriviaOption { Title = "passes control to the next iteration", IsCorrect = true },
                        new TriviaOption { Title = "passes to another method", IsCorrect = false },
                        new TriviaOption { Title = "passes to another class", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What does the 'break' statement do?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "calls the garbage collector", IsCorrect = false },
                        new TriviaOption { Title = "crashes a program", IsCorrect = false },
                        new TriviaOption { Title = "exits a loop", IsCorrect = true },
                        new TriviaOption { Title = "deletes a class", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is boxing in C#?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "Two variables that come to fisticuffs", IsCorrect = false },
                        new TriviaOption { Title = "Converting a value type to reference type", IsCorrect = true },
                        new TriviaOption { Title = "Converting a reference type to a value type", IsCorrect = false },
                        new TriviaOption { Title = "Compiling code", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is unboxing in C#?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "Converting a value type to a reference type", IsCorrect = false },
                        new TriviaOption { Title = "Compiling code", IsCorrect = false },
                        new TriviaOption { Title = "Unzipping a file", IsCorrect = false },
                        new TriviaOption { Title = "Converting a reference type to a value type", IsCorrect = true }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is the compiler of C#?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "Windows Black Box", IsCorrect = false },
                        new TriviaOption { Title = "CSC", IsCorrect = true },
                        new TriviaOption { Title = "DLL", IsCorrect = false },
                        new TriviaOption { Title = "Boolean", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What term is used for the execution path of a program?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "dll", IsCorrect = false },
                        new TriviaOption { Title = ".exe", IsCorrect = false },
                        new TriviaOption { Title = "Path", IsCorrect = false },
                        new TriviaOption { Title = "Thread", IsCorrect = true }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which is the correct way to concat two strings?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "string.Concat(firstStr, secStr)", IsCorrect = true },
                        new TriviaOption { Title = "firstStr.Concat(secString)", IsCorrect = false },
                        new TriviaOption { Title = "firstStr+secStr", IsCorrect = false },
                        new TriviaOption { Title = "firstStr += secStr", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "In the acronym PaaS, what does the P stand for?",
                Options = (
                    new TriviaOption[] 
                    {
                        new TriviaOption { Title = "Programming", IsCorrect = false },
                        new TriviaOption { Title = "Power", IsCorrect = false },
                        new TriviaOption { Title = "Platform", IsCorrect = true },
                        new TriviaOption { Title = "Pedestrian", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is the speed of light in metres per second?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "299,792,458", IsCorrect = true },
                        new TriviaOption { Title = "312,123,156", IsCorrect = false },
                        new TriviaOption { Title = "100,000,000", IsCorrect = false },
                        new TriviaOption { Title = "541,123,102", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What was the original name of the C# programming language?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "Boo", IsCorrect = false },
                        new TriviaOption { Title = "C+++", IsCorrect = false },
                        new TriviaOption { Title = "Cool", IsCorrect = true },
                        new TriviaOption { Title = "Anders", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which of the following is an example of Boxing in C#?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "int foo = 12;", IsCorrect = false },
                        new TriviaOption { Title = "System.Box(56);", IsCorrect = false },
                        new TriviaOption { Title = "int foo = (int)bar;", IsCorrect = false },
                        new TriviaOption { Title = "object bar = 42;", IsCorrect = true }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which of the following was not an alternative name considered for XML?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "MAGMA", IsCorrect = false },
                        new TriviaOption { Title = "SGML", IsCorrect = true },
                        new TriviaOption { Title = "SLIM", IsCorrect = false },
                        new TriviaOption { Title = "MGML", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "How many HTML tags are defined in the original description of the markup language?",
                Options = (
                    new TriviaOption[] 
                    {
                        new TriviaOption { Title = "1", IsCorrect = false },
                        new TriviaOption { Title = "11", IsCorrect = false },
                        new TriviaOption { Title = "18", IsCorrect = true },
                        new TriviaOption { Title = "25", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which of the following ECMA standards represents the standardization of JavaScript?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "ECMA-123", IsCorrect = false },
                        new TriviaOption { Title = "ECMA-262", IsCorrect = true },
                        new TriviaOption { Title = "ECMA-301", IsCorrect = false },
                        new TriviaOption { Title = "ECMA-431", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What was the first Web Browser called?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "WorldWideWeb", IsCorrect = true },
                        new TriviaOption { Title = "Mosaic", IsCorrect = false },
                        new TriviaOption { Title = "Lynx", IsCorrect = false },
                        new TriviaOption { Title = "Gopher", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "In version control systems, the process of bringing together two sets of changes is called what?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "Branch", IsCorrect = false },
                        new TriviaOption { Title = "Commit", IsCorrect = false },
                        new TriviaOption { Title = "Merge", IsCorrect = true },
                        new TriviaOption { Title = "Share", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "In 1980, Microsoft released their first operating system. What was it called?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "MS-DOS", IsCorrect = false },
                        new TriviaOption { Title = "Windows", IsCorrect = false },
                        new TriviaOption { Title = "Xenix", IsCorrect = true },
                        new TriviaOption { Title = "Altair OS", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which ASCII code (in decimal) represents the character B?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "22", IsCorrect = false },
                        new TriviaOption { Title = "66", IsCorrect = true },
                        new TriviaOption { Title = "97", IsCorrect = false },
                        new TriviaOption { Title = "112", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which are the first 6 decimal digits of Pi?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "3.14159", IsCorrect = true },
                        new TriviaOption { Title = "3.14195", IsCorrect = false },
                        new TriviaOption { Title = "3.14132", IsCorrect = false },
                        new TriviaOption { Title = "3.14123", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Internet Protocol v4 provides approximately how many addresses?",
                Options = (
                    new TriviaOption[] 
                    {
                        new TriviaOption { Title = "1.5 billion", IsCorrect = false },
                        new TriviaOption { Title = "4.3 billion", IsCorrect = true },
                        new TriviaOption { Title = "55 billion", IsCorrect = false },
                        new TriviaOption { Title = "3.4 trillion", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "What is Layer 4 of the OSI Model?",
                Options = (
                    new TriviaOption[] 
                    {
                        new TriviaOption { Title = "Network Layer", IsCorrect = false },
                        new TriviaOption { Title = "Transport Layer", IsCorrect = true },
                        new TriviaOption { Title = "Session Layer", IsCorrect = false },
                        new TriviaOption { Title = "Presentation Layer", IsCorrect = false }
                    }).ToList()
            });

            questions.Add(new TriviaQuestion
            {
                Title = "Which of the following is NOT a value type in the .NET Framework Common Type System?",
                Options = (
                    new TriviaOption[]
                    {
                        new TriviaOption { Title = "System.Integer", IsCorrect = false },
                        new TriviaOption { Title = "System.String", IsCorrect = true },
                        new TriviaOption { Title = "System.DateTime", IsCorrect = false },
                        new TriviaOption { Title = "System.Float", IsCorrect = false }
                    }).ToList()
            });

            questions.ForEach(a => context.TriviaQuestions.Add(a));

            context.SaveChanges();
        }
    }
}