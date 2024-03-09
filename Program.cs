using static System.Convert;
using static SplashKitSDK.SplashKit;

// Declaring variables
string xInput = "";
string xUnit = "";
float xRaw = 0;
double xFeet = 0;
double xMetres = 0;

string yInput = "";
string yUnit = "";
double yRaw = 0;
double yFeet = 0;
double yMetres = 0;

string operation = "";

double outFeet = 0;
double outMetres = 0;

string cont = "";

// Calculation function
void Calculate() {
    // First input
    WriteLine("Is your first input in feet (F) or metres (M)?");
    xUnit = ReadLine();
    while (xUnit != "F" && xUnit != "M"){
        WriteLine("Expected F for feet or M for metres. Try again.");
        WriteLine("Is your first input in feet (F) or metres (M)?");
        xUnit = ReadLine();
    }

    WriteLine("Please enter your first input:");
    xInput = ReadLine();
    while (!IsDouble(xInput) || Single.IsNegative((float)ToDouble(xInput))) {
        if (!IsDouble(xInput)) {
            WriteLine("Do not put in any alphabets or symbols other than decimal points.");
        } else if (Single.IsNegative((float)ToDouble(xInput))) {
            WriteLine("This calculator does not accept negative numbers.");
        }
        WriteLine("Try again.");
        WriteLine("Please enter your first input:");
        xInput = ReadLine();
    }
    xRaw = (float)ToDouble(xInput);

    // Second input
    WriteLine("Is your second input in feet (F) or metres (M)?");
    yUnit = ReadLine();
    while (yUnit != "F" && yUnit != "M"){
        WriteLine("Expected F for feet or M for metres. Try again.");
        WriteLine("Is your first input in feet (F) or metres (M)?");
        yUnit = ReadLine();
    }

    WriteLine("Please enter your second input:");
    yInput = ReadLine();
    while (!IsDouble(yInput) || Single.IsNegative((float)ToDouble(yInput))) {
        if (!IsDouble(yInput)) {
            WriteLine("Do not put in any alphabets or symbols other than decimal points.");
        } else if (Single.IsNegative((float)ToDouble(yInput))) {
            WriteLine("This calculator does not accept negative numbers.");
        }
        WriteLine("Try again.");
        WriteLine("Please enter your second input:");
        yInput = ReadLine();
    }
    yRaw = (float)ToDouble(yInput);

    // Operation - user input
    WriteLine("What operation would you like to perform?");
    WriteLine("(A)ddition");
    WriteLine("(S)ubtraction");
    WriteLine("(M)ultiplication");
    WriteLine("(D)ivision");
    operation = ReadLine();
    while (operation != "A" && operation != "S" && operation != "M" && operation != "D") {
        WriteLine("Unacceptable input. Please try again.");
        WriteLine("What operation would you like to perform?");
        WriteLine("(A)ddition");
        WriteLine("(S)ubtraction");
        WriteLine("(M)ultiplication");
        WriteLine("(D)ivision");
        operation = ReadLine();
    }

    // Conversion from raw inputs into input in feet and metres
    // One foot is equal to 0.3048 meters.
    if (xUnit == "F") {
        xFeet = xRaw;
        xMetres = xRaw * 0.3048;
    } else if (xUnit == "M") {
        xFeet = xRaw / 0.3048;
        xMetres = xRaw;
    }

    if (yUnit == "F") {
        yFeet = yRaw;
        yMetres = yRaw * 0.3048;
    } else if (xUnit == "M") {
        yFeet = yRaw / 0.3048;
        yMetres = yRaw;
    }

    // Conducting the operation
    if (operation == "A") {
        // Addition
        outFeet = xFeet + yFeet;
        outMetres = xMetres + yMetres;
        WriteLine("Result of addition:");
        WriteLine($"{outFeet} feet");
        WriteLine($"{outMetres} metres");
    } else if (operation == "S") {
        // Subtraction
        outFeet = xFeet - yFeet;
        outMetres = xMetres - yMetres;
        WriteLine("Result of subtraction:");
        WriteLine($"{outFeet} feet");
        WriteLine($"{outMetres} metres");
    } else if (operation == "M") {
        // Multiplication
        outFeet = xFeet * yFeet;
        outMetres = xMetres * yMetres;
        WriteLine("Result of multiplication:");
        WriteLine($"{outFeet} feet squared");
        WriteLine($"{outMetres} metres squared");
    } else if (operation == "D") {
        // Division
        outFeet = xFeet / yFeet;
        outMetres = xMetres / yMetres;
        WriteLine("Result of division:");
        WriteLine($"{outFeet} feet");
        WriteLine($"{outMetres} metres");
    }
}

// Initialisation
WriteLine("Welcome to the Advanced Unit Converter and Calculator!");

// Do-while loop so that the user can use the calculator for as long as cont == Y
// i.e. the user wishes to continue.
do {
    Calculate();
    WriteLine("Would you like to perform another calculation?");
    WriteLine("(Y)es || (N)o");
    cont = ReadLine();
} while (cont == "Y");