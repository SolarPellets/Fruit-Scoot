using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
	public Button play;
	public Button options;
	public Button exit;
	public Button Orange;
	public Button Apple;
	public Button Lemon;
	public Button Banana;
	public Button Grapes;
	public Button Back;
    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(TaskPlay);
        exit.onClick.AddListener(TaskExit);
        Back.onClick.AddListener(TaskBack);
        options.onClick.AddListener(TaskOptions);
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
    }

    // Update is called once per frame
    void TaskPlay()
    {
        Orange.transform.localScale = new Vector3(1,1,1);
        Apple.transform.localScale = new Vector3(1,1,1);
        Lemon.transform.localScale = new Vector3(1,1,1);
        Banana.transform.localScale = new Vector3(1,1,1);
        Grapes.transform.localScale = new Vector3(1,1,1);
        Back.transform.localScale = new Vector3(1,1,1);
        play.transform.localScale = new Vector3(0,0,0);
        options.transform.localScale = new Vector3(0,0,0);
        exit.transform.localScale = new Vector3(0,0,0);
    }
    void TaskBack(){
    	Orange.transform.localScale = new Vector3(0,0,0);
        Apple.transform.localScale = new Vector3(0,0,0);
        Lemon.transform.localScale = new Vector3(0,0,0);
        Banana.transform.localScale = new Vector3(0,0,0);
        Grapes.transform.localScale = new Vector3(0,0,0);
        Back.transform.localScale = new Vector3(0,0,0);
        play.transform.localScale = new Vector3(1,1,1);
        options.transform.localScale = new Vector3(1,1,1);
        exit.transform.localScale = new Vector3(1,1,1);
    }
    void TaskOptions(){
    
    }
    void TaskOrange(){
    	SceneManager.LoadScene("K1O");
    }
    void TaskApple(){
    	
    }
    void TaskLemon(){
    	
    }
    void TaskBanana(){
    	
    }
    void TaskGrapes(){
    	
    }
    void TaskExit(){
    	Application.Quit();
    }
}
