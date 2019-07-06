using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mono.Data.Sqlite;
using System.Data;
using System;
using UnityEngine.UI;

public class bdGameOver : MonoBehaviour
{
    public Text score;
    
    // Start is called before the first frame update
    void Start()
    {
        Listar();
    }
    public void Listar()
    {
       
        string conn = "URI=file:" + Application.dataPath + "/Plugins/Datos.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "SELECT MAX(id),* FROM Persona";
        dbcmd.CommandText = sqlQuery;
        IDataReader reader = dbcmd.ExecuteReader();

        while (reader.Read())
        {
            
            double scorelb = reader.GetDouble(3);

            score.text = scorelb.ToString();

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
