using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;

namespace Terraria.IO
{
	// Token: 0x020003BA RID: 954
	[global::Cpp2ILInjected.Token(Token = "0x200055E")]
	public abstract class FileData
	{
		// Token: 0x170005F1 RID: 1521
		// (get) Token: 0x06002F01 RID: 12033 RVA: 0x0002A656 File Offset: 0x00028856
		[global::Cpp2ILInjected.Token(Token = "0x1700066C")]
		public string Path
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003366")]
			[global::Cpp2ILInjected.Address(RVA = "0x133B8F4", Offset = "0x133B8F4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F2 RID: 1522
		// (get) Token: 0x06002F02 RID: 12034 RVA: 0x0002A659 File Offset: 0x00028859
		[global::Cpp2ILInjected.Token(Token = "0x1700066D")]
		public bool IsCloudSave
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003367")]
			[global::Cpp2ILInjected.Address(RVA = "0x133B8FC", Offset = "0x133B8FC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x170005F3 RID: 1523
		// (get) Token: 0x06002F03 RID: 12035 RVA: 0x0002A65C File Offset: 0x0002885C
		[global::Cpp2ILInjected.Token(Token = "0x1700066E")]
		public bool IsFavorite
		{
			[global::Cpp2ILInjected.Token(Token = "0x6003368")]
			[global::Cpp2ILInjected.Address(RVA = "0x133B904", Offset = "0x133B904", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002F04 RID: 12036 RVA: 0x0002A65F File Offset: 0x0002885F
		[global::Cpp2ILInjected.Token(Token = "0x6003369")]
		[global::Cpp2ILInjected.Address(RVA = "0x133B90C", Offset = "0x133B90C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		protected FileData(string type)
		{
			throw null;
		}

		// Token: 0x06002F05 RID: 12037 RVA: 0x0002A662 File Offset: 0x00028862
		[global::Cpp2ILInjected.Token(Token = "0x600336A")]
		[global::Cpp2ILInjected.Address(RVA = "0x133B934", Offset = "0x133B934", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFileData), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "IsFavorite", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected FileData(string type, string path, bool isCloud)
		{
			throw null;
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x0002A665 File Offset: 0x00028865
		[global::Cpp2ILInjected.Token(Token = "0x600336B")]
		[global::Cpp2ILInjected.Address(RVA = "0x133B9EC", Offset = "0x133B9EC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void UpdatePath(string newPath)
		{
			throw null;
		}

		// Token: 0x06002F07 RID: 12039 RVA: 0x0002A668 File Offset: 0x00028868
		[global::Cpp2ILInjected.Token(Token = "0x600336C")]
		[global::Cpp2ILInjected.Address(RVA = "0x133B9F4", Offset = "0x133B9F4", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public void ToggleFavorite()
		{
			throw null;
		}

		// Token: 0x06002F08 RID: 12040 RVA: 0x0002A66B File Offset: 0x0002886B
		[global::Cpp2ILInjected.Token(Token = "0x600336D")]
		[global::Cpp2ILInjected.Address(RVA = "0x133B304", Offset = "0x133B304", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "RefreshPlayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FavoritesFile), Member = "SaveFavorite", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FavoritesFile), Member = "ClearEntry", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(FavoritesFile), Member = "IsFavorite", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "MoveToCloud", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerFileData), Member = "MoveToLocal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "GetFileName", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string GetFileName(bool includeExtension = true)
		{
			throw null;
		}

		// Token: 0x06002F09 RID: 12041 RVA: 0x0002A66E File Offset: 0x0002886E
		[global::Cpp2ILInjected.Token(Token = "0x600336E")]
		[global::Cpp2ILInjected.Address(RVA = "0x133BA08", Offset = "0x133BA08", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "SelectAndHighlight", MemberParameters = new object[] { typeof(WorldFileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WorldFile), Member = "CreateMetadata", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool),
			typeof(int)
		}, ReturnType = typeof(WorldFileData))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_LocalFavoriteData", ReturnType = typeof(FavoritesFile))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FavoritesFile), Member = "SaveFavorite", MemberParameters = new object[] { typeof(FileData) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetFavorite(bool favorite, bool saveChanges = true)
		{
			throw null;
		}

		// Token: 0x06002F0A RID: 12042
		[global::Cpp2ILInjected.Token(Token = "0x600336F")]
		public abstract void SetAsActive();

		// Token: 0x06002F0B RID: 12043
		[global::Cpp2ILInjected.Token(Token = "0x6003370")]
		public abstract void MoveToCloud();

		// Token: 0x06002F0C RID: 12044
		[global::Cpp2ILInjected.Token(Token = "0x6003371")]
		public abstract void MoveToLocal();

		// Token: 0x04003280 RID: 12928
		[global::Cpp2ILInjected.Token(Token = "0x4003C35")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected string _path;

		// Token: 0x04003281 RID: 12929
		[global::Cpp2ILInjected.Token(Token = "0x4003C36")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected bool _isCloudSave;

		// Token: 0x04003282 RID: 12930
		[global::Cpp2ILInjected.Token(Token = "0x4003C37")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public FileMetadata Metadata;

		// Token: 0x04003283 RID: 12931
		[global::Cpp2ILInjected.Token(Token = "0x4003C38")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public string Name;

		// Token: 0x04003284 RID: 12932
		[global::Cpp2ILInjected.Token(Token = "0x4003C39")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		public readonly string Type;

		// Token: 0x04003285 RID: 12933
		[global::Cpp2ILInjected.Token(Token = "0x4003C3A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		protected bool _isFavorite;
	}
}
