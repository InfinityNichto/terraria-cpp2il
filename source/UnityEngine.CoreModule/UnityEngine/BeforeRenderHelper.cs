using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;

namespace UnityEngine
{
	[global::Cpp2ILInjected.Token(Token = "0x200005F")]
	internal static class BeforeRenderHelper
	{
		[global::Cpp2ILInjected.Token(Token = "0x60001B7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74BD8", Offset = "0x1F74BD8", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Application), Member = "InvokeOnBeforeRender", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<BeforeRenderHelper.OrderBlock>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void Invoke()
		{
			throw null;
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60001B8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F74D5C", Offset = "0x1F74D5C", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<BeforeRenderHelper.OrderBlock>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static BeforeRenderHelper()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x400022E")]
		private static List<BeforeRenderHelper.OrderBlock> s_OrderBlocks;

		[global::Cpp2ILInjected.Token(Token = "0x2000060")]
		private struct OrderBlock
		{
			[global::Cpp2ILInjected.Token(Token = "0x400022F")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
			internal int order;

			[global::Cpp2ILInjected.Token(Token = "0x4000230")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
			internal UnityAction callback;
		}
	}
}
