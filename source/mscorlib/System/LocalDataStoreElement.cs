using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	[global::Cpp2ILInjected.Token(Token = "0x2000140")]
	internal sealed class LocalDataStoreElement
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000CB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C5C3E8", Offset = "0x1C5C3E8", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public LocalDataStoreElement(long cookie)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000119")]
		public object Value
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5C410", Offset = "0x1C5C410", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000CB2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5C418", Offset = "0x1C5C418", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700011A")]
		public long Cookie
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000CB3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1C5C420", Offset = "0x1C5C420", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40004E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object m_value;

		[global::Cpp2ILInjected.Token(Token = "0x40004E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private long m_cookie;
	}
}
