using System;
using System.IO;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Terraria.Utilities;
using UnityEngine;

namespace Terraria.IO
{
	// Token: 0x020003C6 RID: 966
	[global::Cpp2ILInjected.Token(Token = "0x2000570")]
	public class OldSaveSynchronise
	{
		// Token: 0x170005FE RID: 1534
		// (get) Token: 0x06002F69 RID: 12137 RVA: 0x0002A785 File Offset: 0x00028985
		[global::Cpp2ILInjected.Token(Token = "0x17000679")]
		private static string OldSaveRoot
		{
			[global::Cpp2ILInjected.Token(Token = "0x60033D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1342D68", Offset = "0x1342D68", Length = "0x22C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OldSaveSynchronise), Member = "CopyOldSaves", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaClass), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "GetStatic", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[] { typeof(string) }, ReturnType = "FieldType")]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(AndroidJavaObject[]), Member = "Call", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
			{
				typeof(string),
				typeof(object[])
			}, ReturnType = "ReturnType")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 17)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06002F6A RID: 12138 RVA: 0x0002A788 File Offset: 0x00028988
		[global::Cpp2ILInjected.Token(Token = "0x60033D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1342F94", Offset = "0x1342F94", Length = "0x92C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadWorlds", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Main), Member = "LoadPlayers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_SavePath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OldSaveSynchronise), Member = "get_OldSaveRoot", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Exists", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_OldPlayerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "CreateDirectory", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_OldWorldPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_PlayerPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Main), Member = "get_WorldPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_persistentDataPath", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Directory), Member = "Exists", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "GetFiles", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Replace", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Move", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Copy", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(File), Member = "Copy", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "Delete", MemberParameters = new object[]
		{
			typeof(string),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(FileUtilities), Member = "WriteAllBytes", MemberParameters = new object[]
		{
			typeof(string),
			typeof(byte[]),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 50)]
		public static void CopyOldSaves()
		{
			throw null;
		}

		// Token: 0x06002F6B RID: 12139 RVA: 0x0002A78B File Offset: 0x0002898B
		[global::Cpp2ILInjected.Token(Token = "0x60033D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x13438C0", Offset = "0x13438C0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public OldSaveSynchronise()
		{
			throw null;
		}

		// Token: 0x040032BA RID: 12986
		[global::Cpp2ILInjected.Token(Token = "0x4003E1A")]
		private static string _oldSaveRoot;
	}
}
