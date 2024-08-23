using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameInput
{
	// Token: 0x020004B8 RID: 1208
	[global::Cpp2ILInjected.Token(Token = "0x20006D0")]
	public class TriggersPack
	{
		// Token: 0x06003491 RID: 13457 RVA: 0x0002B63A File Offset: 0x0002983A
		[global::Cpp2ILInjected.Token(Token = "0x60039FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x147052C", Offset = "0x147052C", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "Initialize", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void Initialize()
		{
			throw null;
		}

		// Token: 0x06003492 RID: 13458 RVA: 0x0002B63D File Offset: 0x0002983D
		[global::Cpp2ILInjected.Token(Token = "0x6003A00")]
		[global::Cpp2ILInjected.Address(RVA = "0x14705FC", Offset = "0x14705FC", Length = "0x40")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "ResetInputsOnActiveStateChange", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = "Clone", MemberParameters = new object[] { typeof(TriggersSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x06003493 RID: 13459 RVA: 0x0002B640 File Offset: 0x00029840
		[global::Cpp2ILInjected.Token(Token = "0x6003A01")]
		[global::Cpp2ILInjected.Address(RVA = "0x14706B8", Offset = "0x14706B8", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerInput), Member = "UpdateInput", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersPack), Member = "CompareDiffs", MemberParameters = new object[]
		{
			typeof(TriggersSet),
			typeof(TriggersSet),
			typeof(TriggersSet)
		}, ReturnType = typeof(void))]
		public void Update()
		{
			throw null;
		}

		// Token: 0x06003494 RID: 13460 RVA: 0x0002B643 File Offset: 0x00029843
		[global::Cpp2ILInjected.Token(Token = "0x6003A02")]
		[global::Cpp2ILInjected.Address(RVA = "0x14706DC", Offset = "0x14706DC", Length = "0x80")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TriggersPack), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void CompareDiffs(TriggersSet Bearer, TriggersSet oldset, TriggersSet newset)
		{
			throw null;
		}

		// Token: 0x06003495 RID: 13461 RVA: 0x0002B646 File Offset: 0x00029846
		[global::Cpp2ILInjected.Token(Token = "0x6003A03")]
		[global::Cpp2ILInjected.Address(RVA = "0x147075C", Offset = "0x147075C", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LocalUserGameState), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TriggersSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public TriggersPack()
		{
			throw null;
		}

		// Token: 0x0400664F RID: 26191
		[global::Cpp2ILInjected.Token(Token = "0x4007A6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TriggersSet Current;

		// Token: 0x04006650 RID: 26192
		[global::Cpp2ILInjected.Token(Token = "0x4007A6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public TriggersSet Old;

		// Token: 0x04006651 RID: 26193
		[global::Cpp2ILInjected.Token(Token = "0x4007A6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TriggersSet JustPressed;

		// Token: 0x04006652 RID: 26194
		[global::Cpp2ILInjected.Token(Token = "0x4007A6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TriggersSet JustReleased;
	}
}
