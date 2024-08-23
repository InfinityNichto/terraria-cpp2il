using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.EventSystems;

namespace UnityEngine.UI
{
	// Token: 0x0200003B RID: 59
	[DisallowMultipleComponent]
	[AddComponentMenu("UI/Toggle Group", 31)]
	[global::Cpp2ILInjected.Token(Token = "0x2000076")]
	public class ToggleGroup : UIBehaviour
	{
		// Token: 0x1700013D RID: 317
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x00002D70 File Offset: 0x00000F70
		// (set) Token: 0x0600047E RID: 1150 RVA: 0x00002D73 File Offset: 0x00000F73
		[global::Cpp2ILInjected.Token(Token = "0x17000150")]
		public bool allowSwitchOff
		{
			[global::Cpp2ILInjected.Token(Token = "0x60004E2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDEB6C", Offset = "0x1FDEB6C", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60004E3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDEB74", Offset = "0x1FDEB74", Length = "0xC")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			set
			{
				throw null;
			}
		}

		// Token: 0x0600047F RID: 1151 RVA: 0x00002D76 File Offset: 0x00000F76
		[global::Cpp2ILInjected.Token(Token = "0x60004E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEB80", Offset = "0x1FDEB80", Length = "0x7C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		protected ToggleGroup()
		{
			throw null;
		}

		// Token: 0x06000480 RID: 1152 RVA: 0x00002D79 File Offset: 0x00000F79
		[global::Cpp2ILInjected.Token(Token = "0x60004E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEBFC", Offset = "0x1FDEBFC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "Start", ReturnType = typeof(void))]
		protected override void Start()
		{
			throw null;
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x00002D7C File Offset: 0x00000F7C
		[global::Cpp2ILInjected.Token(Token = "0x60004E6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEC18", Offset = "0x1FDEC18", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UIBehaviour), Member = "OnEnable", ReturnType = typeof(void))]
		protected override void OnEnable()
		{
			throw null;
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x00002D7F File Offset: 0x00000F7F
		[global::Cpp2ILInjected.Token(Token = "0x60004E7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEC34", Offset = "0x1FDEC34", Length = "0x120")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new object[]
		{
			typeof(Toggle),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "Format", MemberParameters = new object[]
		{
			typeof(string),
			typeof(object[])
		}, ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 12)]
		private void ValidateToggleIsInGroup(Toggle toggle)
		{
			throw null;
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x00002D82 File Offset: 0x00000F82
		[global::Cpp2ILInjected.Token(Token = "0x60004E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE898", Offset = "0x1FDE898", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new object[]
		{
			typeof(ToggleGroup),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "ValidateToggleIsInGroup", MemberParameters = new object[] { typeof(Toggle) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public void NotifyToggleOn(Toggle toggle, bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x00002D85 File Offset: 0x00000F85
		[global::Cpp2ILInjected.Token(Token = "0x60004E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE738", Offset = "0x1FDE738", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new object[]
		{
			typeof(ToggleGroup),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Remove", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void UnregisterToggle(Toggle toggle)
		{
			throw null;
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x00002D88 File Offset: 0x00000F88
		[global::Cpp2ILInjected.Token(Token = "0x60004EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE7C8", Offset = "0x1FDE7C8", Length = "0xD0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "SetToggleGroup", MemberParameters = new object[]
		{
			typeof(ToggleGroup),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Contains", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public void RegisterToggle(Toggle toggle)
		{
			throw null;
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00002D8B File Offset: 0x00000F8B
		[global::Cpp2ILInjected.Token(Token = "0x60004EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE0C4", Offset = "0x1FDE0C4", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "OnDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "Start", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "AnyTogglesOn", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "NotifyToggleOn", MemberParameters = new object[]
		{
			typeof(Toggle),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "ActiveToggles", ReturnType = typeof(IEnumerable<Toggle>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "GetFirstActiveToggle", ReturnType = typeof(Toggle))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 20)]
		public void EnsureValidState()
		{
			throw null;
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x00002D8E File Offset: 0x00000F8E
		[global::Cpp2ILInjected.Token(Token = "0x60004EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDE9BC", Offset = "0x1FDE9BC", Length = "0x138")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Predicate<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "Find", MemberParameters = new object[] { typeof(Predicate<object>) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public bool AnyTogglesOn()
		{
			throw null;
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x00002D91 File Offset: 0x00000F91
		[global::Cpp2ILInjected.Token(Token = "0x60004ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDED54", Offset = "0x1FDED54", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "GetFirstActiveToggle", ReturnType = typeof(Toggle))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
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
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public IEnumerable<Toggle> ActiveToggles()
		{
			throw null;
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x00002D94 File Offset: 0x00000F94
		[global::Cpp2ILInjected.Token(Token = "0x60004EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEE50", Offset = "0x1FDEE50", Length = "0x88")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(ToggleGroup), Member = "EnsureValidState", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ToggleGroup), Member = "ActiveToggles", ReturnType = typeof(IEnumerable<Toggle>))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "Count", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = typeof(int))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Enumerable), Member = "First", MemberTypeParameters = new object[] { "TSource" }, MemberParameters = new object[] { "System.Collections.Generic.IEnumerable`1<TSource>" }, ReturnType = "TSource")]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Toggle GetFirstActiveToggle()
		{
			throw null;
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x00002D97 File Offset: 0x00000F97
		[global::Cpp2ILInjected.Token(Token = "0x60004EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1FDEED8", Offset = "0x1FDEED8", Length = "0xE4")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsInvalidInstructions]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(List<object>), Member = "get_Item", MemberParameters = new object[] { typeof(int) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Toggle), Member = "Set", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void SetAllTogglesOff(bool sendCallback = true)
		{
			throw null;
		}

		// Token: 0x0400017C RID: 380
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000252")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private bool m_AllowSwitchOff;

		// Token: 0x0400017D RID: 381
		[global::Cpp2ILInjected.Token(Token = "0x4000253")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		protected List<Toggle> m_Toggles;

		// Token: 0x020000BA RID: 186
		[CompilerGenerated]
		[global::Cpp2ILInjected.Token(Token = "0x2000077")]
		[Serializable]
		private sealed class <>c
		{
			// Token: 0x060006C9 RID: 1737 RVA: 0x000033EB File Offset: 0x000015EB
			// Note: this type is marked as 'beforefieldinit'.
			[global::Cpp2ILInjected.Token(Token = "0x60004F0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDEFBC", Offset = "0x1FDEFBC", Length = "0x5C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			static <>c()
			{
				throw null;
			}

			// Token: 0x060006CA RID: 1738 RVA: 0x000033EE File Offset: 0x000015EE
			[global::Cpp2ILInjected.Token(Token = "0x60004F1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDF018", Offset = "0x1FDF018", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
			public <>c()
			{
				throw null;
			}

			// Token: 0x060006CB RID: 1739 RVA: 0x000033F1 File Offset: 0x000015F1
			[global::Cpp2ILInjected.Token(Token = "0x60004F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDF020", Offset = "0x1FDF020", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <AnyTogglesOn>b__13_0(Toggle x)
			{
				throw null;
			}

			// Token: 0x060006CC RID: 1740 RVA: 0x000033F4 File Offset: 0x000015F4
			[global::Cpp2ILInjected.Token(Token = "0x60004F3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1FDF028", Offset = "0x1FDF028", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			internal bool <ActiveToggles>b__14_0(Toggle x)
			{
				throw null;
			}

			// Token: 0x0400031F RID: 799
			[global::Cpp2ILInjected.Token(Token = "0x4000254")]
			public static readonly ToggleGroup.<>c <>9;

			// Token: 0x04000320 RID: 800
			[global::Cpp2ILInjected.Token(Token = "0x4000255")]
			public static Predicate<Toggle> <>9__13_0;

			// Token: 0x04000321 RID: 801
			[global::Cpp2ILInjected.Token(Token = "0x4000256")]
			public static Func<Toggle, bool> <>9__14_0;
		}
	}
}
