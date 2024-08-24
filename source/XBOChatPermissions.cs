using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200002A RID: 42
[global::Cpp2ILInjected.Token(Token = "0x2000046")]
public static class XBOChatPermissions
{
	// Token: 0x06000104 RID: 260 RVA: 0x00021E84 File Offset: 0x00020084
	[global::Cpp2ILInjected.Token(Token = "0x600017E")]
	[global::Cpp2ILInjected.Address(RVA = "0x7056D0", Offset = "0x7056D0", Length = "0x1D0")]
	[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
	[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(XNAUnityRunner), Member = "OnApplicationPause", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "GetEnumerator", ReturnType = "Enumerator<TKey, TValue>")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = "Clear", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
	public static void Reset()
	{
		throw null;
	}

	// Token: 0x06000105 RID: 261 RVA: 0x00021E87 File Offset: 0x00020087
	[global::Cpp2ILInjected.Token(Token = "0x600017F")]
	[global::Cpp2ILInjected.Address(RVA = "0x7058A8", Offset = "0x7058A8", Length = "0x1C0")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = "Add", MemberParameters = new object[]
	{
		typeof(object),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = "get_Item", MemberParameters = new object[] { typeof(object) }, ReturnType = "TValue")]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
	public static void CanChatWith(string xboPlayerId, XBOChatPermissions.ChatPermissionsResult result)
	{
		throw null;
	}

	// Token: 0x06000106 RID: 262 RVA: 0x00021E8A File Offset: 0x0002008A
	[global::Cpp2ILInjected.Token(Token = "0x6000180")]
	[global::Cpp2ILInjected.Address(RVA = "0x705B04", Offset = "0x705B04", Length = "0x88")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = "Add", MemberParameters = new object[]
	{
		typeof(object),
		typeof(bool)
	}, ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
	public static void SetPermissions(string xboPlayerId, bool canCommunicate)
	{
		throw null;
	}

	// Token: 0x06000107 RID: 263 RVA: 0x00021E8D File Offset: 0x0002008D
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x6000181")]
	[global::Cpp2ILInjected.Address(RVA = "0x705B8C", Offset = "0x705B8C", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	static XBOChatPermissions()
	{
		throw null;
	}

	// Token: 0x040000BE RID: 190
	[global::Cpp2ILInjected.Token(Token = "0x4000113")]
	private static Dictionary<string, XBOChatPermissions.RequestResult> _inprogress;

	// Token: 0x040000BF RID: 191
	[global::Cpp2ILInjected.Token(Token = "0x4000114")]
	private static Dictionary<string, bool> _cachedChatPermissions;

	// Token: 0x0200077E RID: 1918
	// (Invoke) Token: 0x0600484E RID: 18510
	[global::Cpp2ILInjected.Token(Token = "0x2000047")]
	public delegate void ChatPermissionsResult(string playerId, bool result);

	// Token: 0x0200077F RID: 1919
	[global::Cpp2ILInjected.Token(Token = "0x2000048")]
	public class RequestResult
	{
		// Token: 0x06004851 RID: 18513 RVA: 0x0002EE5C File Offset: 0x0002D05C
		[global::Cpp2ILInjected.Token(Token = "0x6000186")]
		[global::Cpp2ILInjected.Address(RVA = "0x7058A0", Offset = "0x7058A0", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x14000061 RID: 97
		// (add) Token: 0x06004852 RID: 18514 RVA: 0x0002EE5F File Offset: 0x0002D05F
		// (remove) Token: 0x06004853 RID: 18515 RVA: 0x0002EE62 File Offset: 0x0002D062
		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		public event XBOChatPermissions.ChatPermissionsResult ResultCallbacks
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000187")]
			[global::Cpp2ILInjected.Address(RVA = "0x705A68", Offset = "0x705A68", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000188")]
			[global::Cpp2ILInjected.Address(RVA = "0x705DFC", Offset = "0x705DFC", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x06004854 RID: 18516 RVA: 0x0002EE65 File Offset: 0x0002D065
		[global::Cpp2ILInjected.Token(Token = "0x6000189")]
		[global::Cpp2ILInjected.Address(RVA = "0x705E98", Offset = "0x705E98", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RequestResult()
		{
			throw null;
		}

		// Token: 0x0400783A RID: 30778
		[global::Cpp2ILInjected.Token(Token = "0x4000115")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string xboPlayerId;

		// Token: 0x0400783B RID: 30779
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x4000116")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XBOChatPermissions.ChatPermissionsResult ResultCallbacks;
	}
}
