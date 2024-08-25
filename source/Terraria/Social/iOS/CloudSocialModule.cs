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
	[global::Cpp2ILInjected.Token(Token = "0x2000514")]
	public class CloudSocialModule : CloudSocialModule
	{
		[global::Cpp2ILInjected.Token(Token = "0x600315B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E3C", Offset = "0x1304E3C", Length = "0xC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CloudSocialModule), Member = "Initialize", ReturnType = typeof(void))]
		public override void Initialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600315C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E50", Offset = "0x1304E50", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override void Shutdown()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x600315E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E68", Offset = "0x1304E68", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		public bool HasFinishedSync()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x600315F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1304E48", Offset = "0x1304E48", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool IsRequired()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003161")]
		[global::Cpp2ILInjected.Address(RVA = "0x130502C", Offset = "0x130502C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIPlayerSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GUIWorldSelectMenu), Member = "Draw", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		public bool IsConnected()
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x6003169")]
		[global::Cpp2ILInjected.Address(RVA = "0x13053CC", Offset = "0x13053CC", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public override bool Forget(string path)
		{
			throw null;
		}

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

		[global::Cpp2ILInjected.Token(Token = "0x4003B18")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string editorRemoteCache;

		[global::Cpp2ILInjected.Token(Token = "0x4003B19")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string cacheFolder;

		[global::Cpp2ILInjected.Token(Token = "0x4003B1A")]
		private static Regex FileNameRegex;

		[global::Cpp2ILInjected.Token(Token = "0x4003B1B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string SyncPath;

		[global::Cpp2ILInjected.Token(Token = "0x4003B1C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private DateTime SyncStarted;
	}
}
