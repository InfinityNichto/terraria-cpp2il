using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Mono.Util;

namespace System.IO.Compression
{
	[global::Cpp2ILInjected.Token(Token = "0x2000440")]
	internal class DeflateStreamNative
	{
		[global::Cpp2ILInjected.Token(Token = "0x6001DDE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95EAC", Offset = "0x1E95EAC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		private DeflateStreamNative()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DDF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E947C4", Offset = "0x1E947C4", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Alloc", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative.UnmanagedReadOrWrite), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "ToIntPtr", MemberParameters = new object[] { typeof(GCHandle) }, ReturnType = typeof(IntPtr))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "CreateZStream", MemberParameters = new object[]
		{
			typeof(CompressionMode),
			typeof(bool),
			typeof(DeflateStreamNative.UnmanagedReadOrWrite),
			typeof(IntPtr)
		}, ReturnType = typeof(DeflateStreamNative.SafeDeflateStreamHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static DeflateStreamNative Create(Stream compressedStream, CompressionMode mode, bool gzip)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DE0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96010", Offset = "0x1E96010", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		protected override void Finalize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DE1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94A54", Offset = "0x1E94A54", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "Dispose", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "Create", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool)
		}, ReturnType = typeof(DeflateStreamNative))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "Finalize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_IsAllocated", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "Free", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "SuppressFinalize", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Dispose(bool disposing)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DE2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95104", Offset = "0x1E95104", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "Flush", MemberParameters = new object[] { typeof(DeflateStreamNative.SafeDeflateStreamHandle) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "CheckResult", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Flush()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DE3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94B84", Offset = "0x1E94B84", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "Read", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "ReadZStream", MemberParameters = new object[]
		{
			typeof(DeflateStreamNative.SafeDeflateStreamHandle),
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "CheckResult", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int ReadZStream(IntPtr buffer, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DE4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E94E10", Offset = "0x1E94E10", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStream), Member = "Write", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "WriteZStream", MemberParameters = new object[]
		{
			typeof(DeflateStreamNative.SafeDeflateStreamHandle),
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "CheckResult", MemberParameters = new object[]
		{
			typeof(int),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void WriteZStream(IntPtr buffer, int length)
		{
			throw null;
		}

		[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
		[global::Cpp2ILInjected.Token(Token = "0x6001DE5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95D4C", Offset = "0x1E95D4C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "FromIntPtr", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "UnmanagedRead", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int UnmanagedRead(IntPtr buffer, int length, IntPtr data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DE6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96330", Offset = "0x1E96330", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "UnmanagedRead", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(byte[]),
			typeof(int),
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private int UnmanagedRead(IntPtr buffer, int length)
		{
			throw null;
		}

		[MonoPInvokeCallback(typeof(DeflateStreamNative.UnmanagedReadOrWrite))]
		[global::Cpp2ILInjected.Token(Token = "0x6001DE7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95DFC", Offset = "0x1E95DFC", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "FromIntPtr", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(GCHandle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GCHandle), Member = "get_Target", ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative), Member = "UnmanagedWrite", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static int UnmanagedWrite(IntPtr buffer, int length, IntPtr data)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DE8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E964C0", Offset = "0x1E964C0", Length = "0x1C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "UnmanagedWrite", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int),
			typeof(IntPtr)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Math), Member = "Min", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		private int UnmanagedWrite(IntPtr buffer, int length)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DE9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E9610C", Offset = "0x1E9610C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "ReadZStream", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "WriteZStream", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IOException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private void CheckResult(int result, string where)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6001DEA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E95F78", Offset = "0x1E95F78", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "Create", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(CompressionMode),
			typeof(bool)
		}, ReturnType = typeof(DeflateStreamNative))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DeflateStreamNative.SafeDeflateStreamHandle), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		[PreserveSig]
		private static extern DeflateStreamNative.SafeDeflateStreamHandle CreateZStream(CompressionMode compress, bool gzip, DeflateStreamNative.UnmanagedReadOrWrite feeder, IntPtr data);

		[global::Cpp2ILInjected.Token(Token = "0x6001DEB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E966D8", Offset = "0x1E966D8", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		[PreserveSig]
		private static extern int CloseZStream(IntPtr stream);

		[global::Cpp2ILInjected.Token(Token = "0x6001DEC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E960A8", Offset = "0x1E960A8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "Flush", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[PreserveSig]
		private static extern int Flush(DeflateStreamNative.SafeDeflateStreamHandle stream);

		[global::Cpp2ILInjected.Token(Token = "0x6001DED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E96238", Offset = "0x1E96238", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "ReadZStream", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[PreserveSig]
		private static extern int ReadZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length);

		[global::Cpp2ILInjected.Token(Token = "0x6001DEE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E962B4", Offset = "0x1E962B4", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "WriteZStream", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousAddRef", MemberParameters = new object[] { typeof(ref bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = "DangerousRelease", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		[PreserveSig]
		private static extern int WriteZStream(DeflateStreamNative.SafeDeflateStreamHandle stream, IntPtr buffer, int length);

		[global::Cpp2ILInjected.Token(Token = "0x400140F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private DeflateStreamNative.UnmanagedReadOrWrite feeder;

		[global::Cpp2ILInjected.Token(Token = "0x4001410")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private Stream base_stream;

		[global::Cpp2ILInjected.Token(Token = "0x4001411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private DeflateStreamNative.SafeDeflateStreamHandle z_stream;

		[global::Cpp2ILInjected.Token(Token = "0x4001412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private GCHandle data;

		[global::Cpp2ILInjected.Token(Token = "0x4001413")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private bool disposed;

		[global::Cpp2ILInjected.Token(Token = "0x4001414")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private byte[] io_buffer;

		[global::Cpp2ILInjected.Token(Token = "0x4001415")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Exception last_error;

		[UnmanagedFunctionPointer(CallingConvention.Cdecl)]
		[global::Cpp2ILInjected.Token(Token = "0x2000441")]
		private delegate int UnmanagedReadOrWrite(IntPtr buffer, int length, IntPtr data);

		[global::Cpp2ILInjected.Token(Token = "0x2000442")]
		private sealed class SafeDeflateStreamHandle : SafeHandle
		{
			[global::Cpp2ILInjected.Token(Token = "0x170006BB")]
			public override bool IsInvalid
			{
				[global::Cpp2ILInjected.Token(Token = "0x6001DF1")]
				[global::Cpp2ILInjected.Address(RVA = "0x1E966F0", Offset = "0x1E966F0", Length = "0x54")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
				{
					typeof(IntPtr),
					typeof(IntPtr)
				}, ReturnType = typeof(bool))]
				[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
				get
				{
					throw null;
				}
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001DF2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96680", Offset = "0x1E96680", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeflateStreamNative), Member = "CreateZStream", MemberParameters = new object[]
			{
				typeof(CompressionMode),
				typeof(bool),
				"System.IO.Compression.DeflateStreamNative.UnmanagedReadOrWrite",
				typeof(IntPtr)
			}, ReturnType = typeof(DeflateStreamNative.SafeDeflateStreamHandle))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SafeHandle), Member = ".ctor", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private SafeDeflateStreamHandle()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6001DF3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E96744", Offset = "0x1E96744", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
			protected override bool ReleaseHandle()
			{
				throw null;
			}
		}
	}
}
