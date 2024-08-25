using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000406")]
	internal sealed class BinaryMethodCall
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D1B8", Offset = "0x1B5D1B8", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMethodCall", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOUtil), Member = "WriteStringWithCode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Write(__BinaryWriter sout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D2D0", Offset = "0x1B5D2D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D2D4", Offset = "0x1B5D2D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BinaryMethodCall()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400106B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string methodName;

		[global::Cpp2ILInjected.Token(Token = "0x400106C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string typeName;

		[global::Cpp2ILInjected.Token(Token = "0x400106D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object[] args;

		[global::Cpp2ILInjected.Token(Token = "0x400106E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object callContext;

		[global::Cpp2ILInjected.Token(Token = "0x400106F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Type[] argTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4001070")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool bArgsPrimitive;

		[global::Cpp2ILInjected.Token(Token = "0x4001071")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private MessageEnum messageEnum;
	}
}
