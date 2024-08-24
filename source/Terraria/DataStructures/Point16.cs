using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.NetModules;
using Terraria.ObjectData;

namespace Terraria.DataStructures
{
	// Token: 0x0200044D RID: 1101
	[global::Cpp2ILInjected.Token(Token = "0x2000649")]
	public struct Point16
	{
		// Token: 0x060031BF RID: 12735 RVA: 0x0002AE6F File Offset: 0x0002906F
		[global::Cpp2ILInjected.Token(Token = "0x60036DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D0CC", Offset = "0x141D0CC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Point16(Point point)
		{
			throw null;
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x0002AE72 File Offset: 0x00029072
		[global::Cpp2ILInjected.Token(Token = "0x60036DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D0DC", Offset = "0x141D0DC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 195)]
		public Point16(int X, int Y)
		{
			throw null;
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x0002AE75 File Offset: 0x00029075
		[global::Cpp2ILInjected.Token(Token = "0x60036DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D0E8", Offset = "0x141D0E8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Animation), Member = "RemoveTemporaryAnimation", MemberParameters = new object[]
		{
			typeof(short),
			typeof(short)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetTeleportPylonModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public Point16(short X, short Y)
		{
			throw null;
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x0002AE78 File Offset: 0x00029078
		[global::Cpp2ILInjected.Token(Token = "0x60036DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D0F4", Offset = "0x141D0F4", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static Point16 Max(int firstX, int firstY, int secondX, int secondY)
		{
			throw null;
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x0002AE7B File Offset: 0x0002907B
		[global::Cpp2ILInjected.Token(Token = "0x60036E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D10C", Offset = "0x141D10C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Point16 Max(int compareX, int compareY)
		{
			throw null;
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x0002AE7E File Offset: 0x0002907E
		[global::Cpp2ILInjected.Token(Token = "0x60036E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D12C", Offset = "0x141D12C", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Point16 Max(Point16 compareTo)
		{
			throw null;
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x0002AE81 File Offset: 0x00029081
		[global::Cpp2ILInjected.Token(Token = "0x60036E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D158", Offset = "0x141D158", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Mount.<>c__DisplayClass141_0", Member = "<DrillSmartCursor_Walls>b__0", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "UseDrill", MemberParameters = new object[] { typeof(Player) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mount), Member = "Draw", MemberParameters = new object[]
		{
			typeof(ref PlayerDrawSet),
			typeof(int),
			typeof(Player),
			typeof(Vector2),
			typeof(Color),
			typeof(SpriteEffects),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_Origin", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileObjectData), Member = "set_CoordinatePaddingFix", MemberParameters = new object[] { typeof(Point16) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TeleportPylonInfo), Member = "Equals", MemberParameters = new object[] { typeof(TeleportPylonInfo) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public static bool operator ==(Point16 first, Point16 second)
		{
			throw null;
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x0002AE84 File Offset: 0x00029084
		[global::Cpp2ILInjected.Token(Token = "0x60036E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D168", Offset = "0x141D168", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static bool operator !=(Point16 first, Point16 second)
		{
			throw null;
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x0002AE87 File Offset: 0x00029087
		[global::Cpp2ILInjected.Token(Token = "0x60036E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D178", Offset = "0x141D178", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x0002AE8A File Offset: 0x0002908A
		[global::Cpp2ILInjected.Token(Token = "0x60036E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D210", Offset = "0x141D210", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x0002AE8D File Offset: 0x0002908D
		[global::Cpp2ILInjected.Token(Token = "0x60036E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D224", Offset = "0x141D224", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x0002AE90 File Offset: 0x00029090
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60036E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D2C4", Offset = "0x141D2C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Point16()
		{
			throw null;
		}

		// Token: 0x040063FE RID: 25598
		[global::Cpp2ILInjected.Token(Token = "0x40077EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly short X;

		// Token: 0x040063FF RID: 25599
		[global::Cpp2ILInjected.Token(Token = "0x40077EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		public readonly short Y;

		// Token: 0x04006400 RID: 25600
		[global::Cpp2ILInjected.Token(Token = "0x40077F0")]
		public static Point16 Zero;

		// Token: 0x04006401 RID: 25601
		[global::Cpp2ILInjected.Token(Token = "0x40077F1")]
		public static Point16 NegativeOne;
	}
}
