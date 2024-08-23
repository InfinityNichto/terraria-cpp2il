﻿using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x0200001C RID: 28
	[global::Cpp2ILInjected.Token(Token = "0x200001C")]
	internal class ZipCipherStream : Stream
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00005044 File Offset: 0x00003244
		[global::Cpp2ILInjected.Token(Token = "0x6000094")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47F9C", Offset = "0x1A47F9C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "GetExtractDecryptor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "MaybeApplyEncryption", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZipCipherStream(Stream s, ZipCrypto cipher, CryptoMode mode)
		{
			throw null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00005047 File Offset: 0x00003247
		[global::Cpp2ILInjected.Token(Token = "0x6000095")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4801C", Offset = "0x1A4801C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "DecryptMessage", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000504A File Offset: 0x0000324A
		[global::Cpp2ILInjected.Token(Token = "0x6000096")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A48170", Offset = "0x1A48170", Length = "0x15C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "EncryptMessage", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x1700001C RID: 28
		// (get) Token: 0x06000097 RID: 151 RVA: 0x0000504D File Offset: 0x0000324D
		[global::Cpp2ILInjected.Token(Token = "0x1700001C")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000097")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A482CC", Offset = "0x1A482CC", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001D RID: 29
		// (get) Token: 0x06000098 RID: 152 RVA: 0x00005050 File Offset: 0x00003250
		[global::Cpp2ILInjected.Token(Token = "0x1700001D")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000098")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A482DC", Offset = "0x1A482DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001E RID: 30
		// (get) Token: 0x06000099 RID: 153 RVA: 0x00005053 File Offset: 0x00003253
		[global::Cpp2ILInjected.Token(Token = "0x1700001E")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000099")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A482E4", Offset = "0x1A482E4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00005056 File Offset: 0x00003256
		[global::Cpp2ILInjected.Token(Token = "0x600009A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A482F4", Offset = "0x1A482F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x1700001F RID: 31
		// (get) Token: 0x0600009B RID: 155 RVA: 0x00005059 File Offset: 0x00003259
		[global::Cpp2ILInjected.Token(Token = "0x1700001F")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A482F8", Offset = "0x1A482F8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000020 RID: 32
		// (get) Token: 0x0600009C RID: 156 RVA: 0x0000505C File Offset: 0x0000325C
		// (set) Token: 0x0600009D RID: 157 RVA: 0x0000505F File Offset: 0x0000325F
		[global::Cpp2ILInjected.Token(Token = "0x17000020")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x600009C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A48330", Offset = "0x1A48330", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600009D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A48368", Offset = "0x1A48368", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00005062 File Offset: 0x00003262
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A483A0", Offset = "0x1A483A0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override long Seek(long offset, SeekOrigin origin)
		{
			throw null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00005065 File Offset: 0x00003265
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A483D8", Offset = "0x1A483D8", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x04000049 RID: 73
		[global::Cpp2ILInjected.Token(Token = "0x4000049")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ZipCrypto _cipher;

		// Token: 0x0400004A RID: 74
		[global::Cpp2ILInjected.Token(Token = "0x400004A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private Stream _s;

		// Token: 0x0400004B RID: 75
		[global::Cpp2ILInjected.Token(Token = "0x400004B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private CryptoMode _mode;
	}
}