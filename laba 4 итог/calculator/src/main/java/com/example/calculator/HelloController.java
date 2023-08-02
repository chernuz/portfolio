package com.example.calculator;

import javafx.event.ActionEvent;
import javafx.fxml.FXML;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.input.MouseEvent;
import javafx.scene.text.Text;

public class HelloController {
    @FXML
    public Button fxButton;
    @FXML
    private Label welcomeText;
    @FXML
    private Text output;
    private double num1 = 0;
    private double num2 = 0;
    private boolean start = true;
    private String operator = "";
    private Model model = new Model();
    @FXML
    private void processNum(ActionEvent event)
    {
        if(start)
        {
            output.setText("");
            start=false;
        }
        String v = ((Button)event.getSource()).getText();
        if(v.toCharArray()[v.toCharArray().length-1]=='-' && !output.getText().equals("")) {
            num1=Double.parseDouble(output.getText());
            output.setText("");
            start=true;
            processOperator(event);
            operator="-";
        }
        if(v.toCharArray()[v.toCharArray().length-1]=='%') {
            num2 = Double.parseDouble(output.getText());
            double temp = (model.Calculation(100, num2, operator));
            num2 = temp;
            output.setText(v);
            start=true;
            operator="%";
            processOperator(event);
        }
        else
            output.setText(output.getText()+v);
    }
    @FXML
    private void processOperator(ActionEvent event) {
        String v = ((Button) event.getSource()).getText();
        if (!"=".equals(v)) {
            if (!operator.isEmpty() || operator.equals("C")) {
                output.setText("");
                return;
            }
            operator = v;
            if (!output.getText().isEmpty())
                num1 = Double.parseDouble(output.getText());
            output.setText("");
        } else {
            if (operator.isEmpty() || operator.equals("C")) {
                output.setText("");
                return;
            }
            try {
                num2 = Double.parseDouble(output.getText());
                output.setText((String.valueOf(model.Calculation(num1, num2, operator))));
            }
            catch(Exception e)
            {
                //num2 = Double.parseDouble(output.getText().substring(0, output.getText().length()-2));
                output.setText((String.valueOf(model.Calculation(num1, num2, operator))));
            }
            operator = "";
            start = true;
        }
    }
    @FXML
    private void processArithm(ActionEvent event) throws Exception
    {
        HelloApplication.ArithmCalc();
    }

}