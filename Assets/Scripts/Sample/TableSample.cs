using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableSample : MonoBehaviour
{
    void Start()
    {
        Table table = new Table();

        table.addColumn("name");
        table.addColumn("x");
        table.addColumn("y");

        TableRow newRow = new TableRow();
        newRow.setString("username", "jon");
        newRow.setInt("float", Random.Range(0, 10));
        newRow.setFloat("int", Random.Range(0.0f, 10.0f));
        table.addRow(newRow);

        table.save("data/hoge.csv");//Assetsのなかのdataフォルダに追加される

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
