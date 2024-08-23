using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002C6 RID: 710
	[global::Cpp2ILInjected.Token(Token = "0x20003C5")]
	public class UInt32Converter : BaseNumberConverter
	{
		// Token: 0x170005A4 RID: 1444
		// (get) Token: 0x06001745 RID: 5957 RVA: 0x00006FD7 File Offset: 0x000051D7
		[global::Cpp2ILInjected.Token(Token = "0x170005D8")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5FB94", Offset = "0x1E5FB94", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001746 RID: 5958 RVA: 0x00006FDA File Offset: 0x000051DA
		[global::Cpp2ILInjected.Token(Token = "0x60019A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FC00", Offset = "0x1E5FC00", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x06001747 RID: 5959 RVA: 0x00006FDD File Offset: 0x000051DD
		[global::Cpp2ILInjected.Token(Token = "0x60019A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FC94", Offset = "0x1E5FC94", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x00006FE0 File Offset: 0x000051E0
		[global::Cpp2ILInjected.Token(Token = "0x60019AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FD08", Offset = "0x1E5FD08", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(uint), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x00006FE3 File Offset: 0x000051E3
		[global::Cpp2ILInjected.Token(Token = "0x60019AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5FDB0", Offset = "0x1E5FDB0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public UInt32Converter()
		{
			throw null;
		}
	}
}
