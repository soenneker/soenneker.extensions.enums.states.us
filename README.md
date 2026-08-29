[![](https://img.shields.io/nuget/v/soenneker.extensions.enums.states.us.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.enums.states.us/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.enums.states.us/publish-package.yml?style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.enums.states.us/actions/workflows/publish-package.yml)
[![](https://img.shields.io/nuget/dt/soenneker.extensions.enums.states.us.svg?style=for-the-badge)](https://www.nuget.org/packages/soenneker.extensions.enums.states.us/)
[![](https://img.shields.io/github/actions/workflow/status/soenneker/soenneker.extensions.enums.states.us/codeql.yml?label=CodeQL&style=for-the-badge)](https://github.com/soenneker/soenneker.extensions.enums.states.us/actions/workflows/codeql.yml)

# ![](https://user-images.githubusercontent.com/4441470/224455560-91ed3ee7-f510-4041-a8d2-3fc093025112.png) Soenneker.Extensions.Enums.States.US
Expands `USState` abbreviations into full U.S. state names.

## Installation

```bash
dotnet add package Soenneker.Extensions.Enums.States.US
```

## Usage

```csharp
using Soenneker.Extensions.Enums.States.US;

string name = USState.ILValue.ToFullName(); // "Illinois"
string missing = ((USState?) null).ToFullName(); // ""
```

`ToFullName()` covers the 50 state values. Null becomes an empty string. If the enum contains an unrecognized value, the method falls back to that value's `ToString()` representation rather than throwing.
