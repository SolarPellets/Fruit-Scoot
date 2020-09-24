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
    }

    // Update is called once per frame
    void TaskPlay()
    {
        Orange.image.rectTransform.sizeDelta = new Vector3(1,1,1);
        Apple.image.rectTransform.sizeDelta = new Vector3(1,1,1);
        Lemon.image.rectTransform.sizeDelta = new Vector3(1,1,1);
        Banana.image.rectTransform.sizeDelta = new Vector3(1,1,1);
        Grapes.image.rectTransform.sizeDelta = new Vector3(1,1,1);
        Back.image.rectTransform.sizeDelta = new Vector3(1,1,1);
        play.image.rectTransform.sizeDelta = new Vector3(0,0,0);
        options.image.rectTransform.sizeDelta = new Vector3(0,0,0);
        exit.image.rectTransform.sizeDelta = new Vector3(0,0,0);
    }
    void TaskBack(){
    	Orange.image.rectTransform.sizeDelta = new Vector2(0,0);
        Apple.image.rectTransform.sizeDelta = new Vector2(0,0);
        Lemon.image.rectTransform.sizeDelta = new Vector2(0,0);
        Banana.image.rectTransform.sizeDelta = new Vector2(0,0);
        Grapes.image.rectTransform.sizeDelta = new Vector2(0,0);
        Back.image.rectTransform.sizeDelta = new Vector2(0,0);
        play.image.rectTransform.sizeDelta = new Vector2(1,1);
        options.image.rectTransform.sizeDelta = new Vector2(1,1);
        exit.image.rectTransform.sizeDelta = new Vector2(1,1);
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
