using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vanising_scr : MonoBehaviour
{
	public bool v1 = false;
	public bool v2 = false;
	public bool v3 = false;
	public bool v4 = false;
	SpriteRenderer spr;
	private float prog = 0.5f;
	public Text hp_txt;
	public Image bar; //Хелсбар
	void Start(){
		 spr = GetComponent<SpriteRenderer>();
}
    void Update()
    {
    	if(v1 == true){
    		spr.color = new Color(1, 1, 1, prog); //Изменение прозрачности в минус
    		prog -= 0.01f;
    	}
    	if(v2 == true){
    		spr.color = new Color(1, 1, 1, 0); //Изменение прозрачности в минус
    	}
    	if(v3 == true){
    		bar.color = new Color(1, 1, 1, 0); //Изменение прозрачности в минус
    	}
    	if(v4 == true){
    		hp_txt.color = new Color(0, 0, 0); //Изменение прозрачности в минус
    	}
    }
}