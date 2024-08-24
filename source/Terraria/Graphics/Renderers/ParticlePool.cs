using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Drawing;

namespace Terraria.Graphics.Renderers
{
	// Token: 0x020004F5 RID: 1269
	[global::Cpp2ILInjected.Token(Token = "0x2000750")]
	public class ParticlePool<T> where T : IPooledParticle
	{
		// Token: 0x0600373D RID: 14141 RVA: 0x0002BDF3 File Offset: 0x00029FF3
		[global::Cpp2ILInjected.Token(Token = "0x6003DB0")]
		[global::Cpp2ILInjected.Address(RVA = "0x181924C", Offset = "0x181924C", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "Spawn_PooFly", MemberParameters = new object[] { typeof(ParticleOrchestraSettings) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public int CountParticlesInUse()
		{
			throw null;
		}

		// Token: 0x0600373E RID: 14142 RVA: 0x0002BDF6 File Offset: 0x00029FF6
		[global::Cpp2ILInjected.Token(Token = "0x6003DB1")]
		[global::Cpp2ILInjected.Address(RVA = "0x181927C", Offset = "0x181927C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public ParticlePool(int initialPoolSize, ParticlePool<T>.ParticleInstantiator instantiator)
		{
			throw null;
		}

		// Token: 0x0600373F RID: 14143 RVA: 0x0002BDF9 File Offset: 0x00029FF9
		[global::Cpp2ILInjected.Token(Token = "0x6003DB2")]
		[global::Cpp2ILInjected.Address(RVA = "0x18192EC", Offset = "0x18192EC", Length = "0x248")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 45)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T RequestParticle()
		{
			throw null;
		}

		// Token: 0x04006785 RID: 26501
		[global::Cpp2ILInjected.Token(Token = "0x4007C6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private ParticlePool<T>.ParticleInstantiator _instantiator;

		// Token: 0x04006786 RID: 26502
		[global::Cpp2ILInjected.Token(Token = "0x4007C6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private List<T> _particles;

		// Token: 0x02000968 RID: 2408
		// (Invoke) Token: 0x06004D4E RID: 19790
		[global::Cpp2ILInjected.Token(Token = "0x2000751")]
		public delegate T ParticleInstantiator();
	}
}
