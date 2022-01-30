using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instanting_scr2 : MonoBehaviour
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
    	forar = Instantiate(mar4, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 20f, transform.position.y, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 50f, transform.position.y, 0);
    	forar = Instantiate(ar9, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 65f, 0);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 75f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 82f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 87f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 91f, 0);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 95f, transform.position.y, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 99f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 103f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 108f, 0);
    	Instantiate(nar2, new Vector3(transform.position.x - 112f, ay, 0f), l, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 116f, 0f), d, gameObject.transform);
    	Instantiate(nar4, new Vector3(transform.position.x + 120f, ay, 0f), r, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 124f, 0f), u, gameObject.transform);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 128f, transform.position.y, 0);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 132f, transform.position.y, 0);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 136f, 0);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 140f, 0);
    	forar = Instantiate(ar9, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 144f, 0);
    	forar = Instantiate(ar7, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 148f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 153f, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 156f, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 159f, transform.position.y, 0);
    	forar = Instantiate(ar12, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 162f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 165f, transform.position.y, 0);
    	forar = Instantiate(ar4, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 168f, transform.position.y, 0);
    	forar = Instantiate(ar12, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 175f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 176f, 0);
    	forar = Instantiate(ar4, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 178.2f, transform.position.y, 0);
    	forar = Instantiate(ar7, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 183.2f, 0);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 183.4f, transform.position.y, 0);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 185.6f, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 190.6f, transform.position.y, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 190.8f, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 193f, transform.position.y, 0);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 198f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 198.2f, transform.position.y, 0);
    	forar = Instantiate(ar9, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 200.4f, 0);
    	Instantiate(ml, new Vector3(transform.position.x - 100f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 208f, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 212f, transform.position.y, 0);
    	forar = Instantiate(ar12, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 216f, transform.position.y, 0);
    	forar = Instantiate(ar7, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 220f, 0);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 223f, 0f), d, gameObject.transform);
    	Instantiate(mr, new Vector3(transform.position.x + 110f, ay, 0f), r, gameObject.transform);
    	forar = Instantiate(ar9, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 232f, 0);
    	forar = Instantiate(ar4, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 236f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 240f, transform.position.y, 0);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 244f, 0);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 247f, 0f), u, gameObject.transform);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 254f, 0);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 257f, transform.position.y, 0);
    	forar = Instantiate(ar12, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 260f, transform.position.y, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 263f, 0);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 266f, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 269f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 272f, 0);
    	forar = Instantiate(ar9, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 275f, 0);
    	forar = Instantiate(ar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 278f, transform.position.y, 0);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 282f, 0f), d, gameObject.transform);
    	Instantiate(nar3, new Vector3(ax, transform.position.y + 284.5f, 0f), u, gameObject.transform);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 292f, transform.position.y, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 294.5f, transform.position.y, 0);
    	forar = Instantiate(ar12, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 297f, transform.position.y, 0);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 299.5f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 302f, 0);
    	Instantiate(nar2, new Vector3(transform.position.x - 306f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar12, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 307f, transform.position.y, 0);
    	Instantiate(nar4, new Vector3(transform.position.x + 311f, ay, 0f), r, gameObject.transform);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 312f, 0);
    	forar = Instantiate(ar11, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 315.5f, transform.position.y, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 318f, 0);
    	forar = Instantiate(ar7, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 320.5f, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 323f, transform.position.y, 0);
    	forar = Instantiate(ar9, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 325.5f, 0);
    	forar = Instantiate(ar12, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 328f, transform.position.y, 0);
    	forar = Instantiate(mar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 151f, 0);
    	forar = Instantiate(mar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 152.4f, 0);
    	forar = Instantiate(mar4, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 153.8f, transform.position.y, 0);
    	forar = Instantiate(mar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 155.2f, 0);
    	Instantiate(mr, new Vector3(transform.position.x + 157.6f, ay, 0f), r, gameObject.transform);
    	forar = Instantiate(mar5, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 158f, transform.position.y, 0);
    	forar = Instantiate(mar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 159.4f, transform.position.y, 0);
    	forar = Instantiate(mar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 160.8f, transform.position.y, 0);
    	forar = Instantiate(mar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 162.2f, 0);
    	Instantiate(ml, new Vector3(transform.position.x - 162.6f, ay, 0f), l, gameObject.transform);
    	Instantiate(mr, new Vector3(transform.position.x + 163.8f, ay, 0f), r, gameObject.transform);
    	Instantiate(ml, new Vector3(transform.position.x - 165f, ay, 0f), l, gameObject.transform);
    	Instantiate(mr, new Vector3(transform.position.x + 166.2f, ay, 0f), r, gameObject.transform);
    	Instantiate(md, new Vector3(ax, transform.position.y - 167.4f, 0f), d, gameObject.transform);
    	Instantiate(mu, new Vector3(ax, transform.position.y + 168.6f, 0f), u, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 397f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 401f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 404f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 407f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 413f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 416f, 0f), d, gameObject.transform);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 425f, 0f), d, gameObject.transform);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 399f, transform.position.y, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 401f, transform.position.y, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 405f, transform.position.y, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 409f, transform.position.y, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 411f, transform.position.y, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 413f, transform.position.y, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 417f, transform.position.y, 0);
    	forar = Instantiate(ar10, new Vector3(transform.position.x, ay, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x + 419f, transform.position.y, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 400f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 403f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 406f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 408f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 409f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 415f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 417f, 0);
    	forar = Instantiate(ar8, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y + 420f, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 399.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 402.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 403.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 406.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 407.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 411.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 414.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 415.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 418.5f, transform.position.y, 0);
    	forar = Instantiate(ar6, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x - 422.1f, transform.position.y, 0);
    	Instantiate(nar2, new Vector3(transform.position.x - 426f, ay, 0f), l, gameObject.transform);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 429, 0);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 431.5f, 0);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 435, 0);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 438.5f, 0f), d, gameObject.transform);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 440f, 0);
    	forar = Instantiate(ar3, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 442.5f, 0);
    	forar = Instantiate(ar1, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 445f, 0);
    	Instantiate(nar1, new Vector3(ax, transform.position.y - 448.5f, 0f), d, gameObject.transform);
    	forar = Instantiate(ar2, new Vector3(ax, transform.position.y, 0f), Quaternion.identity, gameObject.transform);
    	forar.transform.GetChild(0).transform.position = new Vector3(transform.position.x, transform.position.y - 450f, 0);
    }
}
