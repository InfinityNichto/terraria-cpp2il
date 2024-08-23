using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200049B RID: 1179
	[global::Cpp2ILInjected.Token(Token = "0x2000571")]
	internal class CStreamReader : StreamReader
	{
		// Token: 0x060026DC RID: 9948 RVA: 0x0001B137 File Offset: 0x00019337
		[global::Cpp2ILInjected.Token(Token = "0x60029F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1D30", Offset = "0x1BD1D30", Length = "0x114")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Console), Member = "SetupStreams", MemberParameters = new object[]
		{
			typeof(global::System.Text.Encoding),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public CStreamReader(Stream stream, global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060026DD RID: 9949 RVA: 0x0001B13A File Offset: 0x0001933A
		[global::Cpp2ILInjected.Token(Token = "0x60029FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1E44", Offset = "0x1BD1E44", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "Peek", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override int Peek()
		{
			throw null;
		}

		// Token: 0x060026DE RID: 9950 RVA: 0x0001B13D File Offset: 0x0001933D
		[global::Cpp2ILInjected.Token(Token = "0x60029FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1ECC", Offset = "0x1BD1ECC", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Console), Member = "ReadKey", ReturnType = typeof(global::System.ConsoleKeyInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override int Read()
		{
			throw null;
		}

		// Token: 0x060026DF RID: 9951 RVA: 0x0001B140 File Offset: 0x00019340
		[global::Cpp2ILInjected.Token(Token = "0x60029FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1F9C", Offset = "0x1BD1F9C", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override int Read([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] char[] dest, int index, int count)
		{
			throw null;
		}

		// Token: 0x060026E0 RID: 9952 RVA: 0x0001B143 File Offset: 0x00019343
		[global::Cpp2ILInjected.Token(Token = "0x60029FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD2130", Offset = "0x1BD2130", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "ReadLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override string ReadLine()
		{
			throw null;
		}

		// Token: 0x060026E1 RID: 9953 RVA: 0x0001B146 File Offset: 0x00019346
		[global::Cpp2ILInjected.Token(Token = "0x60029FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD21BC", Offset = "0x1BD21BC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.TermInfoDriver), Member = "ReadToEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override string ReadToEnd()
		{
			throw null;
		}

		// Token: 0x0400133A RID: 4922
		[global::Cpp2ILInjected.Token(Token = "0x4001689")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.TermInfoDriver driver;
	}
}
