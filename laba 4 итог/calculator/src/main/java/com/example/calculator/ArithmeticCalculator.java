package com.example.calculator;

import javafx.application.Application;
import javafx.event.EventHandler;
import javafx.fxml.FXMLLoader;
import javafx.scene.Scene;
import javafx.scene.input.KeyCode;
import javafx.stage.Stage;
import javafx.scene.input.KeyEvent;
public class ArithmeticCalculator extends Application {

    public static void main(String[] args) {
        launch(args);
    }

    @Override
    public void start(Stage primaryStage) throws Exception{
        FXMLLoader fxmlLoader = new FXMLLoader(ArithmeticCalculator.class.getResource("arithm-view.fxml"));
        Scene scene = new Scene(fxmlLoader.load(), 400, 600);
        primaryStage.setTitle("Calculator");
        primaryStage.setWidth(300);
        primaryStage.setHeight(200);
        primaryStage.setResizable(false);
        primaryStage.setScene(scene);

    }
}
