using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{

    public int apple { get { return currentApple;}}
    public static int currentApple;
    public int maxApple = 5;


    [SerializeField] private Text applesText;

    [SerializeField] private AudioSource itemSoundEffect;

    void Start()
    {
        currentApple = 0;
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Pickup"))
        {
            itemSoundEffect.Play();
            Destroy(collision.gameObject);
            currentApple++;
            applesText.text = "Apples: " + apple;
        }
    }

   
    


}

