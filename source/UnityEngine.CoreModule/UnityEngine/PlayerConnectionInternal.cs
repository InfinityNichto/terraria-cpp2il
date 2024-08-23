using System;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Networking.PlayerConnection;

namespace UnityEngine
{
	// Token: 0x02000071 RID: 113
	[NativeHeader("Runtime/Export/PlayerConnection/PlayerConnectionInternal.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x2000077")]
	internal class PlayerConnectionInternal : IPlayerEditorConnectionNative
	{
		// Token: 0x060001D7 RID: 471 RVA: 0x000023F5 File Offset: 0x000005F5
		[global::Cpp2ILInjected.Token(Token = "0x60001E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F758A0", Offset = "0x1F758A0", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void UnityEngine.IPlayerEditorConnectionNative.SendMessage(Guid messageId, byte[] data, int playerId)
		{
			throw null;
		}

		// Token: 0x060001D8 RID: 472 RVA: 0x000023F8 File Offset: 0x000005F8
		[global::Cpp2ILInjected.Token(Token = "0x60001E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75A1C", Offset = "0x1F75A1C", Length = "0x12C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private bool UnityEngine.IPlayerEditorConnectionNative.TrySendMessage(Guid messageId, byte[] data, int playerId)
		{
			throw null;
		}

		// Token: 0x060001D9 RID: 473 RVA: 0x000023FB File Offset: 0x000005FB
		[global::Cpp2ILInjected.Token(Token = "0x60001E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75B9C", Offset = "0x1F75B9C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UnityEngine.IPlayerEditorConnectionNative.Poll()
		{
			throw null;
		}

		// Token: 0x060001DA RID: 474 RVA: 0x000023FE File Offset: 0x000005FE
		[global::Cpp2ILInjected.Token(Token = "0x60001E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75BEC", Offset = "0x1F75BEC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UnityEngine.IPlayerEditorConnectionNative.RegisterInternal(Guid messageId)
		{
			throw null;
		}

		// Token: 0x060001DB RID: 475 RVA: 0x00002401 File Offset: 0x00000601
		[global::Cpp2ILInjected.Token(Token = "0x60001E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75CAC", Offset = "0x1F75CAC", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UnityEngine.IPlayerEditorConnectionNative.UnregisterInternal(Guid messageId)
		{
			throw null;
		}

		// Token: 0x060001DC RID: 476 RVA: 0x00002404 File Offset: 0x00000604
		[global::Cpp2ILInjected.Token(Token = "0x60001E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75D6C", Offset = "0x1F75D6C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UnityEngine.IPlayerEditorConnectionNative.Initialize()
		{
			throw null;
		}

		// Token: 0x060001DD RID: 477 RVA: 0x00002407 File Offset: 0x00000607
		[global::Cpp2ILInjected.Token(Token = "0x60001E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75DBC", Offset = "0x1F75DBC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private bool UnityEngine.IPlayerEditorConnectionNative.IsConnected()
		{
			throw null;
		}

		// Token: 0x060001DE RID: 478 RVA: 0x0000240A File Offset: 0x0000060A
		[global::Cpp2ILInjected.Token(Token = "0x60001E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75E0C", Offset = "0x1F75E0C", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private void UnityEngine.IPlayerEditorConnectionNative.DisconnectAll()
		{
			throw null;
		}

		// Token: 0x060001DF RID: 479
		[FreeFunction("PlayerConnection_Bindings::IsConnected")]
		[global::Cpp2ILInjected.Token(Token = "0x60001E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75DE4", Offset = "0x1F75DE4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool IsConnected();

		// Token: 0x060001E0 RID: 480
		[FreeFunction("PlayerConnection_Bindings::Initialize")]
		[global::Cpp2ILInjected.Token(Token = "0x60001EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75D94", Offset = "0x1F75D94", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Initialize();

		// Token: 0x060001E1 RID: 481
		[FreeFunction("PlayerConnection_Bindings::RegisterInternal")]
		[global::Cpp2ILInjected.Token(Token = "0x60001EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75C70", Offset = "0x1F75C70", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void RegisterInternal(string messageId);

		// Token: 0x060001E2 RID: 482
		[FreeFunction("PlayerConnection_Bindings::UnregisterInternal")]
		[global::Cpp2ILInjected.Token(Token = "0x60001EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75D30", Offset = "0x1F75D30", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void UnregisterInternal(string messageId);

		// Token: 0x060001E3 RID: 483
		[FreeFunction("PlayerConnection_Bindings::SendMessage")]
		[global::Cpp2ILInjected.Token(Token = "0x60001ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F759C8", Offset = "0x1F759C8", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void SendMessage(string messageId, byte[] data, int playerId);

		// Token: 0x060001E4 RID: 484
		[FreeFunction("PlayerConnection_Bindings::TrySendMessage")]
		[global::Cpp2ILInjected.Token(Token = "0x60001EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75B48", Offset = "0x1F75B48", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern bool TrySendMessage(string messageId, byte[] data, int playerId);

		// Token: 0x060001E5 RID: 485
		[FreeFunction("PlayerConnection_Bindings::PollInternal")]
		[global::Cpp2ILInjected.Token(Token = "0x60001EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75BC4", Offset = "0x1F75BC4", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void PollInternal();

		// Token: 0x060001E6 RID: 486
		[FreeFunction("PlayerConnection_Bindings::DisconnectAll")]
		[global::Cpp2ILInjected.Token(Token = "0x60001F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75E34", Offset = "0x1F75E34", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void DisconnectAll();

		// Token: 0x060001E7 RID: 487 RVA: 0x0000240D File Offset: 0x0000060D
		[global::Cpp2ILInjected.Token(Token = "0x60001F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F75E5C", Offset = "0x1F75E5C", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public PlayerConnectionInternal()
		{
			throw null;
		}
	}
}
