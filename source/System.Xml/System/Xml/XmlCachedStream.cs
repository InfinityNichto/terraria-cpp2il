using System;
using System.IO;
using System.Net;
using System.Net.Cache;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml
{
	// Token: 0x02000074 RID: 116
	[global::Cpp2ILInjected.Token(Token = "0x200009B")]
	internal class XmlCachedStream : MemoryStream
	{
		// Token: 0x060006BC RID: 1724 RVA: 0x000042E3 File Offset: 0x000024E3
		[global::Cpp2ILInjected.Token(Token = "0x6000745")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DAC884", Offset = "0x1DAC884", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlDownloadManager.<GetNonFileStreamAsync>d__5", Member = "MoveNext", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XmlDownloadManager), Member = "GetNonFileStream", MemberParameters = new object[]
		{
			typeof(Uri),
			typeof(ICredentials),
			typeof(IWebProxy),
			typeof(RequestCachePolicy)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "set_Position", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		internal XmlCachedStream(Uri uri, Stream stream)
		{
			throw null;
		}

		// Token: 0x0400024E RID: 590
		[global::Cpp2ILInjected.Token(Token = "0x40003B6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private Uri uri;
	}
}
