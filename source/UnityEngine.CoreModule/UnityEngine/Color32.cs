using System;
using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace UnityEngine
{
	// Token: 0x020000BC RID: 188
	[DefaultMember("Item")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000CE")]
	[StructLayout(2)]
	public struct Color32 : IFormattable
	{
		// Token: 0x060003DE RID: 990 RVA: 0x0000288A File Offset: 0x00000A8A
		[global::Cpp2ILInjected.Token(Token = "0x60003F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81694", Offset = "0x1F81694", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public Color32(byte r, byte g, byte b, byte a)
		{
			throw null;
		}

		// Token: 0x060003DF RID: 991 RVA: 0x0000288D File Offset: 0x00000A8D
		[global::Cpp2ILInjected.Token(Token = "0x60003F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F816A8", Offset = "0x1F816A8", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[MethodImpl(256)]
		public static implicit operator Color32(Color c)
		{
			throw null;
		}

		// Token: 0x060003E0 RID: 992 RVA: 0x00002890 File Offset: 0x00000A90
		[global::Cpp2ILInjected.Token(Token = "0x60003F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8196C", Offset = "0x1F8196C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static implicit operator Color(Color32 c)
		{
			throw null;
		}

		// Token: 0x060003E1 RID: 993 RVA: 0x00002893 File Offset: 0x00000A93
		[global::Cpp2ILInjected.Token(Token = "0x60003F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F819A8", Offset = "0x1F819A8", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static Color32 Lerp(Color32 a, Color32 b, float t)
		{
			throw null;
		}

		// Token: 0x060003E2 RID: 994 RVA: 0x00002896 File Offset: 0x00000A96
		[global::Cpp2ILInjected.Token(Token = "0x60003F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81A84", Offset = "0x1F81A84", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060003E3 RID: 995 RVA: 0x00002899 File Offset: 0x00000A99
		[global::Cpp2ILInjected.Token(Token = "0x60003F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F81A90", Offset = "0x1F81A90", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(byte), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = "UnityEngine.UnityString", Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public string ToString(string format, IFormatProvider formatProvider)
		{
			throw null;
		}

		// Token: 0x04000383 RID: 899
		[Ignore(DoesNotContributeToSize = true)]
		[global::Cpp2ILInjected.Token(Token = "0x40003BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		private int rgba;

		// Token: 0x04000384 RID: 900
		[global::Cpp2ILInjected.Token(Token = "0x40003BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		[global::System.Runtime.InteropServices.FieldOffset(0)]
		public byte r;

		// Token: 0x04000385 RID: 901
		[global::Cpp2ILInjected.Token(Token = "0x40003BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1")]
		[global::System.Runtime.InteropServices.FieldOffset(1)]
		public byte g;

		// Token: 0x04000386 RID: 902
		[global::Cpp2ILInjected.Token(Token = "0x40003BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2")]
		[global::System.Runtime.InteropServices.FieldOffset(2)]
		public byte b;

		// Token: 0x04000387 RID: 903
		[global::Cpp2ILInjected.Token(Token = "0x40003BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3")]
		[global::System.Runtime.InteropServices.FieldOffset(3)]
		public byte a;
	}
}
