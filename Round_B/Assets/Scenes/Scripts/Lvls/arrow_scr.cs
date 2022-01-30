using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arrow_scr : MonoBehaviour
{
	public Vector2 diraction; //Направление стрелки
	private Transform _cash; //Кэшируем положение стрелы
	SpriteRenderer spr;
	public Sprite sprite1;
	public Sprite sprite2;
	public GameObject shieldd; //Можно сталкиваться с щитом
	private int num; //Случайный спрайт
    void Start()
    {
    	shieldd = GameObject.Find("shield_obj");
    	num = Random.Range(0, 2);
        _cash = transform;
        spr = GetComponent<SpriteRenderer>();
        if(num == 0){
    	spr.sprite = sprite1;
    	}
    	else if(num == 1){
    	spr.sprite = sprite2;
    	}
    }
    void FixedUpdate()
    {
    	_cash.Translate(diraction*Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D other){
    	if(other.gameObject == shieldd){
    	gameObject.SetActive(false);
    	}
    }
}
