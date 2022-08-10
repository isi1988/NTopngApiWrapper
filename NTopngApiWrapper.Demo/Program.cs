// See https://aka.ms/new-console-template for more information

using NTopngApiWrapper.Lib;

//Create wrapper
var wrapper = new NTopngWrapper();
//Init wrapper
wrapper.InitFromFile();

//Get interface data
var root = await wrapper.GetInterfaceData();

Console.ReadKey();