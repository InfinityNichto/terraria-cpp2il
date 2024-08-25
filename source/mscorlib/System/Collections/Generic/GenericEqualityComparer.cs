using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections.Generic
{
	[global::Cpp2ILInjected.Token(Token = "0x2000656")]
	[global::System.Serializable]
	internal class GenericEqualityComparer<T> : EqualityComparer<T> where T : global::System.IEquatable<T>
	{
		[global::Cpp2ILInjected.Token(Token = "0x6003186")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9ACC", Offset = "0x16A9ACC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`1<T1>" }, ReturnType = typeof(bool))]
		public override bool Equals(T x, T y)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003187")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9AFC", Offset = "0x16A9AFC", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode(T obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003188")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9B20", Offset = "0x16A9B20", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`1<T1>" }, ReturnType = typeof(bool))]
		internal override int IndexOf(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6003189")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9B98", Offset = "0x16A9B98", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<>), Member = "Equals", MemberParameters = new object[] { "System.ValueTuple`1<T1>" }, ReturnType = typeof(bool))]
		internal override int LastIndexOf(T[] array, T value, int startIndex, int count)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600318A")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9C08", Offset = "0x16A9C08", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object obj)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600318B")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9C64", Offset = "0x16A9C64", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override int GetHashCode()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600318C")]
		[global::Cpp2ILInjected.Address(RVA = "0x16A9C8C", Offset = "0x16A9C8C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public GenericEqualityComparer()
		{
			throw null;
		}
	}
}
