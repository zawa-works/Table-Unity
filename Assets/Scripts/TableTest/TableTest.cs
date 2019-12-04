using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Table table = new Table("data/hoge/hoge.csv");

        table.addColumn("username");
        table.addColumn("x");
        table.addColumn("y");

        for (int i = 0; i < 10; i++)
        {

            TableRow row = new TableRow();
            row.setString("username", "hoge");
            row.setFloat("x", Random.Range(0, 10));
            row.setFloat("y", Random.Range(0, 10));

            table.addRow(row);
        }

        table.save();

    }

    // Update is called once per frame
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
