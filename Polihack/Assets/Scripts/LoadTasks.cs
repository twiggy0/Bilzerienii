using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LoadTasks : MonoBehaviour
{
    public static List<string> tasks = new List<string>();

    public TextAsset tasksText;

    public static List<Button> taskButtons = new List<Button>();
    // Start is called before the first frame update
    void Start()
    {
        string[] taskFromTextAsset = tasksText.text.Split('\n');
        foreach(string x in taskFromTextAsset)
        {
            tasks.Add(x + "\n");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
