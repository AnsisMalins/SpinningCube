using UnityEngine;

public sealed class Rotator : MonoBehaviour
{
    [SerializeField]
    private Transform target;
    [SerializeField]
    private Vector3 axis;
    [SerializeField]
    private float speed;

    private float angle;

    private void Update()
    {
        angle += speed * Time.deltaTime;
        if (angle >= 360f)
            angle -= 360f;

        target.rotation = Quaternion.AngleAxis(angle, axis);
    }
}