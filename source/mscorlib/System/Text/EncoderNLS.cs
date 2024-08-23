using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Text
{
	// Token: 0x020001EC RID: 492
	[global::Cpp2ILInjected.Token(Token = "0x2000271")]
	internal class EncoderNLS : Encoder
	{
		// Token: 0x0600134C RID: 4940 RVA: 0x00017B19 File Offset: 0x00015D19
		[global::Cpp2ILInjected.Token(Token = "0x6001506")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD0B34", Offset = "0x1AD0B34", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ASCIIEncoding), Member = "GetEncoder", ReturnType = typeof(Encoder))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal EncoderNLS(Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600134D RID: 4941 RVA: 0x00017B1C File Offset: 0x00015D1C
		[global::Cpp2ILInjected.Token(Token = "0x6001507")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD0B70", Offset = "0x1AD0B70", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override void Reset()
		{
			throw null;
		}

		// Token: 0x0600134E RID: 4942 RVA: 0x00017B1F File Offset: 0x00015D1F
		[global::Cpp2ILInjected.Token(Token = "0x6001508")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD0B90", Offset = "0x1AD0B90", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override int GetByteCount(char[] chars, int index, int count, bool flush)
		{
			throw null;
		}

		// Token: 0x0600134F RID: 4943 RVA: 0x00017B22 File Offset: 0x00015D22
		[global::Cpp2ILInjected.Token(Token = "0x6001509")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD0D5C", Offset = "0x1AD0D5C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetByteCount(char* chars, int count, bool flush)
		{
			throw null;
		}

		// Token: 0x06001350 RID: 4944 RVA: 0x00017B25 File Offset: 0x00015D25
		[global::Cpp2ILInjected.Token(Token = "0x600150A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD0E44", Offset = "0x1AD0E44", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		public override int GetBytes(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, bool flush)
		{
			throw null;
		}

		// Token: 0x06001351 RID: 4945 RVA: 0x00017B28 File Offset: 0x00015D28
		[global::Cpp2ILInjected.Token(Token = "0x600150B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD10C4", Offset = "0x1AD10C4", Length = "0x110")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public unsafe override int GetBytes(char* chars, int charCount, byte* bytes, int byteCount, bool flush)
		{
			throw null;
		}

		// Token: 0x06001352 RID: 4946 RVA: 0x00017B2B File Offset: 0x00015D2B
		[global::Cpp2ILInjected.Token(Token = "0x600150C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD11D4", Offset = "0x1AD11D4", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<char>), Member = "op_Implicit", MemberParameters = new object[] { typeof(char[]) }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal[]), Member = "GetReference", MemberTypeParameters = new object[] { typeof(char) }, MemberParameters = new object[] { typeof(global::System.Span<char>) }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "T[]" }, ReturnType = "System.Span`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public override void Convert(char[] chars, int charIndex, int charCount, byte[] bytes, int byteIndex, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			throw null;
		}

		// Token: 0x06001353 RID: 4947 RVA: 0x00017B2E File Offset: 0x00015D2E
		[global::Cpp2ILInjected.Token(Token = "0x600150D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1488", Offset = "0x1AD1488", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public unsafe override void Convert(char* chars, int charCount, byte* bytes, int byteCount, bool flush, out int charsUsed, out int bytesUsed, out bool completed)
		{
			throw null;
		}

		// Token: 0x170001D9 RID: 473
		// (get) Token: 0x06001354 RID: 4948 RVA: 0x00017B31 File Offset: 0x00015D31
		[global::Cpp2ILInjected.Token(Token = "0x1700021C")]
		public Encoding Encoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x600150E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD1624", Offset = "0x1AD1624", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06001355 RID: 4949 RVA: 0x00017B34 File Offset: 0x00015D34
		[global::Cpp2ILInjected.Token(Token = "0x1700021D")]
		public bool MustFlush
		{
			[global::Cpp2ILInjected.Token(Token = "0x600150F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD162C", Offset = "0x1AD162C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06001356 RID: 4950 RVA: 0x00017B37 File Offset: 0x00015D37
		[global::Cpp2ILInjected.Token(Token = "0x1700021E")]
		internal virtual bool HasState
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001510")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AD1634", Offset = "0x1AD1634", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06001357 RID: 4951 RVA: 0x00017B3A File Offset: 0x00015D3A
		[global::Cpp2ILInjected.Token(Token = "0x6001511")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AD1644", Offset = "0x1AD1644", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Encoding), Member = "ThrowBytesOverflow", MemberParameters = new object[]
		{
			typeof(EncoderNLS),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void ClearMustFlush()
		{
			throw null;
		}

		// Token: 0x040008A6 RID: 2214
		[global::Cpp2ILInjected.Token(Token = "0x4000B12")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal char _charLeftOver;

		// Token: 0x040008A7 RID: 2215
		[global::Cpp2ILInjected.Token(Token = "0x4000B13")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Encoding _encoding;

		// Token: 0x040008A8 RID: 2216
		[global::Cpp2ILInjected.Token(Token = "0x4000B14")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool _mustFlush;

		// Token: 0x040008A9 RID: 2217
		[global::Cpp2ILInjected.Token(Token = "0x4000B15")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x31")]
		internal bool _throwOnOverflow;

		// Token: 0x040008AA RID: 2218
		[global::Cpp2ILInjected.Token(Token = "0x4000B16")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		internal int _charsUsed;
	}
}
