using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Lang_Buttons : MonoBehaviour
{
	public Color ramka; //÷вет рамки выбора €зыка
	public Color tsvet; //÷вет текста выбора €зыка
	public Image r;
	public Text t;
	public bool e; //јнглийский или русский
	public Button yourButton;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }
    void Update()
    {
    	if(Language_Base.Eng == true){
    		if(e == true){
    			r.color = ramka;
    			t.color = tsvet;
    		}
    		else{
    			r.color = new Color(1, 1, 1);
    			t.color = new Color(1, 1, 1);
    		}
    	}
    	else if(Language_Base.Eng == false){
    		if(e == false){
    			r.color = ramka;
    			t.color = tsvet;
    		}
    		else{
    			r.color = new Color(1, 1, 1);
    			t.color = new Color(1, 1, 1);
    		}
    	}
    }
    void TaskOnClick(){
    	if(e == true){
    		Language_Base.Eng = true;
    	}
    	else{
    		Language_Base.Eng = false;
    	}
    }
}
