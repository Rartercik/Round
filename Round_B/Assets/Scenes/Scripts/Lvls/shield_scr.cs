using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shield_scr : MonoBehaviour
{
	public AudioClip clip; //Звук столкновения
	public Sprite sprite1;
	public Sprite sprite2;
	private SpriteRenderer spriteRenderer; //Берём SpriteRenderer как переменную
	private bool stolk = false; //Проверка на столкновение
	private float skolk = 2; //Время другого спрайта
	private AudioSource _cash; //Кэшируем аудио
	public GameObject purple;
	void Start(){
		spriteRenderer = GetComponent<SpriteRenderer>();
		_cash = GetComponent<AudioSource>();
	}
    void OnCollisionEnter2D(Collision2D collision){
		if(collision.gameObject != purple){
		_cash.PlayOneShot(clip);
		}
		else{
			_cash.pitch = 0.8f;
			_cash.PlayOneShot(clip);
		}
    	spriteRenderer.sprite = sprite2;
    	stolk = true;
    }
	void Update(){
		if(stolk == true){
			if(skolk<=0){
		spriteRenderer.sprite = sprite1;
		stolk = false;
			}
			else{
				skolk--;
			}
		}
			else{
				skolk = 2;
			}
	}
}