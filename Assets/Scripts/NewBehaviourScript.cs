using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class NewBehaviourScript : MonoBehaviour
{
    //public Text txtTexts;

    //public GameObject blueMeelee;
    //public GameObject redMeelee;
    //public GameObject blueRanged;
    //public GameObject redRanged;
    //public GameObject blueWarlock;
    //public GameObject redWarlock;
    //public GameObject redBuilding;
    //public GameObject blueBuilding;
    //public GameObject redFactory;
    //public GameObject blueFactory;
    //public GameObject body;
    //public GameObject ground;

    //Map map;
    //int Turn = 0;
    //Random r = new Random();

    //// Use this for initialization
    //void Start()
    //{
    //    map = new Map(20, 20, 20, 20);
    //    Application.targetFrameRate = 1;
    //    Display();
    //}

    //// Update is called once per frame
    //void Update()
    //{
    //    Destroy();
    //    UpdateMap();
    //    Display();
    //    Click();
    //}

    //private void DisplayMap()
    //{
    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(MeeleeUnit))
    //        {
    //            MeeleeUnit m = (MeeleeUnit)u;

    //            if (m.faction == 1)
    //            {
    //                GameObject clone = Instantiate(blueMeelee, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            else if (m.faction == 0)
    //            {
    //                GameObject clone = Instantiate(redMeelee, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            else
    //            {
    //                GameObject clone = Instantiate(ground, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            if (m.isDead())
    //            {
    //                GameObject clone = Instantiate(body, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //        }
    //    }
    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(RangedUnit))
    //        {

    //            RangedUnit m = (RangedUnit)u;

    //            if (m.faction == 1)
    //            {
    //                GameObject clone = Instantiate(redRanged, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            else if (m.faction == 0)
    //            {
    //                GameObject clone = Instantiate(blueRanged, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            else
    //            {
    //                GameObject clone = Instantiate(ground, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            if (m.isDead())
    //            {
    //                GameObject clone = Instantiate(body, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }

    //        }

    //    }

    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(WarlockUnit))
    //        {
    //            WarlockUnit w = (WarlockUnit)u;
               
    //            if (w.faction == 1)
    //            {
    //                GameObject clone = Instantiate(redWarlock, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            else
    //            {
    //                GameObject clone = Instantiate(blueWarlock, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            if (w.isDead())
    //            {
    //                GameObject clone = Instantiate(body, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }

    //        }

    //    }

    //    foreach (Building b in map.Buildings)
    //    {
    //        if (b.GetType() == typeof(FactoryBuilding))
    //        {

    //            FactoryBuilding m = (FactoryBuilding)b;

    //            if (m.faction == 1)
    //            {
    //                GameObject clone = Instantiate(redFactory, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            else
    //            {
    //                GameObject clone = Instantiate(blueFactory, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            if (m.isDead())
    //            {
    //                GameObject clone = Instantiate(body, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }

    //        }
    //    }

    //    foreach (Building b in map.Buildings)
    //    {
    //        if (b.GetType() == typeof(ResourceBuilding))
    //        {

    //            ResourceBuilding m = (ResourceBuilding)b;

    //            if (m.faction == 1)
    //            {
    //                GameObject clone = Instantiate(redBuilding, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            else
    //            {
    //                GameObject clone = Instantiate(blueBuilding, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }
    //            if (m.isDead())
    //            {
    //                GameObject clone = Instantiate(body, new Vector2(m.PosX, m.PosY), Quaternion.identity);
    //                clone.transform.parent = transform;
    //            }

    //        }
    //    }
    //}

    //private void UpdateMap()
    //{
    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(MeeleeUnit))
    //        {
    //            MeeleeUnit m = (MeeleeUnit)u;
    //            if (m.health > 1)
    //            {
    //                if (m.health < 25)
    //                {
    //                    switch (r.Next(0, 4))
    //                    {
    //                        case 0: ((MeeleeUnit)u).NewPos(Direction.North); break;
    //                        case 1: ((MeeleeUnit)u).NewPos(Direction.East); break;
    //                        case 2: ((MeeleeUnit)u).NewPos(Direction.South); break;
    //                        case 3: ((MeeleeUnit)u).NewPos(Direction.West); break;
    //                    }
    //                }
    //                else if (m.health < 10)
    //                {
    //                    int teamChange = r.Next(0, 2);
    //                    if (teamChange == 0)
    //                    {
    //                        if (m.faction == 1)
    //                        {
    //                            m.faction = 0;
    //                            m.health = m.health + 5;
    //                        }
    //                        else
    //                        {
    //                            m.faction = 1;
    //                            m.health = m.health + 5;
    //                        }
    //                    }
    //                }
    //                else
    //                {
    //                    bool inCombat = false;
    //                    foreach (Unit e in map.Units)
    //                    {
    //                        if (u.withinRange(e))
    //                        {
    //                            u.combat(e);
    //                            inCombat = true;
    //                        }
    //                    }
    //                    if (!inCombat)
    //                    {
    //                        Unit c = u.distance(map.Units);
    //                        m.NewPos(m.Directionto(c));
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                m.symbol = body;
    //            }
    //        }


    //    }
    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(RangedUnit))
    //        {
    //            RangedUnit m = (RangedUnit)u;
    //            if (m.health > 1)
    //            {
    //                if (m.health < 25)
    //                {
    //                    switch (r.Next(0, 4))
    //                    {
    //                        case 0: ((RangedUnit)u).NewPos(Direction.North); break;
    //                        case 1: ((RangedUnit)u).NewPos(Direction.East); break;
    //                        case 2: ((RangedUnit)u).NewPos(Direction.South); break;
    //                        case 3: ((RangedUnit)u).NewPos(Direction.West); break;
    //                    }
    //                }
    //                else if (m.health < 10)
    //                {
    //                    int teamChange = r.Next(0, 2);
    //                    if (teamChange == 0)
    //                    {
    //                        if (m.faction == 1)
    //                        {
    //                            m.faction = 0;
    //                            m.health = m.health + 5;
    //                        }
    //                        else
    //                        {
    //                            m.faction = 1;
    //                            m.health = m.health + 5;
    //                        }
    //                    }
    //                }
    //                else
    //                {
    //                    bool inCombat = false;
    //                    foreach (Unit e in map.Units)
    //                    {
    //                        if (u.withinRange(e))
    //                        {
    //                            u.combat(e);
    //                            inCombat = true;
    //                        }
    //                    }
    //                    if (!inCombat)
    //                    {
    //                        Unit c = u.distance(map.Units);
    //                        m.NewPos(m.Directionto(c));
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                m.symbol = body;
    //            }
    //        }
    //    }

    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(WarlockUnit))
    //        {
    //            WarlockUnit w = (WarlockUnit)u;
    //            if (w.health > 1)
    //            {
    //                if (w.health < 25)
    //                {
    //                    switch (r.Next(0, 4))
    //                    {
    //                        case 0: ((WarlockUnit)u).NewPos(Direction.North); break;
    //                        case 1: ((WarlockUnit)u).NewPos(Direction.East); break;
    //                        case 2: ((WarlockUnit)u).NewPos(Direction.South); break;
    //                        case 3: ((WarlockUnit)u).NewPos(Direction.West); break;
    //                    }
    //                }

    //                else
    //                {
    //                    bool inCombat = false;
    //                    foreach (Unit e in map.Units)
    //                    {
    //                        if (u.withinRange(e))
    //                        {
    //                            u.combat(e);
    //                            inCombat = true;
    //                        }
    //                    }
    //                    if (!inCombat)
    //                    {
    //                        Unit c = u.distance(map.Units);
    //                        w.NewPos(w.Directionto(c));
    //                    }
    //                }
    //            }
    //            else
    //            {
    //                w.symbol = body;
    //            }
    //        }
    //    }

    //    foreach (Building b in map.Buildings)
    //    {
    //        if (b.GetType() == typeof(ResourceBuilding))
    //        {
    //            ResourceBuilding rb = (ResourceBuilding)b;
    //            rb.ResourceGenerate();
    //        }
    //    }

    //    foreach (Building b in map.Buildings)
    //    {
    //        if (b.GetType() == typeof(FactoryBuilding))
    //        {
    //            FactoryBuilding fb = (FactoryBuilding)b;
    //        }
    //    }

    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(MeeleeUnit))
    //        {
    //            MeeleeUnit mu = (MeeleeUnit)u;
    //            if (mu.symbol == body)
    //            {
    //                int faction = mu.faction;
    //                int rand = r.Next(0, 5);
    //                FactoryBuilding fb = (FactoryBuilding)map.Buildings[rand];
    //                fb.Spawner(20, 20, faction);
    //            }
    //        }
    //    }

    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(RangedUnit))
    //        {
    //            RangedUnit mu = (RangedUnit)u;
    //            if (mu.symbol == body)
    //            {
    //                int faction = mu.faction;
    //                int rand = r.Next(0, 5);
    //                FactoryBuilding fb = (FactoryBuilding)map.Buildings[rand];
    //                fb.Spawner(20, 20, faction);
    //            }
    //        }
    //    }
    //}

    //public void Destory()
    //{
    //    foreach(Transform child in transform)
    //    {
    //        Destory(child.gameObject);
    //    }
    //}

    //void changeText()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        txtTexts.text = "this is a test";
    //    }
    //}

    //public void stop()
    //{
    //    Time.timeScale = 0;
    //}

    //public void start()
    //{
    //    Time.timeScale = 1;
    //}

    //public void Click()
    //{
    //    int x = map.PosX;
    //    int Y = map.PosY;

    //    foreach (Unit u in map.Units)
    //    {
    //        if (u.GetType() == typeof(RangedUnit))
    //        {
    //            RangedUnit r = (RangedUnit)u;

    //            if (r.PosX == x && r.PosY == Y)
    //            {
    //                txtTexts.text = "" + m.toString;
    //            }
    //        }

    //        else if (u.GetType() == typeof(MeeleeUnit))
    //        {
    //            MeeleeUnit m = (MeeleeUnit)u;

    //            if (m.PosX == x && m.PosY == Y)
    //            {
    //                txtTexts.text = "" + m.toString();
    //            }
    //        }

    //        else if (u.GetType() == typeof(WarlockUnit))
    //        {
    //            WarlockUnit m = (WarlockUnit)u;

    //            if (m.PosX == x && m.PosY == Y)
    //            {
    //                txtTexts.text = "" + m.toString();
    //            }
    //        }
    //    }

    //    foreach (Building b in map.Buildings)
    //    {
    //        if (b.GetType() == typeof(FactoryBuilding))
    //        {
    //            FactoryBuilding fb = (FactoryBuilding)b;

    //            if (fb.PosX == x && fb.PosY == Y)
    //            {
    //                txtTexts.text = "" + fb.toString();
    //            }
    //        }

    //        else if (b.GetType() == typeof(ResourceBuilding))
    //        {
    //            ResourceBuilding rb = (ResourceBuilding)b;

    //            if (rb.PosX == x && rb.PosY == Y)
    //            {
    //                txtTexts.text = "" + rb.toString();
    //            }
    //        }
    //    }
    //}
}