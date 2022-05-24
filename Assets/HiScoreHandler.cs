using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HiScoreHandler : MonoBehaviour
{
    private Transform table, record;
    private List<HiScoreRecord> recordList;
    
    private void Awake()
    {
        table = transform.Find("Table");
        record = table.Find("recordTemplate");
        record.gameObject.SetActive(false);

        recordList = new List<HiScoreRecord>() {
             new HiScoreRecord{ score = 123, name="AAA"},
             new HiScoreRecord{ score = 1342, name="bbb"},
             new HiScoreRecord{ score = 34, name="ccc"},
             new HiScoreRecord{ score = 34552, name="ddd"},
             new HiScoreRecord{ score = 4, name="eee"}
         };
        recordList = new List<HiScoreRecord>();

        //string jsonLoad = PlayerPrefs.GetString("hiScoreTable");
        //RecordContainer scoresLoad = JsonUtility.FromJson<RecordContainer>(jsonLoad);

        recordList.Sort();
        recordList.Reverse();
        
        for(int i=0; i<recordList.Count; i++)
        {
            giveEntryTransform(recordList[i], table, i);
        }
        /*
        RecordContainer scores = new RecordContainer { recordList = recordList };
        string json = JsonUtility.ToJson(scores);

        PlayerPrefs.SetString("hiScoreTable", json);
        PlayerPrefs.Save();
        Debug.Log(PlayerPrefs.GetString("hiScoreTable"));
        */

    }

    private void giveEntryTransform(HiScoreRecord entry, Transform container, int index)
    {
        float distance = 65f;
        entry.trans = Instantiate(record, container);
        RectTransform recordRect = entry.trans.GetComponent<RectTransform>();
        recordRect.anchoredPosition = new Vector2(0, -distance * index);
        entry.trans.gameObject.SetActive(true);
        
        entry.trans.Find("scoreRecord").GetComponent<TMP_Text>().text = entry.score.ToString();
        entry.trans.Find("nameRecord").GetComponent<TMP_Text>().text = entry.name;
    }

    private class RecordContainer
    {
        public List<HiScoreRecord> recordList;
    }

    [System.Serializable]
    private class HiScoreRecord : IComparable<HiScoreRecord>, IEquatable<HiScoreRecord>
    {
        public int score { get; set; }
        public string name { get; set; }

        public Transform trans;

        public bool Equals(HiScoreRecord comparison)
        {
            if (comparison == null) return false;
            return comparison.score == score;
        }

        public int CompareTo(HiScoreRecord comparison)
        {
            if (comparison == null) return 1;
            return this.score.CompareTo(comparison.score);
        }
        public override int GetHashCode()
        {
            return score;
        }
        public override bool Equals(object obj)
        {
            if (obj == null) return false;
            HiScoreRecord record = obj as HiScoreRecord;
            if (record == null) return false;
            return Equals(record);
        }
        public override string ToString()
        {
            return name + " " + score;
        }

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
