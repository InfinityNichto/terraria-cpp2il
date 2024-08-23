using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x0200000B RID: 11
	[global::Cpp2ILInjected.Token(Token = "0x200000B")]
	public class AddProgressEventArgs : ZipProgressEventArgs
	{
		// Token: 0x0600002C RID: 44 RVA: 0x00004F0C File Offset: 0x0000310C
		[global::Cpp2ILInjected.Token(Token = "0x600002C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45230", Offset = "0x1A45230", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		internal AddProgressEventArgs()
		{
			throw null;
		}

		// Token: 0x0600002D RID: 45 RVA: 0x00004F0F File Offset: 0x0000310F
		[global::Cpp2ILInjected.Token(Token = "0x600002D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45234", Offset = "0x1A45234", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		private AddProgressEventArgs(string archiveName, ZipProgressEventType flavor)
		{
			throw null;
		}

		// Token: 0x0600002E RID: 46 RVA: 0x00004F12 File Offset: 0x00003112
		[global::Cpp2ILInjected.Token(Token = "0x600002E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45238", Offset = "0x1A45238", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AfterAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static AddProgressEventArgs AfterEntry(string archiveName, ZipEntry entry, int entriesTotal)
		{
			throw null;
		}

		// Token: 0x0600002F RID: 47 RVA: 0x00004F15 File Offset: 0x00003115
		[global::Cpp2ILInjected.Token(Token = "0x600002F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A452AC", Offset = "0x1A452AC", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnAddStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static AddProgressEventArgs Started(string archiveName)
		{
			throw null;
		}

		// Token: 0x06000030 RID: 48 RVA: 0x00004F18 File Offset: 0x00003118
		[global::Cpp2ILInjected.Token(Token = "0x6000030")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45308", Offset = "0x1A45308", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnAddCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static AddProgressEventArgs Completed(string archiveName)
		{
			throw null;
		}
	}
}
