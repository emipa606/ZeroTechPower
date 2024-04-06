using UnityEngine;
using Verse;

namespace LingGame;

[StaticConstructorOnStartup]
public static class LingSSWAUI
{
    public static readonly Texture2D BreakLink = ContentFinder<Texture2D>.Get("LingUI/BreakLink");

    public static readonly Texture2D PowerDown = ContentFinder<Texture2D>.Get("LingUI/PowerDown");

    public static readonly Texture2D PowerUp = ContentFinder<Texture2D>.Get("LingUI/PowerUp");

    public static readonly Texture2D FindNeeder = ContentFinder<Texture2D>.Get("LingUI/FindNeeder");

    public static readonly Texture2D SelectNeeder = ContentFinder<Texture2D>.Get("LingUI/SelectNeeder");
}