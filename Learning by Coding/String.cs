//string aFriend = "Scott";
//Console.WriteLine($"Hello { aFriend}");

//Length
//string firstFriend = "Jetpreeya";
//string secondFriend = "Amy";
//Console.WriteLine($"My friend are {firstFriend} and {secondFriend}");

//Console.WriteLine($"The name {firstFriend} has {firstFriend.Length} letters.");
//Console.WriteLine($"The name {secondFriend} has {secondFriend.Length} letters.");

//Trim
//string greeting = "    Hello World ! ";
//Console.WriteLine($"[{greeting}]");

//String trimmedGreeting = greeting.TrimStart();
//Console.WriteLine($"[{trimmedGreeting}]");

//trimmedGreeting = greeting.TrimEnd();
//Console.WriteLine($"[{trimmedGreeting}]");

//trimmedGreeting = greeting.Trim();
//Console.WriteLine($"[{trimmedGreeting}]");

//Replace
//string sayHello = "Hello World";
//Console.WriteLine(sayHello);

//sayHello = sayHello.Replace("Hello", "Greetings");
//Console.WriteLine(sayHello);

////ToUpper is capital letter, ToLower is small letter
//Console.WriteLine(sayHello.ToUpper());
//Console.WriteLine(sayHello.ToLower());

//Search strings TRUE || FALSE
//string songLyrics = "YOU say goodbye, and I say hello";
//Console.WriteLine(songLyrics.Contains("goodbye"));
//Console.WriteLine(songLyrics.Contains("greetings"));

string songLyrics = "You say greetings, and I say hello";
var result = songLyrics.StartsWith("You");
Console.WriteLine(result);

Console.WriteLine(songLyrics.Contains("greetings"));

