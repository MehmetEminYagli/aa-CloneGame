using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircleManager : MonoBehaviour
{
    [SerializeField] private float RotationSpeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Setrotate();
    }
    private void Setrotate()
    {
        transform.Rotate(0,0,RotationSpeed * Time.deltaTime);
    }


}
