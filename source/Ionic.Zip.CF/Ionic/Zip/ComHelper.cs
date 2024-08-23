using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x02000002 RID: 2
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000F")]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x2000002")]
	public class ComHelper
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00004EBB File Offset: 0x000030BB
		[global::Cpp2ILInjected.Token(Token = "0x6000001")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A445E8", Offset = "0x1A445E8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsZipFile(string filename)
		{
			throw null;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00004EBE File Offset: 0x000030BE
		[global::Cpp2ILInjected.Token(Token = "0x6000002")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A44694", Offset = "0x1A44694", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool IsZipFileWithExtract(string filename)
		{
			throw null;
		}

		// Token: 0x06000003 RID: 3 RVA: 0x00004EC1 File Offset: 0x000030C1
		[global::Cpp2ILInjected.Token(Token = "0x6000003")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A44980", Offset = "0x1A44980", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_LibraryVersion", ReturnType = typeof(Version))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public string GetZipLibraryVersion()
		{
			throw null;
		}

		// Token: 0x06000004 RID: 4 RVA: 0x00004EC4 File Offset: 0x000030C4
		[global::Cpp2ILInjected.Token(Token = "0x6000004")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A44A30", Offset = "0x1A44A30", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public ComHelper()
		{
			throw null;
		}
	}
}
