using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000191")]
	internal class ByteMatcher
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000FB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C88044", Offset = "0x1C88044", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void AddMapping(global::System.TermInfoStrings key, byte[] val)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C88150", Offset = "0x1C88150", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Sort()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C8525C", Offset = "0x1C8525C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool StartsWith(int c)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C852DC", Offset = "0x1C852DC", Length = "0x444")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "GetKeyFromBuffer", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public global::System.TermInfoStrings Match(char[] buffer, int offset, int length, out int used)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000FB4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C87F94", Offset = "0x1C87F94", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.TermInfoDriver), Member = "InitKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Collections.Hashtable), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ByteMatcher()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40006C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Collections.Hashtable map;

		[global::Cpp2ILInjected.Token(Token = "0x40006CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private global::System.Collections.Hashtable starts;
	}
}
