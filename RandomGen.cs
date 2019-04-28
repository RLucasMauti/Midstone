using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomGen : MonoBehaviour
{
    public string numbers;
    public string[] numbersArray;
    public int randomNumber;
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
        string path = "Assets/numberstrytwo.txt";

        StreamReader reader = new StreamReader(path);
        numbers = reader.ReadToEnd().ToString();
        reader.Close();
        numbersArray = numbers.Split("\t"[0]);
        //Debug.Log(numbersArray.Length);
    }

    int GetRandom()
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

        Debug.Log(quality + manufacturer + item);
    }
}
