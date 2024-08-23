using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Scripting;
using UnityEngine.Scripting.APIUpdating;

namespace UnityEngine.Profiling
{
	// Token: 0x020000D8 RID: 216
	[NativeHeader("Runtime/Profiler/ScriptBindings/Profiler.bindings.h")]
	[UsedByNativeCode]
	[NativeHeader("Runtime/Utilities/MemoryUtilities.h")]
	[NativeHeader("Runtime/Allocator/MemoryManager.h")]
	[NativeHeader("Runtime/Profiler/Profiler.h")]
	[MovedFrom("UnityEngine")]
	[NativeHeader("Runtime/ScriptingBackend/ScriptingApi.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000EF")]
	public sealed class Profiler
	{
		// Token: 0x060004FC RID: 1276 RVA: 0x00002ADF File Offset: 0x00000CDF
		[NativeConditional("ENABLE_PROFILER")]
		[global::Cpp2ILInjected.Token(Token = "0x600051A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F87E58", Offset = "0x1F87E58", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CacheFileManager", Member = "FileSyncInternal", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "CacheFileManager", Member = "FileUpload", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Main", Member = "RunServerCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "TcpClientLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Netplay", Member = "ServerLoop", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "worldGenCallback", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "SaveAndQuitCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "saveAndPlayCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "saveToonWhilePlayingCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.WorldGen", Member = "smCallBack", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 10)]
		public static void EndThreadProfiling()
		{
			throw null;
		}
	}
}
