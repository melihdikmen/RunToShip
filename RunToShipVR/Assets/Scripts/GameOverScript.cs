using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverScript : MonoBehaviour {

	public Coroutine sayac;

	public GameObject LoadingScreen;
	public Slider slider;
	public TextMesh score;


	 public void Start () {

		if (yurume.kontrol == 0)
		{
			score.text = "Engele Çarptınız\nSkor:" + yurume.skor.ToString ();
		} 
		else if (yurume.kontrol == 1) 
		{
			score.text = "Oyunu bitirdiniz.\nSkor:" + yurume.skor.ToString ();
		}


	}
	
	// Update is called once per frame
	void Update () {
		
	}


	public void Baslat(int sceneIndex)
	{
		score.text = "Yeniden Başlatılıyor";
		sayac=StartCoroutine(Example(sceneIndex));


	}

	public void durdur()
	{
		score.text = "Skor:" + yurume.skor.ToString();
		StopCoroutine (sayac);
	}


	IEnumerator Example(int sceneIndex)
	{
		AsyncOperation operation = SceneManager.LoadSceneAsync (sceneIndex);
		LoadingScreen.SetActive (true);
		 
		while (!operation.isDone) 
		{
			float progress = Mathf.Clamp01 (operation.progress / .9f);
			slider.value = progress;
			yield return null;
		}



			


	}
}
