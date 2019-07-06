using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class bd : MonoBehaviour
{
   
    public GameObject content;
    public GameObject listaPrefab;
    // Start is called before the first frame update
    void Start()
    {
        Listar();
    }
    public void Listar()
    {
        while (content.transform.childCount > 0)
        {
            Transform c = content.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }
        string conn = "URI=file:" + Application.dataPath + "/Plugins/Datos.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT * FROM Persona";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();

        while (reader.Read())
        {
            string nick = reader.GetString(1);
            double score = reader.GetDouble(2);

            GameObject go = (GameObject)Instantiate(listaPrefab);
            go.transform.SetParent(content.transform);
            go.transform.Find("nicklb").GetComponent<Text>().text = nick;
            go.transform.Find("scorelb").GetComponent<Text>().text = score.ToString();

        }

        reader.Close();
        reader = null;
        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
   
    // Update is called once per frame
    void Update()
    {

    }
}
