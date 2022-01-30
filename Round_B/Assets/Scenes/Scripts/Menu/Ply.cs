using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ply : MonoBehaviour
{
    public Button yourButton;
    public Transform[] an; //UI объекты
    public bool ol = false; //Проверка на окончание
    public Vector2 start1;
    public Vector2 end1;
    public Vector2 start2;
    public Vector2 end2;
    public Vector2 start3;
    public Vector2 end3;
    public Vector2 start4;
    public Vector2 end4;
    public Vector2 start5;
    public Vector2 end5;
    public Vector2 start6;
    public Vector2 end6;
    public Animator stars; //Для звёзд
    public string yst;
    public string ast;
    private float t = 0;
    public float s; //Скорость UI
    public Ply hoho; //Закончил ли другой скрипт?
    public Animator but;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
    }
    void Update()
    {/*
        if (ol == true)
        {
            if (t < 1)
            {
            	t += s*Time.deltaTime;
                an[0].position = Vector2.Lerp(start1, end1, t);
                an[1].position = Vector2.Lerp(start2, end2, t);
                an[2].position = Vector2.Lerp(start3, end3, t);
                an[3].position = Vector2.Lerp(start4, end4, t);
                an[4].position = Vector2.Lerp(start5, end5, t);
                an[5].position = Vector2.Lerp(start6, end6, t);
                an[6].position = Vector2.Lerp(start4, end4, t);
            }
            else
            {
                ol = false;
                t = 0;
            }
        }*/
    }
    void TaskOnClick()
    {
        //if (hoho.ol == false)
        //{
            //ol = true;
            stars.SetTrigger(yst);
            stars.ResetTrigger(ast);
            but.SetTrigger(yst);
            but.ResetTrigger(ast);
        //}
    }
}
