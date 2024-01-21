using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002A9")]
public class ScreenShader : Effect
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001F2E")]
	private EffectParameter _uColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001F2F")]
	private EffectParameter _uOpacity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001F30")]
	private EffectParameter _uSecondaryColor;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001F31")]
	private EffectParameter _uTime;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001F32")]
	private EffectParameter _uScreenResolution;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001F33")]
	private EffectParameter _uScreenPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4001F34")]
	private EffectParameter _uTargetPosition;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4001F35")]
	private EffectParameter _uIntensity;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4001F36")]
	private EffectParameter _uImageOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4001F37")]
	private EffectParameter _uProgress;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4001F38")]
	private EffectParameter _uDirection;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4001F39")]
	private EffectParameter _uZoom;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4001F3A")]
	private EffectParameter _uImageSize1;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4001F3B")]
	private EffectParameter _uImageSize2;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4001F3C")]
	private EffectParameter _uImageSize3;

	[Cpp2IlInjected.Token(Token = "0x4001F3D")]
	private static ScreenShader _effect;

	[Cpp2IlInjected.Token(Token = "0x4001F3E")]
	private static int _colorId;

	[Cpp2IlInjected.Token(Token = "0x4001F3F")]
	private static int _opacityId;

	[Cpp2IlInjected.Token(Token = "0x4001F40")]
	private static int _secondaryColorId;

	[Cpp2IlInjected.Token(Token = "0x4001F41")]
	private static int _timeId;

	[Cpp2IlInjected.Token(Token = "0x4001F42")]
	private static int _screenResolutionId;

	[Cpp2IlInjected.Token(Token = "0x4001F43")]
	private static int _screenPositionId;

	[Cpp2IlInjected.Token(Token = "0x4001F44")]
	private static int _targetPositionId;

	[Cpp2IlInjected.Token(Token = "0x4001F45")]
	private static int _intensityId;

	[Cpp2IlInjected.Token(Token = "0x4001F46")]
	private static int _progressId;

	[Cpp2IlInjected.Token(Token = "0x4001F47")]
	private static int _directionId;

	[Cpp2IlInjected.Token(Token = "0x4001F48")]
	private static int _ImageSize1;

	[Cpp2IlInjected.Token(Token = "0x4001F49")]
	private static int _ImageSize2;

	[Cpp2IlInjected.Token(Token = "0x4001F4A")]
	private static int _ImageSize3;

	[Cpp2IlInjected.Token(Token = "0x4001F4B")]
	private static int _Zoom;

	[Cpp2IlInjected.Token(Token = "0x17000285")]
	public static ScreenShader Effect
	{
		[Cpp2IlInjected.Token(Token = "0x60015A8")]
		[Cpp2IlInjected.Address(RVA = "0x159456C", Offset = "0x159456C", VA = "0x159456C")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60015A7")]
	[Cpp2IlInjected.Address(RVA = "0x1593F60", Offset = "0x1593F60", VA = "0x1593F60")]
	public ScreenShader(GraphicsDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015A9")]
	[Cpp2IlInjected.Address(RVA = "0x1594974", Offset = "0x1594974", VA = "0x1594974")]
	private static void LoadPass(List<EffectPass> passes, string pass)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015AA")]
	[Cpp2IlInjected.Address(RVA = "0x1594B5C", Offset = "0x1594B5C", VA = "0x1594B5C", Slot = "5")]
	public override void ApplyValuesToMaterial(EffectPass pass, Material material)
	{
	}
}
