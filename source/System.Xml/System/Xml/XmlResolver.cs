using System;
using System.IO;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000086 RID: 134
	[global::Cpp2ILInjected.Token(Token = "0x20000AF")]
	public abstract class XmlResolver
	{
		// Token: 0x06000729 RID: 1833
		[global::Cpp2ILInjected.Token(Token = "0x60007B5")]
		public abstract object GetEntity(Uri absoluteUri, string role, Type ofObjectToReturn);

		// Token: 0x0600072A RID: 1834 RVA: 0x0000441E File Offset: 0x0000261E
		[global::Cpp2ILInjected.Token(Token = "0x60007B6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB0EF4", Offset = "0x1DB0EF4", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlUrlResolver), Member = "ResolveUri", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(Uri))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(UriKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_IsAbsoluteUri", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "get_OriginalString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public virtual Uri ResolveUri(Uri baseUri, string relativeUri)
		{
			throw null;
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x00004421 File Offset: 0x00002621
		[global::Cpp2ILInjected.Token(Token = "0x60007B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB10AC", Offset = "0x1DB10AC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Uri), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(Uri)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public virtual bool SupportsType(Uri absoluteUri, Type type)
		{
			throw null;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x00004424 File Offset: 0x00002624
		[global::Cpp2ILInjected.Token(Token = "0x60007B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB11F0", Offset = "0x1DB11F0", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotImplementedException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public virtual Task<object> GetEntityAsync(Uri absoluteUri, string role, Type ofObjectToReturn)
		{
			throw null;
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x00004427 File Offset: 0x00002627
		[global::Cpp2ILInjected.Token(Token = "0x60007B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB1228", Offset = "0x1DB1228", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected XmlResolver()
		{
			throw null;
		}
	}
}
