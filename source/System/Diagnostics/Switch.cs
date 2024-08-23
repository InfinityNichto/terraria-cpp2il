using System;
using System.Collections.Generic;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Diagnostics
{
	// Token: 0x02000071 RID: 113
	[global::Cpp2ILInjected.Token(Token = "0x20000C9")]
	public abstract class Switch
	{
		// Token: 0x060003F7 RID: 1015 RVA: 0x00003989 File Offset: 0x00001B89
		[global::Cpp2ILInjected.Token(Token = "0x6000497")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC497C", Offset = "0x1EC497C", Length = "0x60")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TraceSwitch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Switch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		protected Switch(string displayName, string description)
		{
			throw null;
		}

		// Token: 0x060003F8 RID: 1016 RVA: 0x0000398C File Offset: 0x00001B8C
		[global::Cpp2ILInjected.Token(Token = "0x6000498")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC4AA0", Offset = "0x1EC4AA0", Length = "0x230")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Switch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Switch), Member = "_pruneCachedSwitches", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		protected Switch(string displayName, string description, string defaultSwitchValue)
		{
			throw null;
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x0000398F File Offset: 0x00001B8F
		[global::Cpp2ILInjected.Token(Token = "0x6000499")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC4CD0", Offset = "0x1EC4CD0", Length = "0x468")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Switch), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "CollectionCount", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "TrimExcess", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 29)]
		private static void _pruneCachedSwitches()
		{
			throw null;
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00003992 File Offset: 0x00001B92
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600049A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1EC5138", Offset = "0x1EC5138", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		static Switch()
		{
			throw null;
		}

		// Token: 0x0400024C RID: 588
		[global::Cpp2ILInjected.Token(Token = "0x400038D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private readonly string description;

		// Token: 0x0400024D RID: 589
		[global::Cpp2ILInjected.Token(Token = "0x400038E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private readonly string displayName;

		// Token: 0x0400024E RID: 590
		[global::Cpp2ILInjected.Token(Token = "0x400038F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string switchValueString;

		// Token: 0x0400024F RID: 591
		[global::Cpp2ILInjected.Token(Token = "0x4000390")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private string defaultValue;

		// Token: 0x04000250 RID: 592
		[global::Cpp2ILInjected.Token(Token = "0x4000391")]
		private static List<WeakReference> switches;

		// Token: 0x04000251 RID: 593
		[global::Cpp2ILInjected.Token(Token = "0x4000392")]
		private static int s_LastCollectionCount;
	}
}
