using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class URLS : MonoBehaviour
{
	public Button yourButton;
	public string yourURL;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }
    void TaskOnClick(){
    	Application.OpenURL(yourURL);
    }
}
