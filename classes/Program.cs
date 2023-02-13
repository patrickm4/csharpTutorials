using Classes;

var account = new BankAccount("Pat", 1000);

account.MakeWIthdrawal(500, DateTime.Now, "Rent payment");
Console.WriteLine(account.Balance);
account.MakeDeposit(100, DateTime.Now, "Friend paid me back");
Console.WriteLine(account.Balance);

// test for negative balance
try {
    account.MakeWIthdrawal(750, DateTime.Now, "Attempt to overdraw");
}
catch (InvalidOperationException e) {
    Console.WriteLine("Exception caught trying to overdraw");
    Console.WriteLine(e.ToString());
}

// test initial balance is positive
BankAccount invalidAccount;
try {
    invalidAccount = new BankAccount("invalid", -55);
}
catch (ArgumentOutOfRangeException e) {
    Console.WriteLine("Exception caught creating account with negative balance");
    Console.WriteLine(e.ToString());
}

Console.WriteLine($"Account {account.Number} was created for {account.Owner} with {account.Balance} initial balance.");

Console.WriteLine(account.GetAccountHistory());
