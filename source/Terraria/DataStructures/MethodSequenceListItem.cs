using System;
using System.Collections.Generic;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.DataStructures
{
	// Token: 0x0200043B RID: 1083
	[global::Cpp2ILInjected.Token(Token = "0x2000636")]
	public class MethodSequenceListItem
	{
		// Token: 0x06003110 RID: 12560 RVA: 0x0002AC62 File Offset: 0x00028E62
		[global::Cpp2ILInjected.Token(Token = "0x600362D")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCBE0", Offset = "0x13DCBE0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public MethodSequenceListItem(string name, Func<bool> method, MethodSequenceListItem parent = null)
		{
			throw null;
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x0002AC65 File Offset: 0x00028E65
		[global::Cpp2ILInjected.Token(Token = "0x600362E")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCC1C", Offset = "0x13DCC1C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(MethodSequenceListItem), Member = "ExecuteSequence", MemberParameters = new object[] { typeof(List<MethodSequenceListItem>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool ShouldAct(List<MethodSequenceListItem> sequence)
		{
			throw null;
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x0002AC68 File Offset: 0x00028E68
		[global::Cpp2ILInjected.Token(Token = "0x600362F")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCC94", Offset = "0x13DCC94", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public bool Act()
		{
			throw null;
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x0002AC6B File Offset: 0x00028E6B
		[global::Cpp2ILInjected.Token(Token = "0x6003630")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCCA8", Offset = "0x13DCCA8", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodSequenceListItem), Member = "ShouldAct", MemberParameters = new object[] { typeof(List<MethodSequenceListItem>) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static void ExecuteSequence(List<MethodSequenceListItem> sequence)
		{
			throw null;
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x0002AC6E File Offset: 0x00028E6E
		[global::Cpp2ILInjected.Token(Token = "0x6003631")]
		[global::Cpp2ILInjected.Address(RVA = "0x13DCDF8", Offset = "0x13DCDF8", Length = "0x190")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(bool), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[] { typeof(string[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x04006304 RID: 25348
		[global::Cpp2ILInjected.Token(Token = "0x40076EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public string Name;

		// Token: 0x04006305 RID: 25349
		[global::Cpp2ILInjected.Token(Token = "0x40076EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public MethodSequenceListItem Parent;

		// Token: 0x04006306 RID: 25350
		[global::Cpp2ILInjected.Token(Token = "0x40076F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public Func<bool> Method;

		// Token: 0x04006307 RID: 25351
		[global::Cpp2ILInjected.Token(Token = "0x40076F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public bool Skip;
	}
}
