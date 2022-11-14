Console.WriteLine("Welcome to the Bank");

BankAccount account =
 new BankAccount(11000);

//account.balance = 100;
try {
    account.makeDeposit(-1);
} catch(Exception ex) {
    Console.WriteLine(ex.Message);
}

Console.Write($" Your balance is: {account.getBalance()} ");
Console.WriteLine($" Account Number: {account.accountNumber}");

// public class BankAccount {
//     public string accountNumber {get; set;} ="";
//     public decimal balance {get; set;}  = 0;
// }