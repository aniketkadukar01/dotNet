using BankingApp;

Account account = new Account();
account.balance = 560000;


account.overBalance += BankingApp.EventHandler.payIncomeTax;
account.overBalance += BankingApp.EventHandler.sendSms;

account.underBalance += BankingApp.EventHandler.blockAccount;

account.withdraw(10000);