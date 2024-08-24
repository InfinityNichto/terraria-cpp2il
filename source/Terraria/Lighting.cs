using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Dyes;
using Terraria.GameContent.Liquid;
using Terraria.GameInput;
using Terraria.Graphics;
using Terraria.Graphics.Capture;
using Terraria.Graphics.Light;
using Terraria.Graphics.Renderers;
using Terraria.ID;
using Terraria.IO;
using Terraria.Map;
using Unity.IL2CPP.CompilerServices;

namespace Terraria
{
	// Token: 0x02000315 RID: 789
	[global::Cpp2ILInjected.Token(Token = "0x20003EF")]
	public class Lighting
	{
		// Token: 0x17000360 RID: 864
		// (get) Token: 0x060019E7 RID: 6631 RVA: 0x00026813 File Offset: 0x00024A13
		// (set) Token: 0x060019E8 RID: 6632 RVA: 0x00026816 File Offset: 0x00024A16
		[global::Cpp2ILInjected.Token(Token = "0x1700038B")]
		private static LightMode _mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B78")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4BDE0", Offset = "0xB4BDE0", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get_Mode", ReturnType = typeof(LightMode))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "set_Mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get_NotRetro", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001B79")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4BE2C", Offset = "0xB4BE2C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "set_Mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000361 RID: 865
		// (get) Token: 0x060019E9 RID: 6633 RVA: 0x00026819 File Offset: 0x00024A19
		[global::Cpp2ILInjected.Token(Token = "0x1700038C")]
		private static LightingEngine NewEngine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B7A")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4BE7C", Offset = "0xB4BE7C", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "set_Mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "Initialize", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get_NewEngine", ReturnType = typeof(LightingEngine))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000362 RID: 866
		// (get) Token: 0x060019EA RID: 6634 RVA: 0x0002681C File Offset: 0x00024A1C
		[global::Cpp2ILInjected.Token(Token = "0x1700038D")]
		private static LegacyLighting LegacyEngine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B7B")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4BEC8", Offset = "0xB4BEC8", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "set_Mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "Initialize", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get_LegacyEngine", ReturnType = typeof(LegacyLighting))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000363 RID: 867
		// (get) Token: 0x060019EB RID: 6635 RVA: 0x0002681F File Offset: 0x00024A1F
		// (set) Token: 0x060019EC RID: 6636 RVA: 0x00026822 File Offset: 0x00024A22
		[global::Cpp2ILInjected.Token(Token = "0x1700038E")]
		private static ILightingEngine _activeEngine
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B7C")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4BF14", Offset = "0xB4BF14", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "Initialize", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "LightTiles", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "Brightness", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetSubLight", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "Clear", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
			{
				typeof(Point),
				typeof(Color)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(Color)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColorClamped", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(Color)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColorVector3", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Vector3))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetLightMap", MemberParameters = new object[] { typeof(ref Rectangle) }, ReturnType = typeof(LightMap))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetScanRegion", ReturnType = typeof(Rectangle))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor9Slice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ref Color[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor9Slice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ref Vector3[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetCornerColors", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ref VertexColors),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor4Slice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ref Color[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "GetColor4Slice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(ref Vector3[])
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 43)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001B7D")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4BF60", Offset = "0xB4BF60", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "set_Mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000364 RID: 868
		// (get) Token: 0x060019ED RID: 6637 RVA: 0x00026825 File Offset: 0x00024A25
		// (set) Token: 0x060019EE RID: 6638 RVA: 0x00026828 File Offset: 0x00024A28
		[global::Cpp2ILInjected.Token(Token = "0x1700038F")]
		public static float GlobalBrightness
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B7E")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4BFB0", Offset = "0xB4BFB0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6001B7F")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4C008", Offset = "0xB4C008", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060019EF RID: 6639 RVA: 0x0002682B File Offset: 0x00024A2B
		[global::Cpp2ILInjected.Token(Token = "0x6001B80")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4C06C", Offset = "0xB4C06C", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SelectPlayer", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMinY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMaxX", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapMaxY", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_updateMap", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_mapTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_renderCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void ResetLighting()
		{
			throw null;
		}

		// Token: 0x17000365 RID: 869
		// (get) Token: 0x060019F0 RID: 6640 RVA: 0x0002682E File Offset: 0x00024A2E
		// (set) Token: 0x060019F1 RID: 6641 RVA: 0x00026831 File Offset: 0x00024A31
		[global::Cpp2ILInjected.Token(Token = "0x17000390")]
		public static LightMode Mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B81")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4C138", Offset = "0xB4C138", Length = "0x4C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "GetValue", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "get_UsingNewLighting", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "NextLightMode", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SaveSettings", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBlack", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EnsureRenderTargetContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "InitTargets", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__mode", ReturnType = typeof(LightMode))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6001B82")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4C184", Offset = "0xB4C184", Length = "0x158")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUISettingsOverlay), Member = "ResetSetting", MemberParameters = new object[] { typeof(GUISettingID) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPulldownSetting), Member = "SetOption", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "Initialize", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "NextLightMode", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadSettings", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OpenLegacySettings", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "EnsureRenderTargetContent", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "InitTargets", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "set__mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__mode", ReturnType = typeof(LightMode))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_LegacyEngine", ReturnType = typeof(LegacyLighting))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "set__activeEngine", MemberParameters = new object[] { typeof(ILightingEngine) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_NewEngine", ReturnType = typeof(LightingEngine))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_renderCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_renderNow", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000366 RID: 870
		// (get) Token: 0x060019F2 RID: 6642 RVA: 0x00026834 File Offset: 0x00024A34
		[global::Cpp2ILInjected.Token(Token = "0x17000391")]
		public static bool NotRetro
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B83")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4C2DC", Offset = "0xB4C2DC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCurrentBackground", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMagmaLayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawRockLayer", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OldDrawBackground", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawLiquid", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(int),
				typeof(float),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetBackColor", MemberParameters = new object[]
			{
				typeof(Main.InfoToSetBackColor),
				typeof(ref Color),
				typeof(ref Color)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(bool),
				typeof(bool),
				typeof(bool),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__mode", ReturnType = typeof(LightMode))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x060019F3 RID: 6643 RVA: 0x00026837 File Offset: 0x00024A37
		[global::Cpp2ILInjected.Token(Token = "0x17000392")]
		public static bool UsingNewLighting
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B84")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4C334", Offset = "0xB4C334", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "GetAreaToLight", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(ref int),
				typeof(ref int),
				typeof(ref int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_Mode", ReturnType = typeof(LightMode))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x060019F4 RID: 6644 RVA: 0x0002683A File Offset: 0x00024A3A
		[global::Cpp2ILInjected.Token(Token = "0x17000393")]
		public static bool UpdateEveryFrame
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001B85")]
			[global::Cpp2ILInjected.Address(RVA = "0xB4C38C", Offset = "0xB4C38C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "PreDrawTiles", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060019F5 RID: 6645 RVA: 0x0002683D File Offset: 0x00024A3D
		[global::Cpp2ILInjected.Token(Token = "0x6001B86")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4C394", Offset = "0xB4C394", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "SetDisplayMode", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_NewEngine", ReturnType = typeof(LightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LightingEngine), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_LegacyEngine", ReturnType = typeof(LegacyLighting))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LegacyLighting), Member = "Rebuild", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "set_Mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Initialize(bool resized = false)
		{
			throw null;
		}

		// Token: 0x060019F6 RID: 6646 RVA: 0x00026840 File Offset: 0x00024A40
		[global::Cpp2ILInjected.Token(Token = "0x6001B87")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4C46C", Offset = "0xB4C46C", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCapture", MemberParameters = new object[]
		{
			typeof(Rectangle),
			typeof(CaptureSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "UpdateWeather", MemberParameters = new object[]
		{
			typeof(GameTime),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoLightTiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_render", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "UpdateGlobalBrightness", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static void LightTiles(int firstX, int lastX, int firstY, int lastY)
		{
			throw null;
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x00026843 File Offset: 0x00024A43
		[global::Cpp2ILInjected.Token(Token = "0x6001B88")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4C5D4", Offset = "0xB4C5D4", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "LightTiles", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_myPlayer", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void UpdateGlobalBrightness()
		{
			throw null;
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x00026846 File Offset: 0x00024A46
		[global::Cpp2ILInjected.Token(Token = "0x6001B89")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4C6F8", Offset = "0xB4C6F8", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCDirect", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(NPC),
			typeof(bool),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_14_EntityHealthBars", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawInterface_Healthbar_Worm", MemberParameters = new object[]
		{
			typeof(NPC),
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWires", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static float Brightness(int x, int y)
		{
			throw null;
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x00026849 File Offset: 0x00024A49
		[global::Cpp2ILInjected.Token(Token = "0x6001B8A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4C840", Offset = "0xB4C840", Length = "0x3E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ReflectiveArmorShaderData), Member = "Apply", MemberParameters = new object[]
		{
			typeof(Entity),
			typeof(DrawData?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static Vector3 GetSubLight(Vector2 position)
		{
			throw null;
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0002684C File Offset: 0x00024A4C
		[global::Cpp2ILInjected.Token(Token = "0x6001B8B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4CC24", Offset = "0xB4CC24", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 46)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void AddLight(Vector2 position, Vector3 rgb)
		{
			throw null;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0002684F File Offset: 0x00024A4F
		[global::Cpp2ILInjected.Token(Token = "0x6001B8C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4CED4", Offset = "0xB4CED4", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 82)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void AddLight(Vector2 position, float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x00026852 File Offset: 0x00024A52
		[global::Cpp2ILInjected.Token(Token = "0x6001B8D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4CF8C", Offset = "0xB4CF8C", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Dust), Member = "UpdateDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TorchID), Member = "TorchColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void AddLight(int i, int j, int torchID, float lightAmount)
		{
			throw null;
		}

		// Token: 0x060019FD RID: 6653 RVA: 0x00026855 File Offset: 0x00024A55
		[global::Cpp2ILInjected.Token(Token = "0x6001B8E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4D178", Offset = "0xB4D178", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Item), Member = "UpdateItem_VisualEffects", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NPC), Member = "AI_001_Slimes", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TorchID), Member = "TorchColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref float),
			typeof(ref float),
			typeof(ref float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void AddLight(Vector2 position, int torchID)
		{
			throw null;
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x00026858 File Offset: 0x00024A58
		[global::Cpp2ILInjected.Token(Token = "0x6001B8F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4CCDC", Offset = "0xB4CCDC", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 136)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHostOnly", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(LocalUserGameState), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void AddLight(int i, int j, float r, float g, float b)
		{
			throw null;
		}

		// Token: 0x060019FF RID: 6655 RVA: 0x0002685B File Offset: 0x00024A5B
		[global::Cpp2ILInjected.Token(Token = "0x6001B90")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4D290", Offset = "0xB4D290", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get_Mode", ReturnType = typeof(LightMode))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "set_Mode", MemberParameters = new object[] { typeof(LightMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "IsDefined", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void NextLightMode()
		{
			throw null;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0002685E File Offset: 0x00024A5E
		[global::Cpp2ILInjected.Token(Token = "0x6001B91")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4D3DC", Offset = "0xB4D3DC", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Lighting), Member = "NextLightMode", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main.<>c", Member = "<Initialize>b__1845_0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoDraw_UpdateCameraPosition", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Teleport", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "Spawn", MemberParameters = new object[] { typeof(PlayerSpawnContext) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldMap), Member = "Load", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void Clear()
		{
			throw null;
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x00026861 File Offset: 0x00024A61
		[global::Cpp2ILInjected.Token(Token = "0x6001B92")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4D49C", Offset = "0xB4D49C", Length = "0x1FC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 32)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static Color GetColor(Point tileCoords)
		{
			throw null;
		}

		// Token: 0x06001A02 RID: 6658 RVA: 0x00026864 File Offset: 0x00024A64
		[global::Cpp2ILInjected.Token(Token = "0x6001B93")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4D698", Offset = "0xB4D698", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawWhip", MemberParameters = new object[] { typeof(Projectile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Color GetColor(Point tileCoords, Color originalColor)
		{
			throw null;
		}

		// Token: 0x06001A03 RID: 6659 RVA: 0x00026867 File Offset: 0x00024A67
		[global::Cpp2ILInjected.Token(Token = "0x6001B94")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4D854", Offset = "0xB4D854", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProj_FishingLine", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(ref float),
			typeof(ref float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawPlayerStoned", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LegacyPlayerRenderer), Member = "DrawGhost", MemberParameters = new object[]
		{
			typeof(Camera),
			typeof(Player),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static Color GetColor(int x, int y, Color oldColor)
		{
			throw null;
		}

		// Token: 0x06001A04 RID: 6660 RVA: 0x0002686A File Offset: 0x00024A6A
		[global::Cpp2ILInjected.Token(Token = "0x6001B95")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4DA10", Offset = "0xB4DA10", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawPlayer_21_Head", MemberParameters = new object[] { typeof(ref PlayerDrawSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "Min", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "ToVector3", ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(Vector3)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[] { typeof(Vector3) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static Color GetColorClamped(int x, int y, Color oldColor)
		{
			throw null;
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0002686D File Offset: 0x00024A6D
		[global::Cpp2ILInjected.Token(Token = "0x6001B96")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4DC10", Offset = "0xB4DC10", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawSet), Member = "BoringSetup", MemberParameters = new object[]
		{
			typeof(Player),
			typeof(DrawData[]),
			typeof(List<int>),
			typeof(List<int>),
			typeof(Vector2),
			typeof(float),
			typeof(float),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static Vector3 GetColorVector3(int x, int y)
		{
			throw null;
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x00026870 File Offset: 0x00024A70
		[global::Cpp2ILInjected.Token(Token = "0x6001B97")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4DD84", Offset = "0xB4DD84", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawNPCs", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCachedNPCs", MemberParameters = new object[]
		{
			typeof(List<int>),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawDust", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawCurrentBackground", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawMagmaLayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawRockLayer", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawBlack", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LockOnHelper), Member = "RefreshTargets", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawTiles", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawLiquidBehindTiles", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "DrawVineStrip", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = "DrawWalls", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LiquidRenderer), Member = "DrawNormalLiquids", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(Vector2),
			typeof(int),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static LightMap GetLightMap(out Rectangle lightMapRegion)
		{
			throw null;
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x00026873 File Offset: 0x00024A73
		[global::Cpp2ILInjected.Token(Token = "0x6001B98")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4DE4C", Offset = "0xB4DE4C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapHelper), Member = "CreateMapTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte)
		}, ReturnType = typeof(MapTile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static Rectangle GetScanRegion()
		{
			throw null;
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x00026876 File Offset: 0x00024A76
		[global::Cpp2ILInjected.Token(Token = "0x6001B99")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4BB50", Offset = "0xB4BB50", Length = "0x210")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 131)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_gameMenu", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static Color GetColor(int x, int y)
		{
			throw null;
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x00026879 File Offset: 0x00024A79
		[global::Cpp2ILInjected.Token(Token = "0x6001B9A")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4DF0C", Offset = "0xB4DF0C", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OldDrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void GetColor9Slice(int centerX, int centerY, ref Color[] slices)
		{
			throw null;
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0002687C File Offset: 0x00024A7C
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[Il2CppSetOption(/*Failed to decode CustomAttribute blob!*/)]
		[global::Cpp2ILInjected.Token(Token = "0x6001B9B")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4E1D4", Offset = "0xB4E1D4", Length = "0x82C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		public static void GetColor9Slice(int x, int y, ref Vector3[] slices)
		{
			throw null;
		}

		// Token: 0x06001A0B RID: 6667 RVA: 0x0002687F File Offset: 0x00024A7F
		[global::Cpp2ILInjected.Token(Token = "0x6001B9C")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4EA00", Offset = "0xB4EA00", Length = "0x7D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OldDrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "set_PackedValue", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static void GetCornerColors(int centerX, int centerY, out VertexColors vertices, float scale = 1f)
		{
			throw null;
		}

		// Token: 0x06001A0C RID: 6668 RVA: 0x00026882 File Offset: 0x00024A82
		[global::Cpp2ILInjected.Token(Token = "0x6001B9D")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4F1D4", Offset = "0xB4F1D4", Length = "0xCB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "OldDrawBackground", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		public static void GetColor4Slice(int centerX, int centerY, ref Color[] slices)
		{
			throw null;
		}

		// Token: 0x06001A0D RID: 6669 RVA: 0x00026885 File Offset: 0x00024A85
		[global::Cpp2ILInjected.Token(Token = "0x6001B9E")]
		[global::Cpp2ILInjected.Address(RVA = "0xB4FE88", Offset = "0xB4FE88", Length = "0x534")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "get__activeEngine", ReturnType = typeof(ILightingEngine))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public static void GetColor4Slice(int x, int y, ref Vector3[] slices)
		{
			throw null;
		}

		// Token: 0x06001A0E RID: 6670 RVA: 0x00026888 File Offset: 0x00024A88
		[global::Cpp2ILInjected.Token(Token = "0x6001B9F")]
		[global::Cpp2ILInjected.Address(RVA = "0xB503BC", Offset = "0xB503BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Lighting()
		{
			throw null;
		}

		// Token: 0x06001A0F RID: 6671 RVA: 0x0002688B File Offset: 0x00024A8B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BA0")]
		[global::Cpp2ILInjected.Address(RVA = "0xB503C4", Offset = "0xB503C4", Length = "0x104C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static Lighting()
		{
			throw null;
		}

		// Token: 0x0400225B RID: 8795
		[global::Cpp2ILInjected.Token(Token = "0x40028CD")]
		private const float DEFAULT_GLOBAL_BRIGHTNESS = 1.2f;

		// Token: 0x0400225C RID: 8796
		[global::Cpp2ILInjected.Token(Token = "0x40028CE")]
		private const float BLIND_GLOBAL_BRIGHTNESS = 1f;

		// Token: 0x0400225D RID: 8797
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40028CF")]
		private static float <GlobalBrightness>k__BackingField;

		// Token: 0x0400225E RID: 8798
		[Obsolete]
		[global::Cpp2ILInjected.Token(Token = "0x40028D0")]
		public static int OffScreenTiles;
	}
}
