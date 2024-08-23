using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Mono.Net.Security
{
	// Token: 0x02000011 RID: 17
	[global::Cpp2ILInjected.Token(Token = "0x2000049")]
	internal class BufferOffsetSize
	{
		// Token: 0x17000018 RID: 24
		// (get) Token: 0x0600005C RID: 92 RVA: 0x00002F42 File Offset: 0x00001142
		[global::Cpp2ILInjected.Token(Token = "0x17000018")]
		public int EndOffset
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D477FC", Offset = "0x1D477FC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600005D RID: 93 RVA: 0x00002F45 File Offset: 0x00001145
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public int Remaining
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1D47808", Offset = "0x1D47808", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600005E RID: 94 RVA: 0x00002F48 File Offset: 0x00001148
		[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47820", Offset = "0x1D47820", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BufferOffsetSize2), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(AsyncReadOrWriteRequest), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(MobileAuthenticatedStream),
			typeof(bool),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public BufferOffsetSize(byte[] buffer, int offset, int size)
		{
			throw null;
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00002F4B File Offset: 0x0000114B
		[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1D47918", Offset = "0x1D47918", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public byte[] Buffer;

		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x400009C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public int Offset;

		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x400009D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		public int Size;

		// Token: 0x04000022 RID: 34
		[global::Cpp2ILInjected.Token(Token = "0x400009E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public int TotalBytes;

		// Token: 0x04000023 RID: 35
		[global::Cpp2ILInjected.Token(Token = "0x400009F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		public bool Complete;
	}
}
