# SunamoWikipedia

A .NET library for parsing content from Wikipedia HTML pages, including tables and lists.

## Features

- Parse Wikipedia HTML tables with column filtering
- Extract structured data from Wikipedia list pages
- HTML entity list parsing with custom formatters

## Key Classes

- **WikipediaHelper** - Main entry point for parsing Wikipedia HTML content (tables, lists, entities)
- **HtmlTableParserWiki** - Parses HTML tables from Wikipedia pages into structured column data

## Installation

```bash
dotnet add package SunamoWikipedia
```

## Usage

```csharp
// Parse Wikipedia tables containing specific columns
var tables = WikipediaHelper.ParseTable(html, "Column1", "Column2");
var values = tables.First().ColumnValues("Column1", true, false);

// Parse Wikipedia list pages
var items = WikipediaHelper.ParseList(html);
```

## Target Frameworks

`net10.0;net9.0;net8.0`

## Dependencies

- [HtmlAgilityPack](https://www.nuget.org/packages/HtmlAgilityPack)
- [Microsoft.Extensions.Logging.Abstractions](https://www.nuget.org/packages/Microsoft.Extensions.Logging.Abstractions)

## Links

- [NuGet](https://www.nuget.org/profiles/sunamo)
- [GitHub](https://github.com/sunamo/PlatformIndependentNuGetPackages)
- [Developer site](https://sunamo.cz)

## License

MIT
