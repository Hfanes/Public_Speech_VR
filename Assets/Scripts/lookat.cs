using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lookat : MonoBehaviour
{
    public Transform target;
    public float Speed = 1f;
    private Coroutine LookCoroutine;
    //private void Start()
    //{
    //    StartRotating();
    //}

    //public void StartRotating()
    //{
    //    if(LookCoroutine != null)
    //    {
    //        StopCoroutine(LookCoroutine);
    //    }
    //    LookCoroutine = StartCoroutine(LookAt());
    //}

    //private IEnumerator LookAt()
    //{
    //    Quaternion lookRotation = Quaternion.LookRotation(target.position - transform.position);
    //    float time = 0;
    //    while(time < 1)
    //    {
    //        transform.rotation = Quaternion.Slerp(transform.rotation, lookRotation, time);
    //        time += Time.deltaTime * Speed;
    //        yield return null;
    //    }
    //}

    private void Update()
    {
        transform.LookAt(target);
        //transform.LookAt(new Vector3(transform.position.x, target.position.y, transform.position.z));

        Debug.Log("passou aqui");
    }


}

