﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x02000023 RID: 35
	[ComVisible(true)]
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
	[global::Cpp2ILInjected.Token(Token = "0x2000027")]
	public class ZipFile : IEnumerable<ZipEntry>, IEnumerable, IDisposable
	{
		// Token: 0x06000147 RID: 327 RVA: 0x0000524E File Offset: 0x0000344E
		[global::Cpp2ILInjected.Token(Token = "0x6000152")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A53EE8", Offset = "0x1A53EE8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ZipEntry AddItem(string fileOrDirectoryName)
		{
			throw null;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00005251 File Offset: 0x00003451
		[global::Cpp2ILInjected.Token(Token = "0x6000153")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A53EF0", Offset = "0x1A53EF0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ZipEntry AddItem(string fileOrDirectoryName, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x06000149 RID: 329 RVA: 0x00005254 File Offset: 0x00003454
		[global::Cpp2ILInjected.Token(Token = "0x6000154")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A54070", Offset = "0x1A54070", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry AddFile(string fileName)
		{
			throw null;
		}

		// Token: 0x0600014A RID: 330 RVA: 0x00005257 File Offset: 0x00003457
		[global::Cpp2ILInjected.Token(Token = "0x6000155")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A53FAC", Offset = "0x1A53FAC", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "NameInArchive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CreateFromFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ZipEntry AddFile(string fileName, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x0600014B RID: 331 RVA: 0x0000525A File Offset: 0x0000345A
		[global::Cpp2ILInjected.Token(Token = "0x6000156")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A541B8", Offset = "0x1A541B8", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void RemoveEntries(ICollection<ZipEntry> entriesToRemove)
		{
			throw null;
		}

		// Token: 0x0600014C RID: 332 RVA: 0x0000525D File Offset: 0x0000345D
		[global::Cpp2ILInjected.Token(Token = "0x6000157")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A544C8", Offset = "0x1A544C8", Length = "0x310")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void RemoveEntries(ICollection<string> entriesToRemove)
		{
			throw null;
		}

		// Token: 0x0600014D RID: 333 RVA: 0x00005260 File Offset: 0x00003460
		[global::Cpp2ILInjected.Token(Token = "0x6000158")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A548A0", Offset = "0x1A548A0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void AddFiles(IEnumerable<string> fileNames)
		{
			throw null;
		}

		// Token: 0x0600014E RID: 334 RVA: 0x00005263 File Offset: 0x00003463
		[global::Cpp2ILInjected.Token(Token = "0x6000159")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A548B8", Offset = "0x1A548B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UpdateFiles(IEnumerable<string> fileNames)
		{
			throw null;
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00005266 File Offset: 0x00003466
		[global::Cpp2ILInjected.Token(Token = "0x600015A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A548AC", Offset = "0x1A548AC", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void AddFiles(IEnumerable<string> fileNames, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00005269 File Offset: 0x00003469
		[global::Cpp2ILInjected.Token(Token = "0x600015B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A54C10", Offset = "0x1A54C10", Length = "0x650")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFiles", MemberParameters = new object[] { typeof(IEnumerable<string>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnAddStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnAddCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public void AddFiles(IEnumerable<string> fileNames, bool preserveDirHierarchy, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x06000151 RID: 337 RVA: 0x0000526C File Offset: 0x0000346C
		[global::Cpp2ILInjected.Token(Token = "0x600015C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A548C0", Offset = "0x1A548C0", Length = "0x350")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnAddStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnAddCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void UpdateFiles(IEnumerable<string> fileNames, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x06000152 RID: 338 RVA: 0x0000526F File Offset: 0x0000346F
		[global::Cpp2ILInjected.Token(Token = "0x600015D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55418", Offset = "0x1A55418", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry UpdateFile(string fileName)
		{
			throw null;
		}

		// Token: 0x06000153 RID: 339 RVA: 0x00005272 File Offset: 0x00003472
		[global::Cpp2ILInjected.Token(Token = "0x600015E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55380", Offset = "0x1A55380", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateItem", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "NameInArchive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ZipEntry UpdateFile(string fileName, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00005275 File Offset: 0x00003475
		[global::Cpp2ILInjected.Token(Token = "0x600015F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55420", Offset = "0x1A55420", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry UpdateDirectory(string directoryName)
		{
			throw null;
		}

		// Token: 0x06000155 RID: 341 RVA: 0x00005278 File Offset: 0x00003478
		[global::Cpp2ILInjected.Token(Token = "0x6000160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5542C", Offset = "0x1A5542C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public ZipEntry UpdateDirectory(string directoryName, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x06000156 RID: 342 RVA: 0x0000527B File Offset: 0x0000347B
		[global::Cpp2ILInjected.Token(Token = "0x6000161")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A554B0", Offset = "0x1A554B0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UpdateItem(string itemName)
		{
			throw null;
		}

		// Token: 0x06000157 RID: 343 RVA: 0x0000527E File Offset: 0x0000347E
		[global::Cpp2ILInjected.Token(Token = "0x6000162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A554B8", Offset = "0x1A554B8", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void UpdateItem(string itemName, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x06000158 RID: 344 RVA: 0x00005281 File Offset: 0x00003481
		[global::Cpp2ILInjected.Token(Token = "0x6000163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55574", Offset = "0x1A55574", Length = "0x38")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		public ZipEntry AddEntry(string entryName, string content)
		{
			throw null;
		}

		// Token: 0x06000159 RID: 345 RVA: 0x00005284 File Offset: 0x00003484
		[global::Cpp2ILInjected.Token(Token = "0x6000164")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A555AC", Offset = "0x1A555AC", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Encoding)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public ZipEntry AddEntry(string entryName, string content, Encoding encoding)
		{
			throw null;
		}

		// Token: 0x0600015A RID: 346 RVA: 0x00005287 File Offset: 0x00003487
		[global::Cpp2ILInjected.Token(Token = "0x6000165")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5569C", Offset = "0x1A5569C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CreateForStream", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetEntryTimes", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ZipEntry AddEntry(string entryName, Stream stream)
		{
			throw null;
		}

		// Token: 0x0600015B RID: 347 RVA: 0x0000528A File Offset: 0x0000348A
		[global::Cpp2ILInjected.Token(Token = "0x6000166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A557A4", Offset = "0x1A557A4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WriteDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CreateForWriter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WriteDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ZipEntry AddEntry(string entryName, WriteDelegate writer)
		{
			throw null;
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000528D File Offset: 0x0000348D
		[global::Cpp2ILInjected.Token(Token = "0x6000167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55854", Offset = "0x1A55854", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OpenDelegate),
			typeof(CloseDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CreateForJitStreamProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OpenDelegate),
			typeof(CloseDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetEntryTimes", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ZipEntry AddEntry(string entryName, OpenDelegate opener, CloseDelegate closer)
		{
			throw null;
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00005290 File Offset: 0x00003490
		[global::Cpp2ILInjected.Token(Token = "0x6000168")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A54078", Offset = "0x1A54078", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WriteDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OpenDelegate),
			typeof(CloseDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_CompressionMethod", MemberParameters = new object[] { typeof(CompressionMethod) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_CompressionLevel", MemberParameters = new object[] { typeof(CompressionLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_Encryption", MemberParameters = new object[] { typeof(EncryptionAlgorithm) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "InternalAddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AfterAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private ZipEntry _InternalAddEntry(ZipEntry ze)
		{
			throw null;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00005293 File Offset: 0x00003493
		[global::Cpp2ILInjected.Token(Token = "0x6000169")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55A6C", Offset = "0x1A55A6C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_Default", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Encoding)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry UpdateEntry(string entryName, string content)
		{
			throw null;
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00005296 File Offset: 0x00003496
		[global::Cpp2ILInjected.Token(Token = "0x600016A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55ABC", Offset = "0x1A55ABC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Encoding)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry UpdateEntry(string entryName, string content, Encoding encoding)
		{
			throw null;
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00005299 File Offset: 0x00003499
		[global::Cpp2ILInjected.Token(Token = "0x600016B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55C4C", Offset = "0x1A55C4C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WriteDelegate)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry UpdateEntry(string entryName, WriteDelegate writer)
		{
			throw null;
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000529C File Offset: 0x0000349C
		[global::Cpp2ILInjected.Token(Token = "0x600016C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55C7C", Offset = "0x1A55C7C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OpenDelegate),
			typeof(CloseDelegate)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry UpdateEntry(string entryName, OpenDelegate opener, CloseDelegate closer)
		{
			throw null;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000529F File Offset: 0x0000349F
		[global::Cpp2ILInjected.Token(Token = "0x600016D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55CBC", Offset = "0x1A55CBC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry UpdateEntry(string entryName, Stream stream)
		{
			throw null;
		}

		// Token: 0x06000163 RID: 355 RVA: 0x000052A2 File Offset: 0x000034A2
		[global::Cpp2ILInjected.Token(Token = "0x600016E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55AFC", Offset = "0x1A55AFC", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(Encoding)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WriteDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OpenDelegate),
			typeof(CloseDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "NameInArchive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void RemoveEntryForUpdate(string entryName)
		{
			throw null;
		}

		// Token: 0x06000164 RID: 356 RVA: 0x000052A5 File Offset: 0x000034A5
		[global::Cpp2ILInjected.Token(Token = "0x600016F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55CEC", Offset = "0x1A55CEC", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public ZipEntry AddEntry(string entryName, byte[] byteContent)
		{
			throw null;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x000052A8 File Offset: 0x000034A8
		[global::Cpp2ILInjected.Token(Token = "0x6000170")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55DC0", Offset = "0x1A55DC0", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry UpdateEntry(string entryName, byte[] byteContent)
		{
			throw null;
		}

		// Token: 0x06000166 RID: 358 RVA: 0x000052AB File Offset: 0x000034AB
		[global::Cpp2ILInjected.Token(Token = "0x6000171")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55DF0", Offset = "0x1A55DF0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry AddDirectory(string directoryName)
		{
			throw null;
		}

		// Token: 0x06000167 RID: 359 RVA: 0x000052AE File Offset: 0x000034AE
		[global::Cpp2ILInjected.Token(Token = "0x6000172")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A54068", Offset = "0x1A54068", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction)
		}, ReturnType = typeof(ZipEntry))]
		public ZipEntry AddDirectory(string directoryName, string directoryPathInArchive)
		{
			throw null;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x000052B1 File Offset: 0x000034B1
		[global::Cpp2ILInjected.Token(Token = "0x6000173")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55DFC", Offset = "0x1A55DFC", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CreateFromNothing", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MarkAsDirectory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetEntryTimes", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "InternalAddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AfterAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public ZipEntry AddDirectoryByName(string directoryNameInArchive)
		{
			throw null;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x000052B4 File Offset: 0x000034B4
		[global::Cpp2ILInjected.Token(Token = "0x6000174")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55434", Offset = "0x1A55434", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddItem", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateItem", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddDirectory", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action)
		{
			throw null;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x000052B7 File Offset: 0x000034B7
		[global::Cpp2ILInjected.Token(Token = "0x6000175")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A49F64", Offset = "0x1A49F64", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "set_FileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddDirectoryByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void InternalAddEntry(string name, ZipEntry entry)
		{
			throw null;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x000052BA File Offset: 0x000034BA
		[global::Cpp2ILInjected.Token(Token = "0x6000176")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55F48", Offset = "0x1A55F48", Length = "0x390")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnAddStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "ToCharArray", ReturnType = typeof(char[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOfAny", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CreateFromFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MarkAsDirectory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "InternalAddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AfterAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetDirectories", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCfFile), Member = "GetAttributes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnAddCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, AddOrUpdateAction action, bool recurse, int level)
		{
			throw null;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000052BD File Offset: 0x000034BD
		[global::Cpp2ILInjected.Token(Token = "0x6000177")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A562D8", Offset = "0x1A562D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool CheckZip(string zipFileName)
		{
			throw null;
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000052C0 File Offset: 0x000034C0
		[global::Cpp2ILInjected.Token(Token = "0x6000178")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A56334", Offset = "0x1A56334", Length = "0xCF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Initialize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<ZipEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileNameWithoutExtension", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Save", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 100)]
		public static bool CheckZip(string zipFileName, bool fixIfNecessary, TextWriter writer)
		{
			throw null;
		}

		// Token: 0x0600016E RID: 366 RVA: 0x000052C3 File Offset: 0x000034C3
		[global::Cpp2ILInjected.Token(Token = "0x6000179")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A57418", Offset = "0x1A57418", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Initialize", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Save", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void FixZipDirectory(string zipFileName)
		{
			throw null;
		}

		// Token: 0x0600016F RID: 367 RVA: 0x000052C6 File Offset: 0x000034C6
		[global::Cpp2ILInjected.Token(Token = "0x600017A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A575B8", Offset = "0x1A575B8", Length = "0x47C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<ZipEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		public static bool CheckZipPassword(string zipFileName, string password)
		{
			throw null;
		}

		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000170 RID: 368 RVA: 0x000052C9 File Offset: 0x000034C9
		[global::Cpp2ILInjected.Token(Token = "0x1700004F")]
		public string Info
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A57A34", Offset = "0x1A57A34", Length = "0x448")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_InputUsesZip64", ReturnType = typeof(bool?))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_Info", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000171 RID: 369 RVA: 0x000052CC File Offset: 0x000034CC
		// (set) Token: 0x06000172 RID: 370 RVA: 0x000052CF File Offset: 0x000034CF
		[global::Cpp2ILInjected.Token(Token = "0x17000050")]
		public bool FullScan
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581AC", Offset = "0x1A581AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600017D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581B4", Offset = "0x1A581B4", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000173 RID: 371 RVA: 0x000052D2 File Offset: 0x000034D2
		// (set) Token: 0x06000174 RID: 372 RVA: 0x000052D5 File Offset: 0x000034D5
		[global::Cpp2ILInjected.Token(Token = "0x17000051")]
		public bool SortEntriesBeforeSaving
		{
			[global::Cpp2ILInjected.Token(Token = "0x600017E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581C0", Offset = "0x1A581C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600017F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581C8", Offset = "0x1A581C8", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000175 RID: 373 RVA: 0x000052D8 File Offset: 0x000034D8
		// (set) Token: 0x06000176 RID: 374 RVA: 0x000052DB File Offset: 0x000034DB
		[global::Cpp2ILInjected.Token(Token = "0x17000052")]
		public bool AddDirectoryWillTraverseReparsePoints
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000180")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581D4", Offset = "0x1A581D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000181")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581DC", Offset = "0x1A581DC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x06000177 RID: 375 RVA: 0x000052DE File Offset: 0x000034DE
		// (set) Token: 0x06000178 RID: 376 RVA: 0x000052E1 File Offset: 0x000034E1
		[global::Cpp2ILInjected.Token(Token = "0x17000053")]
		public int BufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000182")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581E8", Offset = "0x1A581E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000183")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581F0", Offset = "0x1A581F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000179 RID: 377 RVA: 0x000052E4 File Offset: 0x000034E4
		// (set) Token: 0x0600017A RID: 378 RVA: 0x000052E7 File Offset: 0x000034E7
		[global::Cpp2ILInjected.Token(Token = "0x17000054")]
		public int CodecBufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000184")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A581F8", Offset = "0x1A581F8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000185")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58200", Offset = "0x1A58200", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600017B RID: 379 RVA: 0x000052EA File Offset: 0x000034EA
		// (set) Token: 0x0600017C RID: 380 RVA: 0x000052ED File Offset: 0x000034ED
		[global::Cpp2ILInjected.Token(Token = "0x17000055")]
		public bool FlattenFoldersOnExtract
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000186")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58208", Offset = "0x1A58208", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000187")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58210", Offset = "0x1A58210", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600017D RID: 381 RVA: 0x000052F0 File Offset: 0x000034F0
		// (set) Token: 0x0600017E RID: 382 RVA: 0x000052F3 File Offset: 0x000034F3
		[global::Cpp2ILInjected.Token(Token = "0x17000056")]
		public CompressionStrategy Strategy
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000188")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5821C", Offset = "0x1A5821C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000189")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58224", Offset = "0x1A58224", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600017F RID: 383 RVA: 0x000052F6 File Offset: 0x000034F6
		// (set) Token: 0x06000180 RID: 384 RVA: 0x000052F9 File Offset: 0x000034F9
		[global::Cpp2ILInjected.Token(Token = "0x17000057")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5822C", Offset = "0x1A5822C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600018B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58234", Offset = "0x1A58234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x06000181 RID: 385 RVA: 0x000052FC File Offset: 0x000034FC
		// (set) Token: 0x06000182 RID: 386 RVA: 0x000052FF File Offset: 0x000034FF
		[global::Cpp2ILInjected.Token(Token = "0x17000058")]
		public CompressionLevel CompressionLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5823C", Offset = "0x1A5823C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600018D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58244", Offset = "0x1A58244", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x06000183 RID: 387 RVA: 0x00005302 File Offset: 0x00003502
		// (set) Token: 0x06000184 RID: 388 RVA: 0x00005305 File Offset: 0x00003505
		[global::Cpp2ILInjected.Token(Token = "0x17000059")]
		public CompressionMethod CompressionMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x600018E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5824C", Offset = "0x1A5824C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600018F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58254", Offset = "0x1A58254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x06000185 RID: 389 RVA: 0x00005308 File Offset: 0x00003508
		// (set) Token: 0x06000186 RID: 390 RVA: 0x0000530B File Offset: 0x0000350B
		[global::Cpp2ILInjected.Token(Token = "0x1700005A")]
		public string Comment
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000190")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5825C", Offset = "0x1A5825C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000191")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58264", Offset = "0x1A58264", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005B RID: 91
		// (get) Token: 0x06000187 RID: 391 RVA: 0x0000530E File Offset: 0x0000350E
		// (set) Token: 0x06000188 RID: 392 RVA: 0x00005311 File Offset: 0x00003511
		[global::Cpp2ILInjected.Token(Token = "0x1700005B")]
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000192")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58274", Offset = "0x1A58274", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000193")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5827C", Offset = "0x1A5827C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000189 RID: 393 RVA: 0x00005314 File Offset: 0x00003514
		// (set) Token: 0x0600018A RID: 394 RVA: 0x00005317 File Offset: 0x00003517
		[global::Cpp2ILInjected.Token(Token = "0x1700005C")]
		public bool EmitTimesInUnixFormatWhenSaving
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000194")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58288", Offset = "0x1A58288", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000195")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58290", Offset = "0x1A58290", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600018B RID: 395 RVA: 0x0000531A File Offset: 0x0000351A
		[global::Cpp2ILInjected.Token(Token = "0x1700005D")]
		internal bool Verbose
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000196")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4CC0C", Offset = "0x1A4CC0C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600018C RID: 396 RVA: 0x0000531D File Offset: 0x0000351D
		[global::Cpp2ILInjected.Token(Token = "0x6000197")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5829C", Offset = "0x1A5829C", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "HasFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "NormalizePathForUseInZipFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public bool ContainsEntry(string name)
		{
			throw null;
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600018D RID: 397 RVA: 0x00005320 File Offset: 0x00003520
		// (set) Token: 0x0600018E RID: 398 RVA: 0x00005323 File Offset: 0x00003523
		[global::Cpp2ILInjected.Token(Token = "0x1700005E")]
		public bool CaseSensitiveRetrieval
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000198")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58324", Offset = "0x1A58324", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000199")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5832C", Offset = "0x1A5832C", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600018F RID: 399 RVA: 0x00005326 File Offset: 0x00003526
		// (set) Token: 0x06000190 RID: 400 RVA: 0x00005329 File Offset: 0x00003529
		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x1700005F")]
		public bool UseUnicodeAsNecessary
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A584A8", Offset = "0x1A584A8", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600019B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58514", Offset = "0x1A58514", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000191 RID: 401 RVA: 0x0000532C File Offset: 0x0000352C
		// (set) Token: 0x06000192 RID: 402 RVA: 0x0000532F File Offset: 0x0000352F
		[global::Cpp2ILInjected.Token(Token = "0x17000060")]
		public Zip64Option UseZip64WhenSaving
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A585E4", Offset = "0x1A585E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x600019D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A585EC", Offset = "0x1A585EC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000061 RID: 97
		// (get) Token: 0x06000193 RID: 403 RVA: 0x00005332 File Offset: 0x00003532
		[global::Cpp2ILInjected.Token(Token = "0x17000061")]
		public bool? RequiresZip64
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A585F4", Offset = "0x1A585F4", Length = "0x238")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000062 RID: 98
		// (get) Token: 0x06000194 RID: 404 RVA: 0x00005335 File Offset: 0x00003535
		[global::Cpp2ILInjected.Token(Token = "0x17000062")]
		public bool? OutputUsedZip64
		{
			[global::Cpp2ILInjected.Token(Token = "0x600019F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5882C", Offset = "0x1A5882C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000063 RID: 99
		// (get) Token: 0x06000195 RID: 405 RVA: 0x00005338 File Offset: 0x00003538
		[global::Cpp2ILInjected.Token(Token = "0x17000063")]
		public bool? InputUsesZip64
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A57E7C", Offset = "0x1A57E7C", Length = "0x330")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "get_Info", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<ZipEntry>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000196 RID: 406 RVA: 0x0000533B File Offset: 0x0000353B
		// (set) Token: 0x06000197 RID: 407 RVA: 0x0000533E File Offset: 0x0000353E
		[Obsolete("use AlternateEncoding instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000064")]
		public Encoding ProvisionalAlternateEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58834", Offset = "0x1A58834", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58850", Offset = "0x1A58850", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000198 RID: 408 RVA: 0x00005341 File Offset: 0x00003541
		// (set) Token: 0x06000199 RID: 409 RVA: 0x00005344 File Offset: 0x00003544
		[global::Cpp2ILInjected.Token(Token = "0x17000065")]
		public Encoding AlternateEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58860", Offset = "0x1A58860", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58868", Offset = "0x1A58868", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x0600019A RID: 410 RVA: 0x00005347 File Offset: 0x00003547
		// (set) Token: 0x0600019B RID: 411 RVA: 0x0000534A File Offset: 0x0000354A
		[global::Cpp2ILInjected.Token(Token = "0x17000066")]
		public ZipOption AlternateEncodingUsage
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58870", Offset = "0x1A58870", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58878", Offset = "0x1A58878", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x0600019C RID: 412 RVA: 0x0000534D File Offset: 0x0000354D
		[global::Cpp2ILInjected.Token(Token = "0x17000067")]
		public static Encoding DefaultEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58880", Offset = "0x1A58880", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600019D RID: 413 RVA: 0x00005350 File Offset: 0x00003550
		// (set) Token: 0x0600019E RID: 414 RVA: 0x00005353 File Offset: 0x00003553
		[global::Cpp2ILInjected.Token(Token = "0x17000068")]
		public TextWriter StatusMessageTextWriter
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A588D8", Offset = "0x1A588D8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A588E0", Offset = "0x1A588E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x0600019F RID: 415 RVA: 0x00005356 File Offset: 0x00003556
		// (set) Token: 0x060001A0 RID: 416 RVA: 0x00005359 File Offset: 0x00003559
		[global::Cpp2ILInjected.Token(Token = "0x17000069")]
		public string TempFileFolder
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A588E8", Offset = "0x1A588E8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A588F0", Offset = "0x1A588F0", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x060001A2 RID: 418 RVA: 0x0000535F File Offset: 0x0000355F
		// (set) Token: 0x060001A1 RID: 417 RVA: 0x0000535C File Offset: 0x0000355C
		[global::Cpp2ILInjected.Token(Token = "0x1700006A")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A589FC", Offset = "0x1A589FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58974", Offset = "0x1A58974", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x060001A3 RID: 419 RVA: 0x00005362 File Offset: 0x00003562
		// (set) Token: 0x060001A4 RID: 420 RVA: 0x00005365 File Offset: 0x00003565
		[global::Cpp2ILInjected.Token(Token = "0x1700006B")]
		public ExtractExistingFileAction ExtractExistingFile
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58A04", Offset = "0x1A58A04", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58A0C", Offset = "0x1A58A0C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x060001A5 RID: 421 RVA: 0x00005368 File Offset: 0x00003568
		// (set) Token: 0x060001A6 RID: 422 RVA: 0x0000536B File Offset: 0x0000356B
		[global::Cpp2ILInjected.Token(Token = "0x1700006C")]
		public ZipErrorAction ZipErrorAction
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5596C", Offset = "0x1A5596C", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58A14", Offset = "0x1A58A14", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x060001A7 RID: 423 RVA: 0x0000536E File Offset: 0x0000356E
		// (set) Token: 0x060001A8 RID: 424 RVA: 0x00005371 File Offset: 0x00003571
		[global::Cpp2ILInjected.Token(Token = "0x1700006D")]
		public EncryptionAlgorithm Encryption
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58A30", Offset = "0x1A58A30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5899C", Offset = "0x1A5899C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x060001A9 RID: 425 RVA: 0x00005374 File Offset: 0x00003574
		// (set) Token: 0x060001AA RID: 426 RVA: 0x00005377 File Offset: 0x00003577
		[global::Cpp2ILInjected.Token(Token = "0x1700006E")]
		public SetCompressionCallback SetCompression
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58A38", Offset = "0x1A58A38", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58A40", Offset = "0x1A58A40", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x060001AB RID: 427 RVA: 0x0000537A File Offset: 0x0000357A
		// (set) Token: 0x060001AC RID: 428 RVA: 0x0000537D File Offset: 0x0000357D
		[global::Cpp2ILInjected.Token(Token = "0x1700006F")]
		public int MaxOutputSegmentSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58A48", Offset = "0x1A58A48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58A50", Offset = "0x1A58A50", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x060001AD RID: 429 RVA: 0x00005380 File Offset: 0x00003580
		[global::Cpp2ILInjected.Token(Token = "0x17000070")]
		public int NumberOfSegmentsForMostRecentSave
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A58AB0", Offset = "0x1A58AB0", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001AE RID: 430 RVA: 0x00005383 File Offset: 0x00003583
		[global::Cpp2ILInjected.Token(Token = "0x60001B9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A58ABC", Offset = "0x1A58ABC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x060001AF RID: 431 RVA: 0x00005386 File Offset: 0x00003586
		[global::Cpp2ILInjected.Token(Token = "0x17000071")]
		public static Version LibraryVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A449D8", Offset = "0x1A449D8", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ComHelper), Member = "GetZipLibraryVersion", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x00005389 File Offset: 0x00003589
		[global::Cpp2ILInjected.Token(Token = "0x60001BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A49FD4", Offset = "0x1A49FD4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void NotifyEntryChanged()
		{
			throw null;
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0000538C File Offset: 0x0000358C
		[global::Cpp2ILInjected.Token(Token = "0x60001BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4B35C", Offset = "0x1A4B35C", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "ForReading", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint),
			typeof(uint)
		}, ReturnType = typeof(ZipSegmentedStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		internal Stream StreamForDiskNumber(uint diskNumber)
		{
			throw null;
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x0000538F File Offset: 0x0000358F
		[global::Cpp2ILInjected.Token(Token = "0x60001BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4AD14", Offset = "0x1A4AD14", Length = "0x648")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<ZipEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CopyMetaData", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 30)]
		internal void Reset(bool whileSaving)
		{
			throw null;
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00005392 File Offset: 0x00003592
		[global::Cpp2ILInjected.Token(Token = "0x60001BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A58FA0", Offset = "0x1A58FA0", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public ZipFile(string fileName)
		{
			throw null;
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00005395 File Offset: 0x00003595
		[global::Cpp2ILInjected.Token(Token = "0x60001BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5921C", Offset = "0x1A5921C", Length = "0x1D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public ZipFile(string fileName, Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060001B5 RID: 437 RVA: 0x00005398 File Offset: 0x00003598
		[global::Cpp2ILInjected.Token(Token = "0x60001C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A57028", Offset = "0x1A57028", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(TextWriter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "FixZipDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ZipFile()
		{
			throw null;
		}

		// Token: 0x060001B6 RID: 438 RVA: 0x0000539B File Offset: 0x0000359B
		[global::Cpp2ILInjected.Token(Token = "0x60001C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A593F4", Offset = "0x1A593F4", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public ZipFile(Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060001B7 RID: 439 RVA: 0x0000539E File Offset: 0x0000359E
		[global::Cpp2ILInjected.Token(Token = "0x60001C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A59500", Offset = "0x1A59500", Length = "0x1CC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public ZipFile(string fileName, TextWriter statusMessageWriter)
		{
			throw null;
		}

		// Token: 0x060001B8 RID: 440 RVA: 0x000053A1 File Offset: 0x000035A1
		[global::Cpp2ILInjected.Token(Token = "0x60001C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A596CC", Offset = "0x1A596CC", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public ZipFile(string fileName, TextWriter statusMessageWriter, Encoding encoding)
		{
			throw null;
		}

		// Token: 0x060001B9 RID: 441 RVA: 0x000053A4 File Offset: 0x000035A4
		[global::Cpp2ILInjected.Token(Token = "0x60001C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5711C", Offset = "0x1A5711C", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(TextWriter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "FixZipDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void Initialize(string fileName)
		{
			throw null;
		}

		// Token: 0x060001BA RID: 442 RVA: 0x000053A7 File Offset: 0x000035A7
		[global::Cpp2ILInjected.Token(Token = "0x60001C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A58348", Offset = "0x1A58348", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IDictionary<object, object>),
			typeof(IEqualityComparer<object>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void _initEntriesDictionary()
		{
			throw null;
		}

		// Token: 0x060001BB RID: 443 RVA: 0x000053AA File Offset: 0x000035AA
		[global::Cpp2ILInjected.Token(Token = "0x60001C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A59168", Offset = "0x1A59168", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = ".ctor", MemberParameters = new object[] { typeof(Encoding) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_initEntriesDictionary", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void _InitInstance(string zipFileName, TextWriter statusMessageWriter)
		{
			throw null;
		}

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x060001BC RID: 444 RVA: 0x000053AD File Offset: 0x000035AD
		[global::Cpp2ILInjected.Token(Token = "0x17000072")]
		private List<ZipEntry> ZipEntriesAsList
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A59C94", Offset = "0x1A59C94", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000073 RID: 115
		[global::Cpp2ILInjected.Token(Token = "0x17000073")]
		public ZipEntry this[int ix]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A59D40", Offset = "0x1A59D40", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ZipEntriesAsList", ReturnType = typeof(List<ZipEntry>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000074 RID: 116
		[global::Cpp2ILInjected.Token(Token = "0x17000074")]
		public ZipEntry this[string fileName]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4D9BC", Offset = "0x1A4D9BC", Length = "0x120")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Stream),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "NormalizePathForUseInZipFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x060001BF RID: 447 RVA: 0x000053B6 File Offset: 0x000035B6
		[global::Cpp2ILInjected.Token(Token = "0x17000075")]
		public ICollection<string> EntryFileNames
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A59D9C", Offset = "0x1A59D9C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Keys", ReturnType = "KeyCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x060001C0 RID: 448 RVA: 0x000053B9 File Offset: 0x000035B9
		[global::Cpp2ILInjected.Token(Token = "0x17000076")]
		public ICollection<ZipEntry> Entries
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A59DE4", Offset = "0x1A59DE4", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.ZipContentSource", Member = "BuildExtensionFreeEntryList", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "get_EntriesSorted", ReturnType = typeof(ICollection<ZipEntry>))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x060001C1 RID: 449 RVA: 0x000053BC File Offset: 0x000035BC
		[global::Cpp2ILInjected.Token(Token = "0x17000077")]
		public ICollection<ZipEntry> EntriesSorted
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A59E2C", Offset = "0x1A59E2C", Length = "0x440")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile.<>c__DisplayClass1), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_Entries", ReturnType = typeof(ICollection<ZipEntry>))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(object),
				typeof(IntPtr)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AsReadOnly", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x060001C2 RID: 450 RVA: 0x000053BF File Offset: 0x000035BF
		[global::Cpp2ILInjected.Token(Token = "0x17000078")]
		public int Count
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5A26C", Offset = "0x1A5A26C", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060001C3 RID: 451 RVA: 0x000053C2 File Offset: 0x000035C2
		[global::Cpp2ILInjected.Token(Token = "0x60001CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A49E7C", Offset = "0x1A49E7C", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "set_FileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "RemoveEntries", MemberParameters = new object[] { typeof(ICollection<ZipEntry>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "NormalizePathForUseInZipFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void RemoveEntry(ZipEntry entry)
		{
			throw null;
		}

		// Token: 0x060001C4 RID: 452 RVA: 0x000053C5 File Offset: 0x000035C5
		[global::Cpp2ILInjected.Token(Token = "0x60001CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A547D8", Offset = "0x1A547D8", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "RemoveEntries", MemberParameters = new object[] { typeof(ICollection<string>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "NameInArchive", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void RemoveEntry(string fileName)
		{
			throw null;
		}

		// Token: 0x060001C5 RID: 453 RVA: 0x000053C8 File Offset: 0x000035C8
		[global::Cpp2ILInjected.Token(Token = "0x60001D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A572C0", Offset = "0x1A572C0", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.ZipContentSource", Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(TextWriter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Dispose()
		{
			throw null;
		}

		// Token: 0x060001C6 RID: 454 RVA: 0x000053CB File Offset: 0x000035CB
		[global::Cpp2ILInjected.Token(Token = "0x60001D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5A2B4", Offset = "0x1A5A2B4", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected virtual void Dispose(bool disposeManagedResources)
		{
			throw null;
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x060001C7 RID: 455 RVA: 0x000053CE File Offset: 0x000035CE
		[global::Cpp2ILInjected.Token(Token = "0x17000079")]
		internal Stream ReadStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4917C", Offset = "0x1A4917C", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
			{
				typeof(ZipFile),
				typeof(Dictionary<string, object>)
			}, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "StreamForDiskNumber", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnReadBytes", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Zip64SeekToCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadCentralDirectoryFooter", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadZipFileComment", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipContainer), Member = "get_ReadStream", ReturnType = typeof(Stream))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Open", MemberParameters = new object[]
			{
				typeof(string),
				typeof(FileMode),
				typeof(FileAccess),
				typeof(FileShare)
			}, ReturnType = typeof(FileStream))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x060001C8 RID: 456 RVA: 0x000053D1 File Offset: 0x000035D1
		// (set) Token: 0x060001C9 RID: 457 RVA: 0x000053D4 File Offset: 0x000035D4
		[global::Cpp2ILInjected.Token(Token = "0x1700007A")]
		private Stream WriteStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5A328", Offset = "0x1A5A328", Length = "0xE8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "ForWriting", MemberParameters = new object[]
			{
				typeof(string),
				typeof(int)
			}, ReturnType = typeof(ZipSegmentedStream))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "CreateAndOpenUniqueTempFile", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ref Stream),
				typeof(ref string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5A410", Offset = "0x1A5A410", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x060001CA RID: 458 RVA: 0x000053D7 File Offset: 0x000035D7
		[global::Cpp2ILInjected.Token(Token = "0x1700007B")]
		private string ArchiveNameForEvent
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5A468", Offset = "0x1A5A468", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x060001CB RID: 459 RVA: 0x000053DA File Offset: 0x000035DA
		// (remove) Token: 0x060001CC RID: 460 RVA: 0x000053DD File Offset: 0x000035DD
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		public event EventHandler<SaveProgressEventArgs> SaveProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5A4B8", Offset = "0x1A5A4B8", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5A568", Offset = "0x1A5A568", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060001CD RID: 461 RVA: 0x000053E0 File Offset: 0x000035E0
		[global::Cpp2ILInjected.Token(Token = "0x60001D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A51430", Offset = "0x1A51430", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "OnWriteBlock", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithNoChange", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveProgressEventArgs), Member = "ByteUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(SaveProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool OnSaveBlock(ZipEntry entry, long bytesXferred, long totalBytesToXfer)
		{
			throw null;
		}

		// Token: 0x060001CE RID: 462 RVA: 0x000053E3 File Offset: 0x000035E3
		[global::Cpp2ILInjected.Token(Token = "0x60001D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5A618", Offset = "0x1A5A618", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void OnSaveEntry(int current, ZipEntry entry, bool before)
		{
			throw null;
		}

		// Token: 0x060001CF RID: 463 RVA: 0x000053E6 File Offset: 0x000035E6
		[global::Cpp2ILInjected.Token(Token = "0x60001DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5A738", Offset = "0x1A5A738", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void OnSaveEvent(ZipProgressEventType eventFlavor)
		{
			throw null;
		}

		// Token: 0x060001D0 RID: 464 RVA: 0x000053E9 File Offset: 0x000035E9
		[global::Cpp2ILInjected.Token(Token = "0x60001DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5A80C", Offset = "0x1A5A80C", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveProgressEventArgs), Member = "Started", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SaveProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnSaveStarted()
		{
			throw null;
		}

		// Token: 0x060001D1 RID: 465 RVA: 0x000053EC File Offset: 0x000035EC
		[global::Cpp2ILInjected.Token(Token = "0x60001DC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5A8A0", Offset = "0x1A5A8A0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SaveProgressEventArgs), Member = "Completed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(SaveProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnSaveCompleted()
		{
			throw null;
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060001D2 RID: 466 RVA: 0x000053EF File Offset: 0x000035EF
		// (remove) Token: 0x060001D3 RID: 467 RVA: 0x000053F2 File Offset: 0x000035F2
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		public event EventHandler<ReadProgressEventArgs> ReadProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5A92C", Offset = "0x1A5A92C", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
			{
				typeof(Stream),
				typeof(TextWriter),
				typeof(Encoding),
				typeof(EventHandler<ReadProgressEventArgs>)
			}, ReturnType = typeof(ZipFile))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5A9E0", Offset = "0x1A5A9E0", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060001D4 RID: 468 RVA: 0x000053F5 File Offset: 0x000035F5
		[global::Cpp2ILInjected.Token(Token = "0x60001DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5AA94", Offset = "0x1A5AA94", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadProgressEventArgs), Member = "Started", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnReadStarted()
		{
			throw null;
		}

		// Token: 0x060001D5 RID: 469 RVA: 0x000053F8 File Offset: 0x000035F8
		[global::Cpp2ILInjected.Token(Token = "0x60001E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5AB20", Offset = "0x1A5AB20", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadProgressEventArgs), Member = "Completed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnReadCompleted()
		{
			throw null;
		}

		// Token: 0x060001D6 RID: 470 RVA: 0x000053FB File Offset: 0x000035FB
		[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4EA54", Offset = "0x1A4EA54", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Encoding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(bool)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_LengthOfReadStream", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadProgressEventArgs), Member = "ByteUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void OnReadBytes(ZipEntry entry)
		{
			throw null;
		}

		// Token: 0x060001D7 RID: 471 RVA: 0x000053FE File Offset: 0x000035FE
		[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4ECAC", Offset = "0x1A4ECAC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(bool)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadProgressEventArgs), Member = "Before", MemberParameters = new object[]
		{
			typeof(string),
			typeof(int)
		}, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadProgressEventArgs), Member = "After", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(int)
		}, ReturnType = typeof(ReadProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal void OnReadEntry(bool before, ZipEntry entry)
		{
			throw null;
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x060001D8 RID: 472 RVA: 0x00005401 File Offset: 0x00003601
		[global::Cpp2ILInjected.Token(Token = "0x1700007C")]
		private long LengthOfReadStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5ABAC", Offset = "0x1A5ABAC", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "OnReadBytes", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "GetFileLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060001D9 RID: 473 RVA: 0x00005404 File Offset: 0x00003604
		// (remove) Token: 0x060001DA RID: 474 RVA: 0x00005407 File Offset: 0x00003607
		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		public event EventHandler<ExtractProgressEventArgs> ExtractProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5AC28", Offset = "0x1A5AC28", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5ACDC", Offset = "0x1A5ACDC", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060001DB RID: 475 RVA: 0x0000540A File Offset: 0x0000360A
		[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5AD90", Offset = "0x1A5AD90", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipProgressEventArgs), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipProgressEventType)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void OnExtractEntry(int current, bool before, ZipEntry currentEntry, string path)
		{
			throw null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x0000540D File Offset: 0x0000360D
		[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C858", Offset = "0x1A4C858", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "OnExtractProgress", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtractProgressEventArgs), Member = "ByteUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool OnExtractBlock(ZipEntry entry, long bytesWritten, long totalBytesToWrite)
		{
			throw null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00005410 File Offset: 0x00003610
		[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C94C", Offset = "0x1A4C94C", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "OnBeforeExtract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "OnAfterExtract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CheckExtractExistingFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtractProgressEventArgs), Member = "BeforeExtractEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtractProgressEventArgs), Member = "AfterExtractEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool OnSingleEntryExtract(ZipEntry entry, string path, bool before)
		{
			throw null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x00005413 File Offset: 0x00003613
		[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4CA64", Offset = "0x1A4CA64", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "OnExtractExisting", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CheckExtractExistingFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtractProgressEventArgs), Member = "ExtractExisting", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal bool OnExtractExisting(ZipEntry entry, string path)
		{
			throw null;
		}

		// Token: 0x060001DF RID: 479 RVA: 0x00005416 File Offset: 0x00003616
		[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5AEC0", Offset = "0x1A5AEC0", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtractProgressEventArgs), Member = "ExtractAllCompleted", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnExtractAllCompleted(string path)
		{
			throw null;
		}

		// Token: 0x060001E0 RID: 480 RVA: 0x00005419 File Offset: 0x00003619
		[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5AF54", Offset = "0x1A5AF54", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ExtractProgressEventArgs), Member = "ExtractAllStarted", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ExtractProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnExtractAllStarted(string path)
		{
			throw null;
		}

		// Token: 0x14000004 RID: 4
		// (add) Token: 0x060001E1 RID: 481 RVA: 0x0000541C File Offset: 0x0000361C
		// (remove) Token: 0x060001E2 RID: 482 RVA: 0x0000541F File Offset: 0x0000361F
		[global::Cpp2ILInjected.Token(Token = "0x14000004")]
		public event EventHandler<AddProgressEventArgs> AddProgress
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5AFE8", Offset = "0x1A5AFE8", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001ED")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5B09C", Offset = "0x1A5B09C", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060001E3 RID: 483 RVA: 0x00005422 File Offset: 0x00003622
		[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A55260", Offset = "0x1A55260", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AddProgressEventArgs), Member = "Started", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AddProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void OnAddStarted()
		{
			throw null;
		}

		// Token: 0x060001E4 RID: 484 RVA: 0x00005425 File Offset: 0x00003625
		[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A552F4", Offset = "0x1A552F4", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(bool),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateFiles", MemberParameters = new object[]
		{
			typeof(IEnumerable<string>),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AddProgressEventArgs), Member = "Completed", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(AddProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void OnAddCompleted()
		{
			throw null;
		}

		// Token: 0x060001E5 RID: 485 RVA: 0x00005428 File Offset: 0x00003628
		[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5598C", Offset = "0x1A5598C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddDirectoryByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AddProgressEventArgs), Member = "AfterEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(int)
		}, ReturnType = typeof(AddProgressEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void AfterAddEntry(ZipEntry entry)
		{
			throw null;
		}

		// Token: 0x14000005 RID: 5
		// (add) Token: 0x060001E6 RID: 486 RVA: 0x0000542B File Offset: 0x0000362B
		// (remove) Token: 0x060001E7 RID: 487 RVA: 0x0000542E File Offset: 0x0000362E
		[global::Cpp2ILInjected.Token(Token = "0x14000005")]
		public event EventHandler<ZipErrorEventArgs> ZipError
		{
			[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5B150", Offset = "0x1A5B150", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60001F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5B204", Offset = "0x1A5B204", Length = "0xB4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x060001E8 RID: 488 RVA: 0x00005431 File Offset: 0x00003631
		[global::Cpp2ILInjected.Token(Token = "0x60001F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A52784", Offset = "0x1A52784", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "OnZipErrorWhileSaving", MemberParameters = new object[] { typeof(Exception) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipErrorEventArgs), Member = "Saving", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry),
			typeof(Exception)
		}, ReturnType = typeof(ZipErrorEventArgs))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal bool OnZipErrorSaving(ZipEntry entry, Exception exc)
		{
			throw null;
		}

		// Token: 0x060001E9 RID: 489 RVA: 0x00005434 File Offset: 0x00003634
		[global::Cpp2ILInjected.Token(Token = "0x60001F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5B2B8", Offset = "0x1A5B2B8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ExtractAll(string path)
		{
			throw null;
		}

		// Token: 0x060001EA RID: 490 RVA: 0x00005437 File Offset: 0x00003637
		[global::Cpp2ILInjected.Token(Token = "0x60001F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5BBF8", Offset = "0x1A5BBF8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public void ExtractAll(string path, ExtractExistingFileAction extractExistingFile)
		{
			throw null;
		}

		// Token: 0x060001EB RID: 491 RVA: 0x0000543A File Offset: 0x0000363A
		[global::Cpp2ILInjected.Token(Token = "0x60001F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5B2C0", Offset = "0x1A5B2C0", Length = "0x938")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ExtractExistingFileAction)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnExtractAllStarted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "CreateString", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnExtractEntry", MemberParameters = new object[]
		{
			typeof(int),
			typeof(bool),
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "_SetTimes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnExtractAllCompleted", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 70)]
		private void _InternalExtractAll(string path, bool overrideExtractExistingProperty)
		{
			throw null;
		}

		// Token: 0x060001EC RID: 492 RVA: 0x0000543D File Offset: 0x0000363D
		[global::Cpp2ILInjected.Token(Token = "0x60001F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A57200", Offset = "0x1A57200", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(IServiceProvider),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.ZipContentSource", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(TextWriter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZipPassword", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ZipFile Read(string fileName)
		{
			throw null;
		}

		// Token: 0x060001ED RID: 493 RVA: 0x00005440 File Offset: 0x00003640
		[global::Cpp2ILInjected.Token(Token = "0x60001F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5BD38", Offset = "0x1A5BD38", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ZipFile Read(string fileName, ReadOptions options)
		{
			throw null;
		}

		// Token: 0x060001EE RID: 494 RVA: 0x00005443 File Offset: 0x00003643
		[global::Cpp2ILInjected.Token(Token = "0x60001F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5BC08", Offset = "0x1A5BC08", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ReadOptions)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static ZipFile Read(string fileName, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			throw null;
		}

		// Token: 0x060001EF RID: 495 RVA: 0x00005446 File Offset: 0x00003646
		[global::Cpp2ILInjected.Token(Token = "0x60001FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5BDF8", Offset = "0x1A5BDF8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ZipFile Read(Stream zipStream)
		{
			throw null;
		}

		// Token: 0x060001F0 RID: 496 RVA: 0x00005449 File Offset: 0x00003649
		[global::Cpp2ILInjected.Token(Token = "0x60001FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5C018", Offset = "0x1A5C018", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public static ZipFile Read(Stream zipStream, ReadOptions options)
		{
			throw null;
		}

		// Token: 0x060001F1 RID: 497 RVA: 0x0000544C File Offset: 0x0000364C
		[global::Cpp2ILInjected.Token(Token = "0x60001FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5BE58", Offset = "0x1A5BE58", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ReadOptions)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "IsZipFile", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "add_ReadProgress", MemberParameters = new object[] { typeof(EventHandler<ReadProgressEventArgs>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OffsetStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private static ZipFile Read(Stream zipStream, TextWriter statusMessageWriter, Encoding encoding, EventHandler<ReadProgressEventArgs> readProgress)
		{
			throw null;
		}

		// Token: 0x060001F2 RID: 498 RVA: 0x0000544F File Offset: 0x0000364F
		[global::Cpp2ILInjected.Token(Token = "0x60001FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A58B08", Offset = "0x1A58B08", Length = "0x498")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnReadStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadFirstFourBytes", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Max", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "FindSignature", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Zip64SeekToCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		private static void ReadIntoInstance(ZipFile zf)
		{
			throw null;
		}

		// Token: 0x060001F3 RID: 499 RVA: 0x00005452 File Offset: 0x00003652
		[global::Cpp2ILInjected.Token(Token = "0x60001FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5C12C", Offset = "0x1A5C12C", Length = "0x290")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "ReadInt", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		private static void Zip64SeekToCentralDirectory(ZipFile zf)
		{
			throw null;
		}

		// Token: 0x060001F4 RID: 500 RVA: 0x00005455 File Offset: 0x00003655
		[global::Cpp2ILInjected.Token(Token = "0x60001FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5C0D8", Offset = "0x1A5C0D8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "ReadInt", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static uint ReadFirstFourBytes(Stream s)
		{
			throw null;
		}

		// Token: 0x060001F5 RID: 501 RVA: 0x00005458 File Offset: 0x00003658
		[global::Cpp2ILInjected.Token(Token = "0x6000200")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5C3BC", Offset = "0x1A5C3BC", Length = "0x2B4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
		{
			typeof(ZipFile),
			typeof(Dictionary<string, object>)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnReadEntry", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ZipEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadCentralDirectoryFooter", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnReadCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void ReadCentralDirectory(ZipFile zf)
		{
			throw null;
		}

		// Token: 0x060001F6 RID: 502 RVA: 0x0000545B File Offset: 0x0000365B
		[global::Cpp2ILInjected.Token(Token = "0x6000201")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A598B0", Offset = "0x1A598B0", Length = "0x3E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InitInstance", MemberParameters = new object[]
		{
			typeof(string),
			typeof(TextWriter)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnReadStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(bool)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
		{
			typeof(ZipFile),
			typeof(Dictionary<string, object>)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MarkAsDirectory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "ReadCentralDirectoryFooter", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnReadCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private static void ReadIntoInstance_Orig(ZipFile zf)
		{
			throw null;
		}

		// Token: 0x060001F7 RID: 503 RVA: 0x0000545E File Offset: 0x0000365E
		[global::Cpp2ILInjected.Token(Token = "0x6000202")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5C670", Offset = "0x1A5C670", Length = "0x3C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "ReadSignature", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		private static void ReadCentralDirectoryFooter(ZipFile zf)
		{
			throw null;
		}

		// Token: 0x060001F8 RID: 504 RVA: 0x00005461 File Offset: 0x00003661
		[global::Cpp2ILInjected.Token(Token = "0x6000203")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5CA38", Offset = "0x1A5CA38", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static void ReadZipFileComment(ZipFile zf)
		{
			throw null;
		}

		// Token: 0x060001F9 RID: 505 RVA: 0x00005464 File Offset: 0x00003664
		[global::Cpp2ILInjected.Token(Token = "0x6000204")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4463C", Offset = "0x1A4463C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "IsZipFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool IsZipFile(string fileName)
		{
			throw null;
		}

		// Token: 0x060001FA RID: 506 RVA: 0x00005467 File Offset: 0x00003667
		[global::Cpp2ILInjected.Token(Token = "0x6000205")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A446EC", Offset = "0x1A446EC", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "IsZipFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "IsZipFile", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public static bool IsZipFile(string fileName, bool testExtract)
		{
			throw null;
		}

		// Token: 0x060001FB RID: 507 RVA: 0x0000546A File Offset: 0x0000366A
		[global::Cpp2ILInjected.Token(Token = "0x6000206")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5CB20", Offset = "0x1A5CB20", Length = "0x500")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "IsZipFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Read", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(TextWriter),
			typeof(Encoding),
			typeof(EventHandler<ReadProgressEventArgs>)
		}, ReturnType = typeof(ZipFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<ZipEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 37)]
		public static bool IsZipFile(Stream stream, bool testExtract)
		{
			throw null;
		}

		// Token: 0x060001FC RID: 508 RVA: 0x0000546D File Offset: 0x0000366D
		[global::Cpp2ILInjected.Token(Token = "0x6000207")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5D020", Offset = "0x1A5D020", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "Sleep", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void DeleteFileWithRetry(string filename)
		{
			throw null;
		}

		// Token: 0x060001FD RID: 509 RVA: 0x00005470 File Offset: 0x00003670
		[global::Cpp2ILInjected.Token(Token = "0x6000208")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5D124", Offset = "0x1A5D124", Length = "0xCBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSaveStarted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_WriteStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_EntriesSorted", ReturnType = typeof(ICollection<ZipEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSaveCompleted", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_Entries", ReturnType = typeof(ICollection<ZipEntry>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSaveEntry", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ZipEntry),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipOutput), Member = "WriteCentralDirectoryStructure", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ICollection<ZipEntry>),
			typeof(uint),
			typeof(Zip64Option),
			typeof(string),
			typeof(ZipContainer)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSaveEvent", MemberParameters = new object[] { typeof(ZipProgressEventType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "GenerateRandomStringImpl", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "DeleteFileWithRetry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Move", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "NotifyEntriesSaveComplete", MemberParameters = new object[] { typeof(ICollection<ZipEntry>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "CleanupAfterSaveOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 65)]
		public void Save()
		{
			throw null;
		}

		// Token: 0x060001FE RID: 510 RVA: 0x00005473 File Offset: 0x00003673
		[global::Cpp2ILInjected.Token(Token = "0x6000209")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5DDE0", Offset = "0x1A5DDE0", Length = "0x2C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private static void NotifyEntriesSaveComplete(ICollection<ZipEntry> c)
		{
			throw null;
		}

		// Token: 0x060001FF RID: 511 RVA: 0x00005476 File Offset: 0x00003676
		[global::Cpp2ILInjected.Token(Token = "0x600020A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5E0A8", Offset = "0x1A5E0A8", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CleanupAfterSaveOperation", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void RemoveTempFile()
		{
			throw null;
		}

		// Token: 0x06000200 RID: 512 RVA: 0x00005479 File Offset: 0x00003679
		[global::Cpp2ILInjected.Token(Token = "0x600020B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5E19C", Offset = "0x1A5E19C", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveTempFile", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private void CleanupAfterSaveOperation()
		{
			throw null;
		}

		// Token: 0x06000201 RID: 513 RVA: 0x0000547C File Offset: 0x0000367C
		[global::Cpp2ILInjected.Token(Token = "0x600020C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5732C", Offset = "0x1A5732C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(TextWriter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "FixZipDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Save(string fileName)
		{
			throw null;
		}

		// Token: 0x06000202 RID: 514 RVA: 0x0000547F File Offset: 0x0000367F
		[global::Cpp2ILInjected.Token(Token = "0x600020D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5E25C", Offset = "0x1A5E25C", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void Save(Stream outputStream)
		{
			throw null;
		}

		// Token: 0x06000203 RID: 515 RVA: 0x00005482 File Offset: 0x00003682
		[global::Cpp2ILInjected.Token(Token = "0x600020E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A57260", Offset = "0x1A57260", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZip", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(TextWriter)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZipPassword", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "get_InputUsesZip64", ReturnType = typeof(bool?))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "IsZipFile", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "System.Collections.IEnumerable.GetEnumerator", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "GetNewEnum", ReturnType = typeof(IEnumerator))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile.<GetEnumerator>d__3), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public IEnumerator<ZipEntry> GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x00005485 File Offset: 0x00003685
		[global::Cpp2ILInjected.Token(Token = "0x600020F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5E374", Offset = "0x1A5E374", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<ZipEntry>))]
		private IEnumerator System.Collections.IEnumerable.GetEnumerator()
		{
			throw null;
		}

		// Token: 0x06000205 RID: 517 RVA: 0x00005488 File Offset: 0x00003688
		[DispId(-4)]
		[global::Cpp2ILInjected.Token(Token = "0x6000210")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5E378", Offset = "0x1A5E378", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<ZipEntry>))]
		public IEnumerator GetNewEnum()
		{
			throw null;
		}

		// Token: 0x06000206 RID: 518 RVA: 0x0000548B File Offset: 0x0000368B
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000211")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5E37C", Offset = "0x1A5E37C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		static ZipFile()
		{
			throw null;
		}

		// Token: 0x040000B3 RID: 179
		[global::Cpp2ILInjected.Token(Token = "0x40000BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TextWriter _StatusMessageTextWriter;

		// Token: 0x040000B4 RID: 180
		[global::Cpp2ILInjected.Token(Token = "0x40000BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool _CaseSensitiveRetrieval;

		// Token: 0x040000B5 RID: 181
		[global::Cpp2ILInjected.Token(Token = "0x40000BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private Stream _readstream;

		// Token: 0x040000B6 RID: 182
		[global::Cpp2ILInjected.Token(Token = "0x40000C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private Stream _writestream;

		// Token: 0x040000B7 RID: 183
		[global::Cpp2ILInjected.Token(Token = "0x40000C1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ushort _versionMadeBy;

		// Token: 0x040000B8 RID: 184
		[global::Cpp2ILInjected.Token(Token = "0x40000C2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x32")]
		private ushort _versionNeededToExtract;

		// Token: 0x040000B9 RID: 185
		[global::Cpp2ILInjected.Token(Token = "0x40000C3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private uint _diskNumberWithCd;

		// Token: 0x040000BA RID: 186
		[global::Cpp2ILInjected.Token(Token = "0x40000C4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _maxOutputSegmentSize;

		// Token: 0x040000BB RID: 187
		[global::Cpp2ILInjected.Token(Token = "0x40000C5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private uint _numberOfSegmentsForMostRecentSave;

		// Token: 0x040000BC RID: 188
		[global::Cpp2ILInjected.Token(Token = "0x40000C6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private ZipErrorAction _zipErrorAction;

		// Token: 0x040000BD RID: 189
		[global::Cpp2ILInjected.Token(Token = "0x40000C7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private bool _disposed;

		// Token: 0x040000BE RID: 190
		[global::Cpp2ILInjected.Token(Token = "0x40000C8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private Dictionary<string, ZipEntry> _entries;

		// Token: 0x040000BF RID: 191
		[global::Cpp2ILInjected.Token(Token = "0x40000C9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private List<ZipEntry> _zipEntriesAsList;

		// Token: 0x040000C0 RID: 192
		[global::Cpp2ILInjected.Token(Token = "0x40000CA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private string _name;

		// Token: 0x040000C1 RID: 193
		[global::Cpp2ILInjected.Token(Token = "0x40000CB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string _readName;

		// Token: 0x040000C2 RID: 194
		[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private string _Comment;

		// Token: 0x040000C3 RID: 195
		[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		internal string _Password;

		// Token: 0x040000C4 RID: 196
		[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private bool _emitNtfsTimes;

		// Token: 0x040000C5 RID: 197
		[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x79")]
		private bool _emitUnixTimes;

		// Token: 0x040000C6 RID: 198
		[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x7C")]
		private CompressionStrategy _Strategy;

		// Token: 0x040000C7 RID: 199
		[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private CompressionMethod _compressionMethod;

		// Token: 0x040000C8 RID: 200
		[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x84")]
		private bool _fileAlreadyExists;

		// Token: 0x040000C9 RID: 201
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private string _temporaryFileName;

		// Token: 0x040000CA RID: 202
		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private bool _contentsChanged;

		// Token: 0x040000CB RID: 203
		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x91")]
		private bool _hasBeenSaved;

		// Token: 0x040000CC RID: 204
		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private string _TempFileFolder;

		// Token: 0x040000CD RID: 205
		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		private bool _ReadStreamIsOurs;

		// Token: 0x040000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private object LOCK;

		// Token: 0x040000CF RID: 207
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private bool _saveOperationCanceled;

		// Token: 0x040000D0 RID: 208
		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB1")]
		private bool _extractOperationCanceled;

		// Token: 0x040000D1 RID: 209
		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB2")]
		private bool _addOperationCanceled;

		// Token: 0x040000D2 RID: 210
		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB4")]
		private EncryptionAlgorithm _Encryption;

		// Token: 0x040000D3 RID: 211
		[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private bool _JustSaved;

		// Token: 0x040000D4 RID: 212
		[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private long _locEndOfCDS;

		// Token: 0x040000D5 RID: 213
		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private uint _OffsetOfCentralDirectory;

		// Token: 0x040000D6 RID: 214
		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private long _OffsetOfCentralDirectory64;

		// Token: 0x040000D7 RID: 215
		[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private bool? _OutputUsesZip64;

		// Token: 0x040000D8 RID: 216
		[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xDA")]
		internal bool _inExtractAll;

		// Token: 0x040000D9 RID: 217
		[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private Encoding _alternateEncoding;

		// Token: 0x040000DA RID: 218
		[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private ZipOption _alternateEncodingUsage;

		// Token: 0x040000DB RID: 219
		[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
		private static Encoding _defaultEncoding;

		// Token: 0x040000DC RID: 220
		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xEC")]
		private int _BufferSize;

		// Token: 0x040000DD RID: 221
		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		internal Zip64Option _zip64;

		// Token: 0x040000DE RID: 222
		[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF4")]
		private bool _SavingSfx;

		// Token: 0x040000DF RID: 223
		[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
		public static readonly int BufferSizeDefault;

		// Token: 0x040000E0 RID: 224
		[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private EventHandler<SaveProgressEventArgs> SaveProgress;

		// Token: 0x040000E1 RID: 225
		[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private EventHandler<ReadProgressEventArgs> ReadProgress;

		// Token: 0x040000E2 RID: 226
		[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		private long _lengthOfReadStream;

		// Token: 0x040000E3 RID: 227
		[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		private EventHandler<ExtractProgressEventArgs> ExtractProgress;

		// Token: 0x040000E4 RID: 228
		[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		private EventHandler<AddProgressEventArgs> AddProgress;

		// Token: 0x040000E5 RID: 229
		[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		private EventHandler<ZipErrorEventArgs> ZipError;

		// Token: 0x040000E6 RID: 230
		[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		private bool <FullScan>k__BackingField;

		// Token: 0x040000E7 RID: 231
		[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x129")]
		private bool <SortEntriesBeforeSaving>k__BackingField;

		// Token: 0x040000E8 RID: 232
		[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12A")]
		private bool <AddDirectoryWillTraverseReparsePoints>k__BackingField;

		// Token: 0x040000E9 RID: 233
		[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12C")]
		private int <CodecBufferSize>k__BackingField;

		// Token: 0x040000EA RID: 234
		[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		private bool <FlattenFoldersOnExtract>k__BackingField;

		// Token: 0x040000EB RID: 235
		[global::Cpp2ILInjected.Token(Token = "0x40000F5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x134")]
		private CompressionLevel <CompressionLevel>k__BackingField;

		// Token: 0x040000EC RID: 236
		[global::Cpp2ILInjected.Token(Token = "0x40000F6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private ExtractExistingFileAction <ExtractExistingFile>k__BackingField;

		// Token: 0x040000ED RID: 237
		[global::Cpp2ILInjected.Token(Token = "0x40000F7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private SetCompressionCallback <SetCompression>k__BackingField;

		// Token: 0x0200005F RID: 95
		[global::Cpp2ILInjected.Token(Token = "0x2000028")]
		private sealed class <>c__DisplayClass1
		{
			// Token: 0x0600041C RID: 1052 RVA: 0x00005AC1 File Offset: 0x00003CC1
			[global::Cpp2ILInjected.Token(Token = "0x6000212")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E3F4", Offset = "0x1A5E3F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "get_EntriesSorted", ReturnType = typeof(ICollection<ZipEntry>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass1()
			{
				throw null;
			}

			// Token: 0x0600041D RID: 1053 RVA: 0x00005AC4 File Offset: 0x00003CC4
			[global::Cpp2ILInjected.Token(Token = "0x6000213")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E3FC", Offset = "0x1A5E3FC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Compare", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(StringComparison)
			}, ReturnType = typeof(int))]
			public int <get_EntriesSorted>b__0(ZipEntry x, ZipEntry y)
			{
				throw null;
			}

			// Token: 0x040002E8 RID: 744
			[global::Cpp2ILInjected.Token(Token = "0x40000F8")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public StringComparison sc;
		}

		// Token: 0x02000060 RID: 96
		[global::Cpp2ILInjected.Token(Token = "0x2000029")]
		private sealed class <GetEnumerator>d__3 : IEnumerator<ZipEntry>, IEnumerator, IDisposable
		{
			// Token: 0x0600041E RID: 1054 RVA: 0x00005AC7 File Offset: 0x00003CC7
			[global::Cpp2ILInjected.Token(Token = "0x6000214")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E414", Offset = "0x1A5E414", Length = "0x18C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Values", ReturnType = "ValueCollection<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile.<GetEnumerator>d__3), Member = "<>m__Finally6", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			private bool MoveNext()
			{
				throw null;
			}

			// Token: 0x170000FD RID: 253
			// (get) Token: 0x0600041F RID: 1055 RVA: 0x00005ACA File Offset: 0x00003CCA
			[global::Cpp2ILInjected.Token(Token = "0x1700007D")]
			private ZipEntry System.Collections.Generic.IEnumerator<Ionic.Zip.ZipEntry>.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000215")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A5E5F0", Offset = "0x1A5E5F0", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000420 RID: 1056 RVA: 0x00005ACD File Offset: 0x00003CCD
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000216")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E5F8", Offset = "0x1A5E5F8", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NotSupportedException), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private void System.Collections.IEnumerator.Reset()
			{
				throw null;
			}

			// Token: 0x06000421 RID: 1057 RVA: 0x00005AD0 File Offset: 0x00003CD0
			[global::Cpp2ILInjected.Token(Token = "0x6000217")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E630", Offset = "0x1A5E630", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile.<GetEnumerator>d__3), Member = "<>m__Finally6", ReturnType = typeof(void))]
			private void System.IDisposable.Dispose()
			{
				throw null;
			}

			// Token: 0x170000FE RID: 254
			// (get) Token: 0x06000422 RID: 1058 RVA: 0x00005AD3 File Offset: 0x00003CD3
			[global::Cpp2ILInjected.Token(Token = "0x1700007E")]
			private object System.Collections.IEnumerator.Current
			{
				[DebuggerHidden]
				[global::Cpp2ILInjected.Token(Token = "0x6000218")]
				[global::Cpp2ILInjected.Address(RVA = "0x1A5E648", Offset = "0x1A5E648", Length = "0x8")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				get
				{
					throw null;
				}
			}

			// Token: 0x06000423 RID: 1059 RVA: 0x00005AD6 File Offset: 0x00003CD6
			[DebuggerHidden]
			[global::Cpp2ILInjected.Token(Token = "0x6000219")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E650", Offset = "0x1A5E650", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "GetEnumerator", ReturnType = typeof(IEnumerator<ZipEntry>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <GetEnumerator>d__3(int <>1__state)
			{
				throw null;
			}

			// Token: 0x06000424 RID: 1060 RVA: 0x00005AD9 File Offset: 0x00003CD9
			[global::Cpp2ILInjected.Token(Token = "0x600021A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A5E5A0", Offset = "0x1A5E5A0", Length = "0x50")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile.<GetEnumerator>d__3), Member = "MoveNext", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile.<GetEnumerator>d__3), Member = "System.IDisposable.Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.ValueCollection.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private void <>m__Finally6()
			{
				throw null;
			}

			// Token: 0x040002E9 RID: 745
			[global::Cpp2ILInjected.Token(Token = "0x40000F9")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private ZipEntry <>2__current;

			// Token: 0x040002EA RID: 746
			[global::Cpp2ILInjected.Token(Token = "0x40000FA")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			private int <>1__state;

			// Token: 0x040002EB RID: 747
			[global::Cpp2ILInjected.Token(Token = "0x40000FB")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public ZipFile <>4__this;

			// Token: 0x040002EC RID: 748
			[global::Cpp2ILInjected.Token(Token = "0x40000FC")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public ZipEntry <e>5__4;

			// Token: 0x040002ED RID: 749
			[global::Cpp2ILInjected.Token(Token = "0x40000FD")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
			public Dictionary<string, ZipEntry>.ValueCollection.Enumerator <>7__wrap5;
		}
	}
}