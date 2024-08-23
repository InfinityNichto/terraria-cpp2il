using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000107 RID: 263
	[global::Cpp2ILInjected.Token(Token = "0x200018C")]
	internal class CredentialKey
	{
		// Token: 0x06000924 RID: 2340 RVA: 0x0000482F File Offset: 0x00002A2F
		[global::Cpp2ILInjected.Token(Token = "0x6000A33")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B7DC", Offset = "0x1F0B7DC", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialCache), Member = "Add", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string),
			typeof(NetworkCredential)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialCache), Member = "Remove", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CredentialKey(Uri uriPrefix, string authenticationType)
		{
			throw null;
		}

		// Token: 0x06000925 RID: 2341 RVA: 0x00004832 File Offset: 0x00002A32
		[global::Cpp2ILInjected.Token(Token = "0x6000A34")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B82C", Offset = "0x1F0B82C", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialCache), Member = "GetCredential", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(NetworkCredential))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal bool Match(Uri uri, string authenticationType)
		{
			throw null;
		}

		// Token: 0x06000926 RID: 2342 RVA: 0x00004835 File Offset: 0x00002A35
		[global::Cpp2ILInjected.Token(Token = "0x6000A35")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B8D8", Offset = "0x1F0B8D8", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Scheme", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Port", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_AbsolutePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(int),
			typeof(int),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		internal bool IsPrefix(Uri uri, Uri prefixUri)
		{
			throw null;
		}

		// Token: 0x06000927 RID: 2343 RVA: 0x00004838 File Offset: 0x00002A38
		[global::Cpp2ILInjected.Token(Token = "0x6000A36")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0BA00", Offset = "0x1F0BA00", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000928 RID: 2344 RVA: 0x0000483B File Offset: 0x00002A3B
		[global::Cpp2ILInjected.Token(Token = "0x6000A37")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0BA70", Offset = "0x1F0BA70", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		// Token: 0x06000929 RID: 2345 RVA: 0x0000483E File Offset: 0x00002A3E
		[global::Cpp2ILInjected.Token(Token = "0x6000A38")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0BB24", Offset = "0x1F0BB24", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040005B2 RID: 1458
		[global::Cpp2ILInjected.Token(Token = "0x40007C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal Uri UriPrefix;

		// Token: 0x040005B3 RID: 1459
		[global::Cpp2ILInjected.Token(Token = "0x40007C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal int UriPrefixLength;

		// Token: 0x040005B4 RID: 1460
		[global::Cpp2ILInjected.Token(Token = "0x40007C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal string AuthenticationType;

		// Token: 0x040005B5 RID: 1461
		[global::Cpp2ILInjected.Token(Token = "0x40007C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private int m_HashCode;

		// Token: 0x040005B6 RID: 1462
		[global::Cpp2ILInjected.Token(Token = "0x40007C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		private bool m_ComputedHashCode;
	}
}
