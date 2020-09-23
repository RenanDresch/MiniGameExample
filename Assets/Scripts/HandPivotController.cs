using UnityEngine;
using UnityEngine.UI;

public class HandPivotController : MonoBehaviour
{
    [SerializeField]
    private Slider slider = default;

    private float pivotRotation = default;

    private void Update()
    {
        if(Input.GetAxis("Vertical") != 0)
        {
            if(Input.GetAxis("Vertical") > 0 && pivotRotation < -90)
            {
                return;
            }
            else if (Input.GetAxis("Vertical") < 0 && pivotRotation > 45)
            {
                return;
            }

            pivotRotation -= Input.GetAxis("Vertical")/4;
            transform.eulerAngles = new Vector3(pivotRotation, 90, 0);
            slider.value = -pivotRotation;
        }
    }

    public void SetPivotRotation(float degrees)
    {
        transform.eulerAngles = new Vector3(-degrees, 90, 0);
        pivotRotation = -degrees;
    }
}
