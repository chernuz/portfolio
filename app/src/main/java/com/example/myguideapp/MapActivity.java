package com.example.myguideapp;

import android.Manifest;
import android.annotation.SuppressLint;
import android.content.Intent;
import android.content.pm.PackageManager;
import android.content.res.AssetManager;
import android.content.res.Resources;
import android.graphics.Bitmap;
import android.graphics.BitmapFactory;
import android.graphics.Canvas;
import android.graphics.Color;
import android.graphics.ColorFilter;
import android.graphics.Paint;
import android.graphics.PorterDuff;
import android.graphics.PorterDuffColorFilter;
import android.graphics.drawable.Drawable;
import android.os.Bundle;
import android.app.Activity;
import android.os.Environment;
import android.util.Log;
import android.view.View;
import android.view.ViewGroup;
import android.widget.GridView;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.cardview.widget.CardView;
import androidx.core.app.ActivityCompat;
import androidx.core.content.ContextCompat;
import androidx.recyclerview.widget.LinearLayoutManager;
import androidx.recyclerview.widget.RecyclerView;

import com.yandex.mapkit.Animation;
import com.yandex.mapkit.MapKitFactory;
import com.yandex.mapkit.geometry.Point;
import com.yandex.mapkit.map.CameraPosition;

import com.yandex.mapkit.map.MapObject;
import com.yandex.mapkit.map.MapObjectCollection;
import com.yandex.mapkit.map.PlacemarkMapObject;
import com.yandex.mapkit.mapview.MapView;
import com.yandex.runtime.image.ImageProvider;

import java.io.File;
import java.io.IOException;
import java.io.InputStream;
import java.util.ArrayList;
import java.util.Arrays;
import java.util.List;





public class MapActivity extends Activity {

    private static final int PERMISSIONS_REQUEST_LOCATION = 1;
    private final String MAPKIT_API_KEY = "e5ac0605-740b-48df-bb53-7810e4ced9d8";
    private Point TARGET_LOCATION;

    private MapView mapView;



    private CardView buttonScreen;

    private static int count = 0;


    @Override
    protected void onCreate(Bundle savedInstanceState) {

        super.onCreate(savedInstanceState);
        if (count == 0){
            MapKitFactory.setApiKey(MAPKIT_API_KEY);
            MapKitFactory.initialize(this);
        }
        count ++;

        Intent intent = getIntent();
        Sight ourSight = (Sight)intent.getSerializableExtra("sight");
        TARGET_LOCATION = new Point(ourSight.getCoordinates1(), ourSight.getCoordinates2());
        if (ContextCompat.checkSelfPermission(this, Manifest.permission.ACCESS_FINE_LOCATION) == PackageManager.PERMISSION_GRANTED) {

        } else {
            ActivityCompat.requestPermissions(this, new String[]{Manifest.permission.ACCESS_FINE_LOCATION}, PERMISSIONS_REQUEST_LOCATION);
        }



        setContentView(R.layout.activity_map);

        mapView = (MapView)findViewById(R.id.mapview);
        MapObjectCollection mapObjects = mapView.getMap().getMapObjects().addCollection();
        PlacemarkMapObject placemark = mapObjects.addPlacemark(new Point(
                ourSight.getCoordinates1(), ourSight.getCoordinates2()));
        placemark.setOpacity(20.5f);

        mapView.getMap().move(
                new CameraPosition(TARGET_LOCATION, 17.0f, 0.0f, 0.0f),
                new Animation(Animation.Type.SMOOTH, 3),
                null);
        TextView twName = findViewById(R.id.name);
        TextView twHours = findViewById(R.id.workHours);
        TextView twDesc = findViewById(R.id.description);
        twName.setText(ourSight.getName());
        twHours.setText("Время работы: " + ourSight.getWorkHours());
        twDesc.setText(ourSight.getDescription());





    }





    @Override
    protected void onStop() {
        mapView.onStop();
        MapKitFactory.getInstance().onStop();
        super.onStop();
    }

    @Override
    protected void onStart() {
        super.onStart();
        MapKitFactory.getInstance().onStart();
        mapView.onStart();
    }


    public void onBackClick(View view){
        onBackPressed();
    }


}