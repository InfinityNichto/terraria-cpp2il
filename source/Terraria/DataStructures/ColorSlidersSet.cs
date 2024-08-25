using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	[global::Cpp2ILInjected.Token(Token = "0x200061C")]
	public class ColorSlidersSet
	{
		[global::Cpp2ILInjected.Token(Token = "0x60035C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBAB8", Offset = "0x13DBAB8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "rgbToHsl", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetHSL(Color color)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBB28", Offset = "0x13DBB28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetHSL(Vector3 vector)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBB34", Offset = "0x13DBB34", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "hslToRgb", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float),
			typeof(byte)
		}, ReturnType = typeof(Color))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Color GetColor()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBBD8", Offset = "0x13DBBD8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Vector3), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(float),
			typeof(float),
			typeof(float)
		}, ReturnType = typeof(void))]
		public Vector3 GetHSLVector()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBC10", Offset = "0x13DBC10", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_hBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_sBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_lBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "set_aBar", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ApplyToMainLegacyBars()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60035CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBC98", Offset = "0x13DBC98", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ColorSlidersSet()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400769F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float Hue;

		[global::Cpp2ILInjected.Token(Token = "0x40076A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float Saturation;

		[global::Cpp2ILInjected.Token(Token = "0x40076A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float Luminance;

		[global::Cpp2ILInjected.Token(Token = "0x40076A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float Alpha;
	}
}
