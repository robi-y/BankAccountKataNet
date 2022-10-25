# Modeling

```
[Account]->[<<ITransactionRepository>>], 
[Account]->[StatementPrinter], [StatementPrinter]->[Console],
[StatementPrinter]++->[StatementFormatter],
[<<ITransactionRepository>>]^-.-[InMemoryTransactionReopsitory]->[Clock]
```

![yUML IMmage](http://yuml.me/f466972a)