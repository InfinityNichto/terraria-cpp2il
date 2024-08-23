using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework.Content;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics
{
	// Token: 0x020002A5 RID: 677
	[global::Cpp2ILInjected.Token(Token = "0x200036A")]
	public class PixelShader : Effect
	{
		// Token: 0x0600156B RID: 5483 RVA: 0x00025AC9 File Offset: 0x00023CC9
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

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x0600156C RID: 5484 RVA: 0x00025ACC File Offset: 0x00023CCC
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

		// Token: 0x0600156D RID: 5485 RVA: 0x00025ACF File Offset: 0x00023CCF
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

		// Token: 0x0600156E RID: 5486 RVA: 0x00025AD2 File Offset: 0x00023CD2
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

		// Token: 0x0600156F RID: 5487 RVA: 0x00025AD5 File Offset: 0x00023CD5
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

		// Token: 0x04001F05 RID: 7941
		[global::Cpp2ILInjected.Token(Token = "0x40024EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private EffectParameter _uColor;

		// Token: 0x04001F06 RID: 7942
		[global::Cpp2ILInjected.Token(Token = "0x40024ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private EffectParameter _uSaturation;

		// Token: 0x04001F07 RID: 7943
		[global::Cpp2ILInjected.Token(Token = "0x40024EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private EffectParameter _uSecondaryColor;

		// Token: 0x04001F08 RID: 7944
		[global::Cpp2ILInjected.Token(Token = "0x40024EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private EffectParameter _uTime;

		// Token: 0x04001F09 RID: 7945
		[global::Cpp2ILInjected.Token(Token = "0x40024F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private EffectParameter _uOpacity;

		// Token: 0x04001F0A RID: 7946
		[global::Cpp2ILInjected.Token(Token = "0x40024F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private EffectParameter _uLightSource;

		// Token: 0x04001F0B RID: 7947
		[global::Cpp2ILInjected.Token(Token = "0x40024F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private EffectParameter _uSourceRect;

		// Token: 0x04001F0C RID: 7948
		[global::Cpp2ILInjected.Token(Token = "0x40024F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private EffectParameter _uLegacyArmorSourceRect;

		// Token: 0x04001F0D RID: 7949
		[global::Cpp2ILInjected.Token(Token = "0x40024F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private EffectParameter _uLegacyArmorSheetSize;

		// Token: 0x04001F0E RID: 7950
		[global::Cpp2ILInjected.Token(Token = "0x40024F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private EffectParameter _uWorldPosition;

		// Token: 0x04001F0F RID: 7951
		[global::Cpp2ILInjected.Token(Token = "0x40024F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private EffectParameter _uImageSize0;

		// Token: 0x04001F10 RID: 7952
		[global::Cpp2ILInjected.Token(Token = "0x40024F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private EffectParameter _uImageSize1;

		// Token: 0x04001F11 RID: 7953
		[global::Cpp2ILInjected.Token(Token = "0x40024F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private EffectParameter _uImageSize2;

		// Token: 0x04001F12 RID: 7954
		[global::Cpp2ILInjected.Token(Token = "0x40024F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private EffectParameter _uRotation;

		// Token: 0x04001F13 RID: 7955
		[global::Cpp2ILInjected.Token(Token = "0x40024FA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private EffectParameter _uDirection;

		// Token: 0x04001F14 RID: 7956
		[global::Cpp2ILInjected.Token(Token = "0x40024FB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private EffectParameter _uTargetPosition;

		// Token: 0x04001F15 RID: 7957
		[global::Cpp2ILInjected.Token(Token = "0x40024FC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private EffectParameter _uShaderSpecificData;

		// Token: 0x04001F16 RID: 7958
		[global::Cpp2ILInjected.Token(Token = "0x40024FD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private EffectParameter _uMatrixTransform0;

		// Token: 0x04001F17 RID: 7959
		[global::Cpp2ILInjected.Token(Token = "0x40024FE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private short[] TileOffsetData;

		// Token: 0x04001F18 RID: 7960
		[global::Cpp2ILInjected.Token(Token = "0x40024FF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private GraphicsDevice device;

		// Token: 0x04001F19 RID: 7961
		[global::Cpp2ILInjected.Token(Token = "0x4002500")]
		private static PixelShader _effect;

		// Token: 0x04001F1A RID: 7962
		[global::Cpp2ILInjected.Token(Token = "0x4002501")]
		private static int _colorId;

		// Token: 0x04001F1B RID: 7963
		[global::Cpp2ILInjected.Token(Token = "0x4002502")]
		private static int _secondaryColorId;

		// Token: 0x04001F1C RID: 7964
		[global::Cpp2ILInjected.Token(Token = "0x4002503")]
		private static int _saturationId;

		// Token: 0x04001F1D RID: 7965
		[global::Cpp2ILInjected.Token(Token = "0x4002504")]
		private static int _imageSize0Id;

		// Token: 0x04001F1E RID: 7966
		[global::Cpp2ILInjected.Token(Token = "0x4002505")]
		private static int _imageSize1Id;

		// Token: 0x04001F1F RID: 7967
		[global::Cpp2ILInjected.Token(Token = "0x4002506")]
		private static int _sourceRectId;

		// Token: 0x04001F20 RID: 7968
		[global::Cpp2ILInjected.Token(Token = "0x4002507")]
		private static int _timeId;

		// Token: 0x04001F21 RID: 7969
		[global::Cpp2ILInjected.Token(Token = "0x4002508")]
		private static int _opacityId;

		// Token: 0x04001F22 RID: 7970
		[global::Cpp2ILInjected.Token(Token = "0x4002509")]
		private static int _directionId;

		// Token: 0x04001F23 RID: 7971
		[global::Cpp2ILInjected.Token(Token = "0x400250A")]
		private static int _rotationId;

		// Token: 0x04001F24 RID: 7972
		[global::Cpp2ILInjected.Token(Token = "0x400250B")]
		private static int _lightSourceId;

		// Token: 0x04001F25 RID: 7973
		[global::Cpp2ILInjected.Token(Token = "0x400250C")]
		private static int _targetPositionId;

		// Token: 0x04001F26 RID: 7974
		[global::Cpp2ILInjected.Token(Token = "0x400250D")]
		private static int _textureRectId;

		// Token: 0x04001F27 RID: 7975
		[global::Cpp2ILInjected.Token(Token = "0x400250E")]
		private static int _shaderSpecificDataId;

		// Token: 0x02000824 RID: 2084
		[global::Cpp2ILInjected.Token(Token = "0x200036B")]
		public enum PassIds
		{
			// Token: 0x04007DA6 RID: 32166
			[global::Cpp2ILInjected.Token(Token = "0x4002510")]
			Default,
			// Token: 0x04007DA7 RID: 32167
			[global::Cpp2ILInjected.Token(Token = "0x4002511")]
			ColorOnly,
			// Token: 0x04007DA8 RID: 32168
			[global::Cpp2ILInjected.Token(Token = "0x4002512")]
			ArmorMartian,
			// Token: 0x04007DA9 RID: 32169
			[global::Cpp2ILInjected.Token(Token = "0x4002513")]
			ArmorColored,
			// Token: 0x04007DAA RID: 32170
			[global::Cpp2ILInjected.Token(Token = "0x4002514")]
			ArmorColoredAndBlack,
			// Token: 0x04007DAB RID: 32171
			[global::Cpp2ILInjected.Token(Token = "0x4002515")]
			ArmorColoredAndSilverTrim,
			// Token: 0x04007DAC RID: 32172
			[global::Cpp2ILInjected.Token(Token = "0x4002516")]
			ArmorSilverTrim,
			// Token: 0x04007DAD RID: 32173
			[global::Cpp2ILInjected.Token(Token = "0x4002517")]
			ArmorBrightnessColored,
			// Token: 0x04007DAE RID: 32174
			[global::Cpp2ILInjected.Token(Token = "0x4002518")]
			ArmorColoredGradient,
			// Token: 0x04007DAF RID: 32175
			[global::Cpp2ILInjected.Token(Token = "0x4002519")]
			ArmorColoredAndBlackGradient,
			// Token: 0x04007DB0 RID: 32176
			[global::Cpp2ILInjected.Token(Token = "0x400251A")]
			ArmorBrightnessGradient,
			// Token: 0x04007DB1 RID: 32177
			[global::Cpp2ILInjected.Token(Token = "0x400251B")]
			ArmorColoredRainbow,
			// Token: 0x04007DB2 RID: 32178
			[global::Cpp2ILInjected.Token(Token = "0x400251C")]
			ArmorBrightnessRainbow,
			// Token: 0x04007DB3 RID: 32179
			[global::Cpp2ILInjected.Token(Token = "0x400251D")]
			ArmorLivingRainbow,
			// Token: 0x04007DB4 RID: 32180
			[global::Cpp2ILInjected.Token(Token = "0x400251E")]
			ArmorInvert,
			// Token: 0x04007DB5 RID: 32181
			[global::Cpp2ILInjected.Token(Token = "0x400251F")]
			ArmorLivingOcean,
			// Token: 0x04007DB6 RID: 32182
			[global::Cpp2ILInjected.Token(Token = "0x4002520")]
			ArmorLivingFlame,
			// Token: 0x04007DB7 RID: 32183
			[global::Cpp2ILInjected.Token(Token = "0x4002521")]
			ArmorWisp,
			// Token: 0x04007DB8 RID: 32184
			[global::Cpp2ILInjected.Token(Token = "0x4002522")]
			ArmorHighContrastGlow,
			// Token: 0x04007DB9 RID: 32185
			[global::Cpp2ILInjected.Token(Token = "0x4002523")]
			ArmorPlaid,
			// Token: 0x04007DBA RID: 32186
			[global::Cpp2ILInjected.Token(Token = "0x4002524")]
			ArmorDev,
			// Token: 0x04007DBB RID: 32187
			[global::Cpp2ILInjected.Token(Token = "0x4002525")]
			ArmorPlaid2,
			// Token: 0x04007DBC RID: 32188
			[global::Cpp2ILInjected.Token(Token = "0x4002526")]
			ArmorReflectiveColor,
			// Token: 0x04007DBD RID: 32189
			[global::Cpp2ILInjected.Token(Token = "0x4002527")]
			ArmorBasicColor,
			// Token: 0x04007DBE RID: 32190
			[global::Cpp2ILInjected.Token(Token = "0x4002528")]
			ArmorHades,
			// Token: 0x04007DBF RID: 32191
			[global::Cpp2ILInjected.Token(Token = "0x4002529")]
			ArmorTwilight,
			// Token: 0x04007DC0 RID: 32192
			[global::Cpp2ILInjected.Token(Token = "0x400252A")]
			ArmorAcid,
			// Token: 0x04007DC1 RID: 32193
			[global::Cpp2ILInjected.Token(Token = "0x400252B")]
			ArmorMushroom,
			// Token: 0x04007DC2 RID: 32194
			[global::Cpp2ILInjected.Token(Token = "0x400252C")]
			ArmorPhase,
			// Token: 0x04007DC3 RID: 32195
			[global::Cpp2ILInjected.Token(Token = "0x400252D")]
			ArmorReflective,
			// Token: 0x04007DC4 RID: 32196
			[global::Cpp2ILInjected.Token(Token = "0x400252E")]
			ArmorSolar,
			// Token: 0x04007DC5 RID: 32197
			[global::Cpp2ILInjected.Token(Token = "0x400252F")]
			ArmorNebula,
			// Token: 0x04007DC6 RID: 32198
			[global::Cpp2ILInjected.Token(Token = "0x4002530")]
			ArmorVortex,
			// Token: 0x04007DC7 RID: 32199
			[global::Cpp2ILInjected.Token(Token = "0x4002531")]
			ArmorStardust,
			// Token: 0x04007DC8 RID: 32200
			[global::Cpp2ILInjected.Token(Token = "0x4002532")]
			ArmorVoid,
			// Token: 0x04007DC9 RID: 32201
			[global::Cpp2ILInjected.Token(Token = "0x4002533")]
			ArmorShiftingSands,
			// Token: 0x04007DCA RID: 32202
			[global::Cpp2ILInjected.Token(Token = "0x4002534")]
			ArmorShiftingPearlsands,
			// Token: 0x04007DCB RID: 32203
			[global::Cpp2ILInjected.Token(Token = "0x4002535")]
			ArmorFog,
			// Token: 0x04007DCC RID: 32204
			[global::Cpp2ILInjected.Token(Token = "0x4002536")]
			ArmorHallowBoss,
			// Token: 0x04007DCD RID: 32205
			[global::Cpp2ILInjected.Token(Token = "0x4002537")]
			ArmorMirage,
			// Token: 0x04007DCE RID: 32206
			[global::Cpp2ILInjected.Token(Token = "0x4002538")]
			ArmorMidnightRainbow,
			// Token: 0x04007DCF RID: 32207
			[global::Cpp2ILInjected.Token(Token = "0x4002539")]
			ArmorColoredAndSilverTrimGradient,
			// Token: 0x04007DD0 RID: 32208
			[global::Cpp2ILInjected.Token(Token = "0x400253A")]
			ArmorPolarized,
			// Token: 0x04007DD1 RID: 32209
			[global::Cpp2ILInjected.Token(Token = "0x400253B")]
			ArmorGel,
			// Token: 0x04007DD2 RID: 32210
			[global::Cpp2ILInjected.Token(Token = "0x400253C")]
			ArmorFlow,
			// Token: 0x04007DD3 RID: 32211
			[global::Cpp2ILInjected.Token(Token = "0x400253D")]
			ArmorForceField,
			// Token: 0x04007DD4 RID: 32212
			[global::Cpp2ILInjected.Token(Token = "0x400253E")]
			ArmorLoki,
			// Token: 0x04007DD5 RID: 32213
			[global::Cpp2ILInjected.Token(Token = "0x400253F")]
			ForceField,
			// Token: 0x04007DD6 RID: 32214
			[global::Cpp2ILInjected.Token(Token = "0x4002540")]
			WaterProcessor,
			// Token: 0x04007DD7 RID: 32215
			[global::Cpp2ILInjected.Token(Token = "0x4002541")]
			WaterDistortionObject,
			// Token: 0x04007DD8 RID: 32216
			[global::Cpp2ILInjected.Token(Token = "0x4002542")]
			HallowBoss,
			// Token: 0x04007DD9 RID: 32217
			[global::Cpp2ILInjected.Token(Token = "0x4002543")]
			TitaniumStorm,
			// Token: 0x04007DDA RID: 32218
			[global::Cpp2ILInjected.Token(Token = "0x4002544")]
			QueenSlime,
			// Token: 0x04007DDB RID: 32219
			[global::Cpp2ILInjected.Token(Token = "0x4002545")]
			MagicMissile,
			// Token: 0x04007DDC RID: 32220
			[global::Cpp2ILInjected.Token(Token = "0x4002546")]
			FinalFractal,
			// Token: 0x04007DDD RID: 32221
			[global::Cpp2ILInjected.Token(Token = "0x4002547")]
			FinalFractalVertex,
			// Token: 0x04007DDE RID: 32222
			[global::Cpp2ILInjected.Token(Token = "0x4002548")]
			MaskedFade,
			// Token: 0x04007DDF RID: 32223
			[global::Cpp2ILInjected.Token(Token = "0x4002549")]
			RainbowTownSlime,
			// Token: 0x04007DE0 RID: 32224
			[global::Cpp2ILInjected.Token(Token = "0x400254A")]
			RainbowTownSlimeOutline,
			// Token: 0x04007DE1 RID: 32225
			[global::Cpp2ILInjected.Token(Token = "0x400254B")]
			Outline,
			// Token: 0x04007DE2 RID: 32226
			[global::Cpp2ILInjected.Token(Token = "0x400254C")]
			RevSub
		}
	}
}
