using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gamecontroler : MonoBehaviour
{

    public Transform spawn;
    public Transform spawnright;

    public Transform spawnleft;

    public GameObject anime;
public float delay ; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnanime", 0f, delay); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnanime()
    {

        int randum = Random.Range(1,4 );

        if(randum == 1)
        {
            Instantiate(anime, spawnleft);
 

        }

       else if (randum == 2)
        {
            Instantiate(anime, spawn);


        }

        else 
        {
            Instantiate(anime, spawnright);


        }
    }
}
