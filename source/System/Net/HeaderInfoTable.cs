using System;
using System.Collections;
using System.Collections.Specialized;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000159 RID: 345
	[global::Cpp2ILInjected.Token(Token = "0x20001EC")]
	internal class HeaderInfoTable
	{
		// Token: 0x06000AE2 RID: 2786 RVA: 0x00004D12 File Offset: 0x00002F12
		[global::Cpp2ILInjected.Token(Token = "0x6000C0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F246CC", Offset = "0x1F246CC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string[] ParseSingleValue(string value)
		{
			throw null;
		}

		// Token: 0x06000AE3 RID: 2787 RVA: 0x00004D15 File Offset: 0x00002F15
		[global::Cpp2ILInjected.Token(Token = "0x6000C0E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F24748", Offset = "0x1F24748", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringCollection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringCollection), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringCollection), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringCollection), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(string[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static string[] ParseMultiValue(string value)
		{
			throw null;
		}

		// Token: 0x06000AE4 RID: 2788 RVA: 0x00004D18 File Offset: 0x00002F18
		[global::Cpp2ILInjected.Token(Token = "0x6000C0F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F24924", Offset = "0x1F24924", Length = "0x1618")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(HeaderParser), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(IEqualityComparer)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 173)]
		static HeaderInfoTable()
		{
			throw null;
		}

		// Token: 0x1700026C RID: 620
		[global::Cpp2ILInjected.Token(Token = "0x17000279")]
		internal HeaderInfo this[string name]
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C10")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F25F3C", Offset = "0x1F25F3C", Length = "0xD4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "AllowMultiValues", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "SetAddVerified", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "ThrowOnRestrictedHeader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "GetValues", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = "IsRestricted", MemberParameters = new object[]
			{
				typeof(string),
				typeof(bool)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000AE6 RID: 2790 RVA: 0x00004D1E File Offset: 0x00002F1E
		[global::Cpp2ILInjected.Token(Token = "0x6000C11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26010", Offset = "0x1F26010", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HeaderInfoTable()
		{
			throw null;
		}

		// Token: 0x04000837 RID: 2103
		[global::Cpp2ILInjected.Token(Token = "0x4000A7B")]
		private static Hashtable HeaderHashTable;

		// Token: 0x04000838 RID: 2104
		[global::Cpp2ILInjected.Token(Token = "0x4000A7C")]
		private static HeaderInfo UnknownHeaderInfo;

		// Token: 0x04000839 RID: 2105
		[global::Cpp2ILInjected.Token(Token = "0x4000A7D")]
		private static HeaderParser SingleParser;

		// Token: 0x0400083A RID: 2106
		[global::Cpp2ILInjected.Token(Token = "0x4000A7E")]
		private static HeaderParser MultiParser;
	}
}
