using System;
using System.Collections;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.ComponentModel
{
	// Token: 0x020002F4 RID: 756
	[global::Cpp2ILInjected.Token(Token = "0x2000405")]
	internal sealed class WeakHashtable : Hashtable
	{
		// Token: 0x06001919 RID: 6425 RVA: 0x000074D5 File Offset: 0x000056D5
		[global::Cpp2ILInjected.Token(Token = "0x6001BF1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8AAB8", Offset = "0x1E8AAB8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateAssociation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = ".ctor", MemberParameters = new object[] { typeof(IEqualityComparer) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal WeakHashtable()
		{
			throw null;
		}

		// Token: 0x0600191A RID: 6426 RVA: 0x000074D8 File Offset: 0x000056D8
		[global::Cpp2ILInjected.Token(Token = "0x6001BF2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8AB1C", Offset = "0x1E8AB1C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "Clear", ReturnType = typeof(void))]
		public override void Clear()
		{
			throw null;
		}

		// Token: 0x0600191B RID: 6427 RVA: 0x000074DB File Offset: 0x000056DB
		[global::Cpp2ILInjected.Token(Token = "0x6001BF3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8AB24", Offset = "0x1E8AB24", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Hashtable), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		public override void Remove(object key)
		{
			throw null;
		}

		// Token: 0x0600191C RID: 6428 RVA: 0x000074DE File Offset: 0x000056DE
		[global::Cpp2ILInjected.Token(Token = "0x6001BF4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8AB2C", Offset = "0x1E8AB2C", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "AddProvider", MemberParameters = new object[]
		{
			typeof(TypeDescriptionProvider),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TypeDescriptor), Member = "CreateAssociation", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakHashtable), Member = "ScavengeKeys", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void SetWeak(object key, object value)
		{
			throw null;
		}

		// Token: 0x0600191D RID: 6429 RVA: 0x000074E1 File Offset: 0x000056E1
		[global::Cpp2ILInjected.Token(Token = "0x6001BF5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8ABC8", Offset = "0x1E8ABC8", Length = "0x680")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(WeakHashtable), Member = "SetWeak", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GC), Member = "GetTotalMemory", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArrayList), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 31)]
		private void ScavengeKeys()
		{
			throw null;
		}

		// Token: 0x0600191E RID: 6430 RVA: 0x000074E4 File Offset: 0x000056E4
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6001BF6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1E8B280", Offset = "0x1E8B280", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		static WeakHashtable()
		{
			throw null;
		}

		// Token: 0x04000F47 RID: 3911
		[global::Cpp2ILInjected.Token(Token = "0x4001387")]
		private static IEqualityComparer _comparer;

		// Token: 0x04000F48 RID: 3912
		[global::Cpp2ILInjected.Token(Token = "0x4001388")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		private long _lastGlobalMem;

		// Token: 0x04000F49 RID: 3913
		[global::Cpp2ILInjected.Token(Token = "0x4001389")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private int _lastHashCount;

		// Token: 0x0200046F RID: 1135
		[global::Cpp2ILInjected.Token(Token = "0x2000406")]
		private class WeakKeyComparer : IEqualityComparer
		{
			// Token: 0x06001F45 RID: 8005 RVA: 0x0000864E File Offset: 0x0000684E
			[global::Cpp2ILInjected.Token(Token = "0x6001BF7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8B2F8", Offset = "0x1E8B2F8", Length = "0x15C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private bool System.Collections.IEqualityComparer.Equals(object x, object y)
			{
				throw null;
			}

			// Token: 0x06001F46 RID: 8006 RVA: 0x00008651 File Offset: 0x00006851
			[global::Cpp2ILInjected.Token(Token = "0x6001BF8")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8B454", Offset = "0x1E8B454", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			private int System.Collections.IEqualityComparer.GetHashCode(object obj)
			{
				throw null;
			}

			// Token: 0x06001F47 RID: 8007 RVA: 0x00008654 File Offset: 0x00006854
			[global::Cpp2ILInjected.Token(Token = "0x6001BF9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8B2F0", Offset = "0x1E8B2F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public WeakKeyComparer()
			{
				throw null;
			}
		}

		// Token: 0x02000470 RID: 1136
		[global::Cpp2ILInjected.Token(Token = "0x2000407")]
		private sealed class EqualityWeakReference : WeakReference
		{
			// Token: 0x06001F48 RID: 8008 RVA: 0x00008657 File Offset: 0x00006857
			[global::Cpp2ILInjected.Token(Token = "0x6001BFA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8B248", Offset = "0x1E8B248", Length = "0x38")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(WeakReference), Member = ".ctor", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			internal EqualityWeakReference(object o)
			{
				throw null;
			}

			// Token: 0x06001F49 RID: 8009 RVA: 0x0000865A File Offset: 0x0000685A
			[global::Cpp2ILInjected.Token(Token = "0x6001BFB")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8B464", Offset = "0x1E8B464", Length = "0x7C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override bool Equals(object o)
			{
				throw null;
			}

			// Token: 0x06001F4A RID: 8010 RVA: 0x0000865D File Offset: 0x0000685D
			[global::Cpp2ILInjected.Token(Token = "0x6001BFC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1E8B4E0", Offset = "0x1E8B4E0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			public override int GetHashCode()
			{
				throw null;
			}

			// Token: 0x040013BC RID: 5052
			[global::Cpp2ILInjected.Token(Token = "0x400138A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			private int _hashCode;
		}
	}
}
