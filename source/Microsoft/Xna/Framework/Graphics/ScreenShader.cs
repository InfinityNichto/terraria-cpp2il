using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x200036C")]
	public class ScreenShader : Effect
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016D8")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA8EC0", Offset = "0xAA8EC0", Length = "0x53C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "get_Effect", ReturnType = typeof(ScreenShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Effect), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = ".ctor", MemberParameters = new object[] { typeof(EffectParameter[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 52)]
		public ScreenShader(GraphicsDevice device)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002AD")]
		public static ScreenShader Effect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016D9")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA93FC", Offset = "0xAA93FC", Length = "0x4CC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScreenShader), Member = "LoadPass", MemberParameters = new object[]
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
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016DA")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA98C8", Offset = "0xAA98C8", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ScreenShader), Member = "get_Effect", ReturnType = typeof(ScreenShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 25)]
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

		[global::Cpp2ILInjected.Token(Token = "0x60016DB")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA9B2C", Offset = "0xAA9B2C", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "get_Color", ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "get_Float", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = "get_Vector", ReturnType = typeof(Vector4))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016DC")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA9DBC", Offset = "0xAA9DBC", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static ScreenShader()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400254D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private EffectParameter _uColor;

		[global::Cpp2ILInjected.Token(Token = "0x400254E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private EffectParameter _uOpacity;

		[global::Cpp2ILInjected.Token(Token = "0x400254F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private EffectParameter _uSecondaryColor;

		[global::Cpp2ILInjected.Token(Token = "0x4002550")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private EffectParameter _uTime;

		[global::Cpp2ILInjected.Token(Token = "0x4002551")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private EffectParameter _uScreenResolution;

		[global::Cpp2ILInjected.Token(Token = "0x4002552")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private EffectParameter _uScreenPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4002553")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private EffectParameter _uTargetPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4002554")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private EffectParameter _uIntensity;

		[global::Cpp2ILInjected.Token(Token = "0x4002555")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private EffectParameter _uImageOffset;

		[global::Cpp2ILInjected.Token(Token = "0x4002556")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private EffectParameter _uProgress;

		[global::Cpp2ILInjected.Token(Token = "0x4002557")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private EffectParameter _uDirection;

		[global::Cpp2ILInjected.Token(Token = "0x4002558")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private EffectParameter _uZoom;

		[global::Cpp2ILInjected.Token(Token = "0x4002559")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private EffectParameter _uImageSize1;

		[global::Cpp2ILInjected.Token(Token = "0x400255A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private EffectParameter _uImageSize2;

		[global::Cpp2ILInjected.Token(Token = "0x400255B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private EffectParameter _uImageSize3;

		[global::Cpp2ILInjected.Token(Token = "0x400255C")]
		private static ScreenShader _effect;

		[global::Cpp2ILInjected.Token(Token = "0x400255D")]
		private static int _colorId;

		[global::Cpp2ILInjected.Token(Token = "0x400255E")]
		private static int _opacityId;

		[global::Cpp2ILInjected.Token(Token = "0x400255F")]
		private static int _secondaryColorId;

		[global::Cpp2ILInjected.Token(Token = "0x4002560")]
		private static int _timeId;

		[global::Cpp2ILInjected.Token(Token = "0x4002561")]
		private static int _screenResolutionId;

		[global::Cpp2ILInjected.Token(Token = "0x4002562")]
		private static int _screenPositionId;

		[global::Cpp2ILInjected.Token(Token = "0x4002563")]
		private static int _targetPositionId;

		[global::Cpp2ILInjected.Token(Token = "0x4002564")]
		private static int _intensityId;

		[global::Cpp2ILInjected.Token(Token = "0x4002565")]
		private static int _progressId;

		[global::Cpp2ILInjected.Token(Token = "0x4002566")]
		private static int _directionId;

		[global::Cpp2ILInjected.Token(Token = "0x4002567")]
		private static int _ImageSize1;

		[global::Cpp2ILInjected.Token(Token = "0x4002568")]
		private static int _ImageSize2;

		[global::Cpp2ILInjected.Token(Token = "0x4002569")]
		private static int _ImageSize3;

		[global::Cpp2ILInjected.Token(Token = "0x400256A")]
		private static int _Zoom;
	}
}
