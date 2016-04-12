using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void LoadCameraScene()
    {
        SceneManager.LoadScene("Camera");
    }

    public void LoadHistoriaScene()
    {
        SceneManager.LoadScene("Historias");
    }
}
