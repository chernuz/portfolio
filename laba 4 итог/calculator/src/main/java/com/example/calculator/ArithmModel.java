package com.example.calculator;

public class ArithmModel {
    public static double[] Calculation(double a, double b, double c)
    {
        double D=b*b-4*a*c;
        if(D>0) {
            double roots[] = new double[2];
            double rootD = Math.sqrt(D);
            roots[0] = (-b+rootD)/(2*a);
            roots[1]=(-b-rootD)/(2*a);
            return roots;
        }
        else {
            if(D==0) {
                double[] roots = new double[1];
                roots[0]=(-b)/(2*a);
                return roots;
            }
            else
            {
                double roots[] = new double[0];
                return roots;
            }
        }

    }
}
