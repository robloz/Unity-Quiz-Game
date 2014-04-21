using UnityEngine;
using System.Collections;

public class LoadSequenceMesh
{
    GameObject[] secuencia_modelos;
    public Material material;

    public void Load(string ruta_nombre, int tam, int index_start)
    {
        secuencia_modelos = new GameObject[tam];
        for (int i = index_start; i < tam + index_start; i++)
        {
            string ruta_completa = ruta_nombre;
            if (i < 10)
                ruta_completa += "0";
            ruta_completa += i.ToString();
            secuencia_modelos[i - index_start] = Resources.Load(ruta_completa) as GameObject;
        }
    }

    public GameObject GetModel(int index)
    {
        return secuencia_modelos[index];
    }

    public int Count()
    {
        return secuencia_modelos.Length;
    }
}