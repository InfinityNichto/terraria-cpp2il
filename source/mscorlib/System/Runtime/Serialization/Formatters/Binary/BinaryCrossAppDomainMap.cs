using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200040A")]
	internal sealed class BinaryCrossAppDomainMap
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FF9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5B4", Offset = "0x1B5D5B4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryCrossAppDomainMap()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FFA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5BC", Offset = "0x1B5D5BC", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FFB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D5DC", Offset = "0x1B5D5DC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadCrossAppDomainMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400107E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int crossAppDomainArrayIndex;
	}
}
