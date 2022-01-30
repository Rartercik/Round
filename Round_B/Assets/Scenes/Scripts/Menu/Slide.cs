using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Slide : MonoBehaviour
{
	public bool m;
	private Slider sli;
	void Start(){
		sli = GetComponent<Slider>();
		if(m == true){
		sli.value = MS_Base.mus_vol * 100;
		}
		else{
		sli.value = MS_Base.aud_vol * 100;
		}
	}
	public void Sliding(Slider sl){
		if(m == true){
			MS_Base.mus_vol = (float)sl.value/100;
		}
		else{
			MS_Base.aud_vol = (float)sl.value/100;
		}
	}
}
