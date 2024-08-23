using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Audio;
using Terraria.DataStructures;
using Terraria.Enums;
using Terraria.GameContent;
using Terraria.Graphics.Shaders;
using Terraria.Localization;
using Terraria.Utilities;

namespace Terraria
{
	// Token: 0x02000327 RID: 807
	[global::Cpp2ILInjected.Token(Token = "0x2000428")]
	public static class DelegateMethods
	{
		// Token: 0x060025B8 RID: 9656 RVA: 0x00028B77 File Offset: 0x00026D77
		[global::Cpp2ILInjected.Token(Token = "0x60027B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C8734", Offset = "0x10C8734", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Color ColorLerp_BlackToWhite(float percent)
		{
			throw null;
		}

		// Token: 0x060025B9 RID: 9657 RVA: 0x00028B7A File Offset: 0x00026D7A
		[global::Cpp2ILInjected.Token(Token = "0x60027B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C87AC", Offset = "0x10C87AC", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static Color ColorLerp_HSL_H(float percent)
		{
			throw null;
		}

		// Token: 0x060025BA RID: 9658 RVA: 0x00028B7D File Offset: 0x00026D7D
		[global::Cpp2ILInjected.Token(Token = "0x60027B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C8820", Offset = "0x10C8820", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Color ColorLerp_HSL_S(float percent)
		{
			throw null;
		}

		// Token: 0x060025BB RID: 9659 RVA: 0x00028B80 File Offset: 0x00026D80
		[global::Cpp2ILInjected.Token(Token = "0x60027B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C88D0", Offset = "0x10C88D0", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static Color ColorLerp_HSL_L(float percent)
		{
			throw null;
		}

		// Token: 0x060025BC RID: 9660 RVA: 0x00028B83 File Offset: 0x00026D83
		[global::Cpp2ILInjected.Token(Token = "0x60027B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C8994", Offset = "0x10C8994", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static Color ColorLerp_HSL_O(float percent)
		{
			throw null;
		}

		// Token: 0x060025BD RID: 9661 RVA: 0x00028B86 File Offset: 0x00026D86
		[global::Cpp2ILInjected.Token(Token = "0x60027BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C8A8C", Offset = "0x10C8A8C", Length = "0xA00")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "TryKillingReplaceableTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "topSlope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "halfBrick", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SlopeTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "bottomSlope", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 36)]
		public static bool SpreadDirt(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025BE RID: 9662 RVA: 0x00028B89 File Offset: 0x00026D89
		[global::Cpp2ILInjected.Token(Token = "0x60027BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C948C", Offset = "0x10C948C", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "dustWater", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static bool SpreadWater(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025BF RID: 9663 RVA: 0x00028B8C File Offset: 0x00026D8C
		[global::Cpp2ILInjected.Token(Token = "0x60027BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C9784", Offset = "0x10C9784", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool SpreadHoney(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C0 RID: 9664 RVA: 0x00028B8F File Offset: 0x00026D8F
		[global::Cpp2ILInjected.Token(Token = "0x60027BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C9A48", Offset = "0x10C9A48", Length = "0x2A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "PlaceLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool SpreadLava(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C1 RID: 9665 RVA: 0x00028B92 File Offset: 0x00026D92
		[global::Cpp2ILInjected.Token(Token = "0x60027BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C9CE8", Offset = "0x10C9CE8", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "EmptyLiquid", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustDirect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool SpreadDry(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C2 RID: 9666 RVA: 0x00028B95 File Offset: 0x00026D95
		[global::Cpp2ILInjected.Token(Token = "0x60027BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C9F90", Offset = "0x10C9F90", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "SolidTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_wall", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static bool SpreadTest(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C3 RID: 9667 RVA: 0x00028B98 File Offset: 0x00026D98
		[global::Cpp2ILInjected.Token(Token = "0x60027C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CA07C", Offset = "0x10CA07C", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public static bool TestDust(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C4 RID: 9668 RVA: 0x00028B9B File Offset: 0x00026D9B
		[global::Cpp2ILInjected.Token(Token = "0x60027C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CA244", Offset = "0x10CA244", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static bool CastLightFunc(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C5 RID: 9669 RVA: 0x00028B9E File Offset: 0x00026D9E
		[global::Cpp2ILInjected.Token(Token = "0x60027C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CA3C8", Offset = "0x10CA3C8", Length = "0x270")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "inActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool CastLightOpenFunc(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C6 RID: 9670 RVA: 0x00028BA1 File Offset: 0x00026DA1
		[global::Cpp2ILInjected.Token(Token = "0x60027C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CA638", Offset = "0x10CA638", Length = "0x21C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "inActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static bool CheckStopForSolids(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C7 RID: 9671 RVA: 0x00028BA4 File Offset: 0x00026DA4
		[global::Cpp2ILInjected.Token(Token = "0x60027C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CA854", Offset = "0x10CA854", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "inActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector3),
			typeof(float)
		}, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static bool CastLightOpen_StopForSolids_ScaleWithDistance(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C8 RID: 9672 RVA: 0x00028BA7 File Offset: 0x00026DA7
		[global::Cpp2ILInjected.Token(Token = "0x60027C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CABA4", Offset = "0x10CABA4", Length = "0x284")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "inActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static bool CastLightOpen_StopForSolids(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025C9 RID: 9673 RVA: 0x00028BAA File Offset: 0x00026DAA
		[global::Cpp2ILInjected.Token(Token = "0x60027C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CAE28", Offset = "0x10CAE28", Length = "0x2A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Distance", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "inActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Lighting), Member = "AddLight", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static bool SpreadLightOpen_StopForSolids(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025CA RID: 9674 RVA: 0x00028BAD File Offset: 0x00026DAD
		[global::Cpp2ILInjected.Token(Token = "0x60027C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CB0D0", Offset = "0x10CB0D0", Length = "0x2F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "inActive", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(int),
			typeof(Vector2?),
			typeof(int),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Dust))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public static bool EmitGolfCartDust_StopForSolids(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025CB RID: 9675 RVA: 0x00028BB0 File Offset: 0x00026DB0
		[global::Cpp2ILInjected.Token(Token = "0x60027C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CB3C0", Offset = "0x10CB3C0", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartCursorHelper), Member = "Step_WallsCell", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_frameX", ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool NotDoorStand(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025CC RID: 9676 RVA: 0x00028BB3 File Offset: 0x00026DB3
		[global::Cpp2ILInjected.Token(Token = "0x60027C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CB554", Offset = "0x10CB554", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "CanCutTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileCuttingContext)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "KillTile", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(NetworkText),
			typeof(int),
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static bool CutTiles(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025CD RID: 9677 RVA: 0x00028BB6 File Offset: 0x00026DB6
		[global::Cpp2ILInjected.Token(Token = "0x60027CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CB7CC", Offset = "0x10CB7CC", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WorldGen), Member = "InWorld", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static bool SearchAvoidedByNPCsImp(int x, int y)
		{
			throw null;
		}

		// Token: 0x060025CE RID: 9678 RVA: 0x00028BB9 File Offset: 0x00026DB9
		[global::Cpp2ILInjected.Token(Token = "0x60027CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CB944", Offset = "0x10CB944", Length = "0x2EC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public static void RainbowLaserDraw(int stage, out float distCovered, out Rectangle frame, out Vector2 origin, out Color color)
		{
			throw null;
		}

		// Token: 0x060025CF RID: 9679 RVA: 0x00028BBC File Offset: 0x00026DBC
		[global::Cpp2ILInjected.Token(Token = "0x60027CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CBC30", Offset = "0x10CBC30", Length = "0x33C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void TurretLaserDraw(int stage, out float distCovered, out Rectangle frame, out Vector2 origin, out Color color)
		{
			throw null;
		}

		// Token: 0x060025D0 RID: 9680 RVA: 0x00028BBF File Offset: 0x00026DBF
		[global::Cpp2ILInjected.Token(Token = "0x60027CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CBF6C", Offset = "0x10CBF6C", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void LightningLaserDraw(int stage, out float distCovered, out Rectangle frame, out Vector2 origin, out Color color)
		{
			throw null;
		}

		// Token: 0x060025D1 RID: 9681 RVA: 0x00028BC2 File Offset: 0x00026DC2
		[global::Cpp2ILInjected.Token(Token = "0x60027CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CC278", Offset = "0x10CC278", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		public static int CompareYReverse(Point a, Point b)
		{
			throw null;
		}

		// Token: 0x060025D2 RID: 9682 RVA: 0x00028BC5 File Offset: 0x00026DC5
		[global::Cpp2ILInjected.Token(Token = "0x60027CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CC2A0", Offset = "0x10CC2A0", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "CompareTo", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(int))]
		public static int CompareDrawSorterByYScale(DrawData a, DrawData b)
		{
			throw null;
		}

		// Token: 0x060025D3 RID: 9683 RVA: 0x00028BC8 File Offset: 0x00026DC8
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60027D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x10CC2B0", Offset = "0x10CC2B0", Length = "0x244")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils.TileActionAttempt), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		static DelegateMethods()
		{
			throw null;
		}

		// Token: 0x04002CB5 RID: 11445
		[global::Cpp2ILInjected.Token(Token = "0x40033D4")]
		public static Vector3 v3_1;

		// Token: 0x04002CB6 RID: 11446
		[global::Cpp2ILInjected.Token(Token = "0x40033D5")]
		public static Vector2 v2_1;

		// Token: 0x04002CB7 RID: 11447
		[global::Cpp2ILInjected.Token(Token = "0x40033D6")]
		public static float f_1;

		// Token: 0x04002CB8 RID: 11448
		[global::Cpp2ILInjected.Token(Token = "0x40033D7")]
		public static Color c_1;

		// Token: 0x04002CB9 RID: 11449
		[global::Cpp2ILInjected.Token(Token = "0x40033D8")]
		public static int i_1;

		// Token: 0x04002CBA RID: 11450
		[global::Cpp2ILInjected.Token(Token = "0x40033D9")]
		public static bool CheckResultOut;

		// Token: 0x04002CBB RID: 11451
		[global::Cpp2ILInjected.Token(Token = "0x40033DA")]
		public static TileCuttingContext tilecut_0;

		// Token: 0x04002CBC RID: 11452
		[global::Cpp2ILInjected.Token(Token = "0x40033DB")]
		public static bool[] tileCutIgnore;

		// Token: 0x04002CBD RID: 11453
		[global::Cpp2ILInjected.Token(Token = "0x40033DC")]
		public static Utils.TileActionAttempt CastLight;

		// Token: 0x04002CBE RID: 11454
		[global::Cpp2ILInjected.Token(Token = "0x40033DD")]
		public static Utils.TileActionAttempt CastLightOpen;

		// Token: 0x04002CBF RID: 11455
		[global::Cpp2ILInjected.Token(Token = "0x40033DE")]
		public static Utils.TileActionAttempt SearchAvoidedByNPCs;

		// Token: 0x0200085B RID: 2139
		[global::Cpp2ILInjected.Token(Token = "0x2000429")]
		public static class CharacterPreview
		{
			// Token: 0x060049C8 RID: 18888 RVA: 0x0002F129 File Offset: 0x0002D329
			[global::Cpp2ILInjected.Token(Token = "0x60027D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CC4F4", Offset = "0x10CC4F4", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegateMethods.CharacterPreview), Member = "Float", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FloatArray_3), Member = "set_Item", MemberParameters = new object[]
			{
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static void EtsyPet(Projectile proj, bool walking)
			{
				throw null;
			}

			// Token: 0x060049C9 RID: 18889 RVA: 0x0002F12C File Offset: 0x0002D32C
			[global::Cpp2ILInjected.Token(Token = "0x60027D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CC678", Offset = "0x10CC678", Length = "0x184")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiLerp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float[])
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			public static void CompanionCubePet(Projectile proj, bool walking)
			{
				throw null;
			}

			// Token: 0x060049CA RID: 18890 RVA: 0x0002F12F File Offset: 0x0002D32F
			[global::Cpp2ILInjected.Token(Token = "0x60027D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CC7FC", Offset = "0x10CC7FC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static void BerniePet(Projectile proj, bool walking)
			{
				throw null;
			}

			// Token: 0x060049CB RID: 18891 RVA: 0x0002F132 File Offset: 0x0002D332
			[global::Cpp2ILInjected.Token(Token = "0x60027D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CC814", Offset = "0x10CC814", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
			{
				typeof(Array),
				typeof(RuntimeFieldHandle)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "MultiLerp", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float[])
			}, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			public static void SlimePet(Projectile proj, bool walking)
			{
				throw null;
			}

			// Token: 0x060049CC RID: 18892 RVA: 0x0002F135 File Offset: 0x0002D335
			[global::Cpp2ILInjected.Token(Token = "0x60027D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CC920", Offset = "0x10CC920", Length = "0x274")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(double),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToRotation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public static void WormPet(Projectile proj, bool walking)
			{
				throw null;
			}

			// Token: 0x060049CD RID: 18893 RVA: 0x0002F138 File Offset: 0x0002D338
			[global::Cpp2ILInjected.Token(Token = "0x60027D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CCB94", Offset = "0x10CCB94", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegateMethods.CharacterPreview), Member = "Float", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			public static void FloatAndSpinWhenWalking(Projectile proj, bool walking)
			{
				throw null;
			}

			// Token: 0x060049CE RID: 18894 RVA: 0x0002F13B File Offset: 0x0002D33B
			[global::Cpp2ILInjected.Token(Token = "0x60027D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CCC34", Offset = "0x10CCC34", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegateMethods.CharacterPreview), Member = "Float", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(bool)
			}, ReturnType = typeof(void))]
			public static void FloatAndRotateForwardWhenWalking(Projectile proj, bool walking)
			{
				throw null;
			}

			// Token: 0x060049CF RID: 18895 RVA: 0x0002F13E File Offset: 0x0002D33E
			[global::Cpp2ILInjected.Token(Token = "0x60027D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CC5A8", Offset = "0x10CC5A8", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.CharacterPreview), Member = "EtsyPet", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.CharacterPreview), Member = "FloatAndSpinWhenWalking", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.CharacterPreview), Member = "FloatAndRotateForwardWhenWalking", MemberParameters = new object[]
			{
				typeof(Projectile),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			public static void Float(Projectile proj, bool walking)
			{
				throw null;
			}

			// Token: 0x060049D0 RID: 18896 RVA: 0x0002F141 File Offset: 0x0002D341
			[global::Cpp2ILInjected.Token(Token = "0x60027D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CCC70", Offset = "0x10CCC70", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static void RotateForwardWhenWalking(Projectile proj, bool walking)
			{
				throw null;
			}
		}

		// Token: 0x0200085C RID: 2140
		[global::Cpp2ILInjected.Token(Token = "0x200042A")]
		public static class Mount
		{
			// Token: 0x060049D1 RID: 18897 RVA: 0x0002F144 File Offset: 0x0002D344
			[global::Cpp2ILInjected.Token(Token = "0x60027DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CCC8C", Offset = "0x10CCC8C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static bool NoHandPosition(Player player, out Vector2? position)
			{
				throw null;
			}

			// Token: 0x060049D2 RID: 18898 RVA: 0x0002F147 File Offset: 0x0002D347
			[global::Cpp2ILInjected.Token(Token = "0x60027DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CCC9C", Offset = "0x10CCC9C", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "get_MountedCenter", ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Player), Member = "RotatedRelativePoint", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(bool),
				typeof(bool)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(double),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			public static bool WolfMouthPosition(Player player, out Vector2? position)
			{
				throw null;
			}
		}

		// Token: 0x0200085D RID: 2141
		[global::Cpp2ILInjected.Token(Token = "0x200042B")]
		public static class Minecart
		{
			// Token: 0x060049D3 RID: 18899 RVA: 0x0002F14A File Offset: 0x0002D34A
			[global::Cpp2ILInjected.Token(Token = "0x60027DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CCE10", Offset = "0x10CCE10", Length = "0x3C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(double),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			public static void Sparks(Vector2 dustPosition)
			{
				throw null;
			}

			// Token: 0x060049D4 RID: 18900 RVA: 0x0002F14D File Offset: 0x0002D34D
			[global::Cpp2ILInjected.Token(Token = "0x60027DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CD1D0", Offset = "0x10CD1D0", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public static void JumpingSound(Player Player, Vector2 Position, int Width, int Height)
			{
				throw null;
			}

			// Token: 0x060049D5 RID: 18901 RVA: 0x0002F150 File Offset: 0x0002D350
			[global::Cpp2ILInjected.Token(Token = "0x60027DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CD1D4", Offset = "0x10CD1D4", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(LegacySoundStyle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void LandingSound(Player Player, Vector2 Position, int Width, int Height)
			{
				throw null;
			}

			// Token: 0x060049D6 RID: 18902 RVA: 0x0002F153 File Offset: 0x0002D353
			[global::Cpp2ILInjected.Token(Token = "0x60027DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CD28C", Offset = "0x10CD28C", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(LegacySoundStyle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void BumperSound(Player Player, Vector2 Position, int Width, int Height)
			{
				throw null;
			}

			// Token: 0x060049D7 RID: 18903 RVA: 0x0002F156 File Offset: 0x0002D356
			[global::Cpp2ILInjected.Token(Token = "0x60027E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CD344", Offset = "0x10CD344", Length = "0x964")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.Minecart), Member = "JumpingSoundFart", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Vector2),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.Minecart), Member = "LandingSoundFart", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Vector2),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.Minecart), Member = "BumperSoundFart", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Vector2),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "SafeNormalize", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Gore), Member = "NewGore", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2),
				typeof(int),
				typeof(float)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2?), Member = ".ctor", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDustPerfect", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(Vector2?),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Dust))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
			public static void SpawnFartCloud(Player Player, Vector2 Position, int Width, int Height, bool useDelay = true)
			{
				throw null;
			}

			// Token: 0x060049D8 RID: 18904 RVA: 0x0002F159 File Offset: 0x0002D359
			[global::Cpp2ILInjected.Token(Token = "0x60027E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CED94", Offset = "0x10CED94", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(LegacySoundStyle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegateMethods.Minecart), Member = "SpawnFartCloud", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void JumpingSoundFart(Player Player, Vector2 Position, int Width, int Height)
			{
				throw null;
			}

			// Token: 0x060049D9 RID: 18905 RVA: 0x0002F15C File Offset: 0x0002D35C
			[global::Cpp2ILInjected.Token(Token = "0x60027E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CEE6C", Offset = "0x10CEE6C", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(LegacySoundStyle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegateMethods.Minecart), Member = "SpawnFartCloud", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void LandingSoundFart(Player Player, Vector2 Position, int Width, int Height)
			{
				throw null;
			}

			// Token: 0x060049DA RID: 18906 RVA: 0x0002F15F File Offset: 0x0002D35F
			[global::Cpp2ILInjected.Token(Token = "0x60027E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CEF70", Offset = "0x10CEF70", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SoundEngine), Member = "PlaySound", MemberParameters = new object[]
			{
				typeof(LegacySoundStyle),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(SoundEffectInstance))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegateMethods.Minecart), Member = "SpawnFartCloud", MemberParameters = new object[]
			{
				typeof(Player),
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public static void BumperSoundFart(Player Player, Vector2 Position, int Width, int Height)
			{
				throw null;
			}

			// Token: 0x060049DB RID: 18907 RVA: 0x0002F162 File Offset: 0x0002D362
			[global::Cpp2ILInjected.Token(Token = "0x60027E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CF074", Offset = "0x10CF074", Length = "0x430")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DelegateMethods.Minecart), Member = "SparksTerraFart", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(double),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
			public static void SparksFart(Vector2 dustPosition)
			{
				throw null;
			}

			// Token: 0x060049DC RID: 18908 RVA: 0x0002F165 File Offset: 0x0002D365
			[global::Cpp2ILInjected.Token(Token = "0x60027E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CF4A4", Offset = "0x10CF4A4", Length = "0x50C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(double),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "NextFloat", MemberParameters = new object[] { typeof(UnifiedRandom) }, ReturnType = typeof(float))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
			{
				typeof(Color),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(Color))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DelegateMethods.Minecart), Member = "SparksFart", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
			public static void SparksTerraFart(Vector2 dustPosition)
			{
				throw null;
			}

			// Token: 0x060049DD RID: 18909 RVA: 0x0002F168 File Offset: 0x0002D368
			[global::Cpp2ILInjected.Token(Token = "0x60027E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CF9B0", Offset = "0x10CF9B0", Length = "0x3C0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(double),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
			public static void SparksMech(Vector2 dustPosition)
			{
				throw null;
			}

			// Token: 0x060049DE RID: 18910 RVA: 0x0002F16B File Offset: 0x0002D36B
			[global::Cpp2ILInjected.Token(Token = "0x60027E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x10CFD70", Offset = "0x10CFD70", Length = "0x414")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "RotatedBy", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(double),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dust), Member = "NewDust", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(float),
				typeof(float),
				typeof(int),
				typeof(Color),
				typeof(float)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArmorShaderDataSet), Member = "GetShaderFromItemId", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ArmorShaderData))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
			{
				typeof(Vector2),
				typeof(float)
			}, ReturnType = typeof(Vector2))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
			public static void SparksMeow(Vector2 dustPosition)
			{
				throw null;
			}

			// Token: 0x04007ED5 RID: 32469
			[global::Cpp2ILInjected.Token(Token = "0x40033DF")]
			public static Vector2 rotationOrigin;

			// Token: 0x04007ED6 RID: 32470
			[global::Cpp2ILInjected.Token(Token = "0x40033E0")]
			public static float rotation;
		}
	}
}
