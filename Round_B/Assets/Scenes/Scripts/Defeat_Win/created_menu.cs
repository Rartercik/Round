using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class created_menu : MonoBehaviour
{
    private Transform _cash; //Кэшируем позицию
    public Vector3 vect; //Где будет находится
    public Vector2 vect2; //Если победа
    public bool isit = false;
    void Start()
    {
    	_cash = GetComponent<Transform>();
    	if(isit == false){
    	_cash.position = vect;
    	}
    	else{
    		_cash.position = vect2;
    	}
    	_cash.localScale = new Vector3(0.65f, 0.65f, 0.65f);
    }
}