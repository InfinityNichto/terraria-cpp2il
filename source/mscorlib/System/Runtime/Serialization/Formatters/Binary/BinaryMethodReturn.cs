using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	[global::Cpp2ILInjected.Token(Token = "0x2000407")]
	internal sealed class BinaryMethodReturn
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001FED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D2E4", Offset = "0x1B5D2E4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static BinaryMethodReturn()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D38C", Offset = "0x1B5D38C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryMethodReturn()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FEF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D39C", Offset = "0x1B5D39C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(__BinaryWriter), Member = "WriteMethodReturn", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOUtil), Member = "WriteWithCode", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(object),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOUtil), Member = "WriteStringWithCode", MemberParameters = new object[]
		{
			typeof(string),
			typeof(__BinaryWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Write(__BinaryWriter sout)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001FF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D4B4", Offset = "0x1B5D4B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dump()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4001072")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object returnValue;

		[global::Cpp2ILInjected.Token(Token = "0x4001073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object[] args;

		[global::Cpp2ILInjected.Token(Token = "0x4001074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object callContext;

		[global::Cpp2ILInjected.Token(Token = "0x4001075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Type[] argTypes;

		[global::Cpp2ILInjected.Token(Token = "0x4001076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool bArgsPrimitive;

		[global::Cpp2ILInjected.Token(Token = "0x4001077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private MessageEnum messageEnum;

		[global::Cpp2ILInjected.Token(Token = "0x4001078")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Type returnType;

		[global::Cpp2ILInjected.Token(Token = "0x4001079")]
		private static object instanceOfVoid;
	}
}
