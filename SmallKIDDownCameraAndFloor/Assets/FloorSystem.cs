using UnityEngine;

public class FloorSystem : MonoBehaviour
{
    public Transform floor;

    private int y = -5;

    private void Awake()
    {
        Screen.SetResolution(450, 800, false);
    }

    private void Start()
    {
        InvokeRepeating("SpawnFloor", 0, 0.5f);
    }

    private void SpawnFloor()
    {
        int x = Random.Range(-3, 4);
        Vector3 pos = new Vector3(x, y, 0);
        y-=2;
        Instantiate(floor, pos, Quaternion.identity);
    }
}
