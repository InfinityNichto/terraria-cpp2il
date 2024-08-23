using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using Terraria.GameContent;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002A8 RID: 680
	[global::Cpp2ILInjected.Token(Token = "0x200036E")]
	public class TileShader : Effect
	{
		// Token: 0x06001577 RID: 5495 RVA: 0x00025AED File Offset: 0x00023CED
		[global::Cpp2ILInjected.Token(Token = "0x60016DF")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAA328", Offset = "0xAAA328", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "CreateNew", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Effect), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = ".ctor", MemberParameters = new object[] { typeof(EffectParameter[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public TileShader(GraphicsDevice device)
		{
			throw null;
		}

		// Token: 0x06001578 RID: 5496 RVA: 0x00025AF0 File Offset: 0x00023CF0
		[global::Cpp2ILInjected.Token(Token = "0x60016E0")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAA5B8", Offset = "0xAAA5B8", Length = "0x364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(<PrivateImplementationDetails>), Member = "ComputeStringHash", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "get_Float", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
			throw null;
		}

		// Token: 0x06001579 RID: 5497 RVA: 0x00025AF3 File Offset: 0x00023CF3
		[global::Cpp2ILInjected.Token(Token = "0x60016E1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAA91C", Offset = "0xAAA91C", Length = "0x794")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "get_Effect", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TilePaintSystemV2), Member = "InitShader", MemberParameters = new object[] { typeof(TreePaintingSettings) }, ReturnType = typeof(Effect))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DrPlatform), Member = "get_IsMainThread", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileShader), Member = "LoadPass", MemberParameters = new object[]
		{
			typeof(List<EffectPass>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPassCollection), Member = ".ctor", MemberParameters = new object[] { typeof(EffectPass[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectTechnique), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(string),
			typeof(EffectPassCollection)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 60)]
		public static TileShader CreateNew()
		{
			throw null;
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x0600157A RID: 5498 RVA: 0x00025AF6 File Offset: 0x00023CF6
		[global::Cpp2ILInjected.Token(Token = "0x170002AF")]
		public static TileShader Effect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016E2")]
			[global::Cpp2ILInjected.Address(RVA = "0xAAB314", Offset = "0xAAB314", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileShader), Member = "CreateNew", ReturnType = typeof(TileShader))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600157B RID: 5499 RVA: 0x00025AF9 File Offset: 0x00023CF9
		[global::Cpp2ILInjected.Token(Token = "0x60016E3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAB0B0", Offset = "0xAAB0B0", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "CreateNew", ReturnType = typeof(TileShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Resources), Member = "Load", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::UnityEngine.Object),
			typeof(global::UnityEngine.Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new object[] { typeof(Shader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(int),
			typeof(string),
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private static void LoadPass(List<EffectPass> passes, string pass)
		{
			throw null;
		}

		// Token: 0x0600157C RID: 5500 RVA: 0x00025AFC File Offset: 0x00023CFC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016E4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAAB3B0", Offset = "0xAAB3B0", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		static TileShader()
		{
			throw null;
		}

		// Token: 0x04001F47 RID: 8007
		[global::Cpp2ILInjected.Token(Token = "0x400256C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private EffectParameter _leafMinHueOffset;

		// Token: 0x04001F48 RID: 8008
		[global::Cpp2ILInjected.Token(Token = "0x400256D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private EffectParameter _leafMinHue;

		// Token: 0x04001F49 RID: 8009
		[global::Cpp2ILInjected.Token(Token = "0x400256E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private EffectParameter _leafMaxHue;

		// Token: 0x04001F4A RID: 8010
		[global::Cpp2ILInjected.Token(Token = "0x400256F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private EffectParameter _leafMinSat;

		// Token: 0x04001F4B RID: 8011
		[global::Cpp2ILInjected.Token(Token = "0x4002570")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private EffectParameter _leafMaxSat;

		// Token: 0x04001F4C RID: 8012
		[global::Cpp2ILInjected.Token(Token = "0x4002571")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private EffectParameter _invertSpecialGroupResult;

		// Token: 0x04001F4D RID: 8013
		[global::Cpp2ILInjected.Token(Token = "0x4002572")]
		private static int _leafHueTestOffsetId;

		// Token: 0x04001F4E RID: 8014
		[global::Cpp2ILInjected.Token(Token = "0x4002573")]
		private static int _leafMinHueId;

		// Token: 0x04001F4F RID: 8015
		[global::Cpp2ILInjected.Token(Token = "0x4002574")]
		private static int _leafMaxHueId;

		// Token: 0x04001F50 RID: 8016
		[global::Cpp2ILInjected.Token(Token = "0x4002575")]
		private static int _leafMinSatId;

		// Token: 0x04001F51 RID: 8017
		[global::Cpp2ILInjected.Token(Token = "0x4002576")]
		private static int _leafMaxSatId;

		// Token: 0x04001F52 RID: 8018
		[global::Cpp2ILInjected.Token(Token = "0x4002577")]
		private static int _invertSpecialGroupResultId;

		// Token: 0x04001F53 RID: 8019
		[global::Cpp2ILInjected.Token(Token = "0x4002578")]
		private static TileShader _effect;
	}
}
