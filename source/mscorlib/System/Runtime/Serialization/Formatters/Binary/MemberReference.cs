using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000410")]
	internal sealed class MemberReference
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E27C", Offset = "0x1B5E27C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MemberReference()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E284", Offset = "0x1B5E284", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(int idRef)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E28C", Offset = "0x1B5E28C", Length = "0x48")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600201A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E2D4", Offset = "0x1B5E2D4", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadInt32", ReturnType = typeof(int))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600201B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E2F4", Offset = "0x1B5E2F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberReference", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400109B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal int idRef;
	}
}
