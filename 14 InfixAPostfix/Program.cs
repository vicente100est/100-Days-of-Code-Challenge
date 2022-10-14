//Equivale a 567*+89*-
using _14_InfixAPostfix;

string exp = "5+6*7-8*9"; // Necesita expresiones validas de infix
//Stack
//res 567*+89*-

string res = "";
int n = 0;
CStack s  = new CStack();

//Recorremos caracter por caracter
for (n = 0; n<exp.Length; n++)
{
    //Verificamos que sea un operador
    if (exp[n] >= '0' && exp[n] <= '9')
    {
        //Lo adicionamos al resultado
        res += exp[n];
    }
    //Entonces es un operador
    else
    {
        while (!s.EstaVacio() && MayorPrecedencia(s.Peek(), exp[n]))
        {
            //res += s.Peek();
            //s.Pop();
            res += s.Pop();
        }

        s.Push(exp[n]);
    }
}

while (!s.EstaVacio())
{
    //res += s.Peek();
    //s.Pop();
    res += s.Pop();
}

Console.WriteLine("{0} en postfix es {1}", exp, res);

//Ojo, es para demostrar como actuar ante diferentes precedencias
//Pero algunos de estos operadores tienen la misma precedencia
static bool MayorPrecedencia(char a, char b)
{
    bool resultado = false;

    //Es *
    if (a == '*')
        resultado = true;

    //Es /
    if (a == '/')
    {
        if (b == '*')
            resultado = false;
        else
            resultado = true;
    }

    //Es +
    if (a == '+')
    {
        if (b == '*' || b == '/')
            resultado = false;
        else
            resultado = true;
    }

    //Es -
    if (a == '-')
        resultado = false;

    return resultado;
}