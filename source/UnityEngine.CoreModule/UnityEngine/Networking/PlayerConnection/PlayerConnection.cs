using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Events;
using UnityEngine.Scripting;

namespace UnityEngine.Networking.PlayerConnection
{
	// Token: 0x020000DD RID: 221
	[global::Cpp2ILInjected.Token(Token = "0x20000FA")]
	[Serializable]
	public class PlayerConnection : ScriptableObject
	{
		// Token: 0x17000110 RID: 272
		// (get) Token: 0x0600050B RID: 1291 RVA: 0x00002B0C File Offset: 0x00000D0C
		[global::Cpp2ILInjected.Token(Token = "0x17000114")]
		public static PlayerConnection instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000534")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88CE4", Offset = "0x1F88CE4", Length = "0x98")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "MessageCallbackInternal", MemberParameters = new object[]
			{
				typeof(IntPtr),
				typeof(ulong),
				typeof(ulong),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "ConnectedCallbackInternal", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "DisconnectedCallback", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000111 RID: 273
		// (get) Token: 0x0600050C RID: 1292 RVA: 0x00002B0F File Offset: 0x00000D0F
		[global::Cpp2ILInjected.Token(Token = "0x17000115")]
		public bool isConnected
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000535")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F88DF8", Offset = "0x1F88DF8", Length = "0x9C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			get
			{
				throw null;
			}
		}

		// Token: 0x0600050D RID: 1293 RVA: 0x00002B12 File Offset: 0x00000D12
		[global::Cpp2ILInjected.Token(Token = "0x6000536")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F88D7C", Offset = "0x1F88D7C", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableObject), Member = "CreateInstance", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "set_hideFlags", MemberParameters = new object[] { typeof(HideFlags) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private new static PlayerConnection CreateInstance()
		{
			throw null;
		}

		// Token: 0x0600050E RID: 1294 RVA: 0x00002B15 File Offset: 0x00000D15
		[global::Cpp2ILInjected.Token(Token = "0x6000537")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F88F0C", Offset = "0x1F88F0C", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void OnEnable()
		{
			throw null;
		}

		// Token: 0x0600050F RID: 1295 RVA: 0x00002B18 File Offset: 0x00000D18
		[global::Cpp2ILInjected.Token(Token = "0x6000538")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F88E94", Offset = "0x1F88E94", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "get_isConnected", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "Register", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(UnityAction<MessageEventArgs>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "Unregister", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(UnityAction<MessageEventArgs>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "Send", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(byte[])
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "TrySend", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(byte[])
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "BlockUntilRecvMsg", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "DisconnectAll", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnectionInternal), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private IPlayerEditorConnectionNative GetConnectionNativeApi()
		{
			throw null;
		}

		// Token: 0x06000510 RID: 1296 RVA: 0x00002B1B File Offset: 0x00000D1B
		[global::Cpp2ILInjected.Token(Token = "0x6000539")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F88FC4", Offset = "0x1F88FC4", Length = "0x22C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "BlockUntilRecvMsg", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "AddAndCreate", MemberParameters = new object[] { typeof(Guid) }, ReturnType = typeof(UnityEvent<MessageEventArgs>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<object>), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public void Register(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			throw null;
		}

		// Token: 0x06000511 RID: 1297 RVA: 0x00002B1E File Offset: 0x00000D1E
		[global::Cpp2ILInjected.Token(Token = "0x600053A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F891F8", Offset = "0x1F891F8", Length = "0x19C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "BlockUntilRecvMsg", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(int)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "UnregisterManagedCallback", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(UnityAction<MessageEventArgs>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Func<object, bool>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Any", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>", "System.Func`2<TSource, Boolean>" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public void Unregister(Guid messageId, UnityAction<MessageEventArgs> callback)
		{
			throw null;
		}

		// Token: 0x06000512 RID: 1298 RVA: 0x00002B21 File Offset: 0x00000D21
		[global::Cpp2ILInjected.Token(Token = "0x600053B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8939C", Offset = "0x1F8939C", Length = "0x184")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "GetEnumerator", ReturnType = "Enumerator<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "MoveNext", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>.Enumerator), Member = "Dispose", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public void RegisterConnection(UnityAction<int> callback)
		{
			throw null;
		}

		// Token: 0x06000513 RID: 1299 RVA: 0x00002B24 File Offset: 0x00000D24
		[global::Cpp2ILInjected.Token(Token = "0x600053C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89520", Offset = "0x1F89520", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = "AddListener", MemberParameters = new object[] { typeof(UnityAction<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void RegisterDisconnection(UnityAction<int> callback)
		{
			throw null;
		}

		// Token: 0x06000514 RID: 1300 RVA: 0x00002B27 File Offset: 0x00000D27
		[global::Cpp2ILInjected.Token(Token = "0x600053D")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F8957C", Offset = "0x1F8957C", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = "RemoveListener", MemberParameters = new object[] { typeof(UnityAction<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void UnregisterConnection(UnityAction<int> callback)
		{
			throw null;
		}

		// Token: 0x06000515 RID: 1301 RVA: 0x00002B2A File Offset: 0x00000D2A
		[global::Cpp2ILInjected.Token(Token = "0x600053E")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F895D8", Offset = "0x1F895D8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = "RemoveListener", MemberParameters = new object[] { typeof(UnityAction<int>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public void UnregisterDisconnection(UnityAction<int> callback)
		{
			throw null;
		}

		// Token: 0x06000516 RID: 1302 RVA: 0x00002B2D File Offset: 0x00000D2D
		[global::Cpp2ILInjected.Token(Token = "0x600053F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89634", Offset = "0x1F89634", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public void Send(Guid messageId, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000517 RID: 1303 RVA: 0x00002B30 File Offset: 0x00000D30
		[global::Cpp2ILInjected.Token(Token = "0x6000540")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89784", Offset = "0x1F89784", Length = "0x150")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(Guid)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public bool TrySend(Guid messageId, byte[] data)
		{
			throw null;
		}

		// Token: 0x06000518 RID: 1304 RVA: 0x00002B33 File Offset: 0x00000D33
		[global::Cpp2ILInjected.Token(Token = "0x6000541")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F898D4", Offset = "0x1F898D4", Length = "0x1F0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityAction<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "get_Now", ReturnType = typeof(DateTime))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "Register", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(UnityAction<MessageEventArgs>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(DateTime), Member = "op_Subtraction", MemberParameters = new object[]
		{
			typeof(DateTime),
			typeof(DateTime)
		}, ReturnType = typeof(TimeSpan))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TimeSpan), Member = "get_TotalMilliseconds", ReturnType = typeof(double))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "Unregister", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(UnityAction<MessageEventArgs>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public bool BlockUntilRecvMsg(Guid messageId, int timeout)
		{
			throw null;
		}

		// Token: 0x06000519 RID: 1305 RVA: 0x00002B36 File Offset: 0x00000D36
		[global::Cpp2ILInjected.Token(Token = "0x6000542")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89ACC", Offset = "0x1F89ACC", Length = "0x9C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "GetConnectionNativeApi", ReturnType = typeof(IPlayerEditorConnectionNative))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void DisconnectAll()
		{
			throw null;
		}

		// Token: 0x0600051A RID: 1306 RVA: 0x00002B39 File Offset: 0x00000D39
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000543")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89B68", Offset = "0x1F89B68", Length = "0x10C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Marshal), Member = "Copy", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(byte[]),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "get_instance", ReturnType = typeof(PlayerConnection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEditorConnectionEvents), Member = "InvokeMessageIdSubscribers", MemberParameters = new object[]
		{
			typeof(Guid),
			typeof(byte[]),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void MessageCallbackInternal(IntPtr data, ulong size, ulong guid, string messageId)
		{
			throw null;
		}

		// Token: 0x0600051B RID: 1307 RVA: 0x00002B3C File Offset: 0x00000D3C
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000544")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89C74", Offset = "0x1F89C74", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "get_instance", ReturnType = typeof(PlayerConnection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = "Invoke", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void ConnectedCallbackInternal(int playerId)
		{
			throw null;
		}

		// Token: 0x0600051C RID: 1308 RVA: 0x00002B3F File Offset: 0x00000D3F
		[RequiredByNativeCode]
		[global::Cpp2ILInjected.Token(Token = "0x6000545")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89D34", Offset = "0x1F89D34", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerConnection), Member = "get_instance", ReturnType = typeof(PlayerConnection))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = "Remove", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEvent<int>), Member = "Invoke", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private static void DisconnectedCallback(int playerId)
		{
			throw null;
		}

		// Token: 0x0600051D RID: 1309 RVA: 0x00002B42 File Offset: 0x00000D42
		[global::Cpp2ILInjected.Token(Token = "0x6000546")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F89DB8", Offset = "0x1F89DB8", Length = "0xA4")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerEditorConnectionEvents), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<int>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ScriptableObject), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public PlayerConnection()
		{
			throw null;
		}

		// Token: 0x040003D8 RID: 984
		[global::Cpp2ILInjected.Token(Token = "0x400041B")]
		internal static IPlayerEditorConnectionNative connectionNative;

		// Token: 0x040003D9 RID: 985
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400041C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private PlayerEditorConnectionEvents m_PlayerEditorConnectionEvents;

		// Token: 0x040003DA RID: 986
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400041D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<int> m_connectedPlayers;

		// Token: 0x040003DB RID: 987
		[global::Cpp2ILInjected.Token(Token = "0x400041E")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private bool m_IsInitilized;

		// Token: 0x040003DC RID: 988
		[global::Cpp2ILInjected.Token(Token = "0x400041F")]
		private static PlayerConnection s_Instance;

		// Token: 0x0200017D RID: 381
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000FB")]
		private sealed class <>c__DisplayClass12_0
		{
			// Token: 0x060006DD RID: 1757 RVA: 0x00002FD1 File Offset: 0x000011D1
			[global::Cpp2ILInjected.Token(Token = "0x6000547")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F891F0", Offset = "0x1F891F0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass12_0()
			{
				throw null;
			}

			// Token: 0x060006DE RID: 1758 RVA: 0x00002FD4 File Offset: 0x000011D4
			[global::Cpp2ILInjected.Token(Token = "0x6000548")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F89E5C", Offset = "0x1F89E5C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Guid),
				typeof(Guid)
			}, ReturnType = typeof(bool))]
			internal bool <Register>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				throw null;
			}

			// Token: 0x04000673 RID: 1651
			[global::Cpp2ILInjected.Token(Token = "0x4000420")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Guid messageId;
		}

		// Token: 0x0200017E RID: 382
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000FC")]
		private sealed class <>c__DisplayClass13_0
		{
			// Token: 0x060006DF RID: 1759 RVA: 0x00002FD7 File Offset: 0x000011D7
			[global::Cpp2ILInjected.Token(Token = "0x6000549")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F89394", Offset = "0x1F89394", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass13_0()
			{
				throw null;
			}

			// Token: 0x060006E0 RID: 1760 RVA: 0x00002FDA File Offset: 0x000011DA
			[global::Cpp2ILInjected.Token(Token = "0x600054A")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F89E9C", Offset = "0x1F89E9C", Length = "0x40")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Guid), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(Guid),
				typeof(Guid)
			}, ReturnType = typeof(bool))]
			internal bool <Unregister>b__0(PlayerEditorConnectionEvents.MessageTypeSubscribers x)
			{
				throw null;
			}

			// Token: 0x04000674 RID: 1652
			[global::Cpp2ILInjected.Token(Token = "0x4000421")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public Guid messageId;
		}

		// Token: 0x0200017F RID: 383
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x20000FD")]
		private sealed class <>c__DisplayClass20_0
		{
			// Token: 0x060006E1 RID: 1761 RVA: 0x00002FDD File Offset: 0x000011DD
			[global::Cpp2ILInjected.Token(Token = "0x600054B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F89AC4", Offset = "0x1F89AC4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c__DisplayClass20_0()
			{
				throw null;
			}

			// Token: 0x060006E2 RID: 1762 RVA: 0x00002FE0 File Offset: 0x000011E0
			[global::Cpp2ILInjected.Token(Token = "0x600054C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F89EDC", Offset = "0x1F89EDC", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal void <BlockUntilRecvMsg>b__0(MessageEventArgs args)
			{
				throw null;
			}

			// Token: 0x04000675 RID: 1653
			[global::Cpp2ILInjected.Token(Token = "0x4000422")]
			[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
			public bool msgReceived;
		}
	}
}
