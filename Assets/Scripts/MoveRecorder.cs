using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public enum Action
{
    Move,
    Ability,
    Still,
}

public class MoveRecorder : MonoBehaviour
{

    private List<Action[]> moves;
    private List<int[][]> targets;
    private List<int[]> spawns;
    private List<EntityTypes> units;
    private List<int[][]> positions;
    private int maxDays = 5;
    private int year = -1;
    private TextMeshProUGUI yearLabel;

    // Start is called before the first frame update
    void Start()
    {
        moves = new List<Action[]>();
        targets = new List<int[][]>();
        spawns = new List<int[]>();
        units = new List<EntityTypes>();
        positions = new List<int[][]>();
        yearLabel = GameObject.Find("Year Label").GetComponent<TextMeshProUGUI>();
        newYear();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void newYear()
    {
        moves.Add(new Action[maxDays]);
        for (int i = 0; i < maxDays; i++)
        {
            moves[year + 1][i] = Action.Still;
        }
        year = year + 1;
        yearLabel.SetText("Year " + (year + 1).ToString());
    }

    public void setDay(int d, Action act)
    {
        setDay(year, d, act);
    }

    public void setDay(int y, int d, Action act)
    {
        moves[y][d] = act;
    }

    public void setSpawn(int x, int y, EntityTypes un)
    {
        setSpawn(year, x, y, un);
    }

    public void setSpawn(int yrs, int x, int y, EntityTypes un)
    {
        spawns[yrs][0] = x;
        spawns[yrs][1] = y;
        units[yrs] = un;
    }

    public void setPosition(int d, int x, int y)
    {
        setPosition(year, d, x, y);
    }

    public void setPosition(int yrs, int d, int x, int y)
    {
        positions[yrs][d][0] = x;
        positions[yrs][d][1] = y;
    }

    public void setTarget(int d, int x, int y)
    {
        setTarget(year, d, x, y);
    }

    public void setTarget(int yrs, int d, int x, int y)
    {
        targets[yrs][d][0] = x;
        targets[yrs][d][1] = y;
    }

    public Action getDay(int y, int d)
    {
        return moves[y][d];
    }

    public Action[] getYear(int y)
    {
        return moves[y];
    }

    public int[] getSpawn(int y)
    {
        return spawns[y];
    }

    public int[] getPosition(int y, int d)
    {
        return positions[y][d];
    }

    public int[] getTarget(int y, int d)
    {
        return targets[y][d];
    }

    public EntityTypes getPosition(int y)
    {
        return units[y];
    }
}