using UnityEngine;

public class GoalMover : MonoBehaviour
{
    public float speed = 2f;
    public float range = 3f;

    private Vector3 startPos;

    void Start()
    {
        startPos = transform.position;
    }

    void Update()
    {
        float xOffset = Mathf.Sin(Time.time * speed) * range;
        transform.position = new Vector3(
            startPos.x + xOffset,
            startPos.y,
            startPos.z
        );
    }
}
