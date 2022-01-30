using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanting_scr1 : MonoBehaviour
{
	public GameObject nar1; //Снизу
	public GameObject nar2; //Слево
	public GameObject nar3; //Сверху
	public GameObject nar4; //Справо
	public GameObject md; //Медленно снизу
	public GameObject ml; //Медленно слево
	public GameObject mu; //Медленно сверху
	public GameObject mr; //Медленно справо
	public GameObject sml; //Слево (Очень медленно)
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
	public GameObject mar1; //Снизу влево (медленно)
	public GameObject mar2; //Снизу вверх (медленно)
	public GameObject mar3; //Снизу вправо (медленно)
	public GameObject mar4; //Слево вверх (медленно)
	public GameObject mar5; //Слево вправо (медленно)
	public GameObject mar6; //Слево вниз (медленно)
	public GameObject mar7; //Сверху вправо (медленно)
	public GameObject mar8; //Сверху вниз (медленно)
	public GameObject mar9; //Сверху влево (медленно)
	public GameObject mar10; //Справо вниз (медленно)
	public GameObject mar11; //Справо влево (медленно)
	public GameObject mar12; //Справо вверх (медленно)
	public GameObject ob1; //Обман слево
	public GameObject ob2; //Обман снизу
	public GameObject ob3; //Обман справо
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
    	Instantiate(md, new Vector3(ax, transform.position.y - 30f, 0f), d, gameObject.transform);
    	Instantiate(ml, new Vector3(transform.position.x - 40f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(mar7, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 52f, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 135f, 0);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 145f, 0f), d, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 150f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x + 155f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 160f, 0f), u, gameObject.transform);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 163f, 0);
    	Instantiate(nar4, new Vector3(transform.position.x + 170f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 171f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 172f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 173f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 174f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 178f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 180f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 182f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 184f, 0f), d, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 187f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 189f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 191f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 193, transform.position.y, 0);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 199f, 0f), d, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 201f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 203f, 0f), u, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 205f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 207f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 209f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 209f, transform.position.y, 0);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 213.5f, 0f), d, gameObject.transform);
    	Instantiate(sml, new Vector3(transform.position.x - 51.5f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 230f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 233f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 239f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 242f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 245f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 248f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 251f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 254f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 257f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 260f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 263f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 266f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 274f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 274.8f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 275.6f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 276.4f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 277.2f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 278f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 283.2f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 284f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 284.8f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 285.6f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 286.4f, 0f), u, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 287.2f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 292.4f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 293.2f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 294f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 294.8f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar4, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 295.6f, transform.position.y, 0);
    	Instantiate(nar2, new Vector3(transform.position.x - 297.3f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 299.8f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 301.2f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 302.6f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 304f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 305.4f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 306.8f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 308.2f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 309.6f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 311f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 312.4f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 313.8f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 315.2f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 316.6f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 318f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 319.4f, 0f), u, gameObject.transform);
    	Instantiate(nar2, new Vector3(transform.position.x - 320.8f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 321f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 322.6f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 324.2f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 325.8f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 327.4f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 329f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 330.6f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 332.2f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 333.8f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 335.4f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 337f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 338.6f, transform.position.y, 0);
    	Instantiate(ob2, new Vector3(ax, transform.position.y - 343f, 0f), d, gameObject.transform);
    	Instantiate(ob3, new Vector3(transform.position.x + 344.4f, ay, 0f), r, gameObject.transform);
    	Instantiate(mu, new Vector3(ax, transform.position.y + 152.8f, 0f), u, gameObject.transform);
    	Instantiate(md, new Vector3(ax, transform.position.y - 154.2f, 0f), d, gameObject.transform);
    	Instantiate(ml, new Vector3(transform.position.x - 155.6f, ay, 0f), l, gameObject.transform);
    	Instantiate(mr, new Vector3(transform.position.x + 157f, ay, 0f), r, gameObject.transform);
    	Instantiate(md, new Vector3(ax, transform.position.y - 158.4f, 0f), d, gameObject.transform);
    	Instantiate(mu, new Vector3(ax, transform.position.y + 159.8f, 0f), u, gameObject.transform);
    	Instantiate(mr, new Vector3(transform.position.x + 161.2f, ay, 0f), r, gameObject.transform);
    	Instantiate(mu, new Vector3(ax, transform.position.y + 162.6f, 0f), u, gameObject.transform);
    	Instantiate(md, new Vector3(ax, transform.position.y - 164f, 0f), d, gameObject.transform);
    	Instantiate(mu, new Vector3(ax, transform.position.y + 165.4f, 0f), u, gameObject.transform);
    	Instantiate(ml, new Vector3(transform.position.x - 166.8f, ay, 0f), l, gameObject.transform);
    	Instantiate(mr, new Vector3(transform.position.x + 168.2f, ay, 0f), r, gameObject.transform);
    	Instantiate(md, new Vector3(ax, transform.position.y - 169.6f, 0f), d, gameObject.transform);
    	Instantiate(ml, new Vector3(transform.position.x - 171f, ay, 0f), l, gameObject.transform);
    	Instantiate(mr, new Vector3(transform.position.x + 172.4f, ay, 0f), r, gameObject.transform);
    }
}
