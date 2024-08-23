using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035F RID: 863
	[global::Cpp2ILInjected.Token(Token = "0x2000407")]
	internal sealed class BinaryMethodReturn
	{
		// Token: 0x06001DAF RID: 7599 RVA: 0x00019814 File Offset: 0x00017A14
		[global::Cpp2ILInjected.Token(Token = "0x6001FED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D2E4", Offset = "0x1B5D2E4", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FormatterServices), Member = "GetUninitializedObject", MemberParameters = new object[] { typeof(global::System.Type) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static BinaryMethodReturn()
		{
			throw null;
		}

		// Token: 0x06001DB0 RID: 7600 RVA: 0x00019817 File Offset: 0x00017A17
		[global::Cpp2ILInjected.Token(Token = "0x6001FEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D38C", Offset = "0x1B5D38C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal BinaryMethodReturn()
		{
			throw null;
		}

		// Token: 0x06001DB1 RID: 7601 RVA: 0x0001981A File Offset: 0x00017A1A
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

		// Token: 0x06001DB2 RID: 7602 RVA: 0x0001981D File Offset: 0x00017A1D
		[global::Cpp2ILInjected.Token(Token = "0x6001FF0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D4B4", Offset = "0x1B5D4B4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Dump()
		{
			throw null;
		}

		// Token: 0x04000D80 RID: 3456
		[global::Cpp2ILInjected.Token(Token = "0x4001072")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private object returnValue;

		// Token: 0x04000D81 RID: 3457
		[global::Cpp2ILInjected.Token(Token = "0x4001073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private object[] args;

		// Token: 0x04000D82 RID: 3458
		[global::Cpp2ILInjected.Token(Token = "0x4001074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object callContext;

		// Token: 0x04000D83 RID: 3459
		[global::Cpp2ILInjected.Token(Token = "0x4001075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Type[] argTypes;

		// Token: 0x04000D84 RID: 3460
		[global::Cpp2ILInjected.Token(Token = "0x4001076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool bArgsPrimitive;

		// Token: 0x04000D85 RID: 3461
		[global::Cpp2ILInjected.Token(Token = "0x4001077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private MessageEnum messageEnum;

		// Token: 0x04000D86 RID: 3462
		[global::Cpp2ILInjected.Token(Token = "0x4001078")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private global::System.Type returnType;

		// Token: 0x04000D87 RID: 3463
		[global::Cpp2ILInjected.Token(Token = "0x4001079")]
		private static object instanceOfVoid;
	}
}
