using UnityEngine;

public class Target : MonoBehaviour
{
    public int points = 100; // Points for shooting the target
    private ScoreManager scoreManager;

    void Start()
    {
        // Find the ScoreManager in the scene
        scoreManager = FindObjectOfType<ScoreManager>();
    }

    void OnCollisionEnter(Collision collision)
    {
        // Check if the object that hit the target is a bullet
        if (collision.gameObject.CompareTag("Bullet"))
        {
            // Add points to the score
            scoreManager.AddPoints(points);

            // Destroy the bullet and the target (optional)
            Destroy(collision.gameObject); // Destroy the bullet
            Destroy(gameObject); // Destroy the target (optional)
        }
    }
}
