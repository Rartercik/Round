using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;

public class for_right_scr : MonoBehaviour
{
    //Глобальная переменная для выбора кнопки:
	public Button yourButton;
	//Реакция на прозрачность кнопки:
	[Range(0f, 1f)]
    public float AlphaLevel = 1f;
    private Image bt;
    //Переменные для вращения щита:
	public GameObject yourRot;
	private bool forotb = false;
	private bool forotb2 = false;
	private bool forotb3 = false;
	private bool ifwas = false; //Была ли анимация?
	//Кэширование:
	private Transform _cash; //Кэшируем положние щита
	Animator animator; //Добавляем анимацию
	void Awake () {
	_cash = yourRot.transform;
	animator = yourRot.GetComponent<Animator>(); //Ссылка на анимацию
}
    void Start()
    {
        //Создаём всё для кнопки:
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		//Реакция на прозрачность кнопки:
		bt = gameObject.GetComponent<Image>();
        bt.alphaHitTestMinimumThreshold = AlphaLevel;
    }
    void Update(){
    	if(forotb == true){
    		if(ifwas == false){
			animator.SetBool("Up", false);
    		animator.SetBool("down", false);
    		animator.SetBool("left", false);
    		animator.SetBool("right", true);
    		ifwas = true;
    		}
    		else{
    			forotb = false;
    		}
    	}
    	if(forotb2 == true){
    		if(ifwas == false){
    		animator.SetBool("Up", false);
    		animator.SetBool("down", false);
    		animator.SetBool("left", false);
    		animator.SetBool("right", true);
    		ifwas = true;
    		}
    		else{
    			forotb2 = false;
    		}
    	}
    	if(forotb3 == true){
    		if(ifwas == false){
			animator.SetBool("Up", false);
    		animator.SetBool("down", false);
    		animator.SetBool("left", false);
    		animator.SetBool("right", true);
    		ifwas = true;
    		}
    		else{
    			forotb3 = false;
    		}
    	}
    	//Для ПК:
    	/*if (Input.GetKeyDown(KeyCode.D))
        {
    		forotb = true;
			ifwas = false;
        }*/
    }
    void TaskOnClick()
	{
    	//Выравниваем поворот:
    	Quaternion rotationNorm = Quaternion.AngleAxis(0, new Vector3(0, 0, 1)); //1
    	Quaternion rotationNorm2 = Quaternion.AngleAxis(270, new Vector3(0, 0, 1)); //2
    	Quaternion rotationNorm3 = Quaternion.AngleAxis(180, new Vector3(0, 0, 1)); //3
    	Quaternion rotationNeNorm = Quaternion.AngleAxis(360, new Vector3(0, 0, 1)); //1
    	Quaternion rotationNeNorm2 = Quaternion.AngleAxis(-90, new Vector3(0, 0, 1)); //2
    	Quaternion rotationNeNorm3 = Quaternion.AngleAxis(-180, new Vector3(0, 0, 1)); //3
    	if(_cash.rotation == rotationNeNorm){
    		_cash.rotation = rotationNorm;
    	}
    	else if(_cash.rotation == rotationNeNorm2){
    		_cash.rotation = rotationNorm2;
    	}
    	else if(_cash.rotation == rotationNeNorm3){
    		_cash.rotation = rotationNorm3;
    	}
		//Реализация кнопки:
		Quaternion rotationZ = Quaternion.AngleAxis(270, new Vector3(0, 0, 1)); //Если снизу
		Quaternion rotationZ2 = Quaternion.AngleAxis(180, new Vector3(0, 0, 1)); //Если слево
    	Quaternion rotationZ3 = Quaternion.AngleAxis(90, new Vector3(0, 0, 1)); //Если сверху
		forotb = true;
		ifwas = false;
    }
}