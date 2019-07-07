using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//References
using Mono.Data.Sqlite;
using System;
using System.Data;
using System.IO;
using UnityEngine.UI;
public class Android : MonoBehaviour
{
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    private IDataReader reader;
    public GameObject content;
    public GameObject listaPrefab;

    string DatabaseName = "Employers.s3db";
    // Start is called before the first frame update
    void Start()
    {
        //Application database Path android
        string filepath = Application.persistentDataPath + "/" + DatabaseName;
        if (!File.Exists(filepath))
        {
            // If not found on android will create Tables and database

            Debug.LogWarning("File \"" + filepath + "\" does not exist. Attempting to create from \"" +
                             Application.dataPath + "!/assets/Employers");

            // UNITY_ANDROID
            WWW loadDB = new WWW("jar:file://" + Application.dataPath + "!/assets/Employers.s3db");
            while (!loadDB.isDone) { }
            // then save to Application.persistentDataPath
            File.WriteAllBytes(filepath, loadDB.bytes);
        }

        conn = "URI=file:" + filepath;

        Debug.Log("Stablishing connection to: " + conn);
        dbconn = new SqliteConnection(conn);
        dbconn.Open();

        string query;
        query = "CREATE TABLE Staff (ID INTEGER PRIMARY KEY   AUTOINCREMENT, nick varchar(100), score NUMERIC)";
        try
        {
            dbcmd = dbconn.CreateCommand(); // create empty command
            dbcmd.CommandText = query; // fill the command
            reader = dbcmd.ExecuteReader(); // execute command which returns a reader
        }
        catch (Exception e)
        {

            Debug.Log(e);

        }
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
        string nick;
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
                // idreaders = reader.GetString(1);
                nick = reader.GetString(1);
                score = reader.GetDouble(2);

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
            //       dbconn = null;

        }
    }
    // Update is called once per frame
    void Update()
    {

    }
}
