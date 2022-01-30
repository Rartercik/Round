using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_square_scr : MonoBehaviour
{
	public float h1;
	public float h2;
	private Vector2 Vect;
	private Vector2 Vect2;
    public float timer; //Таймер
    public GameObject someobj; //Квадрат
    private Transform _cash; //Кэшируем положние квадрата
    private bool isprosh = true; //Прошёл ли до конца?
    void Awake()
    {
        _cash = someobj.transform;
        Vect[1] = 1f;
        Vect2[1] = -1f;
    }
    void Update()
    {
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
