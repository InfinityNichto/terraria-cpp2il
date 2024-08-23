using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.UI;

namespace Terraria.Map
{
	// Token: 0x020004A8 RID: 1192
	[global::Cpp2ILInjected.Token(Token = "0x20006BA")]
	public struct MapOverlayDrawContext
	{
		// Token: 0x060033BB RID: 13243 RVA: 0x0002B3B8 File Offset: 0x000295B8
		[global::Cpp2ILInjected.Token(Token = "0x6003912")]
		[global::Cpp2ILInjected.Address(RVA = "0x1447990", Offset = "0x1447990", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public MapOverlayDrawContext(Vector2 mapPosition, Vector2 mapOffset, Rectangle? clippingRect, float mapScale, float drawScale)
		{
			throw null;
		}

		// Token: 0x060033BC RID: 13244 RVA: 0x0002B3BB File Offset: 0x000295BB
		[global::Cpp2ILInjected.Token(Token = "0x6003913")]
		[global::Cpp2ILInjected.Address(RVA = "0x1447A2C", Offset = "0x1447A2C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpawnMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte),
			typeof(byte)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(SpriteFrame),
			typeof(Alignment)
		}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
		public MapOverlayDrawContext.DrawResult Draw(Texture2D texture, Vector2 position, Alignment alignment)
		{
			throw null;
		}

		// Token: 0x060033BD RID: 13245 RVA: 0x0002B3BE File Offset: 0x000295BE
		[global::Cpp2ILInjected.Token(Token = "0x6003914")]
		[global::Cpp2ILInjected.Address(RVA = "0x1447AB4", Offset = "0x1447AB4", Length = "0x454")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Alignment)
		}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PingMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = "GetSourceRectangle", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alignment), Member = "get_OffsetMultiplier", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public MapOverlayDrawContext.DrawResult Draw(Texture2D texture, Vector2 position, SpriteFrame frame, Alignment alignment)
		{
			throw null;
		}

		// Token: 0x060033BE RID: 13246 RVA: 0x0002B3C1 File Offset: 0x000295C1
		[global::Cpp2ILInjected.Token(Token = "0x6003915")]
		[global::Cpp2ILInjected.Address(RVA = "0x1447F08", Offset = "0x1447F08", Length = "0x3B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "ToPoint", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Point))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = "Contains", MemberParameters = new object[] { typeof(Point) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteFrame), Member = "GetSourceRectangle", MemberParameters = new object[] { typeof(Texture2D) }, ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "Size", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Alignment), Member = "get_OffsetMultiplier", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_MouseScreen", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle?), Member = ".ctor", MemberParameters = new object[] { typeof(Rectangle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Rectangle?),
			typeof(Color),
			typeof(float),
			typeof(Vector2),
			typeof(float),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public MapOverlayDrawContext.DrawResult Draw(Texture2D texture, Vector2 position, Color color, SpriteFrame frame, float scaleIfNotSelected, float scaleIfSelected, Alignment alignment)
		{
			throw null;
		}

		// Token: 0x0400659B RID: 26011
		[global::Cpp2ILInjected.Token(Token = "0x40079A8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Vector2 _mapPosition;

		// Token: 0x0400659C RID: 26012
		[global::Cpp2ILInjected.Token(Token = "0x40079A9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly Vector2 _mapOffset;

		// Token: 0x0400659D RID: 26013
		[global::Cpp2ILInjected.Token(Token = "0x40079AA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly Rectangle? _clippingRect;

		// Token: 0x0400659E RID: 26014
		[global::Cpp2ILInjected.Token(Token = "0x40079AB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private readonly float _mapScale;

		// Token: 0x0400659F RID: 26015
		[global::Cpp2ILInjected.Token(Token = "0x40079AC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly float _drawScale;

		// Token: 0x02000947 RID: 2375
		[global::Cpp2ILInjected.Token(Token = "0x20006BB")]
		public struct DrawResult
		{
			// Token: 0x06004CCC RID: 19660 RVA: 0x0002F939 File Offset: 0x0002DB39
			[global::Cpp2ILInjected.Token(Token = "0x6003916")]
			[global::Cpp2ILInjected.Address(RVA = "0x14482BC", Offset = "0x14482BC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public DrawResult(bool isMouseOver)
			{
				throw null;
			}

			// Token: 0x06004CCD RID: 19661 RVA: 0x0002F93C File Offset: 0x0002DB3C
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6003917")]
			[global::Cpp2ILInjected.Address(RVA = "0x14482C8", Offset = "0x14482C8", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			static DrawResult()
			{
				throw null;
			}

			// Token: 0x04008AEC RID: 35564
			[global::Cpp2ILInjected.Token(Token = "0x40079AD")]
			public static readonly MapOverlayDrawContext.DrawResult Culled;

			// Token: 0x04008AED RID: 35565
			[global::Cpp2ILInjected.Token(Token = "0x40079AE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			public readonly bool IsMouseOver;
		}
	}
}
