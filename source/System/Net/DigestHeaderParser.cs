using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	[global::Cpp2ILInjected.Token(Token = "0x2000238")]
	internal class DigestHeaderParser
	{
		[global::Cpp2ILInjected.Token(Token = "0x6000E2A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40348", Offset = "0x1F40348", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public DigestHeaderParser(string header)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F3")]
		public string Realm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E2B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F403F0", Offset = "0x1F403F0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F4")]
		public string Opaque
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E2C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F403FC", Offset = "0x1F403FC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F5")]
		public string Nonce
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E2D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40408", Offset = "0x1F40408", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F6")]
		public string Algorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E2E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40414", Offset = "0x1F40414", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170002F7")]
		public string QOP
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000E2F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F40420", Offset = "0x1F40420", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4042C", Offset = "0x1F4042C", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestSession), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestHeaderParser), Member = "GetKeywordAndValue", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestHeaderParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array[]), Member = "IndexOf", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(object[]),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool Parse()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F4073C", Offset = "0x1F4073C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestHeaderParser), Member = "Parse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestHeaderParser), Member = "GetKey", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestHeaderParser), Member = "GetKeywordAndValue", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		private void SkipWhitespace()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F407B4", Offset = "0x1F407B4", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestHeaderParser), Member = "GetKeywordAndValue", MemberParameters = new object[]
		{
			typeof(ref string),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestHeaderParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Trim", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToLower", ReturnType = typeof(string))]
		private string GetKey()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000E33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F405C4", Offset = "0x1F405C4", Length = "0x178")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DigestHeaderParser), Member = "Parse", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestHeaderParser), Member = "GetKey", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DigestHeaderParser), Member = "SkipWhitespace", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		private bool GetKeywordAndValue(out string key, out string value)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000E34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40834", Offset = "0x1F40834", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static DigestHeaderParser()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x4000BCC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string header;

		[global::Cpp2ILInjected.Token(Token = "0x4000BCD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int length;

		[global::Cpp2ILInjected.Token(Token = "0x4000BCE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int pos;

		[global::Cpp2ILInjected.Token(Token = "0x4000BCF")]
		private static string[] keywords;

		[global::Cpp2ILInjected.Token(Token = "0x4000BD0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string[] values;
	}
}
