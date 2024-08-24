﻿using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.Graphics
{
	// Token: 0x020004E7 RID: 1255
	[global::Cpp2ILInjected.Token(Token = "0x200073F")]
	public struct RainbowRodDrawer
	{
		// Token: 0x060036C8 RID: 14024 RVA: 0x0002BC9D File Offset: 0x00029E9D
		[global::Cpp2ILInjected.Token(Token = "0x6003D32")]
		[global::Cpp2ILInjected.Address(RVA = "0x149E574", Offset = "0x149E574", Length = "0x3E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "End", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SpriteBatch), Member = "Begin", MemberParameters = new object[]
		{
			typeof(SpriteSortMode),
			typeof(BlendState),
			typeof(SamplerState),
			typeof(DepthStencilState),
			typeof(RasterizerState),
			typeof(Effect),
			typeof(Matrix?),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip.StripColorFunction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip.StripHalfWidthFunction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_screenPosition", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_UnaryNegation", MemberParameters = new object[] { typeof(Vector2) }, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Entity), Member = "get_Size", ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Division", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "PrepareStripWithProceduralPadding", MemberParameters = new object[]
		{
			typeof(Vector2[]),
			typeof(float[]),
			typeof(VertexStrip.StripColorFunction),
			typeof(VertexStrip.StripHalfWidthFunction),
			typeof(Vector2),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = "DrawTrail", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_pixelShader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public void Draw(Projectile proj)
		{
			throw null;
		}

		// Token: 0x060036C9 RID: 14025 RVA: 0x0002BCA0 File Offset: 0x00029EA0
		[global::Cpp2ILInjected.Token(Token = "0x6003D33")]
		[global::Cpp2ILInjected.Address(RVA = "0x149E954", Offset = "0x149E954", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Color), Member = "op_Multiply", MemberParameters = new object[]
		{
			typeof(Color),
			typeof(float)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void StripColors(float progressOnStrip, out Color col)
		{
			throw null;
		}

		// Token: 0x060036CA RID: 14026 RVA: 0x0002BCA3 File Offset: 0x00029EA3
		[global::Cpp2ILInjected.Token(Token = "0x6003D34")]
		[global::Cpp2ILInjected.Address(RVA = "0x149EAB4", Offset = "0x149EAB4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utils), Member = "GetLerpValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(bool)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MathHelper), Member = "Lerp", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private float StripWidth(float progressOnStrip)
		{
			throw null;
		}

		// Token: 0x060036CB RID: 14027 RVA: 0x0002BCA6 File Offset: 0x00029EA6
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6003D35")]
		[global::Cpp2ILInjected.Address(RVA = "0x149EB48", Offset = "0x149EB48", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VertexStrip), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static RainbowRodDrawer()
		{
			throw null;
		}

		// Token: 0x04006739 RID: 26425
		[global::Cpp2ILInjected.Token(Token = "0x4007C1E")]
		private static VertexStrip _vertexStrip;
	}
}