using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class basket : MonoBehaviour
{
    public int points = 0;
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void setPosition(float amountAlongPath)
    {
        transform.position = new Vector3(amountAlongPath * 20.0f - 10.0f, transform.position.y, 0);
    }

    public void OnTriggerEnter(Collider other)
    {
        points++;
        score.text = points.ToString();
        GameObject.Destroy(other.gameObject);
    }
}
