using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSample : MonoBehaviour
{
    void Start()
    {
        Table table = new Table();

        table.AddColumn("username");
        table.AddColumn("intValue");
        table.AddColumn("floatValue");

        TableRow newRow = new TableRow();
        newRow.SetString("username", "jon");
        newRow.SetInt("intValue", Random.Range(0, 10));
        newRow.SetFloat("floatValue", Random.Range(0.0f, 10.0f));
        table.AddRow(newRow);

        table.Save("data/hoge.csv");//Assetsのなかのdataフォルダに追加される

    }

    void Update()
    {
        Quit();
    }

    public void Quit()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
#elif UNITY_STANDALONE
            UnityEngine.Application.Quit();
#endif
    }
}
