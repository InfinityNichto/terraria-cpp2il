using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.IO;

namespace Terraria.GameContent.Creative
{
	// Token: 0x02000681 RID: 1665
	[global::Cpp2ILInjected.Token(Token = "0x2000A14")]
	public class CreativeUnlocksTracker : IPersistentPerWorldContent, IOnPlayerJoining
	{
		// Token: 0x06004196 RID: 16790 RVA: 0x0002DB9F File Offset: 0x0002BD9F
		[global::Cpp2ILInjected.Token(Token = "0x6004C2B")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7D04", Offset = "0x8B7D04", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "InternalSavePlayerFile", MemberParameters = new object[] { typeof(PlayerFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x06004197 RID: 16791 RVA: 0x0002DBA2 File Offset: 0x0002BDA2
		[global::Cpp2ILInjected.Token(Token = "0x6004C2C")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B7F08", Offset = "0x8B7F08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadTutorialPlayer", ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = "LoadPlayer", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(PlayerFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void Load(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06004198 RID: 16792 RVA: 0x0002DBA5 File Offset: 0x0002BDA5
		[global::Cpp2ILInjected.Token(Token = "0x6004C2D")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B810C", Offset = "0x8B810C", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void ValidateWorld(BinaryReader reader, int gameVersionSaveWasMadeOn)
		{
			throw null;
		}

		// Token: 0x06004199 RID: 16793 RVA: 0x0002DBA8 File Offset: 0x0002BDA8
		[global::Cpp2ILInjected.Token(Token = "0x6004C2E")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B8110", Offset = "0x8B8110", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x0600419A RID: 16794 RVA: 0x0002DBAB File Offset: 0x0002BDAB
		[global::Cpp2ILInjected.Token(Token = "0x6004C2F")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B8198", Offset = "0x8B8198", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void OnPlayerJoining(int playerIndex)
		{
			throw null;
		}

		// Token: 0x0600419B RID: 16795 RVA: 0x0002DBAE File Offset: 0x0002BDAE
		[global::Cpp2ILInjected.Token(Token = "0x6004C30")]
		[global::Cpp2ILInjected.Address(RVA = "0x8B81A0", Offset = "0x8B81A0", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Player), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ItemsSacrificedUnlocksTracker), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public CreativeUnlocksTracker()
		{
			throw null;
		}

		// Token: 0x04006DC8 RID: 28104
		[global::Cpp2ILInjected.Token(Token = "0x400864D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public ItemsSacrificedUnlocksTracker ItemSacrifices;
	}
}
