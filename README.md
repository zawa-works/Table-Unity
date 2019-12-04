# Table Class
- Unityでcsvファイルを書き出すクラス
- Processingの[Tableクラス](https://processing.org/reference/Table.html)を参考に作成(※若干違うので注意)
- 読み込みは随時作成中

## Sample
サンプルは`Assets/Scripts/Sample/TableSample.cs`に書いてある

```c#
Table table = new Table();

table.addColumn("name");
table.addColumn("x");
table.addColumn("y");

TableRow newRow = new TableRow();
newRow.setString("username", "jon");
newRow.setInt("intValue", Random.Range(0, 10));
newRow.setFloat("floatValue", Random.Range(0.0f, 10.0f));
table.addRow(newRow);

table.save("data/hoge.csv");//Assetsのなかのdataフォルダに追加される
```