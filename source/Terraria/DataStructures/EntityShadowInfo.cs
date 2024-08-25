using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x2000624")]
	public struct EntityShadowInfo
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DC528", Offset = "0x13DC528", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "UpdateAdvancedShadows", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void CopyPlayer(Player player)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700068C")]
		public Vector2 HeadgearOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x60035F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x13DC580", Offset = "0x13DC580", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerDrawLayers), Member = "DrawStarboardRainbowTrail", MemberParameters = new object[]
			{
				typeof(ref PlayerDrawSet),
				typeof(Vector2),
				typeof(Vector2)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40076C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Vector2 Position;

		[global::Cpp2ILInjected.Token(Token = "0x40076C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public float Rotation;

		[global::Cpp2ILInjected.Token(Token = "0x40076C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Vector2 Origin;

		[global::Cpp2ILInjected.Token(Token = "0x40076C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public int Direction;

		[global::Cpp2ILInjected.Token(Token = "0x40076C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int GravityDirection;

		[global::Cpp2ILInjected.Token(Token = "0x40076C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int BodyFrameIndex;
	}
}
