using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseGame : MonoBehaviour {

	private Coroutine cor;
	public TextMesh text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void baslat()
	{
		cor=StartCoroutine (kapat ());
	}

	public void dur()
	{
		text.text = "";
		StopCoroutine (cor);
	}


	IEnumerator kapat()
	{
		text.text="Oyun Kapatılıyor";


		yield return new WaitForSecondsRealtime (3);

		Application.Quit ();


	}
}
