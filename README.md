# Multi-targeting tests covering a .NET Standard ClassLib

## Summary
This is an example for debugging and playground purposes.

To execute multi-targeted tests use the command line. The current directory should be your test project.

```console
dotnet build
dotnet test --framework netcoreapp2.1
dotnet test --framework net472
```