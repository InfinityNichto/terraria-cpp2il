using System;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.IO
{
	// Token: 0x0200047D RID: 1149
	[global::Cpp2ILInjected.Token(Token = "0x2000548")]
	public class UnmanagedMemoryStream : Stream
	{
		// Token: 0x06002541 RID: 9537 RVA: 0x0001ACCC File Offset: 0x00018ECC
		[global::Cpp2ILInjected.Token(Token = "0x6002815")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99E0C", Offset = "0x1B99E0C", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PinnedBufferMemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected UnmanagedMemoryStream()
		{
			throw null;
		}

		// Token: 0x06002542 RID: 9538 RVA: 0x0001ACCF File Offset: 0x00018ECF
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002816")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8D85C", Offset = "0x1B8D85C", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Reflection.RuntimeAssembly.UnmanagedMemoryStreamForModule), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long),
			typeof(global::System.Reflection.Module)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long),
			typeof(long),
			typeof(FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length)
		{
			throw null;
		}

		// Token: 0x06002543 RID: 9539 RVA: 0x0001ACD2 File Offset: 0x00018ED2
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002817")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9EE10", Offset = "0x1B9EE10", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV2", MemberParameters = new object[]
		{
			typeof(int),
			typeof(ref global::System.Resources.ResourceTypeCode)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.MarshalByRefObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long),
			typeof(long),
			typeof(FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public unsafe UnmanagedMemoryStream(byte* pointer, long length, long capacity, FileAccess access)
		{
			throw null;
		}

		// Token: 0x06002544 RID: 9540 RVA: 0x0001ACD5 File Offset: 0x00018ED5
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x6002818")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B99E70", Offset = "0x1B99E70", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PinnedBufferMemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long),
			typeof(long),
			typeof(FileAccess)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.InvalidOperationException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		protected unsafe void Initialize(byte* pointer, long length, long capacity, FileAccess access)
		{
			throw null;
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x06002545 RID: 9541 RVA: 0x0001ACD8 File Offset: 0x00018ED8
		[global::Cpp2ILInjected.Token(Token = "0x170005C0")]
		public override bool CanRead
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002819")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EEA0", Offset = "0x1B9EEA0", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06002546 RID: 9542 RVA: 0x0001ACDB File Offset: 0x00018EDB
		[global::Cpp2ILInjected.Token(Token = "0x170005C1")]
		public override bool CanSeek
		{
			[global::Cpp2ILInjected.Token(Token = "0x600281A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EEBC", Offset = "0x1B9EEBC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002547 RID: 9543 RVA: 0x0001ACDE File Offset: 0x00018EDE
		[global::Cpp2ILInjected.Token(Token = "0x170005C2")]
		public override bool CanWrite
		{
			[global::Cpp2ILInjected.Token(Token = "0x600281B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9EEC4", Offset = "0x1B9EEC4", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002548 RID: 9544 RVA: 0x0001ACE1 File Offset: 0x00018EE1
		[global::Cpp2ILInjected.Token(Token = "0x600281C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B8D8F4", Offset = "0x1B8D8F4", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		protected override void Dispose(bool disposing)
		{
			throw null;
		}

		// Token: 0x06002549 RID: 9545 RVA: 0x0001ACE4 File Offset: 0x00018EE4
		[global::Cpp2ILInjected.Token(Token = "0x600281D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9EEE4", Offset = "0x1B9EEE4", Length = "0x34")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "get_Length", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "get_PositionPointer", ReturnType = typeof(byte*))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Seek", MemberParameters = new object[]
		{
			typeof(long),
			typeof(SeekOrigin)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private unsafe void EnsureNotClosed()
		{
			throw null;
		}

		// Token: 0x0600254A RID: 9546 RVA: 0x0001ACE7 File Offset: 0x00018EE7
		[global::Cpp2ILInjected.Token(Token = "0x600281E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9EF18", Offset = "0x1B9EF18", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "ReadByte", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetReadNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureReadable()
		{
			throw null;
		}

		// Token: 0x0600254B RID: 9547 RVA: 0x0001ACEA File Offset: 0x00018EEA
		[global::Cpp2ILInjected.Token(Token = "0x600281F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9EF54", Offset = "0x1B9EF54", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "SetLength", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "WriteByte", MemberParameters = new object[] { typeof(byte) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetWriteNotSupported", ReturnType = typeof(global::System.Exception))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void EnsureWriteable()
		{
			throw null;
		}

		// Token: 0x0600254C RID: 9548 RVA: 0x0001ACED File Offset: 0x00018EED
		[global::Cpp2ILInjected.Token(Token = "0x6002820")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9EF90", Offset = "0x1B9EF90", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		public override void Flush()
		{
			throw null;
		}

		// Token: 0x0600254D RID: 9549 RVA: 0x0001ACF0 File Offset: 0x00018EF0
		[global::Cpp2ILInjected.Token(Token = "0x6002821")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9EF94", Offset = "0x1B9EF94", Length = "0x174")]
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

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x0600254E RID: 9550 RVA: 0x0001ACF3 File Offset: 0x00018EF3
		[global::Cpp2ILInjected.Token(Token = "0x170005C3")]
		public override long Length
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002822")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9F108", Offset = "0x1B9F108", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000546 RID: 1350
		// (get) Token: 0x0600254F RID: 9551 RVA: 0x0001ACF6 File Offset: 0x00018EF6
		// (set) Token: 0x06002550 RID: 9552 RVA: 0x0001ACF9 File Offset: 0x00018EF9
		[global::Cpp2ILInjected.Token(Token = "0x170005C4")]
		public override long Position
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002823")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9F124", Offset = "0x1B9F124", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6002824")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9F16C", Offset = "0x1B9F16C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
			{
				typeof(ref long),
				typeof(long)
			}, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Error), Member = "GetStreamIsClosed", ReturnType = typeof(global::System.Exception))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000547 RID: 1351
		// (get) Token: 0x06002551 RID: 9553 RVA: 0x0001ACFC File Offset: 0x00018EFC
		[global::System.CLSCompliant(false)]
		[global::Cpp2ILInjected.Token(Token = "0x170005C5")]
		public unsafe byte* PositionPointer
		{
			[global::Cpp2ILInjected.Token(Token = "0x6002825")]
			[global::Cpp2ILInjected.Address(RVA = "0x1B9F210", Offset = "0x1B9F210", Length = "0xB8")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "CompareStringEqualsName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "AllocateStringForNameIndex", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref int)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_LoadObjectV2", MemberParameters = new object[]
			{
				typeof(int),
				typeof(ref global::System.Resources.ResourceTypeCode)
			}, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Resources.ResourceReader), Member = "_ReadResources", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.IndexOutOfRangeException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002552 RID: 9554 RVA: 0x0001ACFF File Offset: 0x00018EFF
		[global::Cpp2ILInjected.Token(Token = "0x6002826")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9F2C8", Offset = "0x1B9F2C8", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
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
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x06002553 RID: 9555 RVA: 0x0001AD02 File Offset: 0x00018F02
		[global::Cpp2ILInjected.Token(Token = "0x6002827")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9F478", Offset = "0x1B9F478", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "ReadCore", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Read", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override int Read(global::System.Span<byte> buffer)
		{
			throw null;
		}

		// Token: 0x06002554 RID: 9556 RVA: 0x0001AD05 File Offset: 0x00018F05
		[global::Cpp2ILInjected.Token(Token = "0x6002828")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A064", Offset = "0x1B9A064", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Read", MemberParameters = new object[] { typeof(global::System.Span<byte>) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureReadable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "AcquirePointer", MemberParameters = new object[] { typeof(ref byte*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		internal unsafe int ReadCore(global::System.Span<byte> buffer)
		{
			throw null;
		}

		// Token: 0x06002555 RID: 9557 RVA: 0x0001AD08 File Offset: 0x00018F08
		[global::Cpp2ILInjected.Token(Token = "0x6002829")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9F558", Offset = "0x1B9F558", Length = "0x300")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 33)]
		public override global::System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x06002556 RID: 9558 RVA: 0x0001AD0B File Offset: 0x00018F0B
		[global::Cpp2ILInjected.Token(Token = "0x600282A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9F858", Offset = "0x1B9F858", Length = "0x294")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Memory<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Memory`1<T>" }, ReturnType = "System.ReadOnlyMemory`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberTypeParameters = new object[] { "TResult" }, MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = "System.Threading.Tasks.Task`1<TResult>")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public override global::System.Threading.Tasks.ValueTask<int> ReadAsync(global::System.Memory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			throw null;
		}

		// Token: 0x06002557 RID: 9559 RVA: 0x0001AD0E File Offset: 0x00018F0E
		[global::Cpp2ILInjected.Token(Token = "0x600282B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9FAEC", Offset = "0x1B9FAEC", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureReadable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "AcquirePointer", MemberParameters = new object[] { typeof(ref byte*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe override int ReadByte()
		{
			throw null;
		}

		// Token: 0x06002558 RID: 9560 RVA: 0x0001AD11 File Offset: 0x00018F11
		[global::Cpp2ILInjected.Token(Token = "0x600282C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9FC34", Offset = "0x1B9FC34", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public override long Seek(long offset, SeekOrigin loc)
		{
			throw null;
		}

		// Token: 0x06002559 RID: 9561 RVA: 0x0001AD14 File Offset: 0x00018F14
		[global::Cpp2ILInjected.Token(Token = "0x600282D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9FD3C", Offset = "0x1B9FD3C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "ZeroMemory", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentOutOfRangeException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public unsafe override void SetLength(long value)
		{
			throw null;
		}

		// Token: 0x0600255A RID: 9562 RVA: 0x0001AD17 File Offset: 0x00018F17
		[global::Cpp2ILInjected.Token(Token = "0x600282E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9FEC0", Offset = "0x1B9FEC0", Length = "0x1DC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentOutOfRangeException", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Span<>), Member = "op_Implicit", MemberParameters = new object[] { "System.Span`1<T>" }, ReturnType = "System.ReadOnlySpan`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw null;
		}

		// Token: 0x0600255B RID: 9563 RVA: 0x0001AD1A File Offset: 0x00018F1A
		[global::Cpp2ILInjected.Token(Token = "0x600282F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA009C", Offset = "0x1BA009C", Length = "0xE0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(global::System.Type),
			typeof(global::System.Type)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "WriteCore", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Stream), Member = "Write", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override void Write(global::System.ReadOnlySpan<byte> buffer)
		{
			throw null;
		}

		// Token: 0x0600255C RID: 9564 RVA: 0x0001AD1D File Offset: 0x00018F1D
		[global::Cpp2ILInjected.Token(Token = "0x6002830")]
		[global::Cpp2ILInjected.Address(RVA = "0x1B9A27C", Offset = "0x1B9A27C", Length = "0x2D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnmanagedMemoryStream), Member = "Write", MemberParameters = new object[] { typeof(global::System.ReadOnlySpan<byte>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "ZeroMemory", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "GetReference", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlySpan`1<T>" }, ReturnType = "T&")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "AcquirePointer", MemberParameters = new object[] { typeof(ref byte*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "Memcpy", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(byte*),
			typeof(int),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		internal unsafe void WriteCore(global::System.ReadOnlySpan<byte> buffer)
		{
			throw null;
		}

		// Token: 0x0600255D RID: 9565 RVA: 0x0001AD20 File Offset: 0x00018F20
		[global::Cpp2ILInjected.Token(Token = "0x6002831")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA017C", Offset = "0x1BA017C", Length = "0x2B0")]
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
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		public override global::System.Threading.Tasks.Task WriteAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			throw null;
		}

		// Token: 0x0600255E RID: 9566 RVA: 0x0001AD23 File Offset: 0x00018F23
		[global::Cpp2ILInjected.Token(Token = "0x6002832")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA042C", Offset = "0x1BA042C", Length = "0x214")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.CancellationToken), Member = "get_IsCancellationRequested", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromCanceled", MemberParameters = new object[] { typeof(global::System.Threading.CancellationToken) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ThrowHelper), Member = "ThrowArgumentNullException", MemberParameters = new object[] { typeof(global::System.ExceptionArgument) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.MemoryMarshal), Member = "TryGetArray", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.ReadOnlyMemory`1<T>", "System.ArraySegment`1<T>&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Tasks.Task), Member = "FromException", MemberParameters = new object[] { typeof(global::System.Exception) }, ReturnType = typeof(global::System.Threading.Tasks.Task))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 19)]
		public override global::System.Threading.Tasks.ValueTask WriteAsync(global::System.ReadOnlyMemory<byte> buffer, global::System.Threading.CancellationToken cancellationToken = default(global::System.Threading.CancellationToken))
		{
			throw null;
		}

		// Token: 0x0600255F RID: 9567 RVA: 0x0001AD26 File Offset: 0x00018F26
		[global::Cpp2ILInjected.Token(Token = "0x6002833")]
		[global::Cpp2ILInjected.Address(RVA = "0x1BA0640", Offset = "0x1BA0640", Length = "0x208")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureNotClosed", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnmanagedMemoryStream), Member = "EnsureWriteable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Read", MemberParameters = new object[] { typeof(ref long) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Buffer), Member = "ZeroMemory", MemberParameters = new object[]
		{
			typeof(byte*),
			typeof(long)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Threading.Interlocked), Member = "Exchange", MemberParameters = new object[]
		{
			typeof(ref long),
			typeof(long)
		}, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.CompilerServices.RuntimeHelpers), Member = "PrepareConstrainedRegions", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "AcquirePointer", MemberParameters = new object[] { typeof(ref byte*) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.InteropServices.SafeBuffer), Member = "ReleasePointer", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.NotSupportedException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public unsafe override void WriteByte(byte value)
		{
			throw null;
		}

		// Token: 0x04001296 RID: 4758
		[global::Cpp2ILInjected.Token(Token = "0x40015B8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private global::System.Runtime.InteropServices.SafeBuffer _buffer;

		// Token: 0x04001297 RID: 4759
		[global::Cpp2ILInjected.Token(Token = "0x40015B9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private unsafe byte* _mem;

		// Token: 0x04001298 RID: 4760
		[global::Cpp2ILInjected.Token(Token = "0x40015BA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private long _length;

		// Token: 0x04001299 RID: 4761
		[global::Cpp2ILInjected.Token(Token = "0x40015BB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private long _capacity;

		// Token: 0x0400129A RID: 4762
		[global::Cpp2ILInjected.Token(Token = "0x40015BC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private long _position;

		// Token: 0x0400129B RID: 4763
		[global::Cpp2ILInjected.Token(Token = "0x40015BD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private long _offset;

		// Token: 0x0400129C RID: 4764
		[global::Cpp2ILInjected.Token(Token = "0x40015BE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private FileAccess _access;

		// Token: 0x0400129D RID: 4765
		[global::Cpp2ILInjected.Token(Token = "0x40015BF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x5C")]
		internal bool _isOpen;

		// Token: 0x0400129E RID: 4766
		[global::Cpp2ILInjected.Token(Token = "0x40015C0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private global::System.Threading.Tasks.Task<int> _lastReadTask;
	}
}
