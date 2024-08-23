using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Runtime.Serialization.Formatters.Binary
{
	// Token: 0x0200035E RID: 862
	[global::Cpp2ILInjected.Token(Token = "0x2000406")]
	internal sealed class BinaryMethodCall
	{
		// Token: 0x06001DAC RID: 7596 RVA: 0x0001980B File Offset: 0x00017A0B
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

		// Token: 0x06001DAD RID: 7597 RVA: 0x0001980E File Offset: 0x00017A0E
		[global::Cpp2ILInjected.Token(Token = "0x6001FEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D2D0", Offset = "0x1B5D2D0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void Dump()
		{
			throw null;
		}

		// Token: 0x06001DAE RID: 7598 RVA: 0x00019811 File Offset: 0x00017A11
		[global::Cpp2ILInjected.Token(Token = "0x6001FEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B5D2D4", Offset = "0x1B5D2D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public BinaryMethodCall()
		{
			throw null;
		}

		// Token: 0x04000D79 RID: 3449
		[global::Cpp2ILInjected.Token(Token = "0x400106B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string methodName;

		// Token: 0x04000D7A RID: 3450
		[global::Cpp2ILInjected.Token(Token = "0x400106C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string typeName;

		// Token: 0x04000D7B RID: 3451
		[global::Cpp2ILInjected.Token(Token = "0x400106D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private object[] args;

		// Token: 0x04000D7C RID: 3452
		[global::Cpp2ILInjected.Token(Token = "0x400106E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private object callContext;

		// Token: 0x04000D7D RID: 3453
		[global::Cpp2ILInjected.Token(Token = "0x400106F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private global::System.Type[] argTypes;

		// Token: 0x04000D7E RID: 3454
		[global::Cpp2ILInjected.Token(Token = "0x4001070")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool bArgsPrimitive;

		// Token: 0x04000D7F RID: 3455
		[global::Cpp2ILInjected.Token(Token = "0x4001071")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private MessageEnum messageEnum;
	}
}
