// See https://aka.ms/new-console-template for more information
using name_sorter.Model;
using name_sorter.Service;
using name_sorter.Services;




string inputFile = args.Length > 0 ? args[0] : "unsorted-names-list.txt";  // File path

INameReader reader = new FileNameReader(inputFile);
INameSorter sorter = new NameSorter();
INameWriter writer = new ConsoleNameWriter();

//var names = reader.ReadNames().Select(n => new PersonName(n));
//var sortedNames = sorter.Sort(names);

//writer.WriteNames(sortedNames.Select(n => n.ToString()));

// Optional: write to file
//File.WriteAllLines("sorted-names-list.txt", sortedNames.Select(n => n.ToString()));

Console.WriteLine("--------Sorted names: ");

    var names = reader.ReadNames().Select(n => new Name(n));
    var sortedNames = sorter.Sort(names).ToList();
    writer.WriteName(sortedNames.Select(n => n.ToString()));

    // Optional: write to file
    File.WriteAllLines("sorted-names-list.txt", sortedNames.Select(n => n.ToString()));
    //File.WriteAllLines("sorted-names-list.txt", sortedNames.Select(n => n.ToString()));

