using System;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using UnityEngine.Bindings;
using UnityEngine.Scripting;

namespace Unity.IO.LowLevel.Unsafe
{
	[NativeAsStruct]
	[NativeConditional("ENABLE_PROFILER")]
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	[StructLayout(0)]
	public class AsyncReadManagerMetricsFilters
	{
		[NativeName("typeIDs")]
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		internal ulong[] TypeIDs;

		[NativeName("states")]
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		internal ProcessingState[] States;

		[NativeName("readTypes")]
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		internal FileReadType[] ReadTypes;

		[NativeName("priorityLevels")]
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		internal Priority[] PriorityLevels;

		[NativeName("subsystems")]
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		internal AssetLoadingSubsystem[] Subsystems;
	}
}
