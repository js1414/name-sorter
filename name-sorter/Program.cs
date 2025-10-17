// See https://aka.ms/new-console-template for more information
using name_sorter.Service;

Console.WriteLine("Hello, World!");

string filePath = args.Length > 0 ? args[0] : "unsorted-names-list.txt"; //read default path if it is nkit given

//INameWriter writer = new FileNameReader(filePath);