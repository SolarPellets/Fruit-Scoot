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
	public string currentScene;
	public GameObject buttonP;
	public GameObject resetO;
	public Button reset;
    // Start is called before the first frame update
    void Start()
    {
    	SceneManager.LoadScene("start menu", LoadSceneMode.Additive);
    	reset.onClick.AddListener(TaskReset);
    	levelsUnlocked = PlayerPrefs.GetInt("levels", 0);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        bowlO = banana.bowl;
        var cScene = SceneManager.GetActiveScene();
        currentScene = cScene.name;
        if(bowlO == true){
        	if(currentScene == "K1O"){
        		if(levelsUnlocked == 0){
        			levelsUnlocked = 1;
        		}
        		PlayerPrefs.SetInt("levels", levelsUnlocked);
        		SceneManager.LoadScene("start menu");
        		reset.onClick.AddListener(TaskReset);
        	}
        	if(currentScene == "K1A"){
			if(levelsUnlocked == 1){
				levelsUnlocked = 2;
			}
			PlayerPrefs.SetInt("levels", levelsUnlocked);
			SceneManager.LoadScene("start menu");
			reset.onClick.AddListener(TaskReset);
		}
		if(currentScene == "K1L"){
        		if(levelsUnlocked == 2){
        			levelsUnlocked = 3;
        		}
        		PlayerPrefs.SetInt("levels", levelsUnlocked);
        		SceneManager.LoadScene("start menu");
        		reset.onClick.AddListener(TaskReset);
        	}
        	if(currentScene == "K1B"){
			if(levelsUnlocked == 3){
				levelsUnlocked = 4;
			}
			PlayerPrefs.SetInt("levels", levelsUnlocked);
			SceneManager.LoadScene("start menu");
			reset.onClick.AddListener(TaskReset);
		}
        	bowlO = false;
        }
    }
    void Update(){
    	fruit = GameObject.FindWithTag("Player");
    	bowlObject = GameObject.FindWithTag("bowl");
    	buttonP = GameObject.Find("Canvas");
    	resetO = buttonP.transform.Find("reset").gameObject;
    	reset = resetO.GetComponent<Button>();
    	reset.onClick.AddListener(TaskReset);
    	levelsUn = levelsUnlocked;
    	DontDestroyOnLoad(this.gameObject);
    }
    void TaskReset(){
    	levelsUnlocked = 0;
    	PlayerPrefs.SetInt("levels", levelsUnlocked);
    }
}
