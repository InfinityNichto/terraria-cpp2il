using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameContent.ObjectInteractions
{
	// Token: 0x020005A9 RID: 1449
	[global::Cpp2ILInjected.Token(Token = "0x2000848")]
	public class SmartInteractSystem
	{
		// Token: 0x06003BF7 RID: 15351 RVA: 0x0002CB5B File Offset: 0x0002AD5B
		[global::Cpp2ILInjected.Token(Token = "0x600431A")]
		[global::Cpp2ILInjected.Address(RVA = "0x79E55C", Offset = "0x79E55C", Length = "0x3C4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PotionOfReturnSmartInteractCandidateProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ProjectileSmartInteractCandidateProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NPCSmartInteractCandidateProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TileSmartInteractCandidateProvider), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 22)]
		public SmartInteractSystem()
		{
			throw null;
		}

		// Token: 0x06003BF8 RID: 15352 RVA: 0x0002CB5E File Offset: 0x0002AD5E
		[global::Cpp2ILInjected.Token(Token = "0x600431B")]
		[global::Cpp2ILInjected.Address(RVA = "0x79EAF0", Offset = "0x79EAF0", Length = "0x1C8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SmartInteractLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SmartInteractSystem), Member = "RunQuery", MemberParameters = new object[] { typeof(SmartInteractScanSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x06003BF9 RID: 15353 RVA: 0x0002CB61 File Offset: 0x0002AD61
		[global::Cpp2ILInjected.Token(Token = "0x600431C")]
		[global::Cpp2ILInjected.Address(RVA = "0x79ECB8", Offset = "0x79ECB8", Length = "0x6D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "SmartInteractLookup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(SmartInteractSystem), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 35)]
		public void RunQuery(SmartInteractScanSettings settings)
		{
			throw null;
		}

		// Token: 0x04006B4A RID: 27466
		[global::Cpp2ILInjected.Token(Token = "0x400814B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private List<ISmartInteractCandidateProvider> _candidateProvidersByOrderOfPriority;

		// Token: 0x04006B4B RID: 27467
		[global::Cpp2ILInjected.Token(Token = "0x400814C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<ISmartInteractBlockReasonProvider> _blockProviders;

		// Token: 0x04006B4C RID: 27468
		[global::Cpp2ILInjected.Token(Token = "0x400814D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<ISmartInteractCandidate> _candidates;
	}
}
