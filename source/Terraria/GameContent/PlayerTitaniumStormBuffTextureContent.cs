﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.Graphics.Shaders;
using Terraria.Initializers;

namespace Terraria.GameContent
{
	// Token: 0x02000553 RID: 1363
	[global::Cpp2ILInjected.Token(Token = "0x20007CF")]
	public class PlayerTitaniumStormBuffTextureContent : ARenderTargetContentByRequest
	{
		// Token: 0x060039DB RID: 14811 RVA: 0x0002C552 File Offset: 0x0002A752
		[global::Cpp2ILInjected.Token(Token = "0x60040B1")]
		[global::Cpp2ILInjected.Address(RVA = "0x772C20", Offset = "0x772C20", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AssetInitializer), Member = "LoadRenderTargetAssets", MemberParameters = new object[] { typeof(AssetRequestMode) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Ref<Effect>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseImage1", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public PlayerTitaniumStormBuffTextureContent()
		{
			throw null;
		}

		// Token: 0x060039DC RID: 14812 RVA: 0x0002C555 File Offset: 0x0002A755
		[global::Cpp2ILInjected.Token(Token = "0x60040B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x772D30", Offset = "0x772D30", Length = "0x11C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "DrawProjDirect", MemberParameters = new object[]
		{
			typeof(Projectile),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseOpacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ShaderData), Member = "get_Shader", ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EffectPass),
			typeof(ShaderData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public EffectPass GetRenderEffect()
		{
			throw null;
		}

		// Token: 0x060039DD RID: 14813 RVA: 0x0002C558 File Offset: 0x0002A758
		[global::Cpp2ILInjected.Token(Token = "0x60040B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x772E90", Offset = "0x772E90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void HandleUseReqest(GraphicsDevice device, SpriteBatch spriteBatch)
		{
			throw null;
		}

		// Token: 0x060039DE RID: 14814 RVA: 0x0002C55B File Offset: 0x0002A75B
		[global::Cpp2ILInjected.Token(Token = "0x60040B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x772E4C", Offset = "0x772E4C", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseColor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(MiscShaderData))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MiscShaderData), Member = "UseOpacity", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(MiscShaderData))]
		public void UpdateSettingsForRendering(float gradientContributionFromOriginalTexture, float gradientScrollingSpeed, float flatGradientOffset, float gradientColorDominance)
		{
			throw null;
		}

		// Token: 0x040068F9 RID: 26873
		[global::Cpp2ILInjected.Token(Token = "0x4007E5E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private EffectPass renderEffect;

		// Token: 0x040068FA RID: 26874
		[global::Cpp2ILInjected.Token(Token = "0x4007E5F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private MiscShaderData _shaderData;
	}
}