using System;
using System.Globalization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000106 RID: 262
	[global::Cpp2ILInjected.Token(Token = "0x200018B")]
	internal class CredentialHostKey
	{
		// Token: 0x0600091F RID: 2335 RVA: 0x00004820 File Offset: 0x00002A20
		[global::Cpp2ILInjected.Token(Token = "0x6000A2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B204", Offset = "0x1F0B204", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialCache), Member = "Add", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string),
			typeof(NetworkCredential)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialCache), Member = "Remove", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal CredentialHostKey(string host, int port, string authenticationType)
		{
			throw null;
		}

		// Token: 0x06000920 RID: 2336 RVA: 0x00004823 File Offset: 0x00002A23
		[global::Cpp2ILInjected.Token(Token = "0x6000A2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B240", Offset = "0x1F0B240", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CredentialCache), Member = "GetCredential", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(NetworkCredential))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		internal bool Match(string host, int port, string authenticationType)
		{
			throw null;
		}

		// Token: 0x06000921 RID: 2337 RVA: 0x00004826 File Offset: 0x00002A26
		[global::Cpp2ILInjected.Token(Token = "0x6000A30")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B2AC", Offset = "0x1F0B2AC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToUpperInvariant", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00004829 File Offset: 0x00002A29
		[global::Cpp2ILInjected.Token(Token = "0x6000A31")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B330", Offset = "0x1F0B330", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override bool Equals(object comparand)
		{
			throw null;
		}

		// Token: 0x06000923 RID: 2339 RVA: 0x0000482C File Offset: 0x00002A2C
		[global::Cpp2ILInjected.Token(Token = "0x6000A32")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F0B3F4", Offset = "0x1F0B3F4", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NumberFormatInfo), Member = "get_InvariantInfo", ReturnType = typeof(NumberFormatInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "ToString", MemberParameters = new object[] { typeof(IFormatProvider) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ValidationHelper), Member = "ToString", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x040005AD RID: 1453
		[global::Cpp2ILInjected.Token(Token = "0x40007BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal string Host;

		// Token: 0x040005AE RID: 1454
		[global::Cpp2ILInjected.Token(Token = "0x40007C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal string AuthenticationType;

		// Token: 0x040005AF RID: 1455
		[global::Cpp2ILInjected.Token(Token = "0x40007C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal int Port;

		// Token: 0x040005B0 RID: 1456
		[global::Cpp2ILInjected.Token(Token = "0x40007C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x24")]
		private int m_HashCode;

		// Token: 0x040005B1 RID: 1457
		[global::Cpp2ILInjected.Token(Token = "0x40007C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_ComputedHashCode;
	}
}
