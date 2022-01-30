using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class One_Mswitch : MonoBehaviour
{
	public AudioSource[] aud;
	public bool m; //Музыка или звук
    void Start()
    {
    	if(aud.Length == 1){
    	if(m == true){
    		aud[0].volume *= MS_Base.mus_vol;
    	}
    	else{
    		aud[0].volume *= MS_Base.aud_vol;
    	}
    	}
    	else{
    		aud[0].volume *= MS_Base.mus_vol;
    		aud[1].volume *= MS_Base.aud_vol;
    	}
    }
}
