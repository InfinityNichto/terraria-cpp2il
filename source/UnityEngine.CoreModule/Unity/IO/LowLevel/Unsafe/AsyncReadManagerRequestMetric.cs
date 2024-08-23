using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000010 RID: 16
	[NativeConditional("ENABLE_PROFILER")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	public struct AsyncReadManagerRequestMetric
	{
		// Token: 0x04000027 RID: 39
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000027")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly string <AssetName>k__BackingField;

		// Token: 0x04000028 RID: 40
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000028")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly string <FileName>k__BackingField;

		// Token: 0x04000029 RID: 41
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000029")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly ulong <OffsetBytes>k__BackingField;

		// Token: 0x0400002A RID: 42
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400002A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly ulong <SizeBytes>k__BackingField;

		// Token: 0x0400002B RID: 43
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400002B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly ulong <AssetTypeId>k__BackingField;

		// Token: 0x0400002C RID: 44
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400002C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly ulong <CurrentBytesRead>k__BackingField;

		// Token: 0x0400002D RID: 45
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400002D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly uint <BatchReadCount>k__BackingField;

		// Token: 0x0400002E RID: 46
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400002E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private readonly bool <IsBatchRead>k__BackingField;

		// Token: 0x0400002F RID: 47
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x400002F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private readonly ProcessingState <State>k__BackingField;

		// Token: 0x04000030 RID: 48
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000030")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x3C")]
		private readonly FileReadType <ReadType>k__BackingField;

		// Token: 0x04000031 RID: 49
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000031")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private readonly Priority <PriorityLevel>k__BackingField;

		// Token: 0x04000032 RID: 50
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000032")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x44")]
		private readonly AssetLoadingSubsystem <Subsystem>k__BackingField;

		// Token: 0x04000033 RID: 51
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000033")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		private readonly double <RequestTimeMicroseconds>k__BackingField;

		// Token: 0x04000034 RID: 52
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000034")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private readonly double <TimeInQueueMicroseconds>k__BackingField;

		// Token: 0x04000035 RID: 53
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private readonly double <TotalTimeMicroseconds>k__BackingField;
	}
}
