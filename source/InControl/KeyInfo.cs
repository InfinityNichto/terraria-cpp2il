using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x0200000D RID: 13
	[global::Cpp2ILInjected.Token(Token = "0x200000D")]
	public struct KeyInfo
	{
		// Token: 0x06000060 RID: 96 RVA: 0x00002189 File Offset: 0x00000389
		[global::Cpp2ILInjected.Token(Token = "0x6000060")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B910", Offset = "0x197B910", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private KeyInfo(Key key, string name, params KeyCode[] keyCodes)
		{
			throw null;
		}

		// Token: 0x06000061 RID: 97 RVA: 0x0000218C File Offset: 0x0000038C
		[global::Cpp2ILInjected.Token(Token = "0x6000061")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B920", Offset = "0x197B920", Length = "0x10")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private KeyInfo(Key key, string name, string macName, params KeyCode[] keyCodes)
		{
			throw null;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x06000062 RID: 98 RVA: 0x0000218F File Offset: 0x0000038F
		[global::Cpp2ILInjected.Token(Token = "0x17000019")]
		public bool IsPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000062")]
			[global::Cpp2ILInjected.Address(RVA = "0x197B6B8", Offset = "0x197B6B8", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyCombo), Member = "get_IsPressed", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyCombo), Member = "Detect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(KeyCombo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Input), Member = "GetKey", MemberParameters = new object[] { typeof(KeyCode) }, ReturnType = typeof(bool))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000063 RID: 99 RVA: 0x00002192 File Offset: 0x00000392
		[global::Cpp2ILInjected.Token(Token = "0x1700001A")]
		public string Name
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000063")]
			[global::Cpp2ILInjected.Address(RVA = "0x197B72C", Offset = "0x197B72C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(KeyCombo), Member = "ToString", ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_platform", ReturnType = typeof(RuntimePlatform))]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000064 RID: 100 RVA: 0x00002195 File Offset: 0x00000395
		[global::Cpp2ILInjected.Token(Token = "0x1700001B")]
		public Key Key
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000064")]
			[global::Cpp2ILInjected.Address(RVA = "0x197B930", Offset = "0x197B930", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00002198 File Offset: 0x00000398
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000065")]
		[global::Cpp2ILInjected.Address(RVA = "0x197B938", Offset = "0x197B938", Length = "0x239C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 272)]
		static KeyInfo()
		{
			throw null;
		}

		// Token: 0x040000AD RID: 173
		[global::Cpp2ILInjected.Token(Token = "0x40000AD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x0")]
		private readonly Key key;

		// Token: 0x040000AE RID: 174
		[global::Cpp2ILInjected.Token(Token = "0x40000AE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x8")]
		private readonly string name;

		// Token: 0x040000AF RID: 175
		[global::Cpp2ILInjected.Token(Token = "0x40000AF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string macName;

		// Token: 0x040000B0 RID: 176
		[global::Cpp2ILInjected.Token(Token = "0x40000B0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly KeyCode[] keyCodes;

		// Token: 0x040000B1 RID: 177
		[global::Cpp2ILInjected.Token(Token = "0x40000B1")]
		public static readonly KeyInfo[] KeyList;
	}
}
