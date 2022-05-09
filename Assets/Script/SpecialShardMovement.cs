using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialShardMovement : MonoBehaviour
{
    [SerializeField] float speed, RSpeed;
    Quaternion Rotation;
    // Start is called before the first frame update
    void Start()
    {
        int randomRotation = 30 * Random.Range(1, 12);
        Rotation.eulerAngles = new Vector3(0, 0, randomRotation);
        transform.rotation = Rotation;
        transform.localScale = new Vector3(1, 1, 5);
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.localScale.x < 5)
        {
            transform.localScale = new Vector3(transform.localScale.x + (10 * Time.deltaTime), transform.localScale.y + (10 * Time.deltaTime), 5);
        }
        else
        {
            transform.localScale = new Vector3(5, 5, 5);
        }
        transform.position = new Vector3(0, 0, transform.position.z - (speed * Time.deltaTime));
        transform.Rotate(0, 0, RSpeed * Time.deltaTime);
        if (transform.position.z < -10)
        {
            Destroy(gameObject);
        }
    }
}
