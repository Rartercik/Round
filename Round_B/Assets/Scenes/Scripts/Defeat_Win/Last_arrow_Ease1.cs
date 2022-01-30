using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Last_arrow_Ease1 : MonoBehaviour
{
	public Vector2 diraction; //Направление стрелки
	private Transform _cash; //Кэшируем положение стрелы
	SpriteRenderer spr;
	public Sprite sprite1;
	public Sprite sprite2;
	public GameObject shieldd; //Можно сталкиваться с щитом
	private int num; //Случайный спрайт
	private bool back = false;
	private float timeCount = 0;
	private Vector2 now; //Начало отхода
	public for_trueheart_scr f; //Изменение громкости звука сердечка
	public ParticleSystem[] ps; //Система частиц
	public Color colorit;
	public Image Lay; //Затемнение
	public GameObject[] Wins; //Поражение
	private GameObject pobl;
	private GameObject pobr;
	private bool ohh = false;
	private AudioSource _cashmsc; //Кэшируем аудио
	public AudioClip clip;
	public Text[] Wans; //Победа
	private GameObject canv;
	private float cc = 0;
    void Start()
    {
    	canv = GameObject.Find("Canvas");
    	shieldd = GameObject.Find("shield_obj");
        _cash = transform;
        spr = GetComponent<SpriteRenderer>();
        _cashmsc = GetComponent<AudioSource>();
    }
    void Update(){
    	var col1 = ps[0].colorBySpeed;
    	var col2 = ps[1].colorBySpeed;
    	col1.enabled = true;
    	col2.enabled = true;
    	if(back == true){
    		_cash.position = Vector3.Lerp(now, new Vector2(now[0] + 7, now[1]), timeCount);
    		timeCount += 0.01f;
    		Lay.color = new Color(Lay.color[0], Lay.color[1], Lay.color[2], timeCount);
    	}
    	if(transform.position.x - shieldd.transform.position.x <= 19){
    		f._cash[1].volume -= 0.003f;
    		col1.color = colorit;
    		col2.color = colorit;
    		colorit[3] -= 0.005f;
    		colorit[3] -= 0.005f;
    	}
    	if(Lay.color[3] >= 1f && back == true && ohh == false && timeCount > 0.5f){
    		pobl = Instantiate(Wins[0], Wins[0].transform.position, Quaternion.identity) as GameObject;
        	pobl.transform.SetParent(canv.transform, true);
        	pobl.transform.SetSiblingIndex(7);
        	pobr = Instantiate(Wins[1], Wins[1].transform.position, Quaternion.identity) as GameObject;
        	pobr.transform.SetParent(canv.transform, true);
        	pobr.transform.SetSiblingIndex(8);
        	ohh = true;
        	_cashmsc.PlayOneShot(clip); //Звук победы
    	}
    	else if(ohh == true){
    		Wans[0].color = new Color(Wans[0].color[0], Wans[0].color[1], Wans[0].color[2], cc);
    		Wans[1].color = new Color(Wans[0].color[0], Wans[0].color[1], Wans[0].color[2], cc);
    		Wans[2].color = new Color(Wans[0].color[0], Wans[0].color[1], Wans[0].color[2], cc);
    		Wans[3].color = new Color(Wans[0].color[0], Wans[0].color[1], Wans[0].color[2], cc);
    		Wans[4].color = new Color(Wans[0].color[0], Wans[0].color[1], Wans[0].color[2], cc);
    		Wans[5].color = new Color(Wans[0].color[0], Wans[0].color[1], Wans[0].color[2], cc);
    		Wans[6].color = new Color(Wans[0].color[0], Wans[0].color[1], Wans[0].color[2], cc);
    		cc += 0.01f;
    	}
    }
    void FixedUpdate()
    {
    	_cash.Translate(diraction*Time.deltaTime);
    }
    void OnCollisionEnter2D(Collision2D other){
    	if(other.gameObject == shieldd){
    	back = true;
    	now = new Vector2(transform.position.x, transform.position.y);
    	}
    }
}