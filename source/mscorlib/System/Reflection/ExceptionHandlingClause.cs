using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Reflection
{
	// Token: 0x02000443 RID: 1091
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000504")]
	[StructLayout(0)]
	public class ExceptionHandlingClause
	{
		// Token: 0x060022C4 RID: 8900 RVA: 0x0001A5DC File Offset: 0x000187DC
		[global::Cpp2ILInjected.Token(Token = "0x6002560")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8B854", Offset = "0x1B8B854", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected ExceptionHandlingClause()
		{
			throw null;
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x0001A5DF File Offset: 0x000187DF
		[global::Cpp2ILInjected.Token(Token = "0x6002561")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8B85C", Offset = "0x1B8B85C", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040011A6 RID: 4518
		[global::Cpp2ILInjected.Token(Token = "0x40014C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal global::System.Type catch_type;

		// Token: 0x040011A7 RID: 4519
		[global::Cpp2ILInjected.Token(Token = "0x40014C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int filter_offset;

		// Token: 0x040011A8 RID: 4520
		[global::Cpp2ILInjected.Token(Token = "0x40014C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		internal ExceptionHandlingClauseOptions flags;

		// Token: 0x040011A9 RID: 4521
		[global::Cpp2ILInjected.Token(Token = "0x40014C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int try_offset;

		// Token: 0x040011AA RID: 4522
		[global::Cpp2ILInjected.Token(Token = "0x40014C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		internal int try_length;

		// Token: 0x040011AB RID: 4523
		[global::Cpp2ILInjected.Token(Token = "0x40014C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal int handler_offset;

		// Token: 0x040011AC RID: 4524
		[global::Cpp2ILInjected.Token(Token = "0x40014C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		internal int handler_length;
	}
}
