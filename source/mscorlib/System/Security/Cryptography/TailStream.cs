using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Cryptography
{
	// Token: 0x02000247 RID: 583
	[global::Cpp2ILInjected.Token(Token = "0x20002E4")]
	internal sealed class TailStream : global::System.IO.Stream
	{
		// Token: 0x060016B7 RID: 5815 RVA: 0x000184C1 File Offset: 0x000166C1
		[global::Cpp2ILInjected.Token(Token = "0x60018D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF61C", Offset = "0x1AFF61C", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = "HashCore", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MACTripleDES), Member = "HashFinal", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public TailStream(int bufferSize)
		{
			throw null;
		}

		// Token: 0x060016B8 RID: 5816 RVA: 0x000184C4 File Offset: 0x000166C4
		[global::Cpp2ILInjected.Token(Token = "0x60018D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF94C", Offset = "0x1AFF94C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x060016B9 RID: 5817 RVA: 0x000184C7 File Offset: 0x000166C7
		[global::Cpp2ILInjected.Token(Token = "0x60018D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFF95C", Offset = "0x1AFF95C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.Stream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x17000250 RID: 592
		// (get) Token: 0x060016BA RID: 5818 RVA: 0x000184CA File Offset: 0x000166CA
		[global::Cpp2ILInjected.Token(Token = "0x170002A6")]
		public byte[] Buffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFF7D8", Offset = "0x1AFF7D8", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clone", ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000251 RID: 593
		// (get) Token: 0x060016BB RID: 5819 RVA: 0x000184CD File Offset: 0x000166CD
		[global::Cpp2ILInjected.Token(Token = "0x170002A7")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFFA1C", Offset = "0x1AFFA1C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000252 RID: 594
		// (get) Token: 0x060016BC RID: 5820 RVA: 0x000184D0 File Offset: 0x000166D0
		[global::Cpp2ILInjected.Token(Token = "0x170002A8")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFFA24", Offset = "0x1AFFA24", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000253 RID: 595
		// (get) Token: 0x060016BD RID: 5821 RVA: 0x000184D3 File Offset: 0x000166D3
		[global::Cpp2ILInjected.Token(Token = "0x170002A9")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFFA2C", Offset = "0x1AFFA2C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000254 RID: 596
		// (get) Token: 0x060016BE RID: 5822 RVA: 0x000184D6 File Offset: 0x000166D6
		[global::Cpp2ILInjected.Token(Token = "0x170002AA")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFFA3C", Offset = "0x1AFFA3C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060016BF RID: 5823 RVA: 0x000184D9 File Offset: 0x000166D9
		// (set) Token: 0x060016C0 RID: 5824 RVA: 0x000184DC File Offset: 0x000166DC
		[global::Cpp2ILInjected.Token(Token = "0x170002AB")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60018D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFFA94", Offset = "0x1AFFA94", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60018DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AFFAEC", Offset = "0x1AFFAEC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060016C1 RID: 5825 RVA: 0x000184DF File Offset: 0x000166DF
		[global::Cpp2ILInjected.Token(Token = "0x60018DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFB44", Offset = "0x1AFFB44", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060016C2 RID: 5826 RVA: 0x000184E2 File Offset: 0x000166E2
		[global::Cpp2ILInjected.Token(Token = "0x60018DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFB48", Offset = "0x1AFFB48", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x060016C3 RID: 5827 RVA: 0x000184E5 File Offset: 0x000166E5
		[global::Cpp2ILInjected.Token(Token = "0x60018DD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFBA0", Offset = "0x1AFFBA0", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x060016C4 RID: 5828 RVA: 0x000184E8 File Offset: 0x000166E8
		[global::Cpp2ILInjected.Token(Token = "0x60018DE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFBF8", Offset = "0x1AFFBF8", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060016C5 RID: 5829 RVA: 0x000184EB File Offset: 0x000166EB
		[global::Cpp2ILInjected.Token(Token = "0x60018DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AFFC50", Offset = "0x1AFFC50", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "InternalBlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ObjectDisposedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x040009E7 RID: 2535
		[global::Cpp2ILInjected.Token(Token = "0x4000CC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _Buffer;

		// Token: 0x040009E8 RID: 2536
		[global::Cpp2ILInjected.Token(Token = "0x4000CC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _BufferSize;

		// Token: 0x040009E9 RID: 2537
		[global::Cpp2ILInjected.Token(Token = "0x4000CC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int _BufferIndex;

		// Token: 0x040009EA RID: 2538
		[global::Cpp2ILInjected.Token(Token = "0x4000CC4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private bool _BufferFull;
	}
}
