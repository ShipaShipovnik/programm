/*
 * Базовый класс Fourangle (4хугольник)
 * 1-й производный класс Parallelogram (Fourangle)
 * 2-й Rhomb (Parallelogram)
 * 3-й Rectangle (Fourangle)
 * 4-й Square (Rectangle)
 * 5-й trapezoid (Fourangle)
 */
using FourangleClasses.Classes;
using АБОБА.Classes;

Console.WriteLine("Четырехугольник");
ClsFourangle fourangle = new ClsFourangle();
fourangle.KeyboardInput();
fourangle.SidesCalculation();
fourangle.DiagonalsCalculation();
Console.WriteLine($"Периметр = {fourangle.Perimert}");