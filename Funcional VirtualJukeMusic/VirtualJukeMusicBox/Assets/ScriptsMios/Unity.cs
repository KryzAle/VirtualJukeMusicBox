using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//References
using Mono.Data.Sqlite;
using System;
using System.Data;
using System.IO;
using UnityEngine.UI;
public class Unity : MonoBehaviour
{
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    private IDataReader reader;
    public GameObject content;
    public GameObject listaPrefab;

    string DatabaseName = "Employers.s3db";

    void Start()
    {

        string filepath = Application.dataPath + "/Plugins/" + DatabaseName;

        //open db connection
        conn = "URI=file:" + filepath;

        Debug.Log("Stablishing connection to: " + conn);
        dbconn = new SqliteConnection(conn);
        dbconn.Open();

        reader_function();
    }
   
    //Read All Data For To Database
    private void reader_function()
    {
        while (content.transform.childCount > 0)
        {
            Transform c = content.transform.GetChild(0);
            c.SetParent(null);
            Destroy(c.gameObject);
        }
        string nick, tiempo, mapa;
        double score;
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "SELECT * FROM Staff ORDER BY(score) DESC LIMIT 6";// table name
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                nick = reader.GetString(1);
                score = reader.GetDouble(2);
                tiempo = reader.GetString(3);
                mapa = reader.GetString(4);
                GameObject go = (GameObject)Instantiate(listaPrefab);
                go.transform.SetParent(content.transform);
                go.transform.Find("nicklb").GetComponent<Text>().text = nick;
                go.transform.Find("scorelb").GetComponent<Text>().text = score.ToString();
                go.transform.Find("tiempolb").GetComponent<Text>().text = tiempo;
                go.transform.Find("mapalb").GetComponent<Text>().text = mapa;
            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
            //       dbconn = null;

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
