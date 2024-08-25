using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent;
using Terraria.Graphics.Shaders;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x2000365")]
	public class EffectPass
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016B1")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4D04", Offset = "0xAA4D04", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int GetNextBatchIndex()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B2")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4D54", Offset = "0xAA4D54", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(EffectPass)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(EffectPass),
			typeof(ShaderData)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = "LoadPass", MemberParameters = new object[]
		{
			typeof(List<EffectPass>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "LoadPass", MemberParameters = new object[]
		{
			typeof(List<EffectPass>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SpriteEffect), Member = "get_Effect", ReturnType = typeof(SpriteEffect))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TileShader), Member = "LoadPass", MemberParameters = new object[]
		{
			typeof(List<EffectPass>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public EffectPass(Effect effect, int passindex, string name, Material material)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4DD8", Offset = "0xAA4DD8", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(EffectPassCollection), Member = "Clone", MemberParameters = new object[] { typeof(Effect) }, ReturnType = typeof(EffectPassCollection))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(int),
			typeof(string),
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EffectPass(Effect effect, EffectPass existing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B4")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4E68", Offset = "0xAA4E68", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ArmorShaderData), Member = "GetDustEffect", ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerTitaniumStormBuffTextureContent), Member = "GetRenderEffect", ReturnType = typeof(EffectPass))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = ".ctor", MemberParameters = new object[] { typeof(Material) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectPass), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Effect),
			typeof(int),
			typeof(string),
			typeof(Material)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public EffectPass(EffectPass existing, ShaderData armourData)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4F00", Offset = "0xAA4F00", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenPostProcessor), Member = "OnRenderImage", MemberParameters = new object[]
		{
			typeof(RenderTexture),
			typeof(RenderTexture)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GraphicsDevice), Member = "GetMaterial", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Material))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void ApplyValuesToMaterial(Material material)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA4F6C", Offset = "0xAA4F6C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(EffectParameter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetRegion(Vector4 sourceRect, Texture2D texture)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016B7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA504C", Offset = "0xAA504C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Apply()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40024DD")]
		public static EffectPass BoundEffect;

		[global::Cpp2ILInjected.Token(Token = "0x40024DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public readonly int PassIndex;

		[global::Cpp2ILInjected.Token(Token = "0x40024DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public readonly string Name;

		[global::Cpp2ILInjected.Token(Token = "0x40024E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly Effect _effect;

		[global::Cpp2ILInjected.Token(Token = "0x40024E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public readonly Material _material;

		[global::Cpp2ILInjected.Token(Token = "0x40024E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly int BatchIndex;

		[global::Cpp2ILInjected.Token(Token = "0x40024E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public readonly ShaderData _armour;

		[global::Cpp2ILInjected.Token(Token = "0x40024E4")]
		private static int NextBatchIndex;
	}
}
