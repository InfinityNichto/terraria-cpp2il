using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	[global::Cpp2ILInjected.Token(Token = "0x20003D4")]
	internal class ArraySubsetEnumerator : IEnumerator
	{
		[global::Cpp2ILInjected.Token(Token = "0x60019DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E607C8", Offset = "0x1E607C8", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ArraySubsetEnumerator(Array array, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E607FC", Offset = "0x1E607FC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public bool MoveNext()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60019DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E60824", Offset = "0x1E60824", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170005E2")]
		public object Current
		{
			[global::Cpp2ILInjected.Token(Token = "0x60019DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E60830", Offset = "0x1E60830", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "GetValue", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x40012E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Array array;

		[global::Cpp2ILInjected.Token(Token = "0x40012E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int total;

		[global::Cpp2ILInjected.Token(Token = "0x40012E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int current;
	}
}
