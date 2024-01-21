using System.Collections.Generic;
using Cpp2IlInjected;
using UnityEngine;

namespace Microsoft.Xna.Framework.Graphics;

[Cpp2IlInjected.Token(Token = "0x20002AB")]
public class TileShader : Effect
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4001F4D")]
	private EffectParameter _leafMinHueOffset;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4001F4E")]
	private EffectParameter _leafMinHue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4001F4F")]
	private EffectParameter _leafMaxHue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4001F50")]
	private EffectParameter _leafMinSat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4001F51")]
	private EffectParameter _leafMaxSat;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4001F52")]
	private EffectParameter _invertSpecialGroupResult;

	[Cpp2IlInjected.Token(Token = "0x4001F53")]
	private static int _leafHueTestOffsetId;

	[Cpp2IlInjected.Token(Token = "0x4001F54")]
	private static int _leafMinHueId;

	[Cpp2IlInjected.Token(Token = "0x4001F55")]
	private static int _leafMaxHueId;

	[Cpp2IlInjected.Token(Token = "0x4001F56")]
	private static int _leafMinSatId;

	[Cpp2IlInjected.Token(Token = "0x4001F57")]
	private static int _leafMaxSatId;

	[Cpp2IlInjected.Token(Token = "0x4001F58")]
	private static int _invertSpecialGroupResultId;

	[Cpp2IlInjected.Token(Token = "0x4001F59")]
	private static TileShader _effect;

	[Cpp2IlInjected.Token(Token = "0x17000287")]
	public static TileShader Effect
	{
		[Cpp2IlInjected.Token(Token = "0x60015B1")]
		[Cpp2IlInjected.Address(RVA = "0x154E7FC", Offset = "0x154E7FC", VA = "0x154E7FC")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60015AE")]
	[Cpp2IlInjected.Address(RVA = "0x154DA00", Offset = "0x154DA00", VA = "0x154DA00")]
	public TileShader(GraphicsDevice device)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015AF")]
	[Cpp2IlInjected.Address(RVA = "0x154DCD0", Offset = "0x154DCD0", VA = "0x154DCD0", Slot = "5")]
	public override void ApplyValuesToMaterial(EffectPass pass, Material material)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60015B0")]
	[Cpp2IlInjected.Address(RVA = "0x154DFE4", Offset = "0x154DFE4", VA = "0x154DFE4")]
	public static TileShader CreateNew()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60015B2")]
	[Cpp2IlInjected.Address(RVA = "0x154E614", Offset = "0x154E614", VA = "0x154E614")]
	private static void LoadPass(List<EffectPass> passes, string pass)
	{
	}
}
