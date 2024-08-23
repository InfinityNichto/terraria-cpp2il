using System;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200049A RID: 1178
	[global::Cpp2ILInjected.Token(Token = "0x2000570")]
	internal class UnexceptionalStreamWriter : StreamWriter
	{
		// Token: 0x060026D6 RID: 9942 RVA: 0x0001B125 File Offset: 0x00019325
		[global::Cpp2ILInjected.Token(Token = "0x60029F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1A24", Offset = "0x1BD1A24", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnexceptionalStreamWriter(Stream stream, global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060026D7 RID: 9943 RVA: 0x0001B128 File Offset: 0x00019328
		[global::Cpp2ILInjected.Token(Token = "0x60029F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1A9C", Offset = "0x1BD1A9C", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060026D8 RID: 9944 RVA: 0x0001B12B File Offset: 0x0001932B
		[global::Cpp2ILInjected.Token(Token = "0x60029F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1B20", Offset = "0x1BD1B20", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void Write(char[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060026D9 RID: 9945 RVA: 0x0001B12E File Offset: 0x0001932E
		[global::Cpp2ILInjected.Token(Token = "0x60029F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1BA4", Offset = "0x1BD1BA4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void Write(char value)
		{
			throw null;
		}

		// Token: 0x060026DA RID: 9946 RVA: 0x0001B131 File Offset: 0x00019331
		[global::Cpp2ILInjected.Token(Token = "0x60029F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1C28", Offset = "0x1BD1C28", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(char[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void Write(char[] value)
		{
			throw null;
		}

		// Token: 0x060026DB RID: 9947 RVA: 0x0001B134 File Offset: 0x00019334
		[global::Cpp2ILInjected.Token(Token = "0x60029F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1CAC", Offset = "0x1BD1CAC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = "Write", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override void Write(string value)
		{
			throw null;
		}
	}
}
