using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.UI;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200061D")]
	public struct ContainerTransferContext
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x60035CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBCCC", Offset = "0x13DBCCC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ContainerTransferContext(Vector2 position)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBD24", Offset = "0x13DBD24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public Vector2 GetContainerWorldPosition()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076A3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private Vector2 _position;

		[global::Cpp2ILInjected.Token(Token = "0x40076A4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public bool CanVisualizeTransfers;
	}
}
