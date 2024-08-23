using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Util
{
	// Token: 0x0200020C RID: 524
	[global::Cpp2ILInjected.Token(Token = "0x200029F")]
	internal sealed class Tokenizer
	{
		// Token: 0x06001526 RID: 5414 RVA: 0x00018071 File Offset: 0x00016271
		[global::Cpp2ILInjected.Token(Token = "0x6001728")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0360", Offset = "0x1AF0360", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tokenizer), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(Tokenizer.StringMaker))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void BasicInitialization()
		{
			throw null;
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x00018074 File Offset: 0x00016274
		[global::Cpp2ILInjected.Token(Token = "0x6001729")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF03D8", Offset = "0x1AF03D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = ".ctor", MemberParameters = new object[] { typeof(Tokenizer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SharedStatics), Member = "ReleaseSharedStringMaker", MemberParameters = new object[] { typeof(ref Tokenizer.StringMaker) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Recycle()
		{
			throw null;
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00018077 File Offset: 0x00016277
		[global::Cpp2ILInjected.Token(Token = "0x600172A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0320", Offset = "0x1AF0320", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer), Member = "BasicInitialization", ReturnType = typeof(void))]
		internal Tokenizer(string input)
		{
			throw null;
		}

		// Token: 0x06001529 RID: 5417 RVA: 0x0001807A File Offset: 0x0001627A
		[global::Cpp2ILInjected.Token(Token = "0x600172B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEFAB4", Offset = "0x1AEFAB4", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new object[] { typeof(TokenizerStream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_Unicode", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_UTF8", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.Encoding), Member = "get_ASCII", ReturnType = typeof(global::System.Text.Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.MemoryStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IO.StreamReader), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void ChangeFormat(global::System.Text.Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600152A RID: 5418 RVA: 0x0001807D File Offset: 0x0001627D
		[global::Cpp2ILInjected.Token(Token = "0x600172C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AEF33C", Offset = "0x1AEF33C", Length = "0x6E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "DetermineFormat", MemberParameters = new object[] { typeof(TokenizerStream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Parser), Member = "ParseContents", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(global::System.Text.StringBuilder))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(global::System.StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerStream), Member = "AddToken", MemberParameters = new object[] { typeof(short) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer.StringMaker), Member = "MakeString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TokenizerStream), Member = "AddString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Environment), Member = "GetResourceString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void GetTokens(TokenizerStream stream, int maxNum, bool endAfterKet)
		{
			throw null;
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00018080 File Offset: 0x00016280
		[global::Cpp2ILInjected.Token(Token = "0x600172D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF050C", Offset = "0x1AF050C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer.StringMaker), Member = "MakeString", ReturnType = typeof(string))]
		private string GetStringToken()
		{
			throw null;
		}

		// Token: 0x0400091F RID: 2335
		[global::Cpp2ILInjected.Token(Token = "0x4000BB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int LineNo;

		// Token: 0x04000920 RID: 2336
		[global::Cpp2ILInjected.Token(Token = "0x4000BB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _inProcessingTag;

		// Token: 0x04000921 RID: 2337
		[global::Cpp2ILInjected.Token(Token = "0x4000BB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] _inBytes;

		// Token: 0x04000922 RID: 2338
		[global::Cpp2ILInjected.Token(Token = "0x4000BB7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private char[] _inChars;

		// Token: 0x04000923 RID: 2339
		[global::Cpp2ILInjected.Token(Token = "0x4000BB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _inString;

		// Token: 0x04000924 RID: 2340
		[global::Cpp2ILInjected.Token(Token = "0x4000BB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _inIndex;

		// Token: 0x04000925 RID: 2341
		[global::Cpp2ILInjected.Token(Token = "0x4000BBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int _inSize;

		// Token: 0x04000926 RID: 2342
		[global::Cpp2ILInjected.Token(Token = "0x4000BBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _inSavedCharacter;

		// Token: 0x04000927 RID: 2343
		[global::Cpp2ILInjected.Token(Token = "0x4000BBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private Tokenizer.TokenSource _inTokenSource;

		// Token: 0x04000928 RID: 2344
		[global::Cpp2ILInjected.Token(Token = "0x4000BBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Tokenizer.ITokenReader _inTokenReader;

		// Token: 0x04000929 RID: 2345
		[global::Cpp2ILInjected.Token(Token = "0x4000BBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Tokenizer.StringMaker _maker;

		// Token: 0x0400092A RID: 2346
		[global::Cpp2ILInjected.Token(Token = "0x4000BBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string[] _searchStrings;

		// Token: 0x0400092B RID: 2347
		[global::Cpp2ILInjected.Token(Token = "0x4000BC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string[] _replaceStrings;

		// Token: 0x0400092C RID: 2348
		[global::Cpp2ILInjected.Token(Token = "0x4000BC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int _inNestedIndex;

		// Token: 0x0400092D RID: 2349
		[global::Cpp2ILInjected.Token(Token = "0x4000BC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int _inNestedSize;

		// Token: 0x0400092E RID: 2350
		[global::Cpp2ILInjected.Token(Token = "0x4000BC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string _inNestedString;

		// Token: 0x020005DE RID: 1502
		[global::Cpp2ILInjected.Token(Token = "0x20002A0")]
		private enum TokenSource
		{
			// Token: 0x0400191E RID: 6430
			[global::Cpp2ILInjected.Token(Token = "0x4000BC5")]
			UnicodeByteArray,
			// Token: 0x0400191F RID: 6431
			[global::Cpp2ILInjected.Token(Token = "0x4000BC6")]
			UTF8ByteArray,
			// Token: 0x04001920 RID: 6432
			[global::Cpp2ILInjected.Token(Token = "0x4000BC7")]
			ASCIIByteArray,
			// Token: 0x04001921 RID: 6433
			[global::Cpp2ILInjected.Token(Token = "0x4000BC8")]
			CharArray,
			// Token: 0x04001922 RID: 6434
			[global::Cpp2ILInjected.Token(Token = "0x4000BC9")]
			String,
			// Token: 0x04001923 RID: 6435
			[global::Cpp2ILInjected.Token(Token = "0x4000BCA")]
			NestedStrings,
			// Token: 0x04001924 RID: 6436
			[global::Cpp2ILInjected.Token(Token = "0x4000BCB")]
			Other
		}

		// Token: 0x020005DF RID: 1503
		[global::Cpp2ILInjected.Token(Token = "0x20002A1")]
		[global::System.Serializable]
		internal sealed class StringMaker
		{
			// Token: 0x060040D9 RID: 16601 RVA: 0x0001FD3C File Offset: 0x0001DF3C
			[global::Cpp2ILInjected.Token(Token = "0x600172E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF05D8", Offset = "0x1AF05D8", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tokenizer.StringMaker), Member = "MakeString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private static uint HashString(string str)
			{
				throw null;
			}

			// Token: 0x060040DA RID: 16602 RVA: 0x0001FD3F File Offset: 0x0001DF3F
			[global::Cpp2ILInjected.Token(Token = "0x600172F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF063C", Offset = "0x1AF063C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private static uint HashCharArray(char[] a, int l)
			{
				throw null;
			}

			// Token: 0x060040DB RID: 16603 RVA: 0x0001FD42 File Offset: 0x0001DF42
			[global::Cpp2ILInjected.Token(Token = "0x6001730")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0670", Offset = "0x1AF0670", Length = "0x94")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.SharedStatics), Member = "GetSharedStringMaker", ReturnType = typeof(Tokenizer.StringMaker))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public StringMaker()
			{
				throw null;
			}

			// Token: 0x060040DC RID: 16604 RVA: 0x0001FD45 File Offset: 0x0001DF45
			[global::Cpp2ILInjected.Token(Token = "0x6001731")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0704", Offset = "0x1AF0704", Length = "0x78")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tokenizer.StringMaker), Member = "MakeString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			private bool CompareStringAndChars(string str, char[] a, int l)
			{
				throw null;
			}

			// Token: 0x060040DD RID: 16605 RVA: 0x0001FD48 File Offset: 0x0001DF48
			[global::Cpp2ILInjected.Token(Token = "0x6001732")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AEA294", Offset = "0x1AEA294", Length = "0x228")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SecurityDocument), Member = "GetString", MemberParameters = new object[]
			{
				typeof(ref int),
				typeof(bool)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tokenizer), Member = "GetTokens", MemberParameters = new object[]
			{
				typeof(TokenizerStream),
				typeof(int),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Tokenizer), Member = "GetStringToken", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Text.StringBuilder), Member = "Append", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(global::System.Text.StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer.StringMaker), Member = "HashString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer.StringMaker), Member = "CompareStringAndChars", MemberParameters = new object[]
			{
				typeof(string),
				typeof(char[]),
				typeof(int)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
			{
				typeof(char[]),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			public string MakeString()
			{
				throw null;
			}

			// Token: 0x04001925 RID: 6437
			[global::Cpp2ILInjected.Token(Token = "0x4000BCC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string[] aStrings;

			// Token: 0x04001926 RID: 6438
			[global::Cpp2ILInjected.Token(Token = "0x4000BCD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private uint cStringsMax;

			// Token: 0x04001927 RID: 6439
			[global::Cpp2ILInjected.Token(Token = "0x4000BCE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private uint cStringsUsed;

			// Token: 0x04001928 RID: 6440
			[global::Cpp2ILInjected.Token(Token = "0x4000BCF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::System.Text.StringBuilder _outStringBuilder;

			// Token: 0x04001929 RID: 6441
			[global::Cpp2ILInjected.Token(Token = "0x4000BD0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public char[] _outChars;

			// Token: 0x0400192A RID: 6442
			[global::Cpp2ILInjected.Token(Token = "0x4000BD1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int _outIndex;
		}

		// Token: 0x020005E0 RID: 1504
		[global::Cpp2ILInjected.Token(Token = "0x20002A2")]
		internal interface ITokenReader
		{
			// Token: 0x060040DE RID: 16606
			[global::Cpp2ILInjected.Token(Token = "0x6001733")]
			int Read();
		}

		// Token: 0x020005E1 RID: 1505
		[global::Cpp2ILInjected.Token(Token = "0x20002A3")]
		internal class StreamTokenReader : Tokenizer.ITokenReader
		{
			// Token: 0x060040DF RID: 16607 RVA: 0x0001FD4B File Offset: 0x0001DF4B
			[global::Cpp2ILInjected.Token(Token = "0x6001734")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0434", Offset = "0x1AF0434", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal StreamTokenReader(global::System.IO.StreamReader input)
			{
				throw null;
			}

			// Token: 0x060040E0 RID: 16608 RVA: 0x0001FD4E File Offset: 0x0001DF4E
			[global::Cpp2ILInjected.Token(Token = "0x6001735")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF077C", Offset = "0x1AF077C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual int Read()
			{
				throw null;
			}

			// Token: 0x1700074F RID: 1871
			// (get) Token: 0x060040E1 RID: 16609 RVA: 0x0001FD51 File Offset: 0x0001DF51
			[global::Cpp2ILInjected.Token(Token = "0x17000259")]
			internal int NumCharEncountered
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001736")]
				[global::Cpp2ILInjected.Address(RVA = "0x1AF07B0", Offset = "0x1AF07B0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x0400192B RID: 6443
			[global::Cpp2ILInjected.Token(Token = "0x4000BD2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal global::System.IO.StreamReader _in;

			// Token: 0x0400192C RID: 6444
			[global::Cpp2ILInjected.Token(Token = "0x4000BD3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int _numCharRead;
		}
	}
}
