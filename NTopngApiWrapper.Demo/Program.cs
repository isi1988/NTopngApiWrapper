// See https://aka.ms/new-console-template for more information

using NTopngApiWrapper.Lib;

//Create wrapper
var wrapper = new NTopngWrapper();
//Init wrapper
wrapper.InitFromFile();

//Get interface data
var rootData = await wrapper.GetInterfaceData();


//Get flow sankey diagram
var rootFlowSankey = await wrapper.GetFlowSankey();

//Get root host stats
var rootHostStats = await wrapper.GetHostStats("192.168.30.15");

Console.ReadKey();