using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class for_p_scr : MonoBehaviour
{
	Transform trans;
	//Переменные для изменение прозрачности:
	Text spr;
    public float timer; //Таймер
    private bool ifw = false; //Проверка было изменение прозрачности или нет
    private float prog = 0.96f; //Прогресс изменения прозрачности
    private float prog2 = 1; //Прогресс изменения размера
    void Start(){
    	spr = GetComponent<Text>(); //Изменение переменной прозрачности
    	trans = GetComponent<Transform>(); //Для изменения размера
    }
    void Update()
    {
    	if(timer>=0){
    		timer -= Time.deltaTime;
    	}
    	else{
    		if(ifw == false){
 		spr.color = new Color(spr.color[0], spr.color[1], spr.color[2], 1f); //Изменение прозрачности на максимальное значение
 		ifw = true;
    		}
 		else{
 			if(prog>=0){
    		spr.color = new Color(spr.color[0], spr.color[1], spr.color[2], prog); //Изменение прозрачности в минус
    		prog -= 0.01f;
    		trans.localScale = new Vector3(prog2, prog2, prog2);
    		prog2 += 0.01f;
    	}
 		}
    		}
    	}
    }