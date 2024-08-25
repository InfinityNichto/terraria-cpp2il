using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Shaders;

namespace Terraria.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000737")]
	public struct VertexColors
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003D11")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A7B8", Offset = "0x149A7B8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "StepLiquids", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WaterShaderData), Member = "DrawWaves", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WallDrawing), Member = ".ctor", MemberParameters = new object[] { typeof(TilePaintSystemV2) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		public VertexColors(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D12")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A7C4", Offset = "0x149A7C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public VertexColors(Color topLeft, Color topRight, Color bottomRight, Color bottomLeft)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003D13")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A7D0", Offset = "0x149A7D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator VertexColors(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4007C05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Color TopLeftColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007C06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public Color TopRightColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007C07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Color BottomLeftColor;

		[global::Cpp2ILInjected.Token(Token = "0x4007C08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Color BottomRightColor;
	}
}
