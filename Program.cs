// // See https://aka.ms/new-console-template for more information


// string stranger = "Another";
// int one = 1;

// Console.WriteLine($"Hello, {stranger} {one}");

// Console.Write(stranger.IndexOf("n").ToString());

// int a = 10, b = 20, c = 40; 

// int sum = a + b + c;

// double d = 5.0,  e = 2.0; 

// double div = d / e;
// // int max = int.M

// Console.WriteLine($"The sum is {sum}");
// Console.WriteLine($"What is 70/3 { div }?");

// Console.WriteLine($"What is the max of double {double.MaxValue}");
// Console.WriteLine($"What is the max of int {int.MaxValue}");


// Console.WriteLine("--------------------------------------------------- List -------------------------------");

// // int[] arr2 = new int[] {1,2,3,4};
// var firstArr = new int[5] {-69, 46, 10, 1, 100};

// firstArr[1] = 20;


// // firstArr[0] = 100;

// for(var i =0; i < firstArr.Count(); i++)
// {
//     Console.WriteLine($"The value at {i} is {firstArr[i]}");
// }
// foreach(var el in firstArr)
// {
//     Console.WriteLine($"The value is {el}");
// }

// Console.WriteLine("--------------------------------------------------- List -------------------------------");

// List<int> list = new List<int>();

// list.AddRange(firstArr);
// list.Add(1000);
// list.Add(1001);
// list.Add(1002);

// foreach(var el in list)
// {
//     Console.WriteLine($"The value is {el}");
// }

// Console.WriteLine($"The first element is {list[0]}");



using Accounts;


BankAccount account = new BankAccount();

Console.WriteLine($"This is my account number {account.AccountNumber} and my bal {account.Balance}. Plus my name is {account.Owner}");

BankAccount account2 = new BankAccount("Morisseau", decimal.MinValue);

Console.WriteLine($"This is my account number 2 {account2.AccountNumber} and my bal {account2.Balance}. Plus my name id {account2.Owner}");

SavingAccount savings = new SavingAccount();
savings.InterestRate = 0.05m;
savings.Balance = 2000.0m;

savings.AddMonthlyInterest();

Console.WriteLine($"What is the balance {savings.Balance}");