﻿using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace UnityEngine.SocialPlatforms.Impl
{
	// Token: 0x0200000E RID: 14
	[global::Cpp2ILInjected.Token(Token = "0x200000E")]
	public class UserProfile : IUserProfile
	{
		// Token: 0x06000016 RID: 22 RVA: 0x0000207D File Offset: 0x0000027D
		[global::Cpp2ILInjected.Token(Token = "0x6000016")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F93BF8", Offset = "0x1F93BF8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUser), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Texture2D), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public UserProfile()
		{
			throw null;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00002080 File Offset: 0x00000280
		[global::Cpp2ILInjected.Token(Token = "0x6000017")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F93810", Offset = "0x1F93810", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UserProfile(string name, string id, bool friend, UserState state, Texture2D image)
		{
			throw null;
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00002083 File Offset: 0x00000283
		[global::Cpp2ILInjected.Token(Token = "0x6000018")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F93D6C", Offset = "0x1F93D6C", Length = "0x58")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public UserProfile(string name, string teamId, string gameId, bool friend, UserState state, Texture2D image)
		{
			throw null;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002086 File Offset: 0x00000286
		[global::Cpp2ILInjected.Token(Token = "0x6000019")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F93DC4", Offset = "0x1F93DC4", Length = "0x1B8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00002089 File Offset: 0x00000289
		[global::Cpp2ILInjected.Token(Token = "0x600001A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F93800", Offset = "0x1F93800", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetUserName(string name)
		{
			throw null;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x0000208C File Offset: 0x0000028C
		[global::Cpp2ILInjected.Token(Token = "0x600001B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F937F8", Offset = "0x1F937F8", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetUserID(string id)
		{
			throw null;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x0000208F File Offset: 0x0000028F
		[global::Cpp2ILInjected.Token(Token = "0x600001C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F93808", Offset = "0x1F93808", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void SetImage(Texture2D image)
		{
			throw null;
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x0600001D RID: 29 RVA: 0x00002092 File Offset: 0x00000292
		[global::Cpp2ILInjected.Token(Token = "0x1700000A")]
		public string userName
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F93F84", Offset = "0x1F93F84", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x0600001E RID: 30 RVA: 0x00002095 File Offset: 0x00000295
		[global::Cpp2ILInjected.Token(Token = "0x1700000B")]
		public string id
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F93F7C", Offset = "0x1F93F7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000C RID: 12
		// (get) Token: 0x0600001F RID: 31 RVA: 0x00002098 File Offset: 0x00000298
		[global::Cpp2ILInjected.Token(Token = "0x1700000C")]
		public bool isFriend
		{
			[global::Cpp2ILInjected.Token(Token = "0x600001F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F93F8C", Offset = "0x1F93F8C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700000D RID: 13
		// (get) Token: 0x06000020 RID: 32 RVA: 0x0000209B File Offset: 0x0000029B
		[global::Cpp2ILInjected.Token(Token = "0x1700000D")]
		public UserState state
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000020")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F93F94", Offset = "0x1F93F94", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0400001B RID: 27
		[global::Cpp2ILInjected.Token(Token = "0x400001B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		protected string m_UserName;

		// Token: 0x0400001C RID: 28
		[global::Cpp2ILInjected.Token(Token = "0x400001C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		protected string m_ID;

		// Token: 0x0400001D RID: 29
		[global::Cpp2ILInjected.Token(Token = "0x400001D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_legacyID;

		// Token: 0x0400001E RID: 30
		[global::Cpp2ILInjected.Token(Token = "0x400001E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		protected bool m_IsFriend;

		// Token: 0x0400001F RID: 31
		[global::Cpp2ILInjected.Token(Token = "0x400001F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x2C")]
		protected UserState m_State;

		// Token: 0x04000020 RID: 32
		[global::Cpp2ILInjected.Token(Token = "0x4000020")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		protected Texture2D m_Image;

		// Token: 0x04000021 RID: 33
		[global::Cpp2ILInjected.Token(Token = "0x4000021")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private string m_gameID;
	}
}