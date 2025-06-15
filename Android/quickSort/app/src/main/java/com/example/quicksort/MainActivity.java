package com.example.quicksort;

import androidx.appcompat.app.AppCompatActivity;

import android.os.Bundle;
import android.view.View;

import com.example.Bean.QuickSortReceive;
import com.example.quicksort.databinding.ActivityMainBinding;

public class MainActivity extends AppCompatActivity {

    private ActivityMainBinding binding;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);

        binding = ActivityMainBinding.inflate(getLayoutInflater());
        setContentView(binding.getRoot());

        init();
    }

    private void init(){

        //設定 快速排序
        binding.btnQuickSort.setOnClickListener(btnQuickSort_OnClickListener);
    }

    private View.OnClickListener btnQuickSort_OnClickListener = new View.OnClickListener() {
        @Override
        public void onClick(View view) {

            String tvRandomNumber = binding.editTextTextPersonName.getText().toString();

            QuickSortReceive quickSortReceive = new QuickSortReceive();

            //產生亂數
            int randomNumberCount = tvRandomNumber.equals("") ? 10 : Integer.parseInt(tvRandomNumber);
            int [] randomNumberList = new int[randomNumberCount];

            for (int i=0;i<randomNumberCount;i++){
                randomNumberList[i] = (int)(Math.random()*100)+1;
            }

            quickSortReceive.Data = randomNumberList;

            //呼叫API

            //顯示結果

        }
    };
}