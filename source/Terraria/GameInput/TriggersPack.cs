using System;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;

namespace Terraria.GameInput
{
	[global::Cpp2ILInjected.Token(Token = "0x20006D0")]
	public class TriggersPack
	{
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

		[global::Cpp2ILInjected.Token(Token = "0x4007A6C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public TriggersSet Current;

		[global::Cpp2ILInjected.Token(Token = "0x4007A6D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public TriggersSet Old;

		[global::Cpp2ILInjected.Token(Token = "0x4007A6E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public TriggersSet JustPressed;

		[global::Cpp2ILInjected.Token(Token = "0x4007A6F")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		public TriggersSet JustReleased;
	}
}
