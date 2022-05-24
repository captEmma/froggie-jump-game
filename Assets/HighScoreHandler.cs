using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreHandler : MonoBehaviour
{
    private Transform table, record;
    private List<int> recorList;

    private void Awake()
    {
        table = transform.Find("Table");
        record = table.Find("recordTemplate");
        record.gameObject.SetActive(false);


    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
