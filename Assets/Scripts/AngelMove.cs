using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AngelMove : MonoBehaviour
{
    public float moveSpead, range;
    Vector3 startPosition;
    Transform player;
    Vector3 direction = Vector3.right;
    public AudioSource dorimeSound;
    void Start()
    {
        player = gameObject.GetComponent<Transform>();
        startPosition = player.position;
        dorimeSound.Play();
    }
    void Update()
    {
        player.Translate(direction*Time.deltaTime*moveSpead);
        if (player.position.x <= startPosition.x - range)
        {
            direction = Vector3.right;
        }
        else if (player.position.x >= startPosition.x + range)
        {
            direction = Vector3.left;
        }
        
    }
}
