using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField]
    private GameObject arrowPrefab = default;

    [SerializeField]
    private Transform hand = default;

    private void Update()
    {
        if(Input.GetButtonDown("Jump"))
        {
            ShootArrow();   
        }
    }

    public void ShootArrow()
    {
        var newArrow = Instantiate(arrowPrefab, hand.position, hand.rotation);
        newArrow.GetComponent<Rigidbody>().AddForce(hand.forward * 100, ForceMode.Impulse);
    }
}
