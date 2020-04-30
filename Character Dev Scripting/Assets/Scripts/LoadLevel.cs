
using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LoadLevel : MonoBehaviour {
    
	public void StartGame () {
        SceneManager.LoadScene(1);
	}
}