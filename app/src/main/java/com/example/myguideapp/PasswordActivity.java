package com.example.myguideapp;

import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.GradientDrawable;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import java.util.ArrayList;

public class PasswordActivity extends AppCompatActivity {
    private User user;
    private ArrayList<Sight> allSights;

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_password);
        Intent intent = getIntent();
        GradientDrawable border = new GradientDrawable();
        allSights = (ArrayList<Sight>) intent.getSerializableExtra("sights");
        user = (User)intent.getSerializableExtra("user");
        border.setStroke(5, Color.parseColor("#080301"));
        border.setCornerRadius(20);

    }
    public void onGoOnClick(View view){
        EditText editPassword = findViewById(R.id.password_field);
        if (editPassword.getText().toString().equals("password")){
            Intent intent = new Intent(PasswordActivity.this, AdminActivity.class);
            intent.putExtra("user", user);
            intent.putExtra("wasAdmin", true);
            intent.putExtra("sights", allSights);
            startActivity(intent);
        }
        else {
            Toast.makeText(PasswordActivity.this, "Неправильный пароль",
                    Toast.LENGTH_LONG).show();        }


    }

}
