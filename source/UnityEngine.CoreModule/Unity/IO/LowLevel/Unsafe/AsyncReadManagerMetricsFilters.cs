using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
	// Token: 0x02000011 RID: 17
	[NativeAsStruct]
	[NativeConditional("ENABLE_PROFILER")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	[StructLayout(0)]
	public class AsyncReadManagerMetricsFilters
	{
		// Token: 0x04000036 RID: 54
		[NativeName("typeIDs")]
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ulong[] TypeIDs;

		// Token: 0x04000037 RID: 55
		[NativeName("states")]
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal ProcessingState[] States;

		// Token: 0x04000038 RID: 56
		[NativeName("readTypes")]
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal FileReadType[] ReadTypes;

		// Token: 0x04000039 RID: 57
		[NativeName("priorityLevels")]
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal Priority[] PriorityLevels;

		// Token: 0x0400003A RID: 58
		[NativeName("subsystems")]
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal AssetLoadingSubsystem[] Subsystems;
	}
}
