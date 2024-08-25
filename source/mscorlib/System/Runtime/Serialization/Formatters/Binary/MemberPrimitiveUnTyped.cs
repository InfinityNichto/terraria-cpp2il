using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x200040F")]
	internal sealed class MemberPrimitiveUnTyped
	{
		[global::Cpp2ILInjected.Token(Token = "0x6002011")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E220", Offset = "0x1B5E220", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal MemberPrimitiveUnTyped()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002012")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E228", Offset = "0x1B5E228", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(InternalPrimitiveTypeE typeInformation, object value)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002013")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E234", Offset = "0x1B5E234", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Set(InternalPrimitiveTypeE typeInformation)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002014")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E23C", Offset = "0x1B5E23C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryWriter), Member = "WriteValue", MemberParameters = new object[]
		{
			typeof(InternalPrimitiveTypeE),
			typeof(object)
		}, ReturnType = typeof(void))]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002015")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E250", Offset = "0x1B5E250", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(__BinaryParser), Member = "ReadValue", MemberParameters = new object[] { typeof(InternalPrimitiveTypeE) }, ReturnType = typeof(object))]
		public void Read(__BinaryParser input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6002016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5E278", Offset = "0x1B5E278", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryParser), Member = "ReadMemberPrimitiveUnTyped", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal InternalPrimitiveTypeE typeInformation;

		[global::Cpp2ILInjected.Token(Token = "0x400109A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal object value;
	}
}
