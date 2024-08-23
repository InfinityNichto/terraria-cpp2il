using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x02000297 RID: 663
	[global::Cpp2ILInjected.Token(Token = "0x200038E")]
	public class Int32Converter : BaseNumberConverter
	{
		// Token: 0x17000540 RID: 1344
		// (get) Token: 0x0600156B RID: 5483 RVA: 0x00006A82 File Offset: 0x00004C82
		[global::Cpp2ILInjected.Token(Token = "0x1700056A")]
		internal override Type TargetType
		{
			[global::Cpp2ILInjected.Token(Token = "0x60017B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E4D348", Offset = "0x1E4D348", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x00006A85 File Offset: 0x00004C85
		[global::Cpp2ILInjected.Token(Token = "0x60017B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D3B4", Offset = "0x1E4D3B4", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override object FromString(string value, int radix)
		{
			throw null;
		}

		// Token: 0x0600156D RID: 5485 RVA: 0x00006A88 File Offset: 0x00004C88
		[global::Cpp2ILInjected.Token(Token = "0x60017B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D448", Offset = "0x1E4D448", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(NumberStyles),
			typeof(IFormatProvider)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal override object FromString(string value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x0600156E RID: 5486 RVA: 0x00006A8B File Offset: 0x00004C8B
		[global::Cpp2ILInjected.Token(Token = "0x60017B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D4BC", Offset = "0x1E4D4BC", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(IFormatProvider)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal override string ToString(object value, NumberFormatInfo formatInfo)
		{
			throw null;
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x00006A8E File Offset: 0x00004C8E
		[global::Cpp2ILInjected.Token(Token = "0x60017BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E4D564", Offset = "0x1E4D564", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BaseNumberConverter), Member = ".ctor", ReturnType = typeof(void))]
		public Int32Converter()
		{
			throw null;
		}
	}
}
