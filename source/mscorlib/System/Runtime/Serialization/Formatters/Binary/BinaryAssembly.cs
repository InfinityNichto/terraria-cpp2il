using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000403")]
	internal sealed class BinaryAssembly
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FDD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D00C", Offset = "0x1B5D00C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryAssembly()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D014", Offset = "0x1B5D014", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int assemId, string assemblyString)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D020", Offset = "0x1B5D020", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteAssembly", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(string),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D080", Offset = "0x1B5D080", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadString", ReturnType = typeof(string))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D0BC", Offset = "0x1B5D0BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadAssembly", MemberParameters = new object[] { typeof(BinaryHeaderEnum) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001065")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int assemId;

		[global::Cpp2ILInjected.Token(Token = "0x4001066")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string assemblyString;
	}
}
