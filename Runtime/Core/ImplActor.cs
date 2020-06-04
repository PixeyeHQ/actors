﻿using System.Runtime.CompilerServices;
using Unity.IL2CPP.CompilerServices;
using UnityEngine;

namespace Pixeye.Actors
{
  [Il2CppSetOption(Option.NullChecks | Option.ArrayBoundsChecks | Option.DivideByZeroChecks, false)]
  public class ImplActor : IRequireActorsLayer
  {
    LayerCore layer;

    void IRequireActorsLayer.Bootstrap(LayerCore layer)
    {
      this.layer = layer;
    }

    //===============================//
    // From string
    //===============================//

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Actor Create(string prefabID, Vector3 position = default, bool pooled = false)
    {
      var transform = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
      var       actor     = transform.AddGetActor();
      actor.isPooled = pooled;

      actor.Bootstrap(layer);
      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Actor Create(string prefabID, Transform parent, Vector3 position = default, bool pooled = false)
    {
      var transform =
        pooled ? Obj.Spawn(Pool.Entities, prefabID, parent, position) : Obj.Spawn(prefabID, parent, position);
      var actor = transform.AddGetActor();
      actor.isPooled = pooled;

      actor.Bootstrap(layer);
      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Actor Create(string prefabID, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      var transform = pooled ? Obj.Spawn(Pool.Entities, prefabID, position) : Obj.Spawn(prefabID, position);
      var       actor     = transform.AddGetActor();
      actor.isPooled = pooled;

      actor.Bootstrap(layer, model);
      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Actor Create(string prefabID, Transform parent, ModelComposer model, Vector3 position = default,
      bool pooled = false)
    {
      var transform = pooled
        ? Obj.Spawn(Pool.Entities, prefabID, parent, position)
        : Obj.Spawn(prefabID, parent, position);
      var actor = transform.AddGetActor();
      actor.isPooled = pooled;

      actor.Bootstrap(layer, model);
      return actor;
    }
 
    //===============================//
    // From prefab
    //===============================//
 
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Actor Create(GameObject prefab, Vector3 position = default, bool pooled = false)
    {
      var transform = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
      var       actor     = transform.AddGetActor();
      actor.isPooled = pooled;

      actor.Bootstrap(layer);
      return actor;
    }
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Actor Create(GameObject prefab, Transform parent, Vector3 position = default, bool pooled = false)
    {
      var transform =
        pooled ? Obj.Spawn(Pool.Entities, prefab, parent, position) : Obj.Spawn(prefab, parent, position);
      var actor = transform.AddGetActor();
      actor.isPooled = pooled;

      actor.Bootstrap(layer);
      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Actor Create(GameObject prefab, ModelComposer model, Vector3 position = default, bool pooled = false)
    {
      var transform = pooled ? Obj.Spawn(Pool.Entities, prefab, position) : Obj.Spawn(prefab, position);
      var       actor     = transform.AddGetActor();
      actor.isPooled = pooled;

      actor.Bootstrap(layer, model);
      return actor;
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public Actor Create(GameObject prefab, Transform parent, ModelComposer model, Vector3 position = default,
      bool pooled = false)
    {
      var transform =
        pooled ? Obj.Spawn(Pool.Entities, prefab, parent, position) : Obj.Spawn(prefab, parent, position);
      var actor = transform.AddGetActor();
      actor.isPooled = pooled;

      actor.Bootstrap(layer, model);
      return actor;
    }
  }
}