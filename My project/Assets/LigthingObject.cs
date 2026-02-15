using UnityEngine;

public class LigthingObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public GameObject player;
    public GameObject otherObject;
    void Start()
    {
        player = GameObject.Find("Player");
        otherObject = GameObject.Find("объект(5, 12)");
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 playerPos = player.transform.position;
        Vector2 otherObjectPos = otherObject.transform.position;
        float distance = Vector2.Distance(playerPos, otherObjectPos);
        Debug.Log("Дистанция: " + distance);
        if (distance < 30)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            if (rb == null)
            {
                rb = gameObject.AddComponent<Rigidbody2D>();
                rb.gravityScale = 3f;
            }
            
        }
    }
}
