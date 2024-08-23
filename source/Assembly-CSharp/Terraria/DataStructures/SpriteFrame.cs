using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.Map;
using Terraria.UI;

namespace Terraria.DataStructures
{
	// Token: 0x02000476 RID: 1142
	[global::Cpp2ILInjected.Token(Token = "0x2000677")]
	public struct SpriteFrame
	{
		// Token: 0x17000628 RID: 1576
		// (get) Token: 0x06003213 RID: 12819 RVA: 0x0002AF50 File Offset: 0x00029150
		// (set) Token: 0x06003214 RID: 12820 RVA: 0x0002AF53 File Offset: 0x00029153
		[global::Cpp2ILInjected.Token(Token = "0x170006AA")]
		public byte CurrentColumn
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003739")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E3B4", Offset = "0x141E3B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600373A")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E3BC", Offset = "0x141E3BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000629 RID: 1577
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x0002AF56 File Offset: 0x00029156
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x0002AF59 File Offset: 0x00029159
		[global::Cpp2ILInjected.Token(Token = "0x170006AB")]
		public byte CurrentRow
		{
			[global::Cpp2ILInjected.Token(Token = "0x600373B")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E3C4", Offset = "0x141E3C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600373C")]
			[global::Cpp2ILInjected.Address(RVA = "0x141E3CC", Offset = "0x141E3CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x06003217 RID: 12823 RVA: 0x0002AF5C File Offset: 0x0002915C
		[global::Cpp2ILInjected.Token(Token = "0x600373D")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E3D4", Offset = "0x141E3D4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 28)]
		public SpriteFrame(byte columns, byte rows)
		{
			throw null;
		}

		// Token: 0x06003218 RID: 12824 RVA: 0x0002AF5F File Offset: 0x0002915F
		[global::Cpp2ILInjected.Token(Token = "0x600373E")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E3EC", Offset = "0x141E3EC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonsMapLayer), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref MapOverlayDrawContext),
			typeof(ref string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public SpriteFrame(byte columns, byte rows, byte currentColumn, byte currentRow)
		{
			throw null;
		}

		// Token: 0x06003219 RID: 12825 RVA: 0x0002AF62 File Offset: 0x00029162
		[global::Cpp2ILInjected.Token(Token = "0x600373F")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E408", Offset = "0x141E408", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public SpriteFrame With(byte columnToUse, byte rowToUse)
		{
			throw null;
		}

		// Token: 0x0600321A RID: 12826 RVA: 0x0002AF65 File Offset: 0x00029165
		[global::Cpp2ILInjected.Token(Token = "0x6003740")]
		[global::Cpp2ILInjected.Address(RVA = "0x141E428", Offset = "0x141E428", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawGoreBehind", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawGore", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "get_Width", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "get_Height", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Gore), Member = "get_AABBRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(SpriteFrame),
			typeof(Alignment)
		}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MapOverlayDrawContext), Member = "Draw", MemberParameters = new object[]
		{
			typeof(Texture2D),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteFrame),
			typeof(float),
			typeof(float),
			typeof(Alignment)
		}, ReturnType = typeof(MapOverlayDrawContext.DrawResult))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Skies.AmbientSky.SkyEntity", Member = "get_SourceRectangle", ReturnType = typeof(Rectangle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Rectangle), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public Rectangle GetSourceRectangle(Texture2D texture)
		{
			throw null;
		}

		// Token: 0x04006433 RID: 25651
		[global::Cpp2ILInjected.Token(Token = "0x400782C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public int PaddingX;

		// Token: 0x04006434 RID: 25652
		[global::Cpp2ILInjected.Token(Token = "0x400782D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public int PaddingY;

		// Token: 0x04006435 RID: 25653
		[global::Cpp2ILInjected.Token(Token = "0x400782E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private byte _currentColumn;

		// Token: 0x04006436 RID: 25654
		[global::Cpp2ILInjected.Token(Token = "0x400782F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x9")]
		private byte _currentRow;

		// Token: 0x04006437 RID: 25655
		[global::Cpp2ILInjected.Token(Token = "0x4007830")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA")]
		public readonly byte ColumnCount;

		// Token: 0x04006438 RID: 25656
		[global::Cpp2ILInjected.Token(Token = "0x4007831")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB")]
		public readonly byte RowCount;
	}
}
