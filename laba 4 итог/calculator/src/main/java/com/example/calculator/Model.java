package com.example.calculator;
public class Model{
    public static Double Calculation (double n1, double n2, String operator)
    {
        switch(operator)
        {
            case "+":
                return (n1+n2);
            case "-":
                return (n1-n2);
            case "/":
                /*if(n2 == 0)
                {
                    return "Ошибка: невозможно делить на 0";
                }*/
                return (n1/n2);
            case "*":
                return (n1*n2);
            case "mod":
                /*if(n2 == 0)
                {
                    return "Ошибка: невозможно делить на 0";
                }*/
                return (n1%n2);
            case "%":
                return (n1*(n2/100));
            case "^":
                return (Math.pow(n1, n2));
            case ",":
                while(n2>1)
                    n2/=10;
                n1=n1+n2;
                return (n1);
            case "C":
                return 0.0;
            default:
                return 0.0;
            //return ("Неизвестный оператор "+ operator);
            //return (Double.toString(n1+n2));
        }
    }
}
