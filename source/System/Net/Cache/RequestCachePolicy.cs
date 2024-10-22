﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net.Cache
{
	[global::Cpp2ILInjected.Token(Token = "0x20002E7")]
	public class RequestCachePolicy
	{
		[global::Cpp2ILInjected.Token(Token = "0x60012FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E216BC", Offset = "0x1E216BC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpWebRequest), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public RequestCachePolicy(RequestCacheLevel level)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000464")]
		public RequestCacheLevel Level
		{
			[global::Cpp2ILInjected.Token(Token = "0x60012FE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E217C0", Offset = "0x1E217C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60012FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E217C8", Offset = "0x1E217C8", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override string ToString()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000F7E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private RequestCacheLevel m_Level;
	}
}
