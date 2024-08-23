using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.EventSystems
{
	// Token: 0x0200006C RID: 108
	[global::Cpp2ILInjected.Token(Token = "0x20000BB")]
	internal static class RaycasterManager
	{
		// Token: 0x06000629 RID: 1577 RVA: 0x00003220 File Offset: 0x00001420
		[global::Cpp2ILInjected.Token(Token = "0x60006C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED2B0", Offset = "0x1FED2B0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseRaycaster), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public static void AddRaycaster(BaseRaycaster baseRaycaster)
		{
			throw null;
		}

		// Token: 0x0600062A RID: 1578 RVA: 0x00003223 File Offset: 0x00001423
		[global::Cpp2ILInjected.Token(Token = "0x60006C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED3B4", Offset = "0x1FED3B4", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static List<BaseRaycaster> GetRaycasters()
		{
			throw null;
		}

		// Token: 0x0600062B RID: 1579 RVA: 0x00003226 File Offset: 0x00001426
		[global::Cpp2ILInjected.Token(Token = "0x60006C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED40C", Offset = "0x1FED40C", Length = "0xC4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(BaseRaycaster), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void RemoveRaycasters(BaseRaycaster baseRaycaster)
		{
			throw null;
		}

		// Token: 0x0600062C RID: 1580 RVA: 0x00003229 File Offset: 0x00001429
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x60006C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FED4D0", Offset = "0x1FED4D0", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static RaycasterManager()
		{
			throw null;
		}

		// Token: 0x04000222 RID: 546
		[global::Cpp2ILInjected.Token(Token = "0x4000316")]
		private static readonly List<BaseRaycaster> s_Raycasters;
	}
}
