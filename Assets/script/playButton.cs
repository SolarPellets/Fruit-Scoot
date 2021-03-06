﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
	public Button play;
	public Button Options;
	public Button exit;
	public Button Orange;
	public Button Apple;
	public Button Lemon;
	public Button Banana;
	public Button Grapes;
	public Button Back;
	public Button reset;
	public static float levelsU;
    // Start is called before the first frame update
    void Start()
    {
    	Cursor.lockState = CursorLockMode.None;
        play.onClick.AddListener(TaskPlay);
        exit.onClick.AddListener(TaskExit);
        Back.onClick.AddListener(TaskBack);
        Options.onClick.AddListener(TaskOptions);
        Orange.onClick.AddListener(TaskOrange);
        Apple.onClick.AddListener(TaskApple);
        Lemon.onClick.AddListener(TaskLemon);
        Banana.onClick.AddListener(TaskBanana);
        Grapes.onClick.AddListener(TaskGrapes);
        Orange.transform.localScale = new Vector3(0,0,0);
        Apple.transform.localScale = new Vector3(0,0,0);
        Lemon.transform.localScale = new Vector3(0,0,0);
        Banana.transform.localScale = new Vector3(0,0,0);
        Grapes.transform.localScale = new Vector3(0,0,0);
        Back.transform.localScale = new Vector3(0,0,0);
        reset.transform.localScale = new Vector3(0,0,0);
    }

    // Update is called once per frame
    void Update(){
    	levelsU = option.levelsUnlocked;
    }
    void TaskPlay()
    {
        Orange.transform.localScale = new Vector3(1,1,1);
        Apple.transform.localScale = new Vector3(1,1,1);
        Lemon.transform.localScale = new Vector3(1,1,1);
        Banana.transform.localScale = new Vector3(1,1,1);
        Grapes.transform.localScale = new Vector3(1,1,1);
        Back.transform.localScale = new Vector3(1,1,1);
        play.transform.localScale = new Vector3(0,0,0);
        Options.transform.localScale = new Vector3(0,0,0);
        exit.transform.localScale = new Vector3(0,0,0);
    }
    void TaskBack(){
    	Orange.transform.localScale = new Vector3(0,0,0);
        Apple.transform.localScale = new Vector3(0,0,0);
        Lemon.transform.localScale = new Vector3(0,0,0);
        Banana.transform.localScale = new Vector3(0,0,0);
        Grapes.transform.localScale = new Vector3(0,0,0);
        Back.transform.localScale = new Vector3(0,0,0);
        reset.transform.localScale = new Vector3(0,0,0);
        play.transform.localScale = new Vector3(1,1,1);
        Options.transform.localScale = new Vector3(1,1,1);
        exit.transform.localScale = new Vector3(1,1,1);
    }
    void TaskOptions(){
    	play.transform.localScale = new Vector3(0,0,0);
        Options.transform.localScale = new Vector3(0,0,0);
        exit.transform.localScale = new Vector3(0,0,0);
        Back.transform.localScale = new Vector3(1,1,1);
        reset.transform.localScale = new Vector3(1,1,1);
    }
    void TaskOrange(){
    	SceneManager.LoadScene("K1O");
    }
    void TaskApple(){
    	if(levelsU > 0){
    		SceneManager.LoadScene("K1A");
    	}
    }
    void TaskLemon(){
    	if(levelsU > 1){
    		SceneManager.LoadScene("K1L");
    	}
    }
    void TaskBanana(){
    	if(levelsU > 2){
    		SceneManager.LoadScene("K1B");
    	}
    }
    void TaskGrapes(){
    	if(levelsU > 3){
    		SceneManager.LoadScene("K1G");
    	}
    }
    void TaskExit(){
    	Application.Quit();
    }
}
