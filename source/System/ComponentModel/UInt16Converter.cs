using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002C5 RID: 709
	[global::Cpp2ILInjected.Token(Token = "0x20003C4")]
	public class UInt16Converter : BaseNumberConverter
	{
		// Token: 0x170005A3 RID: 1443
		// (get) Token: 0x06001740 RID: 5952 RVA: 0x00006FC8 File Offset: 0x000051C8
		[global::Cpp2ILInjected.Token(Token = "0x170005D7")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5F970", Offset = "0x1E5F970", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001741 RID: 5953 RVA: 0x00006FCB File Offset: 0x000051CB
		[global::Cpp2ILInjected.Token(Token = "0x60019A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5F9DC", Offset = "0x1E5F9DC", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x06001742 RID: 5954 RVA: 0x00006FCE File Offset: 0x000051CE
		[global::Cpp2ILInjected.Token(Token = "0x60019A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FA70", Offset = "0x1E5FA70", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001743 RID: 5955 RVA: 0x00006FD1 File Offset: 0x000051D1
		[global::Cpp2ILInjected.Token(Token = "0x60019A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FAE4", Offset = "0x1E5FAE4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001744 RID: 5956 RVA: 0x00006FD4 File Offset: 0x000051D4
		[global::Cpp2ILInjected.Token(Token = "0x60019A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FB8C", Offset = "0x1E5FB8C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public UInt16Converter()
		{
			throw null;
		}
	}
}
