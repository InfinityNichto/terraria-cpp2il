using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000652")]
	[global::System.Serializable]
	internal class GenericComparer<T> : Comparer<T> where T : global::System.IComparable<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003171")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A8C48", Offset = "0x16A8C48", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "CompareTo", MemberParameters = new object[] { "System.ValueTuple`1<T1>" }, ReturnType = typeof(int))]
		public override int Compare(T x, T y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003172")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A8C74", Offset = "0x16A8C74", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003173")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A8CD0", Offset = "0x16A8CD0", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003174")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A8CF8", Offset = "0x16A8CF8", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GenericComparer()
		{
			throw null;
		}
	}
}
