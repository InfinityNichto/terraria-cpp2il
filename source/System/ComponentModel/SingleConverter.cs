using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002BB RID: 699
	[global::Cpp2ILInjected.Token(Token = "0x20003B9")]
	public class SingleConverter : BaseNumberConverter
	{
		// Token: 0x1700059C RID: 1436
		// (get) Token: 0x06001705 RID: 5893 RVA: 0x00006F17 File Offset: 0x00005117
		[global::Cpp2ILInjected.Token(Token = "0x170005D0")]
		internal override bool AllowHex
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001966")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5DA14", Offset = "0x1E5DA14", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700059D RID: 1437
		// (get) Token: 0x06001706 RID: 5894 RVA: 0x00006F1A File Offset: 0x0000511A
		[global::Cpp2ILInjected.Token(Token = "0x170005D1")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001967")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E5DA1C", Offset = "0x1E5DA1C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001707 RID: 5895 RVA: 0x00006F1D File Offset: 0x0000511D
		[global::Cpp2ILInjected.Token(Token = "0x6001968")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DA88", Offset = "0x1E5DA88", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToSingle", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x06001708 RID: 5896 RVA: 0x00006F20 File Offset: 0x00005120
		[global::Cpp2ILInjected.Token(Token = "0x6001969")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DB48", Offset = "0x1E5DB48", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x06001709 RID: 5897 RVA: 0x00006F23 File Offset: 0x00005123
		[global::Cpp2ILInjected.Token(Token = "0x600196A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DBB8", Offset = "0x1E5DBB8", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(float), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x0600170A RID: 5898 RVA: 0x00006F26 File Offset: 0x00005126
		[global::Cpp2ILInjected.Token(Token = "0x600196B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E5DC60", Offset = "0x1E5DC60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public SingleConverter()
		{
			throw null;
		}
	}
}
