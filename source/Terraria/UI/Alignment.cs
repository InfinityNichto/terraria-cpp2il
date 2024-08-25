using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria.DataStructures;
using Terraria.Map;

namespace Terraria.UI
{
	[global::Cpp2ILInjected.Token(Token = "0x20006DA")]
	public struct Alignment
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000756")]
		public Vector2 OffsetMultiplier
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003AF0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1472F68", Offset = "0x1472F68", Length = "0x24")]
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
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(float),
				typeof(float)
			}, ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003AF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1472F8C", Offset = "0x1472F8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private Alignment(float horizontal, float vertical)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003AF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1472F94", Offset = "0x1472F94", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Alignment()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007AD1")]
		public static readonly Alignment TopLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4007AD2")]
		public static readonly Alignment Top;

		[global::Cpp2ILInjected.Token(Token = "0x4007AD3")]
		public static readonly Alignment TopRight;

		[global::Cpp2ILInjected.Token(Token = "0x4007AD4")]
		public static readonly Alignment Left;

		[global::Cpp2ILInjected.Token(Token = "0x4007AD5")]
		public static readonly Alignment Center;

		[global::Cpp2ILInjected.Token(Token = "0x4007AD6")]
		public static readonly Alignment Right;

		[global::Cpp2ILInjected.Token(Token = "0x4007AD7")]
		public static readonly Alignment BottomLeft;

		[global::Cpp2ILInjected.Token(Token = "0x4007AD8")]
		public static readonly Alignment Bottom;

		[global::Cpp2ILInjected.Token(Token = "0x4007AD9")]
		public static readonly Alignment BottomRight;

		[global::Cpp2ILInjected.Token(Token = "0x4007ADA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public readonly float VerticalOffsetMultiplier;

		[global::Cpp2ILInjected.Token(Token = "0x4007ADB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public readonly float HorizontalOffsetMultiplier;
	}
}
