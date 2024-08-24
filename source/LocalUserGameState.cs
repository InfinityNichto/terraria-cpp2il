using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Terraria;
using Terraria.Achievements;
using Terraria.DataStructures;
using Terraria.GameContent;
using Terraria.GameContent.Creative;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Golf;
using Terraria.GameContent.UI.BigProgressBar;
using Terraria.GameContent.UI.Minimap;
using Terraria.GameContent.UI.ResourceSets;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Effects;
using Terraria.Graphics.Light;
using Terraria.IO;
using Terraria.Map;

// Token: 0x02000213 RID: 531
[global::Cpp2ILInjected.Token(Token = "0x20002B9")]
public class LocalUserGameState
{
	// Token: 0x17000165 RID: 357
	// (get) Token: 0x06000EF8 RID: 3832 RVA: 0x000247E5 File Offset: 0x000229E5
	[global::Cpp2ILInjected.Token(Token = "0x1700018D")]
	public FavoritesFile LocalFavoriteData
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001028")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4063C", Offset = "0xA4063C", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(char), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000166 RID: 358
	// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x000247E8 File Offset: 0x000229E8
	// (set) Token: 0x06000EFA RID: 3834 RVA: 0x000247EB File Offset: 0x000229EB
	[global::Cpp2ILInjected.Token(Token = "0x1700018E")]
	public WaterfallManager waterfallManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001029")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40760", Offset = "0xA40760", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "get_waterfallManager", ReturnType = typeof(WaterfallManager))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WaterfallManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600102A")]
		[global::Cpp2ILInjected.Address(RVA = "0xA407C4", Offset = "0xA407C4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x17000167 RID: 359
	// (get) Token: 0x06000EFB RID: 3835 RVA: 0x000247EE File Offset: 0x000229EE
	[global::Cpp2ILInjected.Token(Token = "0x1700018F")]
	public LightingEngine NewEngine
	{
		[global::Cpp2ILInjected.Token(Token = "0x600102B")]
		[global::Cpp2ILInjected.Address(RVA = "0xA407CC", Offset = "0xA407CC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get_NewEngine", ReturnType = typeof(LightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000168 RID: 360
	// (get) Token: 0x06000EFC RID: 3836 RVA: 0x000247F1 File Offset: 0x000229F1
	[global::Cpp2ILInjected.Token(Token = "0x17000190")]
	public LegacyLighting LegacyEngine
	{
		[global::Cpp2ILInjected.Token(Token = "0x600102C")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40830", Offset = "0xA40830", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get_LegacyEngine", ReturnType = typeof(LegacyLighting))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_Camera", ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = ".ctor", MemberParameters = new object[] { typeof(Camera) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		get
		{
			throw null;
		}
	}

	// Token: 0x17000169 RID: 361
	// (get) Token: 0x06000EFD RID: 3837 RVA: 0x000247F4 File Offset: 0x000229F4
	// (set) Token: 0x06000EFE RID: 3838 RVA: 0x000247F7 File Offset: 0x000229F7
	[global::Cpp2ILInjected.Token(Token = "0x17000191")]
	public ILightingEngine _activeEngine
	{
		[global::Cpp2ILInjected.Token(Token = "0x600102D")]
		[global::Cpp2ILInjected.Address(RVA = "0xA408CC", Offset = "0xA408CC", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get_NewEngine", ReturnType = typeof(LightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get_LegacyEngine", ReturnType = typeof(LegacyLighting))]
		get
		{
			throw null;
		}
		[global::Cpp2ILInjected.Token(Token = "0x600102E")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40904", Offset = "0xA40904", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		set
		{
			throw null;
		}
	}

	// Token: 0x06000EFF RID: 3839 RVA: 0x000247FA File Offset: 0x000229FA
	[global::Cpp2ILInjected.Token(Token = "0x600102F")]
	[global::Cpp2ILInjected.Address(RVA = "0xA3D9D0", Offset = "0xA3D9D0", Length = "0xAA4")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(PlatformUser)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CreativePowerManager), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LockOnHelperStaticData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileObjectPreviewData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemShopSellbackHelper), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Camera), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BigProgressBarSystem), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Item), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerFileData), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<int, bool>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(int),
		typeof(int),
		typeof(int),
		typeof(int)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stopwatch), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GolfState), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DroneCameraTracker), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldMap), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(float),
		typeof(float)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersPack), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WindGrid), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object>), Member = ".ctor", MemberParameters = new object[]
	{
		typeof(object),
		typeof(IntPtr)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ThreadLocal<>), Member = ".ctor", MemberParameters = new object[] { "System.Func`1<T>" }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 91)]
	public LocalUserGameState()
	{
		throw null;
	}

	// Token: 0x04001892 RID: 6290
	[ThreadStatic]
	[global::Cpp2ILInjected.Token(Token = "0x4001DBE")]
	public static LocalUserGameState Instance;

	// Token: 0x04001893 RID: 6291
	[global::Cpp2ILInjected.Token(Token = "0x4001DBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
	public AchievementManager _achievements;

	// Token: 0x04001894 RID: 6292
	[global::Cpp2ILInjected.Token(Token = "0x4001DC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
	public CreativePowerManager CreativePowerManager;

	// Token: 0x04001895 RID: 6293
	[global::Cpp2ILInjected.Token(Token = "0x4001DC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
	public bool CreativePowerManager_initialized;

	// Token: 0x04001896 RID: 6294
	[global::Cpp2ILInjected.Token(Token = "0x4001DC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x21")]
	public bool SwapBumpersTriggers;

	// Token: 0x04001897 RID: 6295
	[global::Cpp2ILInjected.Token(Token = "0x4001DC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
	public object MapHelperIOLock;

	// Token: 0x04001898 RID: 6296
	[global::Cpp2ILInjected.Token(Token = "0x4001DC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
	public float ScrollSensitivity;

	// Token: 0x04001899 RID: 6297
	[global::Cpp2ILInjected.Token(Token = "0x4001DC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
	public LockOnHelperStaticData LockOnHelperStaticData;

	// Token: 0x0400189A RID: 6298
	[global::Cpp2ILInjected.Token(Token = "0x4001DC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
	public TileObjectPreviewData objectPreview;

	// Token: 0x0400189B RID: 6299
	[global::Cpp2ILInjected.Token(Token = "0x4001DC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
	public bool flushLighting;

	// Token: 0x0400189C RID: 6300
	[global::Cpp2ILInjected.Token(Token = "0x4001DC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
	public MinimapFrame ActiveMinimapFrame;

	// Token: 0x0400189D RID: 6301
	[global::Cpp2ILInjected.Token(Token = "0x4001DC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
	public IPlayerResourcesDisplaySet ActivePlayerResourcesSet;

	// Token: 0x0400189E RID: 6302
	[global::Cpp2ILInjected.Token(Token = "0x4001DCA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
	public int mapDelay;

	// Token: 0x0400189F RID: 6303
	[global::Cpp2ILInjected.Token(Token = "0x4001DCB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
	public bool InReforgeMenu;

	// Token: 0x040018A0 RID: 6304
	[global::Cpp2ILInjected.Token(Token = "0x4001DCC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x65")]
	public bool InGuideCraftMenu;

	// Token: 0x040018A1 RID: 6305
	[global::Cpp2ILInjected.Token(Token = "0x4001DCD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x66")]
	public bool anglerQuestFinished;

	// Token: 0x040018A2 RID: 6306
	[global::Cpp2ILInjected.Token(Token = "0x4001DCE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x67")]
	public bool HoveringOverAnNPC;

	// Token: 0x040018A3 RID: 6307
	[global::Cpp2ILInjected.Token(Token = "0x4001DCF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
	public int currentNPCShowingChatBubble;

	// Token: 0x040018A4 RID: 6308
	[global::Cpp2ILInjected.Token(Token = "0x4001DD0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
	public float hBar;

	// Token: 0x040018A5 RID: 6309
	[global::Cpp2ILInjected.Token(Token = "0x4001DD1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
	public float sBar;

	// Token: 0x040018A6 RID: 6310
	[global::Cpp2ILInjected.Token(Token = "0x4001DD2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x74")]
	public float lBar;

	// Token: 0x040018A7 RID: 6311
	[global::Cpp2ILInjected.Token(Token = "0x4001DD3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
	public float aBar;

	// Token: 0x040018A8 RID: 6312
	[global::Cpp2ILInjected.Token(Token = "0x4001DD4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
	public int mouseNPCIndex;

	// Token: 0x040018A9 RID: 6313
	[global::Cpp2ILInjected.Token(Token = "0x4001DD5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
	public int mouseNPCType;

	// Token: 0x040018AA RID: 6314
	[global::Cpp2ILInjected.Token(Token = "0x4001DD6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
	public int firstTileX;

	// Token: 0x040018AB RID: 6315
	[global::Cpp2ILInjected.Token(Token = "0x4001DD7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
	public int lastTileX;

	// Token: 0x040018AC RID: 6316
	[global::Cpp2ILInjected.Token(Token = "0x4001DD8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x8C")]
	public int firstTileY;

	// Token: 0x040018AD RID: 6317
	[global::Cpp2ILInjected.Token(Token = "0x4001DD9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
	public int lastTileY;

	// Token: 0x040018AE RID: 6318
	[global::Cpp2ILInjected.Token(Token = "0x4001DDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x94")]
	public int rare;

	// Token: 0x040018AF RID: 6319
	[global::Cpp2ILInjected.Token(Token = "0x4001DDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
	public int hairStart;

	// Token: 0x040018B0 RID: 6320
	[global::Cpp2ILInjected.Token(Token = "0x4001DDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x9C")]
	public int oldHairStyle;

	// Token: 0x040018B1 RID: 6321
	[global::Cpp2ILInjected.Token(Token = "0x4001DDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
	public Color oldHairColor;

	// Token: 0x040018B2 RID: 6322
	[global::Cpp2ILInjected.Token(Token = "0x4001DDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
	public int selClothes;

	// Token: 0x040018B3 RID: 6323
	[global::Cpp2ILInjected.Token(Token = "0x4001DDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
	public Color[] oldClothesColor;

	// Token: 0x040018B4 RID: 6324
	[global::Cpp2ILInjected.Token(Token = "0x4001DE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
	public int oldClothesStyle;

	// Token: 0x040018B5 RID: 6325
	[global::Cpp2ILInjected.Token(Token = "0x4001DE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
	public int interactedDresserTopLeftX;

	// Token: 0x040018B6 RID: 6326
	[global::Cpp2ILInjected.Token(Token = "0x4001DE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
	public int interactedDresserTopLeftY;

	// Token: 0x040018B7 RID: 6327
	[global::Cpp2ILInjected.Token(Token = "0x4001DE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xBC")]
	public Vector2 _itemIconCacheScreenPosition;

	// Token: 0x040018B8 RID: 6328
	[global::Cpp2ILInjected.Token(Token = "0x4001DE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
	public int _itemIconCacheSelectedItemID;

	// Token: 0x040018B9 RID: 6329
	[global::Cpp2ILInjected.Token(Token = "0x4001DE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
	public int _itemIconCacheTime;

	// Token: 0x040018BA RID: 6330
	[global::Cpp2ILInjected.Token(Token = "0x4001DE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
	public Player dresserInterfaceDummy;

	// Token: 0x040018BB RID: 6331
	[global::Cpp2ILInjected.Token(Token = "0x4001DE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
	public Color selColor;

	// Token: 0x040018BC RID: 6332
	[global::Cpp2ILInjected.Token(Token = "0x4001DE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xDC")]
	public int waterStyle;

	// Token: 0x040018BD RID: 6333
	[global::Cpp2ILInjected.Token(Token = "0x4001DE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
	public bool drewLava;

	// Token: 0x040018BE RID: 6334
	[global::Cpp2ILInjected.Token(Token = "0x4001DEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
	public float[] liquidAlpha;

	// Token: 0x040018BF RID: 6335
	[global::Cpp2ILInjected.Token(Token = "0x4001DEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
	public int[] activeLiquidAlpha;

	// Token: 0x040018C0 RID: 6336
	[global::Cpp2ILInjected.Token(Token = "0x4001DEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
	public int numActiveLiquidAlpha;

	// Token: 0x040018C1 RID: 6337
	[global::Cpp2ILInjected.Token(Token = "0x4001DED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFC")]
	public bool SettingsUnlock_WorldEvil;

	// Token: 0x040018C2 RID: 6338
	[global::Cpp2ILInjected.Token(Token = "0x4001DEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFD")]
	public bool SettingsEnabled_MinersWobble;

	// Token: 0x040018C3 RID: 6339
	[global::Cpp2ILInjected.Token(Token = "0x4001DEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFE")]
	public bool SettingBlockGamepadsEntirely;

	// Token: 0x040018C4 RID: 6340
	[global::Cpp2ILInjected.Token(Token = "0x4001DF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0xFF")]
	public bool SettingDontScaleMainMenuUp;

	// Token: 0x040018C5 RID: 6341
	[global::Cpp2ILInjected.Token(Token = "0x4001DF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
	public bool SettingsEnabled_OpaqueBoxBehindTooltips;

	// Token: 0x040018C6 RID: 6342
	[global::Cpp2ILInjected.Token(Token = "0x4001DF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
	public int tooltipTime;

	// Token: 0x040018C7 RID: 6343
	[global::Cpp2ILInjected.Token(Token = "0x4001DF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
	public int inventoryTooltipTime;

	// Token: 0x040018C8 RID: 6344
	[global::Cpp2ILInjected.Token(Token = "0x4001DF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
	public bool SettingMusicReplayDelayEnabled;

	// Token: 0x040018C9 RID: 6345
	[global::Cpp2ILInjected.Token(Token = "0x4001DF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x10D")]
	public bool MouseShowBuildingGrid;

	// Token: 0x040018CA RID: 6346
	[global::Cpp2ILInjected.Token(Token = "0x4001DF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
	public float MouseBuildingGridAlpha;

	// Token: 0x040018CB RID: 6347
	[global::Cpp2ILInjected.Token(Token = "0x4001DF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x114")]
	public float GraveyardVisualIntensity;

	// Token: 0x040018CC RID: 6348
	[global::Cpp2ILInjected.Token(Token = "0x4001DF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
	public bool ScreenPostProcessor_Enabled;

	// Token: 0x040018CD RID: 6349
	[global::Cpp2ILInjected.Token(Token = "0x4001DF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
	public List<ScreenPostProcessor> ScreenPostProcessor_Instances;

	// Token: 0x040018CE RID: 6350
	[global::Cpp2ILInjected.Token(Token = "0x4001DFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
	public List<ScreenPostProcessor> ScreenPostProcessor_UIInstances;

	// Token: 0x040018CF RID: 6351
	[global::Cpp2ILInjected.Token(Token = "0x4001DFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
	public List<Filter> ScreenPostProcessor_Filters;

	// Token: 0x040018D0 RID: 6352
	[global::Cpp2ILInjected.Token(Token = "0x4001DFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
	public int ScreenPostProcessor_countUpdate;

	// Token: 0x040018D1 RID: 6353
	[global::Cpp2ILInjected.Token(Token = "0x4001DFD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x13C")]
	public int ScreenPostProcessor_renderCheck;

	// Token: 0x040018D2 RID: 6354
	[global::Cpp2ILInjected.Token(Token = "0x4001DFE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
	public ItemShopSellbackHelper shopSellbackHelper;

	// Token: 0x040018D3 RID: 6355
	[global::Cpp2ILInjected.Token(Token = "0x4001DFF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x148")]
	public Chest[] shop;

	// Token: 0x040018D4 RID: 6356
	[global::Cpp2ILInjected.Token(Token = "0x4001E00")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
	public int npcChatCornerItem;

	// Token: 0x040018D5 RID: 6357
	[global::Cpp2ILInjected.Token(Token = "0x4001E01")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x154")]
	public int npcShop;

	// Token: 0x040018D6 RID: 6358
	[global::Cpp2ILInjected.Token(Token = "0x4001E02")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
	public bool npcChatFocus1;

	// Token: 0x040018D7 RID: 6359
	[global::Cpp2ILInjected.Token(Token = "0x4001E03")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x159")]
	public bool npcChatFocus2;

	// Token: 0x040018D8 RID: 6360
	[global::Cpp2ILInjected.Token(Token = "0x4001E04")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15A")]
	public bool npcChatFocus3;

	// Token: 0x040018D9 RID: 6361
	[global::Cpp2ILInjected.Token(Token = "0x4001E05")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x15B")]
	public bool npcChatFocus4;

	// Token: 0x040018DA RID: 6362
	[global::Cpp2ILInjected.Token(Token = "0x4001E06")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
	public string npcChatText;

	// Token: 0x040018DB RID: 6363
	[global::Cpp2ILInjected.Token(Token = "0x4001E07")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
	public string defaultChestName;

	// Token: 0x040018DC RID: 6364
	[global::Cpp2ILInjected.Token(Token = "0x4001E08")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
	public string blockKey;

	// Token: 0x040018DD RID: 6365
	[global::Cpp2ILInjected.Token(Token = "0x4001E09")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
	public bool blockInput;

	// Token: 0x040018DE RID: 6366
	[global::Cpp2ILInjected.Token(Token = "0x4001E0A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
	public string _savePath;

	// Token: 0x040018DF RID: 6367
	[global::Cpp2ILInjected.Token(Token = "0x4001E0B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
	public string _oldSavePath;

	// Token: 0x040018E0 RID: 6368
	[global::Cpp2ILInjected.Token(Token = "0x4001E0C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
	public bool StateInitialised;

	// Token: 0x040018E1 RID: 6369
	[global::Cpp2ILInjected.Token(Token = "0x4001E0D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
	public Camera Camera;

	// Token: 0x040018E2 RID: 6370
	[global::Cpp2ILInjected.Token(Token = "0x4001E0E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
	public FavoritesFile _localFavoriteData;

	// Token: 0x040018E3 RID: 6371
	[global::Cpp2ILInjected.Token(Token = "0x4001E0F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
	public Preferences _configuration;

	// Token: 0x040018E4 RID: 6372
	[global::Cpp2ILInjected.Token(Token = "0x4001E10")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
	public Preferences _inputProfiles;

	// Token: 0x040018E5 RID: 6373
	[global::Cpp2ILInjected.Token(Token = "0x4001E11")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B8")]
	public WorldSections sectionManager;

	// Token: 0x040018E6 RID: 6374
	[global::Cpp2ILInjected.Token(Token = "0x4001E12")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C0")]
	public BigProgressBarSystem BigBossProgressBar;

	// Token: 0x040018E7 RID: 6375
	[global::Cpp2ILInjected.Token(Token = "0x4001E13")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C8")]
	public float hellBlackBoxBottom;

	// Token: 0x040018E8 RID: 6376
	[global::Cpp2ILInjected.Token(Token = "0x4001E14")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D0")]
	public int[] backTexture;

	// Token: 0x040018E9 RID: 6377
	[global::Cpp2ILInjected.Token(Token = "0x4001E15")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1D8")]
	public int[] oldBackTexture;

	// Token: 0x040018EA RID: 6378
	[global::Cpp2ILInjected.Token(Token = "0x4001E16")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E0")]
	public Texture2D[] backTextureValues;

	// Token: 0x040018EB RID: 6379
	[global::Cpp2ILInjected.Token(Token = "0x4001E17")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1E8")]
	public Texture2D[] oldBackTextureValues;

	// Token: 0x040018EC RID: 6380
	[global::Cpp2ILInjected.Token(Token = "0x4001E18")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F0")]
	public FileMetadata MapFileMetadata;

	// Token: 0x040018ED RID: 6381
	[global::Cpp2ILInjected.Token(Token = "0x4001E19")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x1F8")]
	public Main.MouseTextCache _mouseTextCache;

	// Token: 0x040018EE RID: 6382
	[global::Cpp2ILInjected.Token(Token = "0x4001E1A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x228")]
	private WaterfallManager _waterfallManager;

	// Token: 0x040018EF RID: 6383
	[global::Cpp2ILInjected.Token(Token = "0x4001E1B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x230")]
	public Rain[] rain;

	// Token: 0x040018F0 RID: 6384
	[global::Cpp2ILInjected.Token(Token = "0x4001E1C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x238")]
	public PopupText[] popupText;

	// Token: 0x040018F1 RID: 6385
	[global::Cpp2ILInjected.Token(Token = "0x4001E1D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x240")]
	public int mouseX;

	// Token: 0x040018F2 RID: 6386
	[global::Cpp2ILInjected.Token(Token = "0x4001E1E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x244")]
	public int mouseY;

	// Token: 0x040018F3 RID: 6387
	[global::Cpp2ILInjected.Token(Token = "0x4001E1F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x248")]
	public int worldMouseX;

	// Token: 0x040018F4 RID: 6388
	[global::Cpp2ILInjected.Token(Token = "0x4001E20")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x24C")]
	public int worldMouseY;

	// Token: 0x040018F5 RID: 6389
	[global::Cpp2ILInjected.Token(Token = "0x4001E21")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x250")]
	public int lastMouseX;

	// Token: 0x040018F6 RID: 6390
	[global::Cpp2ILInjected.Token(Token = "0x4001E22")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x254")]
	public int lastMouseY;

	// Token: 0x040018F7 RID: 6391
	[global::Cpp2ILInjected.Token(Token = "0x4001E23")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x258")]
	public bool mouseLeft;

	// Token: 0x040018F8 RID: 6392
	[global::Cpp2ILInjected.Token(Token = "0x4001E24")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x259")]
	public bool mouseRight;

	// Token: 0x040018F9 RID: 6393
	[global::Cpp2ILInjected.Token(Token = "0x4001E25")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25A")]
	public bool worldMouseLeft;

	// Token: 0x040018FA RID: 6394
	[global::Cpp2ILInjected.Token(Token = "0x4001E26")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25B")]
	public bool worldMouseRight;

	// Token: 0x040018FB RID: 6395
	[global::Cpp2ILInjected.Token(Token = "0x4001E27")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25C")]
	public bool worldMouseLeftRelease;

	// Token: 0x040018FC RID: 6396
	[global::Cpp2ILInjected.Token(Token = "0x4001E28")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25D")]
	public bool worldMouseRightRelease;

	// Token: 0x040018FD RID: 6397
	[global::Cpp2ILInjected.Token(Token = "0x4001E29")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25E")]
	public bool isMouseLeftConsumedByUI;

	// Token: 0x040018FE RID: 6398
	[global::Cpp2ILInjected.Token(Token = "0x4001E2A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x25F")]
	public bool hairWindow;

	// Token: 0x040018FF RID: 6399
	[global::Cpp2ILInjected.Token(Token = "0x4001E2B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x260")]
	public bool clothesWindow;

	// Token: 0x04001900 RID: 6400
	[global::Cpp2ILInjected.Token(Token = "0x4001E2C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x261")]
	public bool ingameOptionsWindow;

	// Token: 0x04001901 RID: 6401
	[global::Cpp2ILInjected.Token(Token = "0x4001E2D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x262")]
	public bool inFancyUI;

	// Token: 0x04001902 RID: 6402
	[global::Cpp2ILInjected.Token(Token = "0x4001E2E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x263")]
	public byte gFade;

	// Token: 0x04001903 RID: 6403
	[global::Cpp2ILInjected.Token(Token = "0x4001E2F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x264")]
	public float gFader;

	// Token: 0x04001904 RID: 6404
	[global::Cpp2ILInjected.Token(Token = "0x4001E30")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x268")]
	public byte gFadeDir;

	// Token: 0x04001905 RID: 6405
	[global::Cpp2ILInjected.Token(Token = "0x4001E31")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x26C")]
	public float startScreenYOffset;

	// Token: 0x04001906 RID: 6406
	[global::Cpp2ILInjected.Token(Token = "0x4001E32")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x270")]
	public float targetScreenYOffset;

	// Token: 0x04001907 RID: 6407
	[global::Cpp2ILInjected.Token(Token = "0x4001E33")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x274")]
	public int CameraMovementMode;

	// Token: 0x04001908 RID: 6408
	[global::Cpp2ILInjected.Token(Token = "0x4001E34")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x278")]
	public float screenYOffset;

	// Token: 0x04001909 RID: 6409
	[global::Cpp2ILInjected.Token(Token = "0x4001E35")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x27C")]
	public float cameraOffset;

	// Token: 0x0400190A RID: 6410
	[global::Cpp2ILInjected.Token(Token = "0x4001E36")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x280")]
	public Vector2 screenPosition;

	// Token: 0x0400190B RID: 6411
	[global::Cpp2ILInjected.Token(Token = "0x4001E37")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x288")]
	public Vector2 screenLastPosition;

	// Token: 0x0400190C RID: 6412
	[global::Cpp2ILInjected.Token(Token = "0x4001E38")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x290")]
	public int screenWidth;

	// Token: 0x0400190D RID: 6413
	[global::Cpp2ILInjected.Token(Token = "0x4001E39")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x294")]
	public int screenHeight;

	// Token: 0x0400190E RID: 6414
	[global::Cpp2ILInjected.Token(Token = "0x4001E3A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x298")]
	public bool mouseLeftRelease;

	// Token: 0x0400190F RID: 6415
	[global::Cpp2ILInjected.Token(Token = "0x4001E3B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x299")]
	public bool mouseRightRelease;

	// Token: 0x04001910 RID: 6416
	[global::Cpp2ILInjected.Token(Token = "0x4001E3C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29A")]
	public bool playerInventory;

	// Token: 0x04001911 RID: 6417
	[global::Cpp2ILInjected.Token(Token = "0x4001E3D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x29C")]
	public int stackSplit;

	// Token: 0x04001912 RID: 6418
	[global::Cpp2ILInjected.Token(Token = "0x4001E3E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A0")]
	public bool preventStackSplitReset;

	// Token: 0x04001913 RID: 6419
	[global::Cpp2ILInjected.Token(Token = "0x4001E3F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A4")]
	public int stackCounter;

	// Token: 0x04001914 RID: 6420
	[global::Cpp2ILInjected.Token(Token = "0x4001E40")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2A8")]
	public int stackDelay;

	// Token: 0x04001915 RID: 6421
	[global::Cpp2ILInjected.Token(Token = "0x4001E41")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2AC")]
	public int superFastStack;

	// Token: 0x04001916 RID: 6422
	[global::Cpp2ILInjected.Token(Token = "0x4001E42")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B0")]
	public int timesTriedToFastStack;

	// Token: 0x04001917 RID: 6423
	[global::Cpp2ILInjected.Token(Token = "0x4001E43")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2B8")]
	public Item mouseItem;

	// Token: 0x04001918 RID: 6424
	[global::Cpp2ILInjected.Token(Token = "0x4001E44")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C0")]
	public float mouseItemTime;

	// Token: 0x04001919 RID: 6425
	[global::Cpp2ILInjected.Token(Token = "0x4001E45")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C8")]
	public Item[] mouseItemSource;

	// Token: 0x0400191A RID: 6426
	[global::Cpp2ILInjected.Token(Token = "0x4001E46")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D0")]
	public int mouseItemSourceIndex;

	// Token: 0x0400191B RID: 6427
	[global::Cpp2ILInjected.Token(Token = "0x4001E47")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D4")]
	public int mouseItemSourceContext;

	// Token: 0x0400191C RID: 6428
	[global::Cpp2ILInjected.Token(Token = "0x4001E48")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2D8")]
	public Item guideItem;

	// Token: 0x0400191D RID: 6429
	[global::Cpp2ILInjected.Token(Token = "0x4001E49")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E0")]
	public Item reforgeItem;

	// Token: 0x0400191E RID: 6430
	[global::Cpp2ILInjected.Token(Token = "0x4001E4A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2E8")]
	public float inventoryScale;

	// Token: 0x0400191F RID: 6431
	[global::Cpp2ILInjected.Token(Token = "0x4001E4B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2EC")]
	public Point rulerLineDisplayValues;

	// Token: 0x04001920 RID: 6432
	[global::Cpp2ILInjected.Token(Token = "0x4001E4C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x2F8")]
	public int[] availableRecipe;

	// Token: 0x04001921 RID: 6433
	[global::Cpp2ILInjected.Token(Token = "0x4001E4D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x300")]
	public int lastRecipeUpdateId;

	// Token: 0x04001922 RID: 6434
	[global::Cpp2ILInjected.Token(Token = "0x4001E4E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x304")]
	public int numAvailableRecipes;

	// Token: 0x04001923 RID: 6435
	[global::Cpp2ILInjected.Token(Token = "0x4001E4F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x308")]
	public int focusRecipe;

	// Token: 0x04001924 RID: 6436
	[global::Cpp2ILInjected.Token(Token = "0x4001E50")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x30C")]
	public int myPlayer;

	// Token: 0x04001925 RID: 6437
	[global::Cpp2ILInjected.Token(Token = "0x4001E51")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x310")]
	public int spawnTileX;

	// Token: 0x04001926 RID: 6438
	[global::Cpp2ILInjected.Token(Token = "0x4001E52")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x314")]
	public int spawnTileY;

	// Token: 0x04001927 RID: 6439
	[global::Cpp2ILInjected.Token(Token = "0x4001E53")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x318")]
	public bool npcChatRelease;

	// Token: 0x04001928 RID: 6440
	[global::Cpp2ILInjected.Token(Token = "0x4001E54")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x319")]
	public bool editSign;

	// Token: 0x04001929 RID: 6441
	[global::Cpp2ILInjected.Token(Token = "0x4001E55")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31A")]
	public bool editChest;

	// Token: 0x0400192A RID: 6442
	[global::Cpp2ILInjected.Token(Token = "0x4001E56")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x31C")]
	public int oldNPCShop;

	// Token: 0x0400192B RID: 6443
	[global::Cpp2ILInjected.Token(Token = "0x4001E57")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x320")]
	public bool gameMenu;

	// Token: 0x0400192C RID: 6444
	[global::Cpp2ILInjected.Token(Token = "0x4001E58")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x324")]
	public int menuMode;

	// Token: 0x0400192D RID: 6445
	[global::Cpp2ILInjected.Token(Token = "0x4001E59")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x328")]
	public bool Quitting;

	// Token: 0x0400192E RID: 6446
	[global::Cpp2ILInjected.Token(Token = "0x4001E5A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x330")]
	public List<PlayerFileData> PlayerList;

	// Token: 0x0400192F RID: 6447
	[global::Cpp2ILInjected.Token(Token = "0x4001E5B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x338")]
	public PlayerFileData ActivePlayerFileData;

	// Token: 0x04001930 RID: 6448
	[global::Cpp2ILInjected.Token(Token = "0x4001E5C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x340")]
	public Player PendingPlayer;

	// Token: 0x04001931 RID: 6449
	[global::Cpp2ILInjected.Token(Token = "0x4001E5D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x348")]
	public bool SmartCursorShowing;

	// Token: 0x04001932 RID: 6450
	[global::Cpp2ILInjected.Token(Token = "0x4001E5E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x34C")]
	public int SmartCursorX;

	// Token: 0x04001933 RID: 6451
	[global::Cpp2ILInjected.Token(Token = "0x4001E5F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x350")]
	public int SmartCursorY;

	// Token: 0x04001934 RID: 6452
	[global::Cpp2ILInjected.Token(Token = "0x4001E60")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x354")]
	public bool SmartInteractShowingGenuine;

	// Token: 0x04001935 RID: 6453
	[global::Cpp2ILInjected.Token(Token = "0x4001E61")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x355")]
	public bool SmartInteractShowingFake;

	// Token: 0x04001936 RID: 6454
	[global::Cpp2ILInjected.Token(Token = "0x4001E62")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x358")]
	public int SmartInteractX;

	// Token: 0x04001937 RID: 6455
	[global::Cpp2ILInjected.Token(Token = "0x4001E63")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x35C")]
	public int SmartInteractY;

	// Token: 0x04001938 RID: 6456
	[global::Cpp2ILInjected.Token(Token = "0x4001E64")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x360")]
	public int SmartInteractNPC;

	// Token: 0x04001939 RID: 6457
	[global::Cpp2ILInjected.Token(Token = "0x4001E65")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x364")]
	public int SmartInteractProj;

	// Token: 0x0400193A RID: 6458
	[global::Cpp2ILInjected.Token(Token = "0x4001E66")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x368")]
	public bool SmartInteractPotionOfReturn;

	// Token: 0x0400193B RID: 6459
	[global::Cpp2ILInjected.Token(Token = "0x4001E67")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x370")]
	public Dictionary<int, bool> SmartInteractTileCoords;

	// Token: 0x0400193C RID: 6460
	[global::Cpp2ILInjected.Token(Token = "0x4001E68")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x378")]
	public Dictionary<int, bool> SmartInteractTileCoordsSelected;

	// Token: 0x0400193D RID: 6461
	[global::Cpp2ILInjected.Token(Token = "0x4001E69")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x380")]
	public int TileInteractionLX;

	// Token: 0x0400193E RID: 6462
	[global::Cpp2ILInjected.Token(Token = "0x4001E6A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x384")]
	public int TileInteractionLY;

	// Token: 0x0400193F RID: 6463
	[global::Cpp2ILInjected.Token(Token = "0x4001E6B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x388")]
	public int TileInteractionHX;

	// Token: 0x04001940 RID: 6464
	[global::Cpp2ILInjected.Token(Token = "0x4001E6C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x38C")]
	public int TileInteractionHY;

	// Token: 0x04001941 RID: 6465
	[global::Cpp2ILInjected.Token(Token = "0x4001E6D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x390")]
	public int cursorOverride;

	// Token: 0x04001942 RID: 6466
	[global::Cpp2ILInjected.Token(Token = "0x4001E6E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x394")]
	public int signHover;

	// Token: 0x04001943 RID: 6467
	[global::Cpp2ILInjected.Token(Token = "0x4001E6F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x398")]
	public int lastSignHover;

	// Token: 0x04001944 RID: 6468
	[global::Cpp2ILInjected.Token(Token = "0x4001E70")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x39C")]
	public float GamepadCursorAlpha;

	// Token: 0x04001945 RID: 6469
	[global::Cpp2ILInjected.Token(Token = "0x4001E71")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A0")]
	public int overloadedMousePositionX;

	// Token: 0x04001946 RID: 6470
	[global::Cpp2ILInjected.Token(Token = "0x4001E72")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A4")]
	public int overloadedMousePositionY;

	// Token: 0x04001947 RID: 6471
	[global::Cpp2ILInjected.Token(Token = "0x4001E73")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3A8")]
	public Color mouseColor;

	// Token: 0x04001948 RID: 6472
	[global::Cpp2ILInjected.Token(Token = "0x4001E74")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3AC")]
	public Color MouseBorderColor;

	// Token: 0x04001949 RID: 6473
	[global::Cpp2ILInjected.Token(Token = "0x4001E75")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B0")]
	public Color ControllerColor;

	// Token: 0x0400194A RID: 6474
	[global::Cpp2ILInjected.Token(Token = "0x4001E76")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B4")]
	public Color ControllerBorderColor;

	// Token: 0x0400194B RID: 6475
	[global::Cpp2ILInjected.Token(Token = "0x4001E77")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3B8")]
	public Color cursorColor;

	// Token: 0x0400194C RID: 6476
	[global::Cpp2ILInjected.Token(Token = "0x4001E78")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3BC")]
	public int cursorColorDirection;

	// Token: 0x0400194D RID: 6477
	[global::Cpp2ILInjected.Token(Token = "0x4001E79")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C0")]
	public float cursorAlpha;

	// Token: 0x0400194E RID: 6478
	[global::Cpp2ILInjected.Token(Token = "0x4001E7A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C4")]
	public float cursorScale;

	// Token: 0x0400194F RID: 6479
	[global::Cpp2ILInjected.Token(Token = "0x4001E7B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C8")]
	public bool signBubble;

	// Token: 0x04001950 RID: 6480
	[global::Cpp2ILInjected.Token(Token = "0x4001E7C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3CC")]
	public int signX;

	// Token: 0x04001951 RID: 6481
	[global::Cpp2ILInjected.Token(Token = "0x4001E7D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D0")]
	public int signY;

	// Token: 0x04001952 RID: 6482
	[global::Cpp2ILInjected.Token(Token = "0x4001E7E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D4")]
	public bool hideUI;

	// Token: 0x04001953 RID: 6483
	[global::Cpp2ILInjected.Token(Token = "0x4001E7F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D5")]
	public bool releaseUI;

	// Token: 0x04001954 RID: 6484
	[global::Cpp2ILInjected.Token(Token = "0x4001E80")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D6")]
	public bool renderNow;

	// Token: 0x04001955 RID: 6485
	[global::Cpp2ILInjected.Token(Token = "0x4001E81")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3D8")]
	public int renderCount;

	// Token: 0x04001956 RID: 6486
	[global::Cpp2ILInjected.Token(Token = "0x4001E82")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3DC")]
	public bool render;

	// Token: 0x04001957 RID: 6487
	[global::Cpp2ILInjected.Token(Token = "0x4001E83")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E0")]
	public Stopwatch saveTime;

	// Token: 0x04001958 RID: 6488
	[global::Cpp2ILInjected.Token(Token = "0x4001E84")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3E8")]
	public bool BackgroundEnabled;

	// Token: 0x04001959 RID: 6489
	[global::Cpp2ILInjected.Token(Token = "0x4001E85")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F0")]
	public SceneMetrics SceneMetrics;

	// Token: 0x0400195A RID: 6490
	[global::Cpp2ILInjected.Token(Token = "0x4001E86")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3F8")]
	public int instantBGTransitionCounter;

	// Token: 0x0400195B RID: 6491
	[global::Cpp2ILInjected.Token(Token = "0x4001E87")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x3FC")]
	public int bgDelay;

	// Token: 0x0400195C RID: 6492
	[global::Cpp2ILInjected.Token(Token = "0x4001E88")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x400")]
	public int background;

	// Token: 0x0400195D RID: 6493
	[global::Cpp2ILInjected.Token(Token = "0x4001E89")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x404")]
	public int caveBackground;

	// Token: 0x0400195E RID: 6494
	[global::Cpp2ILInjected.Token(Token = "0x4001E8A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x408")]
	public GolfState LocalGolfState;

	// Token: 0x0400195F RID: 6495
	[global::Cpp2ILInjected.Token(Token = "0x4001E8B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x410")]
	public DroneCameraTracker DroneCameraTracker;

	// Token: 0x04001960 RID: 6496
	[global::Cpp2ILInjected.Token(Token = "0x4001E8C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x418")]
	public Vector2 CurrentPan;

	// Token: 0x04001961 RID: 6497
	[global::Cpp2ILInjected.Token(Token = "0x4001E8D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x420")]
	public float sunCircle;

	// Token: 0x04001962 RID: 6498
	[global::Cpp2ILInjected.Token(Token = "0x4001E8E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x424")]
	public int BlackFadeIn;

	// Token: 0x04001963 RID: 6499
	[global::Cpp2ILInjected.Token(Token = "0x4001E8F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x428")]
	public float ugBackTransition;

	// Token: 0x04001964 RID: 6500
	[global::Cpp2ILInjected.Token(Token = "0x4001E90")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x42C")]
	public int undergroundBackground;

	// Token: 0x04001965 RID: 6501
	[global::Cpp2ILInjected.Token(Token = "0x4001E91")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x430")]
	public int oldUndergroundBackground;

	// Token: 0x04001966 RID: 6502
	[global::Cpp2ILInjected.Token(Token = "0x4001E92")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x434")]
	public int bgStyle;

	// Token: 0x04001967 RID: 6503
	[global::Cpp2ILInjected.Token(Token = "0x4001E93")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x438")]
	public float[] bgAlphaFrontLayer;

	// Token: 0x04001968 RID: 6504
	[global::Cpp2ILInjected.Token(Token = "0x4001E94")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x440")]
	public float[] bgAlphaFarBackLayer;

	// Token: 0x04001969 RID: 6505
	[global::Cpp2ILInjected.Token(Token = "0x4001E95")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x448")]
	public int[] bgFrame;

	// Token: 0x0400196A RID: 6506
	[global::Cpp2ILInjected.Token(Token = "0x4001E96")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x450")]
	public int[] bgFrameCounter;

	// Token: 0x0400196B RID: 6507
	[global::Cpp2ILInjected.Token(Token = "0x4001E97")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x458")]
	public bool mapEnabled;

	// Token: 0x0400196C RID: 6508
	[global::Cpp2ILInjected.Token(Token = "0x4001E98")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x45C")]
	public int invasionProgressMode;

	// Token: 0x0400196D RID: 6509
	[global::Cpp2ILInjected.Token(Token = "0x4001E99")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x460")]
	public bool invasionProgressNearInvasion;

	// Token: 0x0400196E RID: 6510
	[global::Cpp2ILInjected.Token(Token = "0x4001E9A")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x461")]
	public bool placementPreview;

	// Token: 0x0400196F RID: 6511
	[global::Cpp2ILInjected.Token(Token = "0x4001E9B")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x462")]
	public bool autoSave;

	// Token: 0x04001970 RID: 6512
	[global::Cpp2ILInjected.Token(Token = "0x4001E9C")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x464")]
	public Main.AutoPauseMode autoPause;

	// Token: 0x04001971 RID: 6513
	[global::Cpp2ILInjected.Token(Token = "0x4001E9D")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x468")]
	public bool DisableIntenseVisualEffects;

	// Token: 0x04001972 RID: 6514
	[global::Cpp2ILInjected.Token(Token = "0x4001E9E")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x46C")]
	public int WaveQuality;

	// Token: 0x04001973 RID: 6515
	[global::Cpp2ILInjected.Token(Token = "0x4001E9F")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x470")]
	public bool UseStormEffects;

	// Token: 0x04001974 RID: 6516
	[global::Cpp2ILInjected.Token(Token = "0x4001EA0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x471")]
	public bool UseHeatDistortion;

	// Token: 0x04001975 RID: 6517
	[global::Cpp2ILInjected.Token(Token = "0x4001EA1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x474")]
	public float musicVolume;

	// Token: 0x04001976 RID: 6518
	[global::Cpp2ILInjected.Token(Token = "0x4001EA2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x478")]
	public float ambientVolume;

	// Token: 0x04001977 RID: 6519
	[global::Cpp2ILInjected.Token(Token = "0x4001EA3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x47C")]
	public float soundVolume;

	// Token: 0x04001978 RID: 6520
	[global::Cpp2ILInjected.Token(Token = "0x4001EA4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x480")]
	public bool TOWMusicUnlocked;

	// Token: 0x04001979 RID: 6521
	[global::Cpp2ILInjected.Token(Token = "0x4001EA5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x484")]
	public int qaStyle;

	// Token: 0x0400197A RID: 6522
	[global::Cpp2ILInjected.Token(Token = "0x4001EA6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x488")]
	public float caveParallax;

	// Token: 0x0400197B RID: 6523
	[global::Cpp2ILInjected.Token(Token = "0x4001EA7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x48C")]
	public int bgScroll;

	// Token: 0x0400197C RID: 6524
	[global::Cpp2ILInjected.Token(Token = "0x4001EA8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x490")]
	public bool showItemText;

	// Token: 0x0400197D RID: 6525
	[global::Cpp2ILInjected.Token(Token = "0x4001EA9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x491")]
	public bool HidePassword;

	// Token: 0x0400197E RID: 6526
	[global::Cpp2ILInjected.Token(Token = "0x4001EAA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x492")]
	public bool ReversedUpDownArmorSetBonuses;

	// Token: 0x0400197F RID: 6527
	[global::Cpp2ILInjected.Token(Token = "0x4001EAB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x493")]
	public bool SettingsEnabled_TilesSwayInWind;

	// Token: 0x04001980 RID: 6528
	[global::Cpp2ILInjected.Token(Token = "0x4001EAC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x494")]
	public bool cSmartCursorModeIsToggleAndNotHold;

	// Token: 0x04001981 RID: 6529
	[global::Cpp2ILInjected.Token(Token = "0x4001EAD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x498")]
	public float gfxQuality;

	// Token: 0x04001982 RID: 6530
	[global::Cpp2ILInjected.Token(Token = "0x4001EAE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x49C")]
	public float gfxRate;

	// Token: 0x04001983 RID: 6531
	[global::Cpp2ILInjected.Token(Token = "0x4001EAF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A0")]
	public int teamCooldown;

	// Token: 0x04001984 RID: 6532
	[global::Cpp2ILInjected.Token(Token = "0x4001EB0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A4")]
	public bool showFrameRate;

	// Token: 0x04001985 RID: 6533
	[global::Cpp2ILInjected.Token(Token = "0x4001EB1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A5")]
	public bool SettingsSavePending;

	// Token: 0x04001986 RID: 6534
	[global::Cpp2ILInjected.Token(Token = "0x4001EB2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4A8")]
	public WorldMap Map;

	// Token: 0x04001987 RID: 6535
	[global::Cpp2ILInjected.Token(Token = "0x4001EB3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B0")]
	public bool refreshMap;

	// Token: 0x04001988 RID: 6536
	[global::Cpp2ILInjected.Token(Token = "0x4001EB4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B4")]
	public int loadMapLastX;

	// Token: 0x04001989 RID: 6537
	[global::Cpp2ILInjected.Token(Token = "0x4001EB5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B8")]
	public bool loadMapLock;

	// Token: 0x0400198A RID: 6538
	[global::Cpp2ILInjected.Token(Token = "0x4001EB6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4B9")]
	public bool loadMap;

	// Token: 0x0400198B RID: 6539
	[global::Cpp2ILInjected.Token(Token = "0x4001EB7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4BA")]
	public bool loadMapSections;

	// Token: 0x0400198C RID: 6540
	[global::Cpp2ILInjected.Token(Token = "0x4001EB8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4BB")]
	public bool mapReady;

	// Token: 0x0400198D RID: 6541
	[global::Cpp2ILInjected.Token(Token = "0x4001EB9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4BC")]
	public bool updateMap;

	// Token: 0x0400198E RID: 6542
	[global::Cpp2ILInjected.Token(Token = "0x4001EBA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C0")]
	public int mapMinX;

	// Token: 0x0400198F RID: 6543
	[global::Cpp2ILInjected.Token(Token = "0x4001EBB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C4")]
	public int mapMaxX;

	// Token: 0x04001990 RID: 6544
	[global::Cpp2ILInjected.Token(Token = "0x4001EBC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4C8")]
	public int mapMinY;

	// Token: 0x04001991 RID: 6545
	[global::Cpp2ILInjected.Token(Token = "0x4001EBD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4CC")]
	public int mapMaxY;

	// Token: 0x04001992 RID: 6546
	[global::Cpp2ILInjected.Token(Token = "0x4001EBE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D0")]
	public int mapTimeMax;

	// Token: 0x04001993 RID: 6547
	[global::Cpp2ILInjected.Token(Token = "0x4001EBF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D4")]
	public int mapTime;

	// Token: 0x04001994 RID: 6548
	[global::Cpp2ILInjected.Token(Token = "0x4001EC0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D8")]
	public bool clearMap;

	// Token: 0x04001995 RID: 6549
	[global::Cpp2ILInjected.Token(Token = "0x4001EC1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4D9")]
	public bool mapInit;

	// Token: 0x04001996 RID: 6550
	[global::Cpp2ILInjected.Token(Token = "0x4001EC2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4DC")]
	public int mapStyle;

	// Token: 0x04001997 RID: 6551
	[global::Cpp2ILInjected.Token(Token = "0x4001EC3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E0")]
	public float grabMapX;

	// Token: 0x04001998 RID: 6552
	[global::Cpp2ILInjected.Token(Token = "0x4001EC4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E4")]
	public float grabMapY;

	// Token: 0x04001999 RID: 6553
	[global::Cpp2ILInjected.Token(Token = "0x4001EC5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4E8")]
	public float grabMapInitialX;

	// Token: 0x0400199A RID: 6554
	[global::Cpp2ILInjected.Token(Token = "0x4001EC6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4EC")]
	public float grabMapInitialY;

	// Token: 0x0400199B RID: 6555
	[global::Cpp2ILInjected.Token(Token = "0x4001EC7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F0")]
	public bool grabMapInProgress;

	// Token: 0x0400199C RID: 6556
	[global::Cpp2ILInjected.Token(Token = "0x4001EC8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F4")]
	public int miniMapX;

	// Token: 0x0400199D RID: 6557
	[global::Cpp2ILInjected.Token(Token = "0x4001EC9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4F8")]
	public int miniMapY;

	// Token: 0x0400199E RID: 6558
	[global::Cpp2ILInjected.Token(Token = "0x4001ECA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x4FC")]
	public int miniMapWidth;

	// Token: 0x0400199F RID: 6559
	[global::Cpp2ILInjected.Token(Token = "0x4001ECB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x500")]
	public int miniMapHeight;

	// Token: 0x040019A0 RID: 6560
	[global::Cpp2ILInjected.Token(Token = "0x4001ECC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x504")]
	public float mapMinimapScale;

	// Token: 0x040019A1 RID: 6561
	[global::Cpp2ILInjected.Token(Token = "0x4001ECD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x508")]
	public float mapMinimapAlpha;

	// Token: 0x040019A2 RID: 6562
	[global::Cpp2ILInjected.Token(Token = "0x4001ECE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x50C")]
	public float mapOverlayScale;

	// Token: 0x040019A3 RID: 6563
	[global::Cpp2ILInjected.Token(Token = "0x4001ECF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x510")]
	public float mapOverlayAlpha;

	// Token: 0x040019A4 RID: 6564
	[global::Cpp2ILInjected.Token(Token = "0x4001ED0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x514")]
	public bool mapFullscreen;

	// Token: 0x040019A5 RID: 6565
	[global::Cpp2ILInjected.Token(Token = "0x4001ED1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x515")]
	public bool resetMapFull;

	// Token: 0x040019A6 RID: 6566
	[global::Cpp2ILInjected.Token(Token = "0x4001ED2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x518")]
	public int resetMapFullCharacter;

	// Token: 0x040019A7 RID: 6567
	[global::Cpp2ILInjected.Token(Token = "0x4001ED3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x51C")]
	public float mapFullscreenScale;

	// Token: 0x040019A8 RID: 6568
	[global::Cpp2ILInjected.Token(Token = "0x4001ED4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x520")]
	public Vector2 mapFullscreenPos;

	// Token: 0x040019A9 RID: 6569
	[global::Cpp2ILInjected.Token(Token = "0x4001ED5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x528")]
	public bool _MouseOversCanClear;

	// Token: 0x040019AA RID: 6570
	[global::Cpp2ILInjected.Token(Token = "0x4001ED6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x530")]
	public TriggersPack Triggers;

	// Token: 0x040019AB RID: 6571
	[global::Cpp2ILInjected.Token(Token = "0x4001ED7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x538")]
	public MouseState MouseInfo;

	// Token: 0x040019AC RID: 6572
	[global::Cpp2ILInjected.Token(Token = "0x4001ED8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x55C")]
	public MouseState MouseInfoOld;

	// Token: 0x040019AD RID: 6573
	[global::Cpp2ILInjected.Token(Token = "0x4001ED9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x580")]
	public int MouseX;

	// Token: 0x040019AE RID: 6574
	[global::Cpp2ILInjected.Token(Token = "0x4001EDA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x584")]
	public int MouseY;

	// Token: 0x040019AF RID: 6575
	[global::Cpp2ILInjected.Token(Token = "0x4001EDB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x588")]
	public bool LockGamepadTileUseButton;

	// Token: 0x040019B0 RID: 6576
	[global::Cpp2ILInjected.Token(Token = "0x4001EDC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x58C")]
	public int PreUIX;

	// Token: 0x040019B1 RID: 6577
	[global::Cpp2ILInjected.Token(Token = "0x4001EDD")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x590")]
	public int PreUIY;

	// Token: 0x040019B2 RID: 6578
	[global::Cpp2ILInjected.Token(Token = "0x4001EDE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x594")]
	public int PreLockOnX;

	// Token: 0x040019B3 RID: 6579
	[global::Cpp2ILInjected.Token(Token = "0x4001EDF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x598")]
	public int PreLockOnY;

	// Token: 0x040019B4 RID: 6580
	[global::Cpp2ILInjected.Token(Token = "0x4001EE0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x59C")]
	public int ScrollWheelValue;

	// Token: 0x040019B5 RID: 6581
	[global::Cpp2ILInjected.Token(Token = "0x4001EE1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A0")]
	public int ScrollWheelValueOld;

	// Token: 0x040019B6 RID: 6582
	[global::Cpp2ILInjected.Token(Token = "0x4001EE2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A4")]
	public int ScrollWheelDelta;

	// Token: 0x040019B7 RID: 6583
	[global::Cpp2ILInjected.Token(Token = "0x4001EE3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5A8")]
	public int taxRate;

	// Token: 0x040019B8 RID: 6584
	[global::Cpp2ILInjected.Token(Token = "0x4001EE4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5AC")]
	public int tileRangeX;

	// Token: 0x040019B9 RID: 6585
	[global::Cpp2ILInjected.Token(Token = "0x4001EE5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5B0")]
	public int tileRangeY;

	// Token: 0x040019BA RID: 6586
	[global::Cpp2ILInjected.Token(Token = "0x4001EE6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5B4")]
	public int tileTargetX;

	// Token: 0x040019BB RID: 6587
	[global::Cpp2ILInjected.Token(Token = "0x4001EE7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5B8")]
	public int tileTargetY;

	// Token: 0x040019BC RID: 6588
	[global::Cpp2ILInjected.Token(Token = "0x4001EE8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5BC")]
	public int jumpHeight;

	// Token: 0x040019BD RID: 6589
	[global::Cpp2ILInjected.Token(Token = "0x4001EE9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C0")]
	public float jumpSpeed;

	// Token: 0x040019BE RID: 6590
	[global::Cpp2ILInjected.Token(Token = "0x4001EEA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C4")]
	public int BlockInteractionWithProjectiles;

	// Token: 0x040019BF RID: 6591
	[global::Cpp2ILInjected.Token(Token = "0x4001EEB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C8")]
	public bool lastPound;

	// Token: 0x040019C0 RID: 6592
	[global::Cpp2ILInjected.Token(Token = "0x4001EEC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5CC")]
	public int musicNotes;

	// Token: 0x040019C1 RID: 6593
	[global::Cpp2ILInjected.Token(Token = "0x4001EED")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D0")]
	public bool SmartBlocksEnabled;

	// Token: 0x040019C2 RID: 6594
	[global::Cpp2ILInjected.Token(Token = "0x4001EEE")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D1")]
	public bool SmartAxeAfterPickaxe;

	// Token: 0x040019C3 RID: 6595
	[global::Cpp2ILInjected.Token(Token = "0x4001EEF")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5D8")]
	public int[] _specialsCount;

	// Token: 0x040019C4 RID: 6596
	[global::Cpp2ILInjected.Token(Token = "0x4001EF0")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5E0")]
	public Point[][] _specialPositions;

	// Token: 0x040019C5 RID: 6597
	[global::Cpp2ILInjected.Token(Token = "0x4001EF1")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5E8")]
	public WindGrid _windGrid;

	// Token: 0x040019C6 RID: 6598
	[global::Cpp2ILInjected.Token(Token = "0x4001EF2")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5F0")]
	public bool _shouldShowInvisibleBlocks;

	// Token: 0x040019C7 RID: 6599
	[global::Cpp2ILInjected.Token(Token = "0x4001EF3")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5F1")]
	public bool _shouldShowInvisibleBlocks_LastFrame;

	// Token: 0x040019C8 RID: 6600
	[global::Cpp2ILInjected.Token(Token = "0x4001EF4")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x5F8")]
	public ThreadLocal<TileDrawInfo> _currentTileDrawInfo;

	// Token: 0x040019C9 RID: 6601
	[global::Cpp2ILInjected.Token(Token = "0x4001EF5")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x600")]
	public LightMode _mode;

	// Token: 0x040019CA RID: 6602
	[global::Cpp2ILInjected.Token(Token = "0x4001EF6")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x608")]
	private LightingEngine _newEngine;

	// Token: 0x040019CB RID: 6603
	[global::Cpp2ILInjected.Token(Token = "0x4001EF7")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x610")]
	private LegacyLighting _legacyEngine;

	// Token: 0x040019CC RID: 6604
	[global::Cpp2ILInjected.Token(Token = "0x4001EF8")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x618")]
	private ILightingEngine _activeEngineVal;

	// Token: 0x040019CD RID: 6605
	[global::Cpp2ILInjected.Token(Token = "0x4001EF9")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x620")]
	public bool DisableLeftShiftTrashCan;

	// Token: 0x040019CE RID: 6606
	[global::Cpp2ILInjected.Token(Token = "0x4001EFA")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x621")]
	public bool HighlightNewItems;

	// Token: 0x040019CF RID: 6607
	[global::Cpp2ILInjected.Token(Token = "0x4001EFB")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x622")]
	public bool DisableQuickTrash;

	// Token: 0x040019D0 RID: 6608
	[global::Cpp2ILInjected.Token(Token = "0x4001EFC")]
	[global::Cpp2ILInjected.FieldOffset(Offset = "0x623")]
	public bool ChildSafetyDisabled;

	// Token: 0x02000807 RID: 2055
	[CompilerGenerated]
	[global::Cpp2ILInjected.Token(Token = "0x20002BA")]
	[Serializable]
	private sealed class <>c
	{
		// Token: 0x06004903 RID: 18691 RVA: 0x0002EF3A File Offset: 0x0002D13A
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001030")]
		[global::Cpp2ILInjected.Address(RVA = "0xA4090C", Offset = "0xA4090C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static <>c()
		{
			throw null;
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0002EF3D File Offset: 0x0002D13D
		[global::Cpp2ILInjected.Token(Token = "0x6001031")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40968", Offset = "0xA40968", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public <>c()
		{
			throw null;
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x0002EF40 File Offset: 0x0002D140
		[global::Cpp2ILInjected.Token(Token = "0x6001032")]
		[global::Cpp2ILInjected.Address(RVA = "0xA40970", Offset = "0xA40970", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileDrawInfo), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal TileDrawInfo <.ctor>b__331_0()
		{
			throw null;
		}

		// Token: 0x04007CF6 RID: 31990
		[global::Cpp2ILInjected.Token(Token = "0x4001EFD")]
		public static readonly LocalUserGameState.<>c <>9;

		// Token: 0x04007CF7 RID: 31991
		[global::Cpp2ILInjected.Token(Token = "0x4001EFE")]
		public static Func<TileDrawInfo> <>9__331_0;
	}
}
