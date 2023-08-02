package com.example.calculator;

import javafx.application.Application;
import javafx.event.ActionEvent;
import javafx.event.EventHandler;
import javafx.fxml.FXML;
import javafx.fxml.FXMLLoader;
import javafx.scene.Parent;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.TextField;
import javafx.stage.Modality;
import javafx.stage.Stage;
import javafx.scene.control.Label;
import javafx.scene.layout.StackPane;
import java.io.IOException;

public class HelloApplication extends Application {
    //@FXML Button arithmButton;
    public static Stage primaryStage;
    @Override
    @FXML
    public void start(Stage stage) throws IOException {
        FXMLLoader fxmlLoader = new FXMLLoader(HelloApplication.class.getResource("hello-view.fxml"));

        //arithmButton = (Button)fxmlLoader.getNamespace().get("arithmButton");
        Scene scene = new Scene(fxmlLoader.load(), 650, 300);
        stage.setTitle("Calculator");
        stage.setWidth(300);
        stage.setHeight(500);
        stage.setResizable(false);
        stage.setScene(scene);
        stage.show();
        primaryStage = stage;
    }
    public static void ArithmCalc() throws Exception
    {
        /*Label secondLabel = new Label("Введите уравнение:");
        StackPane secondaryLayout = new StackPane();
        secondaryLayout.getChildren().add(secondLabel);
        Scene secondScene = new Scene(secondaryLayout, 230, 100);

                // New window (Stage)
        Stage newWindow = new Stage();
        newWindow.setTitle("арифметический калькулятор");
        newWindow.setScene(secondScene);
                // Specifies the modality for new window.
        newWindow.initModality(Modality.WINDOW_MODAL);

                // Specifies the owner Window (parent) for new window
                //newWindow.initOwner();

                // Set position of second window, related to primary window.
        newWindow.setX(200);
        newWindow.setY(100);

        newWindow.show();

        StackPane root = new StackPane();
        Scene scene1 = new Scene(root, 450, 250);
        newWindow.setScene(scene1);
        TextField text = new TextField("Введите уравнение");*/
        ArithmeticCalculator arithm = new ArithmeticCalculator();
        arithm.start(primaryStage);
    }

    public static void main(String[] args) {
        launch();

    }
}