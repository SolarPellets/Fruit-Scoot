using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class option : MonoBehaviour
{
	public static int levelsUnlocked;
	public int levelsUn;
	public Button save;
	public Button load;
	public Button reset;
	public bool bowlO;
	public string currentScene;
	public GameObject loadB;
	public GameObject resetB;
	public GameObject saveB;
	public GameObject fruit;
	public GameObject bowlObject;
    // Start is called before the first frame update
    void Start()
    {
    	SceneManager.LoadScene("start menu", LoadSceneMode.Additive);
        reset.onClick.AddListener(TaskReset);
        load.onClick.AddListener(TaskLoad);
        save.onClick.AddListener(TaskSave);
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
        		SceneManager.LoadScene("start menu");
        	}
        	if(currentScene == "K1A"){
			if(levelsUnlocked == 1){
				levelsUnlocked = 2;
			}
			SceneManager.LoadScene("start menu");
		}
		if(currentScene == "K1L"){
        		if(levelsUnlocked == 2){
        			levelsUnlocked = 3;
        		}
        		SceneManager.LoadScene("start menu");
        	}
        	if(currentScene == "K1B"){
			if(levelsUnlocked == 3){
				levelsUnlocked = 4;
			}
			SceneManager.LoadScene("start menu");
		}
        	bowlO = false;
        }
    }
    void Update(){
    	if(currentScene == "start menu"){
    		saveB = GameObject.Find("save");
    		resetB = GameObject.Find("reset");
    		loadB = GameObject.Find("load");
    		save = saveB.GetComponent<Button>();
    		reset = resetB.GetComponent<Button>();
    		load = loadB.GetComponent<Button>();
    	}
    	else{
    		fruit = GameObject.FindWithTag("Player");
    		bowlObject = GameObject.FindWithTag("bowl");
    	}
    	levelsUn = levelsUnlocked;
    	DontDestroyOnLoad(this.gameObject);
    }
    void TaskReset(){
    	levelsUnlocked = 0;
    }
    void TaskLoad(){
    	levelsUnlocked = PlayerPrefs.GetInt("levels", 0);
    }
    void TaskSave(){
    	PlayerPrefs.SetInt("levels", levelsUnlocked);
    }
}
