using System;
using System.Collections;
using System.Collections.Generic;
using System.Security.Authentication.ExtendedProtection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Net
{
	// Token: 0x02000168 RID: 360
	[global::Cpp2ILInjected.Token(Token = "0x20001FE")]
	internal class ServiceNameStore
	{
		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06000B4B RID: 2891 RVA: 0x00004E44 File Offset: 0x00003044
		[global::Cpp2ILInjected.Token(Token = "0x1700028D")]
		public ServiceNameCollection ServiceNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000C7E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F28508", Offset = "0x1F28508", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = "get_DefaultServiceNames", ReturnType = typeof(ServiceNameCollection))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameCollection), Member = ".ctor", MemberParameters = new object[] { typeof(ICollection) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000B4C RID: 2892 RVA: 0x00004E47 File Offset: 0x00003047
		[global::Cpp2ILInjected.Token(Token = "0x6000C7F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28574", Offset = "0x1F28574", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(HttpListener), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ServiceNameStore()
		{
			throw null;
		}

		// Token: 0x06000B4D RID: 2893 RVA: 0x00004E4A File Offset: 0x0000304A
		[global::Cpp2ILInjected.Token(Token = "0x6000C80")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F285F4", Offset = "0x1F285F4", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameCollection), Member = "NormalizeServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameCollection), Member = "Contains", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ICollection)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private bool AddSingleServiceName(string spn)
		{
			throw null;
		}

		// Token: 0x06000B4E RID: 2894 RVA: 0x00004E4D File Offset: 0x0000304D
		[global::Cpp2ILInjected.Token(Token = "0x6000C81")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F286E0", Offset = "0x1F286E0", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameStore), Member = "BuildServiceNames", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameStore), Member = "AddSingleServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		public bool Add(string uriPrefix)
		{
			throw null;
		}

		// Token: 0x06000B4F RID: 2895 RVA: 0x00004E50 File Offset: 0x00003050
		[global::Cpp2ILInjected.Token(Token = "0x6000C82")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28B9C", Offset = "0x1F28B9C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameStore), Member = "BuildSimpleServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameCollection), Member = "NormalizeServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameCollection), Member = "Contains", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ICollection)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logging), Member = "get_On", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Remove(string uriPrefix)
		{
			throw null;
		}

		// Token: 0x06000B50 RID: 2896 RVA: 0x00004E53 File Offset: 0x00003053
		[global::Cpp2ILInjected.Token(Token = "0x6000C83")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F286C0", Offset = "0x1F286C0", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameCollection), Member = "Contains", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ICollection)
		}, ReturnType = typeof(bool))]
		private bool Contains(string newServiceName)
		{
			throw null;
		}

		// Token: 0x06000B51 RID: 2897 RVA: 0x00004E56 File Offset: 0x00003056
		[global::Cpp2ILInjected.Token(Token = "0x6000C84")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28CA0", Offset = "0x1F28CA0", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06000B52 RID: 2898 RVA: 0x00004E59 File Offset: 0x00003059
		[global::Cpp2ILInjected.Token(Token = "0x6000C85")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28D04", Offset = "0x1F28D04", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "BuildSimpleServiceName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "BuildServiceNames", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "IsWellFormedUriString", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_Host", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private string ExtractHostname(string uriPrefix, bool allowInvalidUriStrings)
		{
			throw null;
		}

		// Token: 0x06000B53 RID: 2899 RVA: 0x00004E5C File Offset: 0x0000305C
		[global::Cpp2ILInjected.Token(Token = "0x6000C86")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28C38", Offset = "0x1F28C38", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "Remove", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameStore), Member = "ExtractHostname", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public string BuildSimpleServiceName(string uriPrefix)
		{
			throw null;
		}

		// Token: 0x06000B54 RID: 2900 RVA: 0x00004E5F File Offset: 0x0000305F
		[global::Cpp2ILInjected.Token(Token = "0x6000C87")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F28768", Offset = "0x1F28768", Length = "0x434")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ServiceNameStore), Member = "Add", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ServiceNameStore), Member = "ExtractHostname", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(StringComparison)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IPAddress), Member = "TryParse", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ref IPAddress)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dns), Member = "GetHostEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(IPHostEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Contains", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 51)]
		public string[] BuildServiceNames(string uriPrefix)
		{
			throw null;
		}

		// Token: 0x0400086C RID: 2156
		[global::Cpp2ILInjected.Token(Token = "0x4000AB8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<string> serviceNames;

		// Token: 0x0400086D RID: 2157
		[global::Cpp2ILInjected.Token(Token = "0x4000AB9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private ServiceNameCollection serviceNameCollection;
	}
}
