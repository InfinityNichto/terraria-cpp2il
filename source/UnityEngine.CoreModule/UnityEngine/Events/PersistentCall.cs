using System;
using System.Reflection;
using Cpp2ILInjected;
using Cpp2ILInjected.CallAnalysis;
using UnityEngine.Serialization;

namespace UnityEngine.Events
{
	[global::Cpp2ILInjected.Token(Token = "0x2000164")]
	[Serializable]
	internal class PersistentCall : ISerializationCallbackReceiver
	{
		[global::Cpp2ILInjected.Token(Token = "0x1700015B")]
		public Object target
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A1")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90C78", Offset = "0x1F90C78", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700015C")]
		public string targetAssemblyTypeName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A2")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90C80", Offset = "0x1F90C80", Length = "0xA0")]
			[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentCall), Member = "IsValid", ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new object[] { typeof(PersistentCall) }, ReturnType = typeof(MethodInfo))]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 2)]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
			{
				typeof(Object),
				typeof(Object)
			}, ReturnType = typeof(bool))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
			[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
			[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700015D")]
		public string methodName
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A3")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90D20", Offset = "0x1F90D20", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700015E")]
		public PersistentListenerMode mode
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A4")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90D28", Offset = "0x1F90D28", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x1700015F")]
		public ArgumentCache arguments
		{
			[global::Cpp2ILInjected.Token(Token = "0x60006A5")]
			[global::Cpp2ILInjected.Address(RVA = "0x1F90D30", Offset = "0x1F90D30", Length = "0x8")]
			[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
			get
			{
				throw null;
			}
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A6")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90D38", Offset = "0x1F90D38", Length = "0x3C")]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(InvokableCallList),
			typeof(UnityEventBase)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentCall), Member = "get_targetAssemblyTypeName", ReturnType = typeof(string))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		public bool IsValid()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A7")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F90D74", Offset = "0x1F90D74", Length = "0x2BC")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentCallGroup), Member = "Initialize", MemberParameters = new object[]
		{
			typeof(InvokableCallList),
			typeof(UnityEventBase)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventBase), Member = "FindMethod", MemberParameters = new object[] { typeof(PersistentCall) }, ReturnType = typeof(MethodInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(MethodBase), Member = "get_IsStatic", ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Equality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(InvokableCall), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(object),
			typeof(MethodInfo)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(PersistentCall), Member = "GetObjectCall", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(MethodInfo),
			typeof(ArgumentCache)
		}, ReturnType = typeof(BaseInvokableCall))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedInvokableCall<int>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(MethodInfo),
			typeof(int)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedInvokableCall<float>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(MethodInfo),
			typeof(float)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedInvokableCall<object>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(MethodInfo),
			typeof(object)
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(CachedInvokableCall<>), Member = ".ctor", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(MethodInfo),
			"T"
		}, ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 18)]
		public BaseInvokableCall GetRuntimeCall(UnityEventBase theEvent)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A8")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F911F0", Offset = "0x1F911F0", Length = "0x3C0")]
		[global::Cpp2ILInjected.CallAnalysis.ContainsUnimplementedInstructions]
		[global::Cpp2ILInjected.CallAnalysis.CalledBy(Type = typeof(PersistentCall), Member = "GetRuntimeCall", MemberParameters = new object[] { typeof(UnityEventBase) }, ReturnType = typeof(BaseInvokableCall))]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 1)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetTypeFromHandle", MemberParameters = new object[] { typeof(RuntimeTypeHandle) }, ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(string), Member = "IsNullOrEmpty", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Type), Member = "GetConstructor", MemberParameters = new object[] { typeof(Type[]) }, ReturnType = typeof(ConstructorInfo))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(Object), Member = "op_Inequality", MemberParameters = new object[]
		{
			typeof(Object),
			typeof(Object)
		}, ReturnType = typeof(bool))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = "GetType", ReturnType = typeof(Type))]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(ConstructorInfo), Member = "Invoke", MemberParameters = new object[] { typeof(object[]) }, ReturnType = typeof(object))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 28)]
		private static BaseInvokableCall GetObjectCall(Object target, MethodInfo method, ArgumentCache arguments)
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006A9")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F915B0", Offset = "0x1F915B0", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public void OnBeforeSerialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006AA")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F915CC", Offset = "0x1F915CC", Length = "0x1C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(UnityEventTools), Member = "TidyAssemblyTypeName", MemberParameters = new object[] { typeof(string) }, ReturnType = typeof(string))]
		public void OnAfterDeserialize()
		{
			throw null;
		}

		[global::Cpp2ILInjected.Token(Token = "0x60006AB")]
		[global::Cpp2ILInjected.Address(RVA = "0x1F915E8", Offset = "0x1F915E8", Length = "0x6C")]
		[global::Cpp2ILInjected.CallAnalysis.CallerCount(Count = 0)]
		[global::Cpp2ILInjected.CallAnalysis.Calls(Type = typeof(object), Member = ".ctor", ReturnType = typeof(void))]
		[global::Cpp2ILInjected.CallAnalysis.CallsUnknownMethods(Count = 2)]
		public PersistentCall()
		{
			throw null;
		}

		[SerializeField]
		[FormerlySerializedAs("instance")]
		[global::Cpp2ILInjected.Token(Token = "0x4000658")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x10")]
		private Object m_Target;

		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x4000659")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x18")]
		private string m_TargetAssemblyTypeName;

		[FormerlySerializedAs("methodName")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400065A")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x20")]
		private string m_MethodName;

		[FormerlySerializedAs("mode")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400065B")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x28")]
		private PersistentListenerMode m_Mode;

		[FormerlySerializedAs("arguments")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400065C")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x30")]
		private ArgumentCache m_Arguments;

		[FormerlySerializedAs("m_Enabled")]
		[FormerlySerializedAs("enabled")]
		[SerializeField]
		[global::Cpp2ILInjected.Token(Token = "0x400065D")]
		[global::Cpp2ILInjected.FieldOffset(Offset = "0x38")]
		private UnityEventCallState m_CallState;
	}
}
