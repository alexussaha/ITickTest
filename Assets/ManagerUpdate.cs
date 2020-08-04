using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ManagerUpdate", menuName = "Managers/ManagerUpdate")]
public class ManagerUpdate : ManagerBase, IAwake
{
    // Start is called before the first frame update
    public List<ITick> ticks = new List<ITick>();

    public static void AddTo(object updateble)
    {

        var mngUpdate = Toolbox.Get<ManagerUpdate>();

        if (updateble is ITick)
            mngUpdate.ticks.Add(updateble as ITick);

    }
    public static void RemoveFrom(object updateble)
    {

        var mngUpdate = Toolbox.Get<ManagerUpdate>();
        if (updateble is ITick)
            mngUpdate.ticks.Remove(updateble as ITick);


    }


    public void Tick()
    {
        foreach (var t in ticks)
        {
            t.Tick();
        }
    }


    public void OnAwake()
    {
        GameObject.Find("SETUP").AddComponent<ManagerUpdateComponent>().Setup(this);
    }

}
