using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class For_text_scr : MonoBehaviour
{
	private string[] texti =  new string[8];
	int num; //Случайная надпись
	public Text m_MyText;
    void Start()
    {
    	num = Random.Range(0, 8);
    }
    void Update(){
    	if(Language_Base.Eng == true){
    		texti[0] = "Complete at least\non easy";
    		texti[1] = "#First game";
    		texti[2] = "Good luck";
    		texti[3] = "By R-Stid";
   			texti[4] = "You can!";
    		texti[5] = "You will do this.";
    		texti[6] = "Don't be lazy!";
    		texti[7] = "It's easy...";
    	}
    	else{
    		texti[0] = "Пройди хотя бы \n на лёгком :)";
    		texti[1] = "#Первая игра";
    		texti[2] = "Удачи";
    		texti[3] = "От R-Stid";
   			texti[4] = "Ты сможешь!";
    		texti[5] = "У тебя получится.";
    		texti[6] = "Не ленись!";
    		texti[7] = "Это легко...";
    	}
    	if(num == 0){
    	m_MyText.text = texti[0];
    	}
    	else if(num == 1){
    	m_MyText.text = texti[1];
    	}
    	else if(num == 2){
    	m_MyText.text = texti[2];
    	}
    	else if(num == 3){
    	m_MyText.text = texti[3];
    	}
    	else if(num == 4){
    	m_MyText.text = texti[4];
    	}
    	else if(num == 5){
    	m_MyText.text = texti[5];
    	}
    	else if(num == 6){
    	m_MyText.text = texti[6];
    	}
    	else if(num == 7){
    	m_MyText.text = texti[7];
    	}
    }
}
