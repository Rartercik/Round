using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class for_purple_scr : MonoBehaviour
{
	public Vector2 diraction; //Направление стрелки
	public Vector2 diraction2; //Направление стрелки справо
	public Vector2 diraction3; //Направление стрелки снизу
	public Vector2 diraction4; //Направление стрелки слево
	public Vector2 diraction5; //Направление стрелки сверху
	private Transform _cash; //Кэшируем положение стрелы
	SpriteRenderer spr;
	public GameObject shieldd; //Можно сталкиваться с щитом
	public bool firsttime = true; //Ещё не стлкивался
	public bool back = false; //Можно ли возвращаться?
	private bool inl = false; //Если слева
	private bool ind = false; //Если снизу
	private bool inr = true; //Если справо
	private bool inu = false; //Если сверху
	public GameObject rotator; //Вокруг кого крутится
	Animator r_Animator; //Берём аниматор вращателя
	private Transform _cash2; //Кэшируем положение вращателя
	private Quaternion isrot = Quaternion.AngleAxis(90f, new Vector3(0, 0, 1)); //Начало поворота
	private float isrot2 = 90f; //Конец поворота
	private float somez; //Куда летит
	private string somenaz = "idle_in_right"; //Куда поворачивает
	private string stor = "right"; //Сторона поворота
	private string nestor1 = "Up"; //Не сторона поворота1
	private string nestor2 = "left"; //Не сторона поворота2
	private string nestor3 = "down"; //Не сторона поворота3
	private int sluch; //Случайное число для выбора поворота
	public float spd; //С какой скоростью повернёт
	public float rasst; //Где повернёт
	private Vector2 somechislo; //Куда летит
	public Rigidbody2D rb;
	private float timeCount = 0; //За сколько повернётся
	public GameObject heart; //Столкновение с сердцем
	private int times = 27; //Сколько раз удаляется
	private bool now = false; //Вверх или вниз?
	public Vanising_scr script; //Фиолетовое дошло 1
	public Vanising_scr script1; //Фиолетовое дошло 1
	public Vanising_scr script2; //Фиолетовое дошло 1
	public Vanising_scr script3; //Фиолетовое дошло 1
	public Vanising_scr script4; //Фиолетовое дошло 1
	public Vanising_scr script5; //Фиолетовое дошло 1
	public Vanising_scr script6; //Фиолетовое дошло 1
	public Vanising_scr script7; //Фиолетовое дошло 1
	public Vanising_scr script8; //Фиолетовое дошло 2
	public Vanising_scr script9; //Фиолетовое дошло 2
	public Vanising_scr script10; //Фиолетовое дошло 2
	public Vanising_scr script11; //Фиолетовое дошло 2
	public Vanising_scr script12; //Фиолетовое дошло 2
	private float tt = 0;
	public Sprite nsprite; //Сломанная стрелка
	public GameObject[] purples; //Сломанные части
	private float heh = 2;
	public for_trueheart_scr scr;
    void Start()
    {
        _cash = transform;
        _cash2 = rotator.transform;
        spr = GetComponent<SpriteRenderer>();
        r_Animator = rotator.GetComponent<Animator>(); //Присваеваем значение чужому аниматору
        r_Animator.SetFloat("animSpeed", spd);
        rb = GetComponent<Rigidbody2D>();
    }
    void Update(){
    	if(_cash.position.x - _cash2.position.x <= 20){
    		script.v1 = true;
    		script1.v1 = true;
    		script2.v1 = true;
    		script3.v1 = true;
    		script4.v1 = true;
    		script5.v1 = true;
    		script6.v1 = true;
    		script7.v1 = true;
    		scr.uh = true;
    	}
    	if(spr.sprite == nsprite){
    			if(heh > 0){
    				heh -= Time.deltaTime;
    			}
    			else{
    			Instantiate(purples[0], new Vector2(_cash.position.x - 0.3f, transform.position.y + 0.3f), Quaternion.identity);
    			Instantiate(purples[1], new Vector2(_cash.position.x - 0.3f, transform.position.y - 0.3f), Quaternion.identity);
    			Instantiate(purples[2], new Vector2(_cash.position.x, transform.position.y + 0.3f), Quaternion.identity);
    			Instantiate(purples[3], new Vector2(_cash.position.x, transform.position.y - 0.3f), Quaternion.identity);
    			Instantiate(purples[4], new Vector2(_cash.position.x + 0.3f, transform.position.y + 0.3f), Quaternion.identity);
    			Instantiate(purples[5], new Vector2(_cash.position.x + 0.3f, transform.position.y - 0.3f), Quaternion.identity);
    			heart.SetActive(false);
    			gameObject.SetActive(false);
    			}
    		}
    }
    void FixedUpdate()
    {
    	Quaternion torot = Quaternion.AngleAxis(isrot2, new Vector3(0, 0, 1)); //Конечный поворот
    	if(ind == true){
    		somechislo = diraction3.normalized * diraction3[1];
    		somez = _cash2.position.y - rasst;
    	}
    	else if(inl == true){
    		somechislo = diraction4.normalized * diraction4[0];
    		somez = _cash2.position.x - rasst;
    	}
    	else if(inu == true){
    		somechislo = diraction5.normalized * -diraction5[1];
    		somez = _cash2.position.y + rasst;
    	}
    	else if(inr == true){
    		somechislo = diraction2.normalized * -diraction2[0];
    		somez = _cash2.position.x + rasst;
    	}
    	if(times > 0){
    	if(firsttime == true){
    	_cash.Translate(diraction*Time.deltaTime);
    	}
    	else if(back == true){
    			if(isrot != torot){
    		_cash.rotation = Quaternion.Slerp(isrot, torot, timeCount);
    		timeCount += 0.1f;
    			}
    		if(inr == true){
    			if(_cash.position.x < somez){
    				_cash.Translate(Vector2.right.normalized*0.4f, Space.World);
    			}
    			else{
    				back = false;
    			}
    		}
    		else if(ind == true){
    			if(_cash.position.y > somez){
    				_cash.Translate(Vector2.down.normalized*0.4f, Space.World);
    			}
    			else{
    				back = false;
    			}
    		}
    		else if(inl == true){
    			if(_cash.position.x > somez){
    				_cash.Translate(Vector2.left.normalized*0.4f, Space.World);
    			}
    			else{
    				back = false;
    			}
    		}
    		else if(inu == true){
    			if(_cash.position.y < somez){
    				_cash.Translate(Vector2.up.normalized*0.4f, Space.World);
    			}
    			else{
    				back = false;
    			}
    		}
    	}
    	if(firsttime == false && back == false){
    		_cash.rotation = torot;
    		r_Animator.SetBool(stor, true);
    		r_Animator.SetBool(nestor1, false);
    		r_Animator.SetBool(nestor2, false);
    		r_Animator.SetBool(nestor3, false);
    		if(r_Animator.GetCurrentAnimatorStateInfo(0).IsName(somenaz)){
    			if(stor == "Up"){
    				inu = true;
    				ind = false;
    				inr = false;
    				inl = false;
    				_cash.position = new Vector3(-4.27f, _cash.position.y, 0f);
    			}
    			else if(stor == "down"){
    				ind = true;
    				inu = false;
    				inr = false;
    				inl = false;
    				_cash.position = new Vector3(-4.27f, _cash.position.y, 0f);
    			}
    			else if(stor == "left"){
    				inl = true;
    				inu = false;
    				inr = false;
    				ind = false;
    				_cash.position = new Vector3(_cash.position.x, -5.84f, 0f);
    			}
    			else if(stor == "right"){
    				inr = true;
    				inu = false;
    				ind = false;
    				inl = false;
    				_cash.position = new Vector3(_cash.position.x, -5.84f, 0f);
    			}
    				rb.velocity = (somechislo);
    			}
    	}
    	}
    	else{
    		script8.v2 = true;
    		script9.v2 = true;
    		script10.v3 = true;
    		script11.v3 = true;
    		script12.v4 = true;
    		if(_cash.position.x < 1.2f){
    			_cash.Translate(new Vector2(1, 0).normalized * 0.05f, Space.World);
    			if(_cash.position.y > -5.99f && now == false){
    					_cash.Translate(new Vector2(0, -0.05f), Space.World);
    			}
    					else if (_cash.position.y < -5.69f){
    					now = true;
    					_cash.Translate(new Vector2(0, 0.05f), Space.World);
    				}
    			else{
    				now = false;
    			}
    		}
    		else{
    			if(tt < 0.9f){
    				tt += 0.01f;
    			}
    			else{
    				spr.sprite = nsprite;
    			}
    		}
    	}
    }
    void OnCollisionEnter2D(Collision2D other){
    	if(other.gameObject == shieldd){
    		rb.velocity = Vector2.zero;
    		if(times > 2)
    	sluch = Random.Range(0, 12);
    		else
    			sluch = 1;
    		if(r_Animator.GetCurrentAnimatorStateInfo(0).IsName("idle_down_anime"))
    		isrot = Quaternion.AngleAxis(0, new Vector3(0, 0, 1));
    		else if(r_Animator.GetCurrentAnimatorStateInfo(0).IsName("idle_in_right"))
    		isrot = Quaternion.AngleAxis(90, new Vector3(0, 0, 1));
    		else if(r_Animator.GetCurrentAnimatorStateInfo(0).IsName("idle_up_anim"))
    		isrot = Quaternion.AngleAxis(180, new Vector3(0, 0, 1));
    		else if(r_Animator.GetCurrentAnimatorStateInfo(0).IsName("idle_left_anim"))
    		isrot = Quaternion.AngleAxis(-90, new Vector3(0, 0, 1));
    	if(sluch == 0 || sluch == 4 || sluch == 8){
    		stor = "Up";
    		nestor1 = "right";
    		nestor2 = "down";
    		nestor3 = "left";
    		somenaz = "idle_up_anim";
    		isrot2 = 180f;
    	}
    	else if(sluch == 1 || sluch == 5 || sluch == 9){
    		stor = "right";
    		nestor1 = "Up";
    		nestor2 = "down";
    		nestor3 = "left";
    		somenaz = "idle_in_right";
    		isrot = _cash.rotation;
    		isrot2 = 90f;
    	}
    	else if(sluch == 2 || sluch == 6 || sluch == 10){
    		stor = "down";
    		nestor1 = "right";
    		nestor2 = "Up";
    		nestor3 = "left";
    		somenaz = "idle_down_anime";
    		isrot = _cash.rotation;
    		isrot2 = 0f;
    	}
    	else if(sluch == 3 || sluch == 7 || sluch == 11){
    		stor = "left";
    		nestor1 = "right";
    		nestor2 = "down";
    		nestor3 = "Up";
    		somenaz = "idle_left_anim";
    		isrot = _cash.rotation;
    		isrot2 = -90f;
    	}
    	timeCount = 0f;
    	firsttime = false;
    	back = true;
    	times--;
    	}
    }
}
