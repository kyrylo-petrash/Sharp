// See https://aka.ms/new-console-template for more information

using static System.Console; // импортируем возможность класса Console, статический импорт
using Short = System.Console;
using System;
using System.Globalization;
using System.Net.Security;

#region Console
WriteLine("Hello, World!");
Short.WriteLine("Hello, World!");

Console.Beep(523, 500); // До
Console.Beep(587, 500); // Ре
Console.Beep(659, 500); // Ми
Console.Beep(698, 500); // Фа
Console.Beep(784, 500); // Соль
Console.Beep(880, 500); // Ля
Console.Beep(988, 500); // Си
// 1 параметр частоты
// 2 параметр длительность

Console.WriteLine("Введите число x");
double x = double.Parse(Console.ReadLine()); // Parse преобразует только строку

Console.WriteLine("Введите число y");
double y = Convert.ToDouble(Console.ReadLine()); // Convert преобразует любой тип

double result = (x + y) / 2;

// Thread.Sleep(1000);

Console.WriteLine($"Среднеее арифметическое двух чисел = {result}");
Console.WriteLine("Среднеее арифметическое двух чисел = {0}", result); // строка составного формата
Console.WriteLine("Среднеее арифметическое двух чисел = " + result); // Concat

Console.WriteLine($"nameof: {nameof(result)}"); // nameof

// цвет
Console.ForegroundColor = ConsoleColor.Red;   // устанавливаем цвет букв
Console.BackgroundColor = ConsoleColor.White; // устанавливаем цвет фона

Console.WriteLine("Hello world!");
Console.WriteLine("Hello friends!");

Console.ResetColor();  // сбрасываем настройки цвета букв и фона
// Console.ForegroundColor = ConsoleColor.Gray;  // устанавливаем цвет букв
// Console.BackgroundColor = ConsoleColor.Black; // устанавливаем цвет фона

Console.WriteLine("Goodbye!");
#endregion

#region Escape
int numEsc = 1;
Console.Write($"{numEsc++}\tHello World! I like to see you!\a\n"); Thread.Sleep(1000); // t - horizontal-tab
Console.Write($"{numEsc++}\tHello World! I like to see you!\a\f"); Thread.Sleep(1000); // f - form-feed (next page)
Console.Write($"{numEsc++}\tHello World! I like to see you!\a\v"); Thread.Sleep(1000); // v - vertical-tab
Console.Write($"{numEsc++}\tHello World\b\b\b\b\b\b! I like to see you!\a\n"); Thread.Sleep(1000); // b - back-space
Console.Write($"{numEsc++}\tHello World! \"I like to see you!\"\a\n"); Thread.Sleep(1000); // \"
Console.Write($"{numEsc++}\tHello World! \\I like to see you!\\\a\n"); Thread.Sleep(1000); // //
Console.Write($"{numEsc++}\tHello World! I like to see you!\r\a\n"); Thread.Sleep(1000);
Console.Write("Hello World!\r"); // выводит курсор на начало строки
Console.Write("\nHello World!\0\n"); // null терминатор

// коды ASCII символов в шестнадцатеричном формате (256 cимволов)
Console.WriteLine('\x48' + '\x65' + '\x6c' + '\x6c' + '\x6f' + '\x20' + '\x57' + '\x6f' + '\x72' + '\x6c' + '\x64' + '\x21');
// коды Unicode символов в шестнадцатеричном формате
Console.WriteLine('\u0048' + '\u0065' + '\u006c' + '\u006c' + '\u006f' + '\u0020' + '\u0057' + '\u006f' + '\u0072' + '\u006c' + '\u0064' + '\u0021');
#endregion

#region Comments
/* Многострочный комментарий */

// Выводим на экран строку "Привет мир!" по-английски
Console.Write("\x48\x65\x6c\x6c\x6f\x20\x57\x6f\x72\x6c\x64\x21");

// UNDONE: доработать имеющуюся функциональность (напр., сделать цветными буквы)
// TODO: добавить новую функциональность (например, попрощаться с пользователем)
// HACK: этот код - временное решение, которое нужно переделать или удалить
// нажимаем Вид, открываем свписок задач
#endregion

#region Value
// целочисленные: sbyte(1), short(2), ushort(2), int(4), uint(4), long(8), ulong(8)
// числа с плавающей запятой: float(4), double(8)
// десятичные: decimal(16)
// логическое значение: bool(1)
// строка: string
// символ: char(2)

// натуральные (N): 1, 2, 3
// целые (Z): -1, 0, 1
// действительные (вещественные) числа (R): 3.14, 28.0

// byte (N) [0 to 255] 0b_
// sbyte (Z) [-127 to 128]
// ushort (N) [0 to 65535]
// short (Z) [-32768 to 32767]
// uint (N) [0 to ~4,3 млрд.] u
// int (Z) [-2,1 млрд. to 2,1 млрд.]
// ulong (N) [64-битные] ul
// long (Z) [64-битные] L
// float (R) [32-битные] f
// double (R) [64-битные] d
// decimal (R) [128-битные] m
// unsigned - знаковые
// signed - знаковые

float value = sbyte.MinValue; Console.WriteLine(value);
value = sbyte.MaxValue; Console.WriteLine(value);

value = int.MinValue; Console.WriteLine(value);
value = int.MaxValue; Console.WriteLine(value);

value = int.Parse(Console.ReadLine()); Console.WriteLine(value);
value = Convert.ToInt32(Console.ReadLine()); Console.WriteLine(value);

double apples = 1 + 0.5, pears = 2, fruits = apples + pears;
Console.WriteLine("Sum is {0}", fruits);
Console.WriteLine($"Sum is {fruits}");

value = sizeof(int);
Console.WriteLine(sizeof(Int32));

int negativeNumber = -1;
Console.WriteLine(negativeNumber);
Console.WriteLine(Convert.ToString(negativeNumber, 2)); // двоичная система исчисления
#endregion

#region Convert
byte valueOfLowerType = 255;
int valueOfGreaterType = valueOfLowerType; // меньший тип записуется в больший тип
Console.WriteLine(valueOfGreaterType);
valueOfLowerType = (byte)valueOfGreaterType; // явное преобразование

float pi = 3.14f; // необходимо поставить f
Console.WriteLine(pi);
// sbyte @sbyte = 129; // автоматически преобразовывает само число в int
#endregion

#region OperationNumeric
byte dividend = 9, divisor = 2;
int quotient = dividend / divisor;
int remainder = dividend % divisor;
Console.WriteLine("9 / 2 = {0}\n" +
    "9 % 2 = {1}", quotient, remainder);

byte augend = 1, addend = 2;
byte sum = (byte)(augend + addend); // int int.operator +(int left, int right) результатом должно быть значение типа int
Console.WriteLine(sum);

float tM = 3.0f, tT = -2.0f, tW = 0f;
int daysInWeak = 3;
float tWeak = (tM + tT + tW) / daysInWeak;
Console.WriteLine("tWeak = {0}", tWeak);
#endregion

#region ArithmeticOperators
#region Increment/decrement
// бинарные и унарные, постфиксные и префиксные
int unary = 1;
// инкрименты
Console.WriteLine(unary); // 1
Console.WriteLine(unary++); // 1
Console.WriteLine(unary); // 2
Console.WriteLine(++unary); // 3
// декрименты
Console.WriteLine(unary--); // 3
Console.WriteLine(unary); // 2
Console.WriteLine(--unary); // 1
#endregion

#region NaN
// NaN значение, которое не является числом
if ((3 / 2) == Double.NaN)
    Console.WriteLine("3/2 == NaN");
else
    Console.WriteLine("3/2 is not NaN");

// все математические операции, содержащие NaN в качестве одного из операндов
Console.WriteLine(2 + double.NaN);
Console.WriteLine(-0d / +0d); // деление нуля на ноль
Console.WriteLine(double.NegativeInfinity / double.PositiveInfinity); // деление бесконечности на бесконечность
Console.WriteLine(0 * double.PositiveInfinity); // умножение нуля на бесконечность
Console.WriteLine(double.NegativeInfinity + double.PositiveInfinity); // сложение бесконечности с бесконечностью противоположного знака
#endregion

#region Math
Console.WriteLine(Math.Pow(6, 2)); // возведение в степень
Console.WriteLine(Math.Sqrt(-36)); // вычисление квадратного корня отрицательного числа
Console.WriteLine(Math.Log(-36, 6)); // логарифмирование отрицательного числа (показатель степени чтобы получить -36 из 6)
#endregion

#region Unary
// составное присвоедние
int a = 5;
a += 5; Console.WriteLine(a);
a -= 5; Console.WriteLine(a);
a *= 5; Console.WriteLine(a);
a /= 5; Console.WriteLine(a);
a %= 5; Console.WriteLine(a);
#endregion

#region Priority
// приоритет операций
int b = a++ * 5; // a++ у постфиксного самый низкий приоритет
Console.WriteLine($"a = {a} b = {b}");

b = ++a * 5; // ++a у префиксного самый высокий приоритет
Console.WriteLine($"a = {a} b = {b}");
#endregion
#endregion

#region String
string sentence = "Hello world"; // строковой литерал
Console.WriteLine(sentence);
sentence = Console.ReadLine(); // ввод данных
Console.WriteLine(sentence);

char letter = 'a';
Console.WriteLine(letter);

char[] letterArr = { 'a', 'b', 'c' };
Console.WriteLine("letterArr = {0} sizeof(char) = {1}", letterArr[0], sizeof(char));

char convertChar = Convert.ToChar("A");
Console.WriteLine($"char = {convertChar}");
string convertStr = Convert.ToString(convertChar);
Console.WriteLine($"string = {convertStr}");

// некоторые особенности
string textInter = @"Hello World"; // не нужно ставить + при добавлении
textInter = $"Result is {convertStr}"; // интерполяция
Console.WriteLine(textInter);

// кодировка ASCII только 256 символов
#endregion

#region StringOperation
// создание строк
#region Format
int numFormat = 1;
string infoFormat = String.Format("You have {0} mind, today is {1}", numFormat, DateTime.Now);
Console.WriteLine(infoFormat);

Console.WriteLine("C format: {0:C}", 2.50); // валюта
Console.WriteLine("D format: {0:D}", 25); // десятичное число
Console.WriteLine("E format: {0:E2}", 25); // экспоненциальный
Console.WriteLine("F format: {0:F2}", 2.5); // с фиксированной запятой
Console.WriteLine("G format: {0:G}", 2.5); // общий
Console.WriteLine("N format: {0:N}", 25); // numeric
Console.WriteLine("P format: {0:P}", 0.25); // процент
Console.WriteLine("R format: {0:R}", 2.5); // приемо-передача (Round-Trip)
Console.WriteLine("X format: {0:X}", 250); // шестнадцатеричный
Console.WriteLine("X format: {0:X2}", 250); // шестнадцатеричный

Console.WriteLine("format: {0}", 0.123456789_12345678);
Console.WriteLine("R format: {0:R}", 0.123456789_12345678);

// смещение
double interpolation = 0.123456789_12345678;
const int aligment = 30;
Console.WriteLine($"R format: {interpolation,aligment:R} : End"); // R представляет формат String
Console.WriteLine($"R format: {interpolation,-aligment:R} : End");
Console.WriteLine($"{interpolation,-25} & {interpolation,-25} = {interpolation,-25}"); // минус смещает влево
#endregion
#region Concat
string firstConcat = "Hello", secondConcat = "World", textConcat = null;
textConcat = firstConcat + " " + secondConcat;
textConcat += "!";
Console.WriteLine(textConcat);

Console.WriteLine(String.Concat(firstConcat, ' ', secondConcat, '!'));

#region Calc
Console.Write("Enter Augend: ");
int augentConcat = int.Parse(Console.ReadLine());

Console.Write("Random Addend is ");
Random randomConcat = new Random();
int addendConcat = randomConcat.Next(0, 11);
Console.WriteLine($"{addendConcat}");

int sumConcat = augentConcat + addendConcat;
Console.WriteLine(String.Concat(augentConcat, '+', addendConcat, '=', sumConcat));
#endregion
#endregion
#region Join
string[] wordsJoin = { "Hello", "and", "welcom", "to", "my", "world!" };
Console.WriteLine(String.Join(" ", wordsJoin));
#endregion
#region Insert
string textInsert = "Once a time.";
Console.WriteLine(textInsert.Insert(4, " upon"));
#endregion
#region CopyTo
string textStringCopyTo = "Hello World!";
char[] charCopyTo = { 'W', 'h', 'e', 'r', 'e' };
Console.WriteLine($"Original: {new string(charCopyTo)}");
textStringCopyTo.CopyTo(0, charCopyTo, 0, 5); // с какого индекса textStringCopyTo
                                              // копируем в charCopyTo
                                              // в какой индекс charCopyTo начинаем записывать
                                              // сколько индексов запишем в charCopyTo
Console.WriteLine($"New: {new string(charCopyTo)}");
#endregion
// обраезка и удаление символов
#region Trim
string textTrim = "  Big  ";
Console.WriteLine("Hello {0} World!", textTrim);
string changeTrim = textTrim.Trim(); // удаляет пробелы
Console.WriteLine("Hello {0} World!", changeTrim);

string headTrim = "* Hello my darling. *";
Console.WriteLine(headTrim);
Console.WriteLine(headTrim.Trim(new Char[] { ' ', '*', '.' })); ;

#endregion
#region Remove
string textRemove = "Hello Beautiful World!";
Console.WriteLine(textRemove.Remove(5, 10)); // удалить символы индексов от 5 до 10
#endregion
#region Replace
string textReplace = "Cold, dark night";
string changeReplace = textReplace.Replace(",", "!");
Console.WriteLine(changeReplace);
#endregion
// заполнение строк
#region PadLeft
string textPadLeft = "Hello World!";
Console.WriteLine(textPadLeft.PadLeft(20, '-'));
#endregion
#region PadRight
string textPadRight = "Hello World!";
Console.WriteLine(textPadRight.PadRight(20, '-'));

string changePad = textPadRight.PadRight(20, '-');
Console.WriteLine(changePad.PadLeft(28, '-'));
#endregion
// методы сравнения
#region Compare
string textCompare = "Hello World!";
Console.WriteLine(String.Compare(textCompare, "Hello World?")); // замена правого параметра на левый
#endregion
#region CompareTo
string firstCompareTo = "Hello World!";
string secondCompareTo = "Hello Word";
Console.WriteLine(firstCompareTo.CompareTo(secondCompareTo));
#endregion
#region  Equals
string firstEquals = "Hello World!";
string secondEquals = "Hello World!";
Console.WriteLine(firstEquals.Equals(secondEquals));
Console.WriteLine(String.Equals(firstEquals, secondEquals));
#endregion
#region StartsWith
string firstWith = "Hello World";
string startsWith = "Hello";
Console.WriteLine(firstWith.StartsWith(startsWith));

Console.WriteLine(firstWith.EndsWith(startsWith));
#endregion
#region IndexOf
string textIndexOf = "Hello World";
Console.WriteLine(textIndexOf.IndexOf('l')); // проверяет первое вхождение и выводит индекс массива сначала

Console.WriteLine(textIndexOf.LastIndexOf('l')); // проверяет первое вхождение и выводит индекс массива с конца
#endregion
#region ToUpper
string textToUpper = "Hello World!";
Console.WriteLine(textToUpper.ToUpper());
#endregion
#region ToLower
string textToLower = "Hello World";
Console.WriteLine(textToLower.ToLower());
#endregion
#region ToTitleCase
string textToTitleCase = "a tale of two cities";
TextInfo ti = CultureInfo.CurrentCulture.TextInfo;
Console.WriteLine(ti.ToTitleCase(textToTitleCase));
#endregion
// разделение
#region Split
string textSplit = "You win. You lose some.";

string[] subs = textSplit.Split(); // вместо space новая строка
foreach (string s in subs)
    Console.WriteLine(s);

string[] points = textSplit.Split('.', ' '); // вместо перечисленных знаков новая строка
foreach (string s in points)
    Console.WriteLine(s);
#endregion
#endregion

#region ComparisonOperations
int firstComparison = 1, secondComparison = 2;
Console.WriteLine(firstComparison == secondComparison); // равно
Console.WriteLine(firstComparison != secondComparison); // не равно
Console.WriteLine(firstComparison < secondComparison); // меньше
Console.WriteLine(firstComparison > secondComparison); // больше
Console.WriteLine(firstComparison <= secondComparison); // меньше или равно
Console.WriteLine(firstComparison >= secondComparison); // меньше или равно

bool isEqual = firstComparison == secondComparison;
Console.WriteLine(isEqual);
// при сравнении типа char учитывается Unicode
#endregion

#region LogicalOperations
#region Not !
bool firstLog = true, secondLog = false;
Console.WriteLine($"firstLog = {firstLog} secondLog = {secondLog}");
bool firstToLog = !secondLog;
bool secondToLog = !firstLog;
Console.WriteLine("firstTolLog = {0} secondToLog = {1}", firstToLog, secondToLog);

#region Salary
int salaryLog, minSalaryLog = 1000;
Console.Write("\nEnter your salary to $: ");
salaryLog = Int16.Parse(Console.ReadLine());
bool salaryNotLessMin = !(salaryLog > minSalaryLog);
Console.WriteLine($"Моя зарплата: {salaryLog}, и она меньше {minSalaryLog}: {salaryNotLessMin}");
#endregion
#endregion

#region And &/&&
Console.WriteLine("\nОперации конъюнкции");
bool firstAnd = true, secondAnd = false;
bool resultAnd = firstAnd & secondAnd; // конъюнскция
Console.WriteLine($"{firstAnd,-5} & {secondAnd,-5} = {resultAnd,-5}"); // + справа - слева дистанции
firstAnd = secondAnd = false;
Console.WriteLine($"{firstAnd,-5} & {secondAnd,-5} = {resultAnd,-5}");
resultAnd = (firstAnd = true) & secondAnd;
Console.WriteLine($"{firstAnd,-5} & {secondAnd,-5} = {resultAnd,-5}");

#region ParallelAssignment
(firstAnd, secondAnd) = (secondAnd, firstAnd); // техника параллельного присвоения
Console.WriteLine((firstAnd, secondAnd).firstAnd); // меняется после присвоения
Console.WriteLine((firstAnd, secondAnd).secondAnd);
Console.WriteLine($"{firstAnd,-5} & {secondAnd,-5} = {resultAnd,-5}");
#endregion

#region Bank
Console.Write("\nEnter salary of client: ");
int salaryClientAnd = int.Parse(Console.ReadLine());
Console.Write("Enter age: ");
int ageClientAnd = int.Parse(Console.ReadLine());
int minSalaryAnd = 1500, minAgeAnd = 21, maxAgeAnd = 75;
bool bankLoadAnd = (!(ageClientAnd <= minAgeAnd) & !(ageClientAnd >= maxAgeAnd) & !(salaryClientAnd <= minSalaryAnd));
Console.WriteLine($"\"Кредитование\" доступно: {bankLoadAnd}");

bool bankShortCircutingAnd = ((ageClientAnd >= minAgeAnd) && (ageClientAnd <= maxAgeAnd) && (salaryClientAnd >= minSalaryAnd)); // ShortCircuting если false вначале, то и дальше false
Console.WriteLine($"\"Кредитование\" доступно: {bankShortCircutingAnd}");
#endregion
#endregion

#region Or |/||
Console.WriteLine("\nОперации дизъюнкции");
#region Bank
Console.Write("Enter salary of client: ");
int salaryClientOr = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter age: ");
int ageClientOr = Convert.ToInt32(Console.ReadLine());
Console.Write("Наличие поручителя (да/нет): ");
bool hasClientOr = Console.ReadLine() == "да";
Console.Write("Наличие залогового обеспечения (да/нет): ");
bool hasGuarantor = Console.ReadLine().Contains("да"); // опосредованный метод вызова
int minSalaryOr = 1500, minAgeOr = 21, maxAgeOr = 75;
bool bankLoadOr = (ageClientOr >= minAgeOr) & (ageClientOr <= maxAgeOr) & (salaryClientOr > minSalaryOr) |
    hasClientOr | hasGuarantor; // true либо hasClientOr либо hasGuarantor;
Console.WriteLine($"\"Кредитование\" доступно: {bankLoadOr}");

bool bankShortCircutingOr = (ageClientOr >= minAgeOr) & (ageClientOr <= maxAgeOr) & (salaryClientOr > minSalaryOr) ||
    hasClientOr || hasGuarantor; // ShortCircuting если false вначале, то и дальше false
Console.WriteLine($"\"Кредитование\" доступно: {bankShortCircutingOr}");
#endregion
#endregion

#region XOR ^
Console.WriteLine("\nОперации XOR");
bool bankShortCircutingXor = hasClientOr ^ hasGuarantor; // true ^ true = false, false ^ false = false
Console.WriteLine($"\"Кредитование\" доступно: {bankShortCircutingXor}");
#endregion

#region myExamination
Console.Write("Выслуга лет составляет: ");
int seniority = Convert.ToInt32(Console.ReadLine());
int seniorityLength = 0;
// && результат левого оператора false, дальше вычислять не будет
bool resultSeniority = (seniority < 5 && (seniorityLength += 10) == 10) |
    (seniority > 5 && (seniorityLength += 12) == 12) |
    (seniority > 10 && (seniorityLength += 15) == 15) |
    (seniority > 15 && (seniorityLength += 25) == 25) |
    (seniority > 20 && (seniorityLength += 35) == 35) |
    (seniority > 25 && (seniorityLength += 45) == 45) |
    (seniority > 25 && (seniorityLength += 50) == 50);
Console.WriteLine($"выдать премию в размере {seniorityLength}% от заработной платы : \nЗа выслугу лет: {seniority} лет");
#endregion
#endregion

#region BitOperations
#region BitwiseComplementOperator
int firstBit = 1;
int secondBit = ~firstBit;
int thirdBit = secondBit + 1;
Console.WriteLine($"{firstBit} {secondBit} {thirdBit}");
#endregion

#region And &/&&

#endregion

#endregion

Console.ReadLine();
