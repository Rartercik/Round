using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Smile_Text : MonoBehaviour
{
	private int rand; //Рандомный смайлик
	private Text MyText; //Текст
	private string eor; //Английский или русский
    void Start()
    {
    	MyText = GetComponent<Text>();
    	rand = Random.Range(0, 31);
    	if(Language_Base.Eng == true){
    		eor = "Game Over";
    	}
    	else{
    		eor = "Поражение";
    	}
    	if(rand == 0){
    		MyText.text = eor + " ;)";
    	}
    	else if(rand == 1){
    		MyText.text = eor + " :)";
    	}
    	else if(rand == 2){
    		MyText.text = eor + " :0";
    	}
    	else if(rand == 3){
    		MyText.text = eor + " =)";
    	}
    	else if(rand == 4){
    		MyText.text = eor + " =0";
    	}
    	else if(rand == 5){
    		MyText.text = eor + " :-)";
    	}
    	else if(rand == 6){
    		MyText.text = eor + " =_-";
    	}
    	else if(rand == 7){
    		MyText.text = eor + " -_-";
    	}
    	else if(rand == 8){
    		MyText.text = eor + " +_+";
    	}
    	else if(rand == 9){
    		MyText.text = eor + " :/";
    	}
    	else if(rand == 10){
    		MyText.text = eor + " -_+";
    	}
    	else if(rand == 11){
    		MyText.text = eor + " :3";
    	}
    	else if(rand == 12){
    		MyText.text = eor + " :|";
    	}
    	else if(rand == 13){
    		MyText.text = eor + " :\\";
    	}
    	else if(rand == 14){
    		MyText.text = eor + " >w<";
    	}
    	else if(rand == 15){
    		MyText.text = eor + " ^w^";
    	}
    	else if(rand == 16){
    		MyText.text = eor + " >_<";
    	}
    	else if(rand == 17){
    		MyText.text = eor + " :1";
    	}
    	else if(rand == 18){
    		MyText.text = eor + " ᵔᴥᵔ";
    	}
    	else if(rand == 19){
    		MyText.text = eor + " :D";
    	}
    	else if(rand == 20){
    		MyText.text = eor + " =D";
    	}
    	else if(rand == 21){
    		MyText.text = eor + " ._.";
    	}
    	else if(rand == 22){
    		MyText.text = eor + " *-*";
    	}
    	else if(rand == 23){
    		MyText.text = eor + " *_*";
    	}
    	else if(rand == 24){
    		MyText.text = eor + " o_o";
    	}
    	else if(rand == 25){
    		MyText.text = eor + " O_o";
    	}
    	else if(rand == 26){
    		MyText.text = eor + " o_O";
    	}
    	else if(rand == 27){
    		MyText.text = eor + " L:)";
    	}
    	else if(rand == 28){
    		MyText.text = eor + " G_G";
    	}
    	else if(rand == 29){
    		MyText.text = eor + " G-G";
    	}
    	else if(rand == 30){
    		MyText.text = @"¯\_(ツ)_/¯";
    	}
    }
}