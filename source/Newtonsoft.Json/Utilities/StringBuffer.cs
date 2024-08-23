using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Newtonsoft.Json.Shims;

namespace Newtonsoft.Json.Utilities
{
	// Token: 0x02000056 RID: 86
	[Preserve]
	[global::Cpp2ILInjected.Token(Token = "0x200006B")]
	internal struct StringBuffer
	{
		// Token: 0x170000B0 RID: 176
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00002B16 File Offset: 0x00000D16
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00002B19 File Offset: 0x00000D19
		[global::Cpp2ILInjected.Token(Token = "0x170000B6")]
		public int Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD9AD8", Offset = "0x1CD9AD8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60003BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD9AE0", Offset = "0x1CD9AE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x170000B1 RID: 177
		// (get) Token: 0x0600038C RID: 908 RVA: 0x00002B1C File Offset: 0x00000D1C
		[global::Cpp2ILInjected.Token(Token = "0x170000B7")]
		public bool IsEmpty
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD9AE8", Offset = "0x1CD9AE8", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "EnsureBufferNotEmpty", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00002B1F File Offset: 0x00000D1F
		[global::Cpp2ILInjected.Token(Token = "0x60003C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9AF8", Offset = "0x1CD9AF8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "EnsureBufferNotEmpty", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(char[]))]
		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
			throw null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00002B22 File Offset: 0x00000D22
		[global::Cpp2ILInjected.Token(Token = "0x60003C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9B1C", Offset = "0x1CD9B1C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private StringBuffer(char[] buffer)
		{
			throw null;
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00002B25 File Offset: 0x00000D25
		[global::Cpp2ILInjected.Token(Token = "0x60003C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9B28", Offset = "0x1CD9B28", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "WriteCharToBuffer", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuffer), Member = "EnsureSize", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Append(IArrayPool<char> bufferPool, char value)
		{
			throw null;
		}

		// Token: 0x06000390 RID: 912 RVA: 0x00002B28 File Offset: 0x00000D28
		[global::Cpp2ILInjected.Token(Token = "0x60003C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9BDC", Offset = "0x1CD9BDC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "ReadStringIntoBuffer", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "WriteCharToBuffer", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuffer), Member = "EnsureSize", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
			throw null;
		}

		// Token: 0x06000391 RID: 913 RVA: 0x00002B2B File Offset: 0x00000D2B
		[global::Cpp2ILInjected.Token(Token = "0x60003C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9C54", Offset = "0x1CD9C54", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(JsonTextReader), Member = "Close", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(char[])
		}, ReturnType = typeof(void))]
		public void Clear(IArrayPool<char> bufferPool)
		{
			throw null;
		}

		// Token: 0x06000392 RID: 914 RVA: 0x00002B2E File Offset: 0x00000D2E
		[global::Cpp2ILInjected.Token(Token = "0x60003C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9B7C", Offset = "0x1CD9B7C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(char)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(StringBuffer), Member = "Append", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "RentBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(int)
		}, ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BufferUtils), Member = "ReturnBuffer", MemberParameters = new object[]
		{
			typeof(IArrayPool<char>),
			typeof(char[])
		}, ReturnType = typeof(void))]
		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
			throw null;
		}

		// Token: 0x06000393 RID: 915 RVA: 0x00002B31 File Offset: 0x00000D31
		[global::Cpp2ILInjected.Token(Token = "0x60003C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9C80", Offset = "0x1CD9C80", Length = "0x18")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00002B34 File Offset: 0x00000D34
		[global::Cpp2ILInjected.Token(Token = "0x60003C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1CD9C98", Offset = "0x1CD9C98", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		public string ToString(int start, int length)
		{
			throw null;
		}

		// Token: 0x170000B2 RID: 178
		// (get) Token: 0x06000395 RID: 917 RVA: 0x00002B37 File Offset: 0x00000D37
		[global::Cpp2ILInjected.Token(Token = "0x170000B8")]
		public char[] InternalBuffer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60003C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1CD9CB4", Offset = "0x1CD9CB4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x040001BD RID: 445
		[global::Cpp2ILInjected.Token(Token = "0x40001F8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private char[] _buffer;

		// Token: 0x040001BE RID: 446
		[global::Cpp2ILInjected.Token(Token = "0x40001F9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private int _position;
	}
}
