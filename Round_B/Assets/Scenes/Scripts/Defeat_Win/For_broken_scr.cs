using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class For_broken_scr : MonoBehaviour
{
    private float sch = 1f; //Через сколько меняет спрайт
    private float sch2 = 1f; //Через сколько уничтожается
    private SpriteRenderer spriteRenderer; //Берём SpriteRenderer как переменную
    public Sprite sprite; //Новый спрайт
    Animator m_Animator; //Берём наш аниматор
    public GameObject[] hearts;
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        m_Animator = GetComponent<Animator>(); //Присваеваем значение аниматору
    }
    void Update()
    {
        if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("untwitching_anim")){
    		if(sch>0)
    			sch -= Time.deltaTime;
    	else
    		spriteRenderer.sprite = sprite;
    	}
    	if(sch <= 0){
    		if(sch2>0){
    			sch2 -= Time.deltaTime;
    		}
    		else{
    			Instantiate(hearts[0], hearts[0].transform.position, Quaternion.identity);
    			Instantiate(hearts[1], hearts[1].transform.position, Quaternion.identity);
    			Instantiate(hearts[2], hearts[2].transform.position, Quaternion.identity);
    			Instantiate(hearts[3], hearts[3].transform.position, Quaternion.identity);
    			gameObject.SetActive(false);
    		}
    	}
    }
}
