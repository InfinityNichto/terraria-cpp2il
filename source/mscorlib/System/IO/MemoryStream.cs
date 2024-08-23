using System;
using System.Runtime.InteropServices;
using System.Security.Util;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x02000473 RID: 1139
	[global::Cpp2ILInjected.Token(Token = "0x2000539")]
	[global::System.Serializable]
	public class MemoryStream : Stream
	{
		// Token: 0x060024AA RID: 9386 RVA: 0x0001AB0A File Offset: 0x00018D0A
		[global::Cpp2ILInjected.Token(Token = "0x600274E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96744", Offset = "0x1B96744", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 51)]
		public MemoryStream()
		{
			throw null;
		}

		// Token: 0x060024AB RID: 9387 RVA: 0x0001AB0D File Offset: 0x00018D0D
		[global::Cpp2ILInjected.Token(Token = "0x600274F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9674C", Offset = "0x1B9674C", Length = "0x154")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Player", Member = "InternalSavePlayerFile", MemberParameters = new object[] { "Terraria.IO.PlayerFileData" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.ResourcePack", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "InternalSaveWorld", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "RenameWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "InternalSaveMapCompressed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Map.MapHelper", Member = "InternalSaveMap", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ReLogic.Content.Sources.ZipContentSource", Member = "OpenStream", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Stream))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public MemoryStream(int capacity)
		{
			throw null;
		}

		// Token: 0x060024AC RID: 9388 RVA: 0x0001AB10 File Offset: 0x00018D10
		[global::Cpp2ILInjected.Token(Token = "0x6002750")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B968A8", Offset = "0x1B968A8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 53)]
		public MemoryStream(byte[] buffer)
		{
			throw null;
		}

		// Token: 0x060024AD RID: 9389 RVA: 0x0001AB13 File Offset: 0x00018D13
		[global::Cpp2ILInjected.Token(Token = "0x6002751")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B968B0", Offset = "0x1B968B0", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Net.FtpWebResponse.EmptyStream", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Mono.Security.Authenticode.AuthenticodeBase", Member = "Open", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public MemoryStream(byte[] buffer, bool writable)
		{
			throw null;
		}

		// Token: 0x060024AE RID: 9390 RVA: 0x0001AB16 File Offset: 0x00018D16
		[global::Cpp2ILInjected.Token(Token = "0x6002752")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9699C", Offset = "0x1B9699C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldConsole", Member = "DecompressData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "GetAllMetadata", MemberParameters = new object[] { typeof(string) }, ReturnType = "Terraria.IO.WorldFileData")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WorldFile_OldSwitch", Member = "DecompressData", MemberParameters = new object[] { "System.Byte[]" }, ReturnType = "System.Byte[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Security.Util.Tokenizer), Member = "ChangeFormat", MemberParameters = new object[] { typeof(global::System.Text.Encoding) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		public MemoryStream(byte[] buffer, int index, int count)
		{
			throw null;
		}

		// Token: 0x060024AF RID: 9391 RVA: 0x0001AB19 File Offset: 0x00018D19
		[global::Cpp2ILInjected.Token(Token = "0x6002753")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96B70", Offset = "0x1B96B70", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "InternalSaveWorld", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.IO.WorldFile", Member = "RenameWorld", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		public MemoryStream(byte[] buffer, int index, int count, bool writable)
		{
			throw null;
		}

		// Token: 0x060024B0 RID: 9392 RVA: 0x0001AB1C File Offset: 0x00018D1C
		[global::Cpp2ILInjected.Token(Token = "0x6002754")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B969A8", Offset = "0x1B969A8", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
		public MemoryStream(byte[] buffer, int index, int count, bool writable, bool publiclyVisible)
		{
			throw null;
		}

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x060024B1 RID: 9393 RVA: 0x0001AB1F File Offset: 0x00018D1F
		[global::Cpp2ILInjected.Token(Token = "0x170005A9")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002755")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B96B7C", Offset = "0x1B96B7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x060024B2 RID: 9394 RVA: 0x0001AB22 File Offset: 0x00018D22
		[global::Cpp2ILInjected.Token(Token = "0x170005AA")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002756")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B96B84", Offset = "0x1B96B84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x060024B3 RID: 9395 RVA: 0x0001AB25 File Offset: 0x00018D25
		[global::Cpp2ILInjected.Token(Token = "0x170005AB")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002757")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B96B8C", Offset = "0x1B96B8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060024B4 RID: 9396 RVA: 0x0001AB28 File Offset: 0x00018D28
		[global::Cpp2ILInjected.Token(Token = "0x6002758")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96B94", Offset = "0x1B96B94", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "InternalReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "InternalEmulateRead", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "get_Capacity", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "set_Capacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "get_Length", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "get_Position", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "set_Position", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Read", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Seek", MemberParameters = new object[]
		{
			typeof(long),
			typeof(SeekOrigin)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureNotClosed()
		{
			throw null;
		}

		// Token: 0x060024B5 RID: 9397 RVA: 0x0001AB2B File Offset: 0x00018D2B
		[global::Cpp2ILInjected.Token(Token = "0x6002759")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96BC8", Offset = "0x1B96BC8", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureWriteable()
		{
			throw null;
		}

		// Token: 0x060024B6 RID: 9398 RVA: 0x0001AB2E File Offset: 0x00018D2E
		[global::Cpp2ILInjected.Token(Token = "0x600275A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96C04", Offset = "0x1B96C04", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x060024B7 RID: 9399 RVA: 0x0001AB31 File Offset: 0x00018D31
		[global::Cpp2ILInjected.Token(Token = "0x600275B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96C18", Offset = "0x1B96C18", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "Write", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private bool EnsureCapacity(int value)
		{
			throw null;
		}

		// Token: 0x060024B8 RID: 9400 RVA: 0x0001AB34 File Offset: 0x00018D34
		[global::Cpp2ILInjected.Token(Token = "0x600275C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96CC4", Offset = "0x1B96CC4", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x060024B9 RID: 9401 RVA: 0x0001AB37 File Offset: 0x00018D37
		[global::Cpp2ILInjected.Token(Token = "0x600275D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96CC8", Offset = "0x1B96CC8", Length = "0x174")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public override global::System.Threading.Tasks.Task FlushAsync(global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060024BA RID: 9402 RVA: 0x0001AB3A File Offset: 0x00018D3A
		[global::Cpp2ILInjected.Token(Token = "0x600275E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96E3C", Offset = "0x1B96E3C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.UnauthorizedAccessException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public virtual byte[] GetBuffer()
		{
			throw null;
		}

		// Token: 0x060024BB RID: 9403 RVA: 0x0001AB3D File Offset: 0x00018D3D
		[global::Cpp2ILInjected.Token(Token = "0x600275F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96E9C", Offset = "0x1B96E9C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal byte[] InternalGetBuffer()
		{
			throw null;
		}

		// Token: 0x060024BC RID: 9404 RVA: 0x0001AB40 File Offset: 0x00018D40
		[global::Cpp2ILInjected.Token(Token = "0x6002760")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96EA4", Offset = "0x1B96EA4", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		internal int InternalGetPosition()
		{
			throw null;
		}

		// Token: 0x060024BD RID: 9405 RVA: 0x0001AB43 File Offset: 0x00018D43
		[global::Cpp2ILInjected.Token(Token = "0x6002761")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96EAC", Offset = "0x1B96EAC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryReader), Member = "ReadInt32", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetEndOfFile", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal int InternalReadInt32()
		{
			throw null;
		}

		// Token: 0x060024BE RID: 9406 RVA: 0x0001AB46 File Offset: 0x00018D46
		[global::Cpp2ILInjected.Token(Token = "0x6002762")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B96F2C", Offset = "0x1B96F2C", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BinaryReader), Member = "InternalReadChars", MemberParameters = new object[]
		{
			typeof(char[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		internal int InternalEmulateRead(int count)
		{
			throw null;
		}

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x060024BF RID: 9407 RVA: 0x0001AB49 File Offset: 0x00018D49
		// (set) Token: 0x060024C0 RID: 9408 RVA: 0x0001AB4C File Offset: 0x00018D4C
		[global::Cpp2ILInjected.Token(Token = "0x170005AC")]
		public virtual int Capacity
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002763")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B96F68", Offset = "0x1B96F68", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002764")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B96F88", Offset = "0x1B96F88", Length = "0x178")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
			{
				typeof(global::System.Array),
				typeof(int),
				typeof(global::System.Array),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x060024C1 RID: 9409 RVA: 0x0001AB4F File Offset: 0x00018D4F
		[global::Cpp2ILInjected.Token(Token = "0x170005AD")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002765")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B97100", Offset = "0x1B97100", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x060024C2 RID: 9410 RVA: 0x0001AB52 File Offset: 0x00018D52
		// (set) Token: 0x060024C3 RID: 9411 RVA: 0x0001AB55 File Offset: 0x00018D55
		[global::Cpp2ILInjected.Token(Token = "0x170005AE")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002766")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B97124", Offset = "0x1B97124", Length = "0x20")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002767")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B97144", Offset = "0x1B97144", Length = "0xC8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.Xml.XmlCachedStream", Member = ".ctor", MemberParameters = new object[]
			{
				"System.Uri",
				typeof(Stream)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060024C4 RID: 9412 RVA: 0x0001AB58 File Offset: 0x00018D58
		[global::Cpp2ILInjected.Token(Token = "0x6002768")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9720C", Offset = "0x1B9720C", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060024C5 RID: 9413 RVA: 0x0001AB5B File Offset: 0x00018D5B
		[global::Cpp2ILInjected.Token(Token = "0x6002769")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B973EC", Offset = "0x1B973EC", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Read", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public override int Read(global::System.Span<byte> buffer)
		{
			throw null;
		}

		// Token: 0x060024C6 RID: 9414 RVA: 0x0001AB5E File Offset: 0x00018D5E
		[global::Cpp2ILInjected.Token(Token = "0x600276A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B97868", Offset = "0x1B97868", Length = "0x358")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task<int>), Member = "get_Result", ReturnType = "TResult")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task[]), Member = "FromResult", MemberTypeParameters = new object[] { typeof(int) }, MemberParameters = new object[] { typeof(int) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCancellation", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.OperationCanceledException) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 39)]
		public override global::System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060024C7 RID: 9415 RVA: 0x0001AB61 File Offset: 0x00018D61
		[global::Cpp2ILInjected.Token(Token = "0x600276B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B97BC0", Offset = "0x1B97BC0", Length = "0x2DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Memory<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Memory`1<T>" }, ReturnType = "System.ReadOnlyMemory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCancellation", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.OperationCanceledException) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public override global::System.Threading.Tasks.ValueTask<int> ReadAsync(global::System.Memory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			throw null;
		}

		// Token: 0x060024C8 RID: 9416 RVA: 0x0001AB64 File Offset: 0x00018D64
		[global::Cpp2ILInjected.Token(Token = "0x600276C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B97E9C", Offset = "0x1B97E9C", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		public override int ReadByte()
		{
			throw null;
		}

		// Token: 0x060024C9 RID: 9417 RVA: 0x0001AB67 File Offset: 0x00018D67
		[global::Cpp2ILInjected.Token(Token = "0x600276D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B97EDC", Offset = "0x1B97EDC", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(StreamHelpers), Member = "ValidateCopyToArgs", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "CopyTo", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override void CopyTo(Stream destination, int bufferSize)
		{
			throw null;
		}

		// Token: 0x060024CA RID: 9418 RVA: 0x0001AB6A File Offset: 0x00018D6A
		[global::Cpp2ILInjected.Token(Token = "0x600276E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B983D8", Offset = "0x1B983D8", Length = "0x14C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override long Seek(long offset, SeekOrigin loc)
		{
			throw null;
		}

		// Token: 0x060024CB RID: 9419 RVA: 0x0001AB6D File Offset: 0x00018D6D
		[global::Cpp2ILInjected.Token(Token = "0x600276F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B98524", Offset = "0x1B98524", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x060024CC RID: 9420 RVA: 0x0001AB70 File Offset: 0x00018D70
		[global::Cpp2ILInjected.Token(Token = "0x6002770")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B98600", Offset = "0x1B98600", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public virtual byte[] ToArray()
		{
			throw null;
		}

		// Token: 0x060024CD RID: 9421 RVA: 0x0001AB73 File Offset: 0x00018D73
		[global::Cpp2ILInjected.Token(Token = "0x6002771")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B986DC", Offset = "0x1B986DC", Length = "0x278")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "BlockCopy", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x060024CE RID: 9422 RVA: 0x0001AB76 File Offset: 0x00018D76
		[global::Cpp2ILInjected.Token(Token = "0x6002772")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B98954", Offset = "0x1B98954", Length = "0x24C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ReadOnlySpan<>), Member = "CopyTo", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public override void Write(global::System.ReadOnlySpan<byte> buffer)
		{
			throw null;
		}

		// Token: 0x060024CF RID: 9423 RVA: 0x0001AB79 File Offset: 0x00018D79
		[global::Cpp2ILInjected.Token(Token = "0x6002773")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B98D60", Offset = "0x1B98D60", Length = "0x2F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task[]), Member = "FromCancellation", MemberTypeParameters = new object[] { typeof(global::System.Threading.Tasks.VoidTaskResult) }, MemberParameters = new object[] { typeof(global::System.OperationCanceledException) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		public override global::System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x060024D0 RID: 9424 RVA: 0x0001AB7C File Offset: 0x00018D7C
		[global::Cpp2ILInjected.Token(Token = "0x6002774")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99058", Offset = "0x1B99058", Length = "0x25C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task[]), Member = "FromCancellation", MemberTypeParameters = new object[] { typeof(global::System.Threading.Tasks.VoidTaskResult) }, MemberParameters = new object[] { typeof(global::System.OperationCanceledException) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public override global::System.Threading.Tasks.ValueTask WriteAsync(global::System.ReadOnlyMemory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			throw null;
		}

		// Token: 0x060024D1 RID: 9425 RVA: 0x0001AB7F File Offset: 0x00018D7F
		[global::Cpp2ILInjected.Token(Token = "0x6002775")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B992B4", Offset = "0x1B992B4", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = "EnsureCapacity", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(global::System.Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void WriteByte(byte value)
		{
			throw null;
		}

		// Token: 0x04001263 RID: 4707
		[global::Cpp2ILInjected.Token(Token = "0x4001583")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private byte[] _buffer;

		// Token: 0x04001264 RID: 4708
		[global::Cpp2ILInjected.Token(Token = "0x4001584")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private int _origin;

		// Token: 0x04001265 RID: 4709
		[global::Cpp2ILInjected.Token(Token = "0x4001585")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private int _position;

		// Token: 0x04001266 RID: 4710
		[global::Cpp2ILInjected.Token(Token = "0x4001586")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private int _length;

		// Token: 0x04001267 RID: 4711
		[global::Cpp2ILInjected.Token(Token = "0x4001587")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private int _capacity;

		// Token: 0x04001268 RID: 4712
		[global::Cpp2ILInjected.Token(Token = "0x4001588")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private bool _expandable;

		// Token: 0x04001269 RID: 4713
		[global::Cpp2ILInjected.Token(Token = "0x4001589")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x41")]
		private bool _writable;

		// Token: 0x0400126A RID: 4714
		[global::Cpp2ILInjected.Token(Token = "0x400158A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x42")]
		private bool _exposable;

		// Token: 0x0400126B RID: 4715
		[global::Cpp2ILInjected.Token(Token = "0x400158B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x43")]
		private bool _isOpen;

		// Token: 0x0400126C RID: 4716
		[global::Cpp2ILInjected.Token(Token = "0x400158C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		[global::System.NonSerialized]
		private global::System.Threading.Tasks.Task<int> _lastReadTask;
	}
}
