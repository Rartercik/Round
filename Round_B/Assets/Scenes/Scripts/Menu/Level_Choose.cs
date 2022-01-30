using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Level_Choose : MonoBehaviour
{
	public Button yourButton;
	public bool lor; //Лево или право
	public Transform[] levels; //Уровни
	public Vector2 lstart;
    public Vector2 lend;
    public Vector2 lstart2;
    public Vector2 lend2;
    public Vector2 rstart;
    public Vector2 rend;
    public Vector2 rstart2;
    public Vector2 rend2;
    private float t = 1; //Прогресс
    public bool left = false; //Начало движения влево
    public bool right = false; //Начало движения вправо
    public Level_Choose another; //Другая кнопка
    public ParticleSystem ps;
    public Gradient[] grad;
    public Animator but; //Для проверки полноценного перехода анимации меню
    public Animator[] animators;
    void Start()
    {
        Button btn = yourButton.GetComponent<Button>();
        btn.onClick.AddListener(TaskOnClick);
        LV_BASE.l[0] = true;
    }
    void Update(){
    	var col = ps.colorBySpeed;
    	col.enabled = true;
    	/*if(left == true){
    		t += Time.deltaTime;
    		if(LV_BASE.l[0] == true){
    			col.color = grad[3];
    		levels[0].position = Vector2.Lerp(lstart, lend, t);
    		levels[5].position = Vector2.Lerp(lstart2, lend2, t);
    		if(t >= 1){
    			left = false;
    			LV_BASE.l[0] = false;
    			LV_BASE.l[5] = true;
    		}
    		}
    		else if(LV_BASE.l[5] == true){
    			col.color = grad[2];
    		levels[5].position = Vector2.Lerp(lstart, lend, t);
    		levels[4].position = Vector2.Lerp(lstart2, lend2, t);
    		if(t >= 1){
    			left = false;
    			LV_BASE.l[5] = false;
    			LV_BASE.l[4] = true;
    		}
    		}
    		else if(LV_BASE.l[4] == true){
    			col.color = grad[1];
    		levels[4].position = Vector2.Lerp(lstart, lend, t);
    		levels[3].position = Vector2.Lerp(lstart2, lend2, t);
    		if(t >= 1){
    			left = false;
    			LV_BASE.l[4] = false;
    			LV_BASE.l[3] = true;
    		}
    		}
    		else if(LV_BASE.l[3] == true){
    			col.color = grad[0];
    		levels[3].position = Vector2.Lerp(lstart, lend, t);
    		levels[2].position = Vector2.Lerp(lstart2, lend2, t);
    		if(t >= 1){
    			left = false;
    			LV_BASE.l[3] = false;
    			LV_BASE.l[2] = true;
    		}
    		}
    		else if(LV_BASE.l[2] == true){
    			col.color = grad[0];
    		levels[2].position = Vector2.Lerp(lstart, lend, t);
    		levels[1].position = Vector2.Lerp(lstart2, lend2, t);
    		if(t >= 1){
    			left = false;
    			LV_BASE.l[2] = false;
    			LV_BASE.l[1] = true;
    		}
    		}
    		else if(LV_BASE.l[1] == true){
    			col.color = grad[0];
    		levels[1].position = Vector2.Lerp(lstart, lend, t);
    		levels[0].position = Vector2.Lerp(lstart2, lend2, t);
    		if(t >= 1){
    			left = false;
    			LV_BASE.l[1] = false;
    			LV_BASE.l[0] = true;
    		}
    		}
    	}
    	else if(right == true){
    		t += Time.deltaTime;
    		if(LV_BASE.l[0] == true){
    			col.color = grad[0];
    		levels[0].position = Vector2.Lerp(rstart, rend, t);
    		levels[1].position = Vector2.Lerp(rstart2, rend2, t);
    		if(t >= 1){
    			right = false;
    			LV_BASE.l[0] = false;
    			LV_BASE.l[1] = true;
    		}
    		}
    		else if(LV_BASE.l[1] == true){
    			col.color = grad[0];
    		levels[1].position = Vector2.Lerp(rstart, rend, t);
    		levels[2].position = Vector2.Lerp(rstart2, rend2, t);
    		if(t >= 1){
    			right = false;
    			LV_BASE.l[1] = false;
    			LV_BASE.l[2] = true;
    		}
    		}
    		else if(LV_BASE.l[2] == true){
    			col.color = grad[1];
    		levels[2].position = Vector2.Lerp(rstart, rend, t);
    		levels[3].position = Vector2.Lerp(rstart2, rend2, t);
    		if(t >= 1){
    			right = false;
    			LV_BASE.l[2] = false;
    			LV_BASE.l[3] = true;
    		}
    		}
    		else if(LV_BASE.l[3] == true){
    			col.color = grad[2];
    		levels[3].position = Vector2.Lerp(rstart, rend, t);
    		levels[4].position = Vector2.Lerp(rstart2, rend2, t);
    		if(t >= 1){
    			right = false;
    			LV_BASE.l[3] = false;
    			LV_BASE.l[4] = true;
    		}
    		}
    		else if(LV_BASE.l[4] == true){
    			col.color = grad[3];
    		levels[4].position = Vector2.Lerp(rstart, rend, t);
    		levels[5].position = Vector2.Lerp(rstart2, rend2, t);
    		if(t >= 1){
    			right = false;
    			LV_BASE.l[4] = false;
    			LV_BASE.l[5] = true;
    		}
    		}
    		else if(LV_BASE.l[5] == true){
    			col.color = grad[0];
    		levels[5].position = Vector2.Lerp(rstart, rend, t);
    		levels[0].position = Vector2.Lerp(rstart2, rend2, t);
    		if(t >= 1){
    			right = false;
    			LV_BASE.l[5] = false;
    			LV_BASE.l[0] = true;
    		}
    		}
    }*/
    	if(left == true){
    		if(LV_BASE.l[0] == true){
    			col.color = grad[3];
    			animators[0].SetTrigger("leaveright");
    			animators[5].SetTrigger("comeleft");
    		if(animators[5].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			left = false;
    			animators[0].ResetTrigger("leaveright");
    			animators[5].ResetTrigger("comeleft");
    			LV_BASE.l[0] = false;
    			LV_BASE.l[5] = true;
    		}
    		}
    		else if(LV_BASE.l[5] == true){
    			col.color = grad[2];
    		animators[5].SetTrigger("leaveright");
    		animators[4].SetTrigger("comeleft");
    		if(animators[4].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			left = false;
    			animators[5].ResetTrigger("leaveright");
    			animators[4].ResetTrigger("comeleft");
    			LV_BASE.l[5] = false;
    			LV_BASE.l[4] = true;
    		}
    		}
    		else if(LV_BASE.l[4] == true){
    			col.color = grad[1];
    		animators[4].SetTrigger("leaveright");
    		animators[3].SetTrigger("comeleft");
    		if(animators[3].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			left = false;
    			animators[4].ResetTrigger("leaveright");
    			animators[3].ResetTrigger("comeleft");
    			LV_BASE.l[4] = false;
    			LV_BASE.l[3] = true;
    		}
    		}
    		else if(LV_BASE.l[3] == true){
    			col.color = grad[0];
    		animators[3].SetTrigger("leaveright");
    		animators[2].SetTrigger("comeleft");
    		if(animators[2].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			left = false;
    			animators[3].ResetTrigger("leaveright");
    			animators[2].ResetTrigger("comeleft");
    			LV_BASE.l[3] = false;
    			LV_BASE.l[2] = true;
    		}
    		}
    		else if(LV_BASE.l[2] == true){
    			col.color = grad[0];
    		animators[2].SetTrigger("leaveright");
    		animators[1].SetTrigger("comeleft");
    		if(animators[1].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			left = false;
    			animators[2].ResetTrigger("leaveright");
    			animators[1].ResetTrigger("comeleft");
    			LV_BASE.l[2] = false;
    			LV_BASE.l[1] = true;
    		}
    		}
    		else if(LV_BASE.l[1] == true){
    			col.color = grad[0];
    		animators[1].SetTrigger("leaveright");
    		animators[0].SetTrigger("comeleft");
    		if(animators[0].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			left = false;
    			animators[1].ResetTrigger("leaveright");
    			animators[0].ResetTrigger("comeleft");
    			LV_BASE.l[1] = false;
    			LV_BASE.l[0] = true;
    		}
    		}
    	}
    	else if(right == true){
    		if(LV_BASE.l[0] == true){
    			col.color = grad[0];
    		animators[0].SetTrigger("leaveleft");
    		animators[1].SetTrigger("comeright");
    		if(animators[1].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			right = false;
    			animators[0].ResetTrigger("leaveleft");
    			animators[1].ResetTrigger("comeright");
    			LV_BASE.l[0] = false;
    			LV_BASE.l[1] = true;
    		}
    		}
    		else if(LV_BASE.l[1] == true){
    			col.color = grad[0];
    		animators[1].SetTrigger("leaveleft");
    		animators[2].SetTrigger("comeright");
    		if(animators[2].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			right = false;
    			animators[1].ResetTrigger("leaveleft");
    			animators[2].ResetTrigger("comeright");
    			LV_BASE.l[1] = false;
    			LV_BASE.l[2] = true;
    		}
    		}
    		else if(LV_BASE.l[2] == true){
    			col.color = grad[1];
    		animators[2].SetTrigger("leaveleft");
    		animators[3].SetTrigger("comeright");
    		if(animators[3].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			right = false;
    			animators[2].ResetTrigger("leaveleft");
    			animators[3].ResetTrigger("comeright");
    			LV_BASE.l[2] = false;
    			LV_BASE.l[3] = true;
    		}
    		}
    		else if(LV_BASE.l[3] == true){
    			col.color = grad[2];
    		animators[3].SetTrigger("leaveleft");
    		animators[4].SetTrigger("comeright");
    		if(animators[4].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			right = false;
    			animators[3].ResetTrigger("leaveleft");
    			animators[4].ResetTrigger("comeright");
    			LV_BASE.l[3] = false;
    			LV_BASE.l[4] = true;
    		}
    		}
    		else if(LV_BASE.l[4] == true){
    			col.color = grad[3];
    		animators[4].SetTrigger("leaveleft");
    		animators[5].SetTrigger("comeright");
    		if(animators[5].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			right = false;
    			animators[4].ResetTrigger("leaveleft");
    			animators[5].ResetTrigger("comeright");
    			LV_BASE.l[4] = false;
    			LV_BASE.l[5] = true;
    		}
    		}
    		else if(LV_BASE.l[5] == true){
    			col.color = grad[0];
    		animators[5].SetTrigger("leaveleft");
    		animators[0].SetTrigger("comeright");
    		if(animators[0].GetCurrentAnimatorStateInfo(0).IsName("Stand")){
    			right = false;
    			animators[5].ResetTrigger("leaveleft");
    			animators[0].ResetTrigger("comeright");
    			LV_BASE.l[5] = false;
    			LV_BASE.l[0] = true;
    		}
    		}
    }
    }
    void TaskOnClick(){
    	/*if(another.right == false && another.left == false){
    	if(t >= 1){
    		t = 0;
    		if(lor == true){
    			left = true;
    		}
    		else if(lor == false){
    			right = true;
    		}
    	}
    	}*/
    	if(another.right == false && another.left == false){
    	if(lor == true){
    			left = true;
    		}
    		else if(lor == false){
    			right = true;
    		}
    	}
    }
}