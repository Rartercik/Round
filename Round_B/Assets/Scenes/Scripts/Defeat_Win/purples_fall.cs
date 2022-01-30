using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class purples_fall : MonoBehaviour
{
	private Rigidbody2D rb2D; //Берём компонент физики
	public float pov; //Как поворачиваем
	public float fromminx; //Минимальное значение по X
	public float tomaxx; //Максимальное значение по X
	public float fromminy; //Минимальное значение по Y
	public float tomaxy; //Максимальное значение по Y
	private float itogx; //Итоговое значение X
	private float itogy; //Итоговое значение Y
	private Transform _cash; //Кэшируем поворот шестертинки
	public GameObject[] Wins; //Поражение
	private GameObject p;
	private GameObject o;
	private GameObject b;
	private GameObject e;
	private GameObject d;
	private GameObject a;
	private GameObject i;
	private GameObject pobl;
	private GameObject pobr;
	private float del = 3f; //Через сколько появляется
	private bool stopit = false; //Чтобы появлялся только один раз
	public GameObject canv;
	public AudioClip clip; //Звук столкновения
	private AudioSource _cashmsc; //Кэшируем аудио
	public int[] sibling;
    void Start()
    {
        canv = GameObject.Find("Canvas");
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        itogx = Random.Range(fromminx, tomaxx);
        itogy = Random.Range(fromminy, tomaxy);
        rb2D.AddForce(new Vector2(itogx, itogy));
        _cash = GetComponent<Transform>();
        _cashmsc = GetComponent<AudioSource>();
    }
    void Update()
    {
    	if(itogx>=0)
        _cash.Rotate(0.0f, 0.0f, -pov, Space.World );
    	else
    	_cash.Rotate(0.0f, 0.0f, pov, Space.World );	
        if(del>0){
        	del -= Time.deltaTime;
        }
        else{
        	if(Wins.Length>0 && stopit == false){
    		p = Instantiate(Wins[0], new Vector2(-658, 242), Quaternion.identity) as GameObject;
    		p.transform.SetParent(canv.transform, true);
    		p.transform.SetSiblingIndex(sibling[0]);
        	o = Instantiate(Wins[1], new Vector2(-408, 242), Quaternion.identity) as GameObject;
        	o.transform.SetParent(canv.transform, true);
        	o.transform.SetSiblingIndex(sibling[1]);
        	b = Instantiate(Wins[2], new Vector2(-158, 242), Quaternion.identity) as GameObject;
        	b.transform.SetParent(canv.transform, true);
        	b.transform.SetSiblingIndex(sibling[2]);
        	e = Instantiate(Wins[3], new Vector2(92, 242), Quaternion.identity) as GameObject;
        	e.transform.SetParent(canv.transform, true);
        	e.transform.SetSiblingIndex(sibling[3]);
        	d = Instantiate(Wins[4], new Vector2(342, 242), Quaternion.identity) as GameObject;
        	d.transform.SetParent(canv.transform, true);
        	d.transform.SetSiblingIndex(sibling[4]);
        	a = Instantiate(Wins[5], new Vector2(592, 242), Quaternion.identity) as GameObject;
        	a.transform.SetParent(canv.transform, true);
        	a.transform.SetSiblingIndex(sibling[5]);
        	i = Instantiate(Wins[6], new Vector2(795, 242), Quaternion.identity) as GameObject;
        	i.transform.SetParent(canv.transform, true);
        	i.transform.SetSiblingIndex(sibling[6]);
        	pobl = Instantiate(Wins[7], Wins[7].transform.position, Quaternion.identity) as GameObject;
        	pobl.transform.SetParent(canv.transform, true);
        	pobl.transform.SetSiblingIndex(sibling[7]);
        	pobr = Instantiate(Wins[8], Wins[8].transform.position, Quaternion.identity) as GameObject;
        	pobr.transform.SetParent(canv.transform, true);
        	pobr.transform.SetSiblingIndex(sibling[8]);
        	_cashmsc.PlayOneShot(clip); //Звук победы
    		stopit = true;
        	}
        }
    }
}
