using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
	public static int levelsUnlocked;
	public int levelsUn;
	public bool bowlO;
	public GameObject fruit;
	public GameObject bowlObject;
    // Start is called before the first frame update
    void Start()
    {
    	SceneManager.LoadScene("start menu", LoadSceneMode.Additive);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
    	levelsUnlocked = PlayerPrefs.GetInt("levels", 0);
        bowlO = banana.bowl;
        var cScene = SceneManager.GetActiveScene();
        if(bowlO == true){
        	if(cScene.name == "K1O"){
        		if(levelsUnlocked == 0){
        			levelsUnlocked = 1;
        		}
        		PlayerPrefs.SetInt("levels", levelsUnlocked);
        		SceneManager.LoadScene("start menu");
        	}
        	if(cScene.name == "K1A"){
			if(levelsUnlocked == 1){
				levelsUnlocked = 2;
			}
			SceneManager.LoadScene("start menu");
		}
		if(cScene.name == "K1L"){
        		if(levelsUnlocked == 2){
        			levelsUnlocked = 3;
        		}
        		SceneManager.LoadScene("start menu");
        	}
        	if(cScene.name == "K1B"){
			if(levelsUnlocked == 3){
				levelsUnlocked = 4;
			}
			SceneManager.LoadScene("start menu");
		}
        	bowlO = false;
        }
    	fruit = GameObject.FindWithTag("Player");
    	bowlObject = GameObject.FindWithTag("bowl");
    	levelsUn = levelsUnlocked;
    	DontDestroyOnLoad(this.gameObject);
    }
}
