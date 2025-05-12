# Homeworld Vocabulary Analyzer

A simple solution created with the help of ChatGPT, to count word elements and give statistics, made with a purpose to analyze already created words for Kushan conlang:
  - to understand what consonants and vowels are commonly used and what are rarity or not used
  - to understand what word structures are preferred in Kushan/Hiigaran language
  - to collect words using the same roots and suffixes
  - to find other similarities

Google [spreadsheets](https://docs.google.com/spreadsheets/d/1Zb5Y1ee2zTvkYHdkAwAExr8cWcW0_cjyZhO1ZbHmXII/edit?usp=sharing) are used for this purpose and then converted into .CSV file.

Initially, this work started within the following articles:
- [Homeworld: XenoLanguage](https://www.moddb.com/members/amddred/blogs/homeworld-xenolanguage)
- [Homeworld: XenoLanguage-II](https://www.moddb.com/members/amddred/blogs/homeworld-xenolanguage-ii)
- [Homeworld: XenoLanguage-III](https://www.moddb.com/members/amddred/blogs/homeworld-xenolanguage-iii)

Hope you'd find this useful for whatever purposes you may have.

If the program is giving you error like this:
```
MSBuild version 17.13.19+0d9f5a35a for .NET Framework
MSBUILD : error MSB1013: The response file was specified twice. A response file can be specified only once. Any files named "msbuild.rsp" in the directory of MSBuild.exe or in the directory of the first project or solution built (which if no project or solution is specified is the current working directory) were automatically used as response files.
Switch: @.\MSBuild.rsp
```

Try this:
```
dotnet build HWA-Project.csproj
```

And save .CSV in UTF-8 encoding.