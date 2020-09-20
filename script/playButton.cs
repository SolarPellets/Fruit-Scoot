using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class playButton : MonoBehaviour
{
	public Button play;
	public Button exit;
    // Start is called before the first frame update
    void Start()
    {
        play.onClick.AddListener(TaskPlay);
        exit.onClick.AddListener(TaskExit);
    }

    // Update is called once per frame
    void TaskPlay()
    {
        SceneManager.LoadScene("Level1");
    }
    void TaskExit(){
    	Application.Quit();
    }
}
