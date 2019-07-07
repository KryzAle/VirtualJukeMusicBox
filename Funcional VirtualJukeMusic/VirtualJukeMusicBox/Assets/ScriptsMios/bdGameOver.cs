using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;
//references
using System.IO;
public class bdGameOver : MonoBehaviour
{
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    private IDataReader reader;

    string DatabaseName = "Employers.s3db";
    public Text score;
    
    // Start is called before the first frame update
    void Start()
    {
        //android descomentale para ejecutar
        /* string filepath = Application.persistentDataPath + "/" + DatabaseName;
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
        query = "CREATE TABLE Staff (ID INTEGER PRIMARY KEY   AUTOINCREMENT, nick varchar(100), score varchar(200))";
        try
        {
            dbcmd = dbconn.CreateCommand(); // create empty command
            dbcmd.CommandText = query; // fill the command
            reader = dbcmd.ExecuteReader(); // execute command which returns a reader
        }
        catch (Exception e)
        {

            Debug.Log(e);

        }*/
        //unity comentale para compilar
        string filepath = Application.dataPath + "/Plugins/" + DatabaseName;

        //open db connection
        conn = "URI=file:" + filepath;

        Debug.Log("Stablishing connection to: " + conn);
        dbconn = new SqliteConnection(conn);
        dbconn.Open();
        Listar();
    }
    public void Listar()
    {
        double  scorelb;
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            IDbCommand dbcmd = dbconn.CreateCommand();
            string sqlQuery = "SELECT MAX(id),* FROM Staff";// table name
            dbcmd.CommandText = sqlQuery;
            IDataReader reader = dbcmd.ExecuteReader();
            while (reader.Read())
            {
                scorelb = reader.GetDouble(3);
                Debug.Log("score = " + scorelb.ToString());
                score.text = scorelb.ToString();
            }
            reader.Close();
            reader = null;
            dbcmd.Dispose();
            dbcmd = null;
            dbconn.Close();
        }
            
    }

    // Update is called once per frame
    void Update()
    {

    }
}
