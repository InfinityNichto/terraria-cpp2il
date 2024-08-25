using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;

namespace UnityEngine.Profiling.Experimental
{
	[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
	public struct DebugScreenCapture
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700010F")]
		public NativeArray<byte> rawImageDataReference
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000521")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8823C", Offset = "0x1F8823C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000110")]
		public TextureFormat imageFormat
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000522")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88244", Offset = "0x1F88244", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000111")]
		public int width
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000523")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8824C", Offset = "0x1F8824C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000112")]
		public int height
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000524")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88254", Offset = "0x1F88254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private NativeArray<byte> <rawImageDataReference>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TextureFormat <imageFormat>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000410")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int <width>k__BackingField;

		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <height>k__BackingField;
	}
}
