using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Last_Ease2 : MonoBehaviour
{
     public Vector2 diraction; //����������� �������
    public Vector2 diraction2; //����� ����������� �������
	private Transform _cash; //�������� ��������� ������
	public GameObject shieldd; //����� ������������ � �����
	private Transform _cash2; //�������� ��������� ���������
	public GameObject rotator; //������ ���� ��������
	private bool ifwas = false;
	Animator m_Animator; //���� ��� ��������
	public float isrot; //����� ���������� ��������
	public string stor; //������� ��������
	public string nestor1; //�� ������� ��������1
	public string nestor2; //�� ������� ��������2
	public string nestor3; //�� ������� ��������3
	public bool inl; //���� �����
	public bool ind; //���� �����
	public bool inr; //���� ������
	public bool inu; //���� ������
	private float somez; //���� �����
	private string somenaz; //���� ������������
	public float spd; //� ����� ��������� �������
	public float rasst; //��� �������
	public bool oh = false;
	public Vector2 othod;
	public Rigidbody2D rb;
	public Image ending;
	private float ho = 0;
	public AudioSource aud;
	public float t;
	public GameObject[] yellows; //�������
    void Start()
    {
    	rb = GetComponent<Rigidbody2D>();
    	shieldd = GameObject.Find("shield_obj");
        _cash = transform;
        _cash2 = rotator.transform;
        m_Animator = rotator.GetComponent<Animator>(); //����������� �������� ���������
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
    	if(oh == false){
    	Quaternion nowrot = Quaternion.AngleAxis(isrot, new Vector3(0, 0, 1)); //��������� �������
    	if(oh == false){
    	_cash.rotation = nowrot;
    	}
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
    }
    void Update(){
    	if(oh == true){
    		_cash.Rotate(0, 0, -8.5f, Space.World);
    		ending.color = new Color(0, 0, 0, ho);
    		ho += 0.1f;
    		if(t>0){
    			t -= Time.deltaTime;
    		}
    		else{
    			Instantiate(yellows[0], new Vector2(_cash.position.x - 0.3f, transform.position.y + 0.3f), Quaternion.identity);
    			Instantiate(yellows[1], new Vector2(_cash.position.x - 0.3f, transform.position.y - 0.3f), Quaternion.identity);
    			Instantiate(yellows[2], new Vector2(_cash.position.x, transform.position.y + 0.3f), Quaternion.identity);
    			Instantiate(yellows[3], new Vector2(_cash.position.x, transform.position.y - 0.3f), Quaternion.identity);
    			Instantiate(yellows[4], new Vector2(_cash.position.x + 0.3f, transform.position.y + 0.3f), Quaternion.identity);
    			Instantiate(yellows[5], new Vector2(_cash.position.x + 0.3f, transform.position.y - 0.3f), Quaternion.identity);
    			gameObject.SetActive(false);
    		}
    	}
    }
    void OnCollisionEnter2D(Collision2D other){
    	if(other.gameObject == shieldd){
    		oh = true;
    		rb.velocity = othod;
    		aud.volume = 0;
    }
    }
}
