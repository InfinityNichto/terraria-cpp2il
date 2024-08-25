using System;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Security.Util
{
	[global::Cpp2ILInjected.Token(Token = "0x200029F")]
	internal sealed class Tokenizer
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x600172A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF0320", Offset = "0x1AF0320", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer), Member = "BasicInitialization", ReturnType = typeof(void))]
		internal Tokenizer(string input)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600172D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1AF050C", Offset = "0x1AF050C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Tokenizer.StringMaker), Member = "MakeString", ReturnType = typeof(string))]
		private string GetStringToken()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BB4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public int LineNo;

		[global::Cpp2ILInjected.Token(Token = "0x4000BB5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _inProcessingTag;

		[global::Cpp2ILInjected.Token(Token = "0x4000BB6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private byte[] _inBytes;

		[global::Cpp2ILInjected.Token(Token = "0x4000BB7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private char[] _inChars;

		[global::Cpp2ILInjected.Token(Token = "0x4000BB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string _inString;

		[global::Cpp2ILInjected.Token(Token = "0x4000BB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _inIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int _inSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _inSavedCharacter;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private Tokenizer.TokenSource _inTokenSource;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Tokenizer.ITokenReader _inTokenReader;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Tokenizer.StringMaker _maker;

		[global::Cpp2ILInjected.Token(Token = "0x4000BBF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private string[] _searchStrings;

		[global::Cpp2ILInjected.Token(Token = "0x4000BC0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string[] _replaceStrings;

		[global::Cpp2ILInjected.Token(Token = "0x4000BC1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private int _inNestedIndex;

		[global::Cpp2ILInjected.Token(Token = "0x4000BC2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x64")]
		private int _inNestedSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000BC3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string _inNestedString;

		[global::Cpp2ILInjected.Token(Token = "0x20002A0")]
		private enum TokenSource
		{
			[global::Cpp2ILInjected.Token(Token = "0x4000BC5")]
			UnicodeByteArray,
			[global::Cpp2ILInjected.Token(Token = "0x4000BC6")]
			UTF8ByteArray,
			[global::Cpp2ILInjected.Token(Token = "0x4000BC7")]
			ASCIIByteArray,
			[global::Cpp2ILInjected.Token(Token = "0x4000BC8")]
			CharArray,
			[global::Cpp2ILInjected.Token(Token = "0x4000BC9")]
			String,
			[global::Cpp2ILInjected.Token(Token = "0x4000BCA")]
			NestedStrings,
			[global::Cpp2ILInjected.Token(Token = "0x4000BCB")]
			Other
		}

		[global::Cpp2ILInjected.Token(Token = "0x20002A1")]
		[global::System.Serializable]
		internal sealed class StringMaker
		{
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

			[global::Cpp2ILInjected.Token(Token = "0x600172F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF063C", Offset = "0x1AF063C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private static uint HashCharArray(char[] a, int l)
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000BCC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string[] aStrings;

			[global::Cpp2ILInjected.Token(Token = "0x4000BCD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private uint cStringsMax;

			[global::Cpp2ILInjected.Token(Token = "0x4000BCE")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
			private uint cStringsUsed;

			[global::Cpp2ILInjected.Token(Token = "0x4000BCF")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public global::System.Text.StringBuilder _outStringBuilder;

			[global::Cpp2ILInjected.Token(Token = "0x4000BD0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public char[] _outChars;

			[global::Cpp2ILInjected.Token(Token = "0x4000BD1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public int _outIndex;
		}

		[global::Cpp2ILInjected.Token(Token = "0x20002A2")]
		internal interface ITokenReader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001733")]
			int Read();
		}

		[global::Cpp2ILInjected.Token(Token = "0x20002A3")]
		internal class StreamTokenReader : Tokenizer.ITokenReader
		{
			[global::Cpp2ILInjected.Token(Token = "0x6001734")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF0434", Offset = "0x1AF0434", Length = "0x2C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			internal StreamTokenReader(global::System.IO.StreamReader input)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001735")]
			[global::Cpp2ILInjected.Address(RVA = "0x1AF077C", Offset = "0x1AF077C", Length = "0x34")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public virtual int Read()
			{
				throw null;
			}

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

			[global::Cpp2ILInjected.Token(Token = "0x4000BD2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			internal global::System.IO.StreamReader _in;

			[global::Cpp2ILInjected.Token(Token = "0x4000BD3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			internal int _numCharRead;
		}
	}
}
