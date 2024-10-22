﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InControl
{
	[global::Cpp2ILInjected.Token(Token = "0x200003A")]
	public static class InputManager
	{
		[global::Cpp2ILInjected.Token(Token = "0x14000007")]
		public static event Action OnSetup
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994A00", Offset = "0x1994A00", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994ADC", Offset = "0x1994ADC", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000008")]
		public static event Action<ulong, float> OnUpdate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994BB8", Offset = "0x1994BB8", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994CAC", Offset = "0x1994CAC", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x14000009")]
		public static event Action OnReset
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994DA0", Offset = "0x1994DA0", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994E7C", Offset = "0x1994E7C", Length = "0xDC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400000A")]
		public static event Action<InputDevice> OnDeviceAttached
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1994F58", Offset = "0x1994F58", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x199504C", Offset = "0x199504C", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400000B")]
		public static event Action<InputDevice> OnDeviceDetached
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995140", Offset = "0x1995140", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerManager", Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.PlayerManager", Member = "Start", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995234", Offset = "0x1995234", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerManager", Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400000C")]
		public static event Action<InputDevice> OnActiveDeviceChanged
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995328", Offset = "0x1995328", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
			[global::Cpp2ILInjected.Address(RVA = "0x199541C", Offset = "0x199541C", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400000D")]
		internal static event Action<ulong, float> OnUpdateDevices
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995510", Offset = "0x1995510", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995604", Offset = "0x1995604", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1400000E")]
		internal static event Action<ulong, float> OnCommitDevices
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
			[global::Cpp2ILInjected.Address(RVA = "0x19956F8", Offset = "0x19956F8", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Combine", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			add
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x19957EC", Offset = "0x19957EC", Length = "0xF4")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Delegate), Member = "Remove", MemberParameters = new object[]
			{
				typeof(Delegate),
				typeof(Delegate)
			}, ReturnType = typeof(Delegate))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			remove
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000F5")]
		public static bool CommandWasPressed
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002DD")]
			[global::Cpp2ILInjected.Address(RVA = "0x19958E0", Offset = "0x19958E0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002DE")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995938", Offset = "0x1995938", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000F6")]
		public static bool InvertYAxis
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995994", Offset = "0x1995994", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
			[global::Cpp2ILInjected.Address(RVA = "0x19959EC", Offset = "0x19959EC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000F7")]
		public static bool IsSetup
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995A48", Offset = "0x1995A48", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995AA0", Offset = "0x1995AA0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000F8")]
		internal static string Platform
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995AFC", Offset = "0x1995AFC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995B54", Offset = "0x1995B54", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			private set
			{
				throw null;
			}
		}

		[Obsolete("Use InputManager.CommandWasPressed instead.")]
		[global::Cpp2ILInjected.Token(Token = "0x170000F9")]
		public static bool MenuWasPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1995BB0", Offset = "0x1995BB0", Length = "0x88")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1995C38", Offset = "0x1995C38", Length = "0x3D8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "Reload", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Utility), Member = "GetPlatformName", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "AsReadOnly", ReturnType = "System.Collections.ObjectModel.ReadOnlyCollection`1<T>")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(NativeInputDeviceManager), Member = "Enable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AddDeviceManager", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 24)]
		internal static bool SetupInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996340", Offset = "0x1996340", Length = "0x128")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "Reload", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "OnApplicationQuit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "DestroyDeviceManagers", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "DestroyDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static void ResetInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x19966BC", Offset = "0x19966BC", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Update()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996708", Offset = "0x1996708", Length = "0x28C")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "Update", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "FixedUpdate", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "OnLevelWasLoaded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "set_Enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AssertIsSetup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdateCurrentTime", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdateDeviceManagers", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdateDevices", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "CommitDevices", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdateActiveDevice", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdatePlayerActionSets", MemberParameters = new object[] { typeof(float) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		internal static void UpdateInternal()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x19971B8", Offset = "0x19971B8", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "ResetInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "SetupInternal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void Reload()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996994", Offset = "0x1996994", Length = "0xD4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "AddDeviceManager", MemberParameters = new object[] { typeof(InputDeviceManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void AssertIsSetup()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1997208", Offset = "0x1997208", Length = "0x148")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "OnApplicationFocus", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "OnLevelWasLoaded", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "set_Enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Count", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ReadOnlyCollection<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputControl), Member = "SetZeroTick", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void SetZeroTickOnAllControls()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1997350", Offset = "0x1997350", Length = "0x194")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "OnApplicationFocus", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "set_Enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "ClearInputState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "ClearInputState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static void ClearInputState()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x19974E4", Offset = "0x19974E4", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnApplicationFocus", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "ClearInputState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "SetZeroTickOnAllControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		internal static void OnApplicationFocus(bool focusState)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x19975BC", Offset = "0x19975BC", Length = "0x4")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnApplicationPause", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		internal static void OnApplicationPause(bool pauseState)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x19975C0", Offset = "0x19975C0", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnApplicationQuit", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "ResetInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void OnApplicationQuit()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x199760C", Offset = "0x199760C", Length = "0x50")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnSceneWasLoaded", MemberParameters = new object[]
		{
			typeof(Scene),
			typeof(LoadSceneMode)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "SetZeroTickOnAllControls", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		internal static void OnLevelWasLoaded()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
		[global::Cpp2ILInjected.Address(RVA = "0x199765C", Offset = "0x199765C", Length = "0x1D4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "AddDeviceManager", MemberTypeParameters = new object[] { "T" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AssertIsSetup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
		{
			typeof(string),
			typeof(string),
			typeof(string)
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Logger), Member = "LogError", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Add", MemberParameters = new object[]
		{
			typeof(object),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static void AddDeviceManager(InputDeviceManager deviceManager)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x158BC1C", Offset = "0x158BC1C", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "SetupInternal", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "Enable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AddDeviceManager", MemberParameters = new object[] { typeof(InputDeviceManager) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static void AddDeviceManager<T>() where T : InputDeviceManager, new()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x158BC8C", Offset = "0x158BC8C", Length = "0x140")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "TryGetValue", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		public static T GetDeviceManager<T>() where T : InputDeviceManager
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x158BDCC", Offset = "0x158BDCC", Length = "0xB4")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "ContainsKey", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static bool HasDeviceManager<T>() where T : InputDeviceManager
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996A68", Offset = "0x1996A68", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Time), Member = "get_realtimeSinceStartup", ReturnType = typeof(float))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void UpdateCurrentTime()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996B38", Offset = "0x1996B38", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static void UpdateDeviceManagers(float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996468", Offset = "0x1996468", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "ResetInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = "Clear", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void DestroyDeviceManagers()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996588", Offset = "0x1996588", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "ResetInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "OnDetached", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 8)]
		private static void DestroyDevices()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996C28", Offset = "0x1996C28", Length = "0x130")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		private static void UpdateDevices(float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996D58", Offset = "0x1996D58", Length = "0x1A4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "Commit", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "get_CommandWasPressed", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 10)]
		private static void CommitDevices(float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1996EFC", Offset = "0x1996EFC", Length = "0x1D0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Array), Member = "Clear", MemberParameters = new object[]
		{
			typeof(Array),
			typeof(int),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "LastInputAfter", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "set_ActiveDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		private static void UpdateActiveDevice()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x19978C0", Offset = "0x19978C0", Length = "0x280")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(NativeInputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "CreateDevice", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "AttachDevice", MemberParameters = new object[] { typeof(UnityInputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "<OnEnable>b__3_0", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "AssertIsSetup", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Comparison<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Sort", MemberParameters = new object[] { typeof(Comparison<object>) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "OnAttached", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		public static void AttachDevice(InputDevice inputDevice)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1997B40", Offset = "0x1997B40", Length = "0x188")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "DetachDevice", MemberParameters = new object[] { typeof(NativeInputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(OuyaEverywhereDeviceManager), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetachDevices", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "get_ActiveDevice", ReturnType = typeof(InputDevice))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "set_ActiveDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDevice), Member = "OnDetached", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		public static void DetachDevice(InputDevice inputDevice)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60002FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1997CC8", Offset = "0x1997CC8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(NativeInputDeviceManager), Member = "Enable", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputDeviceProfile), Member = "Hide", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static void HideDevicesWithProfile(Type type)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1997D98", Offset = "0x1997D98", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		internal static void AttachPlayerActionSet(PlayerActionSet playerActionSet)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000301")]
		[global::Cpp2ILInjected.Address(RVA = "0x1997E9C", Offset = "0x1997E9C", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "Destroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		internal static void DetachPlayerActionSet(PlayerActionSet playerActionSet)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x6000302")]
		[global::Cpp2ILInjected.Address(RVA = "0x19970CC", Offset = "0x19970CC", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PlayerActionSet), Member = "Update", MemberParameters = new object[]
		{
			typeof(ulong),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		internal static void UpdatePlayerActionSets(float deltaTime)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000FA")]
		public static bool AnyKeyIsPressed
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000303")]
			[global::Cpp2ILInjected.Address(RVA = "0x1997F14", Offset = "0x1997F14", Length = "0x70")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(KeyCombo), Member = "Detect", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(KeyCombo))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000FB")]
		public static InputDevice ActiveDevice
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000304")]
			[global::Cpp2ILInjected.Address(RVA = "0x19940A8", Offset = "0x19940A8", Length = "0x8C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerActionSet), Member = "FindActiveDevice", ReturnType = typeof(InputDevice))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlInputModule), Member = "get_Device", ReturnType = typeof(InputDevice))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateActiveDevice", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "DetachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnGUI", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "OnDrawGizmos", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "VirtualDeviceExample.VirtualDeviceExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TouchExample.CubeController", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerManager", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.PlayerManager", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InterfaceMovement.ButtonManager", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "BasicExample.BasicExample", Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 16)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000305")]
			[global::Cpp2ILInjected.Address(RVA = "0x1997830", Offset = "0x1997830", Length = "0x90")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "UpdateActiveDevice", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InputManager), Member = "DetachDevice", MemberParameters = new object[] { typeof(InputDevice) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			private set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000FC")]
		public static bool Enabled
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000306")]
			[global::Cpp2ILInjected.Address(RVA = "0x1997F84", Offset = "0x1997F84", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x6000307")]
			[global::Cpp2ILInjected.Address(RVA = "0x1997FDC", Offset = "0x1997FDC", Length = "0xAC")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TestInputManager), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "SetZeroTickOnAllControls", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "UpdateInternal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InputManager), Member = "ClearInputState", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000FD")]
		public static bool SuspendInBackground
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000308")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998088", Offset = "0x1998088", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000309")]
			[global::Cpp2ILInjected.Address(RVA = "0x19980E0", Offset = "0x19980E0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000FE")]
		public static bool EnableNativeInput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600030A")]
			[global::Cpp2ILInjected.Address(RVA = "0x199813C", Offset = "0x199813C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600030B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998194", Offset = "0x1998194", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x170000FF")]
		public static bool EnableXInput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600030C")]
			[global::Cpp2ILInjected.Address(RVA = "0x19981F0", Offset = "0x19981F0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600030D")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998248", Offset = "0x1998248", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000100")]
		public static bool EditorDisableAllProfiles
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600030E")]
			[global::Cpp2ILInjected.Address(RVA = "0x19982A4", Offset = "0x19982A4", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600030F")]
			[global::Cpp2ILInjected.Address(RVA = "0x19982FC", Offset = "0x19982FC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000101")]
		public static uint XInputUpdateRate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000310")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998358", Offset = "0x1998358", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000311")]
			[global::Cpp2ILInjected.Address(RVA = "0x19983B0", Offset = "0x19983B0", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000102")]
		public static uint XInputBufferSize
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000312")]
			[global::Cpp2ILInjected.Address(RVA = "0x199840C", Offset = "0x199840C", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000313")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998464", Offset = "0x1998464", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000103")]
		public static bool NativeInputEnableXInput
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000314")]
			[global::Cpp2ILInjected.Address(RVA = "0x19984C0", Offset = "0x19984C0", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000315")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998518", Offset = "0x1998518", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000104")]
		public static bool NativeInputEnableMFi
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000316")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998574", Offset = "0x1998574", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000317")]
			[global::Cpp2ILInjected.Address(RVA = "0x19985CC", Offset = "0x19985CC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000105")]
		public static bool NativeInputPreventSleep
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000318")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998628", Offset = "0x1998628", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x6000319")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998680", Offset = "0x1998680", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000106")]
		public static uint NativeInputUpdateRate
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600031A")]
			[global::Cpp2ILInjected.Address(RVA = "0x19986DC", Offset = "0x19986DC", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600031B")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998734", Offset = "0x1998734", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000107")]
		public static bool EnableICade
		{
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600031C")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998790", Offset = "0x1998790", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
			[CompilerGenerated]
			[global::Cpp2ILInjected.Token(Token = "0x600031D")]
			[global::Cpp2ILInjected.Address(RVA = "0x19987E8", Offset = "0x19987E8", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			internal set
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000108")]
		internal static VersionInfo UnityVersion
		{
			[global::Cpp2ILInjected.Token(Token = "0x600031E")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998844", Offset = "0x1998844", Length = "0x10C")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityInputDeviceManager), Member = "DetectJoystickDevice", MemberParameters = new object[]
			{
				typeof(int),
				typeof(string)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "UnityVersion", ReturnType = typeof(VersionInfo))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo?), Member = ".ctor", MemberParameters = new object[] { typeof(VersionInfo) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo?), Member = "get_Value", ReturnType = "T")]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x17000109")]
		public static ulong CurrentTick
		{
			[global::Cpp2ILInjected.Token(Token = "0x600031F")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998950", Offset = "0x1998950", Length = "0x58")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000320")]
		[global::Cpp2ILInjected.Address(RVA = "0x19989A8", Offset = "0x19989A8", Length = "0x1EC")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(VersionInfo), Member = "InControlVersion", ReturnType = typeof(VersionInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Dictionary<object, object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 16)]
		static InputManager()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x40002A6")]
		public static readonly VersionInfo Version;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A7")]
		private static Action OnSetup;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A8")]
		private static Action<ulong, float> OnUpdate;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002A9")]
		private static Action OnReset;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AA")]
		private static Action<InputDevice> OnDeviceAttached;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AB")]
		private static Action<InputDevice> OnDeviceDetached;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AC")]
		private static Action<InputDevice> OnActiveDeviceChanged;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AD")]
		private static Action<ulong, float> OnUpdateDevices;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002AE")]
		private static Action<ulong, float> OnCommitDevices;

		[global::Cpp2ILInjected.Token(Token = "0x40002AF")]
		private static readonly List<InputDeviceManager> deviceManagers;

		[global::Cpp2ILInjected.Token(Token = "0x40002B0")]
		private static readonly Dictionary<Type, InputDeviceManager> deviceManagerTable;

		[global::Cpp2ILInjected.Token(Token = "0x40002B1")]
		private static readonly List<InputDevice> devices;

		[global::Cpp2ILInjected.Token(Token = "0x40002B2")]
		private static InputDevice activeDevice;

		[global::Cpp2ILInjected.Token(Token = "0x40002B3")]
		private static readonly List<InputDevice> activeDevices;

		[global::Cpp2ILInjected.Token(Token = "0x40002B4")]
		private static readonly List<PlayerActionSet> playerActionSets;

		[global::Cpp2ILInjected.Token(Token = "0x40002B5")]
		public static ReadOnlyCollection<InputDevice> Devices;

		[global::Cpp2ILInjected.Token(Token = "0x40002B6")]
		public static ReadOnlyCollection<InputDevice> ActiveDevices;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B7")]
		private static bool <CommandWasPressed>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B8")]
		private static bool <InvertYAxis>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002B9")]
		private static bool <IsSetup>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002BA")]
		private static string <Platform>k__BackingField;

		[global::Cpp2ILInjected.Token(Token = "0x40002BB")]
		private static bool applicationIsFocused;

		[global::Cpp2ILInjected.Token(Token = "0x40002BC")]
		private static float initialTime;

		[global::Cpp2ILInjected.Token(Token = "0x40002BD")]
		private static float currentTime;

		[global::Cpp2ILInjected.Token(Token = "0x40002BE")]
		private static float lastUpdateTime;

		[global::Cpp2ILInjected.Token(Token = "0x40002BF")]
		private static ulong currentTick;

		[global::Cpp2ILInjected.Token(Token = "0x40002C0")]
		private static VersionInfo? unityVersion;

		[global::Cpp2ILInjected.Token(Token = "0x40002C1")]
		private static bool enabled;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002C2")]
		private static bool <SuspendInBackground>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002C3")]
		private static bool <EnableNativeInput>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002C4")]
		private static bool <EnableXInput>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002C5")]
		private static bool <EditorDisableAllProfiles>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002C6")]
		private static uint <XInputUpdateRate>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002C7")]
		private static uint <XInputBufferSize>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002C8")]
		private static bool <NativeInputEnableXInput>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002C9")]
		private static bool <NativeInputEnableMFi>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002CA")]
		private static bool <NativeInputPreventSleep>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002CB")]
		private static uint <NativeInputUpdateRate>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x40002CC")]
		private static bool <EnableICade>k__BackingField;

		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200003B")]
		[Serializable]
		private sealed class <>c
		{
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x6000321")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998B94", Offset = "0x1998B94", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000322")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998BF0", Offset = "0x1998BF0", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x6000323")]
			[global::Cpp2ILInjected.Address(RVA = "0x1998BF8", Offset = "0x1998BF8", Length = "0x24")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			internal int <AttachDevice>b__80_0(InputDevice d1, InputDevice d2)
			{
				throw null;
			}

			[global::Cpp2ILInjected.Token(Token = "0x40002CD")]
			public static readonly InputManager.<>c <>9;

			[global::Cpp2ILInjected.Token(Token = "0x40002CE")]
			public static Comparison<InputDevice> <>9__80_0;
		}
	}
}
