﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Ionic.BZip2;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	[Guid("ebc25cf6-9120-4283-b972-0e5520d00004")]
	[ComVisible(true)]
	[global::Cpp2ILInjected.Token(Token = "0x200001D")]
	public class ZipEntry
	{
		[global::Cpp2ILInjected.Token(Token = "0x17000021")]
		internal bool AttributesIndicateDirectory
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A48410", Offset = "0x1A48410", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4842C", Offset = "0x1A4842C", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void ResetDirEntry()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		public string Info
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4843C", Offset = "0x1A4843C", Length = "0x6A4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "get_Info", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StringBuilder), Member = "Append", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(StringBuilder))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "PackedToDateTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 45)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A48AE0", Offset = "0x1A48AE0", Length = "0x69C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadCentralDirectory", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "ReadSignature", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "PackedToDateTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "Utf8StringFromBuffer", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry.CopyHelper), Member = "AppendCopyToFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MarkAsDirectory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ProcessExtraField", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(short)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 32)]
		internal static ZipEntry ReadDirEntry(ZipFile zf, Dictionary<string, object> previouslySeen)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A491CC", Offset = "0x1A491CC", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static bool IsNotValidZipDirEntrySig(int signature)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A491E0", Offset = "0x1A491E0", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
		{
			typeof(ZipFile),
			typeof(Dictionary<string, object>)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntrySource),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(bool)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public ZipEntry()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		public DateTime LastModified
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49814", Offset = "0x1A49814", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49820", Offset = "0x1A49820", Length = "0xE4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "SpecifyKind", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTimeKind)
			}, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "AdjustTime_Reverse", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		private int BufferSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49904", Offset = "0x1A49904", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_BufferSize", ReturnType = typeof(int))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public DateTime ModifiedTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49910", Offset = "0x1A49910", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49918", Offset = "0x1A49918", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		public DateTime AccessedTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49BE4", Offset = "0x1A49BE4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49BEC", Offset = "0x1A49BEC", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetEntryTimes", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public DateTime CreationTime
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C00", Offset = "0x1A49C00", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C08", Offset = "0x1A49C08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetEntryTimes", MemberParameters = new object[]
			{
				typeof(DateTime),
				typeof(DateTime),
				typeof(DateTime)
			}, ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A49928", Offset = "0x1A49928", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "set_AccessedTime", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "set_CreationTime", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OpenDelegate),
			typeof(CloseDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddDirectoryByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Kind", ReturnType = typeof(DateTimeKind))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void SetEntryTimes(DateTime created, DateTime accessed, DateTime modified)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C10", Offset = "0x1A49C10", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C18", Offset = "0x1A49C18", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public bool EmitTimesInUnixFormatWhenSaving
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C2C", Offset = "0x1A49C2C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C34", Offset = "0x1A49C34", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		public ZipEntryTimestamp Timestamp
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C48", Offset = "0x1A49C48", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public FileAttributes Attributes
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C50", Offset = "0x1A49C50", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C58", Offset = "0x1A49C58", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		internal string LocalFileName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C70", Offset = "0x1A49C70", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		public string FileName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C78", Offset = "0x1A49C78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49C80", Offset = "0x1A49C80", Length = "0x138")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "NameInArchive", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "InternalAddEntry", MemberParameters = new object[]
			{
				typeof(string),
				typeof(ZipEntry)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		public Stream InputStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49FE0", Offset = "0x1A49FE0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A49FE8", Offset = "0x1A49FE8", Length = "0x68")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		public bool InputStreamWasJitProvided
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A050", Offset = "0x1A4A050", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		public ZipEntrySource Source
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A058", Offset = "0x1A4A058", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		public short VersionNeeded
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A060", Offset = "0x1A4A060", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000032")]
		public string Comment
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A068", Offset = "0x1A4A068", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A070", Offset = "0x1A4A070", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000033")]
		public bool? RequiresZip64
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A080", Offset = "0x1A4A080", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000034")]
		public bool? OutputUsedZip64
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A08C", Offset = "0x1A4A08C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000035")]
		public short BitField
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A098", Offset = "0x1A4A098", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000036")]
		public CompressionMethod CompressionMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A0A0", Offset = "0x1A4A0A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A0A8", Offset = "0x1A4A0A8", Length = "0xBC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyMetaData", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000037")]
		public CompressionLevel CompressionLevel
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A164", Offset = "0x1A4A164", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A16C", Offset = "0x1A4A16C", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "MaybeUnsetCompressionMethodForWriting", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000038")]
		public long CompressedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A1CC", Offset = "0x1A4A1CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000039")]
		public long UncompressedSize
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A1D4", Offset = "0x1A4A1D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003A")]
		public double CompressionRatio
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A1DC", Offset = "0x1A4A1DC", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003B")]
		public int Crc
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A214", Offset = "0x1A4A214", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003C")]
		public bool IsDirectory
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A21C", Offset = "0x1A4A21C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003D")]
		public bool UsesEncryption
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A224", Offset = "0x1A4A224", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003E")]
		public EncryptionAlgorithm Encryption
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A234", Offset = "0x1A4A234", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A23C", Offset = "0x1A4A23C", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalAddEntry", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700003F")]
		public string Password
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A304", Offset = "0x1A4A304", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A2C0", Offset = "0x1A4A2C0", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000040")]
		internal bool IsChanged
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A30C", Offset = "0x1A4A30C", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000041")]
		public ExtractExistingFileAction ExtractExistingFile
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A31C", Offset = "0x1A4A31C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A324", Offset = "0x1A4A324", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000042")]
		public ZipErrorAction ZipErrorAction
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A32C", Offset = "0x1A4A32C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A334", Offset = "0x1A4A334", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000043")]
		public bool IncludedInMostRecentSave
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A33C", Offset = "0x1A4A33C", Length = "0x10")]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutput), Member = "CountEntries", MemberParameters = new object[] { typeof(ICollection<ZipEntry>) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000044")]
		public SetCompressionCallback SetCompression
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A34C", Offset = "0x1A4A34C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A354", Offset = "0x1A4A354", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x17000045")]
		public bool UseUnicodeAsNecessary
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A35C", Offset = "0x1A4A35C", Length = "0x6C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A3C8", Offset = "0x1A4A3C8", Length = "0xD0")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
			set
			{
				throw null;
			}
		}

		[Obsolete("This property is obsolete since v1.9.1.6. Use AlternateEncoding and AlternateEncodingUsage instead.", true)]
		[global::Cpp2ILInjected.Token(Token = "0x17000046")]
		public Encoding ProvisionalAlternateEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A498", Offset = "0x1A4A498", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A4A0", Offset = "0x1A4A4A0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000047")]
		public Encoding AlternateEncoding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A4A8", Offset = "0x1A4A4A8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A4B0", Offset = "0x1A4A4B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000048")]
		public ZipOption AlternateEncodingUsage
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A4B8", Offset = "0x1A4A4B8", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4A4C0", Offset = "0x1A4A4C0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A49DB8", Offset = "0x1A49DB8", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "set_FileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "UpdateFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "RemoveEntryForUpdate", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "RemoveEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "NormalizePathForUseInZipFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static string NameInArchive(string filename, string directoryPathInArchive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4A4C8", Offset = "0x1A4A4C8", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddDirectoryByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ZipEntry CreateFromNothing(string nameInArchive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4A9B4", Offset = "0x1A4A9B4", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddFile", MemberParameters = new object[]
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
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntrySource),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ZipEntry CreateFromFile(string filename, string nameInArchive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4AA20", Offset = "0x1A4AA20", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntrySource),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ZipEntry CreateForStream(string entryName, Stream s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4AA8C", Offset = "0x1A4AA8C", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WriteDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntrySource),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ZipEntry CreateForWriter(string entryName, WriteDelegate d)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4AAF8", Offset = "0x1A4AAF8", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddEntry", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OpenDelegate),
			typeof(CloseDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntrySource),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ZipEntry CreateForJitStreamProvider(string nameInArchive, OpenDelegate opener, CloseDelegate closer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4AB68", Offset = "0x1A4AB68", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "Create", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntrySource),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static ZipEntry CreateForZipOutputStream(string nameInArchive)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4A528", Offset = "0x1A4A528", Length = "0x48C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CreateFromFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CreateForStream", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CreateForWriter", MemberParameters = new object[]
		{
			typeof(string),
			typeof(WriteDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CreateForJitStreamProvider", MemberParameters = new object[]
		{
			typeof(string),
			typeof(OpenDelegate),
			typeof(CloseDelegate)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CreateForZipOutputStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "GetLastWriteTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToUniversalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "GetCreationTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "GetLastAccessTime", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCfFile), Member = "GetAttributes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFullPath", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "NormalizePathForUseInZipFile", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		private static ZipEntry Create(string nameInArchive, ZipEntrySource source, object arg1, object arg2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A495B4", Offset = "0x1A495B4", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
		{
			typeof(ZipFile),
			typeof(Dictionary<string, object>)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Encoding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddDirectoryByName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "AddOrUpdateDirectoryImpl", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(AddOrUpdateAction),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "PutNextEntry", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		internal void MarkAsDirectory()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000049")]
		public bool IsText
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000EB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4AC60", Offset = "0x1A4AC60", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000EC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4AC68", Offset = "0x1A4AC68", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4AC74", Offset = "0x1A4AC74", Length = "0x4C")]
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

		[global::Cpp2ILInjected.Token(Token = "0x1700004A")]
		internal Stream ArchiveStream
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000EE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4ACC0", Offset = "0x1A4ACC0", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetupCryptoForExtract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadExtraField", ReturnType = typeof(void))]
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
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "HandleUnexpectedDataDescriptor", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughOneEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithNoChange", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 44)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "StreamForDiskNumber", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(Stream))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4B390", Offset = "0x1A4B390", Length = "0x320")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "get_FileDataPosition", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "get_LengthOfHeader", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetupCryptoForExtract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughOneEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "GetLengthOfCryptoHeaderBytes", MemberParameters = new object[] { typeof(EncryptionAlgorithm) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadStateException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Exception)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private void SetFdpLoh()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4B6B0", Offset = "0x1A4B6B0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static int GetLengthOfCryptoHeaderBytes(EncryptionAlgorithm a)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004B")]
		internal long FileDataPosition
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4B70C", Offset = "0x1A4B70C", Length = "0x28")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004C")]
		private int LengthOfHeader
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4B734", Offset = "0x1A4B734", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4B758", Offset = "0x1A4B758", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Extract()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C058", Offset = "0x1A4C058", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Extract(ExtractExistingFileAction extractExistingFile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C0B8", Offset = "0x1A4C0B8", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.ZipContentSource", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void Extract(Stream stream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C0C8", Offset = "0x1A4C0C8", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void Extract(string baseDirectory)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C0D4", Offset = "0x1A4C0D4", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void Extract(string baseDirectory, ExtractExistingFileAction extractExistingFile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C0E4", Offset = "0x1A4C0E4", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ExtractWithPassword(string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C140", Offset = "0x1A4C140", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void ExtractWithPassword(string baseDirectory, string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C14C", Offset = "0x1A4C14C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void ExtractWithPassword(ExtractExistingFileAction extractExistingFile, string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C1B0", Offset = "0x1A4C1B0", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void ExtractWithPassword(string baseDirectory, ExtractExistingFileAction extractExistingFile, string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C1BC", Offset = "0x1A4C1BC", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		public void ExtractWithPassword(Stream stream, string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C1CC", Offset = "0x1A4C1CC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CrcCalculatorStream OpenReader()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C3F0", Offset = "0x1A4C3F0", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public CrcCalculatorStream OpenReader(string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60000FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C244", Offset = "0x1A4C244", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "OpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetInputAndFigureFileLength", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipInputStream), Member = "SetupStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipInputStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ValidateCompression", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ValidateEncryption", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetupCryptoForExtract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "GetExtractDecryptor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "GetExtractDecompressor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadStateException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal CrcCalculatorStream InternalOpenReader(string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000100")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C824", Offset = "0x1A4C824", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnExtractBlock", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(bool))]
		private void OnExtractProgress(long bytesWritten, long totalBytesToWrite)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000101")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C910", Offset = "0x1A4C910", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSingleEntryExtract", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		private void OnBeforeExtract(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000102")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4CA08", Offset = "0x1A4CA08", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSingleEntryExtract", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		private void OnAfterExtract(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000103")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4CA34", Offset = "0x1A4CA34", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnExtractExisting", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(bool))]
		private void OnExtractExisting(string path)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000104")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4CB14", Offset = "0x1A4CB14", Length = "0x2C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCfFile), Member = "GetAttributes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCfFile), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		private static void ReallyDelete(string fileName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000105")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4CBE4", Offset = "0x1A4CBE4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private void WriteStatus(string format, params object[] args)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000106")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4B7A8", Offset = "0x1A4B7A8", Length = "0x8B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Extract", MemberParameters = new object[] { typeof(ExtractExistingFileAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Extract", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Extract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Extract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ExtractExistingFileAction)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractWithPassword", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractWithPassword", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractWithPassword", MemberParameters = new object[]
		{
			typeof(ExtractExistingFileAction),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractWithPassword", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ExtractExistingFileAction),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractWithPassword", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "CheckZipPassword", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "IsZipFile", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "OnBeforeExtract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ValidateCompression", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ValidateEncryption", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ValidateOutput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSingleEntryExtract", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CheckExtractExistingFile", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetupCryptoForExtract", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetDirectoryName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "VerifyCrcAfterExtract", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Move", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "_SetTimes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReallyDelete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCfFile), Member = "SetAttributes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadStateException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 54)]
		private void InternalExtract(string baseDir, Stream outstream, string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000107")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4D4F8", Offset = "0x1A4D4F8", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipInputStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadCrcException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal void VerifyCrcAfterExtract(int actualCrc32)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000108")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4CE68", Offset = "0x1A4CE68", Length = "0x220")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnExtractExisting", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSingleEntryExtract", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private int CheckExtractExistingFile(string baseDir, string targetFileName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000109")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4DADC", Offset = "0x1A4DADC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private void _CheckRead(int nbytes)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4D088", Offset = "0x1A4D088", Length = "0x470")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_BufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "GetExtractDecryptor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "GetExtractDecompressor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "_CheckRead", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnExtractBlock", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = "get_Crc", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		private int ExtractOne(Stream output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C764", Offset = "0x1A4C764", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2InputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal Stream GetExtractDecompressor(Stream input2)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C6EC", Offset = "0x1A4C6EC", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ExtractOne", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCipherStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ZipCrypto),
			typeof(CryptoMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal Stream GetExtractDecryptor(Stream input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600010D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4D5CC", Offset = "0x1A4D5CC", Length = "0x3F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ValidateOutput", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(ref string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "_InternalExtractAll", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCfFile), Member = "SetTimes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTime),
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "AdjustTime_Reverse", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetCfFile), Member = "SetLastWriteTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 44)]
		internal void _SetTimes(string fileOrDirectory, bool isFile)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004D")]
		private string UnsupportedAlgorithm
		{
			[global::Cpp2ILInjected.Token(Token = "0x600010E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4DD88", Offset = "0x1A4DD88", Length = "0x264")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ValidateEncryption", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700004E")]
		private string UnsupportedCompressionMethod
		{
			[global::Cpp2ILInjected.Token(Token = "0x600010F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4DFEC", Offset = "0x1A4DFEC", Length = "0x1B8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ValidateCompression", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000110")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C518", Offset = "0x1A4C518", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_UnsupportedAlgorithm", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void ValidateEncryption()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000111")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C450", Offset = "0x1A4C450", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_UnsupportedCompressionMethod", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void ValidateCompression()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000112")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4C5C8", Offset = "0x1A4C5C8", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "ForRead", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void SetupCryptoForExtract(string password)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000113")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4CC1C", Offset = "0x1A4CC1C", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "InternalExtract", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Stream),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[] { typeof(char) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "StartsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "GetFileName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Path), Member = "Combine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "_SetTimes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private bool ValidateOutput(string basedir, Stream outstream, out string outFileName)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000114")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4E1A4", Offset = "0x1A4E1A4", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraFieldUnixTimes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ProcessExtraField", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(short)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void ReadExtraField()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000115")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4E350", Offset = "0x1A4E350", Length = "0x6F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(bool)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "ReadEntrySignature", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "PackedToDateTime", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MarkAsDirectory", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ProcessExtraField", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(short)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnReadBytes", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "FindSignature", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReadWeakEncryptionHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(byte[])
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static bool ReadHeader(ZipEntry ze, Encoding defaultEncoding)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000116")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A47BA4", Offset = "0x1A47BA4", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipCrypto), Member = "ForRead", MemberParameters = new object[]
		{
			typeof(string),
			typeof(ZipEntry)
		}, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Encoding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static int ReadWeakEncryptionHeader(Stream s, byte[] buffer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000117")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4EA40", Offset = "0x1A4EA40", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private static bool IsNotValidSig(int signature)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000118")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4EB14", Offset = "0x1A4EB14", Length = "0x198")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "ReadIntoInstance_Orig", MemberParameters = new object[] { typeof(ZipFile) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipInputStream), Member = "GetNextEntry", ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_ReadStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_AlternateEncoding", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnReadEntry", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ZipEntry)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "HandlePK00Prefix", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Encoding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "HandleUnexpectedDataDescriptor", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnReadBytes", MemberParameters = new object[] { typeof(ZipEntry) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static ZipEntry ReadEntry(ZipContainer zc, bool first)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000119")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4ED98", Offset = "0x1A4ED98", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(bool)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "ReadInt", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal static void HandlePK00Prefix(Stream s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600011A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4EE48", Offset = "0x1A4EE48", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadEntry", MemberParameters = new object[]
		{
			typeof(ZipContainer),
			typeof(bool)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "ReadInt", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		private static void HandleUnexpectedDataDescriptor(ZipEntry entry)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600011B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4EF68", Offset = "0x1A4EF68", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal static int FindExtraFieldSegment(byte[] extra, int offx, ushort targetHeaderId)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600011C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A49624", Offset = "0x1A49624", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
		{
			typeof(ZipFile),
			typeof(Dictionary<string, object>)
		}, ReturnType = typeof(ZipEntry))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadExtraField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadHeader", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Encoding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ProcessExtraFieldInfoZipTimes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ProcessExtraFieldWindowsTimes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ProcessExtraFieldZip64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ProcessExtraFieldUnixTimes", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int ProcessExtraField(Stream s, short extraFieldLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600011D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4F820", Offset = "0x1A4F820", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private int ProcessExtraFieldPkwareStrongEncryption(byte[] Buffer, int j)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600011E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4F63C", Offset = "0x1A4F63C", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraField", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(short)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry.Func<long>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private int ProcessExtraFieldZip64(byte[] buffer, int j, short dataSize, long posn)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600011F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4F454", Offset = "0x1A4F454", Length = "0x1E8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraField", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(short)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private int ProcessExtraFieldInfoZipTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000120")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4F1C0", Offset = "0x1A4F1C0", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraField", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(short)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry.Func<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_UtcNow", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ReadExtraField", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private int ProcessExtraFieldUnixTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000121")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4EFD0", Offset = "0x1A4EFD0", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ProcessExtraField", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(short)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt64", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "FromFileTimeUtc", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		private int ProcessExtraFieldWindowsTimes(byte[] buffer, int j, short dataSize, long posn)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000122")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4F864", Offset = "0x1A4F864", Length = "0x3DC")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Zip64", ReturnType = typeof(Zip64Option))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "GetEncodedFileNameBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ConstructExtraField", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal void WriteCentralDirectoryEntry(Stream s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000123")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4FF04", Offset = "0x1A4FF04", Length = "0x714")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteCentralDirectoryEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Zip64", ReturnType = typeof(Zip64Option))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToFileTime", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalSeconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		private byte[] ConstructExtraField(bool forCentralDirectory)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000124")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A50618", Offset = "0x1A50618", Length = "0x1E4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "GetEncodedFileNameBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IndexOf", MemberParameters = new object[]
		{
			typeof(char),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private string NormalizeFileName()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000125")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A4FC40", Offset = "0x1A4FC40", Length = "0x2C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteCentralDirectoryEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "NormalizeFileName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private byte[] GetEncodedFileNameBytes()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000126")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A507FC", Offset = "0x1A507FC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		private bool WantReadAgain()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000127")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5087C", Offset = "0x1A5087C", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "GetFileLength", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_CompressionLevel", MemberParameters = new object[] { typeof(CompressionLevel) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void MaybeUnsetCompressionMethodForWriting(int cycle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000128")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A50980", Offset = "0x1A50980", Length = "0x558")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "_InitiateCurrentEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Zip64", ReturnType = typeof(Zip64Option))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "GetEncodedFileNameBytes", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MaybeUnsetCompressionMethodForWriting", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetZip64Flags", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "DateTimeToPacked", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "ConstructExtraField", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "ComputeSegment", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		internal void WriteHeader(Stream s, int cycle)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000129")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A51030", Offset = "0x1A51030", Length = "0x1A0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteSecurityMetadata", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = "get_Crc", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "PrepSourceStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CRC32), Member = "GetCrc32", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private int FigureCrc32()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600012A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A511D0", Offset = "0x1A511D0", Length = "0x1A8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "FigureCrc32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "SetInputAndFigureFileLength", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long?), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(long?), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void PrepSourceStream()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600012B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A51378", Offset = "0x1A51378", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Reset", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "set_CompressionMethod", MemberParameters = new object[] { typeof(CompressionMethod) }, ReturnType = typeof(void))]
		internal void CopyMetaData(ZipEntry source)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600012C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A513FC", Offset = "0x1A513FC", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSaveBlock", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(bool))]
		private void OnWriteBlock(long bytesXferred, long totalBytesToXfer)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600012D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A514E8", Offset = "0x1A514E8", Length = "0x438")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetInputAndFigureFileLength", MemberParameters = new object[] { typeof(ref Stream) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MaybeApplyEncryption", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MaybeApplyCompression", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_BufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "ReadWithRetry", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = "get_TotalBytesSlurped", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSaveBlock", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "FinishOutputStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CountingStream),
			typeof(Stream),
			typeof(Stream),
			typeof(CrcCalculatorStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "PostProcessOutput", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		private void _WriteEntryData(Stream s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600012E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A51920", Offset = "0x1A51920", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Open", MemberParameters = new object[]
		{
			typeof(string),
			typeof(FileMode),
			typeof(FileAccess),
			typeof(FileShare)
		}, ReturnType = typeof(FileStream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "PrepSourceStream", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "InternalOpenReader", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(CrcCalculatorStream))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		private long SetInputAndFigureFileLength(ref Stream input)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600012F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A51CB0", Offset = "0x1A51CB0", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "_FinishCurrentEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = "get_TotalBytesSlurped", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = "get_Crc", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void FinishOutputStream(Stream s, CountingStream entryCounter, Stream encryptor, Stream compressor, CrcCalculatorStream output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000130")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A51DFC", Offset = "0x1A51DFC", Length = "0x858")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "_FinishCurrentEntry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetZip64Flags", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "ForUpdate", MemberParameters = new object[]
		{
			typeof(string),
			typeof(uint)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = "Adjust", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "GetBytes", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		internal void PostProcessOutput(Stream s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000131")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A50ED8", Offset = "0x1A50ED8", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "PostProcessOutput", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Zip64", ReturnType = typeof(Zip64Option))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private void SetZip64Flags()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000132")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A52660", Offset = "0x1A52660", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "_InitiateCurrentEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MaybeApplyEncryption", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "MaybeApplyCompression", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long)
		}, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CrcCalculatorStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		internal void PrepOutputStream(Stream s, long streamLength, out CountingStream outputCounter, out Stream encryptor, out Stream compressor, out CrcCalculatorStream output)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000133")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A51B98", Offset = "0x1A51B98", Length = "0x118")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "PrepOutputStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(ref CountingStream),
			typeof(ref Stream),
			typeof(ref Stream),
			typeof(ref CrcCalculatorStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(CompressionLevel),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_CodecBufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = "set_BufferSize", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Strategy", ReturnType = typeof(CompressionStrategy))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStream), Member = "set_Strategy", MemberParameters = new object[] { typeof(CompressionStrategy) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BZip2OutputStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private Stream MaybeApplyCompression(Stream s, long streamLength)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000134")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A51B20", Offset = "0x1A51B20", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "PrepOutputStream", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(long),
			typeof(ref CountingStream),
			typeof(ref Stream),
			typeof(ref Stream),
			typeof(ref CrcCalculatorStream)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCipherStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(ZipCrypto),
			typeof(CryptoMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private Stream MaybeApplyEncryption(Stream s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000135")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A52754", Offset = "0x1A52754", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnZipErrorSaving", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		private void OnZipErrorWhileSaving(Exception e)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000136")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5287C", Offset = "0x1A5287C", Length = "0x574")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipFile), Member = "Save", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Zip64", ReturnType = typeof(Zip64Option))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "WriteSecurityMetadata", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "_WriteEntryData", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "WantReadAgain", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipSegmentedStream), Member = "TruncateBackward", MemberParameters = new object[]
		{
			typeof(uint),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = "Adjust", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CopyThroughOneEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnZipErrorSaving", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(Exception)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		internal void Write(Stream s)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000137")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A52654", Offset = "0x1A52654", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "_InitiateCurrentEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal void StoreRelativeOffset()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000138")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A5319C", Offset = "0x1A5319C", Length = "0x20")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal void NotifySaveComplete()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000139")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A53014", Offset = "0x1A53014", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipOutputStream), Member = "_InitiateCurrentEntry", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Password", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "ForWrite", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(ZipCrypto))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Random), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "FigureCrc32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "ToLocalTime", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SharedUtilities), Member = "DateTimeToPacked", MemberParameters = new object[] { typeof(DateTime) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipCrypto), Member = "EncryptMessage", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal void WriteSecurityMetadata(Stream outstream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600013A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A52DF0", Offset = "0x1A52DF0", Length = "0x224")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "Write", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CopyThroughWithRecompute", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_UseZip64WhenSaving", ReturnType = typeof(Zip64Option))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "CopyThroughWithNoChange", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = ".ctor", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_Zip64", ReturnType = typeof(Zip64Option))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Nullable<>), Member = "get_Value", ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadStateException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void CopyThroughOneEntry(Stream outStream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600013B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A531BC", Offset = "0x1A531BC", Length = "0x440")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughOneEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_BufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "SetFdpLoh", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "WriteHeader", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "EndsWith", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "GetLengthOfCryptoHeaderBytes", MemberParameters = new object[] { typeof(EncryptionAlgorithm) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSaveBlock", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_UseZip64WhenSaving", ReturnType = typeof(Zip64Option))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		private void CopyThroughWithRecompute(Stream outstream)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600013C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A535FC", Offset = "0x1A535FC", Length = "0x1C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "CopyThroughOneEntry", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipContainer), Member = "get_BufferSize", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipEntry), Member = "get_ArchiveStream", ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CountingStream), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ZipFile), Member = "OnSaveBlock", MemberParameters = new object[]
		{
			typeof(ZipEntry),
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void CopyThroughWithNoChange(Stream outstream)
		{
			throw null;
		}

		[Conditional("Trace")]
		[global::Cpp2ILInjected.Token(Token = "0x600013D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A537C0", Offset = "0x1A537C0", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Thread), Member = "get_CurrentThread", ReturnType = typeof(Thread))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "Write", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Console), Member = "WriteLine", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private void TraceWriteLine(string format, params object[] varParams)
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600013E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1A53920", Offset = "0x1A53920", Length = "0x124")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "GetEncoding", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(int),
			typeof(DateTimeKind)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "FromFileTimeUtc", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static ZipEntry()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400004C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private short _VersionMadeBy;

		[global::Cpp2ILInjected.Token(Token = "0x400004D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x12")]
		private short _InternalFileAttrs;

		[global::Cpp2ILInjected.Token(Token = "0x400004E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int _ExternalFileAttrs;

		[global::Cpp2ILInjected.Token(Token = "0x400004F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private short _filenameLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000050")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A")]
		private short _extraFieldLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000051")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1C")]
		private short _commentLength;

		[global::Cpp2ILInjected.Token(Token = "0x4000052")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private ZipCrypto _zipCrypto_forExtract;

		[global::Cpp2ILInjected.Token(Token = "0x4000053")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ZipCrypto _zipCrypto_forWrite;

		[global::Cpp2ILInjected.Token(Token = "0x4000054")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal DateTime _LastModified;

		[global::Cpp2ILInjected.Token(Token = "0x4000055")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private DateTime _Mtime;

		[global::Cpp2ILInjected.Token(Token = "0x4000056")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private DateTime _Atime;

		[global::Cpp2ILInjected.Token(Token = "0x4000057")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private DateTime _Ctime;

		[global::Cpp2ILInjected.Token(Token = "0x4000058")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private bool _ntfsTimesAreSet;

		[global::Cpp2ILInjected.Token(Token = "0x4000059")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x51")]
		private bool _emitNtfsTimes;

		[global::Cpp2ILInjected.Token(Token = "0x400005A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x52")]
		private bool _emitUnixTimes;

		[global::Cpp2ILInjected.Token(Token = "0x400005B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x53")]
		private bool _TrimVolumeFromFullyQualifiedPaths;

		[global::Cpp2ILInjected.Token(Token = "0x400005C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		internal string _LocalFileName;

		[global::Cpp2ILInjected.Token(Token = "0x400005D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private string _FileNameInArchive;

		[global::Cpp2ILInjected.Token(Token = "0x400005E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		internal short _VersionNeeded;

		[global::Cpp2ILInjected.Token(Token = "0x400005F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6A")]
		internal short _BitField;

		[global::Cpp2ILInjected.Token(Token = "0x4000060")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6C")]
		internal short _CompressionMethod;

		[global::Cpp2ILInjected.Token(Token = "0x4000061")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x6E")]
		private short _CompressionMethod_FromZipFile;

		[global::Cpp2ILInjected.Token(Token = "0x4000062")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private CompressionLevel _CompressionLevel;

		[global::Cpp2ILInjected.Token(Token = "0x4000063")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		internal string _Comment;

		[global::Cpp2ILInjected.Token(Token = "0x4000064")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private bool _IsDirectory;

		[global::Cpp2ILInjected.Token(Token = "0x4000065")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private byte[] _CommentBytes;

		[global::Cpp2ILInjected.Token(Token = "0x4000066")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal long _CompressedSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000067")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		internal long _CompressedFileDataSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000068")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		internal long _UncompressedSize;

		[global::Cpp2ILInjected.Token(Token = "0x4000069")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		internal int _TimeBlob;

		[global::Cpp2ILInjected.Token(Token = "0x400006A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xAC")]
		private bool _crcCalculated;

		[global::Cpp2ILInjected.Token(Token = "0x400006B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		internal int _Crc32;

		[global::Cpp2ILInjected.Token(Token = "0x400006C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		internal byte[] _Extra;

		[global::Cpp2ILInjected.Token(Token = "0x400006D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private bool _metadataChanged;

		[global::Cpp2ILInjected.Token(Token = "0x400006E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC1")]
		private bool _restreamRequiredOnSave;

		[global::Cpp2ILInjected.Token(Token = "0x400006F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC2")]
		private bool _sourceIsEncrypted;

		[global::Cpp2ILInjected.Token(Token = "0x4000070")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC3")]
		private bool _skippedDuringSave;

		[global::Cpp2ILInjected.Token(Token = "0x4000071")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC4")]
		private uint _diskNumber;

		[global::Cpp2ILInjected.Token(Token = "0x4000072")]
		private static Encoding ibm437;

		[global::Cpp2ILInjected.Token(Token = "0x4000073")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private Encoding _actualEncoding;

		[global::Cpp2ILInjected.Token(Token = "0x4000074")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		internal ZipContainer _container;

		[global::Cpp2ILInjected.Token(Token = "0x4000075")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private long __FileDataPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4000076")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private byte[] _EntryHeader;

		[global::Cpp2ILInjected.Token(Token = "0x4000077")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		internal long _RelativeOffsetOfLocalHeader;

		[global::Cpp2ILInjected.Token(Token = "0x4000078")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private long _future_ROLH;

		[global::Cpp2ILInjected.Token(Token = "0x4000079")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private long _TotalEntrySize;

		[global::Cpp2ILInjected.Token(Token = "0x400007A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x100")]
		private int _LengthOfHeader;

		[global::Cpp2ILInjected.Token(Token = "0x400007B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x104")]
		private int _LengthOfTrailer;

		[global::Cpp2ILInjected.Token(Token = "0x400007C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x108")]
		internal bool _InputUsesZip64;

		[global::Cpp2ILInjected.Token(Token = "0x400007D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10C")]
		private uint _UnsupportedAlgorithmId;

		[global::Cpp2ILInjected.Token(Token = "0x400007E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x110")]
		internal string _Password;

		[global::Cpp2ILInjected.Token(Token = "0x400007F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x118")]
		internal ZipEntrySource _Source;

		[global::Cpp2ILInjected.Token(Token = "0x4000080")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x11C")]
		internal EncryptionAlgorithm _Encryption;

		[global::Cpp2ILInjected.Token(Token = "0x4000081")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x120")]
		internal EncryptionAlgorithm _Encryption_FromZipFile;

		[global::Cpp2ILInjected.Token(Token = "0x4000082")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x128")]
		internal byte[] _WeakEncryptionHeader;

		[global::Cpp2ILInjected.Token(Token = "0x4000083")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x130")]
		internal Stream _archiveStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000084")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x138")]
		private Stream _sourceStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000085")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x140")]
		private long? _sourceStreamOriginalPosition;

		[global::Cpp2ILInjected.Token(Token = "0x4000086")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x150")]
		private bool _sourceWasJitProvided;

		[global::Cpp2ILInjected.Token(Token = "0x4000087")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x151")]
		private bool _ioOperationCanceled;

		[global::Cpp2ILInjected.Token(Token = "0x4000088")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x152")]
		private bool _presumeZip64;

		[global::Cpp2ILInjected.Token(Token = "0x4000089")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x153")]
		private bool? _entryRequiresZip64;

		[global::Cpp2ILInjected.Token(Token = "0x400008A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x155")]
		private bool? _OutputUsesZip64;

		[global::Cpp2ILInjected.Token(Token = "0x400008B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x157")]
		private bool _IsText;

		[global::Cpp2ILInjected.Token(Token = "0x400008C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x158")]
		private ZipEntryTimestamp _timestamp;

		[global::Cpp2ILInjected.Token(Token = "0x400008D")]
		private static DateTime _unixEpoch;

		[global::Cpp2ILInjected.Token(Token = "0x400008E")]
		private static DateTime _win32Epoch;

		[global::Cpp2ILInjected.Token(Token = "0x400008F")]
		private static DateTime _zeroHour;

		[global::Cpp2ILInjected.Token(Token = "0x4000090")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x160")]
		private WriteDelegate _WriteDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x4000091")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x168")]
		private OpenDelegate _OpenDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x4000092")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x170")]
		private CloseDelegate _CloseDelegate;

		[global::Cpp2ILInjected.Token(Token = "0x4000093")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x178")]
		private Stream _inputDecryptorStream;

		[global::Cpp2ILInjected.Token(Token = "0x4000094")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x180")]
		private int _readExtraDepth;

		[global::Cpp2ILInjected.Token(Token = "0x4000095")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x188")]
		private object _outputLock;

		[global::Cpp2ILInjected.Token(Token = "0x4000096")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x190")]
		private ExtractExistingFileAction <ExtractExistingFile>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000097")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x194")]
		private ZipErrorAction <ZipErrorAction>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000098")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x198")]
		private SetCompressionCallback <SetCompression>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x4000099")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A0")]
		private Encoding <ProvisionalAlternateEncoding>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x400009A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1A8")]
		private Encoding <AlternateEncoding>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x400009B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x1B0")]
		private ZipOption <AlternateEncodingUsage>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x200001E")]
		private class CopyHelper
		{
			[global::Cpp2ILInjected.Token(Token = "0x600013F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4929C", Offset = "0x1A4929C", Length = "0x318")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ZipEntry), Member = "ReadDirEntry", MemberParameters = new object[]
			{
				typeof(ZipFile),
				typeof(Dictionary<string, object>)
			}, ReturnType = typeof(ZipEntry))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "LastIndexOf", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[]
			{
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Match))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Group), Member = "get_Success", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(Group))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "get_Value", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "Parse", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OverflowException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
			internal static string AppendCopyToFileName(string f)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000140")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A53A44", Offset = "0x1A53A44", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public CopyHelper()
			{
				throw null;
			}

			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000141")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A53A4C", Offset = "0x1A53A4C", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			static CopyHelper()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400009C")]
			private static Regex re;

			[global::Cpp2ILInjected.Token(Token = "0x400009D")]
			private static int callCount;
		}

		[global::Cpp2ILInjected.Token(Token = "0x200001F")]
		private delegate T Func<T>();

		[global::Cpp2ILInjected.Token(Token = "0x2000020")]
		private sealed class <>c__DisplayClass1
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000146")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4F854", Offset = "0x1A4F854", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass1()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000147")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A53AE8", Offset = "0x1A53AE8", Length = "0x104")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt64", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
			{
				typeof(string),
				typeof(object)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BadReadException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			public long <ProcessExtraFieldZip64>b__0()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x400009E")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int remainingData;

			[global::Cpp2ILInjected.Token(Token = "0x400009F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public byte[] buffer;

			[global::Cpp2ILInjected.Token(Token = "0x40000A0")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public int j;

			[global::Cpp2ILInjected.Token(Token = "0x40000A1")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public long posn;
		}

		[global::Cpp2ILInjected.Token(Token = "0x2000021")]
		private sealed class <>c__DisplayClass4
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000148")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A4F85C", Offset = "0x1A4F85C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass4()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000149")]
			[global::Cpp2ILInjected.Address(RVA = "0x1A53BEC", Offset = "0x1A53BEC", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BitConverter), Member = "ToInt32", MemberParameters = new object[]
			{
				typeof(byte[]),
				typeof(int)
			}, ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "AddSeconds", MemberParameters = new object[] { typeof(double) }, ReturnType = typeof(DateTime))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			public DateTime <ProcessExtraFieldUnixTimes>b__3()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40000A2")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public int remainingData;

			[global::Cpp2ILInjected.Token(Token = "0x40000A3")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public ZipEntry <>4__this;

			[global::Cpp2ILInjected.Token(Token = "0x40000A4")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public byte[] buffer;

			[global::Cpp2ILInjected.Token(Token = "0x40000A5")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
			public int j;
		}
	}
}
