using UnityEngine;

public class PistolBehavior : MonoBehaviour
{
    public GameObject laserTemplate;
    public Transform spawnPoint;
    public int clipSize;
    public int shotsRemaining;

    public void ShootLaser()
    {
        if (shotsRemaining > 0)
        {
            GameObject laser = Instantiate(laserTemplate, spawnPoint.position, spawnPoint.rotation);
            laser.GetComponent<Rigidbody>().AddForce(spawnPoint.forward * 5, ForceMode.Impulse);
            shotsRemaining -= 1;
        }
    }

    public void reload()
    {
        shotsRemaining = clipSize;
    }
}