using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yarrow_scr : MonoBehaviour
{
    public Vector2 diraction; //Направление стрелки
    public Vector2 diraction2; //Новое направление стрелки
	private Transform _cash; //Кэшируем положение стрелы
	public GameObject shieldd; //Можно сталкиваться с щитом
	private Transform _cash2; //Кэшируем положение вращателя
	public GameObject rotator; //Вокруг кого крутится
	private bool ifwas = false;
	Animator m_Animator; //Берём наш аниматор
	public float isrot; //Число настоящего поворота
	public string stor; //Сторона поворота
	public string nestor1; //Не сторона поворота1
	public string nestor2; //Не сторона поворота2
	public string nestor3; //Не сторона поворота3
	public bool inl; //Если слева
	public bool ind; //Если снизу
	public bool inr; //Если справо
	public bool inu; //Если сверху
	private float somez; //Куда летит
	private string somenaz; //Куда поворачивает
	public float spd; //С какой скоростью повернёт
	public float rasst; //Где повернёт
    void Start()
    {
    	shieldd = GameObject.Find("shield_obj");
        _cash = transform;
        _cash2 = rotator.transform;
        m_Animator = rotator.GetComponent<Animator>(); //Присваеваем значение аниматору
        m_Animator.SetFloat("animSpeed", spd);
        if(stor == "Up"){
        	somenaz = "idle_up_anim";
        }
        else if(stor == "down"){
        	somenaz = "idle_down_anime";
        }
        else if(stor == "left"){
        	somenaz = "idle_left_anim";
        }
        else if(stor == "right"){
        	somenaz = "idle_right_anim";
        }
    }
    void FixedUpdate()
    {
    	Quaternion nowrot = Quaternion.AngleAxis(isrot, new Vector3(0, 0, 1)); //Настоящий поворот
    	_cash.rotation = nowrot;
    	if(ind == true)
    		somez = _cash2.position.y - _cash.position.y;
    	else if(inl == true)
    		somez = _cash2.position.x - _cash.position.x;
    	else if(inu == true)
    		somez = _cash.position.y - _cash2.position.y;
    	else if(inr == true)
    		somez = _cash.position.x - _cash2.position.x;
    	if(somez > rasst){
    	_cash.Translate(diraction*Time.deltaTime);
    	}
    	else{
    		if(ifwas==false){
    		m_Animator.SetBool(stor, true);
    		m_Animator.SetBool(nestor1, false);
    		m_Animator.SetBool(nestor2, false);
    		m_Animator.SetBool(nestor3, false);
    		ifwas = true;
    		}
    		else{
    			if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName(somenaz)){
    				_cash.Translate(diraction2*Time.deltaTime);
    			}
    		}
    	}
    	_cash.rotation = nowrot;
    }
    void OnCollisionEnter2D(Collision2D other){
    	if(other.gameObject == shieldd){
    	rotator.SetActive(false);
    	gameObject.SetActive(false);
    	}
    }
}
