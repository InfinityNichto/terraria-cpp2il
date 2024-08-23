using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.GameContent.Drawing;

namespace Terraria
{
	// Token: 0x02000321 RID: 801
	[global::Cpp2ILInjected.Token(Token = "0x2000421")]
	public class Animation
	{
		// Token: 0x06002549 RID: 9545 RVA: 0x00028A2A File Offset: 0x00026C2A
		[global::Cpp2ILInjected.Token(Token = "0x6002746")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C4B98", Offset = "0x10C4B98", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "Initialize_AlmostEverything", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point16, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void Initialize()
		{
			throw null;
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x00028A2D File Offset: 0x00026C2D
		[global::Cpp2ILInjected.Token(Token = "0x6002747")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C4CE4", Offset = "0x10C4CE4", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Animation), Member = "NewTemporaryAnimation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ushort),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(RuntimeHelpers), Member = "InitializeArray", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(RuntimeFieldHandle)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void SetDefaults(int type)
		{
			throw null;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x00028A30 File Offset: 0x00026C30
		[global::Cpp2ILInjected.Token(Token = "0x6002748")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C4EDC", Offset = "0x10C4EDC", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MessageBuffer), Member = "ProcessData", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(ref int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "TileInteractionsUse", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Wiring), Member = "HitWireSingle", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animation), Member = "SetDefaults", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetMessage), Member = "SendTemporaryAnimation", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void NewTemporaryAnimation(int type, ushort tileType, int x, int y)
		{
			throw null;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x00028A33 File Offset: 0x00026C33
		[global::Cpp2ILInjected.Token(Token = "0x6002749")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C50C0", Offset = "0x10C50C0", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Animation), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point16, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void RemoveTemporaryAnimation(short x, short y)
		{
			throw null;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x00028A36 File Offset: 0x00026C36
		[global::Cpp2ILInjected.Token(Token = "0x600274A")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C51CC", Offset = "0x10C51CC", Length = "0x30C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DoUpdate", MemberParameters = new object[] { typeof(GameTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animation), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point16, object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(Point16),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point16, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point16, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point16, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<Point16>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point16, object>), Member = "Remove", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static void UpdateAll()
		{
			throw null;
		}

		// Token: 0x0600254E RID: 9550 RVA: 0x00028A39 File Offset: 0x00026C39
		[global::Cpp2ILInjected.Token(Token = "0x600274B")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C54D8", Offset = "0x10C54D8", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Animation), Member = "UpdateAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "get_type", ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Animation), Member = "RemoveTemporaryAnimation", MemberParameters = new object[]
		{
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Update()
		{
			throw null;
		}

		// Token: 0x0600254F RID: 9551 RVA: 0x00028A3C File Offset: 0x00026C3C
		[global::Cpp2ILInjected.Token(Token = "0x600274C")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C55B0", Offset = "0x10C55B0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(TileDrawInfo),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileDrawing), Member = "GetTileDrawData", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(Tile),
			typeof(ushort),
			typeof(ref short),
			typeof(ref short),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref int),
			typeof(ref SpriteEffects),
			typeof(ref Texture2D),
			typeof(ref Rectangle),
			typeof(ref Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point16), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<Point16, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(Point16),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool GetTemporaryFrame(int x, int y, out int frameData)
		{
			throw null;
		}

		// Token: 0x06002550 RID: 9552 RVA: 0x00028A3F File Offset: 0x00026C3F
		[global::Cpp2ILInjected.Token(Token = "0x600274D")]
		[global::Cpp2ILInjected.Address(RVA = "0x10C50B8", Offset = "0x10C50B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Animation()
		{
			throw null;
		}

		// Token: 0x04002C6F RID: 11375
		[global::Cpp2ILInjected.Token(Token = "0x400338B")]
		private static List<Animation> _animations;

		// Token: 0x04002C70 RID: 11376
		[global::Cpp2ILInjected.Token(Token = "0x400338C")]
		private static Dictionary<Point16, Animation> _temporaryAnimations;

		// Token: 0x04002C71 RID: 11377
		[global::Cpp2ILInjected.Token(Token = "0x400338D")]
		private static List<Point16> _awaitingRemoval;

		// Token: 0x04002C72 RID: 11378
		[global::Cpp2ILInjected.Token(Token = "0x400338E")]
		private static List<Animation> _awaitingAddition;

		// Token: 0x04002C73 RID: 11379
		[global::Cpp2ILInjected.Token(Token = "0x400338F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private bool _temporary;

		// Token: 0x04002C74 RID: 11380
		[global::Cpp2ILInjected.Token(Token = "0x4003390")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private Point16 _coordinates;

		// Token: 0x04002C75 RID: 11381
		[global::Cpp2ILInjected.Token(Token = "0x4003391")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x16")]
		private ushort _tileType;

		// Token: 0x04002C76 RID: 11382
		[global::Cpp2ILInjected.Token(Token = "0x4003392")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int _frame;

		// Token: 0x04002C77 RID: 11383
		[global::Cpp2ILInjected.Token(Token = "0x4003393")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int _frameMax;

		// Token: 0x04002C78 RID: 11384
		[global::Cpp2ILInjected.Token(Token = "0x4003394")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private int _frameCounter;

		// Token: 0x04002C79 RID: 11385
		[global::Cpp2ILInjected.Token(Token = "0x4003395")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int _frameCounterMax;

		// Token: 0x04002C7A RID: 11386
		[global::Cpp2ILInjected.Token(Token = "0x4003396")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int[] _frameData;
	}
}
