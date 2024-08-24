using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

// Token: 0x0200002E RID: 46
[global::Cpp2ILInjected.Token(Token = "0x200004C")]
public static class XBOOnlinePresencePermissions
{
	// Token: 0x06000117 RID: 279 RVA: 0x00021EBD File Offset: 0x000200BD
	[global::Cpp2ILInjected.Token(Token = "0x6000199")]
	[global::Cpp2ILInjected.Address(RVA = "0x705F84", Offset = "0x705F84", Length = "0x1D0")]
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

	// Token: 0x06000118 RID: 280 RVA: 0x00021EC0 File Offset: 0x000200C0
	[global::Cpp2ILInjected.Token(Token = "0x600019A")]
	[global::Cpp2ILInjected.Address(RVA = "0x70615C", Offset = "0x70615C", Length = "0x1BC")]
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
	public static void CanSeeOnlinePresence(string xboPlayerId, XBOOnlinePresencePermissions.OnlinePresencePermissionsResult result)
	{
		throw null;
	}

	// Token: 0x06000119 RID: 281 RVA: 0x00021EC3 File Offset: 0x000200C3
	[global::Cpp2ILInjected.Token(Token = "0x600019B")]
	[global::Cpp2ILInjected.Address(RVA = "0x7063B4", Offset = "0x7063B4", Length = "0x88")]
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

	// Token: 0x0600011A RID: 282 RVA: 0x00021EC6 File Offset: 0x000200C6
	// Note: this type is marked as 'beforefieldinit'.
	[global::Cpp2ILInjected.Token(Token = "0x600019C")]
	[global::Cpp2ILInjected.Address(RVA = "0x70643C", Offset = "0x70643C", Length = "0xDC")]
	[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, bool>), Member = ".ctor", ReturnType = typeof(void))]
	[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
	static XBOOnlinePresencePermissions()
	{
		throw null;
	}

	// Token: 0x040000C1 RID: 193
	[global::Cpp2ILInjected.Token(Token = "0x4000118")]
	private static Dictionary<string, XBOOnlinePresencePermissions.RequestResult> _inprogress;

	// Token: 0x040000C2 RID: 194
	[global::Cpp2ILInjected.Token(Token = "0x4000119")]
	private static Dictionary<string, bool> _cachedOnlinePresencePermissions;

	// Token: 0x02000780 RID: 1920
	// (Invoke) Token: 0x06004856 RID: 18518
	[global::Cpp2ILInjected.Token(Token = "0x200004D")]
	public delegate void OnlinePresencePermissionsResult(string playerId, bool result);

	// Token: 0x02000781 RID: 1921
	[global::Cpp2ILInjected.Token(Token = "0x200004E")]
	public class RequestResult
	{
		// Token: 0x06004859 RID: 18521 RVA: 0x0002EE68 File Offset: 0x0002D068
		[global::Cpp2ILInjected.Token(Token = "0x60001A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x706154", Offset = "0x706154", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		public void Clear()
		{
			throw null;
		}

		// Token: 0x14000062 RID: 98
		// (add) Token: 0x0600485A RID: 18522 RVA: 0x0002EE6B File Offset: 0x0002D06B
		// (remove) Token: 0x0600485B RID: 18523 RVA: 0x0002EE6E File Offset: 0x0002D06E
		[global::Cpp2ILInjected.Token(Token = "0x14000004")]
		public event XBOOnlinePresencePermissions.OnlinePresencePermissionsResult ResultCallbacks
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60001A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x706318", Offset = "0x706318", Length = "0x9C")]
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
			[global::Cpp2ILInjected.Token(Token = "0x60001A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x7066AC", Offset = "0x7066AC", Length = "0x9C")]
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

		// Token: 0x0600485C RID: 18524 RVA: 0x0002EE71 File Offset: 0x0002D071
		[global::Cpp2ILInjected.Token(Token = "0x60001A4")]
		[global::Cpp2ILInjected.Address(RVA = "0x706748", Offset = "0x706748", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public RequestResult()
		{
			throw null;
		}

		// Token: 0x0400783C RID: 30780
		[global::Cpp2ILInjected.Token(Token = "0x400011A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string xboPlayerId;

		// Token: 0x0400783D RID: 30781
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x400011B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private XBOOnlinePresencePermissions.OnlinePresencePermissionsResult ResultCallbacks;
	}
}
