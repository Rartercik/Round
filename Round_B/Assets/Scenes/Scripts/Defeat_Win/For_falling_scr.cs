using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_falling_scr : MonoBehaviour
{
	private Rigidbody2D rb2D; //Берём компонент физики
	public float pov; //Как поворачиваем
	public float fromminx; //Минимальное значение по X
	public float tomaxx; //Максимальное значение по X
	public float fromminy; //Минимальное значение по Y
	public float tomaxy; //Максимальное значение по Y
	private float itogx; //Итоговое значение X
	private float itogy; //Итоговое значение Y
	private Transform _cash; //Кэшируем поворот четвертинки
	public GameObject[] Defeats; //Поражение
	public GameObject defd;
	public GameObject defd2;
	public GameObject defd3;
	private float del = 1f; //Через сколько появляется
	private bool stopit = false; //Чтобы появлялся только один раз
	//Transform _delta;
	public GameObject canv;
	public AudioClip clip; //Звук поражения
	private AudioSource _cashmsk; //Кэшируем аудио
    void Start()
    {
    	canv = GameObject.Find("Canvas");
        rb2D = gameObject.GetComponent<Rigidbody2D>();
        itogx = Random.Range(fromminx, tomaxx);
        itogy = Random.Range(fromminy, tomaxy);
        rb2D.AddForce(new Vector2(itogx, itogy));
        _cash = GetComponent<Transform>();
        _cashmsk = GetComponent<AudioSource>();
    }
    void Update()
    {
        _cash.Rotate(0.0f, 0.0f, pov, Space.World );
        if(del>0){
        	del -= Time.deltaTime;
        }
        else{
        	if(Defeats.Length>0 && stopit == false){
        		_cashmsk.PlayOneShot(clip);
        	defd = Instantiate(Defeats[0], Defeats[0].transform.position, Quaternion.identity) as GameObject;
        	defd.transform.SetParent(canv.transform, true);
        	defd.transform.SetSiblingIndex(0);
        	defd2 = Instantiate(Defeats[1], Defeats[1].transform.position, Quaternion.identity) as GameObject;
        	defd2.transform.SetParent(canv.transform, true);
        	defd2.transform.SetSiblingIndex(1);
        	defd3 = Instantiate(Defeats[2], Defeats[2].transform.position, Quaternion.identity) as GameObject;
        	defd3.transform.SetParent(canv.transform, true);
        	defd3.transform.SetSiblingIndex(2);
    		stopit = true;
        	}
        }
    }
}
