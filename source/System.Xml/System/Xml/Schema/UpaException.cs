using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Xml.Schema
{
	// Token: 0x0200009A RID: 154
	[global::Cpp2ILInjected.Token(Token = "0x20000C4")]
	internal class UpaException : Exception
	{
		// Token: 0x06000783 RID: 1923 RVA: 0x000044ED File Offset: 0x000026ED
		[global::Cpp2ILInjected.Token(Token = "0x6000811")]
		[global::Cpp2ILInjected.Address(RVA = "0x1DB4480", Offset = "0x1DB4480", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckCMUPAWithLeafRangeNodes", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleContentValidator), Member = "CheckUniqueParticleAttribution", MemberParameters = new object[] { typeof(BitSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public UpaException(object particle1, object particle2)
		{
			throw null;
		}

		// Token: 0x040002A6 RID: 678
		[global::Cpp2ILInjected.Token(Token = "0x4000418")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private object particle1;

		// Token: 0x040002A7 RID: 679
		[global::Cpp2ILInjected.Token(Token = "0x4000419")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private object particle2;
	}
}
