using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.Serialization;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace System.Collections
{
	// Token: 0x020004EC RID: 1260
	[global::Cpp2ILInjected.Token(Token = "0x20005E0")]
	[global::System.Serializable]
	public sealed class Comparer : IComparer, global::System.Runtime.Serialization.ISerializable
	{
		// Token: 0x06002A32 RID: 10802 RVA: 0x0001BAD0 File Offset: 0x00019CD0
		[global::Cpp2ILInjected.Token(Token = "0x6002D96")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06960", Offset = "0x1C06960", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Comparer), Member = ".cctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList), Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(SortedList), Member = ".ctor", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public Comparer(global::System.Globalization.CultureInfo culture)
		{
			throw null;
		}

		// Token: 0x06002A33 RID: 10803 RVA: 0x0001BAD3 File Offset: 0x00019CD3
		[global::Cpp2ILInjected.Token(Token = "0x6002D97")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C069E4", Offset = "0x1C069E4", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(global::System.RuntimeTypeHandle) }, ReturnType = typeof(global::System.Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "GetValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(global::System.Type)
		}, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		private Comparer(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002A34 RID: 10804 RVA: 0x0001BAD6 File Offset: 0x00019CD6
		[global::Cpp2ILInjected.Token(Token = "0x6002D98")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06B54", Offset = "0x1C06B54", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Runtime.Serialization.SerializationInfo), Member = "AddValue", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentNullException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void GetObjectData(global::System.Runtime.Serialization.SerializationInfo info, global::System.Runtime.Serialization.StreamingContext context)
		{
			throw null;
		}

		// Token: 0x06002A35 RID: 10805 RVA: 0x0001BAD9 File Offset: 0x00019CD9
		[global::Cpp2ILInjected.Token(Token = "0x6002D99")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06BF4", Offset = "0x1C06BF4", Length = "0x200")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(CaseInsensitiveComparer), Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(global::System.Collections.Generic.ObjectComparer<>), Member = "Compare", MemberParameters = new object[] { "T", "T" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "System.InvariantComparer", Member = "Compare", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public int Compare(object a, object b)
		{
			throw null;
		}

		// Token: 0x06002A36 RID: 10806 RVA: 0x0001BADC File Offset: 0x00019CDC
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6002D9A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1C06DF4", Offset = "0x1C06DF4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_CurrentCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparer), Member = ".ctor", MemberParameters = new object[] { typeof(global::System.Globalization.CultureInfo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::System.Globalization.CultureInfo), Member = "get_InvariantCulture", ReturnType = typeof(global::System.Globalization.CultureInfo))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		static Comparer()
		{
			throw null;
		}

		// Token: 0x040015AC RID: 5548
		[global::Cpp2ILInjected.Token(Token = "0x400199C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private global::System.Globalization.CompareInfo _compareInfo;

		// Token: 0x040015AD RID: 5549
		[global::Cpp2ILInjected.Token(Token = "0x400199D")]
		public static readonly Comparer Default;

		// Token: 0x040015AE RID: 5550
		[global::Cpp2ILInjected.Token(Token = "0x400199E")]
		public static readonly Comparer DefaultInvariant;
	}
}
