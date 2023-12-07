using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
    {
    private String accountName;
    private Decimal balance ;
    public BankAccount(String acountNam) {
    this.accountName = acountNam;
        this.balance = 0;
    }
    public void Deposit(Decimal balance) { 
    this.balance += balance;
    }
    public void Withdraw(Decimal balance)
    {
        this.balance -= balance;
    }
   public void Balance() => Console.WriteLine(this.balance);

}


