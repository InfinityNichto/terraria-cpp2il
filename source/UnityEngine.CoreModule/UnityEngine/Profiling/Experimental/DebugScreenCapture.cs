using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;

namespace UnityEngine.Profiling.Experimental
{
	// Token: 0x020000DB RID: 219
	[global::Cpp2ILInjected.Token(Token = "0x20000F2")]
	public struct DebugScreenCapture
	{
		// Token: 0x1700010C RID: 268
		// (set) Token: 0x06000503 RID: 1283 RVA: 0x00002AF4 File Offset: 0x00000CF4
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

		// Token: 0x1700010D RID: 269
		// (set) Token: 0x06000504 RID: 1284 RVA: 0x00002AF7 File Offset: 0x00000CF7
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

		// Token: 0x1700010E RID: 270
		// (set) Token: 0x06000505 RID: 1285 RVA: 0x00002AFA File Offset: 0x00000CFA
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

		// Token: 0x1700010F RID: 271
		// (set) Token: 0x06000506 RID: 1286 RVA: 0x00002AFD File Offset: 0x00000CFD
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

		// Token: 0x040003D1 RID: 977
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400040E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private NativeArray<byte> <rawImageDataReference>k__BackingField;

		// Token: 0x040003D2 RID: 978
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400040F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private TextureFormat <imageFormat>k__BackingField;

		// Token: 0x040003D3 RID: 979
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000410")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x14")]
		private int <width>k__BackingField;

		// Token: 0x040003D4 RID: 980
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000411")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private int <height>k__BackingField;
	}
}
