using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x02000011 RID: 17
	[Guid("ebc25cf6-9120-4283-b972-0e5520d0000A")]
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	[Serializable]
	public class BadReadException : ZipException
	{
		// Token: 0x0600004D RID: 77 RVA: 0x00004F6F File Offset: 0x0000316F
		[global::Cpp2ILInjected.Token(Token = "0x600004D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A459F0", Offset = "0x1A459F0", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", ReturnType = typeof(void))]
		public BadReadException()
		{
			throw null;
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00004F72 File Offset: 0x00003172
		[global::Cpp2ILInjected.Token(Token = "0x600004E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A459F4", Offset = "0x1A459F4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SharedUtilities), Member = "_ReadFourBytes", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.<>c__DisplayClass1", Member = "<ProcessExtraFieldZip64>b__0", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
		{
			typeof(ZipFile),
			typeof(Dictionary<string, object>)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_CheckRead", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Encoding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraFieldZip64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraFieldInfoZipTimes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraFieldUnixTimes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraFieldWindowsTimes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Zip64SeekToCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadCentralDirectoryFooter", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public BadReadException(string message)
		{
			throw null;
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00004F75 File Offset: 0x00003175
		[global::Cpp2ILInjected.Token(Token = "0x600004F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A459F8", Offset = "0x1A459F8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		public BadReadException(string message, Exception innerException)
		{
			throw null;
		}
	}
}
