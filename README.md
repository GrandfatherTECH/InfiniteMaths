# Infinite Maths

A Windows desktop application for converting numbers between arbitrary numeral systems (bases 2–36+).

## What it does

- **To decimal** — enter a number in any base using digits `0–9` and letters `A–Z` (where A=10, B=11, … Z=35), specify the source base, and convert to decimal.
- **From decimal** — enter a decimal number and a target base to get the result in that base using the same digit/letter notation.
- Supports **fractional numbers** (decimal point). When converting from decimal, you can set a precision (number of fractional digits); if left blank, up to 100 digits are computed and a repeating fraction is detected automatically (marked with `p`).
- Supports **"complex" digits** — digits whose value ≥ 10 can be written inside pipe characters (e.g. `|AB|` denotes a single digit with value 10+11=21), allowing bases larger than 36.

## Built with

| Technology | Details |
|---|---|
| Language | C# |
| UI framework | WPF (Windows Presentation Foundation) |
| Target framework | .NET 7 (Windows) |
| Project type | WinExe (.exe) |

The solution contains three projects:

- `InfiniteMaths` — the main WPF application
- `IsAllLetterOrDigit` — helper library for character-type validation
- `Placeholder Textbox Control` — custom WPF control that shows placeholder text in empty text boxes

## Requirements

- Windows (WPF is Windows-only)
- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0) or newer

## How to build

**Using Visual Studio:**

1. Open `InfiniteMaths.sln` in Visual Studio 2022 or later.
2. Set `InfiniteMaths` as the startup project.
3. Press **F5** to build and run, or **Ctrl+Shift+B** to build only.

**Using the .NET CLI:**

```bash
dotnet build InfiniteMaths.sln
dotnet run --project InfiniteMaths/InfiniteMaths.csproj
```

The output executable will be placed in `InfiniteMaths/bin/Debug/net7.0-windows/`.

## License

See [LICENSE.txt](LICENSE.txt).
