using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Menu_Open : MonoBehaviour
{
	public GameObject menu;
	public Button yourButton;
	public Image bea; //Для красивого включения
	public bool ok; //Включить или выключить настройки
	private float f = 0.8f;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }
    void Update(){
    	if(ok == false){
    		bea.color = new Color(0, 0, 0, f);
    		f -= Time.deltaTime;
    	}
    }
    void TaskOnClick(){
    	if(ok == false){
    	f = 0.8f;
    	bea.color = new Color(0, 0, 0, f);
    	}
    	menu.SetActive(ok);
    }
}
