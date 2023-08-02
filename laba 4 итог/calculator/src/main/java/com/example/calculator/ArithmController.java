package com.example.calculator;

import javafx.fxml.FXML;
import javafx.scene.control.TextField;
import javafx.scene.input.KeyCode;
import javafx.scene.input.KeyEvent;
import javafx.scene.text.Text;
import java.util.ArrayList;
import java.util.Scanner;
import javax.script.ScriptEngineManager;
import javax.script.ScriptEngine;
import javax.script.ScriptException;

public class ArithmController {
    @FXML
    public TextField output;
    @FXML
    private void proccessKeyPressed(KeyEvent key) throws ScriptException
    {
        ArrayList<Character> accessible = new ArrayList<Character>();
        boolean isEquality = false;
        accessible.add('x'); accessible.add('+'); accessible.add('='); accessible.add('-'); accessible.add('/'); accessible.add('^'); accessible.add(' '); accessible.add('.');
        if(key.getCode()== KeyCode.ENTER)
        {
            String text = output.getText();
            ArrayList<Character> chars = new ArrayList<>();
            for (char c : text.toCharArray()) {
                chars.add(c);
            }
            if(!text.contains("x^2") || !text.contains("="))
            {
                output.setText("Вы ввели не квадратное уравнение");
                return;
            }
            if(!text.contains("x"))
            {
                output.setText("Вы ввели не уравнение");
                return;
            }
            for(int i=0; i<chars.size(); i++)
            {
                if(!Character.isDigit(chars.get(i)) && !accessible.contains(chars.get(i))) {
                    output.setText("Введен неправильный символ");
                    return;
                }
                if(chars.get(i)=='=')
                    isEquality = true;
            }


            double a=0, b=0, c=0;
            int currentInd=0;
            //String temp="";

            //убираем лишние пробелы
            text.replaceAll(" ", "");
            //разделяем на пол. и отр. части
            String[] texts = text.split("=");
            //считываем индексы
            try {
                for (int i = 0; i < texts.length; i++) {
                    //a
                    if (currentInd == texts[i].indexOf("x^2", currentInd)) {
                        a += 1 * (i == 0 ? 1 : -1);
                        //temp+="a1 ";
                    }
                    else {
                        if (currentInd == texts[i].indexOf("x^2", currentInd) - 1 && texts[i].toCharArray()[currentInd] == '-') {
                            a += -1 * (i == 0 ? 1 : -1); //temp+="a2 ";
                        } else {
                            a += Double.parseDouble(texts[i].substring(currentInd, texts[i].indexOf("x^2", currentInd))) * (i == 0 ? 1 : -1);
                            //temp+="a3 ";
                        }
                    }
                    currentInd = texts[i].indexOf("x^2") + 3;
                    if (texts[i].toCharArray()[currentInd] == '+')
                        currentInd++;
                    else {
                        if (texts[i].toCharArray()[currentInd] != '-' && currentInd!=texts[i].length()-1) {
                            output.setText("Уравнение введено в неверном формате "+currentInd);
                            return;
                        }
                    }
                    //b
                    if (currentInd == texts[i].indexOf("x", currentInd))
                        b += 1 * (i == 0 ? 1 : -1);
                    else {
                        if (currentInd == texts[i].indexOf("x", currentInd) - 1 && texts[i].toCharArray()[currentInd] == '-') {
                            b += -1 *(i == 0 ? 1 : -1);
                        } else {
                            b += Double.parseDouble(texts[i].substring(currentInd, texts[i].indexOf("x", currentInd))) * (i == 0 ? 1 : -1);
                        }
                    }
                    currentInd = texts[i].indexOf("x", currentInd) + 1;
                    if (texts[i].toCharArray()[currentInd] == '+')
                        currentInd++;
                    else {
                        if (texts[i].toCharArray()[currentInd] != '-' && currentInd!=texts[i].length()-1) {
                            output.setText("Уравнение введено в неверном формате "+ currentInd);
                            return;
                        }
                    }
                    //c
                    if (currentInd == texts[i].length())
                        c += 0;
                    else
                        c += Double.parseDouble(texts[i].substring(currentInd, texts[i].length())) * (i == 0 ? 1 : -1);
                    currentInd=0;
                }
            }
            catch(Exception e) {
                output.setText(e.getMessage());
            }
            //output.setText(texts[0].indexOf("x^2")+" " + texts[0].indexOf("x", texts[0].indexOf("x^2")+3));
            //output.setText("Считывание завершено a ="+a+" b= "+b+" c="+c);
            if(a==0) {
                output.setText("Введенное уравнение не является квадратным");
                return;
            }
            double[] roots = ArithmModel.Calculation(a, b, c);
            if(roots.length==0)
            {
                output.setText("D<0");
            }
            else
            {
                if(roots.length==1)
                    output.setText("x = "+ roots[0]);
                else
                    output.setText("x1 = "+roots[0]+"; x2 = "+roots[1]);
            }


            /*double D=Math.sqrt(b*b-4*a*c);
            if(D<0)
            {
                output.setText("D<0");
            }
            else
            {
                if(D==0)
                {
                    double x=(-b)/(2*a);
                    output.setText("x =" +x);
                }
                else
                {
                    double rootD=Math.sqrt(D);
                    double x1=(-b+rootD)/(2*a);
                    double x2=(-b-rootD)/(2*a);
                    output.setText("x1 = "+x1+"; x2 = "+x2);
                }
            }*/
        }
    }
}
