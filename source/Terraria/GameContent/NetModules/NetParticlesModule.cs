using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.GameContent.Drawing;
using Terraria.Net;

namespace Terraria.GameContent.NetModules
{
	// Token: 0x02000673 RID: 1651
	[global::Cpp2ILInjected.Token(Token = "0x20009FA")]
	public class NetParticlesModule : NetModule
	{
		// Token: 0x060040FB RID: 16635 RVA: 0x0002D9CE File Offset: 0x0002BBCE
		[global::Cpp2ILInjected.Token(Token = "0x6004B80")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A9110", Offset = "0x8A9110", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "RequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings),
			typeof(int?)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "BroadcastParticleSpawn", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ParticleOrchestrator), Member = "BroadcastOrRequestParticleSpawn", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NetParticlesModule), Member = "Deserialize", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = "CreatePacket", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetPacket), Member = "get_Writer", ReturnType = typeof(BinaryWriter))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestraSettings), Member = "Serialize", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public static NetPacket Serialize(ParticleOrchestraType particleType, ParticleOrchestraSettings settings)
		{
			throw null;
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x0002D9D1 File Offset: 0x0002BBD1
		[global::Cpp2ILInjected.Token(Token = "0x6004B81")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A91AC", Offset = "0x8A91AC", Length = "0x160")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestraSettings), Member = "DeserializeFrom", MemberParameters = new object[] { typeof(BinaryReader) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_NetHost", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetParticlesModule), Member = "Serialize", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(NetPacket))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetManager), Member = "Broadcast", MemberParameters = new object[]
		{
			typeof(NetPacket),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ParticleOrchestrator), Member = "SpawnParticlesDirect", MemberParameters = new object[]
		{
			typeof(ParticleOrchestraType),
			typeof(ParticleOrchestraSettings)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public override bool Deserialize(BinaryReader reader, int userId)
		{
			throw null;
		}

		// Token: 0x060040FD RID: 16637 RVA: 0x0002D9D4 File Offset: 0x0002BBD4
		[global::Cpp2ILInjected.Token(Token = "0x6004B82")]
		[global::Cpp2ILInjected.Address(RVA = "0x8A930C", Offset = "0x8A930C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NetModule), Member = ".ctor", ReturnType = typeof(void))]
		public NetParticlesModule()
		{
			throw null;
		}
	}
}
