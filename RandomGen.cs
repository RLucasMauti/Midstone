using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class RandomGen : MonoBehaviour
{
    public int commonMax;
    public int uncommonMax;
    public int rareMax;
    public int legendaryMax;
    public bool droppedNotSpawned;

    public string numbers;
    public string[] numbersArray;
    public int randomNumber;
    public GameObject common;
    public GameObject uncommon;
    public GameObject rare;
    public GameObject legendary;
    public Transform dropPoint;
    public Transform playerDropPoint;
    public Transform playerPos;
    public Mesh cube;
    public Mesh sphere;
    public Mesh capsule;
    public Mesh cylinder;

    public Sprite commonGun;
    public Sprite commonGrenade;
    public Sprite commonRelic;
    public Sprite commonShield;

    public Sprite uncommonGun;
    public Sprite uncommonGrenade;
    public Sprite uncommonRelic;
    public Sprite uncommonShield;

    public Sprite rareGun;
    public Sprite rareGrenade;
    public Sprite rareRelic;
    public Sprite rareShield;

    public Sprite LegendaryGun;
    public Sprite LegendaryGrenade;
    public Sprite LegendaryRelic;
    public Sprite LegendaryShield;

    // Start is called before the first frame update
    void Start()
    { 
        ReadFile();

        commonMax = 600;
        uncommonMax = 800;
        rareMax = 950;
        legendaryMax = 1000;

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

    public void DropFromInv(string invtext)
    {
        string[] tempArray = invtext.Split(" "[0]);
        droppedNotSpawned = true;

        if (tempArray[0] == "Common")
        {
            common.GetComponentInChildren<TextMesh>().text = invtext;
            if (tempArray[2] == "Gun")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = cylinder;
                common.GetComponent<DestroyAfterTime>().image = commonGun;
            }
            else if (tempArray[2] == "Shield")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = sphere;
                common.GetComponent<DestroyAfterTime>().image = commonShield;
            }
            else if (tempArray[2] == "Relic")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = cube;
                common.GetComponent<DestroyAfterTime>().image = commonRelic;
            }
            else if (tempArray[2] == "Grenade")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = capsule;
                common.GetComponent<DestroyAfterTime>().image = commonGrenade;
            }
            Vector3 dropDir = playerDropPoint.position - playerPos.position;
            //Debug.Log(dropDir);
            common.GetComponent<Rigidbody>().velocity = new Vector3(dropDir.x * 80.0f, 0.0f, dropDir.z * 80.0f);
            Instantiate(common, playerDropPoint.position, playerPos.rotation);
        }
        else if (tempArray[0] == "Uncommon")
        {
            uncommon.GetComponentInChildren<TextMesh>().text = invtext;
            if (tempArray[2] == "Gun")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = cylinder;
                uncommon.GetComponent<DestroyAfterTime>().image = uncommonGun;
            }
            else if (tempArray[2] == "Shield")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = sphere;
                uncommon.GetComponent<DestroyAfterTime>().image = uncommonShield;
            }
            else if (tempArray[2] == "Relic")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = cube;
                uncommon.GetComponent<DestroyAfterTime>().image = uncommonRelic;
            }
            else if (tempArray[2] == "Grenade")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = capsule;
                uncommon.GetComponent<DestroyAfterTime>().image = uncommonGrenade;
            }
            Vector3 dropDir = playerDropPoint.position - playerPos.position;
            uncommon.GetComponent<Rigidbody>().velocity = dropDir;
            Instantiate(uncommon, playerDropPoint.position, playerPos.rotation);
        }
        else if (tempArray[0] == "Rare")
        {
            rare.GetComponentInChildren<TextMesh>().text = invtext;
            if (tempArray[2] == "Gun")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = cylinder;
                rare.GetComponent<DestroyAfterTime>().image = rareGun;
            }
            else if (tempArray[2] == "Shield")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = sphere;
                rare.GetComponent<DestroyAfterTime>().image = rareShield;
            }
            else if (tempArray[2] == "Relic")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = cube;
                rare.GetComponent<DestroyAfterTime>().image = rareRelic;
            }
            else if (tempArray[2] == "Grenade")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = capsule;
                rare.GetComponent<DestroyAfterTime>().image = rareGrenade;
            }
            Vector3 dropDir = playerDropPoint.position - playerPos.position;
            rare.GetComponent<Rigidbody>().velocity = dropDir;
            Instantiate(rare, playerDropPoint.position, playerPos.rotation);
        }
        else if (tempArray[0] == "Legendary")
        {
            legendary.GetComponentInChildren<TextMesh>().text = invtext;
            if (tempArray[2] == "Gun")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = cylinder;
                legendary.GetComponent<DestroyAfterTime>().image = LegendaryGun;
            }
            else if (tempArray[2] == "Shield")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = sphere;
                legendary.GetComponent<DestroyAfterTime>().image = LegendaryShield;
            }
            else if (tempArray[2] == "Relic")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = cube;
                legendary.GetComponent<DestroyAfterTime>().image = LegendaryRelic;
            }
            else if (tempArray[2] == "Grenade")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = capsule;
                legendary.GetComponent<DestroyAfterTime>().image = LegendaryGrenade;
            }
            Vector3 dropDir = playerDropPoint.position - playerPos.position;
            legendary.GetComponent<Rigidbody>().velocity = dropDir;
            Instantiate(legendary, playerDropPoint.position, playerPos.rotation);
        }
        else
        {

        }
    }

    void DropItem()
    {
        string item = " ";
        string quality = " ";
        string manufacturer = " ";
        droppedNotSpawned = false;

        int value = GetRandom();
        if (value < 500)
        {
            item = "Gun ";
            value = GetRandom();
            if (value < commonMax)
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
            else if (value >= commonMax && value < uncommonMax)
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
            else if (value >= uncommonMax && value < rareMax)
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
            else if (value >= rareMax && value <= legendaryMax)
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
            item = "Shield ";
            value = GetRandom();
            if (value < commonMax)
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
            else if (value >= commonMax && value < uncommonMax)
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
            else if (value >= uncommonMax && value < rareMax)
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
            else if (value >= rareMax && value <= legendaryMax)
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
        else if (value >= 750 && value < 850)
        {
            item = "Relic ";
            value = GetRandom();
            if (value < commonMax)
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
            else if (value >= commonMax && value < uncommonMax)
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
            else if (value >= uncommonMax && value < rareMax)
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
            else if (value >= rareMax && value <= legendaryMax)
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
        else if (value >= 850 && value < 1000)
        {
            item = "Grenade Mod ";
            value = GetRandom();
            if (value < commonMax)
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
            else if (value >= commonMax && value < uncommonMax)
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
            else if (value >= uncommonMax && value < rareMax)
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
            else if (value >= rareMax && value <= legendaryMax)
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
            common.GetComponentInChildren<TextMesh>().text = quality + manufacturer + item;
            if (item == "Grenade Mod ")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = capsule;
                common.GetComponent<DestroyAfterTime>().image = commonGrenade;
            }
            else if (item == "Shield ")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = sphere;
                common.GetComponent<DestroyAfterTime>().image = commonShield;
            }
            else if (item == "Gun ")
            {
                common.GetComponentInChildren<MeshFilter>().mesh = cylinder;
                common.GetComponent<DestroyAfterTime>().image = commonGun;
            }
            else
            {
                common.GetComponentInChildren<MeshFilter>().mesh = cube;
                common.GetComponent<DestroyAfterTime>().image = commonRelic;
            }
            Instantiate(common, dropPoint);
        }
        else if (quality == "Uncommon ")
        {
            uncommon.GetComponentInChildren<TextMesh>().text = quality + manufacturer + item;
            if (item == "Grenade Mod ")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = capsule;
                uncommon.GetComponent<DestroyAfterTime>().image = uncommonGrenade;
            }
            else if (item == "Shield ")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = sphere;
                uncommon.GetComponent<DestroyAfterTime>().image = uncommonShield;
            }
            else if (item == "Gun ")
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = cylinder;
                uncommon.GetComponent<DestroyAfterTime>().image = uncommonGun;
            }
            else
            {
                uncommon.GetComponentInChildren<MeshFilter>().mesh = cube;
                uncommon.GetComponent<DestroyAfterTime>().image = uncommonRelic;
            }
            Instantiate(uncommon, dropPoint);
        }
        else if (quality == "Rare ")
        {
            rare.GetComponentInChildren<TextMesh>().text = quality + manufacturer + item;
            if (item == "Grenade Mod ")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = capsule;
                rare.GetComponent<DestroyAfterTime>().image = rareGrenade;
            }
            else if (item == "Shield ")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = sphere;
                rare.GetComponent<DestroyAfterTime>().image = rareShield;
            }
            else if (item == "Gun ")
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = cylinder;
                rare.GetComponent<DestroyAfterTime>().image = rareGun;
            }
            else
            {
                rare.GetComponentInChildren<MeshFilter>().mesh = cube;
                rare.GetComponent<DestroyAfterTime>().image = rareRelic;
            }
            Instantiate(rare, dropPoint);
        }
        else
        {
            legendary.GetComponentInChildren<TextMesh>().text = quality + manufacturer + item;
            if (item == "Grenade Mod ")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = capsule;
                legendary.GetComponent<DestroyAfterTime>().image = LegendaryGrenade;
            }
            else if (item == "Shield ")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = sphere;
                legendary.GetComponent<DestroyAfterTime>().image = LegendaryShield;
            }
            else if (item == "Gun ")
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = cylinder;
                legendary.GetComponent<DestroyAfterTime>().image = LegendaryGun;
            }
            else
            {
                legendary.GetComponentInChildren<MeshFilter>().mesh = cube;
                legendary.GetComponent<DestroyAfterTime>().image = LegendaryRelic;
            }
            Instantiate(legendary, dropPoint);
        }
        

        Debug.Log(quality + manufacturer + item);
        
    }
}
