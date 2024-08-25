using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000404")]
	internal sealed class BinaryCrossAppDomainAssembly
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D0C0", Offset = "0x1B5D0C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryCrossAppDomainAssembly()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D0C8", Offset = "0x1B5D0C8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D104", Offset = "0x1B5D104", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001067")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int assemId;

		[global::Cpp2ILInjected.Token(Token = "0x4001068")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		internal int assemblyIndex;
	}
}
