using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002C7 RID: 711
	[global::Cpp2ILInjected.Token(Token = "0x20003C6")]
	public class UInt64Converter : BaseNumberConverter
	{
		// Token: 0x170005A5 RID: 1445
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00006FE6 File Offset: 0x000051E6
		[global::Cpp2ILInjected.Token(Token = "0x170005D9")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5FDB8", Offset = "0x1E5FDB8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600174B RID: 5963 RVA: 0x00006FE9 File Offset: 0x000051E9
		[global::Cpp2ILInjected.Token(Token = "0x60019AD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FE24", Offset = "0x1E5FE24", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x0600174C RID: 5964 RVA: 0x00006FEC File Offset: 0x000051EC
		[global::Cpp2ILInjected.Token(Token = "0x60019AE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FEB8", Offset = "0x1E5FEB8", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(ulong))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00006FEF File Offset: 0x000051EF
		[global::Cpp2ILInjected.Token(Token = "0x60019AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FF2C", Offset = "0x1E5FF2C", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ulong), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00006FF2 File Offset: 0x000051F2
		[global::Cpp2ILInjected.Token(Token = "0x60019B0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FFD4", Offset = "0x1E5FFD4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public UInt64Converter()
		{
			throw null;
		}
	}
}
