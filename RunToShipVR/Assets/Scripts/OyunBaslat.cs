using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OyunBaslat : MonoBehaviour {

	public TextMesh text;

	private Coroutine cor;
	// Use this for initialization
	void Start () {
		text.text = "";
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void baslat()
	{
		cor=StartCoroutine(say());
	}

	public void durdur()
	{

		StopCoroutine (cor);
		text.text = "";
	}

	IEnumerator say()
	{
		text.text = "Oyun Başlatılıyor";
		yield return new WaitForSecondsRealtime (3);
		SceneManager.LoadScene ("AnaSahne");

	}
}
