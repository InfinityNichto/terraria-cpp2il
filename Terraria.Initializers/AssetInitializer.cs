using System.Collections;
using Cpp2IlInjected;
using Microsoft.Xna.Framework;
using ReLogic.Content;
using Terraria.GameContent;
using Terraria.IO;

namespace Terraria.Initializers;

[Cpp2IlInjected.Token(Token = "0x20003BD")]
public static class AssetInitializer
{
	[Cpp2IlInjected.Token(Token = "0x400327E")]
	public static bool initialAssetsLoaded;

	[Cpp2IlInjected.Token(Token = "0x6002F36")]
	[Cpp2IlInjected.Address(RVA = "0x125B3D8", Offset = "0x125B3D8", VA = "0x125B3D8")]
	public static void CreateAssetServices(GameServiceContainer services)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F37")]
	[Cpp2IlInjected.Address(RVA = "0x125B538", Offset = "0x125B538", VA = "0x125B538")]
	public static void LoadSplashAssets(bool asyncLoadForSounds)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F38")]
	[Cpp2IlInjected.Address(RVA = "0x125B7C4", Offset = "0x125B7C4", VA = "0x125B7C4")]
	[Cpp2IlInjected.Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x393AC4", Offset = "0x393AC4")]
	public static IEnumerator LoadAssetsWhileInInitialBlackScreen_InSteps()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F39")]
	[Cpp2IlInjected.Address(RVA = "0x125B850", Offset = "0x125B850", VA = "0x125B850")]
	public static void LoadAssetsWhileInInitialBlackScreen()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F3A")]
	[Cpp2IlInjected.Address(RVA = "0x1267820", Offset = "0x1267820", VA = "0x1267820")]
	public static void Load(bool asyncLoad)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F3B")]
	[Cpp2IlInjected.Address(RVA = "0x1267824", Offset = "0x1267824", VA = "0x1267824")]
	[Cpp2IlInjected.Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x393B34", Offset = "0x393B34")]
	private static IEnumerator LoadFonts_InSteps(AssetRequestMode mode)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F3C")]
	[Cpp2IlInjected.Address(RVA = "0x125BFAC", Offset = "0x125BFAC", VA = "0x125BFAC")]
	private static void LoadFonts(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F3D")]
	[Cpp2IlInjected.Address(RVA = "0x1267798", Offset = "0x1267798", VA = "0x1267798")]
	private static void LoadSounds(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F3E")]
	[Cpp2IlInjected.Address(RVA = "0x1267684", Offset = "0x1267684", VA = "0x1267684")]
	private static void LoadRenderTargetAssets(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F3F")]
	[Cpp2IlInjected.Address(RVA = "0x12678B8", Offset = "0x12678B8", VA = "0x12678B8")]
	private static void RegisterRenderTargetAsset(INeedRenderTargetContent content)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F40")]
	[Cpp2IlInjected.Address(RVA = "0x126794C", Offset = "0x126794C", VA = "0x126794C")]
	[Cpp2IlInjected.Attribute(Name = "IteratorStateMachineAttribute", RVA = "0x393BA4", Offset = "0x393BA4")]
	private static IEnumerator LoadTextures_InSteps(AssetRequestMode mode)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6002F41")]
	[Cpp2IlInjected.Address(RVA = "0x125C184", Offset = "0x125C184", VA = "0x125C184")]
	private static void LoadTextures(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F42")]
	[Cpp2IlInjected.Address(RVA = "0x12679E0", Offset = "0x12679E0", VA = "0x12679E0")]
	private static void LoadMinimapFrames(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F43")]
	[Cpp2IlInjected.Address(RVA = "0x1268878", Offset = "0x1268878", VA = "0x1268878")]
	private static void Configuration_OnSave_MinimapFrame(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F44")]
	[Cpp2IlInjected.Address(RVA = "0x126861C", Offset = "0x126861C", VA = "0x126861C")]
	private static void LoadMinimap(string name, Vector2 frameOffset, Vector2 resetPosition, Vector2 zoomInPosition, Vector2 zoomOutPosition, AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F45")]
	[Cpp2IlInjected.Address(RVA = "0x126831C", Offset = "0x126831C", VA = "0x126831C")]
	private static void LoadPlayerResourceSets(AssetRequestMode mode)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F46")]
	[Cpp2IlInjected.Address(RVA = "0x1268A18", Offset = "0x1268A18", VA = "0x1268A18")]
	private static void Configuration_OnSave_PlayerResourcesSet(Preferences obj)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6002F47")]
	[Cpp2IlInjected.Address(RVA = "0x166B63C", Offset = "0x166B63C", VA = "0x166B63C")]
	private static Asset<T> LoadAsset<T>(string assetName, AssetRequestMode mode) where T : class
	{
		return null;
	}
}
