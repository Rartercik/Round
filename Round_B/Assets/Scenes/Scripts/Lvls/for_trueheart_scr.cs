using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class for_trueheart_scr : MonoBehaviour
{
	public GameObject shieldt; //Щит нельзя удалять
	public AudioClip clip; //Звук столкновения
	public AudioSource[] _cash; //Кэшируем аудио
	SpriteRenderer spr; //Для прозрачности
	private bool stolk = false; //Проверка на столкновение
	private float skolk = 2; //Время другого спрайта
	public GameObject hpb; //Хелсбар и рамка
	public Image bar; //Хелсбар
	private int hp = 10;
	public Text hp_txt;
	private bool delayy = false; //Задержка уничтожения
	public GameObject nheart;
	public GameObject purple;
	public for_purple_scr script; //Фиолетовое нельзя уничтожить
	public bool uh = false; //Для замедления музыки
	private float uht = 2.5f; //Для замедления музыки
	public AudioClip clip2; //Музыка
	public Animator animator; //Аниматор для поворота щита
	public Last_Ease2 a; //Столкновение на Ease2
	public GameObject Sil;
    void Start()
    {
        //_cash = GetComponent<AudioSource>();
        spr = GetComponent<SpriteRenderer>(); //Изменение переменной прозрачности
        if(GameObject.Find("osrot") != null){
        script = purple.GetComponent<for_purple_scr>();
        }
    }
    public void RotateShield(string norm, string nenorm1, string nenorm2, string nenorm3){
    		animator.SetBool(norm, true);
    		animator.SetBool(nenorm1, false);
    		animator.SetBool(nenorm2, false);
    		animator.SetBool(nenorm3, false);
    }
    void Update()
    {
    	//Поворот щита:
    	if (Input.GetKeyDown(KeyCode.W))
        {
    		RotateShield("Up", "down", "left", "right");
        }
    	else if (Input.GetKeyDown(KeyCode.D))
        {
    		RotateShield("right", "down", "left", "Up");
        }
    	else if (Input.GetKeyDown(KeyCode.S))
        {
    		RotateShield("down", "Up", "left", "right");
        }
    	else if (Input.GetKeyDown(KeyCode.A))
        {
    		RotateShield("left", "down", "Up", "right");
        }
    	
    	if(uh == true){
    		if(uht > 0){
    			_cash[1].pitch = uht;
    			uht -= 0.005f;
    		}
    	}
    	if(hp<=0){
    		if(delayy == true){
    		hp = 0;
    		Destroy(hp_txt);
    		hpb.SetActive(false);
    		Instantiate(nheart, nheart.transform.position, Quaternion.identity);
    		gameObject.SetActive(false);
    		}
    		else{
    			delayy = true;
    			hp = 0;
    		}
    	}
    	hp_txt.text = "HP:" + hp.ToString();
        if(stolk == true){
			if(skolk<=0){
		spr.color = new Color(1, 1, 1, 1); //Онулирование прозрачности
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
    void OnTriggerEnter2D(Collider2D other){
    	if(other.gameObject != shieldt && other.gameObject != purple && other.tag != "Finish" && other.tag != "Ease2"){
    		_cash[0].PlayOneShot(clip); //Звук столкновения
    	spr.color = new Color(1, 1, 1, 0); //Онулирование прозрачности
    	stolk = true;
    	hp--;
    	bar.fillAmount-=0.1f;
        Destroy(other.gameObject);
    	}
    	else if(other.gameObject == purple){
    		_cash[0].pitch = 0.5f;
    		_cash[0].PlayOneShot(clip); //Звук столкновения
    		hp -= 5;
    		script.firsttime = false;
    		script.back = true;
    		script.rb.velocity = Vector2.zero;
    		bar.fillAmount-=0.5f;
    	}
    	else if(other.tag == "Finish"){
    		_cash[0].PlayOneShot(clip); //Звук столкновения
    		hp -= 10;
    		bar.fillAmount-=1f;
    		Sil.SetActive(true);;
    	}
    	else if(other.tag == "Ease2"){
    		_cash[0].PlayOneShot(clip); //Звук столкновения
    		hp -= 1;
    		bar.fillAmount-=0.1f;
    		a.oh = true;
    		a.rb.velocity = a.othod;
    		a.aud.volume = 0;
    	}
    }
}
