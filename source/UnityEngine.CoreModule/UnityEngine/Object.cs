using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using Unity.Collections;
using UnityEngine.Bindings;
using UnityEngine.Experimental.GlobalIllumination;
using UnityEngine.Internal;
using UnityEngine.Networking.PlayerConnection;
using UnityEngine.Rendering;
using UnityEngine.Scripting;
using UnityEngineInternal;

namespace UnityEngine
{
	// Token: 0x02000095 RID: 149
	[RequiredByNativeCode(GenerateProxy = true)]
	[NativeHeader("Runtime/GameCode/CloneObject.h")]
	[NativeHeader("Runtime/SceneManager/SceneManager.h")]
	[NativeHeader("Runtime/Export/Scripting/UnityEngineObject.bindings.h")]
	[global::Cpp2ILInjected.Token(Token = "0x20000A3")]
	[StructLayout(0)]
	public class Object
	{
		// Token: 0x060002D1 RID: 721 RVA: 0x000025DE File Offset: 0x000007DE
		[global::Cpp2ILInjected.Token(Token = "0x60002DF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A7A8", Offset = "0x1F7A7A8", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1.<>c", Member = "<Awake>b__14_0", MemberParameters = new object[] { "TComponent" }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "get_Instance", ReturnType = "TComponent")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "get_EnforceSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "get_IsTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "get_IsNotTheSingleton", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "Awake", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.SingletonMonoBehavior`1", Member = "OnDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DirectionalLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref PointLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref SpotLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref RectangleLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref DiscLight)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(LightmapperUtils), Member = "Extract", MemberParameters = new object[]
		{
			typeof(Light),
			typeof(ref Cookie)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Experimental.GlobalIllumination.Lightmapping.<>c", Member = "<.cctor>b__7_0", MemberParameters = new object[]
		{
			typeof(Light[]),
			typeof(NativeArray<LightDataGI>)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 15)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "ToInt64", ReturnType = typeof(long))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = ".ctor", MemberParameters = new object[] { typeof(long) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Explicit", MemberParameters = new object[] { typeof(IntPtr) }, ReturnType = typeof(void*))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 6)]
		public unsafe int GetInstanceID()
		{
			throw null;
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x000025E1 File Offset: 0x000007E1
		[global::Cpp2ILInjected.Token(Token = "0x60002E0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A904", Offset = "0x1F7A904", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetHashCode", ReturnType = typeof(int))]
		public override int GetHashCode()
		{
			throw null;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x000025E4 File Offset: 0x000007E4
		[global::Cpp2ILInjected.Token(Token = "0x60002E1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A90C", Offset = "0x1F7A90C", Length = "0xFC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		public override bool Equals(object other)
		{
			throw null;
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x000025E7 File Offset: 0x000007E7
		[global::Cpp2ILInjected.Token(Token = "0x60002E2")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AAA8", Offset = "0x1F7AAA8", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 62)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "CompareBaseObjects", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static implicit operator bool(Object exists)
		{
			throw null;
		}

		// Token: 0x060002D5 RID: 725 RVA: 0x000025EA File Offset: 0x000007EA
		[global::Cpp2ILInjected.Token(Token = "0x60002E3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AA08", Offset = "0x1F7AA08", Length = "0xA0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "op_Implicit", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "IsNativeObjectAlive", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static bool CompareBaseObjects(Object lhs, Object rhs)
		{
			throw null;
		}

		// Token: 0x060002D6 RID: 726 RVA: 0x000025ED File Offset: 0x000007ED
		[global::Cpp2ILInjected.Token(Token = "0x60002E4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AB0C", Offset = "0x1F7AB0C", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "CompareBaseObjects", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(IntPtr), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(IntPtr),
			typeof(IntPtr)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		private static bool IsNativeObjectAlive(Object o)
		{
			throw null;
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x000025F0 File Offset: 0x000007F0
		[global::Cpp2ILInjected.Token(Token = "0x60002E5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AB60", Offset = "0x1F7AB60", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		private IntPtr GetCachedPtr()
		{
			throw null;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002D8 RID: 728 RVA: 0x000025F3 File Offset: 0x000007F3
		// (set) Token: 0x060002D9 RID: 729 RVA: 0x000025F6 File Offset: 0x000007F6
		[global::Cpp2ILInjected.Token(Token = "0x170000AB")]
		public string name
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002E6")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F6E96C", Offset = "0x1F6E96C", Length = "0x74")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindAllInChildren", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(string),
				"System.Collections.Generic.List`1<Transform>"
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "GetChildByName", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(string)
			}, ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "FindInChildren", MemberParameters = new object[]
			{
				typeof(Transform),
				typeof(string)
			}, ReturnType = typeof(Transform))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "TransformExtensions", Member = "GetPath", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Content.ContentManager", Member = "CreateSoundEffect", MemberParameters = new object[] { typeof(object) }, ReturnType = typeof(object))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.Localization.LanguageManager", Member = "LoadFilesForCulture", MemberParameters = new object[] { "Terraria.Localization.GameCulture" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "SetVertexBufferData", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
			{
				"T[]",
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(int),
				typeof(MeshUpdateFlags)
			}, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "PrintErrorCantAccessIndices", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Mesh), Member = "RecalculateBounds", MemberParameters = new object[] { typeof(MeshUpdateFlags) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Texture), Member = "CreateNonReadableException", MemberParameters = new object[] { typeof(Texture) }, ReturnType = typeof(UnityException))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Image", Member = "GenerateTiledSprite", MemberParameters = new object[] { "UnityEngine.UI.VertexHelper" }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new object[]
			{
				typeof(Material),
				typeof(int),
				typeof(StencilOp),
				typeof(CompareFunction),
				typeof(ColorWriteMask),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.GUISkin", Member = "GetStyle", MemberParameters = new object[] { typeof(string) }, ReturnType = "UnityEngine.GUIStyle")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.TextGenerator", Member = "ValidatedSettings", MemberParameters = new object[] { "UnityEngine.TextGenerationSettings" }, ReturnType = "UnityEngine.TextGenerationSettings")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 20)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			get
			{
				throw null;
			}
			[global::Cpp2ILInjected.Token(Token = "0x60002E7")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7ABA4", Offset = "0x1F7ABA4", Length = "0x84")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.GeometryBufferInstance", Member = ".ctor", MemberParameters = new object[] { typeof(Transform) }, ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateDropdown", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.DefaultControls", Member = "CreateScrollView", MemberParameters = new object[] { "UnityEngine.UI.DefaultControls.Resources" }, ReturnType = typeof(GameObject))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "Show", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "AddItem", MemberParameters = new object[]
			{
				"UnityEngine.UI.Dropdown.OptionData",
				typeof(bool),
				"UnityEngine.UI.Dropdown.DropdownItem",
				"System.Collections.Generic.List`1<DropdownItem>"
			}, ReturnType = "UnityEngine.UI.Dropdown.DropdownItem")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_workerMesh", ReturnType = typeof(Mesh))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new object[]
			{
				typeof(Material),
				typeof(int),
				typeof(StencilOp),
				typeof(CompareFunction),
				typeof(ColorWriteMask),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 8)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
			set
			{
				throw null;
			}
		}

		// Token: 0x060002DA RID: 730 RVA: 0x000025F9 File Offset: 0x000007F9
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x60002E8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AC6C", Offset = "0x1F7AC6C", Length = "0x1B0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[]
		{
			"T",
			typeof(Vector3),
			typeof(Quaternion)
		}, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "CheckNullArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Internal_InstantiateSingle", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Vector3),
			typeof(Quaternion)
		}, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 13)]
		public static Object Instantiate(Object original, Vector3 position, Quaternion rotation)
		{
			throw null;
		}

		// Token: 0x060002DB RID: 731 RVA: 0x000025FC File Offset: 0x000007FC
		[TypeInferenceRule(TypeInferenceRules.TypeOfFirstArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x60002E9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AF00", Offset = "0x1F7AF00", Length = "0xF0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Singleton`1", Member = "Create", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "CheckNullArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 9)]
		public static Object Instantiate(Object original)
		{
			throw null;
		}

		// Token: 0x060002DC RID: 732 RVA: 0x000025FF File Offset: 0x000007FF
		[global::Cpp2ILInjected.Token(Token = "0x60002EA")]
		[global::Cpp2ILInjected.Address(RVA = "0x159408C", Offset = "0x159408C", Length = "0x134")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GameObjectExtensions", Member = "InstantiatePrefabAsChild", MemberParameters = new object[]
		{
			typeof(GameObject),
			typeof(GameObject)
		}, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateDropdownList", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(GameObject))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "CreateItem", MemberParameters = new object[] { "UnityEngine.UI.Dropdown.DropdownItem" }, ReturnType = "UnityEngine.UI.Dropdown.DropdownItem")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "CheckNullArgument", MemberParameters = new object[]
		{
			typeof(object),
			typeof(string)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Internal_CloneSingle", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 11)]
		public static T Instantiate<T>(T original) where T : Object
		{
			throw null;
		}

		// Token: 0x060002DD RID: 733 RVA: 0x00002602 File Offset: 0x00000802
		[global::Cpp2ILInjected.Token(Token = "0x60002EB")]
		[global::Cpp2ILInjected.Address(RVA = "0x15941C0", Offset = "0x15941C0", Length = "0x104")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerManager", Member = "CreatePlayer", MemberParameters = new object[] { "InControl.InputDevice" }, ReturnType = "MultiplayerWithBindingsExample.Player")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.PlayerManager", Member = "CreatePlayer", MemberParameters = new object[] { "InControl.InputDevice" }, ReturnType = "MultiplayerBasicExample.Player")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "Instantiate", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Vector3),
			typeof(Quaternion)
		}, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static T Instantiate<T>(T original, Vector3 position, Quaternion rotation) where T : Object
		{
			throw null;
		}

		// Token: 0x060002DE RID: 734
		[NativeMethod(Name = "Scripting::DestroyObjectFromScripting", IsFreeFunction = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002EC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B02C", Offset = "0x1F7B02C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void Destroy(Object obj, [DefaultValue("0.0F")] float t);

		// Token: 0x060002DF RID: 735 RVA: 0x00002605 File Offset: 0x00000805
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60002ED")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B078", Offset = "0x1F7B078", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "SoundManager", Member = "SetupChannels", MemberParameters = new object[] { typeof(int) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ScreenshotSetup", Member = "get_RenderTexture", ReturnType = typeof(RenderTexture))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "ScreenshotSetup", Member = "get_SaveTexture", ReturnType = typeof(Texture2D))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchSprite", Member = "Delete", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "DestroyBlocker", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Dropdown", Member = "DestroyDropdownList", MemberParameters = new object[] { typeof(GameObject) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "OnDestroy", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Misc", Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Misc", Member = "DestroyImmediate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerWithBindingsExample.PlayerManager", Member = "RemovePlayer", MemberParameters = new object[] { "MultiplayerWithBindingsExample.Player" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "MultiplayerBasicExample.PlayerManager", Member = "RemovePlayer", MemberParameters = new object[] { "MultiplayerBasicExample.Player" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 11)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void Destroy(Object obj)
		{
			throw null;
		}

		// Token: 0x060002E0 RID: 736
		[NativeMethod(Name = "Scripting::DestroyObjectFromScriptingImmediate", IsFreeFunction = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002EE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B0F0", Offset = "0x1F7B0F0", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void DestroyImmediate(Object obj, [DefaultValue("false")] bool allowDestroyingAssets);

		// Token: 0x060002E1 RID: 737 RVA: 0x00002608 File Offset: 0x00000808
		[ExcludeFromDocs]
		[global::Cpp2ILInjected.Token(Token = "0x60002EF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B134", Offset = "0x1F7B134", Length = "0x78")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "GUIMap", Member = "CleanupMapTargets", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer.MaterialPartition", Member = "DestroyMaterials", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Microsoft.Xna.Framework.Graphics.MaterialBuffer", Member = "DestroyMaterials", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "Terraria.GameContent.Liquid.LiquidRenderer", Member = "SetWaveMaskData", MemberParameters = new object[] { "Microsoft.Xna.Framework.Graphics.Texture2D&" }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.TouchManager", Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "OnDisable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Misc", Member = "Destroy", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Misc", Member = "DestroyImmediate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 9)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public static void DestroyImmediate(Object obj)
		{
			throw null;
		}

		// Token: 0x060002E2 RID: 738
		[FreeFunction("UnityEngineObjectBindings::FindObjectsOfType")]
		[TypeInferenceRule(TypeInferenceRules.ArrayOfTypeReferencedByFirstArgument)]
		[global::Cpp2ILInjected.Token(Token = "0x60002F0")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B1AC", Offset = "0x1F7B1AC", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "FindObjectsOfType", MemberTypeParameters = new object[] { "T" }, ReturnType = "T[]")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern Object[] FindObjectsOfType(Type type, bool includeInactive);

		// Token: 0x060002E3 RID: 739
		[FreeFunction("GetSceneManager().DontDestroyOnLoad", ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002F1")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B1F0", Offset = "0x1F7B1F0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "InControl.InControlManager", Member = "OnEnable", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		public static extern void DontDestroyOnLoad([NotNull("NullExceptionObject")] Object target);

		// Token: 0x170000AA RID: 170
		// (set) Token: 0x060002E4 RID: 740
		[global::Cpp2ILInjected.Token(Token = "0x170000AC")]
		public extern HideFlags hideFlags
		{
			[global::Cpp2ILInjected.Token(Token = "0x60002F2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F7B22C", Offset = "0x1F7B22C", Length = "0x44")]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PlayerConnection), Member = "CreateInstance", ReturnType = typeof(PlayerConnection))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.Graphic", Member = "get_workerMesh", ReturnType = typeof(Mesh))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.InputField", Member = "UpdateGeometry", ReturnType = typeof(void))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.UI.StencilMaterial", Member = "Add", MemberParameters = new object[]
			{
				typeof(Material),
				typeof(int),
				typeof(StencilOp),
				typeof(CompareFunction),
				typeof(ColorWriteMask),
				typeof(int),
				typeof(int)
			}, ReturnType = typeof(Material))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 4)]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			[MethodImpl(4096)]
			set;
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000260B File Offset: 0x0000080B
		[global::Cpp2ILInjected.Token(Token = "0x60002F3")]
		[global::Cpp2ILInjected.Address(RVA = "0x1593FE0", Offset = "0x1593FE0", Length = "0xAC")]
		[global::Cpp2ILInjected.CallAnalysis.DeduplicatedMethod]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "FindObjectsOfType", MemberParameters = new object[]
		{
			typeof(Type),
			typeof(bool)
		}, ReturnType = typeof(Object[]))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 5)]
		public static T[] FindObjectsOfType<T>() where T : Object
		{
			throw null;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000260E File Offset: 0x0000080E
		[global::Cpp2ILInjected.Token(Token = "0x60002F4")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AE1C", Offset = "0x1F7AE1C", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Vector3),
			typeof(Quaternion)
		}, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberParameters = new object[] { typeof(Object) }, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 3)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ArgumentException), Member = ".ctor", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		private static void CheckNullArgument(object arg, string message)
		{
			throw null;
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x00002611 File Offset: 0x00000811
		[global::Cpp2ILInjected.Token(Token = "0x60002F5")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B270", Offset = "0x1F7B270", Length = "0x74")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 4)]
		public override string ToString()
		{
			throw null;
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x00002614 File Offset: 0x00000814
		[global::Cpp2ILInjected.Token(Token = "0x60002F6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F72B40", Offset = "0x1F72B40", Length = "0x64")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 269)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "CompareBaseObjects", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator ==(Object x, Object y)
		{
			throw null;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x00002617 File Offset: 0x00000817
		[global::Cpp2ILInjected.Token(Token = "0x60002F7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B320", Offset = "0x1F7B320", Length = "0x70")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 289)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "CompareBaseObjects", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public static bool operator !=(Object x, Object y)
		{
			throw null;
		}

		// Token: 0x060002EA RID: 746
		[NativeMethod(Name = "Object::GetOffsetOfInstanceIdMember", IsFreeFunction = true, IsThreadSafe = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002F8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7A8DC", Offset = "0x1F7A8DC", Length = "0x28")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern int GetOffsetOfInstanceIDInCPlusPlusObject();

		// Token: 0x060002EB RID: 747
		[NativeMethod(Name = "CloneObject", IsFreeFunction = true, ThrowsException = true)]
		[global::Cpp2ILInjected.Token(Token = "0x60002F9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AFF0", Offset = "0x1F7AFF0", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberTypeParameters = new object[] { "T" }, MemberParameters = new object[] { "T" }, ReturnType = "T")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern Object Internal_CloneSingle([NotNull("NullExceptionObject")] Object data);

		// Token: 0x060002EC RID: 748 RVA: 0x0000261A File Offset: 0x0000081A
		[FreeFunction("InstantiateObject")]
		[global::Cpp2ILInjected.Token(Token = "0x60002FA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AE68", Offset = "0x1F7AE68", Length = "0x98")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Object), Member = "Instantiate", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Vector3),
			typeof(Quaternion)
		}, ReturnType = typeof(Object))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 3)]
		private static Object Internal_InstantiateSingle([NotNull("NullExceptionObject")] Object data, Vector3 pos, Quaternion rot)
		{
			throw null;
		}

		// Token: 0x060002ED RID: 749
		[FreeFunction("UnityEngineObjectBindings::ToString")]
		[global::Cpp2ILInjected.Token(Token = "0x60002FB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B2E4", Offset = "0x1F7B2E4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern string ToString(Object obj);

		// Token: 0x060002EE RID: 750
		[FreeFunction("UnityEngineObjectBindings::GetName")]
		[global::Cpp2ILInjected.Token(Token = "0x60002FC")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AB68", Offset = "0x1F7AB68", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern string GetName([NotNull("NullExceptionObject")] Object obj);

		// Token: 0x060002EF RID: 751
		[FreeFunction("UnityEngineObjectBindings::SetName")]
		[global::Cpp2ILInjected.Token(Token = "0x60002FD")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7AC28", Offset = "0x1F7AC28", Length = "0x44")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern void SetName([NotNull("NullExceptionObject")] Object obj, string name);

		// Token: 0x060002F0 RID: 752
		[VisibleToOtherModules]
		[FreeFunction("UnityEngineObjectBindings::FindObjectFromInstanceID")]
		[global::Cpp2ILInjected.Token(Token = "0x60002FE")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B3E4", Offset = "0x1F7B3E4", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RaycastHit2D", Member = "get_collider", ReturnType = "UnityEngine.Collider2D")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.RaycastHit", Member = "get_collider", ReturnType = "UnityEngine.Collider")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		internal static extern Object FindObjectFromInstanceID(int instanceID);

		// Token: 0x060002F1 RID: 753 RVA: 0x0000261D File Offset: 0x0000081D
		[global::Cpp2ILInjected.Token(Token = "0x60002FF")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F6D580", Offset = "0x1F6D580", Length = "0x8")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(Sprite), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = "UnityEngine.Audio.AudioMixerGroup", Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		public Object()
		{
			throw null;
		}

		// Token: 0x060002F2 RID: 754 RVA: 0x00002620 File Offset: 0x00000820
		// Note: this type is marked as 'beforefieldinit'.
		[global::Cpp2ILInjected.Token(Token = "0x6000300")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B420", Offset = "0x1F7B420", Length = "0x4C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 1)]
		static Object()
		{
			throw null;
		}

		// Token: 0x060002F3 RID: 755
		[global::Cpp2ILInjected.Token(Token = "0x6000301")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F7B390", Offset = "0x1F7B390", Length = "0x54")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		[MethodImpl(4096)]
		private static extern Object Internal_InstantiateSingle_Injected(Object data, ref Vector3 pos, ref Quaternion rot);

		// Token: 0x0400032D RID: 813
		[global::Cpp2ILInjected.Token(Token = "0x400035D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private IntPtr m_CachedPtr;

		// Token: 0x0400032E RID: 814
		[global::Cpp2ILInjected.Token(Token = "0x400035E")]
		internal static int OffsetOfInstanceIDInCPlusPlusObject;

		// Token: 0x0400032F RID: 815
		[global::Cpp2ILInjected.Token(Token = "0x400035F")]
		private const string objectIsNullMessage = "The Object you want to instantiate is null.";

		// Token: 0x04000330 RID: 816
		[global::Cpp2ILInjected.Token(Token = "0x4000360")]
		private const string cloneDestroyedMessage = "Instantiate failed because the clone was destroyed during creation. This can happen if DestroyImmediate is called in MonoBehaviour.Awake.";
	}
}
