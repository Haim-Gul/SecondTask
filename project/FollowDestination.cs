using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowDestination : MonoBehaviour
{
    // Start is called before the first frame update
    private UnityEngine.AI.NavMeshAgent agent = null;
    public Transform destination = null;
    [SerializeField] float turnspeed = 45.0f;
    [SerializeField] float speed = 10f;
    private float horizontal;
    private float vertical;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(destination.position);
        //  horizontal = Input.GetAxis("Horizontal");
        //vertical = Input.GetAxis("Vertical");

        //  transform.Translate(Vector3.forward * speed * Time.deltaTime * vertical);
        //transform.Rotate(Vector3.up, turnspeed * horizontal * Time.deltaTime);

    }

}
