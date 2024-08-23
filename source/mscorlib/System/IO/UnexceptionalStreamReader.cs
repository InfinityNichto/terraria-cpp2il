using System;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000499 RID: 1177
	[global::Cpp2ILInjected.Token(Token = "0x200056F")]
	internal class UnexceptionalStreamReader : StreamReader
	{
		// Token: 0x060026CE RID: 9934 RVA: 0x0001B10D File Offset: 0x0001930D
		[global::Cpp2ILInjected.Token(Token = "0x60029EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1340", Offset = "0x1BD1340", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static UnexceptionalStreamReader()
		{
			throw null;
		}

		// Token: 0x060026CF RID: 9935 RVA: 0x0001B110 File Offset: 0x00019310
		[global::Cpp2ILInjected.Token(Token = "0x60029EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD13DC", Offset = "0x1BD13DC", Length = "0x70")]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UnexceptionalStreamReader(Stream stream, global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060026D0 RID: 9936 RVA: 0x0001B113 File Offset: 0x00019313
		[global::Cpp2ILInjected.Token(Token = "0x60029ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD144C", Offset = "0x1BD144C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "Peek", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override int Peek()
		{
			throw null;
		}

		// Token: 0x060026D1 RID: 9937 RVA: 0x0001B116 File Offset: 0x00019316
		[global::Cpp2ILInjected.Token(Token = "0x60029EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD14D4", Offset = "0x1BD14D4", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override int Read()
		{
			throw null;
		}

		// Token: 0x060026D2 RID: 9938 RVA: 0x0001B119 File Offset: 0x00019319
		[global::Cpp2ILInjected.Token(Token = "0x60029EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD155C", Offset = "0x1BD155C", Length = "0x268")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "Read", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnexceptionalStreamReader), Member = "CheckEOL", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override int Read([global::System.Runtime.InteropServices.In] [global::System.Runtime.InteropServices.Out] char[] dest_buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060026D3 RID: 9939 RVA: 0x0001B11C File Offset: 0x0001931C
		[global::Cpp2ILInjected.Token(Token = "0x60029F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD17C4", Offset = "0x1BD17C4", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnexceptionalStreamReader), Member = "Read", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "get_NewLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private bool CheckEOL(char current)
		{
			throw null;
		}

		// Token: 0x060026D4 RID: 9940 RVA: 0x0001B11F File Offset: 0x0001931F
		[global::Cpp2ILInjected.Token(Token = "0x60029F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD1914", Offset = "0x1BD1914", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "ReadLine", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override string ReadLine()
		{
			throw null;
		}

		// Token: 0x060026D5 RID: 9941 RVA: 0x0001B122 File Offset: 0x00019322
		[global::Cpp2ILInjected.Token(Token = "0x60029F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BD199C", Offset = "0x1BD199C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamReader), Member = "ReadToEnd", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override string ReadToEnd()
		{
			throw null;
		}

		// Token: 0x04001338 RID: 4920
		[global::Cpp2ILInjected.Token(Token = "0x4001687")]
		private static bool[] newline;

		// Token: 0x04001339 RID: 4921
		[global::Cpp2ILInjected.Token(Token = "0x4001688")]
		private static char newlineChar;
	}
}
