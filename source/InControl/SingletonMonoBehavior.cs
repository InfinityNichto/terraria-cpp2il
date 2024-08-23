using System;
using System.Runtime.CompilerServices;
using System.Threading;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace InControl
{
	// Token: 0x02000062 RID: 98
	[global::Cpp2ILInjected.Token(Token = "0x200006D")]
	public abstract class SingletonMonoBehavior<TComponent> : MonoBehaviour where TComponent : MonoBehaviour
	{
		// Token: 0x17000161 RID: 353
		// (get) Token: 0x060004EF RID: 1263 RVA: 0x00002EFA File Offset: 0x000010FA
		[global::Cpp2ILInjected.Token(Token = "0x17000163")]
		public static TComponent Instance
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000503")]
			[global::Cpp2ILInjected.Address(RVA = "0x1865910", Offset = "0x1865910", Length = "0x50C")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Equality", MemberParameters = new object[]
			{
				typeof(global::UnityEngine.Object),
				typeof(global::UnityEngine.Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Concat", MemberParameters = new object[]
			{
				typeof(string),
				typeof(string),
				typeof(string)
			}, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Exception), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 55)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000162 RID: 354
		// (get) Token: 0x060004F0 RID: 1264 RVA: 0x00002EFD File Offset: 0x000010FD
		[global::Cpp2ILInjected.Token(Token = "0x17000164")]
		protected bool EnforceSingleton
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000504")]
			[global::Cpp2ILInjected.Address(RVA = "0x1865E1C", Offset = "0x1865E1C", Length = "0xA4")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = "OnEnable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000163 RID: 355
		// (get) Token: 0x060004F1 RID: 1265 RVA: 0x00002F00 File Offset: 0x00001100
		[global::Cpp2ILInjected.Token(Token = "0x17000165")]
		protected bool IsTheSingleton
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000505")]
			[global::Cpp2ILInjected.Address(RVA = "0x1865EC0", Offset = "0x1865EC0", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			get
			{
				throw null;
			}
		}

		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060004F2 RID: 1266 RVA: 0x00002F03 File Offset: 0x00001103
		[global::Cpp2ILInjected.Token(Token = "0x17000166")]
		protected bool IsNotTheSingleton
		{
			[global::Cpp2ILInjected.Token(Token = "0x6000506")]
			[global::Cpp2ILInjected.Address(RVA = "0x1866034", Offset = "0x1866034", Length = "0x174")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnDisable", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "Update", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "FixedUpdate", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnApplicationFocus", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnApplicationPause", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnApplicationQuit", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = "OnSceneWasLoaded", MemberParameters = new object[]
			{
				typeof(Scene),
				typeof(LoadSceneMode)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
			{
				typeof(object),
				typeof(ref bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
			get
			{
				throw null;
			}
		}

		// Token: 0x060004F3 RID: 1267 RVA: 0x00002F06 File Offset: 0x00001106
		[global::Cpp2ILInjected.Token(Token = "0x6000507")]
		[global::Cpp2ILInjected.Address(RVA = "0x18661A8", Offset = "0x18661A8", Length = "0x2CC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 26)]
		private static TComponent[] FindInstances()
		{
			throw null;
		}

		// Token: 0x060004F4 RID: 1268 RVA: 0x00002F09 File Offset: 0x00001109
		[global::Cpp2ILInjected.Token(Token = "0x6000508")]
		[global::Cpp2ILInjected.Address(RVA = "0x1866474", Offset = "0x1866474", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		private static TComponent FindFirstInstance()
		{
			throw null;
		}

		// Token: 0x060004F5 RID: 1269 RVA: 0x00002F0C File Offset: 0x0000110C
		[global::Cpp2ILInjected.Token(Token = "0x6000509")]
		[global::Cpp2ILInjected.Address(RVA = "0x1866514", Offset = "0x1866514", Length = "0x538")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Application), Member = "get_isPlaying", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(global::UnityEngine.Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Behaviour), Member = "set_enabled", MemberParameters = new object[] { typeof(bool) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 34)]
		protected virtual void Awake()
		{
			throw null;
		}

		// Token: 0x060004F6 RID: 1270 RVA: 0x00002F0F File Offset: 0x0000110F
		[global::Cpp2ILInjected.Token(Token = "0x600050A")]
		[global::Cpp2ILInjected.Address(RVA = "0x1866A4C", Offset = "0x1866A4C", Length = "0x1BC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Enter", MemberParameters = new object[]
		{
			typeof(object),
			typeof(ref bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "GetInstanceID", ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Monitor), Member = "Exit", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 15)]
		protected virtual void OnDestroy()
		{
			throw null;
		}

		// Token: 0x060004F7 RID: 1271 RVA: 0x00002F12 File Offset: 0x00001112
		[global::Cpp2ILInjected.Token(Token = "0x600050B")]
		[global::Cpp2ILInjected.Address(RVA = "0x1866C08", Offset = "0x1866C08", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(InControlManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(TouchManager), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MonoBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		protected SingletonMonoBehavior()
		{
			throw null;
		}

		// Token: 0x060004F8 RID: 1272 RVA: 0x00002F15 File Offset: 0x00001115
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x600050C")]
		[global::Cpp2ILInjected.Address(RVA = "0x1866C10", Offset = "0x1866C10", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		static SingletonMonoBehavior()
		{
			throw null;
		}

		// Token: 0x040003A5 RID: 933
		[global::Cpp2ILInjected.Token(Token = "0x40003F2")]
		private static TComponent instance;

		// Token: 0x040003A6 RID: 934
		[global::Cpp2ILInjected.Token(Token = "0x40003F3")]
		private static bool hasInstance;

		// Token: 0x040003A7 RID: 935
		[global::Cpp2ILInjected.Token(Token = "0x40003F4")]
		private static int instanceId;

		// Token: 0x040003A8 RID: 936
		[global::Cpp2ILInjected.Token(Token = "0x40003F5")]
		private static readonly object lockObject;

		// Token: 0x020001F5 RID: 501
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x200006E")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x06000864 RID: 2148 RVA: 0x00003959 File Offset: 0x00001B59
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x600050D")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0264", Offset = "0x15B0264", Length = "0xEC")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x06000865 RID: 2149 RVA: 0x0000395C File Offset: 0x00001B5C
			[global::Cpp2ILInjected.Token(Token = "0x600050E")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0350", Offset = "0x15B0350", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x06000866 RID: 2150 RVA: 0x0000395F File Offset: 0x00001B5F
			[global::Cpp2ILInjected.Token(Token = "0x600050F")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B0358", Offset = "0x15B0358", Length = "0x54")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Component), Member = "get_transform", ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Transform), Member = "GetSiblingIndex", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(int), Member = "CompareTo", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(int))]
			internal int <FindInstances>b__12_0(TComponent a, TComponent b)
			{
				throw null;
			}

			// Token: 0x06000867 RID: 2151 RVA: 0x00003962 File Offset: 0x00001B62
			[global::Cpp2ILInjected.Token(Token = "0x6000510")]
			[global::Cpp2ILInjected.Address(RVA = "0x15B03AC", Offset = "0x15B03AC", Length = "0x80")]
			[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(global::UnityEngine.Object), Member = "GetInstanceID", ReturnType = typeof(int))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
			internal bool <Awake>b__14_0(TComponent o)
			{
				throw null;
			}

			// Token: 0x0400041F RID: 1055
			[global::Cpp2ILInjected.Token(Token = "0x40003F6")]
			public static readonly SingletonMonoBehavior<TComponent>.<>c <>9;

			// Token: 0x04000420 RID: 1056
			[global::Cpp2ILInjected.Token(Token = "0x40003F7")]
			public static Comparison<TComponent> <>9__12_0;

			// Token: 0x04000421 RID: 1057
			[global::Cpp2ILInjected.Token(Token = "0x40003F8")]
			public static Func<TComponent, bool> <>9__14_0;
		}
	}
}
