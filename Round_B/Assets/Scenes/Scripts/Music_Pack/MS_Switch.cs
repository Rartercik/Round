using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MS_Switch : MonoBehaviour
{
	public AudioSource aud;
	public bool m; //Музыка или звук
    void Update()
    {
    	if(m == true){
    		aud.volume = MS_Base.mus_vol;
    	}
    	else{
    		aud.volume = MS_Base.aud_vol;
    	}
    }
}
