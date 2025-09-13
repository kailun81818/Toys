using UnityEngine;

public class RotateLayer : MonoBehaviour
{
    [SerializeField] private Vector3 position = new Vector3(1, 1, 0);
    [SerializeField] private Vector3 eulerAngles = new Vector3(180, 0, 270);

    [SerializeField] private int angleNow;

    [SerializeField] private bool turnPlus = false;
    [SerializeField] private bool turnMinus = false;


    void Awake()
    {
        transform.localPosition = position;
        transform.localEulerAngles = eulerAngles;
        angleNow = (int)eulerAngles.x;
    }

    void Update()
    {
        if (turnPlus)
        {
            angleNow = (angleNow + 90) % 360;
            transform.localEulerAngles = new Vector3(angleNow, 0, 270);
            turnPlus = false;
        }
        else if (turnMinus)
        {
            angleNow = (angleNow + 270) % 360;
            transform.localEulerAngles = new Vector3(angleNow, 0, 270);
            turnMinus = false;
        }
    }
}
