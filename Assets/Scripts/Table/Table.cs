﻿using System;
using System.IO;
using System.Collections.Generic;
using UnityEngine;

public class Table
{
    List<TableRow> rows;
    List<string> columns;
    string fileName;

    public Table(string _fileName)
    {
        fileName = _fileName;
        rows = new List<TableRow>();
        columns = new List<string>();

    }

    public void addColumn(string column)
    {
        columns.Add(column);
    }


    public void addRow(TableRow _row)
    {
        rows.Add(_row);
    }

    public void save()
    {
        string filePath = Path.Combine(Application.dataPath, @fileName);
        string dirPath = filePath.Substring(0, filePath.LastIndexOf("/", StringComparison.CurrentCulture));
        if (!Directory.Exists(dirPath)) Directory.CreateDirectory(dirPath);

        // Tableファイルに書き込む
        try
        {

            using (StreamWriter sw = File.CreateText(filePath))
            {

                //最初にcolumns（ヘッダーの内容）を書き込む
                sw.WriteLine(format(columns));

                //取得した情報を書き込む
                foreach (TableRow row in rows)
                    sw.WriteLine(format(row));
                sw.Close();
            }
        }
        catch (System.Exception e)
        {
            Debug.Log(e.Message);
        }
    }
    string format(List<string> _columns)
    {
        string str = "";
        int lastIndex = _columns.Count - 1;

        for (int i = 0; i < lastIndex; i++)
            str += _columns[i] + ",";

        str += _columns[lastIndex];

        return str;

    }
    string format(TableRow row)
    {
        string str = "";
        int lastIndex = columns.Count - 1;

        for (int i = 0; i < lastIndex; i++)
            str += row.getObject(columns[i]) + ",";

        str += row.getObject(columns[lastIndex]);

        return str;

    }
}