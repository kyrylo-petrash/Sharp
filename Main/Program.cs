// See https://aka.ms/new-console-template for more information

// создаём библиотеку классов
// пересобрать её
// добавить ссылку в данный проект на файл ClassLibrary, где содержится класс Person и подключить её через using

using System;
using ClassLibrary;

Person person = new Person();
person.Name = "Console";
person.Id = 1;
Console.WriteLine(person);
Console.WriteLine(person.Name);
Console.WriteLine(person.Id);
person.Display();