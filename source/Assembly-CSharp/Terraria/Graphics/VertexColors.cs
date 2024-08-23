using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using Terraria.GameContent;
using Terraria.GameContent.Drawing;
using Terraria.GameContent.Shaders;

namespace Terraria.Graphics
{
	// Token: 0x020004E1 RID: 1249
	[global::Cpp2ILInjected.Token(Token = "0x2000737")]
	public struct VertexColors
	{
		// Token: 0x060036AF RID: 13999 RVA: 0x0002BC52 File Offset: 0x00029E52
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

		// Token: 0x060036B0 RID: 14000 RVA: 0x0002BC55 File Offset: 0x00029E55
		[global::Cpp2ILInjected.Token(Token = "0x6003D12")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A7C4", Offset = "0x149A7C4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public VertexColors(Color topLeft, Color topRight, Color bottomRight, Color bottomLeft)
		{
			throw null;
		}

		// Token: 0x060036B1 RID: 14001 RVA: 0x0002BC58 File Offset: 0x00029E58
		[global::Cpp2ILInjected.Token(Token = "0x6003D13")]
		[global::Cpp2ILInjected.Address(RVA = "0x149A7D0", Offset = "0x149A7D0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public static implicit operator VertexColors(Color color)
		{
			throw null;
		}

		// Token: 0x04006725 RID: 26405
		[global::Cpp2ILInjected.Token(Token = "0x4007C05")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		public Color TopLeftColor;

		// Token: 0x04006726 RID: 26406
		[global::Cpp2ILInjected.Token(Token = "0x4007C06")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x4")]
		public Color TopRightColor;

		// Token: 0x04006727 RID: 26407
		[global::Cpp2ILInjected.Token(Token = "0x4007C07")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		public Color BottomLeftColor;

		// Token: 0x04006728 RID: 26408
		[global::Cpp2ILInjected.Token(Token = "0x4007C08")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC")]
		public Color BottomRightColor;
	}
}
