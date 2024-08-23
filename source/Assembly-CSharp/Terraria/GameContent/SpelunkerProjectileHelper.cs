using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Utilities;

namespace Terraria.GameContent
{
	// Token: 0x02000566 RID: 1382
	[global::Cpp2ILInjected.Token(Token = "0x20007F1")]
	public class SpelunkerProjectileHelper
	{
		// Token: 0x06003A75 RID: 14965 RVA: 0x0002C702 File Offset: 0x0002A902
		[global::Cpp2ILInjected.Token(Token = "0x6004169")]
		[global::Cpp2ILInjected.Address(RVA = "0x77A98C", Offset = "0x77A98C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "PreUpdateAllProjectiles", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Vector2>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void OnPreUpdateAllProjectiles()
		{
			throw null;
		}

		// Token: 0x06003A76 RID: 14966 RVA: 0x0002C705 File Offset: 0x0002A905
		[global::Cpp2ILInjected.Token(Token = "0x600416A")]
		[global::Cpp2ILInjected.Address(RVA = "0x77AA74", Offset = "0x77AA74", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "ItemCheck_EmitHeldItemLight", MemberParameters = new object[] { typeof(Item) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Projectile), Member = "AI_014", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Vector2>), Member = "Add", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void AddSpotToCheck(Vector2 spot)
		{
			throw null;
		}

		// Token: 0x06003A77 RID: 14967 RVA: 0x0002C708 File Offset: 0x0002A908
		[global::Cpp2ILInjected.Token(Token = "0x600416B")]
		[global::Cpp2ILInjected.Address(RVA = "0x77AAF8", Offset = "0x77AAF8", Length = "0x3D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Right", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils[]), Member = "Clamp", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "get_Bottom", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileData), Member = "get_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(Tile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tile), Member = "active", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "IsTileSpelunkable", MemberParameters = new object[] { typeof(Tile) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "Length", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point>), Member = "Add", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnifiedRandom), Member = "Next", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private void CheckSpot(Vector2 Center)
		{
			throw null;
		}

		// Token: 0x06003A78 RID: 14968 RVA: 0x0002C70B File Offset: 0x0002A90B
		[global::Cpp2ILInjected.Token(Token = "0x600416C")]
		[global::Cpp2ILInjected.Address(RVA = "0x77AECC", Offset = "0x77AECC", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Vector2>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HashSet<Point>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public SpelunkerProjectileHelper()
		{
			throw null;
		}

		// Token: 0x04006950 RID: 26960
		[global::Cpp2ILInjected.Token(Token = "0x4007F03")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private HashSet<Vector2> _positionsChecked;

		// Token: 0x04006951 RID: 26961
		[global::Cpp2ILInjected.Token(Token = "0x4007F04")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private HashSet<Point> _tilesChecked;

		// Token: 0x04006952 RID: 26962
		[global::Cpp2ILInjected.Token(Token = "0x4007F05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Rectangle _clampBox;

		// Token: 0x04006953 RID: 26963
		[global::Cpp2ILInjected.Token(Token = "0x4007F06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _frameCounter;
	}
}
