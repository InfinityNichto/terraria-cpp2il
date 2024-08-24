using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.IO;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.Initializers
{
	// Token: 0x020003D3 RID: 979
	[global::Cpp2ILInjected.Token(Token = "0x2000582")]
	public static class AssetInitializer
	{
		// Token: 0x06002FFB RID: 12283 RVA: 0x0002A93B File Offset: 0x00028B3B
		[global::Cpp2ILInjected.Token(Token = "0x6003467")]
		[global::Cpp2ILInjected.Address(RVA = "0x1364F9C", Offset = "0x1364F9C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetReaderCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AsyncAssetLoader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(AssetReaderCollection),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetLoader), Member = ".ctor", MemberParameters = new object[] { typeof(AssetReaderCollection) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetRepository), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IAssetLoader),
			typeof(AsyncAssetLoader)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameServiceContainer), Member = "AddService", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void CreateAssetServices(GameServiceContainer services)
		{
			throw null;
		}

		// Token: 0x06002FFC RID: 12284 RVA: 0x0002A93E File Offset: 0x00028B3E
		[global::Cpp2ILInjected.Token(Token = "0x6003468")]
		[global::Cpp2ILInjected.Address(RVA = "0x1365120", Offset = "0x1365120", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadAsset", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = "ReLogic.Content.Asset`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void LoadSplashAssets(bool asyncLoadForSounds)
		{
			throw null;
		}

		// Token: 0x06002FFD RID: 12285 RVA: 0x0002A941 File Offset: 0x00028B41
		[global::Cpp2ILInjected.Token(Token = "0x6003469")]
		[global::Cpp2ILInjected.Address(RVA = "0x1365390", Offset = "0x1365390", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<LoadContent_Deferred>d__1863", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static IEnumerator LoadAssetsWhileInInitialBlackScreen_InSteps()
		{
			throw null;
		}

		// Token: 0x06002FFE RID: 12286 RVA: 0x0002A944 File Offset: 0x00028B44
		[global::Cpp2ILInjected.Token(Token = "0x600346A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1365410", Offset = "0x1365410", Length = "0x594")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadFonts", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadTextures", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadRenderTargetAssets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadSounds", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadWall", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadBackground", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadGore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettings), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPopoutMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldCreateMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventorySplitStack), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIToggleSetting), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResearch), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		public static void LoadAssetsWhileInInitialBlackScreen()
		{
			throw null;
		}

		// Token: 0x06002FFF RID: 12287 RVA: 0x0002A947 File Offset: 0x00028B47
		[global::Cpp2ILInjected.Token(Token = "0x600346B")]
		[global::Cpp2ILInjected.Address(RVA = "0x136D7CC", Offset = "0x136D7CC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<LoadContent_Deferred>d__1863", Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public static void Load(bool asyncLoad)
		{
			throw null;
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x0002A94A File Offset: 0x00028B4A
		[global::Cpp2ILInjected.Token(Token = "0x600346C")]
		[global::Cpp2ILInjected.Address(RVA = "0x136D7D0", Offset = "0x136D7D0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerator LoadFonts_InSteps(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x0002A94D File Offset: 0x00028B4D
		[global::Cpp2ILInjected.Token(Token = "0x600346D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13659A4", Offset = "0x13659A4", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadAsset", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = "ReLogic.Content.Asset`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void LoadFonts(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06003002 RID: 12290 RVA: 0x0002A950 File Offset: 0x00028B50
		[global::Cpp2ILInjected.Token(Token = "0x600346E")]
		[global::Cpp2ILInjected.Address(RVA = "0x136D768", Offset = "0x136D768", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Game), Member = "get_Services", ReturnType = typeof(GameServiceContainer))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "Load", MemberParameters = new object[] { typeof(IServiceProvider) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void LoadSounds(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06003003 RID: 12291 RVA: 0x0002A953 File Offset: 0x00028B53
		[global::Cpp2ILInjected.Token(Token = "0x600346F")]
		[global::Cpp2ILInjected.Address(RVA = "0x136D674", Offset = "0x136D674", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerRainbowWingsTextureContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "RegisterRenderTargetAsset", MemberParameters = new object[] { typeof(INeedRenderTargetContent) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerQueenSlimeMountTextureContent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void LoadRenderTargetAssets(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06003004 RID: 12292 RVA: 0x0002A956 File Offset: 0x00028B56
		[global::Cpp2ILInjected.Token(Token = "0x6003470")]
		[global::Cpp2ILInjected.Address(RVA = "0x136D858", Offset = "0x136D858", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadRenderTargetAssets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void RegisterRenderTargetAsset(INeedRenderTargetContent content)
		{
			throw null;
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x0002A959 File Offset: 0x00028B59
		[global::Cpp2ILInjected.Token(Token = "0x6003471")]
		[global::Cpp2ILInjected.Address(RVA = "0x136D91C", Offset = "0x136D91C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer.<LoadAssetsWhileInInitialBlackScreen_InSteps>d__3), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static IEnumerator LoadTextures_InSteps(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06003006 RID: 12294 RVA: 0x0002A95C File Offset: 0x00028B5C
		[global::Cpp2ILInjected.Token(Token = "0x6003472")]
		[global::Cpp2ILInjected.Address(RVA = "0x1365B54", Offset = "0x1365B54", Length = "0x7B20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadAssetsWhileInInitialBlackScreen", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadAsset", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = "ReLogic.Content.Asset`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "RefreshBatchIndex", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadBackground", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_waterfallManager", ReturnType = typeof(WaterfallManager))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterfallManager), Member = "LoadContent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "InitAlphaTable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDataInitializer), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadMinimapFrames", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadPlayerResourceSets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 699)]
		private static void LoadTextures(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06003007 RID: 12295 RVA: 0x0002A95F File Offset: 0x00028B5F
		[global::Cpp2ILInjected.Token(Token = "0x6003473")]
		[global::Cpp2ILInjected.Address(RVA = "0x136D9A4", Offset = "0x136D9A4", Length = "0x7D0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer.<LoadTextures_InSteps>d__11), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadTextures", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer.<>c__DisplayClass13_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadMinimap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Configuration", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, object>, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(KeyValuePair<object, object>) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<object, object>>),
			typeof(Func<KeyValuePair<object, object>, bool>)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ActiveMinimapFrame", MemberParameters = new object[] { typeof(MinimapFrame) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActiveMinimapFrame", ReturnType = typeof(MinimapFrame))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		private static void LoadMinimapFrames(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x06003008 RID: 12296 RVA: 0x0002A962 File Offset: 0x00028B62
		[global::Cpp2ILInjected.Token(Token = "0x6003474")]
		[global::Cpp2ILInjected.Address(RVA = "0x136E71C", Offset = "0x136E71C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, object>, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(KeyValuePair<object, object>) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<object, object>>),
			typeof(Func<KeyValuePair<object, object>, bool>)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void Configuration_OnSave_MinimapFrame(Preferences obj)
		{
			throw null;
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x0002A965 File Offset: 0x00028B65
		[global::Cpp2ILInjected.Token(Token = "0x6003475")]
		[global::Cpp2ILInjected.Address(RVA = "0x136E4C0", Offset = "0x136E4C0", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadMinimapFrames", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadAsset", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = "ReLogic.Content.Asset`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "SetResetButton", MemberParameters = new object[]
		{
			typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "SetZoomOutButton", MemberParameters = new object[]
		{
			typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MinimapFrame), Member = "SetZoomInButton", MemberParameters = new object[]
		{
			typeof(Asset<Microsoft.Xna.Framework.Graphics.Texture2D>),
			typeof(Microsoft.Xna.Framework.Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private static void LoadMinimap(string name, Microsoft.Xna.Framework.Vector2 frameOffset, Microsoft.Xna.Framework.Vector2 resetPosition, Microsoft.Xna.Framework.Vector2 zoomInPosition, Microsoft.Xna.Framework.Vector2 zoomOutPosition, AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x0002A968 File Offset: 0x00028B68
		[global::Cpp2ILInjected.Token(Token = "0x6003476")]
		[global::Cpp2ILInjected.Address(RVA = "0x136E174", Offset = "0x136E174", Length = "0x34C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer.<LoadTextures_InSteps>d__11), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadTextures", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer.<>c__DisplayClass16_0), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FancyClassicPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ClassicPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HorizontalBarsPlayerResourcesDisplaySet), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Configuration", ReturnType = typeof(Preferences))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences[]), Member = "Get", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, object>, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(KeyValuePair<object, object>) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<object, object>>),
			typeof(Func<KeyValuePair<object, object>, bool>)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_ActivePlayerResourcesSet", MemberParameters = new object[] { typeof(IPlayerResourcesDisplaySet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerResourcesSet", ReturnType = typeof(IPlayerResourcesDisplaySet))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		private static void LoadPlayerResourceSets(AssetRequestMode mode)
		{
			throw null;
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x0002A96B File Offset: 0x00028B6B
		[global::Cpp2ILInjected.Token(Token = "0x6003477")]
		[global::Cpp2ILInjected.Address(RVA = "0x136E8A0", Offset = "0x136E8A0", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<KeyValuePair<object, object>, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "FirstOrDefault", MemberTypeParameters = new object[] { typeof(KeyValuePair<object, object>) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<KeyValuePair<object, object>>),
			typeof(Func<KeyValuePair<object, object>, bool>)
		}, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Preferences), Member = "Put", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private static void Configuration_OnSave_PlayerResourcesSet(Preferences obj)
		{
			throw null;
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x0002A96E File Offset: 0x00028B6E
		[global::Cpp2ILInjected.Token(Token = "0x6003478")]
		[global::Cpp2ILInjected.Address(RVA = "0x15717B4", Offset = "0x15717B4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer.<LoadFonts_InSteps>d__6), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer.<LoadTextures_InSteps>d__11), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadSplashAssets", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadFonts", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadTextures", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadMinimap", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(Microsoft.Xna.Framework.Vector2),
			typeof(AssetRequestMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 715)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static Asset<T> LoadAsset<T>(string assetName, AssetRequestMode mode) where T : class
		{
			throw null;
		}

		// Token: 0x040033A4 RID: 13220
		[global::Cpp2ILInjected.Token(Token = "0x400414B")]
		public static bool initialAssetsLoaded;

		// Token: 0x020008FF RID: 2303
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000583")]
		private sealed class <LoadAssetsWhileInInitialBlackScreen_InSteps>d__3 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004C17 RID: 19479 RVA: 0x0002F76E File Offset: 0x0002D96E
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6003479")]
			[global::Cpp2ILInjected.Address(RVA = "0x13653E8", Offset = "0x13653E8", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <LoadAssetsWhileInInitialBlackScreen_InSteps>d__3(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06004C18 RID: 19480 RVA: 0x0002F771 File Offset: 0x0002D971
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600347A")]
			[global::Cpp2ILInjected.Address(RVA = "0x136EA24", Offset = "0x136EA24", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06004C19 RID: 19481 RVA: 0x0002F774 File Offset: 0x0002D974
			[global::Cpp2ILInjected.Token(Token = "0x600347B")]
			[global::Cpp2ILInjected.Address(RVA = "0x136EA28", Offset = "0x136EA28", Length = "0x818")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "IsCurrentPlatform", MemberParameters = new object[] { typeof(DrPlatform.DrPlatformType) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadFonts_InSteps", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadTextures_InSteps", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(IEnumerator))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(TimeSpan))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadRenderTargetAssets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadSounds", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadWall", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "get_UnityTexture", ReturnType = typeof(global::UnityEngine.Texture2D))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_CurrentPlatform", ReturnType = typeof(DrPlatform.DrPlatformType))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadBackground", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadGore", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LayoutCalculator), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIVirtualInputController), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIQuickActionButton), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettings), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPopoutMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerSelectMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIPlayerCreateMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldSelectMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIWorldCreateMenu), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMultiplayerLobby), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIMap), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIInventorySplitStack), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIControllerInputButton), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIToggleSetting), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIEmotesWindow), Member = "LoadContent", MemberParameters = new object[] { typeof(ContentManager) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIResearch), Member = "LoadContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUIBestiary), Member = "LoadContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GUISettingsOverlay), Member = "Init", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadProjectile", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadNPC", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700089B RID: 2203
			// (get) Token: 0x06004C1A RID: 19482 RVA: 0x0002F777 File Offset: 0x0002D977
			[global::Cpp2ILInjected.Token(Token = "0x17000680")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600347C")]
				[global::Cpp2ILInjected.Address(RVA = "0x136F240", Offset = "0x136F240", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004C1B RID: 19483 RVA: 0x0002F77A File Offset: 0x0002D97A
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600347D")]
			[global::Cpp2ILInjected.Address(RVA = "0x136F248", Offset = "0x136F248", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700089C RID: 2204
			// (get) Token: 0x06004C1C RID: 19484 RVA: 0x0002F77D File Offset: 0x0002D97D
			[global::Cpp2ILInjected.Token(Token = "0x17000681")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600347E")]
				[global::Cpp2ILInjected.Address(RVA = "0x136F280", Offset = "0x136F280", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400854A RID: 34122
			[global::Cpp2ILInjected.Token(Token = "0x400414C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x0400854B RID: 34123
			[global::Cpp2ILInjected.Token(Token = "0x400414D")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x0400854C RID: 34124
			[global::Cpp2ILInjected.Token(Token = "0x400414E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private bool <doneLoadingFonts>5__2;

			// Token: 0x0400854D RID: 34125
			[global::Cpp2ILInjected.Token(Token = "0x400414F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			private IEnumerator <fontLoadProcedure>5__3;

			// Token: 0x0400854E RID: 34126
			[global::Cpp2ILInjected.Token(Token = "0x4004150")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			private bool <doneLoadingTextures>5__4;

			// Token: 0x0400854F RID: 34127
			[global::Cpp2ILInjected.Token(Token = "0x4004151")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
			private IEnumerator <textureLoadProcedure>5__5;
		}

		// Token: 0x02000900 RID: 2304
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000584")]
		private sealed class <LoadFonts_InSteps>d__6 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004C1D RID: 19485 RVA: 0x0002F780 File Offset: 0x0002D980
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x600347F")]
			[global::Cpp2ILInjected.Address(RVA = "0x136D830", Offset = "0x136D830", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <LoadFonts_InSteps>d__6(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06004C1E RID: 19486 RVA: 0x0002F783 File Offset: 0x0002D983
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6003480")]
			[global::Cpp2ILInjected.Address(RVA = "0x136F288", Offset = "0x136F288", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06004C1F RID: 19487 RVA: 0x0002F786 File Offset: 0x0002D986
			[global::Cpp2ILInjected.Token(Token = "0x6003481")]
			[global::Cpp2ILInjected.Address(RVA = "0x136F28C", Offset = "0x136F28C", Length = "0x284")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadAsset", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(string),
				typeof(AssetRequestMode)
			}, ReturnType = "ReLogic.Content.Asset`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700089D RID: 2205
			// (get) Token: 0x06004C20 RID: 19488 RVA: 0x0002F789 File Offset: 0x0002D989
			[global::Cpp2ILInjected.Token(Token = "0x17000682")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6003482")]
				[global::Cpp2ILInjected.Address(RVA = "0x136F510", Offset = "0x136F510", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004C21 RID: 19489 RVA: 0x0002F78C File Offset: 0x0002D98C
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6003483")]
			[global::Cpp2ILInjected.Address(RVA = "0x136F518", Offset = "0x136F518", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x1700089E RID: 2206
			// (get) Token: 0x06004C22 RID: 19490 RVA: 0x0002F78F File Offset: 0x0002D98F
			[global::Cpp2ILInjected.Token(Token = "0x17000683")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6003484")]
				[global::Cpp2ILInjected.Address(RVA = "0x136F550", Offset = "0x136F550", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04008550 RID: 34128
			[global::Cpp2ILInjected.Token(Token = "0x4004152")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008551 RID: 34129
			[global::Cpp2ILInjected.Token(Token = "0x4004153")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008552 RID: 34130
			[global::Cpp2ILInjected.Token(Token = "0x4004154")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public AssetRequestMode mode;
		}

		// Token: 0x02000901 RID: 2305
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000585")]
		private sealed class <LoadTextures_InSteps>d__11 : IEnumerator<object>, IEnumerator, IDisposable
		{
			// Token: 0x06004C23 RID: 19491 RVA: 0x0002F792 File Offset: 0x0002D992
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6003485")]
			[global::Cpp2ILInjected.Address(RVA = "0x136D97C", Offset = "0x136D97C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <LoadTextures_InSteps>d__11(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06004C24 RID: 19492 RVA: 0x0002F795 File Offset: 0x0002D995
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6003486")]
			[global::Cpp2ILInjected.Address(RVA = "0x136F558", Offset = "0x136F558", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x06004C25 RID: 19493 RVA: 0x0002F798 File Offset: 0x0002D998
			[global::Cpp2ILInjected.Token(Token = "0x6003487")]
			[global::Cpp2ILInjected.Address(RVA = "0x136F55C", Offset = "0x136F55C", Length = "0x81B0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadAsset", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(string),
				typeof(AssetRequestMode)
			}, ReturnType = "ReLogic.Content.Asset`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Microsoft.Xna.Framework.Graphics.Texture2D), Member = "RefreshBatchIndex", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadMinimapFrames", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AssetInitializer), Member = "LoadPlayerResourceSets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "LoadBackground", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_waterfallManager", ReturnType = typeof(WaterfallManager))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterfallManager), Member = "LoadContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "InitAlphaTable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerDataInitializer), Member = "Load", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 715)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x1700089F RID: 2207
			// (get) Token: 0x06004C26 RID: 19494 RVA: 0x0002F79B File Offset: 0x0002D99B
			[global::Cpp2ILInjected.Token(Token = "0x17000684")]
			private object System.Collections.Generic.IEnumerator<System.Object>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6003488")]
				[global::Cpp2ILInjected.Address(RVA = "0x137770C", Offset = "0x137770C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06004C27 RID: 19495 RVA: 0x0002F79E File Offset: 0x0002D99E
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6003489")]
			[global::Cpp2ILInjected.Address(RVA = "0x1377714", Offset = "0x1377714", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x170008A0 RID: 2208
			// (get) Token: 0x06004C28 RID: 19496 RVA: 0x0002F7A1 File Offset: 0x0002D9A1
			[global::Cpp2ILInjected.Token(Token = "0x17000685")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x600348A")]
				[global::Cpp2ILInjected.Address(RVA = "0x137774C", Offset = "0x137774C", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x04008553 RID: 34131
			[global::Cpp2ILInjected.Token(Token = "0x4004155")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private int <>1__state;

			// Token: 0x04008554 RID: 34132
			[global::Cpp2ILInjected.Token(Token = "0x4004156")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private object <>2__current;

			// Token: 0x04008555 RID: 34133
			[global::Cpp2ILInjected.Token(Token = "0x4004157")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public AssetRequestMode mode;
		}

		// Token: 0x02000902 RID: 2306
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000586")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x06004C29 RID: 19497 RVA: 0x0002F7A4 File Offset: 0x0002D9A4
			[global::Cpp2ILInjected.Token(Token = "0x600348B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1377754", Offset = "0x1377754", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadMinimapFrames", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_0()
			{
				throw null;
			}

			// Token: 0x06004C2A RID: 19498 RVA: 0x0002F7A7 File Offset: 0x0002D9A7
			[global::Cpp2ILInjected.Token(Token = "0x600348C")]
			[global::Cpp2ILInjected.Address(RVA = "0x137775C", Offset = "0x137775C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <LoadMinimapFrames>b__0(KeyValuePair<string, MinimapFrame> pair)
			{
				throw null;
			}

			// Token: 0x04008556 RID: 34134
			[global::Cpp2ILInjected.Token(Token = "0x4004158")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string frameName;
		}

		// Token: 0x02000903 RID: 2307
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000587")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06004C2B RID: 19499 RVA: 0x0002F7AA File Offset: 0x0002D9AA
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600348D")]
			[global::Cpp2ILInjected.Address(RVA = "0x13777A4", Offset = "0x13777A4", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06004C2C RID: 19500 RVA: 0x0002F7AD File Offset: 0x0002D9AD
			[global::Cpp2ILInjected.Token(Token = "0x600348E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1377800", Offset = "0x1377800", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06004C2D RID: 19501 RVA: 0x0002F7B0 File Offset: 0x0002D9B0
			[global::Cpp2ILInjected.Token(Token = "0x600348F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1377808", Offset = "0x1377808", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActiveMinimapFrame", ReturnType = typeof(MinimapFrame))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <Configuration_OnSave_MinimapFrame>b__14_0(KeyValuePair<string, MinimapFrame> pair)
			{
				throw null;
			}

			// Token: 0x06004C2E RID: 19502 RVA: 0x0002F7B3 File Offset: 0x0002D9B3
			[global::Cpp2ILInjected.Token(Token = "0x6003490")]
			[global::Cpp2ILInjected.Address(RVA = "0x1377874", Offset = "0x1377874", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_ActivePlayerResourcesSet", ReturnType = typeof(IPlayerResourcesDisplaySet))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <Configuration_OnSave_PlayerResourcesSet>b__17_0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				throw null;
			}

			// Token: 0x04008557 RID: 34135
			[global::Cpp2ILInjected.Token(Token = "0x4004159")]
			public static readonly AssetInitializer.<>c <>9;

			// Token: 0x04008558 RID: 34136
			[global::Cpp2ILInjected.Token(Token = "0x400415A")]
			public static Func<KeyValuePair<string, MinimapFrame>, bool> <>9__14_0;

			// Token: 0x04008559 RID: 34137
			[global::Cpp2ILInjected.Token(Token = "0x400415B")]
			public static Func<KeyValuePair<string, IPlayerResourcesDisplaySet>, bool> <>9__17_0;
		}

		// Token: 0x02000904 RID: 2308
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000588")]
		private sealed class <>c__DisplayClass16_0
		{
			// Token: 0x06004C2F RID: 19503 RVA: 0x0002F7B6 File Offset: 0x0002D9B6
			[global::Cpp2ILInjected.Token(Token = "0x6003491")]
			[global::Cpp2ILInjected.Address(RVA = "0x13778E0", Offset = "0x13778E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadPlayerResourceSets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass16_0()
			{
				throw null;
			}

			// Token: 0x06004C30 RID: 19504 RVA: 0x0002F7B9 File Offset: 0x0002D9B9
			[global::Cpp2ILInjected.Token(Token = "0x6003492")]
			[global::Cpp2ILInjected.Address(RVA = "0x13778E8", Offset = "0x13778E8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			internal bool <LoadPlayerResourceSets>b__0(KeyValuePair<string, IPlayerResourcesDisplaySet> pair)
			{
				throw null;
			}

			// Token: 0x0400855A RID: 34138
			[global::Cpp2ILInjected.Token(Token = "0x400415C")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public string frameName;
		}
	}
}
