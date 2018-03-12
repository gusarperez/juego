using UnityEngine;
using UnityEngine.SceneManagement;		// Requiered to switch scenes
using System.Collections;

public class LevelManager : MonoBehaviour {
    
    public void NextLevel()
    {
        //
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
	public void LoadLevel(string name){
		Debug.Log ("New Level load: " + name);
		//	Application.LoadLevel (name);    -- This method was deprecated a long time ago
		SceneManager.LoadScene ("Level_01");
	}

	public void QuitRequest(){
		Debug.Log ("Quit requested");
		Application.Quit ();
	}

}
