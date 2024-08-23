using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x0200000E RID: 14
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public class ZipErrorEventArgs : ZipProgressEventArgs
	{
		// Token: 0x06000043 RID: 67 RVA: 0x00004F51 File Offset: 0x00003151
		[global::Cpp2ILInjected.Token(Token = "0x6000043")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45824", Offset = "0x1A45824", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		private ZipErrorEventArgs()
		{
			throw null;
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00004F54 File Offset: 0x00003154
		[global::Cpp2ILInjected.Token(Token = "0x6000044")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45828", Offset = "0x1A45828", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnZipErrorSaving", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ZipErrorEventArgs Saving(string archiveName, ZipEntry entry, Exception exception)
		{
			throw null;
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000045 RID: 69 RVA: 0x00004F57 File Offset: 0x00003157
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public Exception Exception
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000045")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A458A0", Offset = "0x1A458A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000046 RID: 70 RVA: 0x00004F5A File Offset: 0x0000315A
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public string FileName
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000046")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A458A8", Offset = "0x1A458A8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x04000028 RID: 40
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Exception _exc;
	}
}
