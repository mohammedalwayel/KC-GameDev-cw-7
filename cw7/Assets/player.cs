using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class player : MonoBehaviour
{

    public Transform min;

    public Transform max;
    public float inc;
    public AudioSource  scr ; 
    

    void Start()
    {
        scr = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }


    void Move()
    {

         if(Input.GetKeyDown(KeyCode.D ))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x + inc, min.position.x,max.position.x ), transform.position.y, transform.position.z);
                 
        }

         else if (Input.GetKeyDown(KeyCode.A))
        {
            transform.position = new Vector3(Mathf.Clamp(transform.position.x - inc, min.position.x, max.position.x), transform.position.y, transform.position.z);

        }

         
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "eny")
        {



            print("collitoin"); 

            scr.Play();

            Invoke("Restart", 1f);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(0);

        

    }
}
