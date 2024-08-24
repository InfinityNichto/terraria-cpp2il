using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Cinematics;

namespace Terraria.DataStructures
{
	// Token: 0x02000460 RID: 1120
	[global::Cpp2ILInjected.Token(Token = "0x200065C")]
	public class EntitySource_Film : IEntitySource
	{
		// Token: 0x060031DD RID: 12765 RVA: 0x0002AEC9 File Offset: 0x000290C9
		[global::Cpp2ILInjected.Token(Token = "0x60036FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D6BC", Offset = "0x141D6BC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "SpawnWitherBeast", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "SpawnJavalinThrower", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "SpawnGoblin", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "CreateCritters", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "CreateOgre", MemberParameters = new object[] { typeof(FrameEventData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DD2Film), Member = "PlaceNPCOnGround", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DSTFilm), Member = "PlaceNPCOnGround", MemberParameters = new object[]
		{
			typeof(int),
			typeof(Vector2)
		}, ReturnType = typeof(NPC))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public EntitySource_Film()
		{
			throw null;
		}
	}
}
