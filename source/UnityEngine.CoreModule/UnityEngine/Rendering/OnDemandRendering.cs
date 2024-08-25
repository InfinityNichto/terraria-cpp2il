using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Scripting;

namespace UnityEngine.Rendering
{
	[RequiredByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x2000104")]
	public class OnDemandRendering
	{
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

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000558")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8A11C", Offset = "0x1F8A11C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static OnDemandRendering()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400042E")]
		private static int m_RenderFrameInterval;
	}
}
