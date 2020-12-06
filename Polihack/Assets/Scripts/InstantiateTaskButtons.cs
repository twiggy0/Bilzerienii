using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InstantiateTaskButtons : MonoBehaviour
{
    public Button taskPrefabButton;
    public GameObject parrentButton;
    // Start is called before the first frame update
    void Start()
    {
        int i = 0;
        foreach(string s in LoadTasks.tasks)
        {
            Button tButton = Instantiate(taskPrefabButton, parrentButton.transform.position, parrentButton.transform.rotation);

            tButton.transform.SetParent(parrentButton.transform);

            string[] x = s.Split(' ');

            string taskComplet = null;

            foreach(string k in x)
            {
                taskComplet = taskComplet + k + "\n";
            }

            tButton.name = "TaskButton" + i;
            GameObject.Find("TaskButton" + i).GetComponentInChildren<Text>().text = taskComplet;
            i++;

            LoadTasks.taskButtons.Add(tButton);
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
