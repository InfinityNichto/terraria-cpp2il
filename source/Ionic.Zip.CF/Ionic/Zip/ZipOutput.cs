using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Ionic.Zip
{
	// Token: 0x02000028 RID: 40
	[global::Cpp2ILInjected.Token(Token = "0x200002E")]
	internal static class ZipOutput
	{
		// Token: 0x0600020E RID: 526 RVA: 0x000054A3 File Offset: 0x000036A3
		[global::Cpp2ILInjected.Token(Token = "0x6000222")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5E6B0", Offset = "0x1A5E6B0", Length = "0x858")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_IncludedInMostRecentSave", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "WriteCentralDirectoryEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutput), Member = "CountEntries", MemberParameters = new object[] { typeof(ICollection<ZipEntry>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutput), Member = "GenZip64EndOfCentralDirectory", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(int),
			typeof(uint)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutput), Member = "GenCentralDirectoryFooter", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(Zip64Option),
			typeof(int),
			typeof(string),
			typeof(ZipContainer)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(ushort) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = "get_ComputedPosition", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public static bool WriteCentralDirectoryStructure(Stream s, ICollection<ZipEntry> entries, uint numSegments, Zip64Option zip64, string comment, ZipContainer container)
		{
			throw null;
		}

		// Token: 0x0600020F RID: 527 RVA: 0x000054A6 File Offset: 0x000036A6
		[global::Cpp2ILInjected.Token(Token = "0x6000223")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5F678", Offset = "0x1A5F678", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutput), Member = "GenCentralDirectoryFooter", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(Zip64Option),
			typeof(int),
			typeof(string),
			typeof(ZipContainer)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_DefaultEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Equals", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		private static Encoding GetEncoding(ZipContainer container, string t)
		{
			throw null;
		}

		// Token: 0x06000210 RID: 528 RVA: 0x000054A9 File Offset: 0x000036A9
		[global::Cpp2ILInjected.Token(Token = "0x6000224")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5F414", Offset = "0x1A5F414", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutput), Member = "WriteCentralDirectoryStructure", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ICollection<ZipEntry>),
			typeof(uint),
			typeof(Zip64Option),
			typeof(string),
			typeof(ZipContainer)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutput), Member = "GetEncoding", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(string)
		}, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static byte[] GenCentralDirectoryFooter(long StartOfCentralDirectory, long EndOfCentralDirectory, Zip64Option zip64, int entryCount, string comment, ZipContainer container)
		{
			throw null;
		}

		// Token: 0x06000211 RID: 529 RVA: 0x000054AC File Offset: 0x000036AC
		[global::Cpp2ILInjected.Token(Token = "0x6000225")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5F1CC", Offset = "0x1A5F1CC", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutput), Member = "WriteCentralDirectoryStructure", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ICollection<ZipEntry>),
			typeof(uint),
			typeof(Zip64Option),
			typeof(string),
			typeof(ZipContainer)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static byte[] GenZip64EndOfCentralDirectory(long StartOfCentralDirectory, long EndOfCentralDirectory, int entryCount, uint numSegments)
		{
			throw null;
		}

		// Token: 0x06000212 RID: 530 RVA: 0x000054AF File Offset: 0x000036AF
		[global::Cpp2ILInjected.Token(Token = "0x6000226")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5EF08", Offset = "0x1A5EF08", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutput), Member = "WriteCentralDirectoryStructure", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ICollection<ZipEntry>),
			typeof(uint),
			typeof(Zip64Option),
			typeof(string),
			typeof(ZipContainer)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_IncludedInMostRecentSave", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static int CountEntries(ICollection<ZipEntry> _entries)
		{
			throw null;
		}
	}
}
