using UnityEngine;

public class NewMonoBehaviourScript : MonoBehaviour
{
    public GameObject Player;
    public float speed;
    public float distanceBetween;

    private float distance;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector2.Distance(transform.position, Player.transform.position); // Calculates distance between enemy and player
        Vector2 direction = Player.transform.position - transform.position; // Gets direction vector from enemy to player
        direction.Normalize();
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg; // Calculates angle to rotate enemy towards player  

        
        
        if (distance < distanceBetween) 
        {
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime); // Moves enemy towards player at a set speed
            transform.rotation = Quaternion.Euler(Vector3.forward * angle); // Rotates enemy to face player
        }
    }
}
