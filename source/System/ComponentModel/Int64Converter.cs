using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000298 RID: 664
	[global::Cpp2ILInjected.Token(Token = "0x200038F")]
	public class Int64Converter : BaseNumberConverter
	{
		// Token: 0x17000541 RID: 1345
		// (get) Token: 0x06001570 RID: 5488 RVA: 0x00006A91 File Offset: 0x00004C91
		[global::Cpp2ILInjected.Token(Token = "0x1700056B")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4D56C", Offset = "0x1E4D56C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00006A94 File Offset: 0x00004C94
		[global::Cpp2ILInjected.Token(Token = "0x60017BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D5D8", Offset = "0x1E4D5D8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00006A97 File Offset: 0x00004C97
		[global::Cpp2ILInjected.Token(Token = "0x60017BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D66C", Offset = "0x1E4D66C", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001573 RID: 5491 RVA: 0x00006A9A File Offset: 0x00004C9A
		[global::Cpp2ILInjected.Token(Token = "0x60017BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D6E0", Offset = "0x1E4D6E0", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001574 RID: 5492 RVA: 0x00006A9D File Offset: 0x00004C9D
		[global::Cpp2ILInjected.Token(Token = "0x60017BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D788", Offset = "0x1E4D788", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public Int64Converter()
		{
			throw null;
		}
	}
}
