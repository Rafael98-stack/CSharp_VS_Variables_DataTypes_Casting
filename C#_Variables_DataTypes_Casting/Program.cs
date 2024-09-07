// See https://aka.ms/new-console-template for more information

/* VARIABLES */

// Variables are containers for storing data values
// There are different types of variables:

/* 
int - stores integers (whole numbers), without decimals, such as 123 or -123 - Size 4 bytes Stores whole numbers from -2,147,483,648 to 2,147,483,647

double - stores floating point numbers, with decimals, such as 19.99 or -19.99 - Size 8 bytes Stores fractional numbers. Sufficient for storing 15 decimal digits

char - stores single characters, such as 'a' or 'B'. Char values are surrounded by single quotes - Size 2 bytes tores a single character/letter, surrounded by single quotes

string - stores text, such as "Hello World". String values are surrounded by double quotes - Size 2 bytes per character  Stores a sequence of characters, surrounded by double quotes

bool - stores values with two states: true or false - Size 1 bit Stores true or false values
 */

using Microsoft.VisualBasic;

string myName = "Marco"; // DICHIARAZIONE E ASSEGNAZIONE 

int random = 10;

int myAge = 25; // DICHIARAZIONE E ASSEGNAZIONE 

Console.WriteLine("My name: " + myName + " My age: " + myAge + random); // CONCATENAZIONE DI PIU VARIABILI 

string mySurname; // DICHIARAZIONE

bool mySurnameChanged = false;

mySurname = "Rossi"; // ASSEGNAZIONE

Console.WriteLine(mySurname + " " + mySurnameChanged);

mySurname = "Neri"; // RIASSEGNAZIONE

myAge = 26; // RIASSEGNAZIONE

 mySurnameChanged = true;


Console.WriteLine("My surname: " + mySurname + " My age: " + myAge + " " + mySurnameChanged); // CONCATENAZIONE DI PIU VARIABILI CON I VALORI RIASSEGNATI

//////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* COSTANTS */

// Costant variables are unchangeable, "const". 

const int myHeight = 170;

// myHeight = 180; // NON PUO ESSERE RIASSEGNATO UNA VARIABILE "COSTANTE", error

const bool amIAlive = true;

// amIAlive = false;

const string iHave_A_Name = "MY NAME";

// iHaveAName = "YOUR NAME";

//////////////////////////////////////////////////////////////////////////////////////////////////////////////

/* TYPE CASTING */

// Type casting is when you assign a value of one data type to another type

// Implicit Casting: converting a smaller type to a larger type size

double myAgeDouble = myAge;

Console.WriteLine("My age with implicit casting: " + myAgeDouble);

// Explicit Casting: converting a larger type to a smaller size type. Is manually done by placing the type in parentheses in front of the value  

myAgeDouble = 25.8;

myAge = (int) myAgeDouble; // CASTING MANUALE ESPLICITO DA "double" A "int" CON LE PARENTESI TONDE "( )" E IL TIPO DI DATO ALL'INTERNO

Console.WriteLine("My age with explicit casting: " + myAge);
Console.WriteLine("My age with double data type: " + myAgeDouble);

/* CONVERSION METHODS */

// convert data types explicitly by using built-in methods
// Convert.ToBoolean, Convert.ToDouble, Convert.ToString, Convert.ToInt32 (int) and Convert.ToInt64 (long)

string myAgeToConvertString = Convert.ToString(myAge);
Console.WriteLine("My Age as a String: " + myAgeToConvertString);

int myAgeToConvertInt = Convert.ToInt32(myAgeDouble);
Console.WriteLine("My age as a int: " + myAgeToConvertInt);