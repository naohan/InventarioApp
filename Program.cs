

// SISTEMA DE GESTION DE INVENTARIO
using System.Reflection;

var assembly = Assembly.GetExecutingAssembly();
var version = assembly.GetName().Version;

Console.WriteLine();
Console.WriteLine($"Versión: 1.0.0");
Console.WriteLine($"Plataforma: {Environment. OSVersion}");
Console.WriteLine($".NET Version: {Environment. Version}");
Console.WriteLine();
Console.WriteLine("Estado: Proyecto inicializado");

