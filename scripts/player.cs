using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
using System;

public class player : MonoBehaviour
{

    private Vector2 targetPos;
    public float Yincrement;
    public float speed;
    public float maxHeight;
    public float minHeight;
    public int health = 3;
    public GameObject effect;
    public GameObject sound;

    protected Transform mytransform;
    public TMP_Text healthDisplay;



    // Update is called once per frame


    void Update()
    {
        mytransform = GetComponent<Transform>();
        healthDisplay.text = health.ToString();

        if (health <= 0)
        {
            SceneManager.LoadScene("restart");
        }


        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if (Input.GetKeyDown(KeyCode.UpArrow) && transform.position.y < maxHeight && (mytransform.position.y == 0 || mytransform.position.y == 3 || mytransform.position.y == -3))
        {
            
            
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            Instantiate(effect, transform.position, Quaternion.identity);
            Instantiate(sound, transform.position, Quaternion.identity);

        }
        else if (Input.GetKeyDown(KeyCode.DownArrow) && transform.position.y > minHeight && (mytransform.position.y == 0 || mytransform.position.y == 3 || mytransform.position.y == -3))
        {
            
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            Instantiate(effect, transform.position, Quaternion.identity);
            Instantiate(sound, transform.position, Quaternion.identity);
        }
    }
}
