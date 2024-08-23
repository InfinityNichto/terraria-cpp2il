using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000296 RID: 662
	[global::Cpp2ILInjected.Token(Token = "0x200038D")]
	public class Int16Converter : BaseNumberConverter
	{
		// Token: 0x1700053F RID: 1343
		// (get) Token: 0x06001566 RID: 5478 RVA: 0x00006A73 File Offset: 0x00004C73
		[global::Cpp2ILInjected.Token(Token = "0x17000569")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4D124", Offset = "0x1E4D124", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00006A76 File Offset: 0x00004C76
		[global::Cpp2ILInjected.Token(Token = "0x60017B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D190", Offset = "0x1E4D190", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x00006A79 File Offset: 0x00004C79
		[global::Cpp2ILInjected.Token(Token = "0x60017B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D224", Offset = "0x1E4D224", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001569 RID: 5481 RVA: 0x00006A7C File Offset: 0x00004C7C
		[global::Cpp2ILInjected.Token(Token = "0x60017B4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D298", Offset = "0x1E4D298", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(short), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x00006A7F File Offset: 0x00004C7F
		[global::Cpp2ILInjected.Token(Token = "0x60017B5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D340", Offset = "0x1E4D340", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public Int16Converter()
		{
			throw null;
		}
	}
}
