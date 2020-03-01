using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Wselect : MonoBehaviour
{
    public GameObject watch1;
	public GameObject watch2;
	public GameObject watch3;
	
	public GameObject window1;
	public GameObject window2;
	public GameObject window3;

    Animation win1animation;
    Animation win2animation;
    Animation win3animation;

    // Start is called before the first frame update
    void Start()
    {
        win1animation = window1.GetComponent<Animation>();
        win2animation = window2.GetComponent<Animation>();
        win3animation = window3.GetComponent<Animation>();
    }

    public void WatchOneButtonClicked(){
    	watch1.SetActive(true);
    	watch2.SetActive(false);
    	watch3.SetActive(false);

        window1.SetActive(true);
        window2.SetActive(false);
        window3.SetActive(false);

        win1animation["window1"].speed=1;
        win1animation.Play();
    }
    
    public void WatchTwoButtonClicked(){
    	watch1.SetActive(false);
    	watch2.SetActive(true);
    	watch3.SetActive(false);

        window1.SetActive(false);
        window2.SetActive(true);
        window3.SetActive(false);

        win2animation["window2"].speed = 1;
        win2animation.Play();
    }
    
    public void WatchThreeButtonClicked(){
    	watch1.SetActive(false);
    	watch2.SetActive(false);
    	watch3.SetActive(true);

        window1.SetActive(false);
        window2.SetActive(false);
        window3.SetActive(true);

        win3animation["window3"].speed = 1;
        win3animation.Play();
    }

    public void CloseButtonClicked()
    {
        string buttonName = EventSystem.current.currentSelectedGameObject.name;
        
        if(buttonName == "Close1")
        {
            win1animation["window1"].speed = -1;
            win1animation["window1"].time = win1animation["window1"].length;
            win1animation.Play();
        }

        else if (buttonName == "Close2")
        {
            win2animation["window2"].speed = -1;
            win2animation["window2"].time = win2animation["window2"].length;
            win2animation.Play();
        }

        else if (buttonName == "Close3")
        {
            win3animation["window3"].speed = -1;
            win3animation["window3"].time = win3animation["window3"].length;
            win3animation.Play();
        }
    }

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                  
}
