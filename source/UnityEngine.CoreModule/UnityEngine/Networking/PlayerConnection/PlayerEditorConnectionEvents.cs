using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020000DC RID: 220
	[global::Cpp2ILInjected.Token(Token = "0x20000F3")]
	[Serializable]
	internal class PlayerEditorConnectionEvents
	{
		// Token: 0x06000507 RID: 1287 RVA: 0x00002B00 File Offset: 0x00000D00
		[global::Cpp2ILInjected.Token(Token = "0x6000525")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8825C", Offset = "0x1F8825C", Length = "0x474")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "MessageCallbackInternal", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(ulong),
			typeof(ulong),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable[]), Member = "Where", MemberTypeParameters = new object[] { typeof(object) }, MemberParameters = new object[]
		{
			typeof(IEnumerable<object>),
			typeof(Func<object, bool>)
		}, ReturnType = "System.Collections.Generic.IEnumerable`1<TSource>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = "Invoke", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		public void InvokeMessageIdSubscribers(Guid messageId, byte[] data, int playerId)
		{
			throw null;
		}

		// Token: 0x06000508 RID: 1288 RVA: 0x00002B03 File Offset: 0x00000D03
		[global::Cpp2ILInjected.Token(Token = "0x6000526")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F886E0", Offset = "0x1F886E0", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "Register", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(UnityAction<MessageEventArgs>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEditorConnectionEvents.MessageTypeSubscribers), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEditorConnectionEvents.MessageEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public UnityEvent<MessageEventArgs> AddAndCreate(Guid messageId)
		{
			throw null;
		}

		// Token: 0x06000509 RID: 1289 RVA: 0x00002B06 File Offset: 0x00000D06
		[global::Cpp2ILInjected.Token(Token = "0x6000527")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8898C", Offset = "0x1F8898C", Length = "0x164")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "Unregister", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(UnityAction<MessageEventArgs>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "SingleOrDefault", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = "RemoveListener", MemberParameters = new object[] { typeof(UnityAction<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void UnregisterManagedCallback(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			throw null;
		}

		// Token: 0x0600050A RID: 1290 RVA: 0x00002B09 File Offset: 0x00000D09
		[global::Cpp2ILInjected.Token(Token = "0x6000528")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F88AF8", Offset = "0x1F88AF8", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEditorConnectionEvents.ConnectionChangeEvent), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public PlayerEditorConnectionEvents()
		{
			throw null;
		}

		// Token: 0x040003D5 RID: 981
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000412")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		public List<PlayerEditorConnectionEvents.MessageTypeSubscribers> messageTypeSubscribers;

		// Token: 0x040003D6 RID: 982
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000413")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		public PlayerEditorConnectionEvents.ConnectionChangeEvent connectionEvent;

		// Token: 0x040003D7 RID: 983
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000414")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		public PlayerEditorConnectionEvents.ConnectionChangeEvent disconnectionEvent;

		// Token: 0x02000177 RID: 375
		[global::Cpp2ILInjected.Token(Token = "0x20000F4")]
		[Serializable]
		public class MessageEvent : UnityEvent<MessageEventArgs>
		{
			// Token: 0x060006D2 RID: 1746 RVA: 0x00002FB0 File Offset: 0x000011B0
			[global::Cpp2ILInjected.Token(Token = "0x6000529")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88944", Offset = "0x1F88944", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerEditorConnectionEvents.MessageTypeSubscribers), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "AddAndCreate", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(UnityEvent<MessageEventArgs>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public MessageEvent()
			{
				throw null;
			}
		}

		// Token: 0x02000178 RID: 376
		[global::Cpp2ILInjected.Token(Token = "0x20000F5")]
		[Serializable]
		public class ConnectionChangeEvent : UnityEvent<int>
		{
			// Token: 0x060006D3 RID: 1747 RVA: 0x00002FB3 File Offset: 0x000011B3
			[global::Cpp2ILInjected.Token(Token = "0x600052A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88BB0", Offset = "0x1F88BB0", Length = "0x48")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
			public ConnectionChangeEvent()
			{
				throw null;
			}
		}

		// Token: 0x02000179 RID: 377
		[global::Cpp2ILInjected.Token(Token = "0x20000F6")]
		[Serializable]
		public class MessageTypeSubscribers
		{
			// Token: 0x1700015F RID: 351
			// (get) Token: 0x060006D4 RID: 1748 RVA: 0x00002FB6 File Offset: 0x000011B6
			// (set) Token: 0x060006D5 RID: 1749 RVA: 0x00002FB9 File Offset: 0x000011B9
			[global::Cpp2ILInjected.Token(Token = "0x17000113")]
			public Guid MessageTypeId
			{
				[global::Cpp2ILInjected.Token(Token = "0x600052B")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F88BF8", Offset = "0x1F88BF8", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
				get
				{
					throw null;
				}
				[global::Cpp2ILInjected.Token(Token = "0x600052C")]
				[global::Cpp2ILInjected.Address(RVA = "0x1F88918", Offset = "0x1F88918", Length = "0x2C")]
				[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
				[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "ToString", ReturnType = typeof(string))]
				set
				{
					throw null;
				}
			}

			// Token: 0x060006D6 RID: 1750 RVA: 0x00002FBC File Offset: 0x000011BC
			[global::Cpp2ILInjected.Token(Token = "0x600052D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F888B8", Offset = "0x1F888B8", Length = "0x60")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerEditorConnectionEvents), Member = "AddAndCreate", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(UnityEvent<MessageEventArgs>))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEditorConnectionEvents.MessageEvent), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			public MessageTypeSubscribers()
			{
				throw null;
			}

			// Token: 0x0400066D RID: 1645
			[SerializeField]
			[global::Cpp2ILInjected.Token(Token = "0x4000415")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			private string m_messageTypeId;

			// Token: 0x0400066E RID: 1646
			[global::Cpp2ILInjected.Token(Token = "0x4000416")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
			public int subscriberCount;

			// Token: 0x0400066F RID: 1647
			[global::Cpp2ILInjected.Token(Token = "0x4000417")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
			public PlayerEditorConnectionEvents.MessageEvent messageCallback;
		}

		// Token: 0x0200017A RID: 378
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000F7")]
		private sealed class <>c__DisplayClass6_0
		{
			// Token: 0x060006D7 RID: 1751 RVA: 0x00002FBF File Offset: 0x000011BF
			[global::Cpp2ILInjected.Token(Token = "0x600052E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F886D0", Offset = "0x1F886D0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass6_0()
			{
				throw null;
			}

			// Token: 0x060006D8 RID: 1752 RVA: 0x00002FC2 File Offset: 0x000011C2
			[global::Cpp2ILInjected.Token(Token = "0x600052F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88C24", Offset = "0x1F88C24", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Guid),
				typeof(Guid)
			}, ReturnType = typeof(bool))]
			internal bool <InvokeMessageIdSubscribers>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				throw null;
			}

			// Token: 0x04000670 RID: 1648
			[global::Cpp2ILInjected.Token(Token = "0x4000418")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Guid messageId;
		}

		// Token: 0x0200017B RID: 379
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000F8")]
		private sealed class <>c__DisplayClass7_0
		{
			// Token: 0x060006D9 RID: 1753 RVA: 0x00002FC5 File Offset: 0x000011C5
			[global::Cpp2ILInjected.Token(Token = "0x6000530")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F888B0", Offset = "0x1F888B0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass7_0()
			{
				throw null;
			}

			// Token: 0x060006DA RID: 1754 RVA: 0x00002FC8 File Offset: 0x000011C8
			[global::Cpp2ILInjected.Token(Token = "0x6000531")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88C64", Offset = "0x1F88C64", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Guid),
				typeof(Guid)
			}, ReturnType = typeof(bool))]
			internal bool <AddAndCreate>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				throw null;
			}

			// Token: 0x04000671 RID: 1649
			[global::Cpp2ILInjected.Token(Token = "0x4000419")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Guid messageId;
		}

		// Token: 0x0200017C RID: 380
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000F9")]
		private sealed class <>c__DisplayClass8_0
		{
			// Token: 0x060006DB RID: 1755 RVA: 0x00002FCB File Offset: 0x000011CB
			[global::Cpp2ILInjected.Token(Token = "0x6000532")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88AF0", Offset = "0x1F88AF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass8_0()
			{
				throw null;
			}

			// Token: 0x060006DC RID: 1756 RVA: 0x00002FCE File Offset: 0x000011CE
			[global::Cpp2ILInjected.Token(Token = "0x6000533")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88CA4", Offset = "0x1F88CA4", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Guid),
				typeof(Guid)
			}, ReturnType = typeof(bool))]
			internal bool <UnregisterManagedCallback>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				throw null;
			}

			// Token: 0x04000672 RID: 1650
			[global::Cpp2ILInjected.Token(Token = "0x400041A")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Guid messageId;
		}
	}
}
