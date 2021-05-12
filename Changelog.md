## Changelog 
### Actors-2020-06-05
⭐ **Changed** 
* [📘 Add Layer.Add`<T>`](https://github.com/PixeyeHQ/actors.unity/issues/61)

🛠️ **Fixed** 
* [🐞 Entities don't manage groups correctly](https://github.com/PixeyeHQ/actors.unity/issues/60)
* [🐞 ACTORS_EVENTS_MANUAL doesn't work correctly](https://github.com/PixeyeHQ/actors.unity/issues/62)
 

### Actors-2020-06-04
🛠️ **Fixed** 
* [🐞 Not adding buildIndex scenes to freeIndexes](https://github.com/PixeyeHQ/actors.unity/issues/58)
* [🐞 Entities don't manage groups and components correctly](https://github.com/PixeyeHQ/actors.unity/issues/59)
 

### Actors-2020-06-03
⭐ **Changed** 
* [📘 Improving Actors + Unity Job](https://github.com/PixeyeHQ/actors.unity/issues/45)
* [📘 Add Layer.Get`<T>`](https://github.com/PixeyeHQ/actors.unity/issues/47)
* [📘 Make scenes work from asset bundles in new version of Actors](https://github.com/PixeyeHQ/actors.unity/issues/51)

🛠️ **Fixed** 
* [🐞 ApplicationIsQuitting is not working](https://github.com/PixeyeHQ/actors.unity/issues/46)
* [🐞 Setup of Monocached is triggered twice](https://github.com/PixeyeHQ/actors.unity/issues/49)
* [🐞 PostHandleFrameworkPatch.cs(128,1): error CS1022](https://github.com/PixeyeHQ/actors.unity/issues/50)
* [🐞 Object Pooling for Actors on the scene doesn't work properly](https://github.com/PixeyeHQ/actors.unity/issues/54)

⚠️ **IMPORTANT** ⚠️  
If you have Actors on the scene that must be added to the pool system use field below to add **prefab name** of that object. If you don't want to use pooling system with
the object just leave a blank field. This action is required to register corresponding prefab in the pool.
<details>
<summary>
Adding Actor to the pool.
</summary>
<a href="https://gyazo.com/a89593aa71f1dd85b31ba318ec5a4015"><img src="https://i.gyazo.com/a89593aa71f1dd85b31ba318ec5a4015.png" alt="Actor" width="480"/></a>
</details>
 

### Actors-2020-06-02
🛠️ **Fixed** 
* [🐞 Pooled gameobject of entity gets null reference exception.](https://github.com/PixeyeHQ/actors.unity/issues/36)
* [🐞 Pooled Actors won't initialize after re-activating.](https://github.com/PixeyeHQ/actors.unity/issues/37)
* [🐞 Childs of entities are not initialized.](https://github.com/PixeyeHQ/actors.unity/issues/38)
* [🐞 Groups are not cleaned when a scene is reloaded.](https://github.com/PixeyeHQ/actors.unity/issues/39)
* [🐞 Actors continue to think that they are on the old layer when using `entity.MoveTo<T>`](https://github.com/PixeyeHQ/actors.unity/issues/40)
* [🐞 Unloading scene in the inspector and hitting play breaks the editor.](https://github.com/PixeyeHQ/actors.unity/issues/41)
* [🐞 Tools->Actors->Update Actors doesn't work in the Unity 2019.4](https://github.com/PixeyeHQ/actors.unity/issues/43)
* [🐞 Updating entities from the Added/Removed Ecs events do not work correctly.](https://github.com/PixeyeHQ/actors.unity/issues/44)

### Actors-2020-06 | Codename: Bluefin Tuna
⚠️ **IMPORTANT** ⚠️   
The new version of Actors **is not compatible** with previous versions. If you are using ***Actors-2020-04-30***  or earlier version in the production cycle, please change your manifest link to: ```"com.pixeye.ecs": "https://github.com/PixeyeHQ/actors.unity.git#actors-2020-04-30",```

The framework was rewritten so there is no reason to write down all changes. Look [README](https://github.com/PixeyeHQ/actors.unity/blob/develop/README.md).

If you want to migrate to the new version of Actors checkout the [MIGRATION GUIDE](https://github.com/PixeyeHQ/actors.unity/wiki/Migration-to-Actors-2020.06).


