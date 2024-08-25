using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	[global::Cpp2ILInjected.Token(Token = "0x200036A")]
	public class PixelShader : Effect
	{
		[global::Cpp2ILInjected.Token(Token = "0x60016D3")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA56F0", Offset = "0xAA56F0", Length = "0x614")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = "get_Effect", ReturnType = typeof(PixelShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsResource), Member = "set_GraphicsDevice", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameter), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(EffectParameterCollection), Member = ".ctor", MemberParameters = new object[] { typeof(EffectParameter[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 63)]
		public PixelShader(GraphicsDevice device)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002AC")]
		public static PixelShader Effect
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016D4")]
			[global::Cpp2ILInjected.Address(RVA = "0xAA5D04", Offset = "0xAA5D04", Length = "0x934")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ContentManager), Member = "Load", MemberTypeParameters = new object[] { "T1" }, MemberParameters = new object[] { typeof(string) }, ReturnType = "T1")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PixelShader), Member = ".ctor", MemberParameters = new object[] { typeof(GraphicsDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PixelShader), Member = "LoadPass", MemberParameters = new object[]
			{
				typeof(List<EffectPass>),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "ToArray", ReturnType = "T[]")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 74)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60016D5")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA6638", Offset = "0xAA6638", Length = "0x260")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PixelShader), Member = "get_Effect", ReturnType = typeof(PixelShader))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 61)]
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

		[global::Cpp2ILInjected.Token(Token = "0x60016D6")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA6898", Offset = "0xAA6898", Length = "0x1364")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetColor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Color)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetVector", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector4)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Material), Member = "SetFloat", MemberParameters = new object[]
		{
			typeof(int),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GraphicsDeviceManager), Member = "get_GraphicsDevice", ReturnType = typeof(GraphicsDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = "get_UnityTexture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector2), Member = "op_Addition", MemberParameters = new object[]
		{
			typeof(Vector2),
			typeof(Vector2)
		}, ReturnType = typeof(Vector2))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		public override void ApplyValuesToMaterial(EffectPass pass, Material material)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60016D7")]
		[global::Cpp2ILInjected.Address(RVA = "0xAA7BFC", Offset = "0xAA7BFC", Length = "0x12C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Shader), Member = "PropertyToID", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		static PixelShader()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40024EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private EffectParameter _uColor;

		[global::Cpp2ILInjected.Token(Token = "0x40024ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private EffectParameter _uSaturation;

		[global::Cpp2ILInjected.Token(Token = "0x40024EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private EffectParameter _uSecondaryColor;

		[global::Cpp2ILInjected.Token(Token = "0x40024EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private EffectParameter _uTime;

		[global::Cpp2ILInjected.Token(Token = "0x40024F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private EffectParameter _uOpacity;

		[global::Cpp2ILInjected.Token(Token = "0x40024F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private EffectParameter _uLightSource;

		[global::Cpp2ILInjected.Token(Token = "0x40024F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private EffectParameter _uSourceRect;

		[global::Cpp2ILInjected.Token(Token = "0x40024F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private EffectParameter _uLegacyArmorSourceRect;

		[global::Cpp2ILInjected.Token(Token = "0x40024F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private EffectParameter _uLegacyArmorSheetSize;

		[global::Cpp2ILInjected.Token(Token = "0x40024F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private EffectParameter _uWorldPosition;

		[global::Cpp2ILInjected.Token(Token = "0x40024F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private EffectParameter _uImageSize0;

		[global::Cpp2ILInjected.Token(Token = "0x40024F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private EffectParameter _uImageSize1;

		[global::Cpp2ILInjected.Token(Token = "0x40024F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private EffectParameter _uImageSize2;

		[global::Cpp2ILInjected.Token(Token = "0x40024F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private EffectParameter _uRotation;

		[global::Cpp2ILInjected.Token(Token = "0x40024FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private EffectParameter _uDirection;

		[global::Cpp2ILInjected.Token(Token = "0x40024FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private EffectParameter _uTargetPosition;

		[global::Cpp2ILInjected.Token(Token = "0x40024FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private EffectParameter _uShaderSpecificData;

		[global::Cpp2ILInjected.Token(Token = "0x40024FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private EffectParameter _uMatrixTransform0;

		[global::Cpp2ILInjected.Token(Token = "0x40024FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private short[] TileOffsetData;

		[global::Cpp2ILInjected.Token(Token = "0x40024FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private GraphicsDevice device;

		[global::Cpp2ILInjected.Token(Token = "0x4002500")]
		private static PixelShader _effect;

		[global::Cpp2ILInjected.Token(Token = "0x4002501")]
		private static int _colorId;

		[global::Cpp2ILInjected.Token(Token = "0x4002502")]
		private static int _secondaryColorId;

		[global::Cpp2ILInjected.Token(Token = "0x4002503")]
		private static int _saturationId;

		[global::Cpp2ILInjected.Token(Token = "0x4002504")]
		private static int _imageSize0Id;

		[global::Cpp2ILInjected.Token(Token = "0x4002505")]
		private static int _imageSize1Id;

		[global::Cpp2ILInjected.Token(Token = "0x4002506")]
		private static int _sourceRectId;

		[global::Cpp2ILInjected.Token(Token = "0x4002507")]
		private static int _timeId;

		[global::Cpp2ILInjected.Token(Token = "0x4002508")]
		private static int _opacityId;

		[global::Cpp2ILInjected.Token(Token = "0x4002509")]
		private static int _directionId;

		[global::Cpp2ILInjected.Token(Token = "0x400250A")]
		private static int _rotationId;

		[global::Cpp2ILInjected.Token(Token = "0x400250B")]
		private static int _lightSourceId;

		[global::Cpp2ILInjected.Token(Token = "0x400250C")]
		private static int _targetPositionId;

		[global::Cpp2ILInjected.Token(Token = "0x400250D")]
		private static int _textureRectId;

		[global::Cpp2ILInjected.Token(Token = "0x400250E")]
		private static int _shaderSpecificDataId;

		[global::Cpp2ILInjected.Token(Token = "0x200036B")]
		public enum PassIds
		{
			[global::Cpp2ILInjected.Token(Token = "0x4002510")]
			Default,
			[global::Cpp2ILInjected.Token(Token = "0x4002511")]
			ColorOnly,
			[global::Cpp2ILInjected.Token(Token = "0x4002512")]
			ArmorMartian,
			[global::Cpp2ILInjected.Token(Token = "0x4002513")]
			ArmorColored,
			[global::Cpp2ILInjected.Token(Token = "0x4002514")]
			ArmorColoredAndBlack,
			[global::Cpp2ILInjected.Token(Token = "0x4002515")]
			ArmorColoredAndSilverTrim,
			[global::Cpp2ILInjected.Token(Token = "0x4002516")]
			ArmorSilverTrim,
			[global::Cpp2ILInjected.Token(Token = "0x4002517")]
			ArmorBrightnessColored,
			[global::Cpp2ILInjected.Token(Token = "0x4002518")]
			ArmorColoredGradient,
			[global::Cpp2ILInjected.Token(Token = "0x4002519")]
			ArmorColoredAndBlackGradient,
			[global::Cpp2ILInjected.Token(Token = "0x400251A")]
			ArmorBrightnessGradient,
			[global::Cpp2ILInjected.Token(Token = "0x400251B")]
			ArmorColoredRainbow,
			[global::Cpp2ILInjected.Token(Token = "0x400251C")]
			ArmorBrightnessRainbow,
			[global::Cpp2ILInjected.Token(Token = "0x400251D")]
			ArmorLivingRainbow,
			[global::Cpp2ILInjected.Token(Token = "0x400251E")]
			ArmorInvert,
			[global::Cpp2ILInjected.Token(Token = "0x400251F")]
			ArmorLivingOcean,
			[global::Cpp2ILInjected.Token(Token = "0x4002520")]
			ArmorLivingFlame,
			[global::Cpp2ILInjected.Token(Token = "0x4002521")]
			ArmorWisp,
			[global::Cpp2ILInjected.Token(Token = "0x4002522")]
			ArmorHighContrastGlow,
			[global::Cpp2ILInjected.Token(Token = "0x4002523")]
			ArmorPlaid,
			[global::Cpp2ILInjected.Token(Token = "0x4002524")]
			ArmorDev,
			[global::Cpp2ILInjected.Token(Token = "0x4002525")]
			ArmorPlaid2,
			[global::Cpp2ILInjected.Token(Token = "0x4002526")]
			ArmorReflectiveColor,
			[global::Cpp2ILInjected.Token(Token = "0x4002527")]
			ArmorBasicColor,
			[global::Cpp2ILInjected.Token(Token = "0x4002528")]
			ArmorHades,
			[global::Cpp2ILInjected.Token(Token = "0x4002529")]
			ArmorTwilight,
			[global::Cpp2ILInjected.Token(Token = "0x400252A")]
			ArmorAcid,
			[global::Cpp2ILInjected.Token(Token = "0x400252B")]
			ArmorMushroom,
			[global::Cpp2ILInjected.Token(Token = "0x400252C")]
			ArmorPhase,
			[global::Cpp2ILInjected.Token(Token = "0x400252D")]
			ArmorReflective,
			[global::Cpp2ILInjected.Token(Token = "0x400252E")]
			ArmorSolar,
			[global::Cpp2ILInjected.Token(Token = "0x400252F")]
			ArmorNebula,
			[global::Cpp2ILInjected.Token(Token = "0x4002530")]
			ArmorVortex,
			[global::Cpp2ILInjected.Token(Token = "0x4002531")]
			ArmorStardust,
			[global::Cpp2ILInjected.Token(Token = "0x4002532")]
			ArmorVoid,
			[global::Cpp2ILInjected.Token(Token = "0x4002533")]
			ArmorShiftingSands,
			[global::Cpp2ILInjected.Token(Token = "0x4002534")]
			ArmorShiftingPearlsands,
			[global::Cpp2ILInjected.Token(Token = "0x4002535")]
			ArmorFog,
			[global::Cpp2ILInjected.Token(Token = "0x4002536")]
			ArmorHallowBoss,
			[global::Cpp2ILInjected.Token(Token = "0x4002537")]
			ArmorMirage,
			[global::Cpp2ILInjected.Token(Token = "0x4002538")]
			ArmorMidnightRainbow,
			[global::Cpp2ILInjected.Token(Token = "0x4002539")]
			ArmorColoredAndSilverTrimGradient,
			[global::Cpp2ILInjected.Token(Token = "0x400253A")]
			ArmorPolarized,
			[global::Cpp2ILInjected.Token(Token = "0x400253B")]
			ArmorGel,
			[global::Cpp2ILInjected.Token(Token = "0x400253C")]
			ArmorFlow,
			[global::Cpp2ILInjected.Token(Token = "0x400253D")]
			ArmorForceField,
			[global::Cpp2ILInjected.Token(Token = "0x400253E")]
			ArmorLoki,
			[global::Cpp2ILInjected.Token(Token = "0x400253F")]
			ForceField,
			[global::Cpp2ILInjected.Token(Token = "0x4002540")]
			WaterProcessor,
			[global::Cpp2ILInjected.Token(Token = "0x4002541")]
			WaterDistortionObject,
			[global::Cpp2ILInjected.Token(Token = "0x4002542")]
			HallowBoss,
			[global::Cpp2ILInjected.Token(Token = "0x4002543")]
			TitaniumStorm,
			[global::Cpp2ILInjected.Token(Token = "0x4002544")]
			QueenSlime,
			[global::Cpp2ILInjected.Token(Token = "0x4002545")]
			MagicMissile,
			[global::Cpp2ILInjected.Token(Token = "0x4002546")]
			FinalFractal,
			[global::Cpp2ILInjected.Token(Token = "0x4002547")]
			FinalFractalVertex,
			[global::Cpp2ILInjected.Token(Token = "0x4002548")]
			MaskedFade,
			[global::Cpp2ILInjected.Token(Token = "0x4002549")]
			RainbowTownSlime,
			[global::Cpp2ILInjected.Token(Token = "0x400254A")]
			RainbowTownSlimeOutline,
			[global::Cpp2ILInjected.Token(Token = "0x400254B")]
			Outline,
			[global::Cpp2ILInjected.Token(Token = "0x400254C")]
			RevSub
		}
	}
}
