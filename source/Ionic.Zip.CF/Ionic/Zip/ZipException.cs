using System;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x0200000F RID: 15
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00006")]
	[global::Cpp2ILInjected.Token(Token = "0x200000F")]
	[Serializable]
	public class ZipException : Exception
	{
		// Token: 0x06000047 RID: 71 RVA: 0x00004F5D File Offset: 0x0000315D
		[global::Cpp2ILInjected.Token(Token = "0x6000047")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A458B4", Offset = "0x1A458B4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BadPasswordException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BadReadException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BadCrcException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SfxGenerationException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BadStateException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZipException()
		{
			throw null;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00004F60 File Offset: 0x00003160
		[global::Cpp2ILInjected.Token(Token = "0x6000048")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4590C", Offset = "0x1A4590C", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 30)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZipException(string message)
		{
			throw null;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00004F63 File Offset: 0x00003163
		[global::Cpp2ILInjected.Token(Token = "0x6000049")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A45974", Offset = "0x1A45974", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BadPasswordException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BadStateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntrySource),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Initialize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZipException(string message, Exception innerException)
		{
			throw null;
		}
	}
}
