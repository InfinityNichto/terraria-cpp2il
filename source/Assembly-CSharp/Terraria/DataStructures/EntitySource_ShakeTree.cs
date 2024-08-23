using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;

namespace Terraria.DataStructures
{
	// Token: 0x0200045B RID: 1115
	[global::Cpp2ILInjected.Token(Token = "0x2000657")]
	public class EntitySource_ShakeTree : AEntitySource_Tile
	{
		// Token: 0x060031D8 RID: 12760 RVA: 0x0002AEBA File Offset: 0x000290BA
		[global::Cpp2ILInjected.Token(Token = "0x60036F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x141D604", Offset = "0x141D604", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GetNPCSource_ShakeTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EntitySource_ShakeTree))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GetProjectileSource_ShakeTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EntitySource_ShakeTree))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GetItemSource_ShakeTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(EntitySource_ShakeTree))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "ShakeTree", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldGen), Member = "GetItemSource_FromTreeShake", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(IEntitySource))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Point), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		public EntitySource_ShakeTree(int tileCoordsX, int tileCoordsY)
		{
			throw null;
		}
	}
}
