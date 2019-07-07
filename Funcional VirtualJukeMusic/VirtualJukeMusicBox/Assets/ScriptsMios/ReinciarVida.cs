using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;
//References
using System.IO;

public class ReinciarVida : MonoBehaviour
{
    private string conn, sqlQuery;
    IDbConnection dbconn;
    IDbCommand dbcmd;
    private IDataReader reader;
    string DatabaseName = "Employers.s3db";
    // Start is called before the first frame update
    public int aciertos = 0;
    public int score = 0;
    public GameObject explosion1;
    public GameObject explosion2;
    public GameOver game;
    public Text textoPunto;
    public Text textoName;
    public string[] nicknames = new string[6]{ "DinoJukebox", "KellyBum", "MrElite", "BumMaster", "DaPro","Dapawn"};



void Start()
    {
        //unity comentale para ejecutar
        string filepath = Application.dataPath + "/Plugins/" + DatabaseName;

        //open db connection
        conn = "URI=file:" + filepath;

        Debug.Log("Stablishing connection to: " + conn);
        dbconn = new SqliteConnection(conn);
        dbconn.Open();
        //android descomentale para ejecutar
        /*string filepath = Application.persistentDataPath + "/" + DatabaseName;
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
        //Lo que hiciste
        ActualizarMarcadorPuntos();

        System.Random rnd = new System.Random();

        int numeroRandom = rnd.Next(5);
        //Debug.Log("hellopapu"+numeroRandom);

        textoName.text = nicknames[numeroRandom];
    }
    void ActualizarMarcadorPuntos() {
        textoPunto.text = "Puntos: " +score;
            
    }

    // Update is called once per frame
    void Update()
    {
        if (aciertos == 5)
        {
            game.Reiciar();
            aciertos = 0;
        }
    }
    void OnCollisionEnter(Collision otherObj)
    {
        if (otherObj.gameObject.CompareTag("cubo1"))
        {
            Instantiate(explosion1, transform.position, otherObj.transform.rotation);
            Destroy(otherObj.gameObject, .01f);
            aciertos++;
            score++;
            ActualizarMarcadorPuntos();
        }
        if (otherObj.gameObject.CompareTag("cubo2"))
        {
            Instantiate(explosion2, transform.position, otherObj.transform.rotation);
            Destroy(otherObj.gameObject, .01f);
            aciertos++;
            score++;
            ActualizarMarcadorPuntos();
        }

    }
    public void Guardar(string nombre,int puntos)
    {
        //unity Comentale para compilar
        using (dbconn = new SqliteConnection(conn))
        {
            dbconn.Open(); //Open connection to the database.
            dbcmd = dbconn.CreateCommand();
            sqlQuery = string.Format("insert into Staff (nick, score) values (\"{0}\",\"{1}\")", nombre, puntos);// table name
            dbcmd.CommandText = sqlQuery;
            dbcmd.ExecuteScalar();
            dbconn.Close();
        }

    }
}
