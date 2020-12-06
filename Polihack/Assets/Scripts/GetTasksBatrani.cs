using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class GetTasksBatrani : MonoBehaviour
{
    // Start is called before the first frame update
    public Button Button;
    
    public InputField iFTasks;
    public InputField iFNume;
    public InputField iFTelefon;
    public InputField iFAdresa;

    
    void Start()
    {
        Button addBtn = Button.GetComponent<Button>();
        addBtn.onClick.AddListener(TaskOnClick);
    }
    
    void TaskOnClick()
    {
        LoadTasks.tasks.Add(iFNume.text + " " + iFTelefon.text + " " + iFAdresa.text + " " + iFTasks.text + "\n");

        string path = "Assets/Resources/Tasks.txt";
        //ModifyFile(path);
        Debug.Log(LoadTasks.tasks.Count + " " + iFNume.text);
    }
    void ModifyFile(string path)
    {
        using (StreamReader sr = File.OpenText(path))
        {
            StreamWriter writer = new StreamWriter(path, true);
            foreach (string x in LoadTasks.tasks)
            {
                writer.WriteLine(x);
            }
            writer.Close();

        }
    }
}
