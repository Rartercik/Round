using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_Silly : MonoBehaviour
{
	public Text t;
	private string s = "Ты действительно сделал это?";
	private string s2 = "Did you realy do this?";
	private bool z = false;
	IEnumerator Fade()
{
    for (int ft = 0; ft < 28; ft += 1) 
    {
    	if(z == true){
    	t.text += s[ft];
    	z = false;
    	}
    	else{
    		ft -= 1;
    		z = true;
    	}
    	yield return null;
    }
}
	IEnumerator FadeEng()
{
    for (int ft = 0; ft < 22; ft += 1) 
    {
    	if(z == true){
    	t.text += s2[ft];
    	z = false;
    	}
    	else{
    		ft -= 1;
    		z = true;
    	}
    	yield return null;
    }
}
	void Start(){
		if(Language_Base.Eng == true){
			StartCoroutine("FadeEng");
		}
		else{
		StartCoroutine("Fade");
		}
	}
}
