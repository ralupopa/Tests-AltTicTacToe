## Prerequisite

1. Download and install [.NET SDK](https://dotnet.microsoft.com/en-us/download)
2. Download [AltTester Pro](https://alttester.com/alttester/#pricing)
3. Use AltTicTacToe from package downloaded above, as it is instrumented with sdk 2.0.0

# Tests created with NUnit & AltTester-Driver for a game developed w/ Unity (TrashCat)

This repository is a test project that uses NUnit as the test library. It was generated using following command (as suggested in [documentation](https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-nunit#creating-the-test-project))

```
dotnet new nunit
```

[AltTester Unity SDK framework](https://alttester.com/docs/sdk/) contains `AltDriver` class used to connect to the instrumented game developed w/ Unity. AltTester-Driver for C# is available as a nuget package. Install [AltTester-Driver nuget package](https://www.nuget.org/packages/AltTester-Driver#versions-body-tab)

```
dotnet add package AltTester-Driver --version 2.0.0
```

# Run tests manually (with [dotnet CLI](https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-test))

1. Launch game
2. From `AltTicTacToeTests` execute all tests:

```
dotnet test
```