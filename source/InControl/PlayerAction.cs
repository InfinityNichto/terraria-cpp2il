using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000011 RID: 17
	[global::Cpp2ILInjected.Token(Token = "0x2000011")]
	public class PlayerAction : OneAxisInputControl
	{
		// Token: 0x17000022 RID: 34
		// (get) Token: 0x06000082 RID: 130 RVA: 0x000021EF File Offset: 0x000003EF
		// (set) Token: 0x06000083 RID: 131 RVA: 0x000021F2 File Offset: 0x000003F2
		[global::Cpp2ILInjected.Token(Token = "0x17000022")]
		public string Name
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000082")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E8BC", Offset = "0x197E8BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000083")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E8C4", Offset = "0x197E8C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000023 RID: 35
		// (get) Token: 0x06000084 RID: 132 RVA: 0x000021F5 File Offset: 0x000003F5
		// (set) Token: 0x06000085 RID: 133 RVA: 0x000021F8 File Offset: 0x000003F8
		[global::Cpp2ILInjected.Token(Token = "0x17000023")]
		public PlayerActionSet Owner
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000084")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E8CC", Offset = "0x197E8CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000085")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E8D4", Offset = "0x197E8D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x14000001 RID: 1
		// (add) Token: 0x06000086 RID: 134 RVA: 0x000021FB File Offset: 0x000003FB
		// (remove) Token: 0x06000087 RID: 135 RVA: 0x000021FE File Offset: 0x000003FE
		[global::Cpp2ILInjected.Token(Token = "0x14000001")]
		public event Action<BindingSourceType> OnLastInputTypeChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000086")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E8DC", Offset = "0x197E8DC", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000087")]
			[global::Cpp2ILInjected.Address(RVA = "0x197E98C", Offset = "0x197E98C", Length = "0xB0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			remove
			{
				throw null;
			}
		}

		// Token: 0x14000002 RID: 2
		// (add) Token: 0x06000088 RID: 136 RVA: 0x00002201 File Offset: 0x00000401
		// (remove) Token: 0x06000089 RID: 137 RVA: 0x00002204 File Offset: 0x00000404
		[global::Cpp2ILInjected.Token(Token = "0x14000002")]
		public event Action OnBindingsChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000088")]
			[global::Cpp2ILInjected.Address(RVA = "0x197EA3C", Offset = "0x197EA3C", Length = "0x9C")]
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
			[global::Cpp2ILInjected.Token(Token = "0x6000089")]
			[global::Cpp2ILInjected.Address(RVA = "0x197EAD8", Offset = "0x197EAD8", Length = "0x9C")]
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

		// Token: 0x17000024 RID: 36
		// (get) Token: 0x0600008A RID: 138 RVA: 0x00002207 File Offset: 0x00000407
		// (set) Token: 0x0600008B RID: 139 RVA: 0x0000220A File Offset: 0x0000040A
		[global::Cpp2ILInjected.Token(Token = "0x17000024")]
		public object UserData
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600008A")]
			[global::Cpp2ILInjected.Address(RVA = "0x197EB74", Offset = "0x197EB74", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600008B")]
			[global::Cpp2ILInjected.Address(RVA = "0x197EB7C", Offset = "0x197EB7C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600008C RID: 140 RVA: 0x0000220D File Offset: 0x0000040D
		[global::Cpp2ILInjected.Token(Token = "0x600008C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197EB84", Offset = "0x197EB84", Length = "0x2AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "CreatePlayerAction", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(PlayerAction))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "AddPlayerAction", MemberParameters = new object[] { typeof(PlayerAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 25)]
		public PlayerAction(string name, PlayerActionSet owner)
		{
			throw null;
		}

		// Token: 0x0600008D RID: 141 RVA: 0x00002210 File Offset: 0x00000410
		[global::Cpp2ILInjected.Token(Token = "0x600008D")]
		[global::Cpp2ILInjected.Address(RVA = "0x197EFD0", Offset = "0x197EFD0", Length = "0x20C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(Key[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(KeyCombo) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(Mouse) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(InputControlType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		public void AddDefaultBinding(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x0600008E RID: 142 RVA: 0x00002213 File Offset: 0x00000413
		[global::Cpp2ILInjected.Token(Token = "0x600008E")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F1DC", Offset = "0x197F1DC", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerActions", Member = "CreateWithKeyboardBindings", ReturnType = "MultiplayerWithBindingsExample.PlayerActions")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions", Member = "CreateWithDefaultBindings", ReturnType = "BindingsExample.PlayerActions")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyBindingSource), Member = ".ctor", MemberParameters = new object[] { typeof(Key[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddDefaultBinding(params Key[] keys)
		{
			throw null;
		}

		// Token: 0x0600008F RID: 143 RVA: 0x00002216 File Offset: 0x00000416
		[global::Cpp2ILInjected.Token(Token = "0x600008F")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F244", Offset = "0x197F244", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddDefaultBinding(KeyCombo keyCombo)
		{
			throw null;
		}

		// Token: 0x06000090 RID: 144 RVA: 0x00002219 File Offset: 0x00000419
		[global::Cpp2ILInjected.Token(Token = "0x6000090")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F2C8", Offset = "0x197F2C8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions", Member = "CreateWithDefaultBindings", ReturnType = "BindingsExample.PlayerActions")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddDefaultBinding(Mouse control)
		{
			throw null;
		}

		// Token: 0x06000091 RID: 145 RVA: 0x0000221C File Offset: 0x0000041C
		[global::Cpp2ILInjected.Token(Token = "0x6000091")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F334", Offset = "0x197F334", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerActions", Member = "CreateWithJoystickBindings", ReturnType = "MultiplayerWithBindingsExample.PlayerActions")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions", Member = "CreateWithDefaultBindings", ReturnType = "BindingsExample.PlayerActions")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddDefaultBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void AddDefaultBinding(InputControlType control)
		{
			throw null;
		}

		// Token: 0x06000092 RID: 146 RVA: 0x0000221F File Offset: 0x0000041F
		[global::Cpp2ILInjected.Token(Token = "0x6000092")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F3A0", Offset = "0x197F3A0", Length = "0x1AC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "InsertBindingAt", MemberParameters = new object[]
		{
			typeof(int),
			typeof(BindingSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public bool AddBinding(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x06000093 RID: 147 RVA: 0x00002222 File Offset: 0x00000422
		[global::Cpp2ILInjected.Token(Token = "0x6000093")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F54C", Offset = "0x197F54C", Length = "0x218")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Insert", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public bool InsertBindingAt(int index, BindingSource binding)
		{
			throw null;
		}

		// Token: 0x06000094 RID: 148 RVA: 0x00002225 File Offset: 0x00000425
		[global::Cpp2ILInjected.Token(Token = "0x6000094")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F764", Offset = "0x197F764", Length = "0x168")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogWarning", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "set_Item", MemberParameters = new object[]
		{
			typeof(int),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public bool ReplaceBinding(BindingSource findBinding, BindingSource withBinding)
		{
			throw null;
		}

		// Token: 0x06000095 RID: 149 RVA: 0x00002228 File Offset: 0x00000428
		[global::Cpp2ILInjected.Token(Token = "0x6000095")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F8CC", Offset = "0x197F8CC", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "FindBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(BindingSource))]
		public bool HasBinding(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x06000096 RID: 150 RVA: 0x0000222B File Offset: 0x0000042B
		[global::Cpp2ILInjected.Token(Token = "0x6000096")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F8FC", Offset = "0x197F8FC", Length = "0x8C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "HasBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "RemoveBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "HasBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "RemoveBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public BindingSource FindBinding(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x06000097 RID: 151 RVA: 0x0000222E File Offset: 0x0000042E
		[global::Cpp2ILInjected.Token(Token = "0x6000097")]
		[global::Cpp2ILInjected.Address(RVA = "0x197F988", Offset = "0x197F988", Length = "0xC8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "IndexOf", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void HardRemoveBinding(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x06000098 RID: 152 RVA: 0x00002231 File Offset: 0x00000431
		[global::Cpp2ILInjected.Token(Token = "0x6000098")]
		[global::Cpp2ILInjected.Address(RVA = "0x197FB94", Offset = "0x197FB94", Length = "0x30")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "FindBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(BindingSource))]
		public void RemoveBinding(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x06000099 RID: 153 RVA: 0x00002234 File Offset: 0x00000434
		[global::Cpp2ILInjected.Token(Token = "0x6000099")]
		[global::Cpp2ILInjected.Address(RVA = "0x197FBC4", Offset = "0x197FBC4", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public void RemoveBindingAt(int index)
		{
			throw null;
		}

		// Token: 0x0600009A RID: 154 RVA: 0x00002237 File Offset: 0x00000437
		[global::Cpp2ILInjected.Token(Token = "0x600009A")]
		[global::Cpp2ILInjected.Address(RVA = "0x197FC84", Offset = "0x197FC84", Length = "0xBC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int CountBindingsOfType(BindingSourceType bindingSourceType)
		{
			throw null;
		}

		// Token: 0x0600009B RID: 155 RVA: 0x0000223A File Offset: 0x0000043A
		[global::Cpp2ILInjected.Token(Token = "0x600009B")]
		[global::Cpp2ILInjected.Address(RVA = "0x197FD40", Offset = "0x197FD40", Length = "0xE8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void RemoveFirstBindingOfType(BindingSourceType bindingSourceType)
		{
			throw null;
		}

		// Token: 0x0600009C RID: 156 RVA: 0x0000223D File Offset: 0x0000043D
		[global::Cpp2ILInjected.Token(Token = "0x600009C")]
		[global::Cpp2ILInjected.Address(RVA = "0x197FE28", Offset = "0x197FE28", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		private int IndexOfFirstInvalidBinding()
		{
			throw null;
		}

		// Token: 0x0600009D RID: 157 RVA: 0x00002240 File Offset: 0x00000440
		[global::Cpp2ILInjected.Token(Token = "0x600009D")]
		[global::Cpp2ILInjected.Address(RVA = "0x197FEF4", Offset = "0x197FEF4", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "ResetBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void ClearBindings()
		{
			throw null;
		}

		// Token: 0x0600009E RID: 158 RVA: 0x00002243 File Offset: 0x00000443
		[global::Cpp2ILInjected.Token(Token = "0x600009E")]
		[global::Cpp2ILInjected.Address(RVA = "0x197FFE4", Offset = "0x197FFE4", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "ClearBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AddRange", MemberParameters = new object[] { typeof(IEnumerable<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public void ResetBindings()
		{
			throw null;
		}

		// Token: 0x0600009F RID: 159 RVA: 0x00002246 File Offset: 0x00000446
		[global::Cpp2ILInjected.Token(Token = "0x600009F")]
		[global::Cpp2ILInjected.Address(RVA = "0x1980128", Offset = "0x1980128", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void ListenForBinding()
		{
			throw null;
		}

		// Token: 0x060000A0 RID: 160 RVA: 0x00002249 File Offset: 0x00000449
		[global::Cpp2ILInjected.Token(Token = "0x60000A0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1980130", Offset = "0x1980130", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void ListenForBindingReplacing(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x060000A1 RID: 161 RVA: 0x0000224C File Offset: 0x0000044C
		[global::Cpp2ILInjected.Token(Token = "0x60000A1")]
		[global::Cpp2ILInjected.Address(RVA = "0x198021C", Offset = "0x198021C", Length = "0x24")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions.<>c", Member = "<CreateWithDefaultBindings>b__8_0", MemberParameters = new object[]
		{
			typeof(PlayerAction),
			typeof(BindingSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		public void StopListeningForBinding()
		{
			throw null;
		}

		// Token: 0x17000025 RID: 37
		// (get) Token: 0x060000A2 RID: 162 RVA: 0x0000224F File Offset: 0x0000044F
		[global::Cpp2ILInjected.Token(Token = "0x17000025")]
		public bool IsListeningForBinding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980240", Offset = "0x1980240", Length = "0x14")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000026 RID: 38
		// (get) Token: 0x060000A3 RID: 163 RVA: 0x00002252 File Offset: 0x00000452
		[global::Cpp2ILInjected.Token(Token = "0x17000026")]
		public ReadOnlyCollection<BindingSource> Bindings
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980254", Offset = "0x1980254", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000027 RID: 39
		// (get) Token: 0x060000A4 RID: 164 RVA: 0x00002255 File Offset: 0x00000455
		[global::Cpp2ILInjected.Token(Token = "0x17000027")]
		public ReadOnlyCollection<BindingSource> UnfilteredBindings
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x198025C", Offset = "0x198025C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00002258 File Offset: 0x00000458
		[global::Cpp2ILInjected.Token(Token = "0x60000A5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1980264", Offset = "0x1980264", Length = "0xB8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private void RemoveOrphanedBindings()
		{
			throw null;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x0000225B File Offset: 0x0000045B
		[global::Cpp2ILInjected.Token(Token = "0x60000A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x198031C", Offset = "0x198031C", Length = "0xB0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateBindings", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		internal void Update(ulong updateTick, float deltaTime, InputDevice device)
		{
			throw null;
		}

		// Token: 0x060000A7 RID: 167 RVA: 0x0000225E File Offset: 0x0000045E
		[global::Cpp2ILInjected.Token(Token = "0x60000A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19803E4", Offset = "0x19803E4", Length = "0x348")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float),
			typeof(InputDevice)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "UpdateWithValue", MemberParameters = new object[]
		{
			typeof(float),
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(OneAxisInputControl), Member = "Commit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "Abs", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void UpdateBindings(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060000A8 RID: 168 RVA: 0x00002261 File Offset: 0x00000461
		[global::Cpp2ILInjected.Token(Token = "0x60000A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x198072C", Offset = "0x198072C", Length = "0x398")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float),
			typeof(InputDevice)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "FindBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "HardRemoveBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "HasBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "ReplaceBinding", MemberParameters = new object[]
		{
			typeof(BindingSource),
			typeof(BindingSource)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "CountBindingsOfType", MemberParameters = new object[] { typeof(BindingSourceType) }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "RemoveFirstBindingOfType", MemberParameters = new object[] { typeof(BindingSourceType) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "IndexOfFirstInvalidBinding", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "RemoveAt", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private void DetectBindings()
		{
			throw null;
		}

		// Token: 0x060000A9 RID: 169 RVA: 0x00002264 File Offset: 0x00000464
		[global::Cpp2ILInjected.Token(Token = "0x60000A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x197FA50", Offset = "0x197FA50", Length = "0x144")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSource), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSource), Member = "get_DeviceName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSource), Member = "get_DeviceClass", ReturnType = typeof(InputDeviceClass))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSource), Member = "get_DeviceStyle", ReturnType = typeof(InputDeviceStyle))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(DeviceBindingSource), Member = "get_IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "HardRemoveBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float),
			typeof(InputDevice)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "UpdateBindings", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "get_Device", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "set_Device", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "AddPlayerAction", MemberParameters = new object[] { typeof(PlayerAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSource), Member = "get_Name", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSource), Member = "get_DeviceName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnknownDeviceBindingSource), Member = "get_IsValid", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private void UpdateVisibleBindings()
		{
			throw null;
		}

		// Token: 0x17000028 RID: 40
		// (get) Token: 0x060000AA RID: 170 RVA: 0x00002267 File Offset: 0x00000467
		// (set) Token: 0x060000AB RID: 171 RVA: 0x0000226A File Offset: 0x0000046A
		[global::Cpp2ILInjected.Token(Token = "0x17000028")]
		internal InputDevice Device
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1979F70", Offset = "0x1979F70", Length = "0x30")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AB")]
			[global::Cpp2ILInjected.Address(RVA = "0x19803CC", Offset = "0x19803CC", Length = "0x18")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000AC RID: 172 RVA: 0x0000226D File Offset: 0x0000046D
		[global::Cpp2ILInjected.Token(Token = "0x17000029")]
		public InputDevice ActiveDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980D98", Offset = "0x1980D98", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Update", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000AD RID: 173 RVA: 0x00002270 File Offset: 0x00000470
		[global::Cpp2ILInjected.Token(Token = "0x1700002A")]
		private bool LastInputTypeIsDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980CBC", Offset = "0x1980CBC", Length = "0x1C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x1700002B RID: 43
		// (get) Token: 0x060000AE RID: 174 RVA: 0x00002273 File Offset: 0x00000473
		// (set) Token: 0x060000AF RID: 175 RVA: 0x00002276 File Offset: 0x00000476
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		[global::Cpp2ILInjected.Token(Token = "0x1700002B")]
		public new float LowerDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000AE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980DFC", Offset = "0x1980DFC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000AF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980E04", Offset = "0x1980E04", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002C RID: 44
		// (get) Token: 0x060000B0 RID: 176 RVA: 0x00002279 File Offset: 0x00000479
		// (set) Token: 0x060000B1 RID: 177 RVA: 0x0000227C File Offset: 0x0000047C
		[Obsolete("Please set this property on device controls directly. It does nothing here.")]
		[global::Cpp2ILInjected.Token(Token = "0x1700002C")]
		public new float UpperDeadZone
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000B0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980E08", Offset = "0x1980E08", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000B1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980E10", Offset = "0x1980E10", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000B2 RID: 178 RVA: 0x0000227F File Offset: 0x0000047F
		[global::Cpp2ILInjected.Token(Token = "0x60000B2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1980E14", Offset = "0x1980E14", Length = "0x204")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "LoadData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "ClearBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnknownDeviceBindingSource), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "AddBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enum), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		internal void Load(BinaryReader reader, ushort dataFormatVersion)
		{
			throw null;
		}

		// Token: 0x060000B3 RID: 179 RVA: 0x00002282 File Offset: 0x00000482
		[global::Cpp2ILInjected.Token(Token = "0x60000B3")]
		[global::Cpp2ILInjected.Address(RVA = "0x198108C", Offset = "0x198108C", Length = "0x108")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "SaveData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "RemoveOrphanedBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal void Save(BinaryWriter writer)
		{
			throw null;
		}

		// Token: 0x040000CC RID: 204
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000CC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private string <Name>k__BackingField;

		// Token: 0x040000CD RID: 205
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000CD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private PlayerActionSet <Owner>k__BackingField;

		// Token: 0x040000CE RID: 206
		[global::Cpp2ILInjected.Token(Token = "0x40000CE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		public BindingListenOptions ListenOptions;

		// Token: 0x040000CF RID: 207
		[global::Cpp2ILInjected.Token(Token = "0x40000CF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		public BindingSourceType LastInputType;

		// Token: 0x040000D0 RID: 208
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000D0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		private Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x040000D1 RID: 209
		[global::Cpp2ILInjected.Token(Token = "0x40000D1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		public ulong LastInputTypeChangedTick;

		// Token: 0x040000D2 RID: 210
		[global::Cpp2ILInjected.Token(Token = "0x40000D2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA0")]
		public InputDeviceClass LastDeviceClass;

		// Token: 0x040000D3 RID: 211
		[global::Cpp2ILInjected.Token(Token = "0x40000D3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA4")]
		public InputDeviceStyle LastDeviceStyle;

		// Token: 0x040000D4 RID: 212
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000D4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xA8")]
		private Action OnBindingsChanged;

		// Token: 0x040000D5 RID: 213
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000D5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB0")]
		private object <UserData>k__BackingField;

		// Token: 0x040000D6 RID: 214
		[global::Cpp2ILInjected.Token(Token = "0x40000D6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xB8")]
		private readonly List<BindingSource> defaultBindings;

		// Token: 0x040000D7 RID: 215
		[global::Cpp2ILInjected.Token(Token = "0x40000D7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC0")]
		private readonly List<BindingSource> regularBindings;

		// Token: 0x040000D8 RID: 216
		[global::Cpp2ILInjected.Token(Token = "0x40000D8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xC8")]
		private readonly List<BindingSource> visibleBindings;

		// Token: 0x040000D9 RID: 217
		[global::Cpp2ILInjected.Token(Token = "0x40000D9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD0")]
		private readonly ReadOnlyCollection<BindingSource> bindings;

		// Token: 0x040000DA RID: 218
		[global::Cpp2ILInjected.Token(Token = "0x40000DA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xD8")]
		private readonly ReadOnlyCollection<BindingSource> unfilteredBindings;

		// Token: 0x040000DB RID: 219
		[global::Cpp2ILInjected.Token(Token = "0x40000DB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE0")]
		private readonly BindingSourceListener[] bindingSourceListeners;

		// Token: 0x040000DC RID: 220
		[global::Cpp2ILInjected.Token(Token = "0x40000DC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE8")]
		private bool triggerBindingEnded;

		// Token: 0x040000DD RID: 221
		[global::Cpp2ILInjected.Token(Token = "0x40000DD")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xE9")]
		private bool triggerBindingChanged;

		// Token: 0x040000DE RID: 222
		[global::Cpp2ILInjected.Token(Token = "0x40000DE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF0")]
		private InputDevice device;

		// Token: 0x040000DF RID: 223
		[global::Cpp2ILInjected.Token(Token = "0x40000DF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0xF8")]
		private InputDevice activeDevice;
	}
}
