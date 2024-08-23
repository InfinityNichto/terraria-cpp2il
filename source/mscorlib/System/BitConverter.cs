using System;
using System.Buffers;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System
{
	// Token: 0x0200006A RID: 106
	[global::Cpp2ILInjected.Token(Token = "0x2000090")]
	public static class BitConverter
	{
		// Token: 0x0600037E RID: 894 RVA: 0x00014F99 File Offset: 0x00013199
		[global::Cpp2ILInjected.Token(Token = "0x6000415")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6BB4", Offset = "0x1BB6BB4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "FileCompressor", Member = "Compress", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile_OldMobile", Member = "BadMarker", MemberParameters = new object[]
		{
			typeof(global::System.IO.BinaryReader),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ConstructExtraField", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "PostProcessOutput", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipSegmentedStream", Member = "_SetWriteStream", MemberParameters = new object[] { typeof(uint) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.GZipStream", Member = "EmitHeader", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = "finish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] GetBytes(int value)
		{
			throw null;
		}

		// Token: 0x0600037F RID: 895 RVA: 0x00014F9C File Offset: 0x0001319C
		[global::Cpp2ILInjected.Token(Token = "0x6000416")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6C04", Offset = "0x1BB6C04", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ConstructExtraField", MemberParameters = new object[] { typeof(bool) }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "PostProcessOutput", MemberParameters = new object[] { typeof(global::System.IO.Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.NetCfFile", Member = "SetTimes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.NetCfFile", Member = "SetLastWriteTime", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.DateTime)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutput", Member = "GenZip64EndOfCentralDirectory", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(int),
			typeof(uint)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] GetBytes(long value)
		{
			throw null;
		}

		// Token: 0x06000380 RID: 896 RVA: 0x00014F9F File Offset: 0x0001319F
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000417")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6C54", Offset = "0x1BB6C54", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutput", Member = "WriteCentralDirectoryStructure", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			"System.Collections.Generic.ICollection`1<ZipEntry>",
			typeof(uint),
			"Ionic.Zip.Zip64Option",
			typeof(string),
			"Ionic.Zip.ZipContainer"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] GetBytes(ushort value)
		{
			throw null;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00014FA2 File Offset: 0x000131A2
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000418")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6CA4", Offset = "0x1BB6CA4", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutput", Member = "WriteCentralDirectoryStructure", MemberParameters = new object[]
		{
			typeof(global::System.IO.Stream),
			"System.Collections.Generic.ICollection`1<ZipEntry>",
			typeof(uint),
			"Ionic.Zip.Zip64Option",
			typeof(string),
			"Ionic.Zip.ZipContainer"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutput", Member = "GenCentralDirectoryFooter", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			"Ionic.Zip.Zip64Option",
			typeof(int),
			typeof(string),
			"Ionic.Zip.ZipContainer"
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipOutput", Member = "GenZip64EndOfCentralDirectory", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long),
			typeof(int),
			typeof(uint)
		}, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] GetBytes(uint value)
		{
			throw null;
		}

		// Token: 0x06000382 RID: 898 RVA: 0x00014FA5 File Offset: 0x000131A5
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6000419")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6CF4", Offset = "0x1BB6CF4", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.IPAddress", Member = "GetHashCode", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool TryWriteBytes(global::System.Span<byte> destination, uint value)
		{
			throw null;
		}

		// Token: 0x06000383 RID: 899 RVA: 0x00014FA8 File Offset: 0x000131A8
		[global::Cpp2ILInjected.Token(Token = "0x600041A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6D78", Offset = "0x1BB6D78", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UID", Member = "UIDGenerationAddFloat", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ref uint)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static byte[] GetBytes(float value)
		{
			throw null;
		}

		// Token: 0x06000384 RID: 900 RVA: 0x00014FAB File Offset: 0x000131AB
		[global::Cpp2ILInjected.Token(Token = "0x600041B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6DD0", Offset = "0x1BB6DD0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToUInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(ushort))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		public static short ToInt16(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000385 RID: 901 RVA: 0x00014FAE File Offset: 0x000131AE
		[global::Cpp2ILInjected.Token(Token = "0x600041C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6E40", Offset = "0x1BB6E40", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "FileCompressor", Member = "HasCompressionHeader", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(ref int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "LoadSaveData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "LoadSaveData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "LoadWorlds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToUInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(uint))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.<>c__DisplayClass4", Member = "<ProcessExtraFieldUnixTimes>b__3", ReturnType = typeof(global::System.DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ProcessExtraFieldInfoZipTimes", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = "finish", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zlib.ZlibBaseStream", Member = "_ReadAndValidateGzipHeader", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 13)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		public static int ToInt32(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000386 RID: 902 RVA: 0x00014FB1 File Offset: 0x000131B1
		[global::Cpp2ILInjected.Token(Token = "0x600041D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6EB0", Offset = "0x1BB6EB0", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry.<>c__DisplayClass1", Member = "<ProcessExtraFieldZip64>b__0", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ReadHeader", MemberParameters = new object[]
		{
			"Ionic.Zip.ZipEntry",
			typeof(global::System.Text.Encoding)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipEntry", Member = "ProcessExtraFieldWindowsTimes", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int),
			typeof(short),
			typeof(long)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "Zip64SeekToCentralDirectory", MemberParameters = new object[] { "Ionic.Zip.ZipFile" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "ReadCentralDirectoryFooter", MemberParameters = new object[] { "Ionic.Zip.ZipFile" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		public static long ToInt64(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00014FB4 File Offset: 0x000131B4
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600041E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6F20", Offset = "0x1BB6F20", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationClient", Member = "SendDataFunction", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SaveSynchronisationHost", Member = "SendDataFunction", MemberParameters = new object[]
		{
			"System.Byte[]",
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Telepathy.Common", Member = "ReadMessageBlocking", MemberParameters = new object[]
		{
			"System.Net.Sockets.NetworkStream",
			typeof(int),
			"System.Byte[]&"
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "ReadIntoInstance", MemberParameters = new object[] { "Ionic.Zip.ZipFile" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "ReadCentralDirectoryFooter", MemberParameters = new object[] { "Ionic.Zip.ZipFile" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BitConverter), Member = "ToInt16", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(short))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static ushort ToUInt16(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00014FB7 File Offset: 0x000131B7
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x600041F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6F84", Offset = "0x1BB6F84", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "ReadIntoInstance", MemberParameters = new object[] { "Ionic.Zip.ZipFile" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Ionic.Zip.ZipFile", Member = "ReadCentralDirectoryFooter", MemberParameters = new object[] { "Ionic.Zip.ZipFile" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BitConverter), Member = "ToInt32", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static uint ToUInt32(byte[] value, int startIndex)
		{
			throw null;
		}

		// Token: 0x06000389 RID: 905 RVA: 0x00014FBA File Offset: 0x000131BA
		[global::Cpp2ILInjected.Token(Token = "0x6000420")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB6FE8", Offset = "0x1BB6FE8", Length = "0x2D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.BitConverter), Member = "ToString", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionArgument),
			typeof(global::System.ExceptionResource)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentException", MemberParameters = new object[]
		{
			typeof(global::System.ExceptionResource),
			typeof(global::System.ExceptionArgument)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ValueTuple<, , >), Member = ".ctor", MemberParameters = new object[] { "T1", "T2", "T3" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffers.SpanAction<, >), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(global::System.IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Create", MemberTypeParameters = new object[] { "TState" }, MemberParameters = new object[]
		{
			typeof(int),
			"TState",
			"System.Buffers.SpanAction`2<Char, TState>"
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::SR), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		public static string ToString(byte[] value, int startIndex, int length)
		{
			throw null;
		}

		// Token: 0x0600038A RID: 906 RVA: 0x00014FBD File Offset: 0x000131BD
		[global::Cpp2ILInjected.Token(Token = "0x6000421")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB72B8", Offset = "0x1BB72B8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Runtime.Serialization.Formatters.Binary.SerializationHeaderRecord), Member = "Read", MemberParameters = new object[] { typeof(global::System.Runtime.Serialization.Formatters.Binary.__BinaryParser) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.BitConverter), Member = "ToString", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static string ToString(byte[] value)
		{
			throw null;
		}

		// Token: 0x0600038B RID: 907 RVA: 0x00014FC0 File Offset: 0x000131C0
		[global::Cpp2ILInjected.Token(Token = "0x6000422")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7324", Offset = "0x1BB7324", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static long DoubleToInt64Bits(double value)
		{
			throw null;
		}

		// Token: 0x0600038C RID: 908 RVA: 0x00014FC3 File Offset: 0x000131C3
		[global::Cpp2ILInjected.Token(Token = "0x6000423")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB732C", Offset = "0x1BB732C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static double Int64BitsToDouble(long value)
		{
			throw null;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00014FC6 File Offset: 0x000131C6
		[global::Cpp2ILInjected.Token(Token = "0x6000424")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB7334", Offset = "0x1BB7334", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[MethodImpl(256)]
		public static int SingleToInt32Bits(float value)
		{
			throw null;
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00014FC9 File Offset: 0x000131C9
		[global::Cpp2ILInjected.Token(Token = "0x6000425")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BB733C", Offset = "0x1BB733C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static BitConverter()
		{
			throw null;
		}

		// Token: 0x04000118 RID: 280
		[global::System.Runtime.CompilerServices.Intrinsic]
		[global::Cpp2ILInjected.Token(Token = "0x40001FD")]
		public static readonly bool IsLittleEndian;

		// Token: 0x0200057B RID: 1403
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000091")]
		[global::System.Serializable]
		private sealed class <>c
		{
			// Token: 0x06003F86 RID: 16262 RVA: 0x0001F958 File Offset: 0x0001DB58
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000426")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB7388", Offset = "0x1BB7388", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06003F87 RID: 16263 RVA: 0x0001F95B File Offset: 0x0001DB5B
			[global::Cpp2ILInjected.Token(Token = "0x6000427")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB73E4", Offset = "0x1BB73E4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06003F88 RID: 16264 RVA: 0x0001F95E File Offset: 0x0001DB5E
			[global::Cpp2ILInjected.Token(Token = "0x6000428")]
			[global::Cpp2ILInjected.Address(RVA = "0x1BB73EC", Offset = "0x1BB73EC", Length = "0x134")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "get_Chars", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(char))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal void <ToString>b__38_0(global::System.Span<char> dst, [global::System.Runtime.CompilerServices.TupleElementNames(new string[] { "value", "startIndex", "length" })] global::System.ValueTuple<byte[], int, int> state)
			{
				throw null;
			}

			// Token: 0x0400178C RID: 6028
			[global::Cpp2ILInjected.Token(Token = "0x40001FE")]
			public static readonly global::System.BitConverter.<>c <>9;

			// Token: 0x0400178D RID: 6029
			[global::System.Runtime.CompilerServices.TupleElementNames(new string[] { "value", "startIndex", "length" })]
			[global::Cpp2ILInjected.Token(Token = "0x40001FF")]
			public static global::System.Buffers.SpanAction<char, global::System.ValueTuple<byte[], int, int>> <>9__38_0;
		}
	}
}
