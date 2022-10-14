using _14_EvalPrePost;
using System.Net.NetworkInformation;

//Evaluamos postfix
CStack miStack = new CStack();
int n = 0;
int a = 0;
int b = 0;
int r = 0;

// -+3*52*73
// 352*+73*-
string expresion = "-+3*52*73";
char caracter = ' ';

for (n = expresion.Length - 1; n >= 0; n--) //prefix
//for (n = 0; n < expresion.Length; n++) //postfix
{
    //Obtenemos el caracter
    caracter = expresion[n];

    //Verificamos si es numero
    if (caracter >= '0' && caracter <= '9')
    {
        // Lo colocamos en el stack
        miStack.Push(Convert.ToInt32(caracter.ToString()));
    }
    else //Es operador
    {
        //Hacemos dos pop
        //Postfix b->a
        //prefix a->b
        a = miStack.Pop();
        b = miStack.Pop();

        //Verificamos que operador es y aplicamos la operacion
        if (caracter == '+')
        {
            r = a + b;
            miStack.Push(r);
        }
        if (caracter == '-')
        {
            r = a - b;
            miStack.Push(r);
        }
        if (caracter == '/')
        {
            r = a / b;
            miStack.Push(r);
        }
        if (caracter == '*')
        {
            r = a * b;
            miStack.Push(r);
        }
    }
}

miStack.Transversa();