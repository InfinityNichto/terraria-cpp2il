using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.DataStructures
{
	// Token: 0x02000422 RID: 1058
	[global::Cpp2ILInjected.Token(Token = "0x200061D")]
	public struct ContainerTransferContext
	{
		// Token: 0x060030AF RID: 12463 RVA: 0x0002AB57 File Offset: 0x00028D57
		[global::Cpp2ILInjected.Token(Token = "0x60035CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBCA8", Offset = "0x13DBCA8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickStackAllChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Center", ReturnType = typeof(Vector2))]
		public static ContainerTransferContext FromProjectile(Projectile projectile)
		{
			throw null;
		}

		// Token: 0x060030B0 RID: 12464 RVA: 0x0002AB5A File Offset: 0x00028D5A
		[global::Cpp2ILInjected.Token(Token = "0x60035CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBCDC", Offset = "0x13DBCDC", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "QuickStackAllChests", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public static ContainerTransferContext FromBlockPosition(int x, int y)
		{
			throw null;
		}

		// Token: 0x060030B1 RID: 12465 RVA: 0x0002AB5D File Offset: 0x00028D5D
		[global::Cpp2ILInjected.Token(Token = "0x60035CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBD18", Offset = "0x13DBD18", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawQuickStack", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPageOptions), Member = "DrawDepositAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ChestUI), Member = "DrawButton", MemberParameters = new object[]
		{
			typeof(SpriteBatch),
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public static ContainerTransferContext FromUnknown(Player player)
		{
			throw null;
		}

		// Token: 0x060030B2 RID: 12466 RVA: 0x0002AB60 File Offset: 0x00028D60
		[global::Cpp2ILInjected.Token(Token = "0x60035CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBCCC", Offset = "0x13DBCCC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ContainerTransferContext(Vector2 position)
		{
			throw null;
		}

		// Token: 0x060030B3 RID: 12467 RVA: 0x0002AB63 File Offset: 0x00028D63
		[global::Cpp2ILInjected.Token(Token = "0x60035D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBD24", Offset = "0x13DBD24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Vector2 GetContainerWorldPosition()
		{
			throw null;
		}

		// Token: 0x040062B9 RID: 25273
		[global::Cpp2ILInjected.Token(Token = "0x40076A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Vector2 _position;

		// Token: 0x040062BA RID: 25274
		[global::Cpp2ILInjected.Token(Token = "0x40076A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public bool CanVisualizeTransfers;
	}
}
