using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDown : MonoBehaviour
{
    [SerializeField] private Image timerImg;
    [SerializeField] private Text timerText;
  //  [SerializeField] private Text scoreText;
    UIManager uýManager;

   // [SerializeField] AudioClip alkissound;
   // [SerializeField] AudioSource audioSource;

    public float currentTime; 
    public float duration; //bizim belirleyeceðimiz süre

    //public GameObject panel;
    public GameObject confetti;

    // private int score;

    //  Distance dt;

    [SerializeField] GameObject TimeEndText;
    void Start()
    {
        currentTime = duration;
        timerText.text = currentTime.ToString();
        StartCoroutine(UpdateTime());
       

    }

    IEnumerator UpdateTime()
    {
        while (currentTime > 0)
        {
            timerImg.fillAmount = Mathf.InverseLerp(0, duration, currentTime); //baþlangýþ, tepe ve þimdki zamaný alýr ve bunlarý image üzerinde gösterir.
            timerText.text = currentTime.ToString(); //zamaný text'te yazdýrdýk
            yield return new WaitForSeconds(1f);
            currentTime--;
        }
        yield return null;
    }

  
    private void Update()
    {
        if (currentTime == 0)
        {
           
          //  panel.SetActive(true);
            confetti.SetActive(true);
            TimeEndText.SetActive(true);
        }
        else
        {
           // panel.SetActive(false);
            confetti.SetActive(false);
            TimeEndText.SetActive(false);
        }
    }
}