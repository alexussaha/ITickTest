using UnityEngine;
using Homebrew;

public class BigShip : MonoBehaviour, ITick {

    public void Awake()
    {
        var mngUpdate = Toolbox.Get<ManagerUpdate>();

        mngUpdate.ticks.Add(this as ITick);
    }
    public void Tick()
    {
        Debug.Log("I'm a zombie");

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Toolbox.Get<ManagerEvents>().CreatePrefab(Random.insideUnitSphere * Random.Range(-10, 10));
        }
    }


}
