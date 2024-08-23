using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	// Token: 0x020000E4 RID: 228
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000104")]
	public class OnDemandRendering
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000527 RID: 1319 RVA: 0x00002B60 File Offset: 0x00000D60
		[global::Cpp2ILInjected.Token(Token = "0x17000117")]
		public static int renderFrameInterval
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000556")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F8A06C", Offset = "0x1F8A06C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OnDemandRendering), Member = "GetRenderFrameInterval", MemberParameters = new object[] { typeof(ref int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000528 RID: 1320 RVA: 0x00002B63 File Offset: 0x00000D63
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000557")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A0C4", Offset = "0x1F8A0C4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OnDemandRendering), Member = "get_renderFrameInterval", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void GetRenderFrameInterval(out int frameInterval)
		{
			throw null;
		}

		// Token: 0x06000529 RID: 1321 RVA: 0x00002B66 File Offset: 0x00000D66
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000558")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A11C", Offset = "0x1F8A11C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static OnDemandRendering()
		{
			throw null;
		}

		// Token: 0x040003E8 RID: 1000
		[global::Cpp2ILInjected.Token(Token = "0x400042E")]
		private static int m_RenderFrameInterval;
	}
}
