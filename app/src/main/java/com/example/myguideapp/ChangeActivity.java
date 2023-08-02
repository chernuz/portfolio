package com.example.myguideapp;

import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.GradientDrawable;
import android.os.Bundle;
import android.view.View;
import android.widget.EditText;
import android.widget.Toast;

import androidx.appcompat.app.AppCompatActivity;

import org.json.JSONException;

import java.io.IOException;
import java.util.ArrayList;

public class ChangeActivity extends AppCompatActivity {
    private ArrayList<Sight> allSights;
    private User user;
    private int pos;
    private boolean addFlag;
    private double lng;
    private double ltd;

    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_change);
        Intent intent = getIntent();
        allSights = (ArrayList<Sight>) intent.getSerializableExtra("sights");
        user = (User)intent.getSerializableExtra("user");
        addFlag =(boolean)intent.getSerializableExtra("addFlag");
        GradientDrawable border = new GradientDrawable();
        if (addFlag==false){
            pos=(int)intent.getSerializableExtra("pos");
        }
        border.setStroke(5, Color.parseColor("#080301"));
        border.setCornerRadius(20);

    }
    public void onDeleteOnClick(View view){
        if (addFlag==false) {
            allSights.remove(pos);
        }
        Intent intent = new Intent(ChangeActivity.this, SightsActivity.class);
        intent.putExtra("sights", allSights);
        intent.putExtra("user", user);
        intent.putExtra("wasAdmin", true);
        startActivity(intent);
    }
    public void onGoOnClick(View view) throws JSONException, IOException {
        EditText editLongtitude = findViewById(R.id.longtitude_field);
        EditText editLatitude = findViewById(R.id.latitude_field);
        EditText editName = findViewById(R.id.namenew_field);
        EditText editWorkTime = findViewById(R.id.worktime_field);
        EditText editDate = findViewById(R.id.date_field);
        EditText editDescription = findViewById(R.id.description_field);
        if (allFieldsPassed(editName, editLongtitude, editLatitude, editDescription, editDate, editWorkTime)) {
            Sight sight = new Sight(editName.getText().toString(), Double.parseDouble(editLongtitude.getText().toString()),
                    Double.parseDouble(editLatitude.getText().toString()), editWorkTime.getText().toString(),
                    Integer.parseInt(editDate.getText().toString()), editDescription.getText().toString());
            if (addFlag) {
                allSights.add(sight);
            } else {
                allSights.remove(pos);
                allSights.add(pos, sight);
            }
            Intent intent = new Intent(ChangeActivity.this, SightsActivity.class);
            intent.putExtra("sights", allSights);
            intent.putExtra("user", user);
            intent.putExtra("wasAdmin", true);
            startActivity(intent);

        }
        else {
            Toast.makeText(ChangeActivity.this, "Все поля должны быть заполнены",
                    Toast.LENGTH_LONG).show();        }


    }
    private boolean allFieldsPassed(EditText e1, EditText e2, EditText e3, EditText e4, EditText e5, EditText e6){
        return !e1.getText().toString().equals("") && !e2.getText().toString().equals("") &&
                !e3.getText().toString().equals("") &&
                !e4.getText().toString().equals("") &&
                !e5.getText().toString().equals("") &&
                !e6.getText().toString().equals("");
    }


}
