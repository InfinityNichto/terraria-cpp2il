using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Runtime.CompilerServices;
using System.Text;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;

namespace InControl
{
	// Token: 0x02000012 RID: 18
	[global::Cpp2ILInjected.Token(Token = "0x2000012")]
	public abstract class PlayerActionSet
	{
		// Token: 0x1700002D RID: 45
		// (get) Token: 0x060000B4 RID: 180 RVA: 0x00002285 File Offset: 0x00000485
		// (set) Token: 0x060000B5 RID: 181 RVA: 0x00002288 File Offset: 0x00000488
		[global::Cpp2ILInjected.Token(Token = "0x1700002D")]
		public InputDevice Device
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000B4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1981194", Offset = "0x1981194", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000B5")]
			[global::Cpp2ILInjected.Address(RVA = "0x198119C", Offset = "0x198119C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x1700002E RID: 46
		// (get) Token: 0x060000B6 RID: 182 RVA: 0x0000228B File Offset: 0x0000048B
		// (set) Token: 0x060000B7 RID: 183 RVA: 0x0000228E File Offset: 0x0000048E
		[global::Cpp2ILInjected.Token(Token = "0x1700002E")]
		public List<InputDevice> IncludeDevices
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000B6")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811A4", Offset = "0x19811A4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000B7")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811AC", Offset = "0x19811AC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x1700002F RID: 47
		// (get) Token: 0x060000B8 RID: 184 RVA: 0x00002291 File Offset: 0x00000491
		// (set) Token: 0x060000B9 RID: 185 RVA: 0x00002294 File Offset: 0x00000494
		[global::Cpp2ILInjected.Token(Token = "0x1700002F")]
		public List<InputDevice> ExcludeDevices
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000B8")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811B4", Offset = "0x19811B4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000B9")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811BC", Offset = "0x19811BC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000030 RID: 48
		// (get) Token: 0x060000BA RID: 186 RVA: 0x00002297 File Offset: 0x00000497
		// (set) Token: 0x060000BB RID: 187 RVA: 0x0000229A File Offset: 0x0000049A
		[global::Cpp2ILInjected.Token(Token = "0x17000030")]
		public ReadOnlyCollection<PlayerAction> Actions
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000BA")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811C4", Offset = "0x19811C4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000BB")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811CC", Offset = "0x19811CC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			private set
			{
				throw null;
			}
		}

		// Token: 0x17000031 RID: 49
		// (get) Token: 0x060000BC RID: 188 RVA: 0x0000229D File Offset: 0x0000049D
		// (set) Token: 0x060000BD RID: 189 RVA: 0x000022A0 File Offset: 0x000004A0
		[global::Cpp2ILInjected.Token(Token = "0x17000031")]
		public ulong UpdateTick
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000BC")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811D4", Offset = "0x19811D4", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000BD")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811DC", Offset = "0x19811DC", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			protected set
			{
				throw null;
			}
		}

		// Token: 0x14000003 RID: 3
		// (add) Token: 0x060000BE RID: 190 RVA: 0x000022A3 File Offset: 0x000004A3
		// (remove) Token: 0x060000BF RID: 191 RVA: 0x000022A6 File Offset: 0x000004A6
		[global::Cpp2ILInjected.Token(Token = "0x14000003")]
		public event Action<BindingSourceType> OnLastInputTypeChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000BE")]
			[global::Cpp2ILInjected.Address(RVA = "0x19811E4", Offset = "0x19811E4", Length = "0xB0")]
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
			[global::Cpp2ILInjected.Token(Token = "0x60000BF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1981294", Offset = "0x1981294", Length = "0xB0")]
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

		// Token: 0x17000032 RID: 50
		// (get) Token: 0x060000C0 RID: 192 RVA: 0x000022A9 File Offset: 0x000004A9
		// (set) Token: 0x060000C1 RID: 193 RVA: 0x000022AC File Offset: 0x000004AC
		[global::Cpp2ILInjected.Token(Token = "0x17000032")]
		public bool Enabled
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1981344", Offset = "0x1981344", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C1")]
			[global::Cpp2ILInjected.Address(RVA = "0x198134C", Offset = "0x198134C", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000033 RID: 51
		// (get) Token: 0x060000C2 RID: 194 RVA: 0x000022AF File Offset: 0x000004AF
		// (set) Token: 0x060000C3 RID: 195 RVA: 0x000022B2 File Offset: 0x000004B2
		[global::Cpp2ILInjected.Token(Token = "0x17000033")]
		public bool PreventInputWhileListeningForBinding
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1981358", Offset = "0x1981358", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1981360", Offset = "0x1981360", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x060000C4 RID: 196 RVA: 0x000022B5 File Offset: 0x000004B5
		// (set) Token: 0x060000C5 RID: 197 RVA: 0x000022B8 File Offset: 0x000004B8
		[global::Cpp2ILInjected.Token(Token = "0x17000034")]
		public object UserData
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C4")]
			[global::Cpp2ILInjected.Address(RVA = "0x198136C", Offset = "0x198136C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60000C5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1981374", Offset = "0x1981374", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x000022BB File Offset: 0x000004BB
		[global::Cpp2ILInjected.Token(Token = "0x60000C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x198137C", Offset = "0x198137C", Length = "0x26C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerActions", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = ".ctor", MemberParameters = new object[] { typeof(IList<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AttachPlayerActionSet", MemberParameters = new object[] { typeof(PlayerActionSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 23)]
		protected PlayerActionSet()
		{
			throw null;
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x000022BE File Offset: 0x000004BE
		[global::Cpp2ILInjected.Token(Token = "0x60000C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x19815E8", Offset = "0x19815E8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.Player", Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerManager", Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "DetachPlayerActionSet", MemberParameters = new object[] { typeof(PlayerActionSet) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Destroy()
		{
			throw null;
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x000022C1 File Offset: 0x000004C1
		[global::Cpp2ILInjected.Token(Token = "0x60000C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1981644", Offset = "0x1981644", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerActions", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerActionSet)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		protected PlayerAction CreatePlayerAction(string name)
		{
			throw null;
		}

		// Token: 0x060000C9 RID: 201 RVA: 0x000022C4 File Offset: 0x000004C4
		[global::Cpp2ILInjected.Token(Token = "0x60000C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x197EE60", Offset = "0x197EE60", Length = "0x170")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(string),
			typeof(PlayerActionSet)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "FindActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "UpdateVisibleBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InControlException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		internal void AddPlayerAction(PlayerAction action)
		{
			throw null;
		}

		// Token: 0x060000CA RID: 202 RVA: 0x000022C7 File Offset: 0x000004C7
		[global::Cpp2ILInjected.Token(Token = "0x60000CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19818A4", Offset = "0x19818A4", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected PlayerOneAxisAction CreateOneAxisPlayerAction(PlayerAction negativeAction, PlayerAction positiveAction)
		{
			throw null;
		}

		// Token: 0x060000CB RID: 203 RVA: 0x000022CA File Offset: 0x000004CA
		[global::Cpp2ILInjected.Token(Token = "0x60000CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19819FC", Offset = "0x19819FC", Length = "0xF4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerActions", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.PlayerActions", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerTwoAxisAction), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(PlayerAction),
			typeof(PlayerAction),
			typeof(PlayerAction),
			typeof(PlayerAction)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected PlayerTwoAxisAction CreateTwoAxisPlayerAction(PlayerAction negativeXAction, PlayerAction positiveXAction, PlayerAction negativeYAction, PlayerAction positiveYAction)
		{
			throw null;
		}

		// Token: 0x17000035 RID: 53
		[global::Cpp2ILInjected.Token(Token = "0x17000035")]
		public PlayerAction this[string actionName]
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000CC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1981B7C", Offset = "0x1981B7C", Length = "0xD8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyNotFoundException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000CD RID: 205 RVA: 0x000022D0 File Offset: 0x000004D0
		[global::Cpp2ILInjected.Token(Token = "0x60000CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1981C54", Offset = "0x1981C54", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public PlayerAction GetPlayerActionByName(string actionName)
		{
			throw null;
		}

		// Token: 0x060000CE RID: 206 RVA: 0x000022D3 File Offset: 0x000004D3
		[global::Cpp2ILInjected.Token(Token = "0x60000CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1981CC4", Offset = "0x1981CC4", Length = "0x264")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdatePlayerActionSets", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "FindActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float),
			typeof(InputDevice)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerOneAxisAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerTwoAxisAction), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal void Update(ulong updateTick, float deltaTime)
		{
			throw null;
		}

		// Token: 0x060000CF RID: 207 RVA: 0x000022D6 File Offset: 0x000004D6
		[global::Cpp2ILInjected.Token(Token = "0x60000CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19821D8", Offset = "0x19821D8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "LoadData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "OnGUI", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "ResetBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void Reset()
		{
			throw null;
		}

		// Token: 0x060000D0 RID: 208 RVA: 0x000022D9 File Offset: 0x000004D9
		[global::Cpp2ILInjected.Token(Token = "0x60000D0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19816AC", Offset = "0x19816AC", Length = "0x1F8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "AddPlayerAction", MemberParameters = new object[] { typeof(PlayerAction) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private InputDevice FindActiveDevice()
		{
			throw null;
		}

		// Token: 0x060000D1 RID: 209 RVA: 0x000022DC File Offset: 0x000004DC
		[global::Cpp2ILInjected.Token(Token = "0x60000D1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1982298", Offset = "0x1982298", Length = "0x1E0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "ClearInputState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(TwoAxisInputControl), Member = "ClearInputState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public void ClearInputState()
		{
			throw null;
		}

		// Token: 0x060000D2 RID: 210 RVA: 0x000022DF File Offset: 0x000004DF
		[global::Cpp2ILInjected.Token(Token = "0x60000D2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1980CD8", Offset = "0x1980CD8", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerAction), Member = "DetectBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "FindBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool HasBinding(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x060000D3 RID: 211 RVA: 0x000022E2 File Offset: 0x000004E2
		[global::Cpp2ILInjected.Token(Token = "0x60000D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1982594", Offset = "0x1982594", Length = "0xC0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "FindBinding", MemberParameters = new object[] { typeof(BindingSource) }, ReturnType = typeof(BindingSource))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void RemoveBinding(BindingSource binding)
		{
			throw null;
		}

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x060000D4 RID: 212 RVA: 0x000022E5 File Offset: 0x000004E5
		[global::Cpp2ILInjected.Token(Token = "0x17000036")]
		public bool IsListeningForBinding
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1980AC4", Offset = "0x1980AC4", Length = "0x10")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x060000D5 RID: 213 RVA: 0x000022E8 File Offset: 0x000004E8
		// (set) Token: 0x060000D6 RID: 214 RVA: 0x000022EB File Offset: 0x000004EB
		[global::Cpp2ILInjected.Token(Token = "0x17000037")]
		public BindingListenOptions ListenOptions
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1982654", Offset = "0x1982654", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60000D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x198265C", Offset = "0x198265C", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x060000D7 RID: 215 RVA: 0x000022EE File Offset: 0x000004EE
		[global::Cpp2ILInjected.Token(Token = "0x17000038")]
		public InputDevice ActiveDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x60000D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x19826CC", Offset = "0x19826CC", Length = "0x64")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060000D8 RID: 216 RVA: 0x000022F1 File Offset: 0x000004F1
		[global::Cpp2ILInjected.Token(Token = "0x60000D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1982730", Offset = "0x1982730", Length = "0x400")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Save", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Encoding), Member = "get_UTF8", ReturnType = typeof(Encoding))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryWriter), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Stream),
			typeof(Encoding)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "Save", MemberParameters = new object[] { typeof(BinaryWriter) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 21)]
		public byte[] SaveData()
		{
			throw null;
		}

		// Token: 0x060000D9 RID: 217 RVA: 0x000022F4 File Offset: 0x000004F4
		[global::Cpp2ILInjected.Token(Token = "0x60000D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1982B30", Offset = "0x1982B30", Length = "0x548")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Load", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MemoryStream), Member = ".ctor", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(BinaryReader), Member = ".ctor", MemberParameters = new object[] { typeof(Stream) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerAction), Member = "Load", MemberParameters = new object[]
		{
			typeof(BinaryReader),
			typeof(ushort)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ushort), Member = "ToString", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 40)]
		public void LoadData(byte[] data)
		{
			throw null;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x000022F7 File Offset: 0x000004F7
		[global::Cpp2ILInjected.Token(Token = "0x60000DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1983078", Offset = "0x1983078", Length = "0x68")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "SaveBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "SaveData", ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "ToBase64String", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public string Save()
		{
			throw null;
		}

		// Token: 0x060000DB RID: 219 RVA: 0x000022FA File Offset: 0x000004FA
		[global::Cpp2ILInjected.Token(Token = "0x60000DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x19830E0", Offset = "0x19830E0", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BindingsExample.BindingsExample", Member = "LoadBindings", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Convert), Member = "FromBase64String", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(byte[]))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "LoadData", MemberParameters = new object[] { typeof(byte[]) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Debug), Member = "LogError", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "Reset", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 14)]
		public void Load(string data)
		{
			throw null;
		}

		// Token: 0x040000E0 RID: 224
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000E0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private InputDevice <Device>k__BackingField;

		// Token: 0x040000E1 RID: 225
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000E1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private List<InputDevice> <IncludeDevices>k__BackingField;

		// Token: 0x040000E2 RID: 226
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000E2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private List<InputDevice> <ExcludeDevices>k__BackingField;

		// Token: 0x040000E3 RID: 227
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000E3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private ReadOnlyCollection<PlayerAction> <Actions>k__BackingField;

		// Token: 0x040000E4 RID: 228
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000E4")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ulong <UpdateTick>k__BackingField;

		// Token: 0x040000E5 RID: 229
		[global::Cpp2ILInjected.Token(Token = "0x40000E5")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		public BindingSourceType LastInputType;

		// Token: 0x040000E6 RID: 230
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000E6")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x40")]
		private Action<BindingSourceType> OnLastInputTypeChanged;

		// Token: 0x040000E7 RID: 231
		[global::Cpp2ILInjected.Token(Token = "0x40000E7")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x48")]
		public ulong LastInputTypeChangedTick;

		// Token: 0x040000E8 RID: 232
		[global::Cpp2ILInjected.Token(Token = "0x40000E8")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x50")]
		public InputDeviceClass LastDeviceClass;

		// Token: 0x040000E9 RID: 233
		[global::Cpp2ILInjected.Token(Token = "0x40000E9")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x54")]
		public InputDeviceStyle LastDeviceStyle;

		// Token: 0x040000EA RID: 234
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000EA")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x58")]
		private bool <Enabled>k__BackingField;

		// Token: 0x040000EB RID: 235
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000EB")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x59")]
		private bool <PreventInputWhileListeningForBinding>k__BackingField;

		// Token: 0x040000EC RID: 236
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40000EC")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x60")]
		private object <UserData>k__BackingField;

		// Token: 0x040000ED RID: 237
		[global::Cpp2ILInjected.Token(Token = "0x40000ED")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x68")]
		private List<PlayerAction> actions;

		// Token: 0x040000EE RID: 238
		[global::Cpp2ILInjected.Token(Token = "0x40000EE")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x70")]
		private List<PlayerOneAxisAction> oneAxisActions;

		// Token: 0x040000EF RID: 239
		[global::Cpp2ILInjected.Token(Token = "0x40000EF")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x78")]
		private List<PlayerTwoAxisAction> twoAxisActions;

		// Token: 0x040000F0 RID: 240
		[global::Cpp2ILInjected.Token(Token = "0x40000F0")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x80")]
		private Dictionary<string, PlayerAction> actionsByName;

		// Token: 0x040000F1 RID: 241
		[global::Cpp2ILInjected.Token(Token = "0x40000F1")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x88")]
		private BindingListenOptions listenOptions;

		// Token: 0x040000F2 RID: 242
		[global::Cpp2ILInjected.Token(Token = "0x40000F2")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x90")]
		internal PlayerAction listenWithAction;

		// Token: 0x040000F3 RID: 243
		[global::Cpp2ILInjected.Token(Token = "0x40000F3")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x98")]
		private InputDevice activeDevice;

		// Token: 0x040000F4 RID: 244
		[global::Cpp2ILInjected.Token(Token = "0x40000F4")]
		private const ushort currentDataFormatVersion = 2;
	}
}
