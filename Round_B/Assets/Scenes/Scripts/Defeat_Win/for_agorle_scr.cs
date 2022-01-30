using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class for_agorle_scr : MonoBehaviour
{
	public Button yourButton; //Берём нашу кнопку
	public Button anotherbutton; //Берём другую кнопку
	public Text ybtext; //Берём нашу кнопку как текст
	public Text abtext; //Берём чужую кнопку как текст
	public int  whichs; //На какую сцены переносим
	Animator m_Animator; //Берём наш аниматор
	private bool dark = false; //Можно ли переходить в другую комнату
	private Transform hrt; //Сердечко при победе
	private GameObject polojenie; //Положение сердечка при победе
	public AudioClip clip; //Звук выбора
	private AudioSource _cash; //Кэшируем аудио
	public KeyCode keyword; //Какая клавиша
    void Start()
    {
        //Создаём всё для кнопки:
        polojenie = GameObject.Find("Away(Clone)");
        hrt = GameObject.Find("heart_spr").GetComponent<Transform>();
		Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
		ybtext = GetComponent<Text>();
		if(whichs == 3){
		abtext = GameObject.Find("Away(Clone)").GetComponent<Text>();
		anotherbutton = GameObject.Find("Again(Clone)").GetComponent<Button>();
		}
		else{
			abtext = GameObject.Find("Again(Clone)").GetComponent<Text>();
			anotherbutton = GameObject.Find("Away(Clone)").GetComponent<Button>();
		}
		m_Animator = GameObject.Find("Image").GetComponent<Animator>(); //Присваеваем значение аниматору
		_cash = GetComponent<AudioSource>();
    }
    void TaskOnClick()
    {
    	if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Toleft_anim") || m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Darkness_anim")){
    	   	//Nothing
    	   }
    	   else
    	_cash.PlayOneShot(clip); //Звук щелчка
    	if(ybtext.color != Color.yellow){
    	ybtext.color = Color.yellow;
    	abtext.color = Color.white;
    	if(GameObject.Find("Defeat(Clone)") == null){
    		if(gameObject == GameObject.Find("Again(Clone)"))
    		hrt.position = new Vector2(gameObject.transform.position.x - 2.15f, polojenie.transform.position.y);
    		else
    		hrt.position = new Vector2(gameObject.transform.position.x - 1.85f, polojenie.transform.position.y);
    	}
    	}
    	else{
    		if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Nothing_anim")){
    			dark = true;
    		}
    		m_Animator.SetBool("Button", true);
    	}
    }
    void Update()
    {
    	if (Input.GetKeyDown(keyword)){
    		if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Toleft_anim") || m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Darkness_anim")){
    	   	//Nothing
    	   }
    	   else
    	_cash.PlayOneShot(clip); //Звук щелчка
    		ybtext.color = Color.yellow;
    		abtext.color = Color.white;
    		if(GameObject.Find("Defeat(Clone)") == null){
    		if(gameObject == GameObject.Find("Again(Clone)"))
    		hrt.position = new Vector2(gameObject.transform.position.x - 2.15f, polojenie.transform.position.y);
    		else
    		hrt.position = new Vector2(gameObject.transform.position.x - 1.85f, polojenie.transform.position.y);
    	}
    	}
    	if (Input.GetKeyDown(KeyCode.Return) && ybtext.color == Color.yellow){
    		if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Toleft_anim") || m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Darkness_anim")){
    	   	//Nothing
    	   }
    	   else
    	_cash.PlayOneShot(clip); //Звук щелчка
    		if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Nothing_anim")){
    			dark = true;
    		}
    		m_Animator.SetBool("Button", true);
    	}
        if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Darkness_anim") && dark == true){
            if (whichs == 0){
    		SceneManager.LoadScene(whichs);
    		}
    		else{
    			SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    		}
    	}
    }
}
