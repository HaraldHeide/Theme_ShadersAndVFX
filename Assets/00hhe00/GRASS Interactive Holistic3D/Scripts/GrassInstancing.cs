using UnityEngine;

public class GrassInstancing : MonoBehaviour
{
    [SerializeField] private GameObject grassPrefab;
    [SerializeField] private int grassSize;
    [SerializeField] private GameObject ball;
    [SerializeField] private Material mat;
    private void Start()
    {
        for (int z = -grassSize; z <= grassSize; z++)
        {
            for (int x = -grassSize; x <= grassSize; x++)
            {
                Vector3 position = new Vector3(x / 4.0f + Random.Range(-0.25f, 0.25f),
                                               this.transform.position.y,
                                                z / 4.0f + Random.Range(-0.25f, 0.25f));

                GameObject grass = Instantiate(grassPrefab, position, Quaternion.identity,this.transform);

                grass.transform.localScale = new Vector3(1, Random.Range(0.8f, 1.2f), 1);
            }
        }
    }

    private void Update()
    {
        mat.SetVector("_TramplePosition", ball.transform.position);
    }

}
