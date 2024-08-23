using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace Terraria.DataStructures
{
	// Token: 0x02000421 RID: 1057
	[global::Cpp2ILInjected.Token(Token = "0x200061C")]
	public class ColorSlidersSet
	{
		// Token: 0x060030A9 RID: 12457 RVA: 0x0002AB45 File Offset: 0x00028D45
		[global::Cpp2ILInjected.Token(Token = "0x60035C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBAB8", Offset = "0x13DBAB8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "rgbToHsl", MemberParameters = new object[] { typeof(Color) }, ReturnType = typeof(Vector3))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetHSL(Color color)
		{
			throw null;
		}

		// Token: 0x060030AA RID: 12458 RVA: 0x0002AB48 File Offset: 0x00028D48
		[global::Cpp2ILInjected.Token(Token = "0x60035C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBB28", Offset = "0x13DBB28", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetHSL(Vector3 vector)
		{
			throw null;
		}

		// Token: 0x060030AB RID: 12459 RVA: 0x0002AB4B File Offset: 0x00028D4B
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

		// Token: 0x060030AC RID: 12460 RVA: 0x0002AB4E File Offset: 0x00028D4E
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

		// Token: 0x060030AD RID: 12461 RVA: 0x0002AB51 File Offset: 0x00028D51
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

		// Token: 0x060030AE RID: 12462 RVA: 0x0002AB54 File Offset: 0x00028D54
		[global::Cpp2ILInjected.Token(Token = "0x60035CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DBC98", Offset = "0x13DBC98", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ColorSlidersSet()
		{
			throw null;
		}

		// Token: 0x040062B5 RID: 25269
		[global::Cpp2ILInjected.Token(Token = "0x400769F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public float Hue;

		// Token: 0x040062B6 RID: 25270
		[global::Cpp2ILInjected.Token(Token = "0x40076A0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		public float Saturation;

		// Token: 0x040062B7 RID: 25271
		[global::Cpp2ILInjected.Token(Token = "0x40076A1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public float Luminance;

		// Token: 0x040062B8 RID: 25272
		[global::Cpp2ILInjected.Token(Token = "0x40076A2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public float Alpha;
	}
}
