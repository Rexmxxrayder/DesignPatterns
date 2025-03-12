
using DesignPatterns.Creationnal.BuilderPattern;
using DesignPatterns.Creationnal.BuilderPattern.Builder;

var carBuilder = new CarBuilder();
carBuilder.SetCarType("aaa").SetSeats(2).SetEngine("vroum");