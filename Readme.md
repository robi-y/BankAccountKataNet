Bank account kata
=================

Think of your personal bank account experience.
When in doubt, go for the simplest solution.
Try outside in test driven development.

Requirements
------------

Create a simple banking application with the following features:

- Deposit into an Account
- Withdraw from an Account
- Print a bank statement to the console


Acceptance criteria: Statement should have transactions in the following format:

|DATE       | AMOUNT  | BALANCE   |
|-----------|---------|-----------|
|10/11/2015 |  500.00 | 1400.00   |
|02/11/2015 | -100.00 | 900.00    |
|01/11/2015 | 1000.00 | 1000.00   |

[Print Statement Acceprace Test](PrintStatementFeature.md)

Constrains
----------

Start with a class like this:

```C#
public class Account {
    public void Deposit(int amount);
	public void Withdraw(int amount);	
	public void PrintStatement();
}
```

1. You can not add other public methods
2. For simplicity, use strings and integers for dates and amounts
3. Spaces in formatting can also be ignored


This follows a tutorial from @sandromancuso, see their for other design/implementation constrasins.
 

#### For more information:

-  [Object Calisthenics pdf](http://www.cs.helsinki.fi/u/luontola/tdd-2009/ext/ObjectCalisthenics.pdf)
-  Object Calisthenics (full book), Jeff Bay in: The ThoughtWorks Anthology.
Pragmatic Bookshelf 2008
-  Original idea for the kata: How Object-Oriented Are You Feeling Today? - Krzysztof Jelski (Session on the Software Craftsmanship UK 2011 conference)
-  Sandro's [Kata repository](https://github.com/sandromancuso/Bank-kata)
-  [A Java verion](https://github.com/trikitrok/bank-kata)
  

