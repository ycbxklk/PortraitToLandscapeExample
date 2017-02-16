using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonClass : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	
	}

	//on click the button
	public	void onClick(){
		SceneManager.LoadSceneAsync ("scene2");
	}

	// Update is called once per frame
	void Update () {
	
	}
}
