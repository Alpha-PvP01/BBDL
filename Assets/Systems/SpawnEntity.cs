using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leopotam.EcsLite;

public class SpawnEntity : IEcsInitSystem
{
    public void Init(IEcsSystems systems)
    {
        var ecsWorld = systems.GetWorld();
        var entity = ecsWorld.NewEntity();
        var entityPool = ecsWorld.GetPool<Entity>();
     //   GameObject etityGO = Object.Instantiate(entityPool.entityPrefab)
    }
}
