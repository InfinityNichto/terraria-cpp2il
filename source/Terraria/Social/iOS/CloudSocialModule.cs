using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Microsoft.Xna.Framework;
using Terraria.Social.Base;

namespace Terraria.Social.iOS
{
	// Token: 0x02000385 RID: 901
	[global::Cpp2ILInjected.Token(Token = "0x2000514")]
	public class CloudSocialModule : CloudSocialModule
	{
		// Token: 0x06002D22 RID: 11554 RVA: 0x0002A185 File Offset: 0x00028385
		[global::Cpp2ILInjected.Token(Token = "0x600315B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E3C", Offset = "0x1304E3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "Initialize", ReturnType = typeof(void))]
		public override void Initialize()
		{
			throw null;
		}

		// Token: 0x06002D23 RID: 11555 RVA: 0x0002A188 File Offset: 0x00028388
		[global::Cpp2ILInjected.Token(Token = "0x600315C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E50", Offset = "0x1304E50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Shutdown()
		{
			throw null;
		}

		// Token: 0x06002D24 RID: 11556 RVA: 0x0002A18B File Offset: 0x0002838B
		[global::Cpp2ILInjected.Token(Token = "0x600315D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E54", Offset = "0x1304E54", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		public void SyncFiles(string path)
		{
			throw null;
		}

		// Token: 0x06002D25 RID: 11557 RVA: 0x0002A18E File Offset: 0x0002838E
		[global::Cpp2ILInjected.Token(Token = "0x600315E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E68", Offset = "0x1304E68", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public bool HasFinishedSync()
		{
			throw null;
		}

		// Token: 0x06002D26 RID: 11558 RVA: 0x0002A191 File Offset: 0x00028391
		[global::Cpp2ILInjected.Token(Token = "0x600315F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E48", Offset = "0x1304E48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool IsRequired()
		{
			throw null;
		}

		// Token: 0x06002D27 RID: 11559 RVA: 0x0002A194 File Offset: 0x00028394
		[global::Cpp2ILInjected.Token(Token = "0x6003160")]
		[global::Cpp2ILInjected.Address(RVA = "0x1305024", Offset = "0x1305024", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "PlayerDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "WorldDraw", MemberParameters = new object[]
		{
			typeof(ItemGrid_Layout),
			typeof(int),
			typeof(Vector2),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		public bool IsAvailable()
		{
			throw null;
		}

		// Token: 0x06002D28 RID: 11560 RVA: 0x0002A197 File Offset: 0x00028397
		[global::Cpp2ILInjected.Token(Token = "0x6003161")]
		[global::Cpp2ILInjected.Address(RVA = "0x130502C", Offset = "0x130502C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool IsConnected()
		{
			throw null;
		}

		// Token: 0x06002D29 RID: 11561 RVA: 0x0002A19A File Offset: 0x0002839A
		[global::Cpp2ILInjected.Token(Token = "0x6003162")]
		[global::Cpp2ILInjected.Address(RVA = "0x1305034", Offset = "0x1305034", Length = "0x158")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Substring", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override IEnumerable<string> GetFiles()
		{
			throw null;
		}

		// Token: 0x06002D2A RID: 11562 RVA: 0x0002A19D File Offset: 0x0002839D
		[global::Cpp2ILInjected.Token(Token = "0x6003163")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304F40", Offset = "0x1304F40", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CloudSocialModule), Member = "Write", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = "Match", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Match))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GroupCollection), Member = "get_Item", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Group))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Capture), Member = "get_Value", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static string GetParentFolderPath(string path, bool includeExtension = true)
		{
			throw null;
		}

		// Token: 0x06002D2B RID: 11563 RVA: 0x0002A1A0 File Offset: 0x000283A0
		[global::Cpp2ILInjected.Token(Token = "0x6003164")]
		[global::Cpp2ILInjected.Address(RVA = "0x130518C", Offset = "0x130518C", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "GetParentFolderPath", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(DirectoryInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public override bool Write(string path, byte[] data, int length)
		{
			throw null;
		}

		// Token: 0x06002D2C RID: 11564 RVA: 0x0002A1A3 File Offset: 0x000283A3
		[global::Cpp2ILInjected.Token(Token = "0x6003165")]
		[global::Cpp2ILInjected.Address(RVA = "0x13052AC", Offset = "0x13052AC", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Copy", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(Array),
			typeof(int)
		}, ReturnType = typeof(void))]
		public override void Read(string path, byte[] buffer, int length)
		{
			throw null;
		}

		// Token: 0x06002D2D RID: 11565 RVA: 0x0002A1A6 File Offset: 0x000283A6
		[global::Cpp2ILInjected.Token(Token = "0x6003166")]
		[global::Cpp2ILInjected.Address(RVA = "0x1305310", Offset = "0x1305310", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override bool HasFile(string path)
		{
			throw null;
		}

		// Token: 0x06002D2E RID: 11566 RVA: 0x0002A1A9 File Offset: 0x000283A9
		[global::Cpp2ILInjected.Token(Token = "0x6003167")]
		[global::Cpp2ILInjected.Address(RVA = "0x1305384", Offset = "0x1305384", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "ReadAllBytes", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		public override int GetFileSize(string path)
		{
			throw null;
		}

		// Token: 0x06002D2F RID: 11567 RVA: 0x0002A1AC File Offset: 0x000283AC
		[global::Cpp2ILInjected.Token(Token = "0x6003168")]
		[global::Cpp2ILInjected.Address(RVA = "0x13053A8", Offset = "0x13053A8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Delete", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		public override bool Delete(string path)
		{
			throw null;
		}

		// Token: 0x06002D30 RID: 11568 RVA: 0x0002A1AF File Offset: 0x000283AF
		[global::Cpp2ILInjected.Token(Token = "0x6003169")]
		[global::Cpp2ILInjected.Address(RVA = "0x13053CC", Offset = "0x13053CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Forget(string path)
		{
			throw null;
		}

		// Token: 0x06002D31 RID: 11569 RVA: 0x0002A1B2 File Offset: 0x000283B2
		[global::Cpp2ILInjected.Token(Token = "0x600316A")]
		[global::Cpp2ILInjected.Address(RVA = "0x13053D4", Offset = "0x13053D4", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public CloudSocialModule()
		{
			throw null;
		}

		// Token: 0x06002D32 RID: 11570 RVA: 0x0002A1B5 File Offset: 0x000283B5
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600316B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1305484", Offset = "0x1305484", Length = "0x1094")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Regex), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(RegexOptions)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static CloudSocialModule()
		{
			throw null;
		}

		// Token: 0x040031BC RID: 12732
		[global::Cpp2ILInjected.Token(Token = "0x4003B18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string editorRemoteCache;

		// Token: 0x040031BD RID: 12733
		[global::Cpp2ILInjected.Token(Token = "0x4003B19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string cacheFolder;

		// Token: 0x040031BE RID: 12734
		[global::Cpp2ILInjected.Token(Token = "0x4003B1A")]
		private static Regex FileNameRegex;

		// Token: 0x040031BF RID: 12735
		[global::Cpp2ILInjected.Token(Token = "0x4003B1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string SyncPath;

		// Token: 0x040031C0 RID: 12736
		[global::Cpp2ILInjected.Token(Token = "0x4003B1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private DateTime SyncStarted;
	}
}
