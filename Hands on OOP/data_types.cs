// boolean can only be true or false. default false
bool result = true;

// integer can have a + or - as a prefix
int numberInDec = -16;
int numberInHex = -0x10;
long numberInLong = 200L;

/* real values are sequences of digits with a positive
 * or negative sign, like integers */
float realNumber = 12.5f;
realNumber = 1.25e+1f;
double realDNumber = 12.5;

string s = "Hello";
string s1 = "Hello \n\r world"; // prints the string with escape sequence
string s2 = @"Hello \n\r world"; // prints the string without escape sequence
string s3 = $"S1 : {s1}, S2: {s2}"; // replaces the {s1} and {s2} with values

// the @ character can be placed as a prefix before a string to take it as it is.
// called a verbatim string

// the $ character is used as a prefix for string interpolation

// CONDITIONS

int a = 5;
if (a == 5)
{
    // As a is 5, do something
}
else
{
    // As a is not 5, do something else
}

// SWITCH CASE
// almost similar to if statement, cases will determine the execution step.

int a = 5;
switch (a)
{
    case 4:
        // Do something;
        break;
    case 5:
        // Do something;
        break;
    default:
        // Do something;
        break;
}

// the switch case automatically picks the correct case statement depending on the value
// a case needs to be concluded with a break statement.

// GOTO STATEMENTS
// used for unconditional jumps in the language.
// you can use a goto statement to jump to any location of your program with the context you have

// ... code block
// goto lbll;
// ...
// ...
// lbll: expression body

// LOOPS

// WHILE

while (condition)
{
    loop body;
}

// this should evalutate to true to execute the loop for the next iteration.

// DO-WHILE
// checks the condition after executing the step once.

do
{
    loop body;
}
while (condition);

// FOR
// handles complications by maintaining the number of executions of the loop efficiently within the block itself

for (initialisation; condition; update)
{
    /* loop body */
}

/* first portion index variable, second is the condition executed in every iteration of the for loop.
 * If the condition becomes false, the for loop doesn't continue its' execution and stops.
 * Third portion is also executed after every execution of the loop body, it manipulates the variable
 * that was used in the for loop initialisation and condition. */

// FOREACH
// used to iterate over a sequence of objects. widely used when dealing with collections.
// should only be used for objects implementing the following:

foreach (type variable in collection)
{
    // statements;
}

// BREAK
/* allows the developer to break the loop and take context out of it.
* used as a bypass to break the loop in which it is getting executed. */

// CONTINUE
/* used to invoke the next iteration. allows the developer to continue to the next step
* without executing any further code in the block. */

var x = 0;
while (x <= 10)
{
    x++;
    if (x == 2) continue;
    Console.WriteLine(x);
    if (x == 5) break;
    Console.WriteLine("End of loop body");
}
Console.WriteLine($"End of loop, X : {x}");

/* this code will skip execution of the body for the iteration value, 2, because of
 * the continue statement. The loop will execute until the value of x is 5 because
 * of the break statement. */

