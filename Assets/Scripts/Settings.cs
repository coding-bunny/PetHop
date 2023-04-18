using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// This class tracks all the settings that the player can configure during the game.
/// Most of these will either be set from the options menu to affect global settings like lightning, difficulty etc.
/// Some settings will be session bound and set once the game starts.
/// </summary>
public static class Settings
{
    private static bool _enableSoundEffects = true;
    private static bool _enableBackgroudMusic = true;

    public static bool enableSoundEffects
    {
        get
        {
            return _enableSoundEffects;
        }
        set
        {
            _enableSoundEffects = value;
        }
    }

    public static bool enableBackgroundMusic
    {
        get
        {
            return _enableBackgroudMusic;
        }
        set
        {
            _enableBackgroudMusic = value;
        }
    }
}