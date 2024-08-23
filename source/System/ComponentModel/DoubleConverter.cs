using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x0200027B RID: 635
	[global::Cpp2ILInjected.Token(Token = "0x2000371")]
	public class DoubleConverter : BaseNumberConverter
	{
		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x060014B2 RID: 5298 RVA: 0x00006947 File Offset: 0x00004B47
		[global::Cpp2ILInjected.Token(Token = "0x17000535")]
		internal override bool AllowHex
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016F9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4A6B0", Offset = "0x1E4A6B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x060014B3 RID: 5299 RVA: 0x0000694A File Offset: 0x00004B4A
		[global::Cpp2ILInjected.Token(Token = "0x17000536")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60016FA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4A6B8", Offset = "0x1E4A6B8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060014B4 RID: 5300 RVA: 0x0000694D File Offset: 0x00004B4D
		[global::Cpp2ILInjected.Token(Token = "0x60016FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A724", Offset = "0x1E4A724", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToDouble", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x060014B5 RID: 5301 RVA: 0x00006950 File Offset: 0x00004B50
		[global::Cpp2ILInjected.Token(Token = "0x60016FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A7E4", Offset = "0x1E4A7E4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x060014B6 RID: 5302 RVA: 0x00006953 File Offset: 0x00004B53
		[global::Cpp2ILInjected.Token(Token = "0x60016FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A854", Offset = "0x1E4A854", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(double), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x060014B7 RID: 5303 RVA: 0x00006956 File Offset: 0x00004B56
		[global::Cpp2ILInjected.Token(Token = "0x60016FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4A8FC", Offset = "0x1E4A8FC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public DoubleConverter()
		{
			throw null;
		}
	}
}
