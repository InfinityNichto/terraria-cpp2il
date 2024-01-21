using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A8")]
public class PixelShader : Effect
{
	[Cpp2IlInjected.Token(Token = "0x200081B")]
	public enum PassIds
	{
		[Cpp2IlInjected.Token(Token = "0x4007D93")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x4007D94")]
		ColorOnly,
		[Cpp2IlInjected.Token(Token = "0x4007D95")]
		ArmorMartian,
		[Cpp2IlInjected.Token(Token = "0x4007D96")]
		ArmorColored,
		[Cpp2IlInjected.Token(Token = "0x4007D97")]
		ArmorColoredAndBlack,
		[Cpp2IlInjected.Token(Token = "0x4007D98")]
		ArmorColoredAndSilverTrim,
		[Cpp2IlInjected.Token(Token = "0x4007D99")]
		ArmorSilverTrim,
		[Cpp2IlInjected.Token(Token = "0x4007D9A")]
		ArmorBrightnessColored,
		[Cpp2IlInjected.Token(Token = "0x4007D9B")]
		ArmorColoredGradient,
		[Cpp2IlInjected.Token(Token = "0x4007D9C")]
		ArmorColoredAndBlackGradient,
		[Cpp2IlInjected.Token(Token = "0x4007D9D")]
		ArmorBrightnessGradient,
		[Cpp2IlInjected.Token(Token = "0x4007D9E")]
		ArmorColoredRainbow,
		[Cpp2IlInjected.Token(Token = "0x4007D9F")]
		ArmorBrightnessRainbow,
		[Cpp2IlInjected.Token(Token = "0x4007DA0")]
		ArmorLivingRainbow,
		[Cpp2IlInjected.Token(Token = "0x4007DA1")]
		ArmorInvert,
		[Cpp2IlInjected.Token(Token = "0x4007DA2")]
		ArmorLivingOcean,
		[Cpp2IlInjected.Token(Token = "0x4007DA3")]
		ArmorLivingFlame,
		[Cpp2IlInjected.Token(Token = "0x4007DA4")]
		ArmorWisp,
		[Cpp2IlInjected.Token(Token = "0x4007DA5")]
		ArmorHighContrastGlow,
		[Cpp2IlInjected.Token(Token = "0x4007DA6")]
		ArmorPlaid,
		[Cpp2IlInjected.Token(Token = "0x4007DA7")]
		ArmorDev,
		[Cpp2IlInjected.Token(Token = "0x4007DA8")]
		ArmorPlaid2,
		[Cpp2IlInjected.Token(Token = "0x4007DA9")]
		ArmorReflectiveColor,
		[Cpp2IlInjected.Token(Token = "0x4007DAA")]
		ArmorBasicColor,
		[Cpp2IlInjected.Token(Token = "0x4007DAB")]
		ArmorHades,
		[Cpp2IlInjected.Token(Token = "0x4007DAC")]
		ArmorTwilight,
		[Cpp2IlInjected.Token(Token = "0x4007DAD")]
		ArmorAcid,
		[Cpp2IlInjected.Token(Token = "0x4007DAE")]
		ArmorMushroom,
		[Cpp2IlInjected.Token(Token = "0x4007DAF")]
		ArmorPhase,
		[Cpp2IlInjected.Token(Token = "0x4007DB0")]
		ArmorReflective,
		[Cpp2IlInjected.Token(Token = "0x4007DB1")]
		ArmorSolar,
		[Cpp2IlInjected.Token(Token = "0x4007DB2")]
		ArmorNebula,
		[Cpp2IlInjected.Token(Token = "0x4007DB3")]
		ArmorVortex,
		[Cpp2IlInjected.Token(Token = "0x4007DB4")]
		ArmorStardust,
		[Cpp2IlInjected.Token(Token = "0x4007DB5")]
		ArmorVoid,
		[Cpp2IlInjected.Token(Token = "0x4007DB6")]
		ArmorShiftingSands,
		[Cpp2IlInjected.Token(Token = "0x4007DB7")]
		ArmorShiftingPearlsands,
		[Cpp2IlInjected.Token(Token = "0x4007DB8")]
		ArmorFog,
		[Cpp2IlInjected.Token(Token = "0x4007DB9")]
		ArmorHallowBoss,
		[Cpp2IlInjected.Token(Token = "0x4007DBA")]
		ArmorMirage,
		[Cpp2IlInjected.Token(Token = "0x4007DBB")]
		ArmorMidnightRainbow,
		[Cpp2IlInjected.Token(Token = "0x4007DBC")]
		ArmorColoredAndSilverTrimGradient,
		[Cpp2IlInjected.Token(Token = "0x4007DBD")]
		ArmorPolarized,
		[Cpp2IlInjected.Token(Token = "0x4007DBE")]
		ArmorGel,
		[Cpp2IlInjected.Token(Token = "0x4007DBF")]
		ArmorFlow,
		[Cpp2IlInjected.Token(Token = "0x4007DC0")]
		ArmorForceField,
		[Cpp2IlInjected.Token(Token = "0x4007DC1")]
		ArmorLoki,
		[Cpp2IlInjected.Token(Token = "0x4007DC2")]
		ForceField,
		[Cpp2IlInjected.Token(Token = "0x4007DC3")]
		WaterProcessor,
		[Cpp2IlInjected.Token(Token = "0x4007DC4")]
		WaterDistortionObject,
		[Cpp2IlInjected.Token(Token = "0x4007DC5")]
		HallowBoss,
		[Cpp2IlInjected.Token(Token = "0x4007DC6")]
		TitaniumStorm,
		[Cpp2IlInjected.Token(Token = "0x4007DC7")]
		QueenSlime,
		[Cpp2IlInjected.Token(Token = "0x4007DC8")]
		MagicMissile,
		[Cpp2IlInjected.Token(Token = "0x4007DC9")]
		FinalFractal,
		[Cpp2IlInjected.Token(Token = "0x4007DCA")]
		FinalFractalVertex,
		[Cpp2IlInjected.Token(Token = "0x4007DCB")]
		MaskedFade,
		[Cpp2IlInjected.Token(Token = "0x4007DCC")]
		RainbowTownSlime,
		[Cpp2IlInjected.Token(Token = "0x4007DCD")]
		RainbowTownSlimeOutline,
		[Cpp2IlInjected.Token(Token = "0x4007DCE")]
		Outline,
		[Cpp2IlInjected.Token(Token = "0x4007DCF")]
		RevSub
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001F0B")]
	private EffectParameter _uColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001F0C")]
	private EffectParameter _uSaturation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001F0D")]
	private EffectParameter _uSecondaryColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001F0E")]
	private EffectParameter _uTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001F0F")]
	private EffectParameter _uOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001F10")]
	private EffectParameter _uLightSource;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001F11")]
	private EffectParameter _uSourceRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001F12")]
	private EffectParameter _uLegacyArmorSourceRect;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001F13")]
	private EffectParameter _uLegacyArmorSheetSize;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001F14")]
	private EffectParameter _uWorldPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001F15")]
	private EffectParameter _uImageSize0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001F16")]
	private EffectParameter _uImageSize1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001F17")]
	private EffectParameter _uImageSize2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001F18")]
	private EffectParameter _uRotation;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001F19")]
	private EffectParameter _uDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4001F1A")]
	private EffectParameter _uTargetPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4001F1B")]
	private EffectParameter _uShaderSpecificData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4001F1C")]
	private EffectParameter _uMatrixTransform0;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x4001F1D")]
	private short[] TileOffsetData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4001F1E")]
	private GraphicsDevice device;

	[Cpp2IlInjected.Token(Token = "0x4001F1F")]
	private static PixelShader _effect;

	[Cpp2IlInjected.Token(Token = "0x4001F20")]
	private static int _colorId;

	[Cpp2IlInjected.Token(Token = "0x4001F21")]
	private static int _secondaryColorId;

	[Cpp2IlInjected.Token(Token = "0x4001F22")]
	private static int _saturationId;

	[Cpp2IlInjected.Token(Token = "0x4001F23")]
	private static int _imageSize0Id;

	[Cpp2IlInjected.Token(Token = "0x4001F24")]
	private static int _imageSize1Id;

	[Cpp2IlInjected.Token(Token = "0x4001F25")]
	private static int _sourceRectId;

	[Cpp2IlInjected.Token(Token = "0x4001F26")]
	private static int _timeId;

	[Cpp2IlInjected.Token(Token = "0x4001F27")]
	private static int _opacityId;

	[Cpp2IlInjected.Token(Token = "0x4001F28")]
	private static int _directionId;

	[Cpp2IlInjected.Token(Token = "0x4001F29")]
	private static int _rotationId;

	[Cpp2IlInjected.Token(Token = "0x4001F2A")]
	private static int _lightSourceId;

	[Cpp2IlInjected.Token(Token = "0x4001F2B")]
	private static int _targetPositionId;

	[Cpp2IlInjected.Token(Token = "0x4001F2C")]
	private static int _textureRectId;

	[Cpp2IlInjected.Token(Token = "0x4001F2D")]
	private static int _shaderSpecificDataId;

	[Cpp2IlInjected.Token(Token = "0x17000284")]
	public static PixelShader Effect
	{
		[Cpp2IlInjected.Token(Token = "0x60015A3")]
		[Cpp2IlInjected.Address(RVA = "0x158F92C", Offset = "0x158F92C", VA = "0x158F92C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60015A2")]
	[Cpp2IlInjected.Address(RVA = "0x158F1D0", Offset = "0x158F1D0", VA = "0x158F1D0")]
	public PixelShader(GraphicsDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015A4")]
	[Cpp2IlInjected.Address(RVA = "0x1590088", Offset = "0x1590088", VA = "0x1590088")]
	private static void LoadPass(List<EffectPass> passes, string pass)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015A5")]
	[Cpp2IlInjected.Address(RVA = "0x1590270", Offset = "0x1590270", VA = "0x1590270", Slot = "5")]
	public override void ApplyValuesToMaterial(EffectPass pass, Material material)
	{
	}
}
