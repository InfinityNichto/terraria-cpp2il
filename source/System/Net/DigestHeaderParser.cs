using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x0200018C RID: 396
	[global::Cpp2ILInjected.Token(Token = "0x2000238")]
	internal class DigestHeaderParser
	{
		// Token: 0x06000CC0 RID: 3264 RVA: 0x00005288 File Offset: 0x00003488
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

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x06000CC1 RID: 3265 RVA: 0x0000528B File Offset: 0x0000348B
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

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x06000CC2 RID: 3266 RVA: 0x0000528E File Offset: 0x0000348E
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

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06000CC3 RID: 3267 RVA: 0x00005291 File Offset: 0x00003491
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

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x06000CC4 RID: 3268 RVA: 0x00005294 File Offset: 0x00003494
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

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x06000CC5 RID: 3269 RVA: 0x00005297 File Offset: 0x00003497
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

		// Token: 0x06000CC6 RID: 3270 RVA: 0x0000529A File Offset: 0x0000349A
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

		// Token: 0x06000CC7 RID: 3271 RVA: 0x0000529D File Offset: 0x0000349D
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

		// Token: 0x06000CC8 RID: 3272 RVA: 0x000052A0 File Offset: 0x000034A0
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

		// Token: 0x06000CC9 RID: 3273 RVA: 0x000052A3 File Offset: 0x000034A3
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

		// Token: 0x06000CCA RID: 3274 RVA: 0x000052A6 File Offset: 0x000034A6
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000E34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F40834", Offset = "0x1F40834", Length = "0x180")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		static DigestHeaderParser()
		{
			throw null;
		}

		// Token: 0x04000924 RID: 2340
		[global::Cpp2ILInjected.Token(Token = "0x4000BCC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private string header;

		// Token: 0x04000925 RID: 2341
		[global::Cpp2ILInjected.Token(Token = "0x4000BCD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int length;

		// Token: 0x04000926 RID: 2342
		[global::Cpp2ILInjected.Token(Token = "0x4000BCE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private int pos;

		// Token: 0x04000927 RID: 2343
		[global::Cpp2ILInjected.Token(Token = "0x4000BCF")]
		private static string[] keywords;

		// Token: 0x04000928 RID: 2344
		[global::Cpp2ILInjected.Token(Token = "0x4000BD0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string[] values;
	}
}
