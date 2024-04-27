//WORK WITH FILES AND DIRECTORIES IN A .NET APPLICATION

//List all directories (To read through and list the names of the top-level directories)
    IEnumerable<string> listOfDirectories = Directory.EnumerateDirectories("stores");

    foreach (var dir in listOfDirectories) 
    {
        Console.WriteLine(dir);
    }
    // Outputs:
    // stores/201
    // stores/202


//List files in a specific directory (To list the names of all of the files in a directory)
    IEnumerable<string> files = Directory.EnumerateFiles("stores");

    foreach (var file in files)
    {
        Console.WriteLine(file);
    }
    // Outputs:
    // stores/totals.txt
    // stores/sales.json


//List all content in a directory and all subdirectories (Find all *.txt files in the stores folder and its subfolders)
    IEnumerable<string> allFilesInAllFolders = Directory.EnumerateFiles("stores", "*.txt", SearchOption.AllDirectories);

    foreach (var file in allFilesInAllFolders)
    {
        Console.WriteLine(file);
    }
    // Outputs:
    // stores/totals.txt
    // stores/201/inventory.txt


//------------------------------------------------------------------------------
//WORK WITH FILE PATHS IN .NET

//Determine the current directory
    Console.WriteLine(Directory.GetCurrentDirectory());
    // Outputs:
    // C:\Users\katesyshepard\Desktop\DOTNET\mslear-dotnet-files\stores\201


//Work with special directories
    string docPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


//Work with paths 
//Special path characters
    Console.WriteLine($"stores{Path.DirectorySeparatorChar}201");
    // returns:
    // stores/201 on macOS

//Join paths
    Console.WriteLine(Path.Combine("stores","201")); // outputs: stores/201

//Determine filename extensions
    Console.WriteLine(Path.GetExtension("sales.json")); // outputs: .json

//Get everything you need to know about a file or path
    string fileName = $"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales{Path.DirectorySeparatorChar}sales.json";
    FileInfo info = new FileInfo(fileName);
    Console.WriteLine($"Full Name: {info.FullName}{Environment.NewLine}Directory: {info.Directory}{Environment.NewLine}Extension: {info.Extension}{Environment.NewLine}Create Date: {info.CreationTime}"); // And many more



//-----------------------------------------------------------------------------
//CREATE FILES AND DIRECTORIES

//Create directories
    Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "stores","201","newDir"));

//Make sure directories exist
    bool doesDirectoryExist = Directory.Exists(filePath);

//Create files
    File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "greeting.txt"), "Hello World!");



//-----------------------------------------------------------------------------
//READ AND WRITE TO FILES

//Read data from files
    File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
    // returns:
    // "total": 22385.32


//Parse data in files
    //bash: dotnet add package Newtonsoft.Json
    using Newtonsoft.Json;

    var salesJson = File.ReadAllText($"stores{Path.DirectorySeparatorChar}201{Path.DirectorySeparatorChar}sales.json");
    var salesData = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
    Console.WriteLine(salesData.Total);
    class SalesTotal {
    public double Total { get; set; }
    }


//Write data to files
    var data = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
    File.WriteAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", data.Total.ToString());
    // totals.txt
    // 22385.32


//Append data to files
    var data = JsonConvert.DeserializeObject<SalesTotal>(salesJson);
    File.AppendAllText($"salesTotalDir{Path.DirectorySeparatorChar}totals.txt", $"{data.Total}{Environment.NewLine}");
    // totals.txt
    // 22385.32
    // 22385.32

