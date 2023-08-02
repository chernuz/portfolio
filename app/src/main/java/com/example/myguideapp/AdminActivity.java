package com.example.myguideapp;

import android.content.Intent;
import android.graphics.drawable.GradientDrawable;
import android.os.Bundle;
import android.view.MotionEvent;
import android.view.View;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.GridLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import java.util.ArrayList;

public class AdminActivity extends AppCompatActivity {

    private ArrayList<Sight> allSights;
    private RecyclerView lw;
    private User user;
    @Override
    protected void onCreate(Bundle savedInstanceState){
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_admin);
        Intent intent = getIntent();
        allSights = (ArrayList<Sight>) intent.getSerializableExtra("sights");
        user = (User)intent.getSerializableExtra("user");
        String[] admNames = new String[allSights.size()];
        for (int j = 0; j < allSights.size(); ++j){
            admNames[j] = allSights.get(j).getName();
        }
        if (allSights.size() ==0){
            Toast.makeText(AdminActivity.this,"В избранное пока ничего не добавлено",
                    Toast.LENGTH_LONG).show();
        }
        System.out.println(admNames.length);
        androidx.cardview.widget.CardView card = findViewById(R.id.cardFav);
        GradientDrawable border = new GradientDrawable();

        border.setCornerRadius(20);
        card.setBackground(border);
        lw = findViewById(R.id.recyclerFav);
        MyAdapter myAdapter = new MyAdapter(admNames);
        lw.setAdapter(myAdapter);
        lw.setLayoutManager(new GridLayoutManager(this, 1));
    }

    public void onAdminSightClick(View view){
        lw.addOnItemTouchListener(new RecyclerView.OnItemTouchListener() {
            @Override
            public boolean onInterceptTouchEvent(@NonNull RecyclerView rv, @NonNull MotionEvent e) {
                return true;
            }

            @Override
            public void onTouchEvent(@NonNull RecyclerView rv, @NonNull MotionEvent e) {
                View childView = rv.findChildViewUnder(e.getX(), e.getY());
                if (childView != null && e.getAction() == MotionEvent.ACTION_UP) {
                    int pos = rv.getChildAdapterPosition(childView);
                    Intent intent = new Intent(AdminActivity.this, ChangeActivity.class);
                    intent.putExtra("sights", allSights);
                    intent.putExtra("user", user);
                    intent.putExtra("addFlag", false);
                    intent.putExtra("pos", pos);
                    startActivity(intent);
                }
            }

            @Override
            public void onRequestDisallowInterceptTouchEvent(boolean disallowIntercept) {}
        });

    }

    public void onAddClick(View view){
        Intent intent1 = new Intent(AdminActivity.this, ChangeActivity.class);
        intent1.putExtra("user", user);
        intent1.putExtra("sights", allSights);
        intent1.putExtra("addFlag", true);
        startActivity(intent1);
    }
    public void onMainClick(View view){
        Intent intent = new Intent(AdminActivity.this, SightsActivity.class);
        intent.putExtra("user", user);
        intent.putExtra("wasAdmin", true);
        intent.putExtra("sights", allSights);
        startActivity(intent);
    }
}
