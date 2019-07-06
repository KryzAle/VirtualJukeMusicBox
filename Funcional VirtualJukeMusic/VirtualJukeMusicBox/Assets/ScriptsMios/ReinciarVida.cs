using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Mono.Data.Sqlite;
using System.Data;

public class ReinciarVida : MonoBehaviour
{
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
        string conn = "URI=file:" + Application.dataPath + "/Plugins/Datos.db"; //Path to database.
        IDbConnection dbconn;
        dbconn = (IDbConnection)new SqliteConnection(conn);
        dbconn.Open(); //Open connection to the database.
        IDbCommand dbcmd = dbconn.CreateCommand();
        string sqlQuery = "INSERT INTO Persona (nick,score) VALUES ('" + nombre + "','" + puntos +"')";
        dbcmd.CommandText = sqlQuery;

        if (dbcmd.ExecuteNonQuery() == 1)
        {
            Debug.Log("se guardo" + nombre + "','" + puntos);

        }
        else
        {
            Debug.Log("no se guardo ni madres");
        }

        dbcmd.Dispose();
        dbcmd = null;
        dbconn.Close();
        dbconn = null;
    }
}
