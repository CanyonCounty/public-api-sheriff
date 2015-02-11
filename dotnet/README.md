# public-api-sheriff
Example usage of the Sheriff Public API in C# .NET

##Prerequisite
  - [Visual Studio](http://www.visualstudio.com/en-us/products/visual-studio-express-vs.aspx) - 2012 was used, but 2103 community should work
  - [nuget](https://www.nuget.org/)
  - [Newtonsoft.Json](https://www.nuget.org/packages/Newtonsoft.Json/) - Installed via nuget

##Example
Open up SheriffExample.sln in visual studio

The solution has three projects

  - SheriffExampleDAL - the data access layer - it contacts api.canyonco.org for data
  - SheriffExampleConsole - Similar output to the python and ruby examples
  - SheriffExampleWin - A Windows Forms application that shows more data
