using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomGen : MonoBehaviour
{
    public string numbers;
    public string[] numbersArray;
    public int randomNumber;
    public GameObject common;
    public GameObject uncommon;
    public GameObject rare;
    public GameObject legendary;
    public Transform dropPoint;
    public Mesh cube;
    public Mesh sphere;
    public Mesh capsule;
    public Mesh cylinder;

    // Start is called before the first frame update
    void Start()
    { 
        ReadFile();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            DropItem();
        }
    }

    void ReadFile()
    {
        string path = "Assets/numberstrythree.txt";

        StreamReader reader = new StreamReader(path);
        numbers = reader.ReadToEnd().ToString();
        reader.Close();
        numbersArray = numbers.Split("\n"[0]);
        //for (int i = 0; i < numbersArray.Length; i++)
        //{
        //    //Debug.Log(numbersArray[i]);
        //}
        ////Debug.Log(numbersArray.Length);
    }

    public int GetRandom()
    {
        int temp = Random.Range(1, 1000);
        //Debug.Log(numbersArray[temp]);
        
        randomNumber = int.Parse(numbersArray[temp]);
        return randomNumber;
    }

    void DropItem()
    {
        string item = " ";
        string quality = " ";
        string manufacturer = " ";
        float x, y, z;
        x = GetRandom() / 10.0f;
        y = GetRandom() / 10.0f;
        z = GetRandom() / 10.0f;
        Vector3 newVel = new Vector3(x, y, z);

        int value = GetRandom();
        if (value < 250)
        {
            item = "Gun ";
            value = GetRandom();
            if (value < 250)
            {
                quality = "Common ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 250 && value < 500)
            {
                quality = "Uncommon ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 500 && value < 750)
            {
                quality = "Rare ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 750 && value < 1000)
            {
                quality = "Legendary ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
        }
        else if (value >= 250 && value < 500)
        {
            item = "Shield ";
            value = GetRandom();
            if (value < 250)
            {
                quality = "Common ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 250 && value < 500)
            {
                quality = "Uncommon ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 500 && value < 750)
            {
                quality = "Rare ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 750 && value < 1000)
            {
                quality = "Legendary ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
        }
        else if (value >= 500 && value < 750)
        {
            item = "Relic ";
            value = GetRandom();
            if (value < 250)
            {
                quality = "Common ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 250 && value < 500)
            {
                quality = "Uncommon ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 500 && value < 750)
            {
                quality = "Rare ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 750 && value < 1000)
            {
                quality = "Legendary ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
        }
        else if (value >= 750 && value < 1000)
        {
            item = "Grenade Mod ";
            value = GetRandom();
            if (value < 250)
            {
                quality = "Common ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 250 && value < 500)
            {
                quality = "Uncommon ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 500 && value < 750)
            {
                quality = "Rare ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
            else if (value >= 750 && value < 1000)
            {
                quality = "Legendary ";
                value = GetRandom();
                if (value < 250)
                {
                    manufacturer = "Torgue ";
                }
                else if (value >= 250 && value < 500)
                {
                    manufacturer = "Maliwan ";
                }
                else if (value >= 500 && value < 750)
                {
                    manufacturer = "Tediore ";
                }
                else if (value >= 750 && value < 1000)
                {
                    manufacturer = "Jakobs ";
                }
            }
        }


        if (quality == "Common ")
        {
            common.GetComponentInChildren<TextMesh>().text = manufacturer + item;
            if (item == "Grenade Mod ")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = capsule;
            }
            else if (item == "Shield ")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = sphere;
            }
            else if (item == "Gun ")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = cylinder;
            }
            else
            {
                common.GetComponentInChildren<MeshFilter>().mesh = cube;
            }
            Instantiate(common, dropPoint);
        }
        else if (quality == "Uncommon ")
        {
            uncommon.GetComponentInChildren<TextMesh>().text = manufacturer + item;
            if (item == "Grenade Mod ")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = capsule;
            }
            else if (item == "Shield ")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = sphere;
            }
            else if (item == "Gun ")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = cylinder;
            }
            else
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = cube;
            }
            Instantiate(uncommon, dropPoint);
        }
        else if (quality == "Rare ")
        {
            rare.GetComponentInChildren<TextMesh>().text = manufacturer + item;
            if (item == "Grenade Mod ")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = capsule;
            }
            else if (item == "Shield ")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = sphere;
            }
            else if (item == "Gun ")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = cylinder;
            }
            else
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = cube;
            }
            Instantiate(rare, dropPoint);
        }
        else
        {
            legendary.GetComponentInChildren<TextMesh>().text = manufacturer + item;
            if (item == "Grenade Mod ")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = capsule;
            }
            else if (item == "Shield ")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = sphere;
            }
            else if (item == "Gun ")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = cylinder;
            }
            else
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = cube;
            }
            Instantiate(legendary, dropPoint);
        }
        

        Debug.Log(quality + manufacturer + item);
        
    }
}
