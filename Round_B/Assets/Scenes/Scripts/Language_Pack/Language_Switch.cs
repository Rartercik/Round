using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Language_Switch : MonoBehaviour
{
	public string English;
	public string Russian;
	private Text textik;
    void Start()
    {
    	textik = GetComponent<Text>();
    	if(Language_Base.Eng == true){
    		textik.text = English;
    	}
    	else{
    		textik.text = Russian;
    	}
    }
    void Update()
    {
    	if(Language_Base.Eng == true){
    		textik.text = English;
    	}
    	else{
    		textik.text = Russian;
    	}
    }
}
