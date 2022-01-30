using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ToLvl : MonoBehaviour
{
	public Animator m_Animator; //Берём наш аниматор
	public Animator m_Animator2; //Ещё один закрыватель (для звёзд)
	public Button yourButton;
	public int scene_n; //Номер следующей комнаты
	private int whichs = 0; //В какую комнату идём
	private bool dark = true; //Можно ли переходить в другую комнату
	public Animator s_Animator; //Аниматор нарушения
    void Start()
    {
    	Button btn = yourButton.GetComponent<Button>();
		btn.onClick.AddListener(TaskOnClick);
    }
    void Update()
    {
        if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Darkness_anim")){
			if(whichs != 0){
    	SceneManager.LoadScene(whichs);
			}
    	}
    	if(m_Animator.GetCurrentAnimatorStateInfo(0).IsName("Toleft_anim")){
			if(whichs == 0){
				dark = false;
			}
    	}
    }
    void TaskOnClick()
    {
    	if(dark == true){
				if(scene_n != 0){
			if(scene_n == 1){
				whichs = 1;
			}
			else if(scene_n == 2){
				whichs = 2;
			}
			else if(scene_n == 3){
				whichs = 3;
			}
			m_Animator.SetBool("Button", true);
			m_Animator2.SetTrigger("Buton");
				}
				else{
					s_Animator.SetTrigger("nar");
				}
			}
    }
}
