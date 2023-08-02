package com.example.myguideapp;

import android.content.Intent;
import android.graphics.Color;
import android.graphics.drawable.GradientDrawable;
import android.os.Bundle;
import android.view.View;
import android.widget.ArrayAdapter;
import android.widget.ListView;
import android.widget.PopupMenu;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;
import androidx.cardview.widget.CardView;

import java.util.ArrayList;

public class SightsActivity extends AppCompatActivity {
    private ListView lsSights;
    private ArrayList<Sight> allSights;
    private User user;
    private boolean wasAdmin;


    private void createSights(){
        allSights = new ArrayList<>();
        allSights.add(new Sight("Московский Кремль",55.751812, 37.617493, "10:00-17:00",1495, "Моско́вский Кремль — крепость в центре Москвы и древнейшая её часть, главный общественно-политический и историко-художественный комплекс города, официальная резиденция Президента Российской Федерации, вплоть до распада СССР в декабре 1991 года была официальной резиденцией Генерального секретаря ЦК КПСС (в 1990—1991 годах — Президента СССР). Одно из самых известных архитектурных сооружений в мире."));
        allSights.add(new Sight("ГУМ",55.75477667007279, 37.62093955800939, "10:00-22:00",1893, "ГУМ (аббревиатура от «Государственный универсальный магазин», до 1921 года — Верхние торговые ряды) — крупный торговый комплекс (универсальный магазин) в центре Москвы, который занимает местность Китай-города и выходит главным фасадом на Красную площадь. Позиционирует себя как главный универсальный магазин страны и целый торговый квартал."));
        allSights.add(new Sight("Собор Василия Блаженного", 55.75252244325822, 37.6228074893885, "11:00-23:00",1792, "Храм Васи́лия Блаже́нного, официально собо́р Покрова́ Пресвято́й Богоро́дицы, что на Рву (также Покро́вский собо́р, собо́р Покрова́ на Рву) — православный храм на Красной площади в Москве, памятник русской архитектуры. Построен в 1555—1561 годах." + "\n" + "Объединяет одиннадцать церквей (приделов), часть из которых освящена в честь святых, дни памяти которых пришлись на решающие бои за Казань."));
        allSights.add(new Sight("ПАРЯЩИЙ МОСТ В ПАРКЕ ЗАРЯДЬЕ",55.75132191748619, 37.628852441513615, "Круглосуточно",2017, "«Парящий мост» парка Зарядье – новая смотровая площадка в Москве – в плане напоминает букву «V» латинского алфавита." + "\n" + "Ограждение выполнено из прочного стекла, что одновременно обеспечивает безопасность нахождения на мосту людей и в то же время не закрывает панораму обзора столичных достопримечательностей." + "\n" + "Парящий мост в Москве – уникальное сооружение. Конструкция выполнена с использованием напряженного бетона, что позволяет мостовому сооружению выдерживать значительные нагрузки – более 240 тонн или порядка 4 тысяч человек одновременно."));
        allSights.add(new Sight("ПАРК ГОРЬКОГО", 55.72961504970115, 37.601215210828045, "Круглосуточно",1923, "Центра́льный парк культу́ры и о́тдыха и́мени Макси́ма Го́рького (сокращённо ЦПКиО или парк Горького, международное название — англ. Gorky Park) — московский парк культуры и отдыха, столичная рекреационная зона, одна из самых больших и популярных в городе[2][3]." + "\n" + "Партерная часть парка появилась в 1923 году после организации на месте свалки Орловского луга Всероссийской сельскохозяйственной выставки (ВСХВ), планировку которой от входа до Нескучного сада выполнил архитектор-авангардист Константин Мельников. ПКиО был открыт 12 августа 1928 года, в 1932 году парку присвоили имя писателя Максима Горького. В разное время проектировкой парка занимались Эль Лисицкий и Александр Власов. Арка главного входа возведена в 1955 году по проекту архитектора Георгия Щуко."));
        allSights.add(new Sight("ВДНХ", 55.83137786717367, 37.62971947229152, "Круглосуточно",1939, "ВДНХ, или Выставка достижений народного хозяйства, — огромный музейный комплекс и парк отдыха, в котором регулярно проходят международные концерты и фестивали, работают выставки и парк аттракционов. Для любителей необычных пеших прогулок недавно открылась бесплатная эко-тропа между деревьями на высоте 6 метров."));
        allSights.add(new Sight("ЭКСПЕРИМЕНТАНИУМ",55.809882980069816, 37.51117069807424, "10:00-20:00",2011, "Экспериментаниум — это увлекательный способ начать знакомство с наукой. В музее собраны сотни интерактивных экспонатов, которые можно потрогать, подёргать, покрутить, послушать, построить. Взрослые тоже разрешают участвовать в опытах и экспериментах."));
        allSights.add(new Sight("СЕВЕРНЫЙ РЕЧНОЙ ВОКЗАЛ",55.85120056658706, 37.466798968506964, "Круглосуточно",1937 , "Северный речной вокзал интересен не только как отправной пункт круизных теплоходов по каналу Москва-Волга до Санкт-Петербурга, Валаама, Кижи, Углича, Твери, Ярославля, Калязина и прогулочных теплоходов по Москве-реке. Здание вокзала похоже на большой двухпалубный теплоход и типично для сталинской архитектуры. 75-метровый шпиль держит звезду, подобную звёздам башен Кремля. А трехъярусные арки на фасадах напоминают венецианский Дворец Дожей."));

    }
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_sights);
        Intent intent = getIntent();
        androidx.cardview.widget.CardView card = findViewById(R.id.card2);
        GradientDrawable border = new GradientDrawable();

        border.setStroke(1, Color.parseColor("#292726"));
        border.setCornerRadius(20);
        card.setBackground(border);

        user = (User)intent.getSerializableExtra("user");
        wasAdmin = (boolean)intent.getSerializableExtra("wasAdmin");

        TextView textHello = findViewById(R.id.helloText);
        textHello.setText(textHello.getText() + " " + user.getName() + " " + user.getSurname());
        if (wasAdmin==false) {
            createSights();
        }
        else{
            allSights = (ArrayList<Sight>) intent.getSerializableExtra("sights");
        }
        showSights();


    }
    public void onMenuClick(View v){
        CardView buttonMenu = findViewById(R.id.buttonmenu);
        buttonMenu.setOnClickListener(view -> {
            PopupMenu menu = new PopupMenu(SightsActivity.this, buttonMenu);
            menu.getMenuInflater().inflate(R.menu.menu_favour, menu.getMenu());
            menu.show();
            menu.setOnMenuItemClickListener(menuItem -> {
                if (menuItem.getItemId() == R.id.menu_item1) {
                    Intent intent1 = new Intent(SightsActivity.this,
                            PasswordActivity.class);
                    intent1.putExtra("user", user);
                    intent1.putExtra("sights", allSights);
                    wasAdmin=true;
                    startActivity(intent1);
                }
                return true;
            });
            //Log.d("sss", "click");

        });
    }
    private void showSights(){
        String[] sightNames = new String[allSights.size()];
        for (int i = 0; i < allSights.size(); ++i){
            sightNames[i] = allSights.get(i).getName();
        }
        lsSights = findViewById(R.id.sightsList);
        ArrayAdapter<String> arrayAdapter= new ArrayAdapter<String>(this,
                R.layout.list_sights, R.id.buttonSight,
                sightNames);
        lsSights.setAdapter(arrayAdapter);

    }

    public void onSightClick(View view){
        int pos = lsSights.getPositionForView(view);
        Sight currentSight = allSights.get(pos);
        Intent intent = new Intent(SightsActivity.this, MapActivity.class);
        intent.putExtra("sight", currentSight);
        intent.putExtra("user", user);
        startActivity(intent);
    }


}
