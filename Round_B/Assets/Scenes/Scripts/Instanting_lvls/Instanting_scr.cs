using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanting_scr : MonoBehaviour
{
	public GameObject nar1; //Снизу
	public GameObject nar2; //Слево
	public GameObject nar3; //Сверху
	public GameObject nar4; //Справо
	public GameObject md; //Медленно снизу
	public GameObject ml; //Медленно слево
	public GameObject mu; //Медленно сверху
	public GameObject mr; //Медленно справо
	public GameObject ar1; //Снизу влево
	public GameObject ar2; //Снизу вверх
	public GameObject ar3; //Снизу вправо
	public GameObject ar4; //Слево вверх
	public GameObject ar5; //Слево вправо
	public GameObject ar6; //Слево вниз
	public GameObject ar7; //Сверху вправо
	public GameObject ar8; //Сверху вниз
	public GameObject ar9; //Сверху влево
	public GameObject ar10; //Справо вниз
	public GameObject ar11; //Справо влево
	public GameObject ar12; //Справо вверх
	public GameObject ob1; //Обман слево
	public GameObject ob2; //Обман снизу
	private float ax = -4.27f + 0.01333332f; //Выравниватель x
	private float ay = -5.84f + 0.01333332f; //Выравниватель y
	private GameObject forar;
	private Quaternion d; //Поворот стрелки снизу
	private Quaternion l; //Поворот стрелки слево
	private Quaternion u; //Поворот стрелки сверху
	private Quaternion r; //Поворот стрелки справо
    void Start()
    {
    	d = nar1.transform.rotation;
    	l = nar2.transform.rotation;
    	u = nar3.transform.rotation;
    	r = nar4.transform.rotation;
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 130f, 0f), d, gameObject.transform);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 131f, 0);
    	Instantiate(nar4, new Vector3(transform.position.x + 138.5f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x - 142.5f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 146.5f, 0);
    	Instantiate(nar4, new Vector3(transform.position.x - 154f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 156f, transform.position.y, 0);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 163f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 163.7f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 164.4f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 165.1f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 165.8f, 0f), u, gameObject.transform);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 166.6f, 0);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 170.9f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 171.6f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 172.3f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 173f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 173.7f, 0f), u, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 176f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 176.7f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 177.4f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 178.1f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 178.8f, ay, 0f), r, gameObject.transform);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 179.5f, transform.position.y, 0);
    	Instantiate(nar4, new Vector3(transform.position.x + 183.8f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 184.5f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 185.2f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 185.9f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 186.6f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 188.6f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 189.3f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 190f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 190.7f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 191.4f, ay, 0f), l, gameObject.transform);
    	Instantiate(ob1, new Vector3(transform.position.x - 192.1f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 194.9f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 195.6f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 196.3f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 197f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 197.7f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 199.1f, 0);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 200.9f, 0);
    	Instantiate(ob2, new Vector3(ax, transform.position.y - 204.5f, 0f), d, gameObject.transform);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 205.4f, 0);
    	Instantiate(ob2, new Vector3(ax, transform.position.y - 209.5f, 0f), d, gameObject.transform);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 211f, 0);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 212.5f, 0);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 219f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 219.8f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 220.5f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 221.2f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 221.9f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 222.6f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 223.3f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 224.1f, 0f), d, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 224.9f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 225.6f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 226.3f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 227f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 227.7f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 228.4f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 229.2f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 230f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 230.7f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 231.4f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 232.1f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 232.8f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 233.5f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 234.3f, 0f), d, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 235.1f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 235.8f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 236.5f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 237.2f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 237.9f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 238.6f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 236.5f, 0);
    	Instantiate(nar2, new Vector3(transform.position.x - 240.2f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 240.9f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 241.6f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 242.3f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 243f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 243.7f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 250f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 251f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 259f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 260f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 267f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 268f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 274f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 275f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 278f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 279.1f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 280.2f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 281.3f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 282.4f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 283.5f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 284.6f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 285.7f, ay, 0f), r, gameObject.transform);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 291f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 292.1f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 293.2f, 0);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 294.3f, transform.position.y, 0);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 303f, 0f), u, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x - 305f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 307f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 309f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 311f, 0f), u, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x - 313f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 315f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 317f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 319f, 0f), u, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x - 321f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 323f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 325f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 327f, 0f), u, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 327.9f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x - 328.9f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 335f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 337f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 339f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 341f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 343f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 345f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 347f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 349f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 351f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 353f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 355f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 357f, 0f), u, gameObject.transform);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 362f, transform.position.y, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 364.5f, transform.position.y, 0);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 367f, transform.position.y, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 369.5f, transform.position.y, 0);
    	Instantiate(ob1, new Vector3(transform.position.x - 375f, ay, 0f), l, gameObject.transform);
    	Instantiate(mr, new Vector3(transform.position.x + 174f, ay, 0f), r, gameObject.transform);//
    	Instantiate(mu, new Vector3(ax, transform.position.y + 175.2f, 0f), u, gameObject.transform);//
    	Instantiate(md, new Vector3(ax, transform.position.y - 176.4f, 0f), d, gameObject.transform);//
    	Instantiate(mr, new Vector3(transform.position.x + 177.6f, ay, 0f), r, gameObject.transform);//
    	Instantiate(ml, new Vector3(transform.position.x - 178.8f, ay, 0f), l, gameObject.transform);//
    	Instantiate(md, new Vector3(ax, transform.position.y - 180f, 0f), d, gameObject.transform);//
    	Instantiate(mu, new Vector3(ax, transform.position.y + 181.2f, 0f), u, gameObject.transform);//
    	Instantiate(md, new Vector3(ax, transform.position.y - 182.4f, 0f), d, gameObject.transform);//
    	Instantiate(ml, new Vector3(transform.position.x - 183.6f, ay, 0f), l, gameObject.transform);//
    	Instantiate(mr, new Vector3(transform.position.x + 184.8f, ay, 0f), r, gameObject.transform);//
    	Instantiate(mr, new Vector3(transform.position.x + 186f, ay, 0f), r, gameObject.transform);//
    	Instantiate(ml, new Vector3(transform.position.x - 187.2f, ay, 0f), l, gameObject.transform);//
    	Instantiate(mu, new Vector3(ax, transform.position.y + 188.4f, 0f), u, gameObject.transform);//
    	Instantiate(ml, new Vector3(transform.position.x - 189.6f, ay, 0f), l, gameObject.transform);//
    	Instantiate(md, new Vector3(ax, transform.position.y - 190.8f, 0f), d, gameObject.transform);//
    	Instantiate(ml, new Vector3(transform.position.x - 192f, ay, 0f), l, gameObject.transform);//
    	Instantiate(mr, new Vector3(transform.position.x + 193.2f, ay, 0f), r, gameObject.transform);//
    	Instantiate(mu, new Vector3(ax, transform.position.y + 194.4f, 0f), u, gameObject.transform);//
    	Instantiate(mr, new Vector3(transform.position.x + 195.6f, ay, 0f), r, gameObject.transform);//
    	Instantiate(md, new Vector3(ax, transform.position.y - 196.8f, 0f), d, gameObject.transform);//
    	Instantiate(ml, new Vector3(transform.position.x - 198f, ay, 0f), l, gameObject.transform);//
    	Instantiate(mu, new Vector3(ax, transform.position.y + 199.2f, 0f), u, gameObject.transform);//
    	Instantiate(mr, new Vector3(transform.position.x + 200.4f, ay, 0f), r, gameObject.transform);//
    	Instantiate(ml, new Vector3(transform.position.x - 201.6f, ay, 0f), l, gameObject.transform);//
    	Instantiate(md, new Vector3(ax, transform.position.y - 202.8f, 0f), d, gameObject.transform);//
    	Instantiate(mu, new Vector3(ax, transform.position.y + 204f, 0f), u, gameObject.transform);//
    }
}
