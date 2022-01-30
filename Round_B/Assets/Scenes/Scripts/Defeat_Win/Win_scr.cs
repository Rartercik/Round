using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Win_scr : MonoBehaviour
{
	private float h1;
	private float h2;
	private Vector2 Vect;
	private Vector2 Vect2;
    public float timer; //Таймер
    public GameObject someobj; //Квадрат
    private Transform _cash; //Кэшируем положние квадрата
    private bool isprosh = true; //Прошёл ли до конца?
    Text spr; //Для прозрачности
    private float prog = 0;
    public Vector2 nons;
    public created_menu script; //Фиолетовое дошло
    public created_menu script2; //Фиолетовое дошло
    void Awake()
    {
    	_cash = GetComponent<Transform>();
    	_cash.position = nons;
    }
    void Start()
    {
    	_cash.localScale = new Vector3(0.65f, 0.65f, 0.65f);
    	script = GameObject.Find("Again(Clone)").GetComponent<created_menu>();
    	script2 = GameObject.Find("Away(Clone)").GetComponent<created_menu>();
    	script.isit = true;
    	script2.isit = true;
    	spr = GetComponent<Text>();
        Vect[1] = 1f;
        Vect2[1] = -1f;
        h1 = nons[1] + 0.5f;
        h2 = nons[1] - 0.5f;
    }
    void Update()
    {
    	if(prog <= 1){
    		spr.color = new Color(spr.color[0], spr.color[1], spr.color[2], prog); //Изменение прозрачности в плюс
    	prog += 0.01f;
    	}
        if(timer>=0){
    		timer -= Time.deltaTime;
    	}
    	else{
    		if(_cash.position.y < h1 && isprosh == true){
    			_cash.Translate(Vect*Time.deltaTime);
    		}
    		else if(_cash.position.y > h2){
    			isprosh = false;
    			_cash.Translate(Vect2*Time.deltaTime);
    		}
    		else{
    			isprosh = true;
    		}
    	}
    }
}
