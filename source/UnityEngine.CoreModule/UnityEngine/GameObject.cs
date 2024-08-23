using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Bindings;
using UnityEngine.Internal;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000092 RID: 146
	[ExcludeFromPreset]
	[NativeHeader("Runtime/Export/Scripting/GameObject.bindings.h")]
	[UsedByNativeCode]
	[global::Cpp2ILInjected.Token(Token = "0x20000A0")]
	public sealed class GameObject : Object
	{
		// Token: 0x060002AC RID: 684 RVA: 0x0000259F File Offset: 0x0000079F
		[global::Cpp2ILInjected.Token(Token = "0x60002BA")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A688", Offset = "0x158A688", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 92)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentFastPath", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public T GetComponent<T>()
		{
			throw null;
		}

		// Token: 0x060002AD RID: 685
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentFromType", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002BB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A090", Offset = "0x1F7A090", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern Component GetComponent(Type type);

		// Token: 0x060002AE RID: 686
		[FreeFunction(Name = "GameObjectBindings::GetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		[NativeWritableSelf]
		[global::Cpp2ILInjected.Token(Token = "0x60002BC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A0D4", Offset = "0x1F7A0D4", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal extern void GetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x060002AF RID: 687
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentInChildren", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002BD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A128", Offset = "0x1F7A128", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(bool) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern Component GetComponentInChildren(Type type, bool includeInactive);

		// Token: 0x060002B0 RID: 688 RVA: 0x000025A2 File Offset: 0x000007A2
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60002BE")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A720", Offset = "0x158A720", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public T GetComponentInChildren<T>()
		{
			throw null;
		}

		// Token: 0x060002B1 RID: 689 RVA: 0x000025A5 File Offset: 0x000007A5
		[global::Cpp2ILInjected.Token(Token = "0x60002BF")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A734", Offset = "0x158A734", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentInChildren", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T GetComponentInChildren<T>([DefaultValue("false")] bool includeInactive)
		{
			throw null;
		}

		// Token: 0x060002B2 RID: 690
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[FreeFunction(Name = "GameObjectBindings::GetComponentInParent", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002C0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A17C", Offset = "0x1F7A17C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponentInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(bool) }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern Component GetComponentInParent(Type type, bool includeInactive);

		// Token: 0x060002B3 RID: 691 RVA: 0x000025A8 File Offset: 0x000007A8
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60002C1")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A800", Offset = "0x158A800", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.BaseInputModule", Member = "HandlePointerExitAndEnter", MemberParameters = new object[]
		{
			"UnityEngine.EventSystems.PointerEventData",
			typeof(GameObject)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public T GetComponentInParent<T>()
		{
			throw null;
		}

		// Token: 0x060002B4 RID: 692 RVA: 0x000025AB File Offset: 0x000007AB
		[global::Cpp2ILInjected.Token(Token = "0x60002C2")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A814", Offset = "0x158A814", Length = "0xCC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentInParent", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T GetComponentInParent<T>([DefaultValue("false")] bool includeInactive)
		{
			throw null;
		}

		// Token: 0x060002B5 RID: 693
		[FreeFunction(Name = "GameObjectBindings::GetComponentsInternal", HasExplicitThis = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002C3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A1D0", Offset = "0x1F7A1D0", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponents", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "System.Collections.Generic.List`1<T>" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(bool) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponentsInChildren", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(bool),
			"System.Collections.Generic.List`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(bool),
			"System.Collections.Generic.List`1<T>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "GetComponentsInParent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { typeof(bool) }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 6)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Array GetComponentsInternal(Type type, bool useSearchTypeAsArrayReturnType, bool recursive, bool includeInactive, bool reverse, object resultList);

		// Token: 0x060002B6 RID: 694 RVA: 0x000025AE File Offset: 0x000007AE
		[global::Cpp2ILInjected.Token(Token = "0x60002C4")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A8E0", Offset = "0x158A8E0", Length = "0xD8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = ".ctor", MemberParameters = new object[]
		{
			typeof(int),
			"PlatformUser"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T[] GetComponents<T>()
		{
			throw null;
		}

		// Token: 0x060002B7 RID: 695 RVA: 0x000025B1 File Offset: 0x000007B1
		[global::Cpp2ILInjected.Token(Token = "0x60002C5")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A9B8", Offset = "0x158A9B8", Length = "0x94")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.ExecuteEvents", Member = "GetEventList", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			typeof(GameObject),
			"System.Collections.Generic.IList`1<IEventSystemHandler>"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetComponents<T>(List<T> results)
		{
			throw null;
		}

		// Token: 0x060002B8 RID: 696 RVA: 0x000025B4 File Offset: 0x000007B4
		[global::Cpp2ILInjected.Token(Token = "0x60002C6")]
		[global::Cpp2ILInjected.Address(RVA = "0x158AA60", Offset = "0x158AA60", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T[] GetComponentsInChildren<T>(bool includeInactive)
		{
			throw null;
		}

		// Token: 0x060002B9 RID: 697 RVA: 0x000025B7 File Offset: 0x000007B7
		[global::Cpp2ILInjected.Token(Token = "0x60002C7")]
		[global::Cpp2ILInjected.Address(RVA = "0x158AB3C", Offset = "0x158AB3C", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetComponentsInChildren<T>(bool includeInactive, List<T> results)
		{
			throw null;
		}

		// Token: 0x060002BA RID: 698 RVA: 0x000025BA File Offset: 0x000007BA
		[global::Cpp2ILInjected.Token(Token = "0x60002C8")]
		[global::Cpp2ILInjected.Address(RVA = "0x158AA4C", Offset = "0x158AA4C", Length = "0x14")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		public T[] GetComponentsInChildren<T>()
		{
			throw null;
		}

		// Token: 0x060002BB RID: 699 RVA: 0x000025BD File Offset: 0x000007BD
		[global::Cpp2ILInjected.Token(Token = "0x60002C9")]
		[global::Cpp2ILInjected.Address(RVA = "0x158ACB8", Offset = "0x158ACB8", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "CacheCanvas", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.MaskUtilities", Member = "GetRectMaskForClippable", MemberParameters = new object[] { "UnityEngine.UI.IClippable" }, ReturnType = "UnityEngine.UI.RectMask2D")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.RectMask2D", Member = "get_Canvas", ReturnType = "UnityEngine.Canvas")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public void GetComponentsInParent<T>(bool includeInactive, List<T> results)
		{
			throw null;
		}

		// Token: 0x060002BC RID: 700 RVA: 0x000025C0 File Offset: 0x000007C0
		[global::Cpp2ILInjected.Token(Token = "0x60002CA")]
		[global::Cpp2ILInjected.Address(RVA = "0x158ABDC", Offset = "0x158ABDC", Length = "0xDC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "GetComponentsInternal", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(bool),
			typeof(object)
		}, ReturnType = typeof(Array))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public T[] GetComponentsInParent<T>(bool includeInactive)
		{
			throw null;
		}

		// Token: 0x060002BD RID: 701 RVA: 0x000025C3 File Offset: 0x000007C3
		[global::Cpp2ILInjected.Token(Token = "0x60002CB")]
		[global::Cpp2ILInjected.Address(RVA = "0x158AD58", Offset = "0x158AD58", Length = "0xA8")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "TryGetComponentFastPath", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(IntPtr)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public bool TryGetComponent<T>(out T component)
		{
			throw null;
		}

		// Token: 0x060002BE RID: 702
		[FreeFunction(Name = "GameObjectBindings::TryGetComponentFastPath", HasExplicitThis = true, ThrowsException = true)]
		[NativeWritableSelf]
		[global::Cpp2ILInjected.Token(Token = "0x60002CC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A254", Offset = "0x1F7A254", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "TryGetComponent", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T&" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal extern void TryGetComponentFastPath(Type type, IntPtr oneFurtherThanResultValue);

		// Token: 0x060002BF RID: 703
		[FreeFunction(Name = "MonoAddComponentWithType", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002CD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A2A8", Offset = "0x1F7A2A8", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private extern Component Internal_AddComponentWithType(Type componentType);

		// Token: 0x060002C0 RID: 704 RVA: 0x000025C6 File Offset: 0x000007C6
		[TypeInferenceRule(TypeInferenceRules.TypeReferencedByFirstArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x60002CE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A2EC", Offset = "0x1F7A2EC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(GameObject), Member = "AddComponent", MemberTypeParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public Component AddComponent(Type componentType)
		{
			throw null;
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x000025C9 File Offset: 0x000007C9
		[global::Cpp2ILInjected.Token(Token = "0x60002CF")]
		[global::Cpp2ILInjected.Address(RVA = "0x158A59C", Offset = "0x158A59C", Length = "0xEC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Alert", Member = "GetAlertDelayObject", ReturnType = "AlertDelayer")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "SetupChannels", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteRenderer", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(Sprite),
			typeof(int)
		}, ReturnType = typeof(SpriteRenderer))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_canvasRenderer", ReturnType = "UnityEngine.CanvasRenderer")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.BaseInputModule", Member = "get_input", ReturnType = "UnityEngine.EventSystems.BaseInput")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 14)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(GameObject), Member = "AddComponent", MemberParameters = new object[] { typeof(Type) }, ReturnType = typeof(Component))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 7)]
		public T AddComponent<T>() where T : Component
		{
			throw null;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002C2 RID: 706
		[global::Cpp2ILInjected.Token(Token = "0x170000A5")]
		public extern Transform transform
		{
			[FreeFunction("GameObjectBindings::GetTransform", HasExplicitThis = true)]
			[global::Cpp2ILInjected.Token(Token = "0x60002D0")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A330", Offset = "0x1F7A330", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 48)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002C3 RID: 707
		// (set) Token: 0x060002C4 RID: 708
		[global::Cpp2ILInjected.Token(Token = "0x170000A6")]
		public extern int layer
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002D1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A36C", Offset = "0x1F7A36C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GameObjectExtensions", Member = "InstantiatePrefabAsChild", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(GameObject)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteGameObject", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Transform)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.Utility", Member = "GameObjectIsCulledOnCurrentCamera", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetParentAndAlign", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(GameObject)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 5)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
			[global::Cpp2ILInjected.Token(Token = "0x60002D2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A3A8", Offset = "0x1F7A3A8", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "SetLayer", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteGameObject", MemberParameters = new object[]
			{
				typeof(string),
				typeof(Transform)
			}, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "SetLayerRecursively", MemberParameters = new object[]
			{
				typeof(GameObject),
				typeof(int)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x060002C5 RID: 709
		[NativeMethod(Name = "SetSelfActive")]
		[global::Cpp2ILInjected.Token(Token = "0x60002D3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A3EC", Offset = "0x1F7A3EC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UserManagement", Member = "SwitchPrimaryUser", MemberParameters = new object[] { "PlatformUser" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UserManagement", Member = "AddUser", MemberParameters = new object[] { "Controller.ControllerDevice", "PlatformUser" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UserManagement", Member = "LocalUserQuit", MemberParameters = new object[] { "LocalUser" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAWorldCameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetBatchInstance", MemberParameters = new object[] { typeof(int) }, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"VertexData[]",
			"System.Int16[]",
			typeof(int),
			typeof(int),
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "GetInstance", MemberParameters = new object[]
		{
			"System.Collections.Generic.List`1<Vector3>",
			"System.Collections.Generic.List`1<Vector2>",
			"System.Collections.Generic.List`1<Vector4>",
			"System.Collections.Generic.List`1<Color32>",
			"System.Collections.Generic.List`1<Int32>",
			typeof(int)
		}, ReturnType = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "FinaliseInstances", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Awake", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "SetupTemplate", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AddItem", MemberParameters = new object[]
		{
			"UnityEngine.UI.Dropdown.OptionData",
			typeof(bool),
			"UnityEngine.UI.Dropdown.DropdownItem",
			"System.Collections.Generic.List`1<DropdownItem>"
		}, ReturnType = "UnityEngine.UI.Dropdown.DropdownItem")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateOneScrollbarVisibility", MemberParameters = new object[]
		{
			typeof(bool),
			typeof(bool),
			"UnityEngine.UI.ScrollRect.ScrollbarVisibility",
			"UnityEngine.UI.Scrollbar"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 23)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void SetActive(bool value);

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002C6 RID: 710
		[global::Cpp2ILInjected.Token(Token = "0x170000A7")]
		public extern bool activeSelf
		{
			[NativeMethod(Name = "IsSelfActive")]
			[global::Cpp2ILInjected.Token(Token = "0x60002D4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A430", Offset = "0x1F7A430", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "XNAWorldCameraSettings", Member = "ApplyCamera", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.ScrollRect", Member = "UpdateOneScrollbarVisibility", MemberParameters = new object[]
			{
				typeof(bool),
				typeof(bool),
				"UnityEngine.UI.ScrollRect.ScrollbarVisibility",
				"UnityEngine.UI.Scrollbar"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002C7 RID: 711
		[global::Cpp2ILInjected.Token(Token = "0x170000A8")]
		public extern bool activeInHierarchy
		{
			[NativeMethod(Name = "IsActive")]
			[global::Cpp2ILInjected.Token(Token = "0x60002D5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A46C", Offset = "0x1F7A46C", Length = "0x3C")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlInputModule", Member = "ShouldActivateModule", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "SubmitControlStates", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "CommitControlStates", MemberParameters = new object[]
			{
				typeof(ulong),
				typeof(float)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "SendTouchBegan", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "SendTouchMoved", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "SendTouchEnded", MemberParameters = new object[] { "InControl.Touch" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnRectTransformDimensionsChange", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.LayoutGroup", Member = "CalculateLayoutInputHorizontal", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Selectable", Member = "DoStateTransition", MemberParameters = new object[]
			{
				"UnityEngine.UI.Selectable.SelectionState",
				typeof(bool)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.CoroutineTween.TweenRunner`1", Member = "StartTween", MemberParameters = new object[] { "T" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.ExecuteEvents", Member = "GetEventList", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				typeof(GameObject),
				"System.Collections.Generic.IList`1<IEventSystemHandler>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.EventSystems.BaseInputModule", Member = "ShouldActivateModule", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 12)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			get;
		}

		// Token: 0x060002C8 RID: 712
		[FreeFunction(Name = "Scripting::SendScriptingMessage", HasExplicitThis = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002D6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A4A8", Offset = "0x1F7A4A8", Length = "0x5C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents.HitInfo", Member = "SendMessage", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.SendMouseEvents", Member = "SendEvents", MemberParameters = new object[]
		{
			typeof(int),
			"UnityEngine.SendMouseEvents.HitInfo"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public extern void SendMessage(string methodName, [DefaultValue("null")] object value, [DefaultValue("SendMessageOptions.RequireReceiver")] SendMessageOptions options);

		// Token: 0x060002C9 RID: 713 RVA: 0x000025CC File Offset: 0x000007CC
		[global::Cpp2ILInjected.Token(Token = "0x60002D7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A504", Offset = "0x1F7A504", Length = "0x90")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Alert", Member = "GetAlertDelayObject", ReturnType = "AlertDelayer")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "Init", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstanceList", Member = "SetupParent", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "CreateSpriteGameObject", MemberParameters = new object[]
		{
			typeof(string),
			typeof(Transform)
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateBlocker", MemberParameters = new object[] { "UnityEngine.Canvas" }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 7)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GameObject(string name)
		{
			throw null;
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000025CF File Offset: 0x000007CF
		[global::Cpp2ILInjected.Token(Token = "0x60002D8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A5D8", Offset = "0x1F7A5D8", Length = "0x84")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GameObject()
		{
			throw null;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x000025D2 File Offset: 0x000007D2
		[global::Cpp2ILInjected.Token(Token = "0x60002D9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A65C", Offset = "0x1F7A65C", Length = "0xF8")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls.DefaultRuntimeFactory", Member = "CreateGameObject", MemberParameters = new object[]
		{
			typeof(string),
			"System.Type[]"
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public GameObject(string name, params Type[] components)
		{
			throw null;
		}

		// Token: 0x060002CC RID: 716
		[FreeFunction(Name = "GameObjectBindings::Internal_CreateGameObject")]
		[global::Cpp2ILInjected.Token(Token = "0x60002DA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A594", Offset = "0x1F7A594", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void Internal_CreateGameObject([Writable] GameObject self, string name);

		// Token: 0x060002CD RID: 717
		[FreeFunction(Name = "GameObjectBindings::Find")]
		[global::Cpp2ILInjected.Token(Token = "0x60002DB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A754", Offset = "0x1F7A754", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransactionButtonStyleDefinitions", Member = "GetDefinition", MemberParameters = new object[] { typeof(string) }, ReturnType = "TransactionButtonStyle_Definition")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "LocalUser", Member = "GetCamera", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(Camera))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "DistortionRenderTargetManager", Member = "get_Instance", ReturnType = "DistortionRenderTargetManager")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "WaterRenderTargetManager", Member = "get_Instance", ReturnType = "WaterRenderTargetManager")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern GameObject Find(string name);

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002CE RID: 718 RVA: 0x000025D5 File Offset: 0x000007D5
		[global::Cpp2ILInjected.Token(Token = "0x170000A9")]
		public GameObject gameObject
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002DC")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7A790", Offset = "0x1F7A790", Length = "0x4")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "SetupChannels", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
			get
			{
				throw null;
			}
		}
	}
}
