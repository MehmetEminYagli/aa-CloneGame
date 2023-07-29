using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{
    private List<GameObject> balllist = new List<GameObject>();
    [SerializeField] private GameObject ballprefab;
    [SerializeField] private int ballCount;
    private int ballIndex;
    void Start()
    {
        createBall();
    }


    private void createBall()
    {
        for (int i = 0; i < ballCount; i++)
        {
            GameObject newball = Instantiate(ballprefab, transform.position, Quaternion.identity);
            newball.SetActive(false);
            balllist.Add(newball);
        }
        balllist[0].SetActive(true);
    }


    public void ActiveBall()
    {
        if (ballIndex < balllist.Count - 1)
        {
            ballIndex++;
            balllist[ballIndex].SetActive(true);
        }
    }
}
