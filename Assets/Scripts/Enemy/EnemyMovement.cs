using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    [SerializeField] private float _speed;



    // Update is called once per frame
    private void Update()
    {
        transform.Translate(Vector3.left * _speed * Time.deltaTime);
    }
}
