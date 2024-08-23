using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.Serialization;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Resources
{
	// Token: 0x020003EC RID: 1004
	[global::Cpp2ILInjected.Token(Token = "0x20004A6")]
	[global::System.Serializable]
	public class MissingManifestResourceException : global::System.SystemException
	{
		// Token: 0x0600204A RID: 8266 RVA: 0x00019F6D File Offset: 0x0001816D
		[global::Cpp2ILInjected.Token(Token = "0x60022C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75B40", Offset = "0x1B75B40", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public MissingManifestResourceException()
		{
			throw null;
		}

		// Token: 0x0600204B RID: 8267 RVA: 0x00019F70 File Offset: 0x00018170
		[global::Cpp2ILInjected.Token(Token = "0x60022C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75B9C", Offset = "0x1B75B9C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FileBasedResourceGroveler), Member = "GrovelForResourceSet", MemberParameters = new object[]
		{
			typeof(global::System.Globalization.CultureInfo),
			typeof(global::System.Collections.Generic.Dictionary<string, ResourceSet>),
			typeof(bool),
			typeof(bool),
			typeof(ref global::System.Threading.StackCrawlMark)
		}, ReturnType = typeof(ResourceSet))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "CaseInsensitiveManifestResourceStreamLookup", MemberParameters = new object[]
		{
			typeof(global::System.Reflection.RuntimeAssembly),
			typeof(string)
		}, ReturnType = typeof(global::System.IO.Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ManifestBasedResourceGroveler), Member = "HandleResourceStreamMissing", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public MissingManifestResourceException(string message)
		{
			throw null;
		}

		// Token: 0x0600204C RID: 8268 RVA: 0x00019F73 File Offset: 0x00018173
		[global::Cpp2ILInjected.Token(Token = "0x60022C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B75BC0", Offset = "0x1B75BC0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.SystemException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(global::System.Runtime.Serialization.SerializationInfo),
			typeof(global::System.Runtime.Serialization.StreamingContext)
		}, ReturnType = typeof(void))]
		protected MissingManifestResourceException(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}
	}
}
