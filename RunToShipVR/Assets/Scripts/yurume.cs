using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class yurume : MonoBehaviour {


	public Transform vrCamera;

	public float speed=3.0f;

	private CharacterController cc;

	public GameObject obje;

	public GUIStyle style;

	public static int skor=0;

	public static int  kontrol=0;

	void Start() 
	{
		cc = GetComponent<CharacterController> ();
		skor = 0;

	}


	void Update()
	{
		Vector3 forward = vrCamera.TransformDirection (Vector3.forward);

		cc.SimpleMove (forward*speed);



	
		if (obje.transform.position.y < 3.0F) {

			SceneManager.LoadScene ("GameOver");
		}	


	}

	void OnCollisionEnter(Collision go)
	{
		if (go.gameObject.tag == "engel") {

			SceneManager.LoadScene ("GameOver");
		} 


	}

	void OnTriggerEnter(Collider go)
	{
		if (go.gameObject.tag == "engel") {

			skor += 5;
			DestroyObject (go);
		}

		else if (go.gameObject.tag == "GameOver") 
		{
			kontrol = 1;
			SceneManager.LoadScene ("GameOver");
		}
	

	}


	void OnGUI()
	{
		GUI.Label (new Rect (25,25, Screen.width, 50), "Skor:"+skor, style);
	}



}