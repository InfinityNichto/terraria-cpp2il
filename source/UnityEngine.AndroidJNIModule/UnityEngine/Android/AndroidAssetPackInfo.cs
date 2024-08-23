using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.Android
{
	// Token: 0x02000011 RID: 17
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	public class AndroidAssetPackInfo
	{
		// Token: 0x06000180 RID: 384 RVA: 0x000022FC File Offset: 0x000004FC
		[global::Cpp2ILInjected.Token(Token = "0x6000180")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F658F8", Offset = "0x1F658F8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		internal AndroidAssetPackInfo(string name, AndroidAssetPackStatus status, ulong size, ulong bytesDownloaded, float transferProgress, AndroidAssetPackError error)
		{
			throw null;
		}

		// Token: 0x04000035 RID: 53
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000035")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string <name>k__BackingField;

		// Token: 0x04000036 RID: 54
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000036")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly AndroidAssetPackStatus <status>k__BackingField;

		// Token: 0x04000037 RID: 55
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000037")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private readonly ulong <size>k__BackingField;

		// Token: 0x04000038 RID: 56
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000038")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private readonly ulong <bytesDownloaded>k__BackingField;

		// Token: 0x04000039 RID: 57
		[CompilerGenerated]
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[global::Cpp2ILInjected.Token(Token = "0x4000039")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private readonly float <transferProgress>k__BackingField;

		// Token: 0x0400003A RID: 58
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400003A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x34")]
		private readonly AndroidAssetPackError <error>k__BackingField;
	}
}
