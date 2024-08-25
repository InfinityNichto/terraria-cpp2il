using System;
using System.Collections;
using System.Collections.Specialized;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x20001EC")]
	internal class HeaderInfoTable
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000C0D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F246CC", Offset = "0x1F246CC", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static string[] ParseSingleValue(string value)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6000C11")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F26010", Offset = "0x1F26010", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WebHeaderCollection), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public HeaderInfoTable()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000A7B")]
		private static Hashtable HeaderHashTable;

		[global::Cpp2ILInjected.Token(Token = "0x4000A7C")]
		private static HeaderInfo UnknownHeaderInfo;

		[global::Cpp2ILInjected.Token(Token = "0x4000A7D")]
		private static HeaderParser SingleParser;

		[global::Cpp2ILInjected.Token(Token = "0x4000A7E")]
		private static HeaderParser MultiParser;
	}
}
