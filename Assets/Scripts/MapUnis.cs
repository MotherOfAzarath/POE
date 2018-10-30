using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


[Serializable]
public class MapUnis: Map
{
    Map map;
    public MapSize mapSize1;
    int Turn = 0;
    Random r = new Random();

    int SIZE = 45;

    map = new Map(mapSize1.Size(), mapSize1.Size(), 30, 10);

    private void DisplayMap()
    {

        foreach (Unit u in map.Units)
        {
            if (u.GetType() == typeof(MeeleeUnit))
            {
                MeeleeUnit m = (MeeleeUnit)u;
            }

        }
        foreach (Unit u in map.Units)
        {
            if (u.GetType() == typeof(RangedUnit))
            {
                RangedUnit m = (RangedUnit)u;
            }

        }

        foreach (Unit u in map.Units)
        {
            if (u.GetType() == typeof(WarlockUnit))
            {
                WarlockUnit w = (WarlockUnit)u;

            }

        }

        foreach (Building b in map.Buildings)
        {
            if (b.GetType() == typeof(FactoryBuilding))
            {

                FactoryBuilding m = (FactoryBuilding)b;
            }
        }

        foreach (Building b in map.Buildings)
        {
            if (b.GetType() == typeof(ResourceBuilding))
            {
                ResourceBuilding m = (ResourceBuilding)b;

            }
        }
    }
}
