// WorkWithString();

void WorkWithString() {
    var names = new List<string> {"Pat", "Ana", "Felipe"};

    foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine();
    names.Add("Maria");
    names.Add("Bill");
    names.Remove("Ana");

    foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}!");
    }

    Console.WriteLine($"My name is {names[0]}");
    Console.WriteLine($"I've added {names[2]} and {names[3]} to the list");

    Console.WriteLine($"The list has {names.Count} people in it");

    var index = names.IndexOf("Felipe");

    if (index == -1) {
        Console.WriteLine($"When an item is not found, indexof returns {index}");
    } else {
        Console.WriteLine($"The name {names[index]} is at index {index}");    
    }

    index = names.IndexOf("Not Found");

    if (index == -1) {
        Console.WriteLine($"When an item is not found, IndexOf return {index}");
    } else {
        Console.WriteLine($"The name {names[index]} is at index {index}");
    }

    names.Sort();
    foreach (var name in names) {
        Console.WriteLine($"Hello {name.ToUpper()}");
    }
}

var fibonacciNumbers = new List<int> {1, 1};
// foreach (var item in fibonacciNumbers)
//     Console.WriteLine(item);

for (int x = 1; x < 20; x++) {
    var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
    var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

    fibonacciNumbers.Add(previous + previous2);
    
    Console.WriteLine(fibonacciNumbers[x]);
}