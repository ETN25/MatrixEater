using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] GameObject Sphere;
    public Animator Animator, Light, UI;
    public Transform transform;
    public int speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, speed * Time.deltaTime);
            //Quaternion target = new Quaternion(0, 0, transform.rotation.z + 1, 0);
            //transform.rotation = Quaternion.Slerp(transform.rotation, target, Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("touché");
        Animator.SetTrigger("Death");
        speed = 0;
        Light.SetTrigger("Stop");
        UI.SetTrigger("End");
        Debug.Log("mort");
    }
    
    public void StartGame()
    {
        speed = 200;
        Light.SetTrigger("Start");
    }
}
